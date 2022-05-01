using System;
using System.Linq;
using System.Windows.Forms;
using BLL;
using NakataniProject.Services;

namespace NakataniProject
{
	public partial class AddRecordForm : Form
	{

        public Guid PatientId { set; private get; }

		public AddRecordForm(IUserService userService)
		{
			InitializeComponent();
			var user = userService.GetUsersByIdAsync(PatientId);
		}

		private void AddRecordForm_Load(object sender, EventArgs e)
		{
			
		}

		private void dotDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			
		}
		
		
	}
}