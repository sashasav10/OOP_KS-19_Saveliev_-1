using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2semLR1_1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form1 obj1 = (Form1)Application.OpenForms["Form1"];
            obj1.Hide();
            Form2 obj2 = (Form2)Application.OpenForms["Form2"];
            obj2.Close();
        }
    }
}
