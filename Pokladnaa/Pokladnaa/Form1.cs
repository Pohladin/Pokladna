using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokladnaa
{
    public partial class Form1 : Form
    {
        List<PokladniZaznam> pokladna;
        IRepos repositar;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            JsonRepos jsonRepos = new JsonRepos("data.json");
            //jsonRepos.VytvorTestData();
            repositar = jsonRepos;

            
            cBoxRok.SelectedIndex = cBoxRok.Items.IndexOf(DateTime.Now.Year.ToString());
            cBoxMesic.SelectedIndex = DateTime.Now.Month - 1;

            
            // repositar = new SqlRepos();
            // repositar = new XmlRepos();
            //   pokladna = repositar.NactiVse();
            // foreach (var p in pokladna)
            //   {
            //     lvData.Items.Add(p.DoLvItem());
            //   }
        }

        private void cBoxRok_SelectedIndexChanged(object sender, EventArgs e)
        {
            NactiAktMesic();
        }

        private void NactiAktMesic()
        {
            if (cBoxRok.SelectedIndex >= 0 && cBoxMesic.SelectedIndex >= 0)
            {
                pokladna = repositar.NactiMesic(int.Parse(cBoxRok.SelectedItem.ToString()), cBoxMesic.SelectedIndex + 1);
                lvData.Items.Clear();
                foreach (var p in pokladna)
                {
                    lvData.Items.Add(p.DoLvItem());
                }
            }
        }




        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtCisloDokladu_TextChanged(object sender, EventArgs e)
        {
            btnUlozit.Enabled = txtCisloDokladu.Text != "";
        }

        private void txtPopis_TextChanged(object sender, EventArgs e)
        {
            btnUlozitJakoNovy.Enabled = txtPopis.Text.Trim() != "" && numericCastka.Value != 0;
        }

        private void numericCastka_ValueChanged(object sender, EventArgs e)
        {
            btnUlozitJakoNovy.Enabled = txtPopis.Text.Trim() != "" && numericCastka.Value != 0;
        }

        private void btnUlozitJakoNovy_Click(object sender, EventArgs e)
        {
            PokladniZaznam novyZaznam = new PokladniZaznam(dtpDatum.Value, txtPopis.Text, (double)numericCastka.Value, txtPoznamka.Text);
            repositar.VytvorZaznam(novyZaznam);
            NactiAktMesic();
            txtPopis.Text = "";
            numericCastka.Value = 0;
            txtPoznamka.Text = "";
        }
    }
}
