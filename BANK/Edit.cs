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
    public partial class Edit : Form
    {
        public Edit()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Starting st = new Starting();
            st.Show();
            this.Hide();
        }

        private void Edit_FormClosing(object sender, FormClosingEventArgs e)
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

        private void transfare_Click(object sender, EventArgs e)
        {
            Transfering tr = new Transfering();
            tr.Show();
            this.Hide();
        }

        private void check_Click(object sender, EventArgs e)
        {
            Check ch = new Check();
            ch.Show();
            this.Hide();
        }

        private void deposit_Click(object sender, EventArgs e)
        {
            Deposit de = new Deposit();
            de.Show();
            this.Hide();
        }

        private void withdraw_Click(object sender, EventArgs e)
        {
            Withdraw wi = new Withdraw();
            wi.Show();
            this.Hide();
        }
    }
}
