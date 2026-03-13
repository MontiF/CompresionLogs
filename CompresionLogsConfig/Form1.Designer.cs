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
            lblDest = new Label();
            txtDestPath = new TextBox();
            btnSelectDest = new Button();
            lblGlobalMonths = new Label();
            numGlobalMonths = new NumericUpDown();
            lblDay = new Label();
            numDayToRun = new NumericUpDown();
            groupBoxFolders = new GroupBox();
            dgvFolders = new DataGridView();
            panelActions = new FlowLayoutPanel();
            btnSave = new Button();
            btnRemoveFolder = new Button();
            btnAddFolder = new Button();
            groupBoxGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numGlobalMonths).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDayToRun).BeginInit();
            groupBoxFolders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFolders).BeginInit();
            panelActions.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxGeneral
            // 
            groupBoxGeneral.Controls.Add(lblDest);
            groupBoxGeneral.Controls.Add(txtDestPath);
            groupBoxGeneral.Controls.Add(btnSelectDest);
            groupBoxGeneral.Controls.Add(lblGlobalMonths);
            groupBoxGeneral.Controls.Add(numGlobalMonths);
            groupBoxGeneral.Controls.Add(lblDay);
            groupBoxGeneral.Controls.Add(numDayToRun);
            groupBoxGeneral.Dock = DockStyle.Top;
            groupBoxGeneral.Location = new Point(10, 10);
            groupBoxGeneral.Name = "groupBoxGeneral";
            groupBoxGeneral.Padding = new Padding(10);
            groupBoxGeneral.Size = new Size(582, 130);
            groupBoxGeneral.TabIndex = 1;
            groupBoxGeneral.TabStop = false;
            groupBoxGeneral.Text = "Configuración General";
            // 
            // lblDest
            // 
            lblDest.AutoSize = true;
            lblDest.Location = new Point(15, 25);
            lblDest.Name = "lblDest";
            lblDest.Size = new Size(118, 15);
            lblDest.TabIndex = 0;
            lblDest.Text = "Ruta Destino de Zips:";
            // 
            // txtDestPath
            // 
            txtDestPath.Location = new Point(15, 45);
            txtDestPath.Name = "txtDestPath";
            txtDestPath.ReadOnly = true;
            txtDestPath.Size = new Size(450, 23);
            txtDestPath.TabIndex = 1;
            // 
            // btnSelectDest
            // 
            btnSelectDest.Location = new Point(470, 44);
            btnSelectDest.Name = "btnSelectDest";
            btnSelectDest.Size = new Size(75, 23);
            btnSelectDest.TabIndex = 2;
            btnSelectDest.Text = "...";
            btnSelectDest.Click += btnSelectDest_Click;
            // 
            // lblGlobalMonths
            // 
            lblGlobalMonths.AutoSize = true;
            lblGlobalMonths.Location = new Point(15, 80);
            lblGlobalMonths.Name = "lblGlobalMonths";
            lblGlobalMonths.Size = new Size(96, 15);
            lblGlobalMonths.TabIndex = 3;
            lblGlobalMonths.Text = "Meses a guardar:";
            // 
            // numGlobalMonths
            // 
            numGlobalMonths.Location = new Point(130, 78);
            numGlobalMonths.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numGlobalMonths.Name = "numGlobalMonths";
            numGlobalMonths.Size = new Size(120, 23);
            numGlobalMonths.TabIndex = 4;
            numGlobalMonths.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblDay
            // 
            lblDay.AutoSize = true;
            lblDay.Location = new Point(250, 80);
            lblDay.Name = "lblDay";
            lblDay.Size = new Size(97, 15);
            lblDay.TabIndex = 5;
            lblDay.Text = "Día de ejecución:";
            // 
            // numDayToRun
            // 
            numDayToRun.Location = new Point(360, 78);
            numDayToRun.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
            numDayToRun.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numDayToRun.Name = "numDayToRun";
            numDayToRun.Size = new Size(120, 23);
            numDayToRun.TabIndex = 6;
            numDayToRun.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // groupBoxFolders
            // 
            groupBoxFolders.Controls.Add(dgvFolders);
            groupBoxFolders.Dock = DockStyle.Fill;
            groupBoxFolders.Location = new Point(10, 140);
            groupBoxFolders.Name = "groupBoxFolders";
            groupBoxFolders.Padding = new Padding(10);
            groupBoxFolders.Size = new Size(582, 229);
            groupBoxFolders.TabIndex = 0;
            groupBoxFolders.TabStop = false;
            groupBoxFolders.Text = "Carpetas a Monitorear";
            // 
            // dgvFolders
            // 
            dgvFolders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFolders.BackgroundColor = Color.White;
            dgvFolders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFolders.Dock = DockStyle.Fill;
            dgvFolders.Location = new Point(10, 26);
            dgvFolders.Name = "dgvFolders";
            dgvFolders.RowHeadersVisible = false;
            dgvFolders.Size = new Size(562, 193);
            dgvFolders.TabIndex = 0;
            // 
            // panelActions
            // 
            panelActions.Controls.Add(btnSave);
            panelActions.Controls.Add(btnRemoveFolder);
            panelActions.Controls.Add(btnAddFolder);
            panelActions.Dock = DockStyle.Bottom;
            panelActions.FlowDirection = FlowDirection.RightToLeft;
            panelActions.Location = new Point(10, 369);
            panelActions.Name = "panelActions";
            panelActions.Padding = new Padding(0, 10, 0, 0);
            panelActions.Size = new Size(582, 50);
            panelActions.TabIndex = 2;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(0, 122, 204);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(429, 13);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(150, 35);
            btnSave.TabIndex = 0;
            btnSave.Text = "Guardar Cambios";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnRemoveFolder
            // 
            btnRemoveFolder.Location = new Point(303, 13);
            btnRemoveFolder.Name = "btnRemoveFolder";
            btnRemoveFolder.Size = new Size(120, 35);
            btnRemoveFolder.TabIndex = 1;
            btnRemoveFolder.Text = "Eliminar Carpeta";
            btnRemoveFolder.Click += btnRemoveFolder_Click;
            // 
            // btnAddFolder
            // 
            btnAddFolder.Location = new Point(177, 13);
            btnAddFolder.Name = "btnAddFolder";
            btnAddFolder.Size = new Size(120, 35);
            btnAddFolder.TabIndex = 2;
            btnAddFolder.Text = "+ Añadir Carpeta";
            btnAddFolder.Click += btnAddFolder_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(602, 429);
            Controls.Add(groupBoxFolders);
            Controls.Add(groupBoxGeneral);
            Controls.Add(panelActions);
            Font = new Font("Segoe UI", 9F);
            Name = "Form1";
            Padding = new Padding(10);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LogManager - Configurador Fase 1";
            groupBoxGeneral.ResumeLayout(false);
            groupBoxGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numGlobalMonths).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDayToRun).EndInit();
            groupBoxFolders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvFolders).EndInit();
            panelActions.ResumeLayout(false);
            ResumeLayout(false);
        }

        private System.Windows.Forms.GroupBox groupBoxGeneral;
        private System.Windows.Forms.Label lblDest;
        private System.Windows.Forms.TextBox txtDestPath;
        private System.Windows.Forms.Button btnSelectDest;
        private System.Windows.Forms.Label lblGlobalMonths;
        private System.Windows.Forms.NumericUpDown numGlobalMonths;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.NumericUpDown numDayToRun;
        private System.Windows.Forms.GroupBox groupBoxFolders;
        private System.Windows.Forms.DataGridView dgvFolders;
        private System.Windows.Forms.FlowLayoutPanel panelActions;
        private System.Windows.Forms.Button btnAddFolder;
        private System.Windows.Forms.Button btnRemoveFolder;
        private System.Windows.Forms.Button btnSave;
    }
}