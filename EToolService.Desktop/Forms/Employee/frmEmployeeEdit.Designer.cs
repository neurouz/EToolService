namespace EToolService.Desktop.Forms.Employee
{
    partial class frmEmployeeEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployeeEdit));
            this.lblActive = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblContract = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtContractDate = new System.Windows.Forms.DateTimePicker();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.lblDetails = new System.Windows.Forms.Label();
            this.employeeEditErrorPovider = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnAddMachine = new XanderUI.XUIButton();
            this.btnAddRequest = new XanderUI.XUIButton();
            ((System.ComponentModel.ISupportInitialize)(this.employeeEditErrorPovider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblActive
            // 
            this.lblActive.AutoSize = true;
            this.lblActive.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActive.Location = new System.Drawing.Point(137, 243);
            this.lblActive.Name = "lblActive";
            this.lblActive.Size = new System.Drawing.Size(118, 16);
            this.lblActive.TabIndex = 16;
            this.lblActive.Text = "Trenutno aktivan";
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.Location = new System.Drawing.Point(212, 216);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(42, 16);
            this.lblSalary.TabIndex = 15;
            this.lblSalary.Text = "Plata";
            // 
            // lblContract
            // 
            this.lblContract.AutoSize = true;
            this.lblContract.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContract.Location = new System.Drawing.Point(90, 189);
            this.lblContract.Name = "lblContract";
            this.lblContract.Size = new System.Drawing.Size(163, 16);
            this.lblContract.TabIndex = 14;
            this.lblContract.Text = "Datum potpisa ugovora";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.Location = new System.Drawing.Point(148, 161);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(105, 16);
            this.lblPosition.TabIndex = 13;
            this.lblPosition.Text = "Radna pozicija";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.Location = new System.Drawing.Point(189, 134);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(62, 16);
            this.lblSurname.TabIndex = 12;
            this.lblSurname.Text = "Prezime";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(216, 107);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(33, 16);
            this.lblName.TabIndex = 11;
            this.lblName.Text = "Ime";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(269, 106);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(289, 20);
            this.txtName.TabIndex = 17;
            this.txtName.Validating += new System.ComponentModel.CancelEventHandler(this.txtName_Validating);
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(269, 132);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(289, 20);
            this.txtSurname.TabIndex = 18;
            this.txtSurname.Validating += new System.ComponentModel.CancelEventHandler(this.txtSurname_Validating);
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(269, 158);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(289, 20);
            this.txtPosition.TabIndex = 19;
            this.txtPosition.Validating += new System.ComponentModel.CancelEventHandler(this.txtPosition_Validating);
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(269, 214);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(289, 20);
            this.txtSalary.TabIndex = 21;
            this.txtSalary.Validating += new System.ComponentModel.CancelEventHandler(this.txtSalary_Validating);
            // 
            // txtContractDate
            // 
            this.txtContractDate.Location = new System.Drawing.Point(269, 187);
            this.txtContractDate.Name = "txtContractDate";
            this.txtContractDate.Size = new System.Drawing.Size(289, 20);
            this.txtContractDate.TabIndex = 22;
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.Location = new System.Drawing.Point(269, 245);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(14, 13);
            this.chkActive.TabIndex = 23;
            this.chkActive.UseVisualStyleBackColor = true;
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetails.Location = new System.Drawing.Point(182, 33);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(300, 34);
            this.lblDetails.TabIndex = 25;
            this.lblDetails.Text = "Uređivanje uposlenika";
            // 
            // employeeEditErrorPovider
            // 
            this.employeeEditErrorPovider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.employeeEditErrorPovider.ContainerControl = this;
            this.employeeEditErrorPovider.Icon = ((System.Drawing.Icon)(resources.GetObject("employeeEditErrorPovider.Icon")));
            // 
            // btnAddMachine
            // 
            this.btnAddMachine.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnAddMachine.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnAddMachine.ButtonImage")));
            this.btnAddMachine.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnAddMachine.ButtonText = "Dodijeli novu mašinu";
            this.btnAddMachine.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnAddMachine.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnAddMachine.CornerRadius = 5;
            this.btnAddMachine.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMachine.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnAddMachine.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnAddMachine.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnAddMachine.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnAddMachine.Location = new System.Drawing.Point(12, 325);
            this.btnAddMachine.Name = "btnAddMachine";
            this.btnAddMachine.Size = new System.Drawing.Size(167, 32);
            this.btnAddMachine.TabIndex = 26;
            this.btnAddMachine.TextColor = System.Drawing.Color.Teal;
            this.btnAddMachine.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnAddMachine.Click += new System.EventHandler(this.btnAddMachine_Click);
            // 
            // btnAddRequest
            // 
            this.btnAddRequest.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnAddRequest.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnAddRequest.ButtonImage")));
            this.btnAddRequest.ButtonStyle = XanderUI.XUIButton.Style.Material;
            this.btnAddRequest.ButtonText = "Sačuvaj promjene";
            this.btnAddRequest.ClickBackColor = System.Drawing.Color.GhostWhite;
            this.btnAddRequest.ClickTextColor = System.Drawing.Color.Black;
            this.btnAddRequest.CornerRadius = 5;
            this.btnAddRequest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddRequest.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRequest.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnAddRequest.HoverBackgroundColor = System.Drawing.Color.GhostWhite;
            this.btnAddRequest.HoverTextColor = System.Drawing.Color.Black;
            this.btnAddRequest.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnAddRequest.Location = new System.Drawing.Point(257, 308);
            this.btnAddRequest.Name = "btnAddRequest";
            this.btnAddRequest.Size = new System.Drawing.Size(166, 38);
            this.btnAddRequest.TabIndex = 27;
            this.btnAddRequest.TextColor = System.Drawing.Color.DarkOrchid;
            this.btnAddRequest.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnAddRequest.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // frmEmployeeEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 369);
            this.Controls.Add(this.btnAddRequest);
            this.Controls.Add(this.btnAddMachine);
            this.Controls.Add(this.lblDetails);
            this.Controls.Add(this.chkActive);
            this.Controls.Add(this.txtContractDate);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtPosition);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblActive);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.lblContract);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmEmployeeEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Promjena podataka";
            this.Load += new System.EventHandler(this.frmEmployeeEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeeEditErrorPovider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblActive;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lblContract;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.DateTimePicker txtContractDate;
        private System.Windows.Forms.CheckBox chkActive;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.ErrorProvider employeeEditErrorPovider;
        private XanderUI.XUIButton btnAddMachine;
        private XanderUI.XUIButton btnAddRequest;
    }
}