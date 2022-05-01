using System;
using System.Windows.Forms;
using BLL;
using Models.Dto;

namespace DicomViewerProj
{
	public partial class AddPatientForm : Form
	{
		private readonly IUserService _userService;

		public AddPatientForm(IUserService userService)
		{
			_userService = userService;
			InitializeComponent();

		}

		private async void savePatientBtn_Click(object sender, EventArgs e)
		{
			var result = await _userService.AddUser(new UserDto
			{
				Name = nametb.Text,
				Complaints = Сomplaintstb.Text,
				DOB = DateTime.Parse(DOBtb.Text),
				Sex = sextb.Text
			});

			if (result == 1)
			{
				this.Close();
			}
		}

		private void ValidateSaveBtn(object sender, EventArgs e)
		{
			if (nametb.Text == string.Empty
			    || DOBtb.Text == string.Empty
			    || sextb.Text == string.Empty)
			{
				savePatientBtn.Enabled = false;
			}
			else savePatientBtn.Enabled = true;
		}
	}
}