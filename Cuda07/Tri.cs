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

        int xD = 1;

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (xD == 1)
            {
                MessageBox.Show("JavaScript - js");
                xD = 0;
            }
            else if (xD == 0)
            {
                MessageBox.Show("PHP - Weeb xd");
                xD = 1;
            }
            

        }
    }
}
