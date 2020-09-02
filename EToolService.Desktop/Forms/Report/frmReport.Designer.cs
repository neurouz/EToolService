namespace EToolService.Desktop.Forms.Report
{
    partial class frmReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReport));
            this.lblAddEmployee = new System.Windows.Forms.Label();
            this.comboGodina = new System.Windows.Forms.ComboBox();
            this.comboMjesec = new System.Windows.Forms.ComboBox();
            this.lblIme = new System.Windows.Forms.Label();
            this.lblBrojProdanih = new System.Windows.Forms.Label();
            this.valBrojProdanih = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.valNajprodavaniji = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.valBrojServisa = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.valUkupnoServis = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.valUkupnoProizvodnja = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.valNajboljiKupac = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPdf = new XanderUI.XUIButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.loader1 = new EToolService.Desktop.Loader();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAddEmployee
            // 
            this.lblAddEmployee.AutoSize = true;
            this.lblAddEmployee.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddEmployee.Location = new System.Drawing.Point(267, -1);
            this.lblAddEmployee.Name = "lblAddEmployee";
            this.lblAddEmployee.Size = new System.Drawing.Size(269, 33);
            this.lblAddEmployee.TabIndex = 3;
            this.lblAddEmployee.Text = "Kreiranje izvještaja";
            // 
            // comboGodina
            // 
            this.comboGodina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboGodina.FormattingEnabled = true;
            this.comboGodina.Location = new System.Drawing.Point(440, 65);
            this.comboGodina.Name = "comboGodina";
            this.comboGodina.Size = new System.Drawing.Size(106, 21);
            this.comboGodina.TabIndex = 5;
            this.comboGodina.SelectionChangeCommitted += new System.EventHandler(this.comboGodina_SelectedIndexChanged);
            // 
            // comboMjesec
            // 
            this.comboMjesec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMjesec.FormattingEnabled = true;
            this.comboMjesec.Location = new System.Drawing.Point(571, 65);
            this.comboMjesec.Name = "comboMjesec";
            this.comboMjesec.Size = new System.Drawing.Size(106, 21);
            this.comboMjesec.TabIndex = 6;
            this.comboMjesec.SelectionChangeCommitted += new System.EventHandler(this.comboMjesec_SelectedIndexChanged);
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIme.Location = new System.Drawing.Point(141, 68);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(266, 16);
            this.lblIme.TabIndex = 7;
            this.lblIme.Text = "Kreiranje izvještaja za odabrani datum:";
            // 
            // lblBrojProdanih
            // 
            this.lblBrojProdanih.AutoSize = true;
            this.lblBrojProdanih.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrojProdanih.Location = new System.Drawing.Point(306, 171);
            this.lblBrojProdanih.Name = "lblBrojProdanih";
            this.lblBrojProdanih.Size = new System.Drawing.Size(143, 16);
            this.lblBrojProdanih.TabIndex = 8;
            this.lblBrojProdanih.Text = "Prodanih artikala:";
            // 
            // valBrojProdanih
            // 
            this.valBrojProdanih.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valBrojProdanih.Location = new System.Drawing.Point(455, 171);
            this.valBrojProdanih.Name = "valBrojProdanih";
            this.valBrojProdanih.Size = new System.Drawing.Size(219, 16);
            this.valBrojProdanih.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(275, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Najprodavaniji artikal:";
            // 
            // valNajprodavaniji
            // 
            this.valNajprodavaniji.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valNajprodavaniji.Location = new System.Drawing.Point(455, 198);
            this.valNajprodavaniji.Name = "valNajprodavaniji";
            this.valNajprodavaniji.Size = new System.Drawing.Size(219, 16);
            this.valNajprodavaniji.TabIndex = 11;
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitle.Location = new System.Drawing.Point(262, 122);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(146, 19);
            this.lblSubtitle.TabIndex = 12;
            this.lblSubtitle.Text = "Izvještaj za datum";
            // 
            // valBrojServisa
            // 
            this.valBrojServisa.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valBrojServisa.Location = new System.Drawing.Point(455, 226);
            this.valBrojServisa.Name = "valBrojServisa";
            this.valBrojServisa.Size = new System.Drawing.Size(219, 16);
            this.valBrojServisa.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(277, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Broj servisiranih alata:";
            // 
            // valUkupnoServis
            // 
            this.valUkupnoServis.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valUkupnoServis.Location = new System.Drawing.Point(455, 253);
            this.valUkupnoServis.Name = "valUkupnoServis";
            this.valUkupnoServis.Size = new System.Drawing.Size(219, 16);
            this.valUkupnoServis.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(222, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(241, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Ukupna zarada na servisiranju:";
            // 
            // valUkupnoProizvodnja
            // 
            this.valUkupnoProizvodnja.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valUkupnoProizvodnja.Location = new System.Drawing.Point(455, 280);
            this.valUkupnoProizvodnja.Name = "valUkupnoProizvodnja";
            this.valUkupnoProizvodnja.Size = new System.Drawing.Size(219, 16);
            this.valUkupnoProizvodnja.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(223, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(238, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Ukupna zarada na proizvodnji:";
            // 
            // valNajboljiKupac
            // 
            this.valNajboljiKupac.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valNajboljiKupac.Location = new System.Drawing.Point(455, 306);
            this.valNajboljiKupac.Name = "valNajboljiKupac";
            this.valNajboljiKupac.Size = new System.Drawing.Size(219, 16);
            this.valNajboljiKupac.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(175, 306);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(293, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "Kupac sa najviše ostvarenih narudžbi:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(55, 134);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 108);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // btnPdf
            // 
            this.btnPdf.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnPdf.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnPdf.ButtonImage")));
            this.btnPdf.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnPdf.ButtonText = "PDF";
            this.btnPdf.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnPdf.ClickTextColor = System.Drawing.Color.Teal;
            this.btnPdf.CornerRadius = 5;
            this.btnPdf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPdf.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPdf.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnPdf.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnPdf.HoverTextColor = System.Drawing.Color.Teal;
            this.btnPdf.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnPdf.Location = new System.Drawing.Point(741, 339);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(81, 37);
            this.btnPdf.TabIndex = 23;
            this.btnPdf.TextColor = System.Drawing.Color.Teal;
            this.btnPdf.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(67, 97);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(675, 19);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // loader1
            // 
            this.loader1.Location = new System.Drawing.Point(365, 128);
            this.loader1.Name = "loader1";
            this.loader1.Size = new System.Drawing.Size(106, 88);
            this.loader1.TabIndex = 13;
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(735, 375);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnPdf);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.valNajboljiKupac);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.valUkupnoProizvodnja);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.valUkupnoServis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.valBrojServisa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.loader1);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.valNajprodavaniji);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.valBrojProdanih);
            this.Controls.Add(this.lblBrojProdanih);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.comboMjesec);
            this.Controls.Add(this.comboGodina);
            this.Controls.Add(this.lblAddEmployee);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReport";
            this.Text = "frmReport";
            this.Load += new System.EventHandler(this.frmReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddEmployee;
        private System.Windows.Forms.ComboBox comboGodina;
        private System.Windows.Forms.ComboBox comboMjesec;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblBrojProdanih;
        private System.Windows.Forms.Label valBrojProdanih;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label valNajprodavaniji;
        private System.Windows.Forms.Label lblSubtitle;
        private Loader loader1;
        private System.Windows.Forms.Label valBrojServisa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label valUkupnoServis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label valUkupnoProizvodnja;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label valNajboljiKupac;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private XanderUI.XUIButton btnPdf;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}