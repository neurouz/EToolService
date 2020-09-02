namespace EToolService.Desktop.Forms.ToolService
{
    partial class frmServiceResponse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmServiceResponse));
            this.txtTitle = new System.Windows.Forms.Label();
            this.btnCLose = new XanderUI.XUIButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDateTime = new System.Windows.Forms.DateTimePicker();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtExplanation = new System.Windows.Forms.RichTextBox();
            this.chkApproved = new System.Windows.Forms.CheckBox();
            this.btnRespond = new XanderUI.XUIButton();
            this.SuspendLayout();
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtTitle.Location = new System.Drawing.Point(143, 34);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(363, 26);
            this.txtTitle.TabIndex = 43;
            this.txtTitle.Text = "Odgovor na zahtjev za servis";
            this.txtTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.btnCLose.Location = new System.Drawing.Point(557, 342);
            this.btnCLose.Name = "btnCLose";
            this.btnCLose.Size = new System.Drawing.Size(91, 34);
            this.btnCLose.TabIndex = 44;
            this.btnCLose.TextColor = System.Drawing.Color.Black;
            this.btnCLose.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnCLose.Click += new System.EventHandler(this.btnCLose_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(110, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 19);
            this.label5.TabIndex = 47;
            this.label5.Text = "Objašnjenje:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(88, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 19);
            this.label3.TabIndex = 46;
            this.label3.Text = "Predložena cijena:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(92, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 19);
            this.label7.TabIndex = 45;
            this.label7.Text = "Datum završetka:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 19);
            this.label1.TabIndex = 48;
            this.label1.Text = "Odobreno:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // txtDateTime
            // 
            this.txtDateTime.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDateTime.Location = new System.Drawing.Point(247, 105);
            this.txtDateTime.Name = "txtDateTime";
            this.txtDateTime.Size = new System.Drawing.Size(117, 21);
            this.txtDateTime.TabIndex = 50;
            this.txtDateTime.Value = new System.DateTime(2020, 8, 22, 0, 0, 0, 0);
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.SystemColors.Window;
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrice.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(247, 138);
            this.txtPrice.Multiline = true;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(314, 20);
            this.txtPrice.TabIndex = 49;
            // 
            // txtExplanation
            // 
            this.txtExplanation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtExplanation.Location = new System.Drawing.Point(247, 170);
            this.txtExplanation.Name = "txtExplanation";
            this.txtExplanation.Size = new System.Drawing.Size(314, 96);
            this.txtExplanation.TabIndex = 51;
            this.txtExplanation.Text = "";
            // 
            // chkApproved
            // 
            this.chkApproved.AutoSize = true;
            this.chkApproved.Checked = true;
            this.chkApproved.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkApproved.Location = new System.Drawing.Point(247, 286);
            this.chkApproved.Name = "chkApproved";
            this.chkApproved.Size = new System.Drawing.Size(14, 13);
            this.chkApproved.TabIndex = 52;
            this.chkApproved.UseVisualStyleBackColor = true;
            // 
            // btnRespond
            // 
            this.btnRespond.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnRespond.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnRespond.ButtonImage")));
            this.btnRespond.ButtonStyle = XanderUI.XUIButton.Style.Material;
            this.btnRespond.ButtonText = "Odgovori";
            this.btnRespond.ClickBackColor = System.Drawing.Color.GhostWhite;
            this.btnRespond.ClickTextColor = System.Drawing.Color.Black;
            this.btnRespond.CornerRadius = 5;
            this.btnRespond.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRespond.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRespond.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnRespond.HoverBackgroundColor = System.Drawing.Color.GhostWhite;
            this.btnRespond.HoverTextColor = System.Drawing.Color.Black;
            this.btnRespond.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnRespond.Location = new System.Drawing.Point(271, 326);
            this.btnRespond.Name = "btnRespond";
            this.btnRespond.Size = new System.Drawing.Size(133, 38);
            this.btnRespond.TabIndex = 53;
            this.btnRespond.TextColor = System.Drawing.Color.DarkSlateGray;
            this.btnRespond.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnRespond.Click += new System.EventHandler(this.btnRespond_Click);
            // 
            // frmServiceResponse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 388);
            this.Controls.Add(this.btnRespond);
            this.Controls.Add(this.chkApproved);
            this.Controls.Add(this.txtExplanation);
            this.Controls.Add(this.txtDateTime);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCLose);
            this.Controls.Add(this.txtTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmServiceResponse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Odgovor na zahtjev";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtTitle;
        private XanderUI.XUIButton btnCLose;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker txtDateTime;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.RichTextBox txtExplanation;
        private System.Windows.Forms.CheckBox chkApproved;
        private XanderUI.XUIButton btnRespond;
    }
}