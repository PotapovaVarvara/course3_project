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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sexLb = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nameLb = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sexLb);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.nameLb);
            this.groupBox1.Controls.Add(this.nameLabel);
            this.groupBox1.Location = new System.Drawing.Point(16, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(713, 245);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Patient Data";
            // 
            // sexLb
            // 
            this.sexLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sexLb.Location = new System.Drawing.Point(137, 70);
            this.sexLb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sexLb.Name = "sexLb";
            this.sexLb.Size = new System.Drawing.Size(101, 45);
            this.sexLb.TabIndex = 15;
            this.sexLb.Text = "-";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(28, 70);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 45);
            this.label3.TabIndex = 14;
            this.label3.Text = "Sex";
            // 
            // nameLb
            // 
            this.nameLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameLb.Location = new System.Drawing.Point(137, 25);
            this.nameLb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLb.Name = "nameLb";
            this.nameLb.Size = new System.Drawing.Size(101, 45);
            this.nameLb.TabIndex = 13;
            this.nameLb.Text = "-";
            // 
            // nameLabel
            // 
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameLabel.Location = new System.Drawing.Point(28, 25);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(101, 45);
            this.nameLabel.TabIndex = 12;
            this.nameLabel.Text = "Name";
            // 
            // AddRecordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 945);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddRecordForm";
            this.Text = "AddRecordForm";
            this.Load += new System.EventHandler(this.AddRecordForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label nameLabel;
		private System.Windows.Forms.Label nameLb;
		private System.Windows.Forms.Label sexLb;

		#endregion
	}
}