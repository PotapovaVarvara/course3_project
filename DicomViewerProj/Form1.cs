using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace NakataniProject
{
    public partial class Form1 : Form
    {
        private readonly IUserService _userService;
        
        public Form1(IUserService userService)
        {
            _userService = userService;
            
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await LoadAllUsers();
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
                patientsDataGrid.Rows.Add(user.Id, user.Name, user.DOB, user.Sex, user.Complaints);
            }
        }

        private void patientsDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var dataGridView = (DataGridView) sender;
            /*if (dataGridView.Columns[e.ColumnIndex].DataPropertyName == "Id")
            {
                var id = dataGridView.CurrentCell.Value.ToString();
            }*/

            if (dataGridView.SelectedCells.Count > 0)
            {
                var selectedRow = dataGridView.Rows[dataGridView.SelectedCells[0].RowIndex];
                var isCellValue = Convert.ToString(selectedRow.Cells["Id"].Value);
            }
        }

        private void addRecordBtn_Click(object sender, EventArgs e)
        {
            var selectedRow = patientsDataGrid.SelectedRows;

            var addRecordForm = new AddRecordForm(GetCurrentRowPatientId());
            addRecordForm.Show();
            /*TabsControl.SelectTab("Record");*/
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
