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
    public partial class DoctorManagement : Form
    {
        public static DoctorManagement dm;
        public DoctorManagement()
        {
            InitializeComponent();
            dm = this;
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

        private void DoctorManagement_Load(object sender, EventArgs e)
        {
           dataGridView1.DataSource = User.u.getDoctorList();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Admin a = new Admin();
            a.Show();
            this.Hide();
        }

        private void remove_btn_Click(object sender, EventArgs e)
        {
            RemoveDoctor rd = new RemoveDoctor();
            rd.Show();
            this.Hide();
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            EditDoctor ed = new EditDoctor();
            ed.Show();
            this.Hide();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            AddDoctor ad = new AddDoctor();
            ad.Show();
            this.Hide();
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            DataTable searchResults = User.u.searchUser(Searchtxtbox);

            if (searchResults != null && searchResults.Rows.Count > 0)
            {
                DoctorSearch ds = new DoctorSearch();
                ds.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("No match found.", "Search Resultbtn", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            Login.l.ClearTextBoxes();
            Login.l.Show();
            this.Hide();
        }
        
        public void RefreshDataGridView()
        {
            dataGridView1.DataSource = User.u.getDoctorList();
            dataGridView1.Refresh();
        }
    }
}
