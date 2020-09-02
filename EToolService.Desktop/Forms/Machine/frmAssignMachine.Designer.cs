namespace EToolService.Desktop.Forms.Machine
{
    partial class frmAssignMachine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAssignMachine));
            this.lblMachineChoice = new System.Windows.Forms.Label();
            this.comboMachines = new System.Windows.Forms.ComboBox();
            this.btnAddMachine = new XanderUI.XUIButton();
            this.SuspendLayout();
            // 
            // lblMachineChoice
            // 
            this.lblMachineChoice.AutoSize = true;
            this.lblMachineChoice.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMachineChoice.Location = new System.Drawing.Point(81, 29);
            this.lblMachineChoice.Name = "lblMachineChoice";
            this.lblMachineChoice.Size = new System.Drawing.Size(118, 15);
            this.lblMachineChoice.TabIndex = 0;
            this.lblMachineChoice.Text = "Odaberite mašinu:";
            // 
            // comboMachines
            // 
            this.comboMachines.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMachines.FormattingEnabled = true;
            this.comboMachines.Location = new System.Drawing.Point(49, 57);
            this.comboMachines.Name = "comboMachines";
            this.comboMachines.Size = new System.Drawing.Size(184, 21);
            this.comboMachines.TabIndex = 1;
            // 
            // btnAddMachine
            // 
            this.btnAddMachine.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnAddMachine.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnAddMachine.ButtonImage")));
            this.btnAddMachine.ButtonStyle = XanderUI.XUIButton.Style.Material;
            this.btnAddMachine.ButtonText = "Sačuvaj";
            this.btnAddMachine.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(200)))), ((int)(((byte)(185)))));
            this.btnAddMachine.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(200)))), ((int)(((byte)(185)))));
            this.btnAddMachine.CornerRadius = 5;
            this.btnAddMachine.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMachine.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnAddMachine.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(200)))), ((int)(((byte)(185)))));
            this.btnAddMachine.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(70)))), ((int)(((byte)(75)))));
            this.btnAddMachine.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnAddMachine.Location = new System.Drawing.Point(84, 96);
            this.btnAddMachine.Name = "btnAddMachine";
            this.btnAddMachine.Size = new System.Drawing.Size(113, 36);
            this.btnAddMachine.TabIndex = 2;
            this.btnAddMachine.TextColor = System.Drawing.Color.DimGray;
            this.btnAddMachine.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnAddMachine.Click += new System.EventHandler(this.btnAddMachine_Click);
            // 
            // frmAssignMachine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 147);
            this.Controls.Add(this.btnAddMachine);
            this.Controls.Add(this.comboMachines);
            this.Controls.Add(this.lblMachineChoice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAssignMachine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodijeli mašinu";
            this.Load += new System.EventHandler(this.frmAssignMachine_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMachineChoice;
        private System.Windows.Forms.ComboBox comboMachines;
        private XanderUI.XUIButton btnAddMachine;
    }
}