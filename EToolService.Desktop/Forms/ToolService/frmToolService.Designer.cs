namespace EToolService.Desktop.Forms.ToolService
{
    partial class frmToolService
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmToolService));
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNext = new XanderUI.XUIButton();
            this.btnPrevious = new XanderUI.XUIButton();
            this.lblPage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(297, -2);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(234, 34);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Zahtjevi za servis";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(805, 219);
            this.panel1.TabIndex = 5;
            // 
            // btnNext
            // 
            this.btnNext.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnNext.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnNext.ButtonImage")));
            this.btnNext.ButtonStyle = XanderUI.XUIButton.Style.Material;
            this.btnNext.ButtonText = "";
            this.btnNext.ClickBackColor = System.Drawing.Color.Black;
            this.btnNext.ClickTextColor = System.Drawing.Color.Black;
            this.btnNext.CornerRadius = 5;
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnNext.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnNext.HoverBackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.btnNext.HoverTextColor = System.Drawing.Color.White;
            this.btnNext.ImagePosition = XanderUI.XUIButton.imgPosition.Center;
            this.btnNext.Location = new System.Drawing.Point(441, 329);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(31, 23);
            this.btnNext.TabIndex = 12;
            this.btnNext.TextColor = System.Drawing.Color.Black;
            this.btnNext.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnPrevious.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnPrevious.ButtonImage")));
            this.btnPrevious.ButtonStyle = XanderUI.XUIButton.Style.Material;
            this.btnPrevious.ButtonText = "";
            this.btnPrevious.ClickBackColor = System.Drawing.Color.Black;
            this.btnPrevious.ClickTextColor = System.Drawing.Color.Black;
            this.btnPrevious.CornerRadius = 5;
            this.btnPrevious.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnPrevious.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnPrevious.HoverBackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.btnPrevious.HoverTextColor = System.Drawing.Color.White;
            this.btnPrevious.ImagePosition = XanderUI.XUIButton.imgPosition.Center;
            this.btnPrevious.Location = new System.Drawing.Point(360, 329);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(30, 23);
            this.btnPrevious.TabIndex = 11;
            this.btnPrevious.TextColor = System.Drawing.Color.Black;
            this.btnPrevious.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // lblPage
            // 
            this.lblPage.AutoSize = true;
            this.lblPage.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPage.Location = new System.Drawing.Point(766, 338);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(51, 14);
            this.lblPage.TabIndex = 14;
            this.lblPage.Text = "Stranica";
            this.lblPage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmToolService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 376);
            this.Controls.Add(this.lblPage);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmToolService";
            this.Text = "frmToolService";
            this.Load += new System.EventHandler(this.frmToolService_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel1;
        private XanderUI.XUIButton btnNext;
        private XanderUI.XUIButton btnPrevious;
        private Loader loader1;
        private System.Windows.Forms.Label lblPage;
    }
}