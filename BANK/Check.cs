using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BANK
{
    public partial class Check : Form
    {
        public Check()
        {
            InitializeComponent();
        }

        private void retu_Click(object sender, EventArgs e)
        {
            Edit st = new Edit();
            st.Show();
            this.Hide();
        }
        private void numberonly(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                check_1.PerformClick();
            }
        }
        private void numbersonly(object sender, KeyPressEventArgs e)
        {
            //e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                Console.Beep();
                e.Handled = true;
            }
        }

        private void Check_FormClosing(object sender, FormClosingEventArgs e)
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

        private void check_1_Click(object sender, EventArgs e)
        {
            if (natid_txt.Text != "")
            {
                DB db = new DB(natid_txt.Text);
                if (db.Find(natid_txt.Text))
                {
                    string[] client =db.KnowInfo();
                    first_txt.Text = client[0];
                    last_txt.Text = client[1];
                    phone_txt.Text = client[2];
                    bal_txt.Text = client[3];
                }
                else
                {
                    MessageBox.Show("No clients with this national ID", "Failed");
                }
            }
            else
            {
                MessageBox.Show("Wrong national ID number", "Failed");
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void phone_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Check_Load(object sender, EventArgs e)
        {

        }
    }
}
