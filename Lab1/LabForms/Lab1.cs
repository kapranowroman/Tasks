using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculator;

namespace LabForms
{
    public partial class Lab1 : Form
    {
        lab1Calc calculator = new lab1Calc();
        public Lab1()
        {
            InitializeComponent();
            controlTask1.SetFunction(new CalculatorTaskDoublToDouble(calculator.task1));
            controlTask2.SetFunction(new CalculatorTaskDoublToDouble(calculator.task2));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            
        }      

        private void btnTask3_Click(object sender, EventArgs e)
        {
            double A;
            double H;
            double.TryParse(txtTask3A.Text, out A);
            double.TryParse(txtTask3H.Text, out H);
            //lblTask2.Text = calculator.task2(R).ToString();
            try
            {
                lblTask3S.Text = calculator.task3(A,H).ToString();
            }
            catch (ArgumentException mes)
            {
                MessageBox.Show(mes.Message, "Ошибка!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTask3A.Text = "0";
                txtTask3H.Text = "0";
                lblTask3S.Text = " ";
            }
        }

        private void btnTask2_Click(object sender, EventArgs e)
        {
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void btnTask4_Click(object sender, EventArgs e)
        {
            double R;
            double.TryParse(txtTask4.Text, out R);
            lblTask4X.Text = calculator.task4(R).ToString();
            
        }

        private void btnTask5_Click(object sender, EventArgs e)
        {
            double X;
            double.TryParse(txtTask5R.Text, out X);
            lblTask5.Text = calculator.task5(X).ToString();
        }

        private void btnTask6_Click(object sender, EventArgs e)
        {
            int X1;
            int Y1;
            int X2;
            int Y2;
            int.TryParse(txtTask6X1.Text, out X1);
            int.TryParse(txtTask6Y1.Text, out Y1);
            int.TryParse(txtTask6X2.Text, out X2);
            int.TryParse(txtTask6Y2.Text, out Y2);
            lblTask6.Text = calculator.task6(X1,Y1,X2,Y2).ToString();
        }

        private void btnTask7_Click(object sender, EventArgs e)
        {
            double V1;
            double T1;
            double V2;
            double T2;
            double.TryParse(txtTask7V1.Text, out V1);
            double.TryParse(txtTask7T1.Text, out T1);
            double.TryParse(txtTask7V2.Text, out V2);
            double.TryParse(txtTask7T2.Text, out T2);
            //lblTask2.Text = calculator.task2(R).ToString();
            try
            {
                lblTask7V.Text = calculator.task7(V1,T1,V2,T2)[0].ToString();
                lblTask7T.Text = calculator.task7(V1, T1, V2, T2)[1].ToString();
            }
            catch (ArgumentException mes)
            {
                MessageBox.Show(mes.Message, "Ошибка!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTask7V1.Text = "0";
                txtTask7V2.Text = "0";
                lblTask7V.Text = " ";
                lblTask7T.Text = " ";

            }
        }

        private void btnTask8_Click(object sender, EventArgs e)
        {
            double A;
            double.TryParse(txtTask8A.Text, out A);
            
            try
            {
                lblTask8V.Text = calculator.task8_9(A)[0].ToString();
            }
            catch (ArgumentException mes)
            {
                MessageBox.Show(mes.Message, "Ошибка!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTask8A.Text = "0";
                lblTask8V.Text = " ";
            }
        }

        private void btnTask9_Click(object sender, EventArgs e)
        {
            double A;
            double.TryParse(txtTask9.Text, out A);

            try
            {
                lblTask9S.Text = calculator.task8_9(A)[1].ToString();
            }
            catch (ArgumentException mes)
            {
                MessageBox.Show(mes.Message, "Ошибка!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTask9.Text = "0";
                lblTask9S.Text = " ";
            }
        }

        private void btnTask10_Click(object sender, EventArgs e)
        {
            int X1;
            int Y1;
            int H;
            int W;
            int.TryParse(txtTask10X1.Text, out X1);
            int.TryParse(txtTask10Y1.Text, out Y1);
            int.TryParse(txtTask10H.Text, out H);
            int.TryParse(txtTask10W.Text, out W);
            //lblTask2.Text = calculator.task2(R).ToString();
            try
            {
                lblTask10.Text = calculator.task10(X1, Y1, H, W)[0].ToString() + ';' + calculator.task10(X1, Y1, H, W)[1].ToString();
                
            }
            catch (ArgumentException mes)
            {
                MessageBox.Show(mes.Message, "Ошибка!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTask7V1.Text = "0";
                txtTask7V2.Text = "0";
                lblTask7V.Text = " ";
                lblTask7T.Text = " ";

            }
        }

        private void myControl1_Load(object sender, EventArgs e)
        {

        }
          
    }
}
