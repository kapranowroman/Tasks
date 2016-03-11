using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabForms
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnLab1Start_Click(object sender, EventArgs e)
        {
            Lab1 Lab1 = new Lab1();
            Lab1.ShowDialog(); 
        }
    }
}
