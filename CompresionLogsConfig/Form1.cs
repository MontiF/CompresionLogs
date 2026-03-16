using LibCompresionLogs.Controladores;
using LibCompresionLogs.Models;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace CompresionLogsConfig
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadDataToUI();
        }

        private void LoadDataToUI()
        {
            var config = ConfigService.Instance;

            numGlobalMonths.Value = config.MonthsToKeep;
            numDayToRun.Value = config.DayToExecute;
            numZipLife.Value = config.ZipLifeTimeMonths;
            txtDestPath.Text = config.DestinationPath;
            txtExtensions.Text = config.DefaultExtensions != null ? string.Join(", ", config.DefaultExtensions) : ".log";

            txtFTPHost.Text = config.FTPHost;
            numFTPPort.Value = config.FTPPort;
            txtFTPUser.Text = config.FTPUser;
            txtFTPPass.Text = config.FTPPass;
            txtFTPPath.Text = config.FTPPath;
            chkIsSFTP.Checked = config.IsSFTP;

            dgvFolders.DataSource = new BindingList<MonitoringFolder>(config.MonitoringFolders);
        }

        private void btnSelectDest_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK) txtDestPath.Text = fbd.SelectedPath;
            }
        }

        private void btnAddFolder_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    ((BindingList<MonitoringFolder>)dgvFolders.DataSource).Add(new MonitoringFolder { Path = fbd.SelectedPath });
                }
            }
        }

        private void btnRemoveFolder_Click(object sender, EventArgs e)
        {
            if (dgvFolders.CurrentRow != null)
                ((BindingList<MonitoringFolder>)dgvFolders.DataSource).RemoveAt(dgvFolders.CurrentRow.Index);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            dgvFolders.EndEdit();
            var config = ConfigService.Instance;

            config.MonthsToKeep = (int)numGlobalMonths.Value;
            config.DayToExecute = (int)numDayToRun.Value;
            config.ZipLifeTimeMonths = (int)numZipLife.Value;
            config.DestinationPath = txtDestPath.Text;
            config.DefaultExtensions = txtExtensions.Text.Split(',').Select(x => x.Trim().ToLower()).Where(x => !string.IsNullOrEmpty(x)).ToList();

            config.FTPHost = txtFTPHost.Text;
            config.FTPPort = (int)numFTPPort.Value;
            config.FTPUser = txtFTPUser.Text;
            config.FTPPass = txtFTPPass.Text;
            config.FTPPath = txtFTPPath.Text;
            config.IsSFTP = chkIsSFTP.Checked;

            try
            {
                ConfigService.Save();
                MessageBox.Show("Configuración guardada.");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void chkIsSFTP_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIsSFTP.Checked && numFTPPort.Value == 21) numFTPPort.Value = 22;
            else if (!chkIsSFTP.Checked && numFTPPort.Value == 22) numFTPPort.Value = 21;
        }
    }
}