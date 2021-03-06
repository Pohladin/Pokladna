﻿using Newtonsoft.Json.Schema;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Pokladnaa
{
    public class SqlRepos : IRepos
    {
        private string connString = @"Data Source=DOMÁLES\SQLEXPRESS;Initial Catalog=pokladna;Integrated Security=True";


        //ddd
        //commit

        public void VytvorTestData(List<PokladniZaznam> vychoziZaznamy)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connString))
            {
                string dotaz = "DROP TABLE IF EXISTS  [dbo].[PokladniZaznamy]; " +
                    "CREATE TABLE [dbo].[PokladniZaznamy] " +
                 "(" +
                 "[IdPokladniZaznam] INT NOT NULL PRIMARY KEY IDENTITY(1,1), " +
                 "[Cislo] INT NOT NULL,  " +
                 "[Datum] DATETIME NOT NULL, " +
                 "[Popis] VARCHAR(250) NOT NULL, " +
                 "[Castka] FLOAT NOT NULL, " +
                 "[Zustatek] FLOAT NOT NULL, " +
                 "[Poznamka] VARCHAR(250) NOT NULL" +
                 ");";

                foreach(var z in vychoziZaznamy)
                {
                    dotaz += $"Insert into PokladniZaznamy(Cislo        , Datum     , Popis         , Castka        , Zustatek      , Poznamka) " +
                                                                            $"values({z.Cislo}, '{z.Datum.ToString("yyyyMMdd")}', '{z.Popis}', {z.Castka}, {z.Zustatek}, '{z.Poznamka}'   )";
                }


                using (SqlCommand sqlCommand = new SqlCommand(dotaz, sqlConnection))
                {
                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                }
            }
        }
        public List<PokladniZaznam> NactiMesic(int rok, int mesic)
        {
            List<PokladniZaznam> result = new List<PokladniZaznam>();
            using (SqlConnection sqlConnection = new SqlConnection(connString))
            {
                string dotaz = $"select * from PokladniZaznamy where year(Datum)={rok} and MONTH(Datum)={mesic} order by Datum";
                using (SqlCommand sqlCommand = new SqlCommand(dotaz, sqlConnection))
                {
                    sqlConnection.Open();
                    using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            result.Add(new PokladniZaznam(Convert.ToInt32(dataReader["IdPokladniZaznam"])
                                                                                     , Convert.ToInt32(dataReader["Cislo"])
                                                                                     , Convert.ToDateTime(dataReader["Datum"])
                                                                                     , dataReader["Popis"].ToString()
                                                                                     , Convert.ToDouble(dataReader["Castka"])
                                                                                     , Convert.ToDouble(dataReader["Zustatek"])
                                                                                     , dataReader["Poznamka"].ToString()));
                        }
                    }
                    sqlConnection.Close();
                }

            }
            return result;
        }

        public List<PokladniZaznam> NactiVse()
        {
            List<PokladniZaznam> result = new List<PokladniZaznam>();
            using (SqlConnection sqlConnection = new SqlConnection(connString))
            {
                using (SqlCommand sqlCommand = new SqlCommand("select * from PokladniZaznamy", sqlConnection))
                {
                    sqlConnection.Open();
                    using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            result.Add(new PokladniZaznam(Convert.ToInt32(dataReader["IdPokladniZaznam"])
                                                                                     , Convert.ToInt32(dataReader["Cislo"])
                                                                                     , Convert.ToDateTime(dataReader["Datum"])
                                                                                     , dataReader["Popis"].ToString()
                                                                                     , Convert.ToDouble(dataReader["Castka"])
                                                                                     , Convert.ToDouble(dataReader["Zustatek"])
                                                                                     , dataReader["Poznamka"].ToString()));
                        }
                    }
                    sqlConnection.Close();
                }
                
            }
            return result;
        }

        public PokladniZaznam NactiZaznam(int idPokladniZaznam)
        {
            throw new NotImplementedException();
        }

        public void SmazZaznam(PokladniZaznam pokladniZaznam)
        {
            throw new NotImplementedException();
        }

        public void UpravZaznam(PokladniZaznam pokladniZaznam)
        {
            throw new NotImplementedException();
        }

        public PokladniZaznam VytvorZaznam(PokladniZaznam pokladniZaznam)
        {
            PokladniZaznam result = pokladniZaznam;
            PokladniZaznam z = pokladniZaznam;
            using (SqlConnection sqlConnection = new SqlConnection(connString))
            {
                string dotaz = $"Insert into PokladniZaznamy(Cislo, Datum, Popis, Castka, Zustatek, Poznamka) " +
                                                                            $"values({z.Cislo}, '{z.Datum.ToString("yyyyMMdd")}', '{z.Popis}', {z.Castka}, {z.Zustatek}, '{z.Poznamka}'   )";
                using (SqlCommand sqlCommand = new SqlCommand(dotaz, sqlConnection))
                {
                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                }

            }
            return result;
        }
    }
}
