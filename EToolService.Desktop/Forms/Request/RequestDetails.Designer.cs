namespace EToolService.Desktop.Forms.Request
{
    partial class RequestDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RequestDetails));
            this.btnCLose = new XanderUI.XUIButton();
            this.lblID = new System.Windows.Forms.Label();
            this.lblDateCreated = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblPurpose = new System.Windows.Forms.Label();
            this.lblPhase = new System.Windows.Forms.Label();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.valID = new System.Windows.Forms.Label();
            this.valEmployee = new System.Windows.Forms.Label();
            this.valDate = new System.Windows.Forms.Label();
            this.valDescription = new System.Windows.Forms.Label();
            this.valPurpose = new System.Windows.Forms.Label();
            this.valPhase = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
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
            this.btnCLose.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCLose.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnCLose.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnCLose.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnCLose.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnCLose.Location = new System.Drawing.Point(422, 241);
            this.btnCLose.Name = "btnCLose";
            this.btnCLose.Size = new System.Drawing.Size(91, 34);
            this.btnCLose.TabIndex = 1;
            this.btnCLose.TextColor = System.Drawing.Color.Black;
            this.btnCLose.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnCLose.Click += new System.EventHandler(this.btnCLose_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(143, 65);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(22, 14);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "ID:";
            // 
            // lblDateCreated
            // 
            this.lblDateCreated.AutoSize = true;
            this.lblDateCreated.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateCreated.Location = new System.Drawing.Point(57, 118);
            this.lblDateCreated.Name = "lblDateCreated";
            this.lblDateCreated.Size = new System.Drawing.Size(103, 14);
            this.lblDateCreated.TabIndex = 3;
            this.lblDateCreated.Text = "Datum kreiranja:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(130, 145);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(35, 14);
            this.lblDescription.TabIndex = 4;
            this.lblDescription.Text = "Opis:";
            // 
            // lblPurpose
            // 
            this.lblPurpose.AutoSize = true;
            this.lblPurpose.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPurpose.Location = new System.Drawing.Point(122, 200);
            this.lblPurpose.Name = "lblPurpose";
            this.lblPurpose.Size = new System.Drawing.Size(42, 14);
            this.lblPurpose.TabIndex = 5;
            this.lblPurpose.Text = "Svrha:";
            // 
            // lblPhase
            // 
            this.lblPhase.AutoSize = true;
            this.lblPhase.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhase.Location = new System.Drawing.Point(128, 227);
            this.lblPhase.Name = "lblPhase";
            this.lblPhase.Size = new System.Drawing.Size(37, 14);
            this.lblPhase.TabIndex = 6;
            this.lblPhase.Text = "Faza:";
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployee.Location = new System.Drawing.Point(95, 91);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(65, 14);
            this.lblEmployee.TabIndex = 7;
            this.lblEmployee.Text = "Uposlenik:";
            // 
            // valID
            // 
            this.valID.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valID.Location = new System.Drawing.Point(190, 65);
            this.valID.Name = "valID";
            this.valID.Size = new System.Drawing.Size(125, 13);
            this.valID.TabIndex = 8;
            this.valID.Text = "id";
            // 
            // valEmployee
            // 
            this.valEmployee.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valEmployee.Location = new System.Drawing.Point(190, 91);
            this.valEmployee.Name = "valEmployee";
            this.valEmployee.Size = new System.Drawing.Size(226, 13);
            this.valEmployee.TabIndex = 9;
            this.valEmployee.Text = "ime i prezime";
            // 
            // valDate
            // 
            this.valDate.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valDate.Location = new System.Drawing.Point(190, 118);
            this.valDate.Name = "valDate";
            this.valDate.Size = new System.Drawing.Size(185, 13);
            this.valDate.TabIndex = 10;
            this.valDate.Text = "dd/MM/yyyy";
            // 
            // valDescription
            // 
            this.valDescription.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valDescription.Location = new System.Drawing.Point(190, 145);
            this.valDescription.Name = "valDescription";
            this.valDescription.Size = new System.Drawing.Size(286, 47);
            this.valDescription.TabIndex = 11;
            this.valDescription.Text = "Description";
            // 
            // valPurpose
            // 
            this.valPurpose.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valPurpose.Location = new System.Drawing.Point(190, 200);
            this.valPurpose.Name = "valPurpose";
            this.valPurpose.Size = new System.Drawing.Size(301, 13);
            this.valPurpose.TabIndex = 12;
            this.valPurpose.Text = "Svrha zahtjeva";
            // 
            // valPhase
            // 
            this.valPhase.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valPhase.Location = new System.Drawing.Point(190, 227);
            this.valPhase.Name = "valPhase";
            this.valPhase.Size = new System.Drawing.Size(155, 13);
            this.valPhase.TabIndex = 13;
            this.valPhase.Text = "Odobren";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(210, 19);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(146, 19);
            this.lblTitle.TabIndex = 14;
            this.lblTitle.Text = "Detalji o zahtjevu";
            // 
            // RequestDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 287);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.valPhase);
            this.Controls.Add(this.valPurpose);
            this.Controls.Add(this.valDescription);
            this.Controls.Add(this.valDate);
            this.Controls.Add(this.valEmployee);
            this.Controls.Add(this.valID);
            this.Controls.Add(this.lblEmployee);
            this.Controls.Add(this.lblPhase);
            this.Controls.Add(this.lblPurpose);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblDateCreated);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnCLose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RequestDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalji";
            this.Load += new System.EventHandler(this.RequestDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private XanderUI.XUIButton btnCLose;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblDateCreated;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblPurpose;
        private System.Windows.Forms.Label lblPhase;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.Label valID;
        private System.Windows.Forms.Label valEmployee;
        private System.Windows.Forms.Label valDate;
        private System.Windows.Forms.Label valDescription;
        private System.Windows.Forms.Label valPurpose;
        private System.Windows.Forms.Label valPhase;
        private System.Windows.Forms.Label lblTitle;
    }
}