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
    public partial class Starting : Form
    {
        public Starting()
        {
            InitializeComponent();
        }

        private void neww_Click(object sender, EventArgs e)
        {
            NEW ne = new NEW();
            ne.Show();
            this.Hide();
        }

        private void Starting_FormClosing(object sender, FormClosingEventArgs e)
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

        private void delete_Click(object sender, EventArgs e)
        {
            Delete de = new Delete();
            de.Show();
            this.Hide();
        }

        private void services_Click(object sender, EventArgs e)
        {
            Loans lo = new Loans();
            lo.Show();
            this.Hide();
        }

        private void edit_Click(object sender, EventArgs e)
        {
            Edit ed = new Edit();
            ed.Show();
            this.Hide();
        }

        private void retu_Click(object sender, EventArgs e)
        {
            LOGIN l = new LOGIN();
            l.Show();
            this.Hide();
        }
    }
}
