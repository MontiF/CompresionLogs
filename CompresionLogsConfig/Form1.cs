using LibCompresionLogs.Controladores;
using LibCompresionLogs.Models;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace CompresionLogsConfig
{
    public partial class Form1 : Form
    {
        private Configuration _config;
        private readonly string _configPath = "C:\\CompresionLogs\\config.json";

        public Form1()
        {
            InitializeComponent();

            _config = ConfigService.Load(_configPath);

            LoadDataToUI();
        }

        private void LoadDataToUI()
        {
            numGlobalMonths.Value = _config.MonthsToKeep;
            numDayToRun.Value = _config.DayToExecute;
            txtDestPath.Text = _config.DestinationPath;

            dgvFolders.DataSource = new BindingList<MonitoringFolder>(_config.MonitoringFolders);
        }

        private void btnSelectDest_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    txtDestPath.Text = fbd.SelectedPath;
                }
            }
        }

        private void btnAddFolder_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    var lista = (BindingList<MonitoringFolder>)dgvFolders.DataSource;
                    lista.Add(new MonitoringFolder { Path = fbd.SelectedPath, MonthsToKeep = null });
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            dgvFolders.EndEdit();
            dgvFolders.BindingContext[dgvFolders.DataSource].EndCurrentEdit();

            _config.MonthsToKeep = (int)numGlobalMonths.Value;
            _config.DayToExecute = (int)numDayToRun.Value;
            _config.DestinationPath = txtDestPath.Text;
            try
            {
                ConfigService.Save(_configPath, _config);
                MessageBox.Show("Configuración guardada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnRemoveFolder_Click(object sender, EventArgs e)
        {
            if (dgvFolders.CurrentRow != null)
            {
                var lista = (BindingList<MonitoringFolder>)dgvFolders.DataSource;
                lista.RemoveAt(dgvFolders.CurrentRow.Index);
            }
        }
    }
}