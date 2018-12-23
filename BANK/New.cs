using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace BANK
{
    public partial class NEW : Form
    {
        public NEW()
        {
            InitializeComponent();
        }
        string age="";
        bool yes = true;
        string gender = null;
        //byte[] pic;
        //MemoryStream ms;
      

        private void DOB_picker_ValueChanged(object sender, EventArgs e)
        {
            age = $"{DOB_picker.Value.Year.ToString()}-{DOB_picker.Value.Month.ToString()}-{DOB_picker.Value.Day.ToString()}";
        }

        public void Gender(ref string gend)
        {
            if (MALE.Checked)
            {
                gend = "Male";
            }
            else
            {
                gend = "Female";
            }
        }

        private void create_Click(object sender, EventArgs e)
        {
            Gender(ref gender);
            yes = true;
            foreach (var item in information_group.Controls)
            {
                if (item is TextBox)
                {
                    TextBox tb = item as TextBox;
                    if (tb.Text == "")
                    {
                        yes = false;
                    }
                }
            }
            if (yes == false)
            {
                MessageBox.Show("Some fields are Empty", "Failed");
            }
            else
            {
                if (natid_txt.Text.Length != 14)
                {
                    MessageBox.Show("Client National ID wrong, must be 14 digit", "Failed");
                }
                else if (Convert.ToInt32(bal_txt.Text) < 1000)
                {
                    MessageBox.Show("Client openening balance is low , Minimum opening balance is 1000 ", "Failed");
                }
                else if (Convert.ToInt32(monthly_txt.Text) < 1500)
                {
                    MessageBox.Show("Client monthly payent is low, Minimum payment is 1500 ", "Failed");
                }
                else if (gender == "")
                {
                    MessageBox.Show("choose clients gender", "Failed");
                }
                else
                {
                    DB db = new DB(first_txt.Text, last_txt.Text, job_txt.Text, address_txt.Text, country_txt.Text, social_combo.Text, gender, monthly_txt.Text, natid_txt.Text, phone_txt.Text, bal_txt.Text, age);
                    db.NewAccount();
                    MessageBox.Show("Test");
                }
            }
        }

        private void NEW_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult di = MessageBox.Show("ARE YOU SURE YOU WANT TO EXIT ?", "EXIT", MessageBoxButtons.YesNo);
            if (di == DialogResult.Yes)
            {
                this.Dispose();
                Environment.Exit(0);
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void numbersonly(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                Console.Beep();
                e.Handled = true;
            }
        }

        private void retu_Click(object sender, EventArgs e)
        {
            Starting st = new Starting();
            st.Show();
            this.Hide();
        }

        private void numberonly(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                create.PerformClick();
            }
        }

        private void dropdownspace(object sender, KeyEventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            if (e.KeyData == Keys.Space)
            {
                cb.DroppedDown = true;
            }
        }

        private void dropdownclick(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            cb.DroppedDown = true;
        }

        private void NEW_Load_1(object sender, EventArgs e)
        {
            social_combo.SelectedIndex = 0;
            age = $"{DOB_picker.Value.Year.ToString()}-{DOB_picker.Value.Month.ToString()}-{DOB_picker.Value.Day.ToString()}";
        }

        private void job_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void phone_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void monthly_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void last_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void address_txt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
