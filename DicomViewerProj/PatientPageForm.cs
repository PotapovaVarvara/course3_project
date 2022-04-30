using BLL;
using System;
using System.Windows.Forms;
namespace NakataniProject
{
    public partial class PatientPageForm : Form
    {

        public Guid PatientId { set; private get; }

        private readonly IUserService _userService;
        public PatientPageForm(IUserService userService)
        {
            InitializeComponent();

            _userService = userService;


        }


        private void PatientPageForm_Load(object sender, EventArgs e)
        {
            var user = _userService.GetUsersById(PatientId);
        }

        private void splitContainer3_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer3_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
