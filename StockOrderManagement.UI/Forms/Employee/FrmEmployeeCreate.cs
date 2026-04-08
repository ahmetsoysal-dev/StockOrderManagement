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

namespace StockOrderManagement.UI.Forms.Employee
{
    public partial class FrmEmployeeCreate : Form
    {
        public FrmEmployeeCreate()
        {
            InitializeComponent();
        }
        EmployeeRepository employeeRepository = new EmployeeRepository();

        private void btn_Save_Click(object sender, EventArgs e)
        {
            employeeRepository.EmployeeName = txt_EmployeeName.Text;

            bool answer = employeeRepository.Save();
            txt_EmployeeName.Text = "";
            MessageBox.Show(CommonMessages.CRUD_Message(CommonMessages.Find_TableName(lbl_formName.Text), answer, CrudTypes.Insert));
        }

        private void txt_EmployeeName_TextChanged(object sender, EventArgs e)
        {
            if (txt_EmployeeName.Text.Length > 0)
            {
                btn_Save.Visible = true;
            }
            else
            {
                btn_Save.Visible = false;
            }
        }

        private void FrmEmployeeCreate_Load(object sender, EventArgs e)
        {
            btn_Save.Visible = false;
        }
    }
}
