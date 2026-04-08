using StockOrderManagement.UI.Forms.Category;
using StockOrderManagement.UI.Forms.Employee;
using StockOrderManagement.UI.Forms.Order;
using StockOrderManagement.UI.Forms.Product;
using StockOrderManagement.UI.Forms.Supplier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockOrderManagement.UI.Forms
{
    public partial class FrmMenus : Form
    {
        public FrmMenus()
        {
            InitializeComponent();
        }

        private void gİRİŞFORMUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCategoryCreate frmCategoryCreate = new FrmCategoryCreate();
            frmCategoryCreate.ShowDialog();
        }

        private void lİSTELEGÜNCELLESİLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCategoryRUD frmCategoryRUD = new FrmCategoryRUD();
            frmCategoryRUD.ShowDialog();
        }

        private void gİRİŞFORMUToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmSupplierCreate frmSupplierCreate = new FrmSupplierCreate();
            frmSupplierCreate.ShowDialog();
        }

        private void lİSTELEGÜNCELLESİLToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            FrmSupplierRUD frmSupplierRUD = new FrmSupplierRUD();
            frmSupplierRUD.ShowDialog();
        }

        private void gİRİŞFORMUToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmProductCreate frmProductCreate = new FrmProductCreate();
            frmProductCreate.ShowDialog();
        }

        private void lİSTELEGÜNCELLESİLToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmProductRUD frmProductRUD = new FrmProductRUD();
            frmProductRUD.ShowDialog();
        }

        private void gİRİŞFORMUToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FrmEmployeeCreate frmEmployeeCreate = new FrmEmployeeCreate();
            frmEmployeeCreate.ShowDialog();
        }

        private void lİSTELEGÜNCELLESİLToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FrmEmployeeRUD frmEmployeeRUD = new FrmEmployeeRUD();
            frmEmployeeRUD.ShowDialog();
        }

        private void gİRİŞFORMUToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            FrmOrderCreate frmOrderCreate = new FrmOrderCreate();
            frmOrderCreate.ShowDialog();
        }

        private void lİSTELEGÜNCELLESİLToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            FrmOrderRUD frmOrderRUD = new FrmOrderRUD();
            frmOrderRUD.ShowDialog();
        }
    }
}
