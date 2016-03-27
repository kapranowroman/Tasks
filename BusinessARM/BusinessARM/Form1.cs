using BusinessARM.DAO;
using BusinessARM.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessARM
{
    public partial class Form1 : Form
    {
        private productDAO dao;
        private List<Product> products;
        private List<Units> units;


        public Form1()
        {
            InitializeComponent();
            dao = new productDAO();
            units = new List<Units>();
            units.Add(Units.BOTTLE_033);
            units.Add(Units.BOTTLE_05);
            units.Add(Units.BOX);
            units.Add(Units.CRATE);
            units.Add(Units.GLASS_POT);
            units.Add(Units.PACK);
            units.Add(Units.PACKING);
            units.Add(Units.TIN_POT); 
            units.Add(Units.UNIT);
            cmbUnit.DataSource = units;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //products = dao.getList();

            try
            {
                products = dao.getList();
                listBox1.DataSource = products;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Product p = (Product)listBox1.SelectedItem;
            txtBoxDescription.Text = p.description.ToString();
            txtBoxGuid.Text = p.id.ToString();
            txtBoxMoney.Text = p.money.ToString();
            txtBoxQuantity.Text = p.quantity.ToString();
            cmbUnit.SelectedItem = p.Unit;
        }
    }
}
