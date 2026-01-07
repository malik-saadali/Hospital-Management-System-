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
    public partial class StaffSearch : Form
    {
        public StaffSearch()
        {
            InitializeComponent();
        }
        
        private void StaffSearch_Load(object sender, EventArgs e)
        {
           dataGridView1.DataSource = User.u.searchUser(StaffManagement.sm.Searchtxtbox);
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            StaffManagement.sm.PrepareForDisplay();
            StaffManagement.sm.Show();
            this.Hide();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            Login.l.ClearTextBoxes();
            StaffManagement.sm.PrepareForDisplay();
            Login.l.Show();
            this.Hide();
        }
    }
}
