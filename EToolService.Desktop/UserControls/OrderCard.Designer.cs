namespace EToolService.Desktop.UserControls
{
    partial class OrderCard
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
            this.lblIznos = new System.Windows.Forms.Label();
            this.lblDatum = new System.Windows.Forms.Label();
            this.lblNarucioc = new System.Windows.Forms.Label();
            this.btnPotvrdi = new System.Windows.Forms.Button();
            this.btnPregled = new System.Windows.Forms.Button();
            this.btnZavršeno = new System.Windows.Forms.Button();
            this.lblAdresa = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblIznos
            // 
            this.lblIznos.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIznos.Location = new System.Drawing.Point(508, 7);
            this.lblIznos.Name = "lblIznos";
            this.lblIznos.Size = new System.Drawing.Size(118, 23);
            this.lblIznos.TabIndex = 11;
            this.lblIznos.Text = "Za platiti";
            // 
            // lblDatum
            // 
            this.lblDatum.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatum.Location = new System.Drawing.Point(150, 6);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(114, 23);
            this.lblDatum.TabIndex = 9;
            this.lblDatum.Text = "Datum kreiranja";
            // 
            // lblNarucioc
            // 
            this.lblNarucioc.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNarucioc.Location = new System.Drawing.Point(11, 7);
            this.lblNarucioc.Name = "lblNarucioc";
            this.lblNarucioc.Size = new System.Drawing.Size(145, 23);
            this.lblNarucioc.TabIndex = 8;
            this.lblNarucioc.Text = "Naručioc";
            // 
            // btnPotvrdi
            // 
            this.btnPotvrdi.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnPotvrdi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPotvrdi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPotvrdi.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPotvrdi.ForeColor = System.Drawing.Color.White;
            this.btnPotvrdi.Location = new System.Drawing.Point(701, 2);
            this.btnPotvrdi.Name = "btnPotvrdi";
            this.btnPotvrdi.Size = new System.Drawing.Size(77, 23);
            this.btnPotvrdi.TabIndex = 13;
            this.btnPotvrdi.Text = "Potvrdi";
            this.btnPotvrdi.UseVisualStyleBackColor = false;
            this.btnPotvrdi.Click += new System.EventHandler(this.btnPotvrdi_Click);
            // 
            // btnPregled
            // 
            this.btnPregled.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPregled.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPregled.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPregled.Location = new System.Drawing.Point(632, 2);
            this.btnPregled.Name = "btnPregled";
            this.btnPregled.Size = new System.Drawing.Size(63, 23);
            this.btnPregled.TabIndex = 12;
            this.btnPregled.Text = "Pregled";
            this.btnPregled.UseVisualStyleBackColor = true;
            this.btnPregled.Click += new System.EventHandler(this.btnPregled_Click);
            // 
            // btnZavršeno
            // 
            this.btnZavršeno.BackColor = System.Drawing.Color.Crimson;
            this.btnZavršeno.Cursor = System.Windows.Forms.Cursors.No;
            this.btnZavršeno.Enabled = false;
            this.btnZavršeno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZavršeno.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZavršeno.ForeColor = System.Drawing.Color.White;
            this.btnZavršeno.Location = new System.Drawing.Point(701, 3);
            this.btnZavršeno.Name = "btnZavršeno";
            this.btnZavršeno.Size = new System.Drawing.Size(77, 23);
            this.btnZavršeno.TabIndex = 14;
            this.btnZavršeno.Text = "Završeno";
            this.btnZavršeno.UseMnemonic = false;
            this.btnZavršeno.UseVisualStyleBackColor = false;
            // 
            // lblAdresa
            // 
            this.lblAdresa.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdresa.Location = new System.Drawing.Point(311, 5);
            this.lblAdresa.Name = "lblAdresa";
            this.lblAdresa.Size = new System.Drawing.Size(191, 23);
            this.lblAdresa.TabIndex = 15;
            this.lblAdresa.Text = "Adresa";
            // 
            // OrderCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblAdresa);
            this.Controls.Add(this.btnZavršeno);
            this.Controls.Add(this.btnPotvrdi);
            this.Controls.Add(this.btnPregled);
            this.Controls.Add(this.lblIznos);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.lblNarucioc);
            this.Name = "OrderCard";
            this.Size = new System.Drawing.Size(781, 30);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblIznos;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Label lblNarucioc;
        private System.Windows.Forms.Button btnPotvrdi;
        private System.Windows.Forms.Button btnPregled;
        private System.Windows.Forms.Button btnZavršeno;
        private System.Windows.Forms.Label lblAdresa;
    }
}
