namespace EToolService.Desktop.Forms.Machine
{
    partial class frmMachineDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMachineDetails));
            this.btnCLose = new XanderUI.XUIButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlMachines = new System.Windows.Forms.Panel();
            this.SuspendLayout();
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
            this.btnCLose.Location = new System.Drawing.Point(501, 273);
            this.btnCLose.Name = "btnCLose";
            this.btnCLose.Size = new System.Drawing.Size(91, 34);
            this.btnCLose.TabIndex = 0;
            this.btnCLose.TextColor = System.Drawing.Color.Black;
            this.btnCLose.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnCLose.Click += new System.EventHandler(this.btnCLose_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoEllipsis = true;
            this.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitle.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(107, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTitle.Size = new System.Drawing.Size(397, 24);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlMachines
            // 
            this.pnlMachines.AutoScroll = true;
            this.pnlMachines.Location = new System.Drawing.Point(58, 68);
            this.pnlMachines.Name = "pnlMachines";
            this.pnlMachines.Size = new System.Drawing.Size(499, 183);
            this.pnlMachines.TabIndex = 3;
            // 
            // frmMachineDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 319);
            this.Controls.Add(this.pnlMachines);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnCLose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmMachineDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalji o mašinama";
            this.Load += new System.EventHandler(this.frmMachineDetails_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private XanderUI.XUIButton btnCLose;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlMachines;
    }
}