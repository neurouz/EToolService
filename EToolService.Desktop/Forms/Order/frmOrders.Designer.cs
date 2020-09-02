namespace EToolService.Desktop.Forms.Order
{
    partial class frmOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrders));
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlOrders = new System.Windows.Forms.Panel();
            this.loader1 = new EToolService.Desktop.Loader();
            this.btnNext = new XanderUI.XUIButton();
            this.btnPrevious = new XanderUI.XUIButton();
            this.comboFilter = new System.Windows.Forms.ComboBox();
            this.lblAdresa = new System.Windows.Forms.Label();
            this.lblIznos = new System.Windows.Forms.Label();
            this.lblDatum = new System.Windows.Forms.Label();
            this.lblNarucioc = new System.Windows.Forms.Label();
            this.lblAkcija = new System.Windows.Forms.Label();
            this.pnlOrders.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(310, -4);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(235, 34);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Pregled narudžbi";
            // 
            // pnlOrders
            // 
            this.pnlOrders.Controls.Add(this.loader1);
            this.pnlOrders.Location = new System.Drawing.Point(25, 113);
            this.pnlOrders.Name = "pnlOrders";
            this.pnlOrders.Size = new System.Drawing.Size(781, 212);
            this.pnlOrders.TabIndex = 5;
            // 
            // loader1
            // 
            this.loader1.Location = new System.Drawing.Point(344, 37);
            this.loader1.Name = "loader1";
            this.loader1.Size = new System.Drawing.Size(104, 136);
            this.loader1.TabIndex = 0;
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
            this.btnNext.Location = new System.Drawing.Point(442, 341);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(31, 23);
            this.btnNext.TabIndex = 10;
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
            this.btnPrevious.Location = new System.Drawing.Point(361, 341);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(30, 23);
            this.btnPrevious.TabIndex = 9;
            this.btnPrevious.TextColor = System.Drawing.Color.Black;
            this.btnPrevious.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // comboFilter
            // 
            this.comboFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFilter.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboFilter.FormattingEnabled = true;
            this.comboFilter.Location = new System.Drawing.Point(637, 34);
            this.comboFilter.Name = "comboFilter";
            this.comboFilter.Size = new System.Drawing.Size(121, 23);
            this.comboFilter.TabIndex = 11;
            this.comboFilter.SelectionChangeCommitted += new System.EventHandler(this.comboFilter_SelectionChangeCommitted);
            // 
            // lblAdresa
            // 
            this.lblAdresa.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdresa.Location = new System.Drawing.Point(341, 79);
            this.lblAdresa.Name = "lblAdresa";
            this.lblAdresa.Size = new System.Drawing.Size(191, 23);
            this.lblAdresa.TabIndex = 19;
            this.lblAdresa.Text = "Adresa";
            // 
            // lblIznos
            // 
            this.lblIznos.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIznos.Location = new System.Drawing.Point(535, 81);
            this.lblIznos.Name = "lblIznos";
            this.lblIznos.Size = new System.Drawing.Size(115, 23);
            this.lblIznos.TabIndex = 18;
            this.lblIznos.Text = "Za platiti";
            // 
            // lblDatum
            // 
            this.lblDatum.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatum.Location = new System.Drawing.Point(181, 80);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(114, 23);
            this.lblDatum.TabIndex = 17;
            this.lblDatum.Text = "Datum kreiranja";
            // 
            // lblNarucioc
            // 
            this.lblNarucioc.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNarucioc.Location = new System.Drawing.Point(40, 81);
            this.lblNarucioc.Name = "lblNarucioc";
            this.lblNarucioc.Size = new System.Drawing.Size(145, 23);
            this.lblNarucioc.TabIndex = 16;
            this.lblNarucioc.Text = "Naručioc";
            // 
            // lblAkcija
            // 
            this.lblAkcija.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAkcija.Location = new System.Drawing.Point(701, 81);
            this.lblAkcija.Name = "lblAkcija";
            this.lblAkcija.Size = new System.Drawing.Size(75, 23);
            this.lblAkcija.TabIndex = 20;
            this.lblAkcija.Text = "Akcija";
            // 
            // frmOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(829, 376);
            this.Controls.Add(this.lblAkcija);
            this.Controls.Add(this.lblAdresa);
            this.Controls.Add(this.comboFilter);
            this.Controls.Add(this.lblIznos);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.lblNarucioc);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.pnlOrders);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOrders";
            this.Text = "frmOrders";
            this.Load += new System.EventHandler(this.frmOrders_Load);
            this.pnlOrders.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlOrders;
        private XanderUI.XUIButton btnNext;
        private XanderUI.XUIButton btnPrevious;
        private System.Windows.Forms.ComboBox comboFilter;
        private System.Windows.Forms.Label lblAdresa;
        private System.Windows.Forms.Label lblIznos;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Label lblNarucioc;
        private System.Windows.Forms.Label lblAkcija;
        private Loader loader1;
    }
}