namespace EToolService.Desktop.UserControls
{
    partial class ProductCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductCard));
            this.picProductImage = new System.Windows.Forms.PictureBox();
            this.lblNazivProizvoda = new System.Windows.Forms.Label();
            this.lblCijena = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.valPrice = new System.Windows.Forms.Label();
            this.valCondition = new System.Windows.Forms.Label();
            this.valPopust = new System.Windows.Forms.Label();
            this.btnEdit = new XanderUI.XUIButton();
            this.btnRemove = new XanderUI.XUIButton();
            this.valID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lineLeft = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picProductImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // picProductImage
            // 
            this.picProductImage.Location = new System.Drawing.Point(28, 19);
            this.picProductImage.Name = "picProductImage";
            this.picProductImage.Size = new System.Drawing.Size(100, 91);
            this.picProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picProductImage.TabIndex = 0;
            this.picProductImage.TabStop = false;
            // 
            // lblNazivProizvoda
            // 
            this.lblNazivProizvoda.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNazivProizvoda.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblNazivProizvoda.Location = new System.Drawing.Point(153, 6);
            this.lblNazivProizvoda.Name = "lblNazivProizvoda";
            this.lblNazivProizvoda.Size = new System.Drawing.Size(230, 21);
            this.lblNazivProizvoda.TabIndex = 6;
            this.lblNazivProizvoda.Text = "Naziv proizvoda";
            // 
            // lblCijena
            // 
            this.lblCijena.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCijena.ForeColor = System.Drawing.Color.Black;
            this.lblCijena.Location = new System.Drawing.Point(159, 48);
            this.lblCijena.Name = "lblCijena";
            this.lblCijena.Size = new System.Drawing.Size(64, 23);
            this.lblCijena.TabIndex = 7;
            this.lblCijena.Text = "Cijena:";
            this.lblCijena.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(159, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Stanje:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(159, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "Popust:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // valPrice
            // 
            this.valPrice.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valPrice.ForeColor = System.Drawing.Color.Black;
            this.valPrice.Location = new System.Drawing.Point(228, 48);
            this.valPrice.Name = "valPrice";
            this.valPrice.Size = new System.Drawing.Size(153, 23);
            this.valPrice.TabIndex = 11;
            this.valPrice.Text = "1045.95 (sa popustom)";
            this.valPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // valCondition
            // 
            this.valCondition.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valCondition.ForeColor = System.Drawing.Color.Black;
            this.valCondition.Location = new System.Drawing.Point(229, 69);
            this.valCondition.Name = "valCondition";
            this.valCondition.Size = new System.Drawing.Size(168, 23);
            this.valCondition.TabIndex = 12;
            this.valCondition.Text = "Polovno";
            this.valCondition.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // valPopust
            // 
            this.valPopust.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valPopust.ForeColor = System.Drawing.Color.Black;
            this.valPopust.Location = new System.Drawing.Point(229, 88);
            this.valPopust.Name = "valPopust";
            this.valPopust.Size = new System.Drawing.Size(105, 23);
            this.valPopust.TabIndex = 14;
            this.valPopust.Text = "2.58%";
            this.valPopust.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnEdit
            // 
            this.btnEdit.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnEdit.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnEdit.ButtonImage")));
            this.btnEdit.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnEdit.ButtonText = "";
            this.btnEdit.ClickBackColor = System.Drawing.Color.Transparent;
            this.btnEdit.ClickTextColor = System.Drawing.Color.LightGray;
            this.btnEdit.CornerRadius = 5;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Horizontal_Alignment = System.Drawing.StringAlignment.Near;
            this.btnEdit.HoverBackgroundColor = System.Drawing.Color.GhostWhite;
            this.btnEdit.HoverTextColor = System.Drawing.Color.DarkSlateGray;
            this.btnEdit.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnEdit.Location = new System.Drawing.Point(311, 98);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(23, 23);
            this.btnEdit.TabIndex = 15;
            this.btnEdit.TextColor = System.Drawing.Color.DarkSlateGray;
            this.btnEdit.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnRemove.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnRemove.ButtonImage")));
            this.btnRemove.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnRemove.ButtonText = "";
            this.btnRemove.ClickBackColor = System.Drawing.Color.Transparent;
            this.btnRemove.ClickTextColor = System.Drawing.Color.LightGray;
            this.btnRemove.CornerRadius = 5;
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemove.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Horizontal_Alignment = System.Drawing.StringAlignment.Near;
            this.btnRemove.HoverBackgroundColor = System.Drawing.Color.GhostWhite;
            this.btnRemove.HoverTextColor = System.Drawing.Color.DarkSlateGray;
            this.btnRemove.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnRemove.Location = new System.Drawing.Point(337, 96);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(24, 24);
            this.btnRemove.TabIndex = 16;
            this.btnRemove.TextColor = System.Drawing.Color.DarkSlateGray;
            this.btnRemove.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // valID
            // 
            this.valID.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valID.ForeColor = System.Drawing.Color.Black;
            this.valID.Location = new System.Drawing.Point(229, 27);
            this.valID.Name = "valID";
            this.valID.Size = new System.Drawing.Size(105, 23);
            this.valID.TabIndex = 19;
            this.valID.Text = "13";
            this.valID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(160, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 21);
            this.label5.TabIndex = 18;
            this.label5.Text = "ID:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lineLeft
            // 
            this.lineLeft.Image = ((System.Drawing.Image)(resources.GetObject("lineLeft.Image")));
            this.lineLeft.Location = new System.Drawing.Point(6, 11);
            this.lineLeft.Name = "lineLeft";
            this.lineLeft.Size = new System.Drawing.Size(10, 108);
            this.lineLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lineLeft.TabIndex = 21;
            this.lineLeft.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 123);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(385, 11);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // ProductCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.lineLeft);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.valID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.valPopust);
            this.Controls.Add(this.valCondition);
            this.Controls.Add(this.valPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCijena);
            this.Controls.Add(this.lblNazivProizvoda);
            this.Controls.Add(this.picProductImage);
            this.Name = "ProductCard";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(384, 141);
            ((System.ComponentModel.ISupportInitialize)(this.picProductImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picProductImage;
        private System.Windows.Forms.Label lblNazivProizvoda;
        private System.Windows.Forms.Label lblCijena;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label valPrice;
        private System.Windows.Forms.Label valCondition;
        private System.Windows.Forms.Label valPopust;
        private XanderUI.XUIButton btnEdit;
        private XanderUI.XUIButton btnRemove;
        private System.Windows.Forms.Label valID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox lineLeft;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
