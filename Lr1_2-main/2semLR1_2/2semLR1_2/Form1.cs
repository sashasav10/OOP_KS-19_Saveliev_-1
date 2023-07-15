using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2semLR1_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            List<Label> lst = new List<Label>();
            foreach (Control obj in this.Controls)
            {
                if (obj is Label)
                {
                    lst.Add((Label)obj);
                }

            }
            foreach (Label uc in lst)
            {
                this.Controls.Remove(uc);

            }
        }
    }
}
