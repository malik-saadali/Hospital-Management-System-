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
    public partial class DoctorPatientList : Form
    {
        public DoctorPatientList()
        {
            InitializeComponent();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Doctor d = new Doctor();
            d.Show();
            this.Hide();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            Login.l.ClearTextBoxes();
            Login.l.Show();
            this.Hide();
        }

        private void DoctorPatientList_Load(object sender, EventArgs e)
        {
            
            string id = User.u.getID(Login.l.Useridtxtbox);
            dataGridView1.DataSource = User.u.getDoctorPatientList(id);
            
        }
    }
}
