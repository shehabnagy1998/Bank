using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Globalization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BANK
{
    public partial class LOGIN : Form
    {
        string lang;
        public LOGIN()
        {
            InitializeComponent();
        }

        private void log_Click(object sender, EventArgs e)
        {
            if (user_txt.Text != "" && pass_txt.Text != "")
            {
                DB db = new DB(user_txt.Text, pass_txt.Text);
                bool[] yes = db.LogIn();
                if (yes[0] == true )
                {
                    if (yes[1])
                    {
                        Manger ma = new Manger();
                        ma.Show();
                        this.Hide();
                        return;
                    }
                    Starting st = new Starting();
                    st.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong username or password, Try again", "Failed" );
                }
            }
            else
            {
                if (user_txt.Text == "")
                {
                    MessageBox.Show("Missing username","Failed");
                }
                else
                {
                    MessageBox.Show("Missing password", "Failed");
                }
            }
            Cursor = Cursors.Default;
        }

        private void LOGIN_FormClosing(object sender, FormClosingEventArgs e)
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

        private void LOGIN_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToString("hh:mm tt");
            date.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void pass_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                log.PerformClick();
            }
        }
    }
}
