namespace EToolService.Desktop
{
    partial class Loader
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
            this.xuiCircleProgressBar1 = new XanderUI.XUICircleProgressBar();
            this.lblWait = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // xuiCircleProgressBar1
            // 
            this.xuiCircleProgressBar1.AnimationSpeed = 10;
            this.xuiCircleProgressBar1.FilledColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(220)))), ((int)(((byte)(210)))));
            this.xuiCircleProgressBar1.FilledColorAlpha = 130;
            this.xuiCircleProgressBar1.FilledThickness = 5;
            this.xuiCircleProgressBar1.IsAnimated = true;
            this.xuiCircleProgressBar1.Location = new System.Drawing.Point(16, 12);
            this.xuiCircleProgressBar1.Name = "xuiCircleProgressBar1";
            this.xuiCircleProgressBar1.Percentage = 30;
            this.xuiCircleProgressBar1.ShowText = false;
            this.xuiCircleProgressBar1.Size = new System.Drawing.Size(74, 74);
            this.xuiCircleProgressBar1.TabIndex = 0;
            this.xuiCircleProgressBar1.TextColor = System.Drawing.Color.Gray;
            this.xuiCircleProgressBar1.TextSize = 25;
            this.xuiCircleProgressBar1.UnFilledColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            this.xuiCircleProgressBar1.UnfilledThickness = 5;
            // 
            // lblWait
            // 
            this.lblWait.AutoSize = true;
            this.lblWait.Location = new System.Drawing.Point(25, 99);
            this.lblWait.Name = "lblWait";
            this.lblWait.Size = new System.Drawing.Size(60, 13);
            this.lblWait.TabIndex = 1;
            this.lblWait.Text = "Pričekajte..";
            // 
            // Loader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblWait);
            this.Controls.Add(this.xuiCircleProgressBar1);
            this.Name = "Loader";
            this.Size = new System.Drawing.Size(104, 136);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private XanderUI.XUICircleProgressBar xuiCircleProgressBar1;
        private System.Windows.Forms.Label lblWait;
    }
}
