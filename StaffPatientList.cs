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
    public partial class StaffPatientList : Form
    {
        public static StaffPatientList spl;
        public StaffPatientList()
        {
            InitializeComponent();
            spl = this;
        }
        public string TextBox1Text
        {
            set { this.textBox1.Text = value; }
            get { return this.textBox1.Text; }
        }
        public void PrepareForDisplay()
        {
            ClearSearchBox();
        }
        public void ClearSearchBox()
        {
            textBox1.Text = string.Empty;
        }
        private void StaffPatientList_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = User.u.getPatientList();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Staff s1 = new Staff();
            s1.Show();
            this.Hide();
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            EditPatient ep = new EditPatient();
            ep.Show();
            this.Hide();
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            string searchText = textBox1.Text.Trim();

            if (string.IsNullOrWhiteSpace(searchText))
            {
                MessageBox.Show("Please enter a search term.", "Empty Search", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            StaffPatientSearch sps = new StaffPatientSearch();
            sps.Show();
            this.Hide();         
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            Login.l.ClearTextBoxes();
            Login.l.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
