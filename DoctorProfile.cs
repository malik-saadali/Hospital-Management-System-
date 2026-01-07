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
    public partial class DoctorProfile : Form
    {
        public DoctorProfile()
        {
            InitializeComponent();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Doctor d = new Doctor();
            d.Show();
            this.Hide();
        }


        private void DoctorProfile_Load(object sender, EventArgs e)
        {
            string key = Login.l.Useridtxtbox;

            this.firstname_txtbox.Text = Convert.ToString(User.u.getFirstName(key));
            this.lastname_txtbox.Text = Convert.ToString(User.u.getLastName(key));
            this.username_txtbox.Text = key;
            this.gender_txtbox.Text = Convert.ToString(User.u.getGender(key));
            this.age_txtbox.Text = Convert.ToString(User.u.getAge(key));
            this.cellphone_txtbox.Text = Convert.ToString(User.u.getCellPhone(key));
            this.bloodgroup_txtbox.Text = Convert.ToString(User.u.getBloodgroup(key));
            
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            Login.l.ClearTextBoxes();
            Login.l.Show();
            this.Hide();
        }
    }
}
