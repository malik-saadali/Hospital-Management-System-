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
    public partial class Doctor : Form
    {
        public Doctor()
        {
            InitializeComponent();
        }

        private void profile_btn_Click(object sender, EventArgs e)
        {
            DoctorProfile dp = new DoctorProfile();
            dp.Show();
            this.Hide();
        }

        private void prescriptionform_btn_Click(object sender, EventArgs e)
        {
            PrescriptionForm pf = new PrescriptionForm();
            pf.Show();
            this.Hide();
        }

        private void patientdischarge_btn_Click(object sender, EventArgs e)
        {
            DoctorPatientDischarge dpd = new DoctorPatientDischarge();
            dpd.Show();
            this.Hide();
        }

        private void patientlist_btn_Click(object sender, EventArgs e)
        {
            DoctorPatientList pl = new DoctorPatientList();
            pl.Show();
            this.Hide();
        }

        private void Doctor_Load(object sender, EventArgs e)
        {
            ln_label.Text = Convert.ToString(User.u.getLastName(Login.l.Useridtxtbox));
            fn_label.Text = Convert.ToString(User.u.getFirstName(Login.l.Useridtxtbox));
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            Login.l.ClearTextBoxes();
            Login.l.Show();
            this.Hide();
        }
    }
}
