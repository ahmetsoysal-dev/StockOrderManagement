using StockOrderManagement.BusinessLayer;
using StockOrderManagement.TypeLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockOrderManagement.UI.Forms.Supplier
{
    public partial class FrmSupplierCreate : Form
    {
        public FrmSupplierCreate()
        {
            InitializeComponent();
        }
        SupplierRepository supplierRepository = new SupplierRepository();

        private void btn_Save_Click(object sender, EventArgs e)
        {
            supplierRepository.CompanyName = txt_SupplierName.Text;

            bool answer = supplierRepository.Save();

            txt_SupplierName.Text = "";
            MessageBox.Show(CommonMessages.CRUD_Message(CommonMessages.Find_TableName(lbl_formName.Text), answer, CrudTypes.Insert));
        }

        private void txt_SupplierName_TextChanged(object sender, EventArgs e)
        {
            if (txt_SupplierName.Text.Length > 0)
            {
                btn_Save.Visible = true;
            }
            else
            {
                btn_Save.Visible = false;
            }
        }

        private void FrmSupplierCreate_Load(object sender, EventArgs e)
        {
            btn_Save.Visible = false;
            lbl_info.Text = CommonMessages.Info;
        }
    }
}
