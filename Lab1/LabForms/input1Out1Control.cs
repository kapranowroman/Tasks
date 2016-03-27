using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabForms
{public delegate Double CalculatorTaskDoublToDouble(Double arg);
    public partial class input1Out1Control : UserControl
    {
        private CalculatorTaskDoublToDouble FunctionTask;
        private String name;
        private String TextInput;
        private String TextRes;
        public String ControlName
        {
            set
            {
                name = value;
                groupBox2.Text = value;
            }
            get
            {
                return name;
            }
        }

        public String ControlTextInput
        {
            set
            {
                TextInput = value;
                lblTextInput.Text = value;
            }
            get
            {
                return TextInput;
            }
        }
        public String ControlTextRes
        {
            set
            {
                TextRes = value;
                lblTextRes.Text = value;
            }
            get
            {
                return TextRes;
            }
        }


        public input1Out1Control()
        {
            InitializeComponent();
        }
        
        public void SetFunction(CalculatorTaskDoublToDouble calc)
        {
        FunctionTask=calc;
        }

        private void btnTask2_Click(object sender, EventArgs e)
        {
            double R;
            double.TryParse(txtTask2.Text, out R);
            //lblTask2.Text = calculator.task2(R).ToString();
            try
            {
                lblTask2.Text = FunctionTask(R).ToString();
            }
            catch (ArgumentException mes)
            {
                MessageBox.Show(mes.Message, "Ошибка!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTask2.Text = "0";
                lblTask2.Text = " ";
            }
        }
    }
}
