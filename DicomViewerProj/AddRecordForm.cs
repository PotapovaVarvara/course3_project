using System;
using System.Linq;
using System.Windows.Forms;
using NakataniProject.Services;

namespace NakataniProject
{
	public partial class AddRecordForm : Form
	{
		public AddRecordForm(string PatientId)
		{
			InitializeComponent();
		}

		private void AddRecordForm_Load(object sender, EventArgs e)
		{
			dotDataGrid.Rows.Add(new object[] {  "H1" });
			dotDataGrid.Rows.Add(new object[] {  "H2" });
			dotDataGrid.Rows.Add(new object[] {  "H3" });
			dotDataGrid.Rows.Add(new object[] {  "H4" });
			dotDataGrid.Rows.Add(new object[] {  "H5" });
			dotDataGrid.Rows.Add(new object[] {  "H6" });
			dotDataGrid.Rows.Add(new object[] {  "F1" });
			dotDataGrid.Rows.Add(new object[] {  "F2" });
			dotDataGrid.Rows.Add(new object[] {  "F3" });
			dotDataGrid.Rows.Add(new object[] {  "F4" });
			dotDataGrid.Rows.Add(new object[] {  "F5" });
			dotDataGrid.Rows.Add(new object[] {  "F6" });
		}

		private void dotDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			var currentDot = GetCurrentDotId();
		}
		
		private string GetCurrentDotId()
		{
			var selectedRow = dotDataGrid.Rows[dotDataGrid.SelectedCells[0].RowIndex];
			return Convert.ToString(selectedRow.Cells.GetCellValueFromColumnHeader("Dot"));

		}
		
	}
}