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
    public partial class Intro : Form
    {
        public Intro()
        {
            InitializeComponent();
        }

        private void Intro_Load(object sender, EventArgs e)
        {
            //this.Cursor = new Cursor("cursor.cur");
            button1.Cursor = new Cursor("cursor.cur");
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackgroundImage = Image.FromFile("PadLock-open-icon.png");
            
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackgroundImage = Image.FromFile("PadLock-icon.png");
            //this.Cursor = DefaultCursor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SplashScreen sp = new SplashScreen();
            sp.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            
        }
    }
}
