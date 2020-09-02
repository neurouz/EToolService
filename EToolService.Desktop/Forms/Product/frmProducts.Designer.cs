namespace EToolService.Desktop.Forms.Product
{
    partial class frmProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProducts));
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnProductAdd = new XanderUI.XUIButton();
            this.flowProductsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNext = new XanderUI.XUIButton();
            this.btnPrevious = new XanderUI.XUIButton();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(334, -4);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(138, 34);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Proizvodi";
            // 
            // btnProductAdd
            // 
            this.btnProductAdd.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnProductAdd.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnProductAdd.ButtonImage")));
            this.btnProductAdd.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnProductAdd.ButtonText = "Dodaj proizvod";
            this.btnProductAdd.ClickBackColor = System.Drawing.Color.Transparent;
            this.btnProductAdd.ClickTextColor = System.Drawing.Color.LightGray;
            this.btnProductAdd.CornerRadius = 5;
            this.btnProductAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProductAdd.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductAdd.Horizontal_Alignment = System.Drawing.StringAlignment.Near;
            this.btnProductAdd.HoverBackgroundColor = System.Drawing.Color.GhostWhite;
            this.btnProductAdd.HoverTextColor = System.Drawing.Color.DarkSlateGray;
            this.btnProductAdd.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnProductAdd.Location = new System.Drawing.Point(693, 342);
            this.btnProductAdd.Name = "btnProductAdd";
            this.btnProductAdd.Size = new System.Drawing.Size(133, 35);
            this.btnProductAdd.TabIndex = 11;
            this.btnProductAdd.TextColor = System.Drawing.Color.DarkSlateGray;
            this.btnProductAdd.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // flowProductsPanel
            // 
            this.flowProductsPanel.AutoScroll = true;
            this.flowProductsPanel.Location = new System.Drawing.Point(21, 37);
            this.flowProductsPanel.Name = "flowProductsPanel";
            this.flowProductsPanel.Size = new System.Drawing.Size(805, 306);
            this.flowProductsPanel.TabIndex = 1;
            // 
            // btnNext
            // 
            this.btnNext.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnNext.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnNext.ButtonImage")));
            this.btnNext.ButtonStyle = XanderUI.XUIButton.Style.Material;
            this.btnNext.ButtonText = "";
            this.btnNext.ClickBackColor = System.Drawing.Color.Black;
            this.btnNext.ClickTextColor = System.Drawing.Color.Black;
            this.btnNext.CornerRadius = 5;
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnNext.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnNext.HoverBackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.btnNext.HoverTextColor = System.Drawing.Color.White;
            this.btnNext.ImagePosition = XanderUI.XUIButton.imgPosition.Center;
            this.btnNext.Location = new System.Drawing.Point(438, 350);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(31, 23);
            this.btnNext.TabIndex = 13;
            this.btnNext.TextColor = System.Drawing.Color.Black;
            this.btnNext.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnPrevious.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnPrevious.ButtonImage")));
            this.btnPrevious.ButtonStyle = XanderUI.XUIButton.Style.Material;
            this.btnPrevious.ButtonText = "";
            this.btnPrevious.ClickBackColor = System.Drawing.Color.Black;
            this.btnPrevious.ClickTextColor = System.Drawing.Color.Black;
            this.btnPrevious.CornerRadius = 5;
            this.btnPrevious.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnPrevious.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnPrevious.HoverBackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.btnPrevious.HoverTextColor = System.Drawing.Color.White;
            this.btnPrevious.ImagePosition = XanderUI.XUIButton.imgPosition.Center;
            this.btnPrevious.Location = new System.Drawing.Point(372, 350);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(30, 23);
            this.btnPrevious.TabIndex = 12;
            this.btnPrevious.TextColor = System.Drawing.Color.Black;
            this.btnPrevious.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // frmProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 389);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.flowProductsPanel);
            this.Controls.Add(this.btnProductAdd);
            this.Controls.Add(this.lblTitle);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProducts";
            this.Text = "frmProducts";
            this.Load += new System.EventHandler(this.frmProducts_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private XanderUI.XUIButton btnProductAdd;
        private System.Windows.Forms.FlowLayoutPanel flowProductsPanel;
        private XanderUI.XUIButton btnNext;
        private XanderUI.XUIButton btnPrevious;
    }
}