namespace DicomViewerProj
{
    partial class DicomViewer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RecordsTab = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientsTab = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.addUserBtn = new System.Windows.Forms.Button();
            this.patientsDataGrid = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Complaints = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TabsControl = new System.Windows.Forms.TabControl();
            this.menuStrip1.SuspendLayout();
            this.RecordsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.PatientsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientsDataGrid)).BeginInit();
            this.TabsControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1067, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // RecordsTab
            // 
            this.RecordsTab.Controls.Add(this.dataGridView1);
            this.RecordsTab.Location = new System.Drawing.Point(4, 29);
            this.RecordsTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RecordsTab.Name = "RecordsTab";
            this.RecordsTab.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RecordsTab.Size = new System.Drawing.Size(1059, 629);
            this.RecordsTab.TabIndex = 1;
            this.RecordsTab.Text = "Records";
            this.RecordsTab.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.PatientId,
            this.dataGridViewTextBoxColumn2});
            this.dataGridView1.Location = new System.Drawing.Point(11, 26);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1021, 334);
            this.dataGridView1.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // PatientId
            // 
            this.PatientId.HeaderText = "Patient Id";
            this.PatientId.MinimumWidth = 6;
            this.PatientId.Name = "PatientId";
            this.PatientId.ReadOnly = true;
            this.PatientId.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Patient Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // PatientsTab
            // 
            this.PatientsTab.Controls.Add(this.splitContainer1);
            this.PatientsTab.Location = new System.Drawing.Point(4, 29);
            this.PatientsTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PatientsTab.Name = "PatientsTab";
            this.PatientsTab.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PatientsTab.Size = new System.Drawing.Size(1059, 629);
            this.PatientsTab.TabIndex = 0;
            this.PatientsTab.Text = "Patients";
            this.PatientsTab.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(4, 5);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.addUserBtn);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.patientsDataGrid);
            this.splitContainer1.Size = new System.Drawing.Size(1051, 619);
            this.splitContainer1.SplitterDistance = 56;
            this.splitContainer1.TabIndex = 7;
            // 
            // addUserBtn
            // 
            this.addUserBtn.Location = new System.Drawing.Point(16, 15);
            this.addUserBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addUserBtn.Name = "addUserBtn";
            this.addUserBtn.Size = new System.Drawing.Size(159, 32);
            this.addUserBtn.TabIndex = 6;
            this.addUserBtn.Text = "Add a Patient";
            this.addUserBtn.UseVisualStyleBackColor = true;
            this.addUserBtn.Click += new System.EventHandler(this.addUserBtn_Click);
            // 
            // patientsDataGrid
            // 
            this.patientsDataGrid.AllowUserToAddRows = false;
            this.patientsDataGrid.AllowUserToDeleteRows = false;
            this.patientsDataGrid.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.patientsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.PatientName,
            this.DOB,
            this.Sex,
            this.Complaints});
            this.patientsDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.patientsDataGrid.Location = new System.Drawing.Point(0, 0);
            this.patientsDataGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.patientsDataGrid.MultiSelect = false;
            this.patientsDataGrid.Name = "patientsDataGrid";
            this.patientsDataGrid.ReadOnly = true;
            this.patientsDataGrid.RowHeadersWidth = 51;
            this.patientsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.patientsDataGrid.Size = new System.Drawing.Size(1051, 559);
            this.patientsDataGrid.TabIndex = 5;
            this.patientsDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.patientsDataGrid_CellClick);
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // PatientName
            // 
            this.PatientName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PatientName.HeaderText = "Patient Name";
            this.PatientName.MinimumWidth = 6;
            this.PatientName.Name = "PatientName";
            this.PatientName.ReadOnly = true;
            // 
            // DOB
            // 
            this.DOB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DOB.HeaderText = "DOB";
            this.DOB.MinimumWidth = 6;
            this.DOB.Name = "DOB";
            this.DOB.ReadOnly = true;
            // 
            // Sex
            // 
            this.Sex.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Sex.HeaderText = "Sex";
            this.Sex.MinimumWidth = 6;
            this.Sex.Name = "Sex";
            this.Sex.ReadOnly = true;
            // 
            // Complaints
            // 
            this.Complaints.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Complaints.HeaderText = "Complaints";
            this.Complaints.MinimumWidth = 6;
            this.Complaints.Name = "Complaints";
            this.Complaints.ReadOnly = true;
            // 
            // TabsControl
            // 
            this.TabsControl.Controls.Add(this.PatientsTab);
            this.TabsControl.Controls.Add(this.RecordsTab);
            this.TabsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabsControl.Location = new System.Drawing.Point(0, 30);
            this.TabsControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TabsControl.Name = "TabsControl";
            this.TabsControl.SelectedIndex = 0;
            this.TabsControl.Size = new System.Drawing.Size(1067, 662);
            this.TabsControl.TabIndex = 4;
            // 
            // DicomViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 692);
            this.Controls.Add(this.TabsControl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DicomViewer";
            this.Text = "Dicom Viewer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.RecordsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.PatientsTab.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.patientsDataGrid)).EndInit();
            this.TabsControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;

        #endregion

        private System.Windows.Forms.TabPage RecordsTab;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.TabPage PatientsTab;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button addUserBtn;
        private System.Windows.Forms.DataGridView patientsDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn Complaints;
        private System.Windows.Forms.TabControl TabsControl;
    }
}

