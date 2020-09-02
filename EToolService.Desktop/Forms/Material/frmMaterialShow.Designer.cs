namespace EToolService.Desktop.Forms.Material
{
    partial class frmMaterialShow
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
            this.pnlMaterials = new System.Windows.Forms.Panel();
            this.lblMaterialType = new System.Windows.Forms.Label();
            this.lblHardness = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblQuality = new System.Windows.Forms.Label();
            this.lblDimenzije = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAddEmployee
            // 
            this.lblAddEmployee.AutoSize = true;
            this.lblAddEmployee.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddEmployee.Location = new System.Drawing.Point(201, 33);
            this.lblAddEmployee.Name = "lblAddEmployee";
            this.lblAddEmployee.Size = new System.Drawing.Size(240, 33);
            this.lblAddEmployee.TabIndex = 2;
            this.lblAddEmployee.Text = "Prikaz materijala";
            // 
            // pnlMaterials
            // 
            this.pnlMaterials.AutoScroll = true;
            this.pnlMaterials.Location = new System.Drawing.Point(7, 141);
            this.pnlMaterials.Name = "pnlMaterials";
            this.pnlMaterials.Size = new System.Drawing.Size(647, 232);
            this.pnlMaterials.TabIndex = 3;
            // 
            // lblMaterialType
            // 
            this.lblMaterialType.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaterialType.Location = new System.Drawing.Point(456, 113);
            this.lblMaterialType.Name = "lblMaterialType";
            this.lblMaterialType.Size = new System.Drawing.Size(54, 23);
            this.lblMaterialType.TabIndex = 9;
            this.lblMaterialType.Text = "Tip";
            // 
            // lblHardness
            // 
            this.lblHardness.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHardness.Location = new System.Drawing.Point(335, 113);
            this.lblHardness.Name = "lblHardness";
            this.lblHardness.Size = new System.Drawing.Size(75, 23);
            this.lblHardness.TabIndex = 8;
            this.lblHardness.Text = "Tvrdoća";
            // 
            // lblQuantity
            // 
            this.lblQuantity.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(246, 113);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(73, 23);
            this.lblQuantity.TabIndex = 7;
            this.lblQuantity.Text = "Na stanju";
            // 
            // lblQuality
            // 
            this.lblQuality.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuality.Location = new System.Drawing.Point(163, 113);
            this.lblQuality.Name = "lblQuality";
            this.lblQuality.Size = new System.Drawing.Size(67, 23);
            this.lblQuality.TabIndex = 6;
            this.lblQuality.Text = "Kvalitet";
            // 
            // lblDimenzije
            // 
            this.lblDimenzije.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDimenzije.Location = new System.Drawing.Point(16, 113);
            this.lblDimenzije.Name = "lblDimenzije";
            this.lblDimenzije.Size = new System.Drawing.Size(180, 23);
            this.lblDimenzije.TabIndex = 5;
            this.lblDimenzije.Text = "Dimenzije";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(558, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ukloni";
            // 
            // frmMaterialShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(658, 375);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMaterialType);
            this.Controls.Add(this.lblHardness);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblQuality);
            this.Controls.Add(this.lblDimenzije);
            this.Controls.Add(this.pnlMaterials);
            this.Controls.Add(this.lblAddEmployee);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMaterialShow";
            this.Text = "frmMaterialShow";
            this.Load += new System.EventHandler(this.frmMaterialShow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddEmployee;
        private System.Windows.Forms.Panel pnlMaterials;
        private System.Windows.Forms.Label lblMaterialType;
        private System.Windows.Forms.Label lblHardness;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblQuality;
        private System.Windows.Forms.Label lblDimenzije;
        private System.Windows.Forms.Label label1;
    }
}