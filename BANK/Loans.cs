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
    public partial class Loans : Form
    {
        public Loans()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Starting st = new Starting();
            st.Show();
            this.Hide();
        }

        private void transfare_Click(object sender, EventArgs e)
        {
            GetLoan gl = new GetLoan();
            gl.Show();
            this.Hide();
        }

        private void check_Click(object sender, EventArgs e)
        {
            viewLoan vl = new viewLoan();
            vl.Show();
            this.Hide();
        }
    }
}
