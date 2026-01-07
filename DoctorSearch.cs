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
    public partial class DoctorSearch : Form
    {
        public DoctorSearch()
        {
            InitializeComponent();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            DoctorManagement.dm.PrepareForDisplay();
            DoctorManagement.dm.Show();
            this.Hide();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            Login.l.ClearTextBoxes();
            Login.l.Show();
            this.Hide();
        }

        private void DoctorSearch_Load(object sender, EventArgs e)
        {
           dataGridView1.DataSource = User.u.searchUser(DoctorManagement.dm.Searchtxtbox);
        }
    }
}
