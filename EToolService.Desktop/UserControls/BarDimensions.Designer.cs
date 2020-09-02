namespace EToolService.Desktop.UserControls
{
    partial class BarDimensions
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
            this.lblPrecnik = new System.Windows.Forms.Label();
            this.lblDuzina = new System.Windows.Forms.Label();
            this.txtPrecnik = new System.Windows.Forms.TextBox();
            this.txtDuzina = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblPrecnik
            // 
            this.lblPrecnik.AutoSize = true;
            this.lblPrecnik.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecnik.Location = new System.Drawing.Point(11, 13);
            this.lblPrecnik.Name = "lblPrecnik";
            this.lblPrecnik.Size = new System.Drawing.Size(53, 14);
            this.lblPrecnik.TabIndex = 5;
            this.lblPrecnik.Text = "Prečnik*";
            // 
            // lblDuzina
            // 
            this.lblDuzina.AutoSize = true;
            this.lblDuzina.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuzina.Location = new System.Drawing.Point(16, 39);
            this.lblDuzina.Name = "lblDuzina";
            this.lblDuzina.Size = new System.Drawing.Size(50, 14);
            this.lblDuzina.TabIndex = 6;
            this.lblDuzina.Text = "Dužina*";
            // 
            // txtPrecnik
            // 
            this.txtPrecnik.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrecnik.Location = new System.Drawing.Point(72, 10);
            this.txtPrecnik.Multiline = true;
            this.txtPrecnik.Name = "txtPrecnik";
            this.txtPrecnik.Size = new System.Drawing.Size(62, 20);
            this.txtPrecnik.TabIndex = 7;
            // 
            // txtDuzina
            // 
            this.txtDuzina.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDuzina.Location = new System.Drawing.Point(72, 36);
            this.txtDuzina.Multiline = true;
            this.txtDuzina.Name = "txtDuzina";
            this.txtDuzina.Size = new System.Drawing.Size(62, 20);
            this.txtDuzina.TabIndex = 8;
            // 
            // BarDimensions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtDuzina);
            this.Controls.Add(this.txtPrecnik);
            this.Controls.Add(this.lblDuzina);
            this.Controls.Add(this.lblPrecnik);
            this.Name = "BarDimensions";
            this.Size = new System.Drawing.Size(281, 68);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrecnik;
        private System.Windows.Forms.Label lblDuzina;
        private System.Windows.Forms.TextBox txtPrecnik;
        private System.Windows.Forms.TextBox txtDuzina;
    }
}
