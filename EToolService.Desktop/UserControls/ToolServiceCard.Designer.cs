namespace EToolService.Desktop.UserControls
{
    partial class ToolServiceCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToolServiceCard));
            this.valCompanyName = new System.Windows.Forms.Label();
            this.valDetails = new System.Windows.Forms.Label();
            this.btnUkloni = new System.Windows.Forms.Button();
            this.btnDetalji = new System.Windows.Forms.Button();
            this.btnOdgovori = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblPending = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // valCompanyName
            // 
            this.valCompanyName.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valCompanyName.Location = new System.Drawing.Point(33, 12);
            this.valCompanyName.Name = "valCompanyName";
            this.valCompanyName.Size = new System.Drawing.Size(430, 23);
            this.valCompanyName.TabIndex = 0;
            this.valCompanyName.Text = "Naziv kompanije";
            // 
            // valDetails
            // 
            this.valDetails.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valDetails.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.valDetails.Location = new System.Drawing.Point(33, 33);
            this.valDetails.Name = "valDetails";
            this.valDetails.Size = new System.Drawing.Size(415, 13);
            this.valDetails.TabIndex = 1;
            this.valDetails.Text = "Detaljan opis koji unosi kupac prilikom slanja zahtjeva za reparaciju ili servis " +
    "alata, tekst moze biti unesen ali nije obavezan";
            // 
            // btnUkloni
            // 
            this.btnUkloni.BackColor = System.Drawing.Color.Crimson;
            this.btnUkloni.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUkloni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUkloni.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUkloni.ForeColor = System.Drawing.Color.White;
            this.btnUkloni.Location = new System.Drawing.Point(689, 12);
            this.btnUkloni.Name = "btnUkloni";
            this.btnUkloni.Size = new System.Drawing.Size(102, 34);
            this.btnUkloni.TabIndex = 16;
            this.btnUkloni.Text = "Ukloni";
            this.btnUkloni.UseMnemonic = false;
            this.btnUkloni.UseVisualStyleBackColor = false;
            this.btnUkloni.Click += new System.EventHandler(this.btnUkloni_Click);
            // 
            // btnDetalji
            // 
            this.btnDetalji.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDetalji.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetalji.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetalji.Location = new System.Drawing.Point(478, 12);
            this.btnDetalji.Name = "btnDetalji";
            this.btnDetalji.Size = new System.Drawing.Size(102, 34);
            this.btnDetalji.TabIndex = 15;
            this.btnDetalji.Text = "Detalji";
            this.btnDetalji.UseVisualStyleBackColor = true;
            this.btnDetalji.Click += new System.EventHandler(this.btnDetalji_Click);
            // 
            // btnOdgovori
            // 
            this.btnOdgovori.BackColor = System.Drawing.Color.DarkCyan;
            this.btnOdgovori.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOdgovori.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdgovori.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdgovori.ForeColor = System.Drawing.Color.White;
            this.btnOdgovori.Location = new System.Drawing.Point(584, 12);
            this.btnOdgovori.Name = "btnOdgovori";
            this.btnOdgovori.Size = new System.Drawing.Size(102, 34);
            this.btnOdgovori.TabIndex = 17;
            this.btnOdgovori.Text = "Odgovori";
            this.btnOdgovori.UseMnemonic = false;
            this.btnOdgovori.UseVisualStyleBackColor = false;
            this.btnOdgovori.Click += new System.EventHandler(this.btnOdgovori_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(793, 10);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // lblPending
            // 
            this.lblPending.BackColor = System.Drawing.Color.Transparent;
            this.lblPending.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPending.ForeColor = System.Drawing.Color.LightCoral;
            this.lblPending.Location = new System.Drawing.Point(19, 10);
            this.lblPending.Name = "lblPending";
            this.lblPending.Size = new System.Drawing.Size(16, 20);
            this.lblPending.TabIndex = 19;
            this.lblPending.Text = "!";
            this.lblPending.Visible = false;
            // 
            // ToolServiceCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblPending);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnOdgovori);
            this.Controls.Add(this.btnUkloni);
            this.Controls.Add(this.btnDetalji);
            this.Controls.Add(this.valDetails);
            this.Controls.Add(this.valCompanyName);
            this.Name = "ToolServiceCard";
            this.Size = new System.Drawing.Size(805, 60);
            this.Load += new System.EventHandler(this.ToolServiceCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label valCompanyName;
        private System.Windows.Forms.Label valDetails;
        private System.Windows.Forms.Button btnUkloni;
        private System.Windows.Forms.Button btnDetalji;
        private System.Windows.Forms.Button btnOdgovori;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblPending;
    }
}
