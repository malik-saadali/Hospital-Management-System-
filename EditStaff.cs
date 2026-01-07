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
    public partial class EditStaff : Form
    {
        public static EditStaff es;
        public EditStaff()
        {
            es = this;
            InitializeComponent();
        }
        public string Searchtxtbox
        {

            set { this.txtbox.Text = value; }
            get { return this.txtbox.Text.Trim(); }
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            StaffManagement sm = new StaffManagement();
            StaffManagement.sm.PrepareForDisplay();
            sm.Show();
            this.Hide();
        }
      
        private void edit_btn_Click(object sender, EventArgs e)
        {
            string input = Searchtxtbox;

            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show("Please enter a valid Username.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (input.All(char.IsDigit))
            {
                MessageBox.Show("Username cannot consist of only numbers.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }           
            EditStaff2 es2 = new EditStaff2();
            es2.Show();
            this.Hide();           
        }

        private void EditStaff_Load(object sender, EventArgs e)
        {

        }
    }
}
