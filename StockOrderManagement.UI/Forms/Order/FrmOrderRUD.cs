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
    public partial class FrmOrderRUD : Form
    {
        public FrmOrderRUD()
        {
            InitializeComponent();
        }
        OrderRepository orderRepository =  new OrderRepository();

        private void FrmOrderRUD_Load(object sender, EventArgs e)
        {
            Fill_Listview();
            lbl_info.Text = CommonMessages.Info;
        }

        void Fill_Listview()
        {
            lst_OrderList.Items.Clear();
            SqlDataReader orderList = orderRepository.Select();

            while (orderList.Read())
            {
                ListViewItem listViewItem = new ListViewItem();

                listViewItem.Text = orderList[0].ToString();
                listViewItem.SubItems.Add(orderList[1].ToString());
                listViewItem.SubItems.Add(orderList[2].ToString());
                listViewItem.SubItems.Add(orderList[3].ToString());
                lst_OrderList.Items.Add(listViewItem);
            }
        }
    }
}
