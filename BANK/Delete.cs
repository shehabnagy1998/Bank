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
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
        }

        private void Delete_FormClosing(object sender, FormClosingEventArgs e)
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
            //e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                Console.Beep();
                e.Handled = true;
            }
        }

        private void delete2_Click(object sender, EventArgs e)
        {
            DB db = new DB(natid_txt.Text);
            db.DeleteAccount();
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
                delete2.PerformClick();
            }
        }

        private void Delete_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
