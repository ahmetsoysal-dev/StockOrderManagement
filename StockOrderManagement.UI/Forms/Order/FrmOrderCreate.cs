using StockOrderManagement.BusinessLayer;
using StockOrderManagement.TypeLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockOrderManagement.UI.Forms.Order
{
    public partial class FrmOrderCreate : Form
    {
        public FrmOrderCreate()
        {
            InitializeComponent();
        }

        OrderRepository orderRepository = new OrderRepository();
        EmployeeRepository employeeRepository = new EmployeeRepository();
        ProductRepository productRepository = new ProductRepository();

        private void btn_Save_Click(object sender, EventArgs e)
        {
            orderRepository.EmployeeID = employeeRepository.FindID(cmb_EmployeeID.SelectedItem.ToString());
            orderRepository.ProductID = productRepository.FindID(cmb_ProductID.SelectedItem.ToString());
            orderRepository.Quantity = Convert.ToInt32(nud_Quantity.Value);

            bool answer = orderRepository.Save();
            MessageBox.Show(CommonMessages.CRUD_Message(CommonMessages.Find_TableName(lbl_formName.Text), answer, CrudTypes.Insert));
        }

        public void Fill_Employee_Combobox()
        {
            cmb_EmployeeID.Items.Clear();
            SqlDataReader employeeList = employeeRepository.Select();

            while (employeeList.Read())
            {
                cmb_EmployeeID.Items.Add(employeeList[2] + " " + employeeList[1]);
            }
        }
        public void Fill_Product_Combobox()
        {
            cmb_ProductID.Items.Clear();
            SqlDataReader productList = productRepository.Select();

            while (productList.Read())
            {
                cmb_ProductID.Items.Add(productList[1]);
            }
        }

        private void FrmOrderCreate_Load(object sender, EventArgs e)
        {
            Fill_Employee_Combobox();
            Fill_Product_Combobox();
        }
    }
}
