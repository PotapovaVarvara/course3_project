namespace NakataniProject
{
    partial class Form1
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
            this.TabsControl = new System.Windows.Forms.TabControl();
            this.PatientsTab = new System.Windows.Forms.TabPage();
            this.goToRecordsBtn = new System.Windows.Forms.Button();
            this.addRecordBtn = new System.Windows.Forms.Button();
            this.addUserBtn = new System.Windows.Forms.Button();
            this.patientsDataGrid = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Complaints = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RecordsTab = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RecordTab = new System.Windows.Forms.TabPage();
            this.menuStrip1.SuspendLayout();
            this.TabsControl.SuspendLayout();
            this.PatientsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.patientsDataGrid)).BeginInit();
            this.RecordsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // TabsControl
            // 
            this.TabsControl.Controls.Add(this.PatientsTab);
            this.TabsControl.Controls.Add(this.RecordsTab);
            this.TabsControl.Controls.Add(this.RecordTab);
            this.TabsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabsControl.Location = new System.Drawing.Point(0, 24);
            this.TabsControl.Name = "TabsControl";
            this.TabsControl.SelectedIndex = 0;
            this.TabsControl.Size = new System.Drawing.Size(800, 426);
            this.TabsControl.TabIndex = 4;
            // 
            // PatientsTab
            // 
            this.PatientsTab.Controls.Add(this.goToRecordsBtn);
            this.PatientsTab.Controls.Add(this.addRecordBtn);
            this.PatientsTab.Controls.Add(this.addUserBtn);
            this.PatientsTab.Controls.Add(this.patientsDataGrid);
            this.PatientsTab.Location = new System.Drawing.Point(4, 22);
            this.PatientsTab.Name = "PatientsTab";
            this.PatientsTab.Padding = new System.Windows.Forms.Padding(3);
            this.PatientsTab.Size = new System.Drawing.Size(792, 400);
            this.PatientsTab.TabIndex = 0;
            this.PatientsTab.Text = "Patients";
            this.PatientsTab.UseVisualStyleBackColor = true;
            // 
            // goToRecordsBtn
            // 
            this.goToRecordsBtn.Location = new System.Drawing.Point(305, 16);
            this.goToRecordsBtn.Name = "goToRecordsBtn";
            this.goToRecordsBtn.Size = new System.Drawing.Size(119, 21);
            this.goToRecordsBtn.TabIndex = 8;
            this.goToRecordsBtn.Text = "Go To Records";
            this.goToRecordsBtn.UseVisualStyleBackColor = true;
            this.goToRecordsBtn.Click += new System.EventHandler(this.goToRecordsBtn_Click);
            // 
            // addRecordBtn
            // 
            this.addRecordBtn.Location = new System.Drawing.Point(158, 16);
            this.addRecordBtn.Name = "addRecordBtn";
            this.addRecordBtn.Size = new System.Drawing.Size(119, 21);
            this.addRecordBtn.TabIndex = 7;
            this.addRecordBtn.Text = "Add a Record";
            this.addRecordBtn.UseVisualStyleBackColor = true;
            this.addRecordBtn.Click += new System.EventHandler(this.addRecordBtn_Click);
            // 
            // addUserBtn
            // 
            this.addUserBtn.Location = new System.Drawing.Point(18, 16);
            this.addUserBtn.Name = "addUserBtn";
            this.addUserBtn.Size = new System.Drawing.Size(119, 21);
            this.addUserBtn.TabIndex = 6;
            this.addUserBtn.Text = "Add a Patient";
            this.addUserBtn.UseVisualStyleBackColor = true;
            this.addUserBtn.Click += new System.EventHandler(this.addUserBtn_Click);
            // 
            // patientsDataGrid
            // 
            this.patientsDataGrid.AllowUserToAddRows = false;
            this.patientsDataGrid.AllowUserToDeleteRows = false;
            this.patientsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.Id, this.PatientName, this.DOB, this.Sex, this.Complaints});
            this.patientsDataGrid.Location = new System.Drawing.Point(18, 56);
            this.patientsDataGrid.MultiSelect = false;
            this.patientsDataGrid.Name = "patientsDataGrid";
            this.patientsDataGrid.ReadOnly = true;
            this.patientsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.patientsDataGrid.Size = new System.Drawing.Size(766, 217);
            this.patientsDataGrid.TabIndex = 5;
            this.patientsDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.patientsDataGrid_CellClick);
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // PatientName
            // 
            this.PatientName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PatientName.HeaderText = "Patient Name";
            this.PatientName.Name = "PatientName";
            this.PatientName.ReadOnly = true;
            // 
            // DOB
            // 
            this.DOB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DOB.HeaderText = "DOB";
            this.DOB.Name = "DOB";
            this.DOB.ReadOnly = true;
            // 
            // Sex
            // 
            this.Sex.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Sex.HeaderText = "Sex";
            this.Sex.Name = "Sex";
            this.Sex.ReadOnly = true;
            // 
            // Complaints
            // 
            this.Complaints.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Complaints.HeaderText = "Complaints";
            this.Complaints.Name = "Complaints";
            this.Complaints.ReadOnly = true;
            // 
            // RecordsTab
            // 
            this.RecordsTab.Controls.Add(this.dataGridView1);
            this.RecordsTab.Location = new System.Drawing.Point(4, 22);
            this.RecordsTab.Name = "RecordsTab";
            this.RecordsTab.Padding = new System.Windows.Forms.Padding(3);
            this.RecordsTab.Size = new System.Drawing.Size(792, 400);
            this.RecordsTab.TabIndex = 1;
            this.RecordsTab.Text = "Records";
            this.RecordsTab.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.dataGridViewTextBoxColumn1, this.PatientId, this.dataGridViewTextBoxColumn2});
            this.dataGridView1.Location = new System.Drawing.Point(8, 17);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(766, 217);
            this.dataGridView1.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // PatientId
            // 
            this.PatientId.HeaderText = "Patient Id";
            this.PatientId.Name = "PatientId";
            this.PatientId.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Patient Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // RecordTab
            // 
            this.RecordTab.Location = new System.Drawing.Point(4, 22);
            this.RecordTab.Name = "RecordTab";
            this.RecordTab.Padding = new System.Windows.Forms.Padding(3);
            this.RecordTab.Size = new System.Drawing.Size(792, 400);
            this.RecordTab.TabIndex = 2;
            this.RecordTab.Text = "Record";
            this.RecordTab.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TabsControl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.TabsControl.ResumeLayout(false);
            this.PatientsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.patientsDataGrid)).EndInit();
            this.RecordsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientId;

        private System.Windows.Forms.DataGridView dataGridView1;

        private System.Windows.Forms.Button goToRecordsBtn;

        private System.Windows.Forms.TabPage RecordTab;

        private System.Windows.Forms.Button addRecordBtn;

        private System.Windows.Forms.DataGridViewTextBoxColumn Complaints;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sex;


        private System.Windows.Forms.Button addUserBtn;

        private System.Windows.Forms.DataGridView patientsDataGrid;

        private System.Windows.Forms.TabControl TabsControl;
        private System.Windows.Forms.TabPage PatientsTab;
        private System.Windows.Forms.TabPage RecordsTab;


        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;

        #endregion
    }
}

