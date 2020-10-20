namespace Pokladnaa
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.gBoxObdobí = new System.Windows.Forms.GroupBox();
            this.cBoxMesic = new System.Windows.Forms.ComboBox();
            this.cBoxRok = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lvData = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numericCastka = new System.Windows.Forms.NumericUpDown();
            this.txtCisloDokladu = new System.Windows.Forms.TextBox();
            this.txtPopis = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPoznamka = new System.Windows.Forms.TextBox();
            this.btnUlozit = new System.Windows.Forms.Button();
            this.btnUlozitJakoNovy = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.gBoxObdobí.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCastka)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.gBoxObdobí);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(794, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(281, 542);
            this.panel1.TabIndex = 0;
            // 
            // gBoxObdobí
            // 
            this.gBoxObdobí.Controls.Add(this.cBoxMesic);
            this.gBoxObdobí.Controls.Add(this.cBoxRok);
            this.gBoxObdobí.Controls.Add(this.label2);
            this.gBoxObdobí.Controls.Add(this.label1);
            this.gBoxObdobí.Location = new System.Drawing.Point(0, 0);
            this.gBoxObdobí.Name = "gBoxObdobí";
            this.gBoxObdobí.Size = new System.Drawing.Size(276, 100);
            this.gBoxObdobí.TabIndex = 0;
            this.gBoxObdobí.TabStop = false;
            this.gBoxObdobí.Text = "Účetní období";
            // 
            // cBoxMesic
            // 
            this.cBoxMesic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxMesic.FormattingEnabled = true;
            this.cBoxMesic.Items.AddRange(new object[] {
            "Leden",
            "Únor",
            "Březen",
            "Duben",
            "Květen",
            "Červen",
            "Červemec",
            "Srpen",
            "Září",
            "Říjen",
            "Listopad",
            "Prosinec"});
            this.cBoxMesic.Location = new System.Drawing.Point(68, 48);
            this.cBoxMesic.Name = "cBoxMesic";
            this.cBoxMesic.Size = new System.Drawing.Size(208, 21);
            this.cBoxMesic.TabIndex = 3;
            this.cBoxMesic.SelectedIndexChanged += new System.EventHandler(this.cBoxRok_SelectedIndexChanged);
            // 
            // cBoxRok
            // 
            this.cBoxRok.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxRok.FormattingEnabled = true;
            this.cBoxRok.Items.AddRange(new object[] {
            "2019",
            "2020",
            "2021"});
            this.cBoxRok.Location = new System.Drawing.Point(68, 24);
            this.cBoxRok.Name = "cBoxRok";
            this.cBoxRok.Size = new System.Drawing.Size(208, 21);
            this.cBoxRok.TabIndex = 2;
            this.cBoxRok.SelectedIndexChanged += new System.EventHandler(this.cBoxRok_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Měsíc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rok";
            // 
            // lvData
            // 
            this.lvData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvData.FullRowSelect = true;
            this.lvData.GridLines = true;
            this.lvData.HideSelection = false;
            this.lvData.Location = new System.Drawing.Point(0, 0);
            this.lvData.Name = "lvData";
            this.lvData.Size = new System.Drawing.Size(794, 542);
            this.lvData.TabIndex = 0;
            this.lvData.UseCompatibleStateImageBehavior = false;
            this.lvData.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Datum";
            this.columnHeader1.Width = 121;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Č dokladu";
            this.columnHeader2.Width = 152;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Popis";
            this.columnHeader3.Width = 184;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Příjmy";
            this.columnHeader4.Width = 119;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Výdaje";
            this.columnHeader5.Width = 71;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Zůstatek";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Poznámka";
            this.columnHeader7.Width = 515;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Datum";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dtpDatum
            // 
            this.dtpDatum.Location = new System.Drawing.Point(69, 19);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(208, 20);
            this.dtpDatum.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUlozitJakoNovy);
            this.groupBox1.Controls.Add(this.btnUlozit);
            this.groupBox1.Controls.Add(this.txtPoznamka);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtPopis);
            this.groupBox1.Controls.Add(this.txtCisloDokladu);
            this.groupBox1.Controls.Add(this.numericCastka);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpDatum);
            this.groupBox1.Location = new System.Drawing.Point(794, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 198);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Položka";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Č. dokladu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Popis";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Částka";
            // 
            // numericCastka
            // 
            this.numericCastka.Location = new System.Drawing.Point(69, 95);
            this.numericCastka.Maximum = new decimal(new int[] {
            200000,
            0,
            0,
            0});
            this.numericCastka.Minimum = new decimal(new int[] {
            200000,
            0,
            0,
            -2147483648});
            this.numericCastka.Name = "numericCastka";
            this.numericCastka.Size = new System.Drawing.Size(208, 20);
            this.numericCastka.TabIndex = 6;
            this.numericCastka.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericCastka.ValueChanged += new System.EventHandler(this.numericCastka_ValueChanged);
            // 
            // txtCisloDokladu
            // 
            this.txtCisloDokladu.Location = new System.Drawing.Point(71, 45);
            this.txtCisloDokladu.Name = "txtCisloDokladu";
            this.txtCisloDokladu.ReadOnly = true;
            this.txtCisloDokladu.Size = new System.Drawing.Size(208, 20);
            this.txtCisloDokladu.TabIndex = 7;
            this.txtCisloDokladu.TextChanged += new System.EventHandler(this.txtCisloDokladu_TextChanged);
            // 
            // txtPopis
            // 
            this.txtPopis.Location = new System.Drawing.Point(69, 71);
            this.txtPopis.Name = "txtPopis";
            this.txtPopis.Size = new System.Drawing.Size(208, 20);
            this.txtPopis.TabIndex = 8;
            this.txtPopis.TextChanged += new System.EventHandler(this.txtPopis_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Poznámka";
            // 
            // txtPoznamka
            // 
            this.txtPoznamka.Location = new System.Drawing.Point(69, 116);
            this.txtPoznamka.Name = "txtPoznamka";
            this.txtPoznamka.Size = new System.Drawing.Size(208, 20);
            this.txtPoznamka.TabIndex = 10;
            // 
            // btnUlozit
            // 
            this.btnUlozit.Enabled = false;
            this.btnUlozit.Location = new System.Drawing.Point(200, 156);
            this.btnUlozit.Name = "btnUlozit";
            this.btnUlozit.Size = new System.Drawing.Size(75, 23);
            this.btnUlozit.TabIndex = 1;
            this.btnUlozit.Text = "Uložit";
            this.btnUlozit.UseVisualStyleBackColor = true;
            // 
            // btnUlozitJakoNovy
            // 
            this.btnUlozitJakoNovy.Enabled = false;
            this.btnUlozitJakoNovy.Location = new System.Drawing.Point(101, 156);
            this.btnUlozitJakoNovy.Name = "btnUlozitJakoNovy";
            this.btnUlozitJakoNovy.Size = new System.Drawing.Size(93, 23);
            this.btnUlozitJakoNovy.TabIndex = 11;
            this.btnUlozitJakoNovy.Text = "Uložit jako nový";
            this.btnUlozitJakoNovy.UseVisualStyleBackColor = true;
            this.btnUlozitJakoNovy.Click += new System.EventHandler(this.btnUlozitJakoNovy_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 542);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lvData);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.gBoxObdobí.ResumeLayout(false);
            this.gBoxObdobí.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCastka)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lvData;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.GroupBox gBoxObdobí;
        private System.Windows.Forms.ComboBox cBoxMesic;
        private System.Windows.Forms.ComboBox cBoxRok;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPoznamka;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPopis;
        private System.Windows.Forms.TextBox txtCisloDokladu;
        private System.Windows.Forms.NumericUpDown numericCastka;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnUlozitJakoNovy;
        private System.Windows.Forms.Button btnUlozit;
    }
}

