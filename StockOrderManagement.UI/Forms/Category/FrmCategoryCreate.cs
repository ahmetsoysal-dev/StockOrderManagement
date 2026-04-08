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

namespace StockOrderManagement.UI.Forms.Category
{
    public partial class FrmCategoryCreate : Form
    {
        public FrmCategoryCreate()
        {
            InitializeComponent();
        }

        CategoryRepository categoryRepository = new CategoryRepository();

        private void btn_Save_Click(object sender, EventArgs e)
        {
            //kullanıcıdan aldığımız kategori adını property ye gönderdik
            categoryRepository.CategoryName = txt_CategoryName.Text;

            // save metodunu tetikledik
            bool answer = categoryRepository.Save();
            MessageBox.Show(CommonMessages.CRUD_Message(CommonMessages.Find_TableName(lbl_formName.Text), answer, CrudTypes.Insert));
        }

        private void FrmCategoryCreate_Load(object sender, EventArgs e)
        {
            btn_Save.Visible = false;
            lbl_info.Text = CommonMessages.Info;
        }

        private void txt_CategoryName_TextChanged(object sender, EventArgs e)
        {
            if (txt_CategoryName.Text.Length > 0)
            {
                btn_Save.Visible = true;
            }
            else
            {
                btn_Save.Visible = false;
            }
        }
    }
}
