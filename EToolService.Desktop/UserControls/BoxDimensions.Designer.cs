namespace EToolService.Desktop.UserControls
{
    partial class BoxDimensions
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
            this.lblSirina = new System.Windows.Forms.Label();
            this.lblDuzina = new System.Windows.Forms.Label();
            this.lblDebljina = new System.Windows.Forms.Label();
            this.txtDuzina = new System.Windows.Forms.TextBox();
            this.txtSirina = new System.Windows.Forms.TextBox();
            this.txtDebljina = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblSirina
            // 
            this.lblSirina.AutoSize = true;
            this.lblSirina.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSirina.Location = new System.Drawing.Point(24, 39);
            this.lblSirina.Name = "lblSirina";
            this.lblSirina.Size = new System.Drawing.Size(42, 14);
            this.lblSirina.TabIndex = 8;
            this.lblSirina.Text = "Širina*";
            // 
            // lblDuzina
            // 
            this.lblDuzina.AutoSize = true;
            this.lblDuzina.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuzina.Location = new System.Drawing.Point(15, 13);
            this.lblDuzina.Name = "lblDuzina";
            this.lblDuzina.Size = new System.Drawing.Size(50, 14);
            this.lblDuzina.TabIndex = 7;
            this.lblDuzina.Text = "Dužina*";
            // 
            // lblDebljina
            // 
            this.lblDebljina.AutoSize = true;
            this.lblDebljina.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDebljina.Location = new System.Drawing.Point(143, 26);
            this.lblDebljina.Name = "lblDebljina";
            this.lblDebljina.Size = new System.Drawing.Size(57, 14);
            this.lblDebljina.TabIndex = 9;
            this.lblDebljina.Text = "Debljina*";
            // 
            // txtDuzina
            // 
            this.txtDuzina.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDuzina.Location = new System.Drawing.Point(71, 10);
            this.txtDuzina.Multiline = true;
            this.txtDuzina.Name = "txtDuzina";
            this.txtDuzina.Size = new System.Drawing.Size(62, 20);
            this.txtDuzina.TabIndex = 10;
            // 
            // txtSirina
            // 
            this.txtSirina.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSirina.Location = new System.Drawing.Point(71, 36);
            this.txtSirina.Multiline = true;
            this.txtSirina.Name = "txtSirina";
            this.txtSirina.Size = new System.Drawing.Size(62, 20);
            this.txtSirina.TabIndex = 11;
            // 
            // txtDebljina
            // 
            this.txtDebljina.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDebljina.Location = new System.Drawing.Point(206, 23);
            this.txtDebljina.Multiline = true;
            this.txtDebljina.Name = "txtDebljina";
            this.txtDebljina.Size = new System.Drawing.Size(62, 20);
            this.txtDebljina.TabIndex = 12;
            // 
            // BoxDimensions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtDebljina);
            this.Controls.Add(this.txtSirina);
            this.Controls.Add(this.txtDuzina);
            this.Controls.Add(this.lblDebljina);
            this.Controls.Add(this.lblSirina);
            this.Controls.Add(this.lblDuzina);
            this.Name = "BoxDimensions";
            this.Size = new System.Drawing.Size(281, 68);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSirina;
        private System.Windows.Forms.Label lblDuzina;
        private System.Windows.Forms.Label lblDebljina;
        private System.Windows.Forms.TextBox txtDuzina;
        private System.Windows.Forms.TextBox txtSirina;
        private System.Windows.Forms.TextBox txtDebljina;
    }
}
