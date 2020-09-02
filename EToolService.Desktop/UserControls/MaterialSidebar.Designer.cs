namespace EToolService.Desktop.UserControls
{
    partial class MaterialSidebar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaterialSidebar));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDostupniMaterijal = new XanderUI.XUIButton();
            this.btnCelik = new System.Windows.Forms.Button();
            this.btnAluminijum = new System.Windows.Forms.Button();
            this.btnSipkastiMaterijal = new System.Windows.Forms.Button();
            this.btnPotroseniMaterijal = new XanderUI.XUIButton();
            this.btnNoviMaterijal = new XanderUI.XUIButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDostupniMaterijal);
            this.panel1.Controls.Add(this.btnCelik);
            this.panel1.Controls.Add(this.btnAluminijum);
            this.panel1.Controls.Add(this.btnSipkastiMaterijal);
            this.panel1.Location = new System.Drawing.Point(7, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(151, 131);
            this.panel1.TabIndex = 12;
            // 
            // btnDostupniMaterijal
            // 
            this.btnDostupniMaterijal.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnDostupniMaterijal.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnDostupniMaterijal.ButtonImage")));
            this.btnDostupniMaterijal.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnDostupniMaterijal.ButtonText = "Dostupni materijal";
            this.btnDostupniMaterijal.ClickBackColor = System.Drawing.Color.Transparent;
            this.btnDostupniMaterijal.ClickTextColor = System.Drawing.Color.LightGray;
            this.btnDostupniMaterijal.CornerRadius = 5;
            this.btnDostupniMaterijal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDostupniMaterijal.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDostupniMaterijal.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnDostupniMaterijal.HoverBackgroundColor = System.Drawing.Color.GhostWhite;
            this.btnDostupniMaterijal.HoverTextColor = System.Drawing.Color.DarkSlateGray;
            this.btnDostupniMaterijal.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnDostupniMaterijal.Location = new System.Drawing.Point(1, 7);
            this.btnDostupniMaterijal.Name = "btnDostupniMaterijal";
            this.btnDostupniMaterijal.Size = new System.Drawing.Size(148, 32);
            this.btnDostupniMaterijal.TabIndex = 12;
            this.btnDostupniMaterijal.TextColor = System.Drawing.Color.DarkSlateGray;
            this.btnDostupniMaterijal.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnDostupniMaterijal.Click += new System.EventHandler(this.btnDostupniMaterijal_Click);
            // 
            // btnCelik
            // 
            this.btnCelik.BackColor = System.Drawing.SystemColors.Control;
            this.btnCelik.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCelik.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCelik.FlatAppearance.BorderSize = 0;
            this.btnCelik.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Control;
            this.btnCelik.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnCelik.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCelik.Location = new System.Drawing.Point(26, 95);
            this.btnCelik.Name = "btnCelik";
            this.btnCelik.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCelik.Size = new System.Drawing.Size(117, 25);
            this.btnCelik.TabIndex = 11;
            this.btnCelik.Text = "Čelik";
            this.btnCelik.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCelik.UseVisualStyleBackColor = false;
            this.btnCelik.Click += new System.EventHandler(this.btnCelik_Click);
            // 
            // btnAluminijum
            // 
            this.btnAluminijum.BackColor = System.Drawing.SystemColors.Control;
            this.btnAluminijum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAluminijum.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAluminijum.FlatAppearance.BorderSize = 0;
            this.btnAluminijum.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Control;
            this.btnAluminijum.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAluminijum.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAluminijum.Location = new System.Drawing.Point(26, 68);
            this.btnAluminijum.Name = "btnAluminijum";
            this.btnAluminijum.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAluminijum.Size = new System.Drawing.Size(117, 25);
            this.btnAluminijum.TabIndex = 10;
            this.btnAluminijum.Text = "Aluminijum";
            this.btnAluminijum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAluminijum.UseVisualStyleBackColor = false;
            this.btnAluminijum.Click += new System.EventHandler(this.btnAluminijum_Click);
            // 
            // btnSipkastiMaterijal
            // 
            this.btnSipkastiMaterijal.BackColor = System.Drawing.SystemColors.Control;
            this.btnSipkastiMaterijal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSipkastiMaterijal.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSipkastiMaterijal.FlatAppearance.BorderSize = 0;
            this.btnSipkastiMaterijal.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Control;
            this.btnSipkastiMaterijal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSipkastiMaterijal.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSipkastiMaterijal.Location = new System.Drawing.Point(26, 41);
            this.btnSipkastiMaterijal.Name = "btnSipkastiMaterijal";
            this.btnSipkastiMaterijal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSipkastiMaterijal.Size = new System.Drawing.Size(117, 25);
            this.btnSipkastiMaterijal.TabIndex = 9;
            this.btnSipkastiMaterijal.Text = "Šipkasti materijal";
            this.btnSipkastiMaterijal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSipkastiMaterijal.UseVisualStyleBackColor = false;
            this.btnSipkastiMaterijal.Click += new System.EventHandler(this.btnSipkastiMaterijal_Click);
            // 
            // btnPotroseniMaterijal
            // 
            this.btnPotroseniMaterijal.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnPotroseniMaterijal.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnPotroseniMaterijal.ButtonImage")));
            this.btnPotroseniMaterijal.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnPotroseniMaterijal.ButtonText = "Potrošeni materijal";
            this.btnPotroseniMaterijal.ClickBackColor = System.Drawing.Color.Transparent;
            this.btnPotroseniMaterijal.ClickTextColor = System.Drawing.Color.LightGray;
            this.btnPotroseniMaterijal.CornerRadius = 5;
            this.btnPotroseniMaterijal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPotroseniMaterijal.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPotroseniMaterijal.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnPotroseniMaterijal.HoverBackgroundColor = System.Drawing.Color.GhostWhite;
            this.btnPotroseniMaterijal.HoverTextColor = System.Drawing.Color.DarkSlateGray;
            this.btnPotroseniMaterijal.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnPotroseniMaterijal.Location = new System.Drawing.Point(7, 139);
            this.btnPotroseniMaterijal.Name = "btnPotroseniMaterijal";
            this.btnPotroseniMaterijal.Size = new System.Drawing.Size(148, 32);
            this.btnPotroseniMaterijal.TabIndex = 13;
            this.btnPotroseniMaterijal.TextColor = System.Drawing.Color.DarkSlateGray;
            this.btnPotroseniMaterijal.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnPotroseniMaterijal.Click += new System.EventHandler(this.btnPotroseniMaterijal_Click);
            // 
            // btnNoviMaterijal
            // 
            this.btnNoviMaterijal.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnNoviMaterijal.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnNoviMaterijal.ButtonImage")));
            this.btnNoviMaterijal.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnNoviMaterijal.ButtonText = "Novi materijal";
            this.btnNoviMaterijal.ClickBackColor = System.Drawing.Color.Transparent;
            this.btnNoviMaterijal.ClickTextColor = System.Drawing.Color.LightGray;
            this.btnNoviMaterijal.CornerRadius = 5;
            this.btnNoviMaterijal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNoviMaterijal.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNoviMaterijal.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnNoviMaterijal.HoverBackgroundColor = System.Drawing.Color.GhostWhite;
            this.btnNoviMaterijal.HoverTextColor = System.Drawing.Color.DarkSlateGray;
            this.btnNoviMaterijal.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnNoviMaterijal.Location = new System.Drawing.Point(8, 177);
            this.btnNoviMaterijal.Name = "btnNoviMaterijal";
            this.btnNoviMaterijal.Size = new System.Drawing.Size(148, 32);
            this.btnNoviMaterijal.TabIndex = 14;
            this.btnNoviMaterijal.TextColor = System.Drawing.Color.DarkSlateGray;
            this.btnNoviMaterijal.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnNoviMaterijal.Click += new System.EventHandler(this.btnNoviMaterijal_Click);
            // 
            // MaterialSidebar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnNoviMaterijal);
            this.Controls.Add(this.btnPotroseniMaterijal);
            this.Controls.Add(this.panel1);
            this.Name = "MaterialSidebar";
            this.Size = new System.Drawing.Size(161, 217);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCelik;
        private System.Windows.Forms.Button btnAluminijum;
        private System.Windows.Forms.Button btnSipkastiMaterijal;
        private XanderUI.XUIButton btnDostupniMaterijal;
        private XanderUI.XUIButton btnPotroseniMaterijal;
        private XanderUI.XUIButton btnNoviMaterijal;
    }
}
