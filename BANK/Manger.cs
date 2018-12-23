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
    public partial class Manger : Form
    {
        public Manger()
        {
            InitializeComponent();
        }

        private void check_Click(object sender, EventArgs e)
        {
            Starting st = new Starting();
            st.Show();
            this.Hide();
        }

        private void transfare_Click(object sender, EventArgs e)
        {
            Supervisor s = new Supervisor();
            s.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LOGIN l = new LOGIN();
            l.Show();
            this.Hide();
        }
    }
}
