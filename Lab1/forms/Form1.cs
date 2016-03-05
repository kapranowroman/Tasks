using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using L1;

namespace forms
{
    public partial class Form1 : Form
    {
        lab1Calc calculator = new lab1Calc();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double R;
            double.TryParse(txtR.Text, out R);
            txtResult.Text = calculator.task1(R).ToString();
                        
        }
    }
}
