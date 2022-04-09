using System.ComponentModel;

namespace NakataniProject
{
	partial class AddRecordForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private IContainer components = null;

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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddRecordForm));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.sexLb = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.nameLb = new System.Windows.Forms.Label();
			this.nameLabel = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.surveyTimeLb = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.surveyDateLb = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.dotDataGrid = new System.Windows.Forms.DataGridView();
			this.Complaints = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.L = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.R = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) (this.dotDataGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.sexLb);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.nameLb);
			this.groupBox1.Controls.Add(this.nameLabel);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(535, 159);
			this.groupBox1.TabIndex = 13;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Patient Data";
			// 
			// sexLb
			// 
			this.sexLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
			this.sexLb.Location = new System.Drawing.Point(181, 79);
			this.sexLb.Name = "sexLb";
			this.sexLb.Size = new System.Drawing.Size(76, 29);
			this.sexLb.TabIndex = 15;
			this.sexLb.Text = "-";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
			this.label3.Location = new System.Drawing.Point(21, 79);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(76, 29);
			this.label3.TabIndex = 14;
			this.label3.Text = "Sex";
			// 
			// nameLb
			// 
			this.nameLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
			this.nameLb.Location = new System.Drawing.Point(181, 33);
			this.nameLb.Name = "nameLb";
			this.nameLb.Size = new System.Drawing.Size(76, 29);
			this.nameLb.TabIndex = 13;
			this.nameLb.Text = "-";
			// 
			// nameLabel
			// 
			this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
			this.nameLabel.Location = new System.Drawing.Point(21, 33);
			this.nameLabel.Name = "nameLabel";
			this.nameLabel.Size = new System.Drawing.Size(76, 29);
			this.nameLabel.TabIndex = 12;
			this.nameLabel.Text = "Name";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.surveyTimeLb);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.surveyDateLb);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Location = new System.Drawing.Point(571, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(393, 159);
			this.groupBox2.TabIndex = 16;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Survey Data";
			// 
			// surveyTimeLb
			// 
			this.surveyTimeLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
			this.surveyTimeLb.Location = new System.Drawing.Point(200, 79);
			this.surveyTimeLb.Name = "surveyTimeLb";
			this.surveyTimeLb.Size = new System.Drawing.Size(76, 29);
			this.surveyTimeLb.TabIndex = 15;
			this.surveyTimeLb.Text = "-";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
			this.label2.Location = new System.Drawing.Point(21, 79);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(137, 29);
			this.label2.TabIndex = 14;
			this.label2.Text = "Survey Time";
			// 
			// surveyDateLb
			// 
			this.surveyDateLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
			this.surveyDateLb.Location = new System.Drawing.Point(200, 33);
			this.surveyDateLb.Name = "surveyDateLb";
			this.surveyDateLb.Size = new System.Drawing.Size(76, 29);
			this.surveyDateLb.TabIndex = 13;
			this.surveyDateLb.Text = "-";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
			this.label5.Location = new System.Drawing.Point(21, 33);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(154, 29);
			this.label5.TabIndex = 12;
			this.label5.Text = "Survey Date";
			// 
			// dotDataGrid
			// 
			this.dotDataGrid.AllowUserToAddRows = false;
			this.dotDataGrid.AllowUserToDeleteRows = false;
			this.dotDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dotDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.Complaints, this.L, this.R});
			this.dotDataGrid.Location = new System.Drawing.Point(12, 201);
			this.dotDataGrid.MultiSelect = false;
			this.dotDataGrid.Name = "dotDataGrid";
			this.dotDataGrid.ReadOnly = true;
			this.dotDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dotDataGrid.Size = new System.Drawing.Size(535, 360);
			this.dotDataGrid.TabIndex = 17;
			this.dotDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dotDataGrid_CellClick);
			// 
			// Complaints
			// 
			this.Complaints.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Complaints.HeaderText = "Dot";
			this.Complaints.Name = "Complaints";
			this.Complaints.ReadOnly = true;
			// 
			// L
			// 
			this.L.HeaderText = "L (left)";
			this.L.Name = "L";
			this.L.ReadOnly = true;
			// 
			// R
			// 
			this.R.HeaderText = "R (right)";
			this.R.Name = "R";
			this.R.ReadOnly = true;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(572, 204);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(391, 357);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 18;
			this.pictureBox1.TabStop = false;
			// 
			// AddRecordForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(976, 614);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.dotDataGrid);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "AddRecordForm";
			this.Text = "AddRecordForm";
			this.Load += new System.EventHandler(this.AddRecordForm_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize) (this.dotDataGrid)).EndInit();
			((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
		}

		private System.Windows.Forms.DataGridViewTextBoxColumn Complaints;
		private System.Windows.Forms.DataGridViewTextBoxColumn L;
		private System.Windows.Forms.DataGridViewTextBoxColumn R;

		private System.Windows.Forms.DataGridView dotDataGrid;
		private System.Windows.Forms.PictureBox pictureBox1;

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label surveyTimeLb;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label surveyDateLb;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label nameLabel;
		private System.Windows.Forms.Label nameLb;
		private System.Windows.Forms.Label sexLb;

		#endregion
	}
}