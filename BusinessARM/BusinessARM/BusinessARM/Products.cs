using BusinessARM.DAO;
using BusinessARM.DTO;
using BusinessARM.Presenter;
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
    public partial class Products : Form
    {
        private ProductsPresenter presenter;
        private productDAO productDao;
        private ProductGroupDAO groupDao;

        private List<ProductGroup> Groups;
        private List<Product> products;
        private List<Units> units;
        //private Product current;

        //private FormState state = FormState.UPDATE_OLD ;

        public Products()
        {
            InitializeComponent();
            presenter = new ProductsPresenter(this);
            productDao = new productDAO();
            groupDao = new ProductGroupDAO();
            Groups = new List<ProductGroup>();
            units = new List<Units>();
            units.Add(Units.EMPTY);
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
                presenter.loadProducts();
                //products = productDao.getList();
                //listBox1.DataSource = products;
                Groups = groupDao.getList();
                cmbProductGroupID.DataSource = Groups;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void displayProducts(List<Product> products)
        {
            listBox1.DataSource = products;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            
            //current = (Product)listBox1.SelectedItem; 
            Product p = (Product)listBox1.SelectedItem;
            txtBoxDescription.Text = p.description.ToString();
            txtBoxGuid.Text = p.id.ToString();
            //txtBoxProductGroupID.Text = p.productGroupID.ToString();
            txtBoxWeight.Text = p.weight.ToString();
            txtBoxMoney.Text = p.money.ToString();
            txtBoxQuantity.Text = p.quantity.ToString();
            cmbUnit.SelectedItem = p.Unit;
            cmbProductGroupID.SelectedItem = Groups.Find(g => g.Id == p.productGroupID);
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            Employees empl = new Employees();
            empl.ShowDialog(); 
        }

        public void ClearFields()
        {
            txtBoxDescription.Clear();
            txtBoxGuid.Clear();
            //txtBoxProductGroupID.Clear();
            txtBoxWeight.Clear();
            txtBoxMoney.Clear();
            txtBoxQuantity.Clear();
            cmbUnit.SelectedItem = Units.EMPTY;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            presenter.beginAdd();            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool valid = true;
            Decimal money;
            string description;
            Decimal weight;
            int quantity;
            Guid productGroupID;
            Units unit;
            
            if (!Decimal.TryParse(txtBoxMoney.Text, out money))
            {
                notify("Не правильно введена цена");
                valid=false;
            }
            description=txtBoxDescription.Text;
            if (!Int32.TryParse(txtBoxQuantity.Text, out quantity))
            {
                notify("Не правильно введено количество");
                valid=false;
            }
            if (!Decimal.TryParse(txtBoxWeight.Text, out weight))
            {
                notify("Не правильно введен вес");
                valid=false;
            }
            unit = (Units)cmbUnit.SelectedItem;
            productGroupID = (cmbProductGroupID.SelectedItem as ProductGroup).Id;
            if (valid)
            {
                presenter.save(listBox1.SelectedItem as Product, money, description, weight, quantity, productGroupID, unit);
            }

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            presenter.delete(listBox1.SelectedItem as Product);
        }

        private void btnReLoad_Click(object sender, EventArgs e)
        {
            try
            {

                presenter.loadProducts();
                Groups = groupDao.getList();
                cmbProductGroupID.DataSource = Groups;
                txtFilter.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            presenter.filterWith(txtFilter.Text);
        }
        public void notify(String message)
        {
            MessageBox.Show(message);
        }
    }
}
