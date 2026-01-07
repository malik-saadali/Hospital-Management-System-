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
    public partial class StaffPatientSearch : Form
    {
        public StaffPatientSearch()
        {
            InitializeComponent();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            StaffPatientList.spl.PrepareForDisplay();
            StaffPatientList.spl.Show();
            this.Hide();
        }

        /* private void StaffPatientSearch_Load(object sender, EventArgs e)
         {
             dataGridView1.DataSource = User.u.searchPatient(StaffPatientList.spl.TextBox1Text);
         }*/
        private void StaffPatientSearch_Load(object sender, EventArgs e)
        {
            try
            {
                if (User.u == null)
                {
                    MessageBox.Show("User is not initialized.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }

                if (StaffPatientList.spl == null)
                {
                    MessageBox.Show("StaffPatientList is not initialized.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }

                string searchText = StaffPatientList.spl.TextBox1Text;
                if (string.IsNullOrWhiteSpace(searchText))
                {
                    MessageBox.Show("Search text is empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Close();
                    return;
                }

                DataTable result = User.u.searchPatient(searchText);
                if (result == null)
                {
                    MessageBox.Show("Search returned no results.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    return;
                }

                dataGridView1.DataSource = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            Login.l.ClearTextBoxes();
            Login.l.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
