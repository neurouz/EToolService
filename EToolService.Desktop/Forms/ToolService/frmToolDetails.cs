using EToolService.Desktop.Services;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace EToolService.Desktop.Forms.ToolService
{
    public partial class frmToolDetails : Form
    {
        private int _toolServiceID;
        private string attachmentUrl;
        private readonly APIService _service = new APIService("ToolService/GetService");

        public frmToolDetails(int id)
        {
            InitializeComponent();
            _toolServiceID = id;
        }

        private void btnCLose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void frmToolDetails_Load(object sender, EventArgs e)
        {
            var result = await _service.GetById<EToolService.Model.Models.Services>
                (_toolServiceID);

            valPredlozenaCijena.Text = result.Price.ToString("N") + " KM";
            valKupac.Text = result.CustomerName;
            valNapomena.Text = result.Note == null ? "Nema napomene" : result.Note;
            valNazivAlata.Text = result.ToolName;
            valObjasnjenje.Text = result.Explanation == null ? "Nije upisano" : result.Explanation;
            valTipServisa.Text = result.ServiceType;
            valDatum.Text = result.DateCreated.ToString("dd/MM/yyyy");
            valDatumZavrsetka.Text = result.FinishDate?.ToString("dd/MM/yyyy");

            if (result.Urgent) lblHitno.Visible = true;
            else lblHitno.Visible = false;

            attachmentUrl = result.Attachment == null ? null : result.Attachment;
        }

        private async void btnPrilog_Click(object sender, EventArgs e)
        {
            if(attachmentUrl == null)
            {
                MessageBox.Show("Korisnik nije dodao prilog", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            try
            {
                var result = await new APIService("File").GetFile($"Download/Services/{attachmentUrl}");
                var desktop = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
                var fullPath = Path.Combine(desktop, attachmentUrl);

                // Save file on desktop
                File.WriteAllBytes(fullPath, result);

                // Open file
                System.Diagnostics.Process.Start(fullPath);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Fajl ne postoji ili je obrisan", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
