using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox55_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox68_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        { 
       
        }

        

        private void BTN_START_Click(object sender, EventArgs e)
        {
            
        }

        private void j(object sender, EventArgs e)
        {
           
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Up)
            {
                pictureBox17.Location = new Point(pictureBox17.Location.X, pictureBox17.Location.Y - 10);

            }
           else if (e.KeyData == Keys.Down)
            {
                pictureBox17.Location = new Point(pictureBox17.Location.X, pictureBox17.Location.Y + 10);
            }
            else if (e.KeyData == Keys.Right) 
            {
                pictureBox17.Location = new Point(pictureBox17.Location.X +10, pictureBox17.Location.Y );

            }
          if (e.KeyData == Keys.Left) 
            {
                pictureBox17.Location = new Point(pictureBox17.Location.X- 10, pictureBox17.Location.Y);

            }
        }
    }
}
