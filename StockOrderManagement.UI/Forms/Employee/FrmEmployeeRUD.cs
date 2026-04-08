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

namespace StockOrderManagement.UI.Forms.Employee
{
    public partial class FrmEmployeeRUD : Form
    {
        public FrmEmployeeRUD()
        {
            InitializeComponent();
        }

        EmployeeRepository employeeRepository = new EmployeeRepository();
        int ListviewID = 0;

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (ListviewID == 0)
            {
                MessageBox.Show(CommonMessages.Dont_Choose_From_List);
            }
            else
            {
                employeeRepository.EmployeeID = ListviewID;
                employeeRepository.EmployeeName = txt_EmployeeName.Text;
                bool result = employeeRepository.Update();

                txt_EmployeeName.Text = "";
                FillListview();
                MessageBox.Show(CommonMessages.CRUD_Message(CommonMessages.Find_TableName(lbl_formName.Text), result, CrudTypes.Update));
            }
        }

        void FillListview()
        {
            lst_EmployeeList.Items.Clear();
            SqlDataReader employeeList = employeeRepository.Select();

            while (employeeList.Read())
            {
                ListViewItem listViewItem = new ListViewItem();

                listViewItem.Text = employeeList[0].ToString();
                listViewItem.SubItems.Add(employeeList[2].ToString() + " " + employeeList[1].ToString());
                lst_EmployeeList.Items.Add(listViewItem);
            }
        }

        private void lst_EmployeeList_Click(object sender, EventArgs e)
        {
            ListviewID = Convert.ToInt32(lst_EmployeeList.FocusedItem.SubItems[0].Text);
            txt_EmployeeName.Text = lst_EmployeeList.FocusedItem.SubItems[1].Text;
        }

        private void FrmEmployeeRUD_Load(object sender, EventArgs e)
        {
            FillListview();
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
                employeeRepository.EmployeeID = ListviewID;
                bool result = employeeRepository.Delete();

                txt_EmployeeName.Text = "";
                FillListview();
                MessageBox.Show(CommonMessages.CRUD_Message(CommonMessages.Find_TableName(lbl_formName.Text), result, CrudTypes.Delete));
            }
        }
    }
}
