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
    public partial class AdminPatientList : Form
    {
        public static AdminPatientList apl;
        public AdminPatientList()
        {
            apl = this;
            InitializeComponent();
        }
        public void PrepareForDisplay()
        {
            ClearSearchBox();
        }
        public void ClearSearchBox()
        {
            search_txtbox.Text = string.Empty;
        }

        public string Searchtxtbox
        {

            set { this.search_txtbox.Text = value; }
            get { return this.search_txtbox.Text; }
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
           
            DataTable searchResults = User.u.searchUser(Searchtxtbox);

            if (searchResults != null)
            {
                AdminPatientSearch aps = new AdminPatientSearch();
                aps.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("No match found.", "Search Resultbtn", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Admin a = new Admin();
            a.Show();
            this.Hide();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            Login.l.ClearTextBoxes();
            Login.l.Show();
            this.Hide();
        }

        private void search_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AdminPatientList_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = User.u.getPatientList();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
