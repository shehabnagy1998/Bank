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
    public partial class Deposit : Form
    {
        public Deposit()
        {
            InitializeComponent();
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
        private void numberonly(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                depo.PerformClick();
            }
        }
        private void Deposit_FormClosing(object sender, FormClosingEventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            Edit ed = new Edit();
            ed.Show();
            this.Hide();
        }
        double balance = 0;
        private void depo_Click(object sender, EventArgs e)
        {
            if (natid_txt.Text == "" && amount_txt.Text == "")
            {
                MessageBox.Show("Some fields are Empty", "Failed");
            }
            else
            {
                if (natid_txt.Text.Length != 14)
                {
                    MessageBox.Show("Wrong National ID", "Failed");
                }
                else if (Convert.ToDouble(amount_txt.Text) < 100)
                {
                    MessageBox.Show("Minimum value to Deposit is 100", "Failed");
                }
                else
                {
                    DB db = new DB(natid_txt.Text);
                    if (db.Find(natid_txt.Text))
                    {
                        balance = db.KnowBalance(natid_txt.Text);
                        balance += Convert.ToDouble(amount_txt.Text);
                        db.InsertBalance(balance.ToString(), natid_txt.Text);
                        bal_txt.Text = balance.ToString();
                    }
                    else
                    {
                        MessageBox.Show("No client with this National ID", "Failed");
                    }
                }
            }
        }

        private void amount_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Deposit_Load(object sender, EventArgs e)
        {

        }
    }
}
