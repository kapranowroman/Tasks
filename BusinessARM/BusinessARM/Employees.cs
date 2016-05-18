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
    public partial class Employees : Form
    {
        private EmployeeDAO dao;
        private List<Employee> employees;
        
        public Employees()
        {
            InitializeComponent();
            dao = new EmployeeDAO();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Employee emp = (Employee)listBox1.SelectedItem;
            txtID.Text = emp.EmployeeId.ToString();
            txtLastName.Text = emp.LastName.ToString();
            txtFirstName.Text = emp.FirstName.ToString();
            txtFatherName.Text = emp.FatherName.ToString();
            txtGender.Text = emp.Gender.ToString();
            checkMarriage.Checked = emp.Marriage;
            txtPostalIndex.Text = emp.PostalIndex.ToString();
            txtPosition.Text = emp.Position.ToString();
            txtHireType.Text = emp.HireType.ToString();
            txtNotes.Text = emp.Notes.ToString();
            dtpBirthDate.Value = emp.BirthDate;
        }

        private void Employees_Load(object sender, EventArgs e)
        {
            try
            {
                employees = dao.getList();
                listBox1.DataSource = employees;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
