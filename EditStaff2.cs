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
    public partial class EditStaff2 : Form
    {
        public EditStaff2()
        {
            InitializeComponent();
        }

        private void EditStaff2_Load(object sender, EventArgs e)
        {
            string key = EditStaff.es.Searchtxtbox;

            id_txtbox.Text = User.u.getID(key);
            firstname_txtbox.Text = User.u.getFirstName(key);
            lastname_txtbox.Text = User.u.getLastName(key);
            username_txtbox.Text = key;
            gender_txtbox.Text = User.u.getGender(key);
            age_txtbox.Text = User.u.getAge(key);
            cellphone_txtbox.Text = User.u.getCellPhone(key);
            bloodgroup_txtbox.Text = User.u.getBloodgroup(key);
            password_txtbox.Text = User.u.getPassword(key);
            type_txtbox.Text = User.u.getType(key);
            
        }

        private void done_btn_Click(object sender, EventArgs e)
        {
            User.u.updateStaff(id_txtbox.Text, firstname_txtbox.Text, lastname_txtbox.Text, username_txtbox.Text, gender_txtbox.Text, age_txtbox.Text, cellphone_txtbox.Text, bloodgroup_txtbox.Text, password_txtbox.Text,type_txtbox.Text);
            StaffManagement sm = new StaffManagement();
            MessageBox.Show("Staff Updated!");
            this.Hide();
            sm.Show();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            Login.l.ClearTextBoxes();
            Login.l.Show();
            this.Hide();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            EditStaff es = new EditStaff();
            es.Show();
            this.Hide();
        }
    }
}
