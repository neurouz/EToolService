namespace EToolService.Desktop.Forms.Product
{
    partial class frmProductEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductEdit));
            this.imgProductImage = new System.Windows.Forms.PictureBox();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.lblCijena = new System.Windows.Forms.Label();
            this.txtStanje = new System.Windows.Forms.TextBox();
            this.lblStanje = new System.Windows.Forms.Label();
            this.txtPopust = new System.Windows.Forms.TextBox();
            this.lblPopust = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.valID = new System.Windows.Forms.Label();
            this.lblOpis = new System.Windows.Forms.Label();
            this.txtDimensions = new System.Windows.Forms.TextBox();
            this.pictureDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnPromijeniSliku = new XanderUI.XUIButton();
            this.btnAddRequest = new XanderUI.XUIButton();
            this.btnCLose = new XanderUI.XUIButton();
            this.txtFilename = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgProductImage)).BeginInit();
            this.SuspendLayout();
            // 
            // imgProductImage
            // 
            this.imgProductImage.Location = new System.Drawing.Point(51, 86);
            this.imgProductImage.Name = "imgProductImage";
            this.imgProductImage.Size = new System.Drawing.Size(209, 174);
            this.imgProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgProductImage.TabIndex = 0;
            this.imgProductImage.TabStop = false;
            // 
            // lblNaziv
            // 
            this.lblNaziv.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaziv.ForeColor = System.Drawing.Color.Black;
            this.lblNaziv.Location = new System.Drawing.Point(302, 28);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(193, 23);
            this.lblNaziv.TabIndex = 8;
            this.lblNaziv.Text = "Naziv proizvoda";
            this.lblNaziv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(306, 52);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(289, 20);
            this.txtNaziv.TabIndex = 18;
            // 
            // txtCijena
            // 
            this.txtCijena.Location = new System.Drawing.Point(306, 99);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(289, 20);
            this.txtCijena.TabIndex = 20;
            // 
            // lblCijena
            // 
            this.lblCijena.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCijena.ForeColor = System.Drawing.Color.Black;
            this.lblCijena.Location = new System.Drawing.Point(302, 75);
            this.lblCijena.Name = "lblCijena";
            this.lblCijena.Size = new System.Drawing.Size(193, 23);
            this.lblCijena.TabIndex = 19;
            this.lblCijena.Text = "Cijena";
            this.lblCijena.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtStanje
            // 
            this.txtStanje.Location = new System.Drawing.Point(306, 151);
            this.txtStanje.Name = "txtStanje";
            this.txtStanje.Size = new System.Drawing.Size(289, 20);
            this.txtStanje.TabIndex = 22;
            // 
            // lblStanje
            // 
            this.lblStanje.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStanje.ForeColor = System.Drawing.Color.Black;
            this.lblStanje.Location = new System.Drawing.Point(302, 127);
            this.lblStanje.Name = "lblStanje";
            this.lblStanje.Size = new System.Drawing.Size(193, 23);
            this.lblStanje.TabIndex = 21;
            this.lblStanje.Text = "Stanje";
            this.lblStanje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPopust
            // 
            this.txtPopust.Location = new System.Drawing.Point(306, 203);
            this.txtPopust.Name = "txtPopust";
            this.txtPopust.Size = new System.Drawing.Size(135, 20);
            this.txtPopust.TabIndex = 24;
            // 
            // lblPopust
            // 
            this.lblPopust.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPopust.ForeColor = System.Drawing.Color.Black;
            this.lblPopust.Location = new System.Drawing.Point(302, 179);
            this.lblPopust.Name = "lblPopust";
            this.lblPopust.Size = new System.Drawing.Size(193, 23);
            this.lblPopust.TabIndex = 23;
            this.lblPopust.Text = "Popust";
            this.lblPopust.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(116, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 23);
            this.label1.TabIndex = 25;
            this.label1.Text = "ID:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // valID
            // 
            this.valID.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valID.ForeColor = System.Drawing.Color.Teal;
            this.valID.Location = new System.Drawing.Point(155, 48);
            this.valID.Name = "valID";
            this.valID.Size = new System.Drawing.Size(79, 23);
            this.valID.TabIndex = 26;
            this.valID.Text = "147";
            this.valID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOpis
            // 
            this.lblOpis.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpis.ForeColor = System.Drawing.Color.Black;
            this.lblOpis.Location = new System.Drawing.Point(303, 237);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(193, 23);
            this.lblOpis.TabIndex = 27;
            this.lblOpis.Text = "Dimenzije / Opis";
            this.lblOpis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDimensions
            // 
            this.txtDimensions.Location = new System.Drawing.Point(305, 263);
            this.txtDimensions.Name = "txtDimensions";
            this.txtDimensions.Size = new System.Drawing.Size(290, 20);
            this.txtDimensions.TabIndex = 28;
            // 
            // pictureDialog
            // 
            this.pictureDialog.FileName = "openFileDialog1";
            this.pictureDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif;" +
    " *.png";
            // 
            // btnPromijeniSliku
            // 
            this.btnPromijeniSliku.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnPromijeniSliku.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnPromijeniSliku.ButtonImage")));
            this.btnPromijeniSliku.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnPromijeniSliku.ButtonText = "Promijeni sliku";
            this.btnPromijeniSliku.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnPromijeniSliku.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnPromijeniSliku.CornerRadius = 5;
            this.btnPromijeniSliku.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPromijeniSliku.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPromijeniSliku.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnPromijeniSliku.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnPromijeniSliku.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnPromijeniSliku.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnPromijeniSliku.Location = new System.Drawing.Point(82, 282);
            this.btnPromijeniSliku.Name = "btnPromijeniSliku";
            this.btnPromijeniSliku.Size = new System.Drawing.Size(157, 32);
            this.btnPromijeniSliku.TabIndex = 29;
            this.btnPromijeniSliku.TextColor = System.Drawing.Color.Teal;
            this.btnPromijeniSliku.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnPromijeniSliku.Click += new System.EventHandler(this.btnPromijeniSliku_Click);
            // 
            // btnAddRequest
            // 
            this.btnAddRequest.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnAddRequest.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnAddRequest.ButtonImage")));
            this.btnAddRequest.ButtonStyle = XanderUI.XUIButton.Style.Material;
            this.btnAddRequest.ButtonText = "Spasi promjene";
            this.btnAddRequest.ClickBackColor = System.Drawing.Color.GhostWhite;
            this.btnAddRequest.ClickTextColor = System.Drawing.Color.Black;
            this.btnAddRequest.CornerRadius = 5;
            this.btnAddRequest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddRequest.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRequest.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnAddRequest.HoverBackgroundColor = System.Drawing.Color.GhostWhite;
            this.btnAddRequest.HoverTextColor = System.Drawing.Color.Black;
            this.btnAddRequest.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnAddRequest.Location = new System.Drawing.Point(237, 336);
            this.btnAddRequest.Name = "btnAddRequest";
            this.btnAddRequest.Size = new System.Drawing.Size(172, 33);
            this.btnAddRequest.TabIndex = 30;
            this.btnAddRequest.TextColor = System.Drawing.Color.ForestGreen;
            this.btnAddRequest.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnAddRequest.Click += new System.EventHandler(this.btnAddRequest_Click);
            // 
            // btnCLose
            // 
            this.btnCLose.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnCLose.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnCLose.ButtonImage")));
            this.btnCLose.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnCLose.ButtonText = "Zatvori";
            this.btnCLose.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnCLose.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnCLose.CornerRadius = 5;
            this.btnCLose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCLose.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnCLose.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnCLose.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnCLose.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnCLose.Location = new System.Drawing.Point(545, 349);
            this.btnCLose.Name = "btnCLose";
            this.btnCLose.Size = new System.Drawing.Size(91, 20);
            this.btnCLose.TabIndex = 31;
            this.btnCLose.TextColor = System.Drawing.Color.Black;
            this.btnCLose.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnCLose.Click += new System.EventHandler(this.btnCLose_Click);
            // 
            // txtFilename
            // 
            this.txtFilename.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilename.ForeColor = System.Drawing.Color.DarkGray;
            this.txtFilename.Location = new System.Drawing.Point(51, 263);
            this.txtFilename.Name = "txtFilename";
            this.txtFilename.Size = new System.Drawing.Size(209, 15);
            this.txtFilename.TabIndex = 32;
            this.txtFilename.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmProductEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 379);
            this.Controls.Add(this.txtFilename);
            this.Controls.Add(this.btnCLose);
            this.Controls.Add(this.btnAddRequest);
            this.Controls.Add(this.btnPromijeniSliku);
            this.Controls.Add(this.txtDimensions);
            this.Controls.Add(this.lblOpis);
            this.Controls.Add(this.valID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPopust);
            this.Controls.Add(this.lblPopust);
            this.Controls.Add(this.txtStanje);
            this.Controls.Add(this.lblStanje);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.lblCijena);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.imgProductImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmProductEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProductEdit";
            ((System.ComponentModel.ISupportInitialize)(this.imgProductImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgProductImage;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.Label lblCijena;
        private System.Windows.Forms.TextBox txtStanje;
        private System.Windows.Forms.Label lblStanje;
        private System.Windows.Forms.TextBox txtPopust;
        private System.Windows.Forms.Label lblPopust;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label valID;
        private System.Windows.Forms.Label lblOpis;
        private System.Windows.Forms.TextBox txtDimensions;
        private System.Windows.Forms.OpenFileDialog pictureDialog;
        private XanderUI.XUIButton btnPromijeniSliku;
        private XanderUI.XUIButton btnAddRequest;
        private XanderUI.XUIButton btnCLose;
        private System.Windows.Forms.Label txtFilename;
    }
}