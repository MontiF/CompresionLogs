namespace CompresionLogsConfig
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            groupBoxGeneral = new GroupBox();
            lblExtensions = new Label();
            txtExtensions = new TextBox();
            lblZipLife = new Label();
            numZipLife = new NumericUpDown();
            lblDay = new Label();
            numDayToRun = new NumericUpDown();
            lblGlobalMonths = new Label();
            numGlobalMonths = new NumericUpDown();
            btnSelectDest = new Button();
            txtDestPath = new TextBox();
            lblDest = new Label();
            groupBoxFTP = new GroupBox();
            chkIsSFTP = new CheckBox();
            lblFTPPath = new Label();
            txtFTPPath = new TextBox();
            lblFTPPass = new Label();
            txtFTPPass = new TextBox();
            lblFTPUser = new Label();
            txtFTPUser = new TextBox();
            lblFTPPort = new Label();
            numFTPPort = new NumericUpDown();
            lblFTPHost = new Label();
            txtFTPHost = new TextBox();
            groupBoxFolders = new GroupBox();
            dgvFolders = new DataGridView();
            panelActions = new FlowLayoutPanel();
            btnSave = new Button();
            btnRemoveFolder = new Button();
            btnAddFolder = new Button();
            groupBoxGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numZipLife).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDayToRun).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numGlobalMonths).BeginInit();
            groupBoxFTP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numFTPPort).BeginInit();
            groupBoxFolders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFolders).BeginInit();
            panelActions.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxGeneral
            // 
            groupBoxGeneral.Controls.Add(lblExtensions);
            groupBoxGeneral.Controls.Add(txtExtensions);
            groupBoxGeneral.Controls.Add(lblZipLife);
            groupBoxGeneral.Controls.Add(numZipLife);
            groupBoxGeneral.Controls.Add(lblDay);
            groupBoxGeneral.Controls.Add(numDayToRun);
            groupBoxGeneral.Controls.Add(lblGlobalMonths);
            groupBoxGeneral.Controls.Add(numGlobalMonths);
            groupBoxGeneral.Controls.Add(btnSelectDest);
            groupBoxGeneral.Controls.Add(txtDestPath);
            groupBoxGeneral.Controls.Add(lblDest);
            groupBoxGeneral.Dock = DockStyle.Top;
            groupBoxGeneral.Location = new Point(10, 10);
            groupBoxGeneral.Name = "groupBoxGeneral";
            groupBoxGeneral.Size = new Size(582, 163);
            groupBoxGeneral.TabIndex = 0;
            groupBoxGeneral.TabStop = false;
            groupBoxGeneral.Text = "Configuración General";
            // 
            // lblExtensions
            // 
            lblExtensions.Location = new Point(230, 125);
            lblExtensions.Name = "lblExtensions";
            lblExtensions.Size = new Size(100, 23);
            lblExtensions.TabIndex = 0;
            lblExtensions.Text = "Extensiones:";
            // 
            // txtExtensions
            // 
            txtExtensions.Location = new Point(325, 122);
            txtExtensions.Name = "txtExtensions";
            txtExtensions.Size = new Size(220, 23);
            txtExtensions.TabIndex = 1;
            // 
            // lblZipLife
            // 
            lblZipLife.Location = new Point(15, 125);
            lblZipLife.Name = "lblZipLife";
            lblZipLife.Size = new Size(110, 23);
            lblZipLife.TabIndex = 2;
            lblZipLife.Text = "Vida ZIP (meses):";
            // 
            // numZipLife
            // 
            numZipLife.Location = new Point(130, 123);
            numZipLife.Name = "numZipLife";
            numZipLife.Size = new Size(80, 23);
            numZipLife.TabIndex = 3;
            // 
            // lblDay
            // 
            lblDay.Location = new Point(230, 90);
            lblDay.Name = "lblDay";
            lblDay.Size = new Size(89, 23);
            lblDay.TabIndex = 4;
            lblDay.Text = "Día ejecución:";
            // 
            // numDayToRun
            // 
            numDayToRun.Location = new Point(325, 88);
            numDayToRun.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
            numDayToRun.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numDayToRun.Name = "numDayToRun";
            numDayToRun.Size = new Size(80, 23);
            numDayToRun.TabIndex = 5;
            numDayToRun.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblGlobalMonths
            // 
            lblGlobalMonths.Location = new Point(15, 90);
            lblGlobalMonths.Name = "lblGlobalMonths";
            lblGlobalMonths.Size = new Size(110, 23);
            lblGlobalMonths.TabIndex = 6;
            lblGlobalMonths.Text = "Meses guardar:";
            // 
            // numGlobalMonths
            // 
            numGlobalMonths.Location = new Point(130, 88);
            numGlobalMonths.Name = "numGlobalMonths";
            numGlobalMonths.Size = new Size(80, 23);
            numGlobalMonths.TabIndex = 7;
            // 
            // btnSelectDest
            // 
            btnSelectDest.Location = new Point(470, 44);
            btnSelectDest.Name = "btnSelectDest";
            btnSelectDest.Size = new Size(75, 23);
            btnSelectDest.TabIndex = 8;
            btnSelectDest.Text = "...";
            btnSelectDest.Click += btnSelectDest_Click;
            // 
            // txtDestPath
            // 
            txtDestPath.Location = new Point(15, 45);
            txtDestPath.Name = "txtDestPath";
            txtDestPath.ReadOnly = true;
            txtDestPath.Size = new Size(450, 23);
            txtDestPath.TabIndex = 9;
            // 
            // lblDest
            // 
            lblDest.Location = new Point(15, 25);
            lblDest.Name = "lblDest";
            lblDest.Size = new Size(150, 23);
            lblDest.TabIndex = 10;
            lblDest.Text = "Ruta Destino Local:";
            // 
            // groupBoxFTP
            // 
            groupBoxFTP.Controls.Add(chkIsSFTP);
            groupBoxFTP.Controls.Add(lblFTPPath);
            groupBoxFTP.Controls.Add(txtFTPPath);
            groupBoxFTP.Controls.Add(lblFTPPass);
            groupBoxFTP.Controls.Add(txtFTPPass);
            groupBoxFTP.Controls.Add(lblFTPUser);
            groupBoxFTP.Controls.Add(txtFTPUser);
            groupBoxFTP.Controls.Add(lblFTPPort);
            groupBoxFTP.Controls.Add(numFTPPort);
            groupBoxFTP.Controls.Add(lblFTPHost);
            groupBoxFTP.Controls.Add(txtFTPHost);
            groupBoxFTP.Dock = DockStyle.Top;
            groupBoxFTP.Location = new Point(10, 173);
            groupBoxFTP.Name = "groupBoxFTP";
            groupBoxFTP.Size = new Size(582, 130);
            groupBoxFTP.TabIndex = 1;
            groupBoxFTP.TabStop = false;
            groupBoxFTP.Text = "Configuración Transferencia";
            // 
            // chkIsSFTP
            // 
            chkIsSFTP.AutoSize = true;
            chkIsSFTP.Location = new Point(465, 64);
            chkIsSFTP.Name = "chkIsSFTP";
            chkIsSFTP.Size = new Size(66, 19);
            chkIsSFTP.TabIndex = 0;
            chkIsSFTP.Text = "Es SFTP";
            chkIsSFTP.CheckedChanged += chkIsSFTP_CheckedChanged;
            // 
            // lblFTPPath
            // 
            lblFTPPath.Location = new Point(15, 95);
            lblFTPPath.Name = "lblFTPPath";
            lblFTPPath.Size = new Size(100, 23);
            lblFTPPath.TabIndex = 1;
            lblFTPPath.Text = "Ruta Remota:";
            // 
            // txtFTPPath
            // 
            txtFTPPath.Location = new Point(115, 92);
            txtFTPPath.Name = "txtFTPPath";
            txtFTPPath.Size = new Size(430, 23);
            txtFTPPath.TabIndex = 2;
            // 
            // lblFTPPass
            // 
            lblFTPPass.Location = new Point(285, 65);
            lblFTPPass.Name = "lblFTPPass";
            lblFTPPass.Size = new Size(80, 23);
            lblFTPPass.TabIndex = 3;
            lblFTPPass.Text = "Password:";
            // 
            // txtFTPPass
            // 
            txtFTPPass.Location = new Point(365, 62);
            txtFTPPass.Name = "txtFTPPass";
            txtFTPPass.PasswordChar = '*';
            txtFTPPass.Size = new Size(80, 23);
            txtFTPPass.TabIndex = 4;
            // 
            // lblFTPUser
            // 
            lblFTPUser.Location = new Point(15, 65);
            lblFTPUser.Name = "lblFTPUser";
            lblFTPUser.Size = new Size(80, 23);
            lblFTPUser.TabIndex = 5;
            lblFTPUser.Text = "Usuario:";
            // 
            // txtFTPUser
            // 
            txtFTPUser.Location = new Point(115, 62);
            txtFTPUser.Name = "txtFTPUser";
            txtFTPUser.Size = new Size(150, 23);
            txtFTPUser.TabIndex = 6;
            // 
            // lblFTPPort
            // 
            lblFTPPort.Location = new Point(410, 30);
            lblFTPPort.Name = "lblFTPPort";
            lblFTPPort.Size = new Size(55, 23);
            lblFTPPort.TabIndex = 7;
            lblFTPPort.Text = "Puerto:";
            // 
            // numFTPPort
            // 
            numFTPPort.Location = new Point(465, 28);
            numFTPPort.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            numFTPPort.Name = "numFTPPort";
            numFTPPort.Size = new Size(80, 23);
            numFTPPort.TabIndex = 8;
            numFTPPort.Value = new decimal(new int[] { 21, 0, 0, 0 });
            // 
            // lblFTPHost
            // 
            lblFTPHost.Location = new Point(15, 30);
            lblFTPHost.Name = "lblFTPHost";
            lblFTPHost.Size = new Size(80, 23);
            lblFTPHost.TabIndex = 9;
            lblFTPHost.Text = "Host FTP:";
            // 
            // txtFTPHost
            // 
            txtFTPHost.Location = new Point(115, 27);
            txtFTPHost.Name = "txtFTPHost";
            txtFTPHost.Size = new Size(280, 23);
            txtFTPHost.TabIndex = 10;
            // 
            // groupBoxFolders
            // 
            groupBoxFolders.Controls.Add(dgvFolders);
            groupBoxFolders.Dock = DockStyle.Fill;
            groupBoxFolders.Location = new Point(10, 303);
            groupBoxFolders.Name = "groupBoxFolders";
            groupBoxFolders.Size = new Size(582, 178);
            groupBoxFolders.TabIndex = 0;
            groupBoxFolders.TabStop = false;
            groupBoxFolders.Text = "Carpetas a Monitorear";
            // 
            // dgvFolders
            // 
            dgvFolders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFolders.Dock = DockStyle.Fill;
            dgvFolders.Location = new Point(3, 19);
            dgvFolders.Name = "dgvFolders";
            dgvFolders.RowHeadersVisible = false;
            dgvFolders.Size = new Size(576, 156);
            dgvFolders.TabIndex = 0;
            // 
            // panelActions
            // 
            panelActions.Controls.Add(btnSave);
            panelActions.Controls.Add(btnRemoveFolder);
            panelActions.Controls.Add(btnAddFolder);
            panelActions.Dock = DockStyle.Bottom;
            panelActions.FlowDirection = FlowDirection.RightToLeft;
            panelActions.Location = new Point(10, 481);
            panelActions.Name = "panelActions";
            panelActions.Size = new Size(582, 50);
            panelActions.TabIndex = 2;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(429, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(150, 35);
            btnSave.TabIndex = 0;
            btnSave.Text = "Guardar Cambios";
            btnSave.Click += btnSave_Click;
            // 
            // btnRemoveFolder
            // 
            btnRemoveFolder.Location = new Point(303, 3);
            btnRemoveFolder.Name = "btnRemoveFolder";
            btnRemoveFolder.Size = new Size(120, 35);
            btnRemoveFolder.TabIndex = 1;
            btnRemoveFolder.Text = "Eliminar Carpeta";
            btnRemoveFolder.Click += btnRemoveFolder_Click;
            // 
            // btnAddFolder
            // 
            btnAddFolder.Location = new Point(177, 3);
            btnAddFolder.Name = "btnAddFolder";
            btnAddFolder.Size = new Size(120, 35);
            btnAddFolder.TabIndex = 2;
            btnAddFolder.Text = "+ Añadir Carpeta";
            btnAddFolder.Click += btnAddFolder_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(602, 541);
            Controls.Add(groupBoxFolders);
            Controls.Add(groupBoxFTP);
            Controls.Add(groupBoxGeneral);
            Controls.Add(panelActions);
            Name = "Form1";
            Padding = new Padding(10);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LogManager - Configurador";
            groupBoxGeneral.ResumeLayout(false);
            groupBoxGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numZipLife).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDayToRun).EndInit();
            ((System.ComponentModel.ISupportInitialize)numGlobalMonths).EndInit();
            groupBoxFTP.ResumeLayout(false);
            groupBoxFTP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numFTPPort).EndInit();
            groupBoxFolders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvFolders).EndInit();
            panelActions.ResumeLayout(false);
            ResumeLayout(false);
        }

        private GroupBox groupBoxGeneral;
        private Label lblDest;
        private TextBox txtDestPath;
        private Button btnSelectDest;
        private Label lblGlobalMonths;
        private NumericUpDown numGlobalMonths;
        private Label lblDay;
        private NumericUpDown numDayToRun;
        private Label lblZipLife;
        private NumericUpDown numZipLife;
        private Label lblExtensions;
        private TextBox txtExtensions;
        private GroupBox groupBoxFTP;
        private Label lblFTPHost;
        private TextBox txtFTPHost;
        private Label lblFTPPort;
        private NumericUpDown numFTPPort;
        private Label lblFTPUser;
        private TextBox txtFTPUser;
        private Label lblFTPPass;
        private TextBox txtFTPPass;
        private Label lblFTPPath;
        private TextBox txtFTPPath;
        private CheckBox chkIsSFTP;
        private GroupBox groupBoxFolders;
        private DataGridView dgvFolders;
        private FlowLayoutPanel panelActions;
        private Button btnAddFolder;
        private Button btnRemoveFolder;
        private Button btnSave;
    }
}