using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tbA_TextChanged(object sender, EventArgs e)
        {
            _calculate();
        }

        private void tbB_TextChanged(object sender, EventArgs e)
        {
            _calculate();
        }

        private void _calculate()
        {
            int nA = 0;
            int nB = 0;

            if (Int32.TryParse(tbA.Text, out nA) == false || Int32.TryParse(tbB.Text, out nB) == false)
            {
                tbSum.Text = "Cannot calulate";
            }
            else
            {
                tbSum.Text = new Util().Add(nA, nB).ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _calculate();
        }
    }
}
