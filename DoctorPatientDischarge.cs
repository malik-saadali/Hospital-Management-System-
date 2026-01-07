using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hospital_Management_System
{
    public partial class DoctorPatientDischarge : Form
    {
        public DoctorPatientDischarge()
        {
            InitializeComponent();
        }
        public string TextBox1Text
        {
            set { this.textBox.Text = value; }
            get { return this.textBox.Text; }
        }
        private void back_btn_Click(object sender, EventArgs e)
        {
            Doctor d = new Doctor();
            d.Show();
            this.Hide();
        }

        private void discharge_btn_Click(object sender, EventArgs e)
        {
            string searchText = textBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(searchText))
            {
                MessageBox.Show("Please enter a term.", "Empty Search", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            User.u.PatientDischarge(textBox.Text);           
            string id = User.u.getID(Login.l.Useridtxtbox);
            dataGridView1.DataSource = User.u.getDoctorPatientList(id);
            MessageBox.Show("Patient Discharged By Doctor");
            textBox.Text = string.Empty;
        }

        private void DoctorPatientDischarge_Load(object sender, EventArgs e)
        {
            string id = User.u.getID(Login.l.Useridtxtbox);
            dataGridView1.DataSource = User.u.getDoctorPatientList(id);
        }
    }
}
