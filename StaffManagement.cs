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
    public partial class StaffManagement : Form
    {
        public static StaffManagement sm;
        public StaffManagement()
        {
            sm = this;
            InitializeComponent();
        }
        public void PrepareForDisplay()
        {
            ClearSearchBox();
        }
        public string Searchtxtbox
        {
            set { this.search_txtbox.Text = value; }
            get { return this.search_txtbox.Text; }
        }
        public void ClearSearchBox()
        {
            search_txtbox.Text = string.Empty;
        }
        private void StaffManagement_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = User.u.getStaffList();
        }
        private void search_btn_Click(object sender, EventArgs e)
        {
            DataTable searchResults = User.u.searchUser(Searchtxtbox);

            if (searchResults != null && searchResults.Rows.Count > 0)
            {
                StaffSearch ss = new StaffSearch();
                ss.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("No match found.", "Search Resultbtn", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            AddStaff asf = new AddStaff();
            asf.Show();
            this.Hide();
        }

        private void remove_btn_Click(object sender, EventArgs e)
        {
            RemoveStaff rs = new RemoveStaff();
            rs.Show();
            this.Hide();

        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            EditStaff es = new EditStaff();
            es.Show();
            this.Hide();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            Login.l.ClearTextBoxes();
            Login.l.Show();
            this.Hide();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Admin a = new Admin();
            a.Show();
            this.Hide();
        }
        public void RefreshDataGridView()
        {
            dataGridView1.DataSource = User.u.getStaffList();
            dataGridView1.Refresh();
        }

    }
}
