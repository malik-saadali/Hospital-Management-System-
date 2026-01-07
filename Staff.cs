using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management_System
{
    public partial class Staff : Form
    {
        public Staff()
        {
            InitializeComponent();
        }

        private void Staff_Load(object sender, EventArgs e)
        {
            ln_label.Text = Convert.ToString(User.u.getLastName(Login.l.Useridtxtbox));
            fn_label.Text = Convert.ToString(User.u.getFirstName(Login.l.Passwordtxtbox));
            
        }

        private void profile_btn_Click(object sender, EventArgs e)
        {
            Staffprofile sp = new Staffprofile();
            sp.Show();
            this.Hide();
        }

        private void reg_btn_Click(object sender, EventArgs e)
        {
            RegistrationForm rf = new RegistrationForm();
            rf.Show();
            this.Hide();
        }

        private void list_btn_Click(object sender, EventArgs e)
        {
            StaffPatientList spl = new StaffPatientList();
            spl.Show();
            this.Hide();
        }

        private void discharged_btn_Click(object sender, EventArgs e)
        {
            DischargedPatients dp = new DischargedPatients();
            dp.Show();
            this.Hide();
        }

        private void rooms_btn_Click(object sender, EventArgs e)
        {
            AvailableRooms ar = new AvailableRooms();
            ar.Show();
            this.Hide();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            Login.l.ClearTextBoxes();
            Login.l.Show();
            this.Hide();
        }
    }
}
