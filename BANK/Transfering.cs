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
    public partial class Transfering : Form
    {
        public Transfering()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Edit ed = new Edit();
            ed.Show();
            this.Hide();
        }

        private void Transfaring_FormClosing(object sender, FormClosingEventArgs e)
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
        bool yes = true, yes2 = true;

        private void numberonly(object sender, KeyPressEventArgs e)
        {
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
                transfer.PerformClick();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void from_groupbox_Enter(object sender, EventArgs e)
        {

        }

        private void transfer_Click(object sender, EventArgs e)
        {
            yes = true; yes2 = true;
            foreach (var item in from_groupbox.Controls)
            {
                if (item is TextBox)
                {
                    TextBox tb = item as TextBox;
                    if (tb.Text == "")
                    {
                        yes = false;
                        break;
                    }
                }
            }
            if (natid2_txt.Text == "")
            {
                yes2 = false;
            }

            if (yes == true && yes2 == true)
            {
                if (natid_txt.Text.Length != 14)
                {
                    MessageBox.Show("Wrong national ID fromat", "Failed");
                }
                else if (Convert.ToDouble(amount_txt.Text) < 100)
                {
                    MessageBox.Show("Wrong amount, minimum amount 100");
                }
                else if (natid2_txt.Text.Length != 14)
                {
                    MessageBox.Show("Wrong national ID fromat", "Failed");
                }
                else
                {
                    DB db = new DB(natid_txt.Text, natid2_txt.Text, amount_txt.Text);
                    if (!db.Find(natid_txt.Text))
                    {
                        MessageBox.Show("no correct account to transfer from");
                    }
                    else if (!db.Find(natid2_txt.Text))
                    {
                        MessageBox.Show("no correct account to transfer to");
                    }
                    else
                    {
                        double balance1 = db.KnowBalance(natid_txt.Text);
                        double balance2 = db.KnowBalance(natid2_txt.Text);
                        if (balance1 >= Convert.ToDouble(amount_txt.Text))
                        {
                            balance1 -= Convert.ToDouble(amount_txt.Text);
                            balance2 += Convert.ToDouble(amount_txt.Text);
                            db.InsertBalance(balance1.ToString(), natid_txt.Text);
                            db.InsertBalance(balance2.ToString(), natid2_txt.Text);
                            cli1_txt.Text = balance1.ToString();
                            cli2_txt.Text = balance2.ToString();
                            MessageBox.Show("Transfer completed", "Success");
                        }
                        else
                        {
                            MessageBox.Show("there is no enough balance", "Failed");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Some fields are empty", "Failed");
            }
        }
    }
}
