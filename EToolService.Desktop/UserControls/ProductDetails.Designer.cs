namespace EToolService.Desktop.UserControls
{
    partial class ProductDetails
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.valUkupno = new System.Windows.Forms.Label();
            this.valKolicina = new System.Windows.Forms.Label();
            this.valCijena = new System.Windows.Forms.Label();
            this.valNaziv = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // valUkupno
            // 
            this.valUkupno.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valUkupno.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.valUkupno.Location = new System.Drawing.Point(271, 4);
            this.valUkupno.Name = "valUkupno";
            this.valUkupno.Size = new System.Drawing.Size(100, 19);
            this.valUkupno.TabIndex = 24;
            this.valUkupno.Text = "Ukupno";
            this.valUkupno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // valKolicina
            // 
            this.valKolicina.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valKolicina.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.valKolicina.Location = new System.Drawing.Point(217, 5);
            this.valKolicina.Name = "valKolicina";
            this.valKolicina.Size = new System.Drawing.Size(36, 19);
            this.valKolicina.TabIndex = 23;
            this.valKolicina.Text = "Količina";
            this.valKolicina.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // valCijena
            // 
            this.valCijena.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valCijena.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.valCijena.Location = new System.Drawing.Point(127, 4);
            this.valCijena.Name = "valCijena";
            this.valCijena.Size = new System.Drawing.Size(82, 19);
            this.valCijena.TabIndex = 22;
            this.valCijena.Text = "Cijena";
            this.valCijena.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // valNaziv
            // 
            this.valNaziv.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valNaziv.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.valNaziv.Location = new System.Drawing.Point(5, 5);
            this.valNaziv.Name = "valNaziv";
            this.valNaziv.Size = new System.Drawing.Size(129, 19);
            this.valNaziv.TabIndex = 21;
            this.valNaziv.Text = "Naziv";
            this.valNaziv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ProductDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.valUkupno);
            this.Controls.Add(this.valKolicina);
            this.Controls.Add(this.valCijena);
            this.Controls.Add(this.valNaziv);
            this.Name = "ProductDetails";
            this.Size = new System.Drawing.Size(371, 28);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label valUkupno;
        private System.Windows.Forms.Label valKolicina;
        private System.Windows.Forms.Label valNaziv;
        private System.Windows.Forms.Label valCijena;
    }
}
