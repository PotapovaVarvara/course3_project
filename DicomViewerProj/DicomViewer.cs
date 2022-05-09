using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL.Models;
using DicomViewerDemo;
using Serilog;

namespace DicomViewerProj
{
    public partial class DicomViewer : Form
    {
        private readonly IUserService _userService;
        private readonly IRecordRepository _recordRepository;

        private static readonly ILogger _logger = Log.ForContext<DicomViewer>();

        public DicomViewer(IUserService userService, IRecordRepository recordRepository)
        {
            _userService = userService;
            _recordRepository = recordRepository;

            InitializeComponent();
            this.Icon = Properties.Resources.app_ico;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await LoadAllUsers();

            _logger.Information("Form1 has been Initialized");
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void addUserBtn_Click(object sender, EventArgs e)
        {
            var newPatientForm = new AddPatientForm(_userService);
            newPatientForm.Show();
            newPatientForm.Closed += async (o, args) => { await LoadAllUsers();};
        }

        private async Task LoadAllUsers()
        {
            var users = await _userService.GetAllUsers();

            patientsDataGrid.Rows.Clear();

            foreach (var user in users)
            {
                // Id, Name, DOB, Sex, Complaints
                patientsDataGrid.Rows.Add(user.Id, user.Name, user.DOB.ToString("d"), user.Sex, user.Complaints);
            }
        }

        private void patientsDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var dataGridView = (DataGridView) sender;
            if (dataGridView.Columns[e.ColumnIndex].Name == "Id")
            {
                var userId = dataGridView.CurrentCell.Value.ToString();
                var addRecordForm = new PatientPageForm(_userService, _recordRepository);
                addRecordForm.PatientId = Guid.Parse(userId);
                addRecordForm.Show();
            }
        }

        private void addRecordBtn_Click(object sender, EventArgs e)
        {
          
        }

        private void goToRecordsBtn_Click(object sender, EventArgs e)
        {
            if (!ValidateSingleRowIsSelected())
            {
                return;
            }

            var patientId = GetCurrentRowPatientId();
        }

        private string GetCurrentRowPatientId()
        {
            if (patientsDataGrid.SelectedCells.Count <= 0) return null;

            var selectedRow = patientsDataGrid.Rows[patientsDataGrid.SelectedCells[0].RowIndex];
            return Convert.ToString(selectedRow.Cells["Id"].Value);

        }
        
        private bool ValidateSingleRowIsSelected()
        {
            if (patientsDataGrid.SelectedCells.Count == 0)
            {
                MessageBox.Show("Please select any row");
            }

            return patientsDataGrid.SelectedCells.Count > 0;
        }

    }
}
