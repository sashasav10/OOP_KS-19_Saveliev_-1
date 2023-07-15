using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2semLr1Var15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.button1.Size = new Size(200,50);
            this.button2.Size = new Size(200, 50);
            this.button3.Size = new Size(200, 50);
            this.button4.Size = new Size(200, 50);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.button1.Size = new Size(125, 35);
            this.button2.Size = new Size(125, 35);
            this.button3.Size = new Size(125, 35);
            this.button4.Size = new Size(125, 35);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            button1.Location = new Point(400,button1.Location.Y);
            button2.Location = new Point(400, button2.Location.Y);
            button3.Location = new Point(400, button3.Location.Y);
            button4.Location = new Point(400, button4.Location.Y);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            button1.Location = new Point(52, button1.Location.Y);
            button2.Location = new Point(52, button2.Location.Y);
            button3.Location = new Point(52, button3.Location.Y);
            button4.Location = new Point(52, button4.Location.Y);
        }
    }
}
