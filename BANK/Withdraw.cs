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
    public partial class Withdraw : Form
    {
        public Withdraw()
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
                withd.PerformClick();
            }
        }

        private void retu_Click(object sender, EventArgs e)
        {
            Edit ed = new Edit();
            ed.Show();
            this.Hide();
        }
        double balance = 0;
        private void withd_Click(object sender, EventArgs e)
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
                    MessageBox.Show("Minimum value to withdraw from is 100", "Failed");
                }
                else
                {
                    DB db = new DB(natid_txt.Text);
                    if (db.Find(natid_txt.Text))
                    {
                        balance = db.KnowBalance(natid_txt.Text);
                        if (balance- Convert.ToDouble(amount_txt.Text) >= 100 )
                        {
                            balance -= Convert.ToDouble(amount_txt.Text);
                            db.InsertBalance(balance.ToString(), natid_txt.Text);
                            bal_txt.Text = balance.ToString();
                        }
                        else
                        {
                            MessageBox.Show("your balalnce is not enough", "Failed");
                        }
                    }
                    else
                    {
                        MessageBox.Show("No client with this National ID", "Failed");
                    }
                }
            }
        }

        private void Withdraw_FormClosing(object sender, FormClosingEventArgs e)
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

        private void Withdraw_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
