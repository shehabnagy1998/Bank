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
    public partial class viewLoan : Form
    {
        public viewLoan()
        {
            InitializeComponent();
        }
        DB db;
        private void numberonly(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                Console.Beep();
                e.Handled = true;
            }
        }

        private void get_Click(object sender, EventArgs e)
        {
            if (cid_txt.Text == "")
                MessageBox.Show("missing National ID", "failed");
            else
            {
                if (cid_txt.Text.Length != 14)
                    MessageBox.Show("national id must be 14 chars length", "failed");
                else
                {
                    db = new DB(cid_txt.Text);
                    if (db.Find(cid_txt.Text) == false)
                        MessageBox.Show("no client with this National ID", "failed");
                    else
                    {
                        loans_combo.Items.Clear();
                        loans_combo.Items.AddRange(db.getLoans().ToArray());
                        loans_combo.Enabled = true;
                        loans_combo.SelectedIndex = 0;
                    }
                }
            }
        }

        private void retu_Click(object sender, EventArgs e)
        {
            Loans l = new Loans();
            l.Show();
            this.Hide();
        }

        private void viewLoan_FormClosing(object sender, FormClosingEventArgs e)
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

        private void loans_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] loans = db.knowLoanInfo(loans_combo.SelectedItem.ToString());
            type_txt.Text = loans[0];
            amount_txt.Text = loans[1];
            date_txt.Text = loans[2];
            branch_txt.Text = loans[3];
        }
    }
}
