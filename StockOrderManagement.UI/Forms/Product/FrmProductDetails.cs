using StockOrderManagement.BusinessLayer;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StockOrderManagement.UI.Forms.Product
{
    public partial class FrmProductDetails : Form
    {
        public FrmProductDetails()
        {
            InitializeComponent();
        }

        int ListviewID = 0;

        public FrmProductDetails(int ListviewID) : this()
        {
            this.ListviewID = ListviewID;
        }

        private void FrmProductDetails_Load(object sender, EventArgs e)
        {
            SqlDataReader ProductDetails = ProductRepository.ProductDetails(ListviewID);

            while (ProductDetails.Read())
            {
                lbl_ProductID.Text = ProductDetails[0].ToString();
                lbl_ProductName.Text = ProductDetails[1].ToString();
                lbl_QuantityPerUnit.Text = ProductDetails[4].ToString();
                lbl_ReOrderLevel.Text = ProductDetails[8].ToString();
            }
        }
    }
}
