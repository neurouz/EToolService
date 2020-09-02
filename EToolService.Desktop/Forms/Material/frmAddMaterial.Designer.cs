namespace EToolService.Desktop.Forms.Material
{
    partial class frmAddMaterial
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
            this.lblAddEmployee = new System.Windows.Forms.Label();
            this.lblIme = new System.Windows.Forms.Label();
            this.comboTipMaterijala = new System.Windows.Forms.ComboBox();
            this.pnlDimenzije = new System.Windows.Forms.Panel();
            this.lblDimenzije = new System.Windows.Forms.Label();
            this.btnDodajMaterijal = new XanderUI.XUIButton();
            this.lblKvalitet = new System.Windows.Forms.Label();
            this.comboKvalitet = new System.Windows.Forms.ComboBox();
            this.lblTvrdoca = new System.Windows.Forms.Label();
            this.lblKolicina = new System.Windows.Forms.Label();
            this.txtTvrdoca = new System.Windows.Forms.TextBox();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblAddEmployee
            // 
            this.lblAddEmployee.AutoSize = true;
            this.lblAddEmployee.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddEmployee.Location = new System.Drawing.Point(134, 35);
            this.lblAddEmployee.Name = "lblAddEmployee";
            this.lblAddEmployee.Size = new System.Drawing.Size(380, 34);
            this.lblAddEmployee.TabIndex = 2;
            this.lblAddEmployee.Text = "Dodavanje novog materijala";
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIme.Location = new System.Drawing.Point(134, 107);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(86, 14);
            this.lblIme.TabIndex = 4;
            this.lblIme.Text = "Tip materijala*";
            // 
            // comboTipMaterijala
            // 
            this.comboTipMaterijala.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTipMaterijala.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboTipMaterijala.FormattingEnabled = true;
            this.comboTipMaterijala.Location = new System.Drawing.Point(233, 104);
            this.comboTipMaterijala.Name = "comboTipMaterijala";
            this.comboTipMaterijala.Size = new System.Drawing.Size(281, 21);
            this.comboTipMaterijala.TabIndex = 5;
            this.comboTipMaterijala.SelectedIndexChanged += new System.EventHandler(this.comboTipMaterijala_SelectedIndexChanged);
            // 
            // pnlDimenzije
            // 
            this.pnlDimenzije.Location = new System.Drawing.Point(233, 131);
            this.pnlDimenzije.Name = "pnlDimenzije";
            this.pnlDimenzije.Size = new System.Drawing.Size(281, 68);
            this.pnlDimenzije.TabIndex = 6;
            // 
            // lblDimenzije
            // 
            this.lblDimenzije.AutoSize = true;
            this.lblDimenzije.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDimenzije.Location = new System.Drawing.Point(152, 160);
            this.lblDimenzije.Name = "lblDimenzije";
            this.lblDimenzije.Size = new System.Drawing.Size(68, 14);
            this.lblDimenzije.TabIndex = 7;
            this.lblDimenzije.Text = "Dimenzije*";
            // 
            // btnDodajMaterijal
            // 
            this.btnDodajMaterijal.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDodajMaterijal.ButtonImage = null;
            this.btnDodajMaterijal.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnDodajMaterijal.ButtonText = "Dodaj materijal";
            this.btnDodajMaterijal.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnDodajMaterijal.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnDodajMaterijal.CornerRadius = 5;
            this.btnDodajMaterijal.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnDodajMaterijal.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnDodajMaterijal.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnDodajMaterijal.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnDodajMaterijal.Location = new System.Drawing.Point(185, 345);
            this.btnDodajMaterijal.Name = "btnDodajMaterijal";
            this.btnDodajMaterijal.Size = new System.Drawing.Size(304, 29);
            this.btnDodajMaterijal.TabIndex = 8;
            this.btnDodajMaterijal.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnDodajMaterijal.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnDodajMaterijal.Click += new System.EventHandler(this.btnDodajMaterijal_Click);
            // 
            // lblKvalitet
            // 
            this.lblKvalitet.AutoSize = true;
            this.lblKvalitet.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKvalitet.Location = new System.Drawing.Point(162, 213);
            this.lblKvalitet.Name = "lblKvalitet";
            this.lblKvalitet.Size = new System.Drawing.Size(55, 14);
            this.lblKvalitet.TabIndex = 9;
            this.lblKvalitet.Text = "Kvalitet*";
            // 
            // comboKvalitet
            // 
            this.comboKvalitet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboKvalitet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboKvalitet.FormattingEnabled = true;
            this.comboKvalitet.Location = new System.Drawing.Point(233, 208);
            this.comboKvalitet.Name = "comboKvalitet";
            this.comboKvalitet.Size = new System.Drawing.Size(281, 21);
            this.comboKvalitet.TabIndex = 10;
            // 
            // lblTvrdoca
            // 
            this.lblTvrdoca.AutoSize = true;
            this.lblTvrdoca.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTvrdoca.Location = new System.Drawing.Point(128, 251);
            this.lblTvrdoca.Name = "lblTvrdoca";
            this.lblTvrdoca.Size = new System.Drawing.Size(90, 14);
            this.lblTvrdoca.TabIndex = 11;
            this.lblTvrdoca.Text = "Tvrdoća (HRC)*";
            // 
            // lblKolicina
            // 
            this.lblKolicina.AutoSize = true;
            this.lblKolicina.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKolicina.Location = new System.Drawing.Point(163, 285);
            this.lblKolicina.Name = "lblKolicina";
            this.lblKolicina.Size = new System.Drawing.Size(55, 14);
            this.lblKolicina.TabIndex = 12;
            this.lblKolicina.Text = "Količina*";
            // 
            // txtTvrdoca
            // 
            this.txtTvrdoca.BackColor = System.Drawing.SystemColors.Window;
            this.txtTvrdoca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTvrdoca.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTvrdoca.Location = new System.Drawing.Point(233, 247);
            this.txtTvrdoca.Multiline = true;
            this.txtTvrdoca.Name = "txtTvrdoca";
            this.txtTvrdoca.Size = new System.Drawing.Size(76, 20);
            this.txtTvrdoca.TabIndex = 13;
            // 
            // txtKolicina
            // 
            this.txtKolicina.BackColor = System.Drawing.SystemColors.Window;
            this.txtKolicina.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtKolicina.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKolicina.Location = new System.Drawing.Point(233, 281);
            this.txtKolicina.Multiline = true;
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(76, 20);
            this.txtKolicina.TabIndex = 14;
            this.txtKolicina.Text = "1";
            // 
            // frmAddMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 375);
            this.Controls.Add(this.txtKolicina);
            this.Controls.Add(this.txtTvrdoca);
            this.Controls.Add(this.lblKolicina);
            this.Controls.Add(this.lblTvrdoca);
            this.Controls.Add(this.comboKvalitet);
            this.Controls.Add(this.lblKvalitet);
            this.Controls.Add(this.btnDodajMaterijal);
            this.Controls.Add(this.lblDimenzije);
            this.Controls.Add(this.pnlDimenzije);
            this.Controls.Add(this.comboTipMaterijala);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.lblAddEmployee);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddMaterial";
            this.Text = "frmAddMaterial";
            this.Load += new System.EventHandler(this.frmAddMaterial_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddEmployee;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.ComboBox comboTipMaterijala;
        private System.Windows.Forms.Panel pnlDimenzije;
        private System.Windows.Forms.Label lblDimenzije;
        private XanderUI.XUIButton btnDodajMaterijal;
        private System.Windows.Forms.Label lblKvalitet;
        private System.Windows.Forms.ComboBox comboKvalitet;
        private System.Windows.Forms.Label lblTvrdoca;
        private System.Windows.Forms.Label lblKolicina;
        private System.Windows.Forms.TextBox txtTvrdoca;
        private System.Windows.Forms.TextBox txtKolicina;
    }
}