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

namespace StockOrderManagement.UI.Forms.Product
{
    public partial class FrmProductCreate : Form
    {
        public FrmProductCreate()
        {
            InitializeComponent();
        }

        ProductRepository productRepository = new ProductRepository();
        CategoryRepository categoryRepository = new CategoryRepository();
        SupplierRepository supplierRepository = new SupplierRepository();

        private void btn_Save_Click(object sender, EventArgs e)
        {
            productRepository.ProductName = txt_productName.Text;
            productRepository.UnitsInStock = Convert.ToInt32(txt_UnitsInStock.Text);
            productRepository.UnitPrice = Convert.ToDecimal(txt_UnitPrice.Text);
            productRepository.CategoryID = categoryRepository.FindID(cmb_CategoryID.SelectedItem.ToString());
            productRepository.SupplierID = supplierRepository.FindID(cmb_SupplierID.SelectedItem.ToString());

            // metodtan dönen sonucu answer değişkenine attım
            bool answer = productRepository.Save();

            CleanProperty();
            MessageBox.Show(CommonMessages.CRUD_Message(CommonMessages.Find_TableName(label1.Text), answer, CrudTypes.Insert));
        }

        void CleanProperty()
        {
            txt_productName.Text = txt_UnitPrice.Text = txt_UnitsInStock.Text = "";
            cmb_CategoryID.SelectedIndex = cmb_SupplierID.SelectedIndex = -1;
        }

        void Fill_Category_Combobox()
        {
            cmb_CategoryID.Items.Clear();
            SqlDataReader categoryList = categoryRepository.Select();

            while (categoryList.Read())
            {
                cmb_CategoryID.Items.Add(categoryList[1]);
            }
        }

        void Fill_Supplier_Combobox()
        {
            cmb_SupplierID.Items.Clear();
            SqlDataReader supplierList = supplierRepository.Select();

            while (supplierList.Read())
            {
                cmb_SupplierID.Items.Add(supplierList[1]);
            }
        }

        private void FrmProductCreate_Load(object sender, EventArgs e)
        {
            Fill_Category_Combobox();
            Fill_Supplier_Combobox();
            lbl_info.Text = CommonMessages.Info;
        }
    }
}
