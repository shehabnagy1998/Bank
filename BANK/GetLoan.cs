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
    public partial class GetLoan : Form
    {
        public GetLoan()
        {
            InitializeComponent();
        }

        string date;
        DB db;

        private void retu_Click(object sender, EventArgs e)
        {
            Loans l = new Loans();
            l.Show();
            this.Hide();
        }

        private void date_picker_ValueChanged(object sender, EventArgs e)
        {
            date = $"{date_picker.Value.Year.ToString()}-{date_picker.Value.Month.ToString()}-{date_picker.Value.Day.ToString()}";
        }

        private void GetLoan_Load(object sender, EventArgs e)
        {
            type_combo.SelectedIndex = 0;
            branch_combo.SelectedIndex = 0;
            date = $"{date_picker.Value.Year.ToString()}-{date_picker.Value.Month.ToString()}-{date_picker.Value.Day.ToString()}";
        }

        private void get_Click(object sender, EventArgs e)
        {
            bool yes = true;
            foreach (var item in info_groupbox.Controls)
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
                MessageBox.Show("Some fields are Empty", "Failed");
            else
            {
                if (cid_txt.Text.Length != 14)
                    MessageBox.Show("Client National ID wrong, must be 14 digit", "Failed");
                else
                {
                    db = new DB(cid_txt.Text, type_combo.Text, amount_txt.Text, date, branch_combo.Text);
                    if (db.Find(cid_txt.Text) == false)
                        MessageBox.Show("no client with this National ID", "failed");
                    else
                    {
                        db.getLoan();
                    }
                }
            }
        }

        private void GetLoan_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
