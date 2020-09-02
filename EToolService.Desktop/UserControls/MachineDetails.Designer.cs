namespace EToolService.Desktop.UserControls
{
    partial class MachineDetails
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMachineName = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblPurpose = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMachineName
            // 
            this.lblMachineName.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMachineName.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblMachineName.Location = new System.Drawing.Point(18, 11);
            this.lblMachineName.Name = "lblMachineName";
            this.lblMachineName.Size = new System.Drawing.Size(491, 25);
            this.lblMachineName.TabIndex = 0;
            this.lblMachineName.Text = "Naziv mašine";
            // 
            // lblDescription
            // 
            this.lblDescription.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(45, 36);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(464, 19);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Opis";
            // 
            // lblType
            // 
            this.lblType.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(45, 65);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(464, 19);
            this.lblType.TabIndex = 2;
            this.lblType.Text = "Tip";
            // 
            // lblPurpose
            // 
            this.lblPurpose.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPurpose.Location = new System.Drawing.Point(45, 93);
            this.lblPurpose.Name = "lblPurpose";
            this.lblPurpose.Size = new System.Drawing.Size(464, 23);
            this.lblPurpose.TabIndex = 3;
            this.lblPurpose.Text = "Namjena";
            // 
            // MachineDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblPurpose);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblMachineName);
            this.Name = "MachineDetails";
            this.Size = new System.Drawing.Size(528, 126);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMachineName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblPurpose;
    }
}
