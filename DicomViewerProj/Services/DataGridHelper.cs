using System.Linq;
using System.Windows.Forms;

namespace DicomViewerProj.Services
{
	public static class DataGridHelper
	{
		public static object GetCellValueFromColumnHeader(this DataGridViewCellCollection CellCollection, string HeaderText)
		{
			return CellCollection.Cast<DataGridViewCell>().First(c => c.OwningColumn.HeaderText == HeaderText).Value;            
		}
	}
}