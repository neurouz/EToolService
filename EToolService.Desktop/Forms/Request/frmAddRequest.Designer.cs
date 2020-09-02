namespace EToolService.Desktop.Forms.Request
{
    partial class frmAddRequest
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddRequest));
            this.lblEmployee = new System.Windows.Forms.Label();
            this.comboEmployee = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPurpose = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnAddRequest = new XanderUI.XUIButton();
            this.errProviderRequestAdd = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errProviderRequestAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployee.Location = new System.Drawing.Point(255, 78);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(129, 14);
            this.lblEmployee.TabIndex = 0;
            this.lblEmployee.Text = "Odaberite uposlenika*";
            // 
            // comboEmployee
            // 
            this.comboEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboEmployee.FormattingEnabled = true;
            this.comboEmployee.Location = new System.Drawing.Point(222, 94);
            this.comboEmployee.Name = "comboEmployee";
            this.comboEmployee.Size = new System.Drawing.Size(191, 21);
            this.comboEmployee.TabIndex = 1;
            this.comboEmployee.Validating += new System.ComponentModel.CancelEventHandler(this.comboEmployee_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(244, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "Svrha izdavanja zahtjeva*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(273, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "Opis zahtjeva";
            // 
            // txtPurpose
            // 
            this.txtPurpose.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPurpose.Location = new System.Drawing.Point(137, 153);
            this.txtPurpose.Multiline = true;
            this.txtPurpose.Name = "txtPurpose";
            this.txtPurpose.Size = new System.Drawing.Size(352, 20);
            this.txtPurpose.TabIndex = 4;
            this.txtPurpose.Validating += new System.ComponentModel.CancelEventHandler(this.txtPurpose_Validating);
            // 
            // txtDescription
            // 
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescription.Location = new System.Drawing.Point(64, 212);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(511, 96);
            this.txtDescription.TabIndex = 5;
            this.txtDescription.Text = "";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(232, 19);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(176, 34);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Novi zahtjev";
            // 
            // btnAddRequest
            // 
            this.btnAddRequest.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnAddRequest.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnAddRequest.ButtonImage")));
            this.btnAddRequest.ButtonStyle = XanderUI.XUIButton.Style.Material;
            this.btnAddRequest.ButtonText = "Evidentiraj zahtjev";
            this.btnAddRequest.ClickBackColor = System.Drawing.Color.GhostWhite;
            this.btnAddRequest.ClickTextColor = System.Drawing.Color.Black;
            this.btnAddRequest.CornerRadius = 5;
            this.btnAddRequest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddRequest.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnAddRequest.HoverBackgroundColor = System.Drawing.Color.GhostWhite;
            this.btnAddRequest.HoverTextColor = System.Drawing.Color.Black;
            this.btnAddRequest.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnAddRequest.Location = new System.Drawing.Point(244, 320);
            this.btnAddRequest.Name = "btnAddRequest";
            this.btnAddRequest.Size = new System.Drawing.Size(150, 38);
            this.btnAddRequest.TabIndex = 7;
            this.btnAddRequest.TextColor = System.Drawing.Color.Black;
            this.btnAddRequest.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnAddRequest.Click += new System.EventHandler(this.btnAddRequest_Click);
            // 
            // errProviderRequestAdd
            // 
            this.errProviderRequestAdd.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errProviderRequestAdd.ContainerControl = this;
            this.errProviderRequestAdd.Icon = ((System.Drawing.Icon)(resources.GetObject("errProviderRequestAdd.Icon")));
            // 
            // frmAddRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 370);
            this.Controls.Add(this.btnAddRequest);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtPurpose);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboEmployee);
            this.Controls.Add(this.lblEmployee);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddRequest";
            this.Text = "frmAddRequest";
            this.Load += new System.EventHandler(this.frmAddRequest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errProviderRequestAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.ComboBox comboEmployee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPurpose;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.Label lblTitle;
        private XanderUI.XUIButton btnAddRequest;
        private System.Windows.Forms.ErrorProvider errProviderRequestAdd;
    }
}