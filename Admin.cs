using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management_System
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void profile_btn_Click(object sender, EventArgs e)
        {
            AdminProfile ap = new AdminProfile();
            ap.Show();
            this.Hide();
        }

        private void rooms_btn_Click(object sender, EventArgs e)
        {
            Room r = new Room();
            r.Show();
            this.Hide();
        }

        private void patientlist_btn_Click(object sender, EventArgs e)
        {
            AdminPatientList pm = new AdminPatientList();
            pm.Show();
            this.Hide();
        }

        private void staffmanagement_btn_Click(object sender, EventArgs e)
        {
            StaffManagement sm = new StaffManagement();
            sm.Show();
            this.Hide();
        }

        private void doctormanagement_btn_Click(object sender, EventArgs e)
        {
            DoctorManagement dm = new DoctorManagement();
            dm.Show();
            this.Hide();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            Login.l.ClearTextBoxes();
            Login.l.Show();
            this.Hide();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            if (User.u != null)
            {
                d_count.Text = Convert.ToString(User.u.getDoctorCount());
                p_count.Text = Convert.ToString(User.u.getPatientCount());
                s_count.Text = Convert.ToString(User.u.getStaffCount());
                ln_label.Text = Convert.ToString(User.u.getLastName(Login.l.Useridtxtbox));
                fn_label.Text = Convert.ToString(User.u.getFirstName(Login.l.Useridtxtbox));
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void ln_label_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void fn_label_Click(object sender, EventArgs e)
        {

        }
    }
}
