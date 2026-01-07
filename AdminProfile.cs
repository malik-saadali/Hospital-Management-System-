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
    public partial class AdminProfile : Form
    {
        public AdminProfile()
        {
            InitializeComponent();
        }

        private void AdminProfile_Load(object sender, EventArgs e)
        {
            if (User.u != null)
            { 
            this.f_label.Text = Convert.ToString(User.u.getFirstName(Login.l.Useridtxtbox));
            this.l_label.Text = Convert.ToString(User.u.getLastName(Login.l.Useridtxtbox));
            this.u_label.Text = Login.l.Useridtxtbox;
            this.g_label.Text = Convert.ToString(User.u.getGender(Login.l.Useridtxtbox));
            this.a_label.Text = Convert.ToString(User.u.getAge(Login.l.Useridtxtbox));
            this.c_label.Text = Convert.ToString(User.u.getCellPhone(Login.l.Useridtxtbox));
            this.b_label.Text = Convert.ToString(User.u.getBloodgroup(Login.l.Useridtxtbox));
            }
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
    }
}
