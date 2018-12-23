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
    public partial class Supervisor : Form
    {
        public Supervisor()
        {
            InitializeComponent();
        }
        DB db;
        private void Supervisor_Load(object sender, EventArgs e)
        {
            db = new DB();
            number_txt.Text = db.count("MgrID","employee");
        }

        private void create_Click(object sender, EventArgs e)
        {
            if (emoid_txt.Text != "")
            {
                string[] emp = db.KnowEmpInfo(emoid_txt.Text);
                if (emp[0] != null)
                {
                    first_txt.Text = emp[0];
                    last_txt.Text = emp[1];
                    gender_txt.Text = emp[2];
                    address_txt.Text = emp[3];
                    branch_txt.Text = emp[4];
                    mgr_txt.Text = emp[5];
                }
                else
                {
                    MessageBox.Show("No employee with this ID", "Failed");
                }
            }
            else
            {
                MessageBox.Show("missing employee id field", "Failed");
            }
        }

        private void retu_Click(object sender, EventArgs e)
        {
            Manger lo = new Manger();
            lo.Show();
            this.Hide();
        }

        private void Supervisor_FormClosing(object sender, FormClosingEventArgs e)
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
