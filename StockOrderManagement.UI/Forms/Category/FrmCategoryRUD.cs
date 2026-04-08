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

namespace StockOrderManagement.UI.Forms.Category
{
    public partial class FrmCategoryRUD : Form
    {
        public FrmCategoryRUD()
        {
            InitializeComponent();
        }

        CategoryRepository categoryRepository = new CategoryRepository();
        int ListviewID = 0; // global değişken 

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (ListviewID == 0)
            {
                MessageBox.Show(CommonMessages.Dont_Choose_From_List);
            }
            else
            {
                // kullanıcıların girdiği bilgileri property lere gönderdim

                categoryRepository.CategoryID = ListviewID;
                categoryRepository.CategoryName = txt_CategoryName.Text;
                bool result = categoryRepository.Update();

                Fill_Listview();
                txt_CategoryName.Text = "";
                MessageBox.Show(CommonMessages.CRUD_Message(CommonMessages.Find_TableName(lbl_formName.Text), result, CrudTypes.Update));
            }
        }

        void Fill_Listview()
        {
            lst_CategoryList.Items.Clear();
            SqlDataReader categoryList = categoryRepository.Select();

            while (categoryList.Read())
            {
                ListViewItem listViewItem = new ListViewItem();

                listViewItem.Text = categoryList[0].ToString(); // 1.kolon
                listViewItem.SubItems.Add(categoryList[1].ToString()); // 2.kolon
                lst_CategoryList.Items.Add(listViewItem);
            }
        }

        private void lst_CategoryList_Click(object sender, EventArgs e)
        {
            txt_CategoryName.Enabled = true;

            ListviewID = Convert.ToInt32(lst_CategoryList.FocusedItem.SubItems[0].Text);
            txt_CategoryName.Text = lst_CategoryList.FocusedItem.SubItems[1].Text;
        }

        void textbox()
        {
            txt_CategoryName.Enabled = false;
        }

        private void FrmCategoryRUD_Load(object sender, EventArgs e)
        {
            textbox();
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
                categoryRepository.CategoryID = ListviewID;
                bool result = categoryRepository.Delete();

                Fill_Listview();
                txt_CategoryName.Text = "";
                MessageBox.Show(CommonMessages.CRUD_Message(CommonMessages.Find_TableName(lbl_formName.Text), result, CrudTypes.Delete));
            }
        }
    }
}
