
namespace NakataniProject
{
    partial class PatientPageForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            Vintasoft.Imaging.Utils.WinFormsSystemClipboard winFormsSystemClipboard1 = new Vintasoft.Imaging.Utils.WinFormsSystemClipboard();
            Vintasoft.Imaging.UI.ThumbnailAppearance thumbnailAppearance1 = new Vintasoft.Imaging.UI.ThumbnailAppearance();
            Vintasoft.Imaging.UI.ThumbnailAppearance thumbnailAppearance2 = new Vintasoft.Imaging.UI.ThumbnailAppearance();
            Vintasoft.Imaging.UI.ThumbnailAppearance thumbnailAppearance3 = new Vintasoft.Imaging.UI.ThumbnailAppearance();
            Vintasoft.Imaging.UI.ThumbnailAppearance thumbnailAppearance4 = new Vintasoft.Imaging.UI.ThumbnailAppearance();
            Vintasoft.Imaging.UI.ThumbnailAppearance thumbnailAppearance5 = new Vintasoft.Imaging.UI.ThumbnailAppearance();
            Vintasoft.Imaging.UI.ThumbnailCaption thumbnailCaption1 = new Vintasoft.Imaging.UI.ThumbnailCaption();
            Vintasoft.Imaging.Codecs.Decoders.RenderingSettings renderingSettings1 = new Vintasoft.Imaging.Codecs.Decoders.RenderingSettings();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ageLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.thumbnailViewer1 = new Vintasoft.Imaging.UI.ThumbnailViewer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.imageViewer1 = new Vintasoft.Imaging.UI.ImageViewer();
            this.dicomAnnotatedViewerToolStrip1 = new DemosCommonCode.Imaging.DicomAnnotatedViewerToolStrip();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.imageViewer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ageLbl);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.nameLabel);
            this.groupBox1.Location = new System.Drawing.Point(13, 5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(464, 166);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Patient Data";
            // 
            // ageLbl
            // 
            this.ageLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ageLbl.Location = new System.Drawing.Point(28, 72);
            this.ageLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ageLbl.Name = "ageLbl";
            this.ageLbl.Size = new System.Drawing.Size(101, 45);
            this.ageLbl.TabIndex = 15;
            this.ageLbl.Text = "Age";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(28, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 45);
            this.label3.TabIndex = 14;
            this.label3.Text = "Sex";
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(80, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 33);
            this.button1.TabIndex = 17;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitContainer1.Location = new System.Drawing.Point(0, 707);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.thumbnailViewer1);
            this.splitContainer1.Size = new System.Drawing.Size(1445, 185);
            this.splitContainer1.SplitterDistance = 481;
            this.splitContainer1.TabIndex = 19;
            // 
            // thumbnailViewer1
            // 
            this.thumbnailViewer1.AllowDrop = true;
            this.thumbnailViewer1.AutoScrollMinSize = new System.Drawing.Size(1, 1);
            this.thumbnailViewer1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.thumbnailViewer1.Clipboard = winFormsSystemClipboard1;
            this.thumbnailViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            thumbnailAppearance1.BackColor = System.Drawing.Color.Transparent;
            thumbnailAppearance1.BorderColor = System.Drawing.Color.Gray;
            thumbnailAppearance1.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Dotted;
            thumbnailAppearance1.BorderWidth = 1;
            this.thumbnailViewer1.FocusedThumbnailAppearance = thumbnailAppearance1;
            thumbnailAppearance2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(186)))), ((int)(((byte)(210)))), ((int)(((byte)(235)))));
            thumbnailAppearance2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(186)))), ((int)(((byte)(210)))), ((int)(((byte)(235)))));
            thumbnailAppearance2.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            thumbnailAppearance2.BorderWidth = 2;
            this.thumbnailViewer1.HoveredThumbnailAppearance = thumbnailAppearance2;
            this.thumbnailViewer1.ImageRotationAngle = 0;
            this.thumbnailViewer1.Location = new System.Drawing.Point(0, 0);
            this.thumbnailViewer1.Name = "thumbnailViewer1";
            thumbnailAppearance3.BackColor = System.Drawing.Color.Black;
            thumbnailAppearance3.BorderColor = System.Drawing.Color.Black;
            thumbnailAppearance3.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            thumbnailAppearance3.BorderWidth = 0;
            this.thumbnailViewer1.NotReadyThumbnailAppearance = thumbnailAppearance3;
            thumbnailAppearance4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(238)))), ((int)(((byte)(253)))));
            thumbnailAppearance4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(222)))), ((int)(((byte)(253)))));
            thumbnailAppearance4.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            thumbnailAppearance4.BorderWidth = 1;
            this.thumbnailViewer1.SelectedThumbnailAppearance = thumbnailAppearance4;
            this.thumbnailViewer1.Size = new System.Drawing.Size(960, 185);
            this.thumbnailViewer1.TabIndex = 0;
            this.thumbnailViewer1.Text = "thumbnailViewer1";
            thumbnailAppearance5.BackColor = System.Drawing.Color.Transparent;
            thumbnailAppearance5.BorderColor = System.Drawing.Color.Transparent;
            thumbnailAppearance5.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            thumbnailAppearance5.BorderWidth = 1;
            this.thumbnailViewer1.ThumbnailAppearance = thumbnailAppearance5;
            thumbnailCaption1.Padding = new Vintasoft.Imaging.PaddingF(0F, 0F, 0F, 0F);
            thumbnailCaption1.TextColor = System.Drawing.Color.Black;
            this.thumbnailViewer1.ThumbnailCaption = thumbnailCaption1;
            this.thumbnailViewer1.ThumbnailImagePadding = new Vintasoft.Imaging.PaddingF(0F, 0F, 0F, 0F);
            this.thumbnailViewer1.ThumbnailMargin = new System.Windows.Forms.Padding(3);
            this.thumbnailViewer1.ThumbnailSize = new System.Drawing.Size(100, 100);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.button1);
            this.splitContainer2.Size = new System.Drawing.Size(1445, 179);
            this.splitContainer2.SplitterDistance = 481;
            this.splitContainer2.TabIndex = 20;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 179);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer3_Panel1_Paint);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.imageViewer1);
            this.splitContainer3.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer3_Panel2_Paint);
            this.splitContainer3.Size = new System.Drawing.Size(1445, 528);
            this.splitContainer3.SplitterDistance = 481;
            this.splitContainer3.TabIndex = 21;
            // 
            // imageViewer1
            // 
            this.imageViewer1.BackColor = System.Drawing.Color.Black;
            this.imageViewer1.Clipboard = winFormsSystemClipboard1;
            this.imageViewer1.Controls.Add(this.dicomAnnotatedViewerToolStrip1);
            this.imageViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageViewer1.ImageRenderingSettings = renderingSettings1;
            this.imageViewer1.ImageRotationAngle = 0;
            this.imageViewer1.Location = new System.Drawing.Point(0, 0);
            this.imageViewer1.Name = "imageViewer1";
            this.imageViewer1.Size = new System.Drawing.Size(960, 528);
            this.imageViewer1.TabIndex = 0;
            this.imageViewer1.Text = "imageViewer1";
            // 
            // dicomAnnotatedViewerToolStrip1
            // 
            this.dicomAnnotatedViewerToolStrip1.DicomAnnotatedViewerTool = null;
            this.dicomAnnotatedViewerToolStrip1.Enabled = false;
            this.dicomAnnotatedViewerToolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.dicomAnnotatedViewerToolStrip1.ImageViewer = null;
            this.dicomAnnotatedViewerToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.dicomAnnotatedViewerToolStrip1.MandatoryVisualTool = null;
            this.dicomAnnotatedViewerToolStrip1.Name = "dicomAnnotatedViewerToolStrip1";
            this.dicomAnnotatedViewerToolStrip1.Size = new System.Drawing.Size(960, 25);
            this.dicomAnnotatedViewerToolStrip1.TabIndex = 0;
            this.dicomAnnotatedViewerToolStrip1.Text = "dicomAnnotatedViewerToolStrip1";
            this.dicomAnnotatedViewerToolStrip1.VisualToolsMenuItem = null;
            // 
            // PatientPageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1445, 892);
            this.Controls.Add(this.splitContainer3);
            this.Controls.Add(this.splitContainer2);
            this.Controls.Add(this.splitContainer1);
            this.Name = "PatientPageForm";
            this.Text = "PatientPageForm";
            this.Load += new System.EventHandler(this.PatientPageForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.imageViewer1.ResumeLayout(false);
            this.imageViewer1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private Vintasoft.Imaging.UI.ThumbnailViewer thumbnailViewer1;
        private Vintasoft.Imaging.UI.ImageViewer imageViewer1;
        private System.Windows.Forms.Label ageLbl;
        private DemosCommonCode.Imaging.DicomAnnotatedViewerToolStrip dicomAnnotatedViewerToolStrip1;
    }
}