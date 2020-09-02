namespace EToolService.Desktop.Forms.Request
{
    partial class frmRequestsDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRequestsDetail));
            this.pnlRequests = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.lblPurpose = new System.Windows.Forms.Label();
            this.lblAction = new System.Windows.Forms.Label();
            this.btnNext = new XanderUI.XUIButton();
            this.btnPrevious = new XanderUI.XUIButton();
            this.lblPageCounter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pnlRequests
            // 
            this.pnlRequests.AutoScroll = true;
            this.pnlRequests.Location = new System.Drawing.Point(12, 134);
            this.pnlRequests.Name = "pnlRequests";
            this.pnlRequests.Size = new System.Drawing.Size(603, 170);
            this.pnlRequests.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(204, 42);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(230, 34);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Pregled zahtjeva";
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployee.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblEmployee.Location = new System.Drawing.Point(36, 109);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(74, 16);
            this.lblEmployee.TabIndex = 4;
            this.lblEmployee.Text = "Uposlenik";
            // 
            // lblPurpose
            // 
            this.lblPurpose.AutoSize = true;
            this.lblPurpose.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPurpose.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblPurpose.Location = new System.Drawing.Point(156, 109);
            this.lblPurpose.Name = "lblPurpose";
            this.lblPurpose.Size = new System.Drawing.Size(44, 16);
            this.lblPurpose.TabIndex = 5;
            this.lblPurpose.Text = "Svrha";
            // 
            // lblAction
            // 
            this.lblAction.AutoSize = true;
            this.lblAction.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAction.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblAction.Location = new System.Drawing.Point(481, 109);
            this.lblAction.Name = "lblAction";
            this.lblAction.Size = new System.Drawing.Size(49, 16);
            this.lblAction.TabIndex = 6;
            this.lblAction.Text = "Akcija";
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
            this.btnNext.Location = new System.Drawing.Point(339, 326);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(31, 23);
            this.btnNext.TabIndex = 10;
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
            this.btnPrevious.Location = new System.Drawing.Point(258, 326);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(30, 23);
            this.btnPrevious.TabIndex = 9;
            this.btnPrevious.TextColor = System.Drawing.Color.Black;
            this.btnPrevious.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // lblPageCounter
            // 
            this.lblPageCounter.AutoSize = true;
            this.lblPageCounter.Location = new System.Drawing.Point(586, 329);
            this.lblPageCounter.Name = "lblPageCounter";
            this.lblPageCounter.Size = new System.Drawing.Size(0, 13);
            this.lblPageCounter.TabIndex = 11;
            // 
            // frmRequestsDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 370);
            this.Controls.Add(this.lblPageCounter);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.lblAction);
            this.Controls.Add(this.lblPurpose);
            this.Controls.Add(this.lblEmployee);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pnlRequests);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRequestsDetail";
            this.Text = "frmRequestsDetail";
            this.Load += new System.EventHandler(this.frmRequestsDetail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlRequests;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.Label lblPurpose;
        private System.Windows.Forms.Label lblAction;
        private XanderUI.XUIButton btnNext;
        private XanderUI.XUIButton btnPrevious;
        private System.Windows.Forms.Label lblPageCounter;
    }
}