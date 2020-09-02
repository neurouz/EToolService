namespace EToolService.Desktop.Forms.Employee
{
    partial class frmEmployeeDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployeeDetails));
            this.lblDetails = new System.Windows.Forms.Label();
            this.lblIme = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblContract = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblActive = new System.Windows.Forms.Label();
            this.lblRequestNumber = new System.Windows.Forms.Label();
            this.valID = new System.Windows.Forms.Label();
            this.valName = new System.Windows.Forms.Label();
            this.valSurname = new System.Windows.Forms.Label();
            this.valPosition = new System.Windows.Forms.Label();
            this.valRequestNumber = new System.Windows.Forms.Label();
            this.valActive = new System.Windows.Forms.Label();
            this.valSalary = new System.Windows.Forms.Label();
            this.valContractDate = new System.Windows.Forms.Label();
            this.lstMachines = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.xuiButton1 = new XanderUI.XUIButton();
            this.btnMachineDetails = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetails.Location = new System.Drawing.Point(187, 36);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(271, 34);
            this.lblDetails.TabIndex = 2;
            this.lblDetails.Text = "Detalji o uposleniku";
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIme.Location = new System.Drawing.Point(189, 113);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(22, 16);
            this.lblIme.TabIndex = 4;
            this.lblIme.Text = "ID";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(180, 140);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(33, 16);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Ime";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.Location = new System.Drawing.Point(153, 167);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(62, 16);
            this.lblSurname.TabIndex = 6;
            this.lblSurname.Text = "Prezime";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.Location = new System.Drawing.Point(112, 194);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(105, 16);
            this.lblPosition.TabIndex = 7;
            this.lblPosition.Text = "Radna pozicija";
            // 
            // lblContract
            // 
            this.lblContract.AutoSize = true;
            this.lblContract.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContract.Location = new System.Drawing.Point(54, 222);
            this.lblContract.Name = "lblContract";
            this.lblContract.Size = new System.Drawing.Size(163, 16);
            this.lblContract.TabIndex = 8;
            this.lblContract.Text = "Datum potpisa ugovora";
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.Location = new System.Drawing.Point(176, 249);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(42, 16);
            this.lblSalary.TabIndex = 9;
            this.lblSalary.Text = "Plata";
            // 
            // lblActive
            // 
            this.lblActive.AutoSize = true;
            this.lblActive.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActive.Location = new System.Drawing.Point(101, 276);
            this.lblActive.Name = "lblActive";
            this.lblActive.Size = new System.Drawing.Size(118, 16);
            this.lblActive.TabIndex = 10;
            this.lblActive.Text = "Trenutno aktivan";
            // 
            // lblRequestNumber
            // 
            this.lblRequestNumber.AutoSize = true;
            this.lblRequestNumber.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequestNumber.Location = new System.Drawing.Point(128, 302);
            this.lblRequestNumber.Name = "lblRequestNumber";
            this.lblRequestNumber.Size = new System.Drawing.Size(93, 16);
            this.lblRequestNumber.TabIndex = 11;
            this.lblRequestNumber.Text = "Broj zahtjeva";
            // 
            // valID
            // 
            this.valID.AutoSize = true;
            this.valID.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valID.Location = new System.Drawing.Point(234, 113);
            this.valID.Name = "valID";
            this.valID.Size = new System.Drawing.Size(0, 16);
            this.valID.TabIndex = 12;
            // 
            // valName
            // 
            this.valName.AutoSize = true;
            this.valName.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valName.Location = new System.Drawing.Point(234, 140);
            this.valName.Name = "valName";
            this.valName.Size = new System.Drawing.Size(0, 16);
            this.valName.TabIndex = 13;
            // 
            // valSurname
            // 
            this.valSurname.AutoSize = true;
            this.valSurname.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valSurname.Location = new System.Drawing.Point(234, 167);
            this.valSurname.Name = "valSurname";
            this.valSurname.Size = new System.Drawing.Size(0, 16);
            this.valSurname.TabIndex = 14;
            // 
            // valPosition
            // 
            this.valPosition.AutoSize = true;
            this.valPosition.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valPosition.Location = new System.Drawing.Point(234, 194);
            this.valPosition.Name = "valPosition";
            this.valPosition.Size = new System.Drawing.Size(0, 16);
            this.valPosition.TabIndex = 15;
            // 
            // valRequestNumber
            // 
            this.valRequestNumber.AutoSize = true;
            this.valRequestNumber.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valRequestNumber.Location = new System.Drawing.Point(234, 302);
            this.valRequestNumber.Name = "valRequestNumber";
            this.valRequestNumber.Size = new System.Drawing.Size(0, 16);
            this.valRequestNumber.TabIndex = 19;
            // 
            // valActive
            // 
            this.valActive.AutoSize = true;
            this.valActive.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valActive.Location = new System.Drawing.Point(234, 275);
            this.valActive.Name = "valActive";
            this.valActive.Size = new System.Drawing.Size(0, 16);
            this.valActive.TabIndex = 18;
            // 
            // valSalary
            // 
            this.valSalary.AutoSize = true;
            this.valSalary.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valSalary.Location = new System.Drawing.Point(234, 248);
            this.valSalary.Name = "valSalary";
            this.valSalary.Size = new System.Drawing.Size(0, 16);
            this.valSalary.TabIndex = 17;
            // 
            // valContractDate
            // 
            this.valContractDate.AutoSize = true;
            this.valContractDate.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valContractDate.Location = new System.Drawing.Point(234, 221);
            this.valContractDate.Name = "valContractDate";
            this.valContractDate.Size = new System.Drawing.Size(0, 16);
            this.valContractDate.TabIndex = 16;
            // 
            // lstMachines
            // 
            this.lstMachines.BackColor = System.Drawing.SystemColors.Control;
            this.lstMachines.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstMachines.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstMachines.ItemHeight = 20;
            this.lstMachines.Location = new System.Drawing.Point(410, 173);
            this.lstMachines.Name = "lstMachines";
            this.lstMachines.Size = new System.Drawing.Size(205, 97);
            this.lstMachines.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(407, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Zadužene mašine";
            // 
            // xuiButton1
            // 
            this.xuiButton1.BackgroundColor = System.Drawing.Color.Transparent;
            this.xuiButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.xuiButton1.ButtonImage = ((System.Drawing.Image)(resources.GetObject("xuiButton1.ButtonImage")));
            this.xuiButton1.ButtonStyle = XanderUI.XUIButton.Style.Material;
            this.xuiButton1.ButtonText = "";
            this.xuiButton1.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.xuiButton1.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton1.CornerRadius = 5;
            this.xuiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.xuiButton1.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuiButton1.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton1.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.xuiButton1.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton1.ImagePosition = XanderUI.XUIButton.imgPosition.Center;
            this.xuiButton1.Location = new System.Drawing.Point(509, 324);
            this.xuiButton1.Name = "xuiButton1";
            this.xuiButton1.Size = new System.Drawing.Size(86, 29);
            this.xuiButton1.TabIndex = 22;
            this.xuiButton1.TextColor = System.Drawing.Color.Black;
            this.xuiButton1.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton1.Click += new System.EventHandler(this.xuiButton1_Click);
            // 
            // btnMachineDetails
            // 
            this.btnMachineDetails.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnMachineDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMachineDetails.Font = new System.Drawing.Font("Montserrat", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMachineDetails.ForeColor = System.Drawing.Color.White;
            this.btnMachineDetails.Location = new System.Drawing.Point(534, 144);
            this.btnMachineDetails.Name = "btnMachineDetails";
            this.btnMachineDetails.Size = new System.Drawing.Size(61, 20);
            this.btnMachineDetails.TabIndex = 23;
            this.btnMachineDetails.Text = "Detalji";
            this.btnMachineDetails.UseVisualStyleBackColor = false;
            this.btnMachineDetails.Click += new System.EventHandler(this.btnMachineDetails_Click);
            // 
            // frmEmployeeDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 375);
            this.Controls.Add(this.btnMachineDetails);
            this.Controls.Add(this.xuiButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstMachines);
            this.Controls.Add(this.valRequestNumber);
            this.Controls.Add(this.valActive);
            this.Controls.Add(this.valSalary);
            this.Controls.Add(this.valContractDate);
            this.Controls.Add(this.valPosition);
            this.Controls.Add(this.valSurname);
            this.Controls.Add(this.valName);
            this.Controls.Add(this.valID);
            this.Controls.Add(this.lblRequestNumber);
            this.Controls.Add(this.lblActive);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.lblContract);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.lblDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEmployeeDetails";
            this.Text = "Detalji o uposleniku";
            this.Load += new System.EventHandler(this.frmEmployeeDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblContract;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lblActive;
        private System.Windows.Forms.Label lblRequestNumber;
        private System.Windows.Forms.Label valID;
        private System.Windows.Forms.Label valName;
        private System.Windows.Forms.Label valSurname;
        private System.Windows.Forms.Label valPosition;
        private System.Windows.Forms.Label valRequestNumber;
        private System.Windows.Forms.Label valActive;
        private System.Windows.Forms.Label valSalary;
        private System.Windows.Forms.Label valContractDate;
        private System.Windows.Forms.TreeView lstMachines;
        private System.Windows.Forms.Label label1;
        private XanderUI.XUIButton xuiButton1;
        private System.Windows.Forms.Button btnMachineDetails;
    }
}