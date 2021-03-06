using System.ComponentModel;

namespace NakataniProject
{
	partial class AddPatientForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPatientForm));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.nameLabel = new System.Windows.Forms.Label();
			this.nametb = new System.Windows.Forms.TextBox();
			this.Сomplaintstb = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.DOBtb = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.sextb = new System.Windows.Forms.ComboBox();
			this.savePatientBtn = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(35, 36);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(180, 154);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// nameLabel
			// 
			this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
			this.nameLabel.Location = new System.Drawing.Point(270, 41);
			this.nameLabel.Name = "nameLabel";
			this.nameLabel.Size = new System.Drawing.Size(76, 29);
			this.nameLabel.TabIndex = 1;
			this.nameLabel.Text = "Name";
			// 
			// nametb
			// 
			this.nametb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
			this.nametb.Location = new System.Drawing.Point(437, 36);
			this.nametb.Name = "nametb";
			this.nametb.Size = new System.Drawing.Size(340, 32);
			this.nametb.TabIndex = 2;
			// 
			// Сomplaintstb
			// 
			this.Сomplaintstb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
			this.Сomplaintstb.Location = new System.Drawing.Point(219, 231);
			this.Сomplaintstb.Multiline = true;
			this.Сomplaintstb.Name = "Сomplaintstb";
			this.Сomplaintstb.Size = new System.Drawing.Size(558, 157);
			this.Сomplaintstb.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
			this.label1.Location = new System.Drawing.Point(52, 234);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(125, 29);
			this.label1.TabIndex = 3;
			this.label1.Text = "Сomplaints";
			// 
			// DOBtb
			// 
			this.DOBtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
			this.DOBtb.Location = new System.Drawing.Point(437, 101);
			this.DOBtb.Name = "DOBtb";
			this.DOBtb.Size = new System.Drawing.Size(340, 32);
			this.DOBtb.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
			this.label2.Location = new System.Drawing.Point(270, 104);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(76, 29);
			this.label2.TabIndex = 6;
			this.label2.Text = "DOB";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
			this.label3.Location = new System.Drawing.Point(270, 161);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(76, 29);
			this.label3.TabIndex = 8;
			this.label3.Text = "Sex";
			// 
			// sextb
			// 
			this.sextb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.sextb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
			this.sextb.FormattingEnabled = true;
			this.sextb.Items.AddRange(new object[] {"male", "female"});
			this.sextb.Location = new System.Drawing.Point(437, 157);
			this.sextb.Name = "sextb";
			this.sextb.Size = new System.Drawing.Size(340, 33);
			this.sextb.TabIndex = 9;
			// 
			// savePatientBtn
			// 
			this.savePatientBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
			this.savePatientBtn.Location = new System.Drawing.Point(652, 466);
			this.savePatientBtn.Name = "savePatientBtn";
			this.savePatientBtn.Size = new System.Drawing.Size(152, 46);
			this.savePatientBtn.TabIndex = 10;
			this.savePatientBtn.Text = "Save";
			this.savePatientBtn.UseVisualStyleBackColor = true;
			this.savePatientBtn.Click += new System.EventHandler(this.savePatientBtn_Click);
			// 
			// AddPatientForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(816, 524);
			this.Controls.Add(this.savePatientBtn);
			this.Controls.Add(this.sextb);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.DOBtb);
			this.Controls.Add(this.Сomplaintstb);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.nametb);
			this.Controls.Add(this.nameLabel);
			this.Controls.Add(this.pictureBox1);
			this.Name = "AddPatientForm";
			this.Text = "AddPatientForm";
			((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		private System.Windows.Forms.Button savePatientBtn;

		private System.Windows.Forms.ComboBox sextb;

		private System.Windows.Forms.DateTimePicker DOBtb;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox nametb;
		private System.Windows.Forms.TextBox Сomplaintstb;

		private System.Windows.Forms.Label nameLabel;

		private System.Windows.Forms.PictureBox pictureBox1;

		#endregion
	}
}