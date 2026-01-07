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
    public partial class Staffprofile : Form
    {
        public Staffprofile()
        {
            InitializeComponent();
        }

        private void Staffprofile_Load(object sender, EventArgs e)
        {
            string key = Login.l.Useridtxtbox;

            this.fn_label.Text = Convert.ToString(User.u.getFirstName(key));
            this.ln_label.Text = Convert.ToString(User.u.getLastName(key));
            this.un_label.Text = key;
            this.gender_label.Text = Convert.ToString(User.u.getGender(key));
            this.age_label.Text = Convert.ToString(User.u.getAge(key));
            this.cp_label.Text = Convert.ToString(User.u.getCellPhone(key));
            this.bg_label.Text = Convert.ToString(User.u.getBloodgroup(key));
            
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Staff s = new Staff();
            s.Show();
            this.Hide();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            Login.l.ClearTextBoxes();
            Login.l.Show();
            this.Hide();
        }
    }
}
