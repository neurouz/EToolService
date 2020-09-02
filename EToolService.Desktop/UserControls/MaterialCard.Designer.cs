namespace EToolService.Desktop.UserControls
{
    partial class MaterialCard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaterialCard));
            this.lblDimenzije = new System.Windows.Forms.Label();
            this.lblQuality = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblHardness = new System.Windows.Forms.Label();
            this.lblMaterialType = new System.Windows.Forms.Label();
            this.picAvailable = new System.Windows.Forms.PictureBox();
            this.picNotAvailable = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tooltip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picAvailable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNotAvailable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDimenzije
            // 
            this.lblDimenzije.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDimenzije.Location = new System.Drawing.Point(12, 6);
            this.lblDimenzije.Name = "lblDimenzije";
            this.lblDimenzije.Size = new System.Drawing.Size(180, 23);
            this.lblDimenzije.TabIndex = 0;
            this.lblDimenzije.Text = "Dimenzije";
            // 
            // lblQuality
            // 
            this.lblQuality.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuality.Location = new System.Drawing.Point(163, 6);
            this.lblQuality.Name = "lblQuality";
            this.lblQuality.Size = new System.Drawing.Size(67, 23);
            this.lblQuality.TabIndex = 1;
            this.lblQuality.Text = "Kvalitet";
            // 
            // lblQuantity
            // 
            this.lblQuantity.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(245, 6);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(67, 23);
            this.lblQuantity.TabIndex = 2;
            this.lblQuantity.Text = "Na stanju";
            // 
            // lblHardness
            // 
            this.lblHardness.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHardness.Location = new System.Drawing.Point(327, 6);
            this.lblHardness.Name = "lblHardness";
            this.lblHardness.Size = new System.Drawing.Size(75, 23);
            this.lblHardness.TabIndex = 3;
            this.lblHardness.Text = "Tvrdoća";
            // 
            // lblMaterialType
            // 
            this.lblMaterialType.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaterialType.Location = new System.Drawing.Point(421, 6);
            this.lblMaterialType.Name = "lblMaterialType";
            this.lblMaterialType.Size = new System.Drawing.Size(130, 23);
            this.lblMaterialType.TabIndex = 4;
            this.lblMaterialType.Text = "Tip";
            // 
            // picAvailable
            // 
            this.picAvailable.Image = ((System.Drawing.Image)(resources.GetObject("picAvailable.Image")));
            this.picAvailable.Location = new System.Drawing.Point(553, 6);
            this.picAvailable.Name = "picAvailable";
            this.picAvailable.Size = new System.Drawing.Size(15, 15);
            this.picAvailable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAvailable.TabIndex = 5;
            this.picAvailable.TabStop = false;
            this.picAvailable.Visible = false;
            // 
            // picNotAvailable
            // 
            this.picNotAvailable.Image = ((System.Drawing.Image)(resources.GetObject("picNotAvailable.Image")));
            this.picNotAvailable.Location = new System.Drawing.Point(553, 6);
            this.picNotAvailable.Name = "picNotAvailable";
            this.picNotAvailable.Size = new System.Drawing.Size(15, 15);
            this.picNotAvailable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNotAvailable.TabIndex = 6;
            this.picNotAvailable.TabStop = false;
            this.picNotAvailable.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(589, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tooltip
            // 
            this.tooltip.AutomaticDelay = 40;
            this.tooltip.AutoPopDelay = 5000;
            this.tooltip.InitialDelay = 40;
            this.tooltip.ReshowDelay = 8;
            // 
            // MaterialCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picNotAvailable);
            this.Controls.Add(this.picAvailable);
            this.Controls.Add(this.lblMaterialType);
            this.Controls.Add(this.lblHardness);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblQuality);
            this.Controls.Add(this.lblDimenzije);
            this.Name = "MaterialCard";
            this.Size = new System.Drawing.Size(627, 28);
            ((System.ComponentModel.ISupportInitialize)(this.picAvailable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNotAvailable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDimenzije;
        private System.Windows.Forms.Label lblQuality;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblHardness;
        private System.Windows.Forms.Label lblMaterialType;
        private System.Windows.Forms.PictureBox picAvailable;
        private System.Windows.Forms.PictureBox picNotAvailable;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip tooltip;
    }
}
