using StockOrderManagement.BusinessLayer;
using StockOrderManagement.TypeLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StockOrderManagement.UI.Forms.Supplier
{
    public partial class FrmSupplierRUD : Form
    {
        public FrmSupplierRUD()
        {
            InitializeComponent();
        }

        SupplierRepository supplierRepository = new SupplierRepository();
        int ListviewID = 0;

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (ListviewID == 0)
            {
                MessageBox.Show(CommonMessages.Dont_Choose_From_List);
            }
            else
            {
                supplierRepository.SupplierID = ListviewID;
                supplierRepository.CompanyName = txt_SupplierName.Text;

                bool result = supplierRepository.Update();

                Fill_Listview();
                txt_SupplierName.Text = "";
                MessageBox.Show(CommonMessages.CRUD_Message(CommonMessages.Find_TableName(lbl_formName.Text), result, CrudTypes.Update));
            }
        }

        void Fill_Listview()
        {
            lst_SupplierList.Items.Clear();
            SqlDataReader supplierList = supplierRepository.Select();

            while (supplierList.Read())
            {
                ListViewItem listViewItem = new ListViewItem();

                listViewItem.Text = supplierList[0].ToString(); // 1.kolon
                listViewItem.SubItems.Add(supplierList[1].ToString()); // 2.kolon
                lst_SupplierList.Items.Add(listViewItem);
            }
        }

        private void FrmSupplierRUD_Load(object sender, EventArgs e)
        {
            txt_SupplierName.Enabled = false;
            Fill_Listview();
            lbl_info.Text = CommonMessages.Info;
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (ListviewID == 0)
            {
                MessageBox.Show(CommonMessages.Dont_Choose_From_List);
            }
            else
            {
                supplierRepository.SupplierID = ListviewID;

                bool result = supplierRepository.Delete();

                Fill_Listview();
                txt_SupplierName.Text = "";
                MessageBox.Show(CommonMessages.CRUD_Message(CommonMessages.Find_TableName(lbl_formName.Text), result, CrudTypes.Delete));
            }
        }

        private void lst_SupplierList_Click(object sender, EventArgs e)
        {
            txt_SupplierName.Enabled = true;
            ListviewID = Convert.ToInt32(lst_SupplierList.FocusedItem.SubItems[0].Text);
            txt_SupplierName.Text = lst_SupplierList.FocusedItem.SubItems[1].Text;
        }
    }
}
