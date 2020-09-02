namespace EToolService.Desktop.Forms.Employee
{
    partial class frmEmployeeAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployeeAdd));
            this.lblAddEmployee = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblIme = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblPosition = new System.Windows.Forms.Label();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPlata = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtDateTime = new System.Windows.Forms.DateTimePicker();
            this.btnAddEmployee = new XanderUI.XUIButton();
            this.lblWarning = new System.Windows.Forms.Label();
            this.errProviderEmployeeAdd = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errProviderEmployeeAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAddEmployee
            // 
            this.lblAddEmployee.AutoSize = true;
            this.lblAddEmployee.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddEmployee.Location = new System.Drawing.Point(205, 35);
            this.lblAddEmployee.Name = "lblAddEmployee";
            this.lblAddEmployee.Size = new System.Drawing.Size(238, 34);
            this.lblAddEmployee.TabIndex = 1;
            this.lblAddEmployee.Text = "Dodaj uposlenika";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.Window;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(263, 100);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(263, 20);
            this.txtName.TabIndex = 2;
            this.txtName.Validating += new System.ComponentModel.CancelEventHandler(this.txtName_Validating);
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIme.Location = new System.Drawing.Point(221, 103);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(33, 14);
            this.lblIme.TabIndex = 3;
            this.lblIme.Text = "Ime*";
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrezime.Location = new System.Drawing.Point(201, 141);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(58, 14);
            this.lblPrezime.TabIndex = 5;
            this.lblPrezime.Text = "Prezime*";
            // 
            // txtSurname
            // 
            this.txtSurname.BackColor = System.Drawing.SystemColors.Window;
            this.txtSurname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSurname.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSurname.Location = new System.Drawing.Point(263, 138);
            this.txtSurname.Multiline = true;
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(263, 20);
            this.txtSurname.TabIndex = 4;
            this.txtSurname.Validating += new System.ComponentModel.CancelEventHandler(this.txtSurname_Validating);
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.Location = new System.Drawing.Point(202, 180);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(54, 14);
            this.lblPosition.TabIndex = 7;
            this.lblPosition.Text = "Pozicija*";
            // 
            // txtPosition
            // 
            this.txtPosition.BackColor = System.Drawing.SystemColors.Window;
            this.txtPosition.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPosition.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPosition.Location = new System.Drawing.Point(263, 177);
            this.txtPosition.Multiline = true;
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(263, 20);
            this.txtPosition.TabIndex = 6;
            this.txtPosition.Validating += new System.ComponentModel.CancelEventHandler(this.txtPosition_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(94, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 14);
            this.label3.TabIndex = 9;
            this.label3.Text = "Datum potpisivanja ugovora";
            // 
            // lblPlata
            // 
            this.lblPlata.AutoSize = true;
            this.lblPlata.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlata.Location = new System.Drawing.Point(211, 249);
            this.lblPlata.Name = "lblPlata";
            this.lblPlata.Size = new System.Drawing.Size(40, 14);
            this.lblPlata.TabIndex = 11;
            this.lblPlata.Text = "Plata*";
            // 
            // txtSalary
            // 
            this.txtSalary.BackColor = System.Drawing.SystemColors.Window;
            this.txtSalary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSalary.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalary.Location = new System.Drawing.Point(263, 246);
            this.txtSalary.Multiline = true;
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(263, 20);
            this.txtSalary.TabIndex = 10;
            this.txtSalary.Validating += new System.ComponentModel.CancelEventHandler(this.txtSalary_Validating);
            // 
            // txtDateTime
            // 
            this.txtDateTime.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDateTime.Location = new System.Drawing.Point(263, 213);
            this.txtDateTime.Name = "txtDateTime";
            this.txtDateTime.Size = new System.Drawing.Size(117, 21);
            this.txtDateTime.TabIndex = 12;
            this.txtDateTime.Value = new System.DateTime(2020, 7, 17, 0, 0, 0, 0);
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnAddEmployee.ButtonImage = null;
            this.btnAddEmployee.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnAddEmployee.ButtonText = "Dodaj uposlenika";
            this.btnAddEmployee.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnAddEmployee.ClickTextColor = System.Drawing.Color.Azure;
            this.btnAddEmployee.CornerRadius = 5;
            this.btnAddEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddEmployee.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEmployee.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnAddEmployee.HoverBackgroundColor = System.Drawing.Color.GhostWhite;
            this.btnAddEmployee.HoverTextColor = System.Drawing.Color.Teal;
            this.btnAddEmployee.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnAddEmployee.Location = new System.Drawing.Point(203, 331);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(208, 32);
            this.btnAddEmployee.TabIndex = 13;
            this.btnAddEmployee.TextColor = System.Drawing.Color.Teal;
            this.btnAddEmployee.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarning.ForeColor = System.Drawing.Color.Maroon;
            this.lblWarning.Location = new System.Drawing.Point(186, 295);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(289, 14);
            this.lblWarning.TabIndex = 14;
            this.lblWarning.Text = "Napomena: Polja označena zvjezdicom su obavezna";
            // 
            // errProviderEmployeeAdd
            // 
            this.errProviderEmployeeAdd.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errProviderEmployeeAdd.ContainerControl = this;
            this.errProviderEmployeeAdd.Icon = ((System.Drawing.Icon)(resources.GetObject("errProviderEmployeeAdd.Icon")));
            // 
            // frmEmployeeAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 375);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.txtDateTime);
            this.Controls.Add(this.lblPlata);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.txtPosition);
            this.Controls.Add(this.lblPrezime);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblAddEmployee);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEmployeeAdd";
            this.Text = "frmEmployeeAdd";
            ((System.ComponentModel.ISupportInitialize)(this.errProviderEmployeeAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddEmployee;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPlata;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.DateTimePicker txtDateTime;
        private XanderUI.XUIButton btnAddEmployee;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.ErrorProvider errProviderEmployeeAdd;
    }
}