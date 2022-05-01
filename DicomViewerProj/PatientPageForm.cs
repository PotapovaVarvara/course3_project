using BLL;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vintasoft.Imaging.Annotation.Dicom.UI.VisualTools;


using Vintasoft.Imaging;
using Vintasoft.Imaging.Annotation;
using Vintasoft.Imaging.Annotation.Dicom;
using Vintasoft.Imaging.Annotation.Dicom.UI.VisualTools;
using Vintasoft.Imaging.Annotation.Formatters;
using Vintasoft.Imaging.Annotation.UI;
using Vintasoft.Imaging.Annotation.UI.VisualTools;
using Vintasoft.Imaging.Codecs;
using Vintasoft.Imaging.Codecs.Decoders;
using Vintasoft.Imaging.Codecs.Encoders;
using Vintasoft.Imaging.Codecs.ImageFiles.Dicom;
using Vintasoft.Imaging.Dicom.UI.VisualTools;
using Vintasoft.Imaging.ImageColors;
using Vintasoft.Imaging.Metadata;
using Vintasoft.Imaging.UI;
using Vintasoft.Imaging.UI.VisualTools;
using Vintasoft.Imaging.UIActions;

using DemosCommonCode;
using DemosCommonCode.Imaging;
using DemosCommonCode.Imaging.Codecs;
using DemosCommonCode.Imaging.Codecs.Dialogs;
using DemosCommonCode.Spelling;
using DemosCommonCode.Dicom;
using System.Collections.Generic;

namespace NakataniProject
{
    public partial class PatientPageForm : Form
    {
        /// DICOM annotated viewer tool.
        /// </summary>
        DicomAnnotatedViewerTool _dicomViewerTool;

        public Guid PatientId { set; private get; }

        private readonly IUserService _userService;

        bool _isVisualToolChanging = false;

        DicomSeriesController _dicomSeriesController = new DicomSeriesController();

        DicomFile _dicomFileWithoutImages = null;

        DicomDecodingSettings _dicomFrameDecodingSettings = new DicomDecodingSettings(false);


        DicomAnnotatedViewerToolInteractionMode _previousDicomViewerToolInteractionMode;

        AnnotationInteractionMode _previousDicomAnnotationToolInteractionMode;


        public PatientPageForm(IUserService userService)
        {
            InitializeComponent();

            this.Icon = Properties.Resources.app_ico;

            _userService = userService;

            MeasurementVisualToolActionFactory.CreateActions(dicomAnnotatedViewerToolStrip1);
            dicomAnnotatedViewerToolStrip1.Items.Remove(voiLutsToolStripSplitButton);
            dicomAnnotatedViewerToolStrip1.Items.Add(voiLutsToolStripSplitButton);

            NoneAction noneAction = dicomAnnotatedViewerToolStrip1.FindAction<NoneAction>();
            noneAction.Activated += new EventHandler(noneAction_Activated);
            noneAction.Deactivated += new EventHandler(noneAction_Deactivated);

            ImageMeasureToolAction imageMeasureToolAction =
               dicomAnnotatedViewerToolStrip1.FindAction<ImageMeasureToolAction>();
            imageMeasureToolAction.Activated += new EventHandler(imageMeasureToolAction_Activated);
            

               _dicomViewerTool = new DicomAnnotatedViewerTool(
                  new DicomViewerTool(),
                  new DicomAnnotationTool(),
                  (Vintasoft.Imaging.Annotation.Measurements.ImageMeasureTool)imageMeasureToolAction.VisualTool);
            

        }


        private async void PatientPageForm_Load(object sender, EventArgs e)
        {
            var user = await _userService.GetUsersByIdAsync(PatientId);

            nameLabel.Text = user.Name;
            ageLbl.Text = "age " + user.Age.ToString();
            sexLabel.Text = user.Sex;
        }

        private void splitContainer3_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer3_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenNewRecordEditor();
        }

        private void OpenNewRecordEditor()
        {
            if (openDicomFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (openDicomFileDialog.FileNames.Length > 0)
                {
                   // ClosePreviouslyOpenedFiles();

               //     AddDicomFilesToSeries(openDicomFileDialog.FileNames);
                    _dicomViewerTool.DicomViewerTool.DicomImageVoiLut =
                        _dicomViewerTool.DicomViewerTool.DefaultDicomImageVoiLut;
                }
            }
        }

        private void imageMeasureToolAction_Activated(object sender, EventArgs e)
        {
            _isVisualToolChanging = true;
            dicomAnnotatedViewerToolStrip1.MainVisualTool.ActiveTool = dicomAnnotatedViewerToolStrip1.DicomAnnotatedViewerTool;
            _dicomViewerTool.InteractionMode = DicomAnnotatedViewerToolInteractionMode.Measuring;
            _dicomViewerTool.DicomAnnotationTool.AnnotationInteractionMode = AnnotationInteractionMode.None;
            _isVisualToolChanging = false;
        }

        private void noneAction_Activated(object sender, EventArgs e)
        {
            // restore the DICOM viewer tool state
            dicomAnnotatedViewerToolStrip1.MainVisualTool.ActiveTool = dicomAnnotatedViewerToolStrip1.DicomAnnotatedViewerTool;
            _dicomViewerTool.InteractionMode = _previousDicomViewerToolInteractionMode;
            _dicomViewerTool.DicomAnnotationTool.AnnotationInteractionMode = _previousDicomAnnotationToolInteractionMode;
        }

        private void noneAction_Deactivated(object sender, EventArgs e)
        {
            // save the DICOM viewer tool state

            _previousDicomViewerToolInteractionMode = _dicomViewerTool.InteractionMode;
            _previousDicomAnnotationToolInteractionMode = _dicomViewerTool.DicomAnnotationTool.AnnotationInteractionMode;
        }


        /* private void AddDicomFilesToSeries(params string[] filesPath)
         {
             try
             {
                 List<DicomFile> filesForLoadPresentationState = new List<DicomFile>();
                 string dirPath = null;


                 actionLabel.Visible = true;
                 progressBar1.Visible = true;
                 progressBar1.Maximum = filesPath.Length;
                 progressBar1.Value = 0

                 bool skipCorruptedFiles = false;

                 foreach (string filePath in filesPath)
                 {
                     if (dirPath == null)
                         dirPath = System.IO.Path.GetDirectoryName(filePath);


                     actionLabel.Text = string.Format("Loading {0}", Path.GetFileName(filePath));

                     progressBar1.Value++;
                     statusStrip1.Update();
                     imageViewer1.Update();

                     DicomFile dicomFile = null;
                     try
                     {
                         // if the series already contains the specified DICOM file
                         if (_dicomSeriesController.Contains(filePath))
                         {
                             DemosTools.ShowInfoMessage(string.Format("The series already contains DICOM file \"{0}\".", Path.GetFileName(filePath)));
                             return;
                         }

                         // instance number of new DICOM file
                         int newDicomFileInstanceNumber = 0;
                         // add DICOM file to the current series of DICOM images and get the DICOM images of new DICOM file
                         ImageCollection newDicomImages =
                             _dicomSeriesController.AddDicomFileToSeries(filePath, out dicomFile, out newDicomFileInstanceNumber);

                         // if DICOM file represents the DICOM directory
                         if (IsDicomDirectory(dicomFile))
                         {
                             // close the DICOM file
                             _dicomSeriesController.CloseDicomFile(dicomFile);
                             // show the error message
                             DemosTools.ShowInfoMessage("The DICOM directory cannot be added to the series of DICOM images.");
                             return;
                         }

                         //IsDicomFileOpening = true;

                         // if DICOM file does not contain images
                         if (dicomFile.Pages.Count == 0)
                         {
                             // if image viewer contains images
                             if (imageViewer1.Images.Count > 0)
                             {
                                 DemosTools.ShowInfoMessage("The DICOM file cannot be added to the series of DICOM images because the DICOM file does not contain image.");
                             }
                             else
                             {
                                 // save reference to the DICOM file
                                 _dicomFileWithoutImages = dicomFile;

                                 // show message for user
                                 DemosTools.ShowInfoMessage("DICOM file does not contain image.");
                                 // show metadata of DICOM file
                                 ShowCurrentFileMetadata();
                             }
                         }
                         else
                         {
                             // update frame count in series
                             imageViewerToolStrip1.PageCount = imageViewer1.Images.Count + dicomFile.Pages.Count;

                             // get image index in image collection of current DICOM file
                             int imageIndex = GetImageIndexInImageCollectionForNewImage(newDicomFileInstanceNumber);

                             try
                             {
                                 // insert images to the specified index
                                 imageViewer1.Images.InsertRange(imageIndex, newDicomImages.ToArray());
                             }
                             catch
                             {
                                 // remove new DICOM images from image collection of image viewer
                                 foreach (VintasoftImage newDicomImage in newDicomImages)
                                     imageViewer1.Images.Remove(newDicomImage);

                                 // close new DICOM file
                                 _dicomSeriesController.CloseDicomFile(dicomFile);
                                 dicomFile = null;

                                 // update frame count in series
                                 imageViewerToolStrip1.PageCount = imageViewer1.Images.Count;

                                 throw;
                             }

                             // if DICOM presentation state file must be loaded automatically
                             if (presentationStateLoadAutomaticallyToolStripMenuItem.Checked)
                             {
                                 filesForLoadPresentationState.Add(dicomFile);
                             }

                             // if image viewer shows the first image in series
                             if (imageViewerToolStrip1.PageCount == dicomFile.Pages.Count)
                                 // update UI of DICOM file
                                 UpdateUIWithInformationAboutDicomFile();
                         }

                         // update header of form
                         this.Text = string.Format(_titlePrefix, Path.GetFileName(filePath));
                     }
                     catch (Exception ex)
                     {
                         // close file
                         if (dicomFile != null)
                             _dicomSeriesController.CloseDicomFile(dicomFile);

                         if (!skipCorruptedFiles)
                         {
                             if (filesPath.Length == 1)
                             {
                                 DemosTools.ShowErrorMessage(ex);

                                 dirPath = null;
                                 CloseDicomSeries();
                             }
                             else
                             {
                                 string exceptionMessage = string.Format(
                                     "The file '{0}' can not be opened:\r\n\"{1}\"\r\nDo you want to continue anyway?",
                                     Path.GetFileName(filePath), DemosTools.GetFullExceptionMessage(ex).Trim());
                                 if (MessageBox.Show(
                                     exceptionMessage,
                                     "Error",
                                     MessageBoxButtons.YesNo,
                                     MessageBoxIcon.Error) == DialogResult.No)
                                 {
                                     dirPath = null;
                                     CloseDicomSeries();
                                     break;
                                 }
                             }

                             skipCorruptedFiles = true;
                         }
                     }
                 }

                 // hide action label and progress bar
                 actionLabel.Text = string.Empty;
                 actionLabel.Visible = false;
                 progressBar1.Visible = false;

                 if (!string.IsNullOrEmpty(dirPath))
                 {
                     // if DICOM presentation files must be loaded automatically
                     if (presentationStateLoadAutomaticallyToolStripMenuItem.Checked)
                         // load presentation state file of DICOM file
                         LoadAnnotationsFromPresentationStateFiles(dirPath, filesForLoadPresentationState.ToArray());
                 }

                 // update UI
                 UpdateUI();
             }
             finally
             {
                 // hide action label and progress bar
                 actionLabel.Text = string.Empty;
                 actionLabel.Visible = false;
                 progressBar1.Visible = false;

                 if (!_isFormClosing)
                 {
                     // update the UI
                     IsDicomFileOpening = false;
                 }
             }
         }*/

        private bool IsDicomDirectory(DicomFile dicomFile)
        {
            if (dicomFile.DataSet.DataElements.Contains(DicomDataElementId.DirectoryRecordSequence))
                return true;

            return false;
        }

    }
}
