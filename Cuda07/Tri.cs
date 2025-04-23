using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cuda07
{
    public partial class Tri : Form
    {
        public Tri()
        {
            InitializeComponent();
        }
        private void Tri_Load(object sender, EventArgs e)
        {
            MessageBox.Show("alicegt");
        }

        int xD = 0;

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (xD == 0)
            {
                MessageBox.Show("JavaScript - Js");
                xD = 1;
            }
            else if (xD == 1)
            {
                MessageBox.Show("PHP - Weeb");
                xD = 2;
            }
            else if (xD == 2)
            {
                MessageBox.Show("Python - Py");
                xD = 3;
            }
            else if (xD == 3)
            {
                MessageBox.Show("C# - Csharp");
                xD = 4;
            }
            else if (xD == 4)
            {
                MessageBox.Show("Java - Ja");
                xD = 5;
            }
            else if (xD == 5)
            {
                MessageBox.Show("C++ - Cpp");
                xD = 6;
            }
            else if(xD == 6)
            {
                MessageBox.Show("Cobol - Co");
                xD = 7;
            }
            else if (xD == 7)
            {
                MessageBox.Show("Pascal - Pa");
                xD = 8;
            }
            else if (xD == 8)
            {
                MessageBox.Show("Ruby - Ru");
                xD = 0;
            }

        }
    }
}
