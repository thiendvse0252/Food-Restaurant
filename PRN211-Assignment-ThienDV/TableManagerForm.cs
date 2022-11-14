using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using Repository;
using Repository.Models;
using Repository.Service;
using BillDetail = Repository.Models.BillDetail;

namespace PRN211_Assignment_ThienDV {
    public partial class TableManagerForm : Form {

        public static Account acc = new Account();
        CategoryService categoryService = new CategoryService();
        FoodService foodService = new FoodService();
        FoodTableService foodTableService = new FoodTableService();
        BillDetailService billDetailService = new BillDetailService();  

        public TableManagerForm(Account account) {
            acc = account;

            InitializeComponent();

            var listTable = foodTableService.GetAll().ToList();
            dgvTableFood.DataSource = listTable;

            var listCategory = categoryService.GetAll().ToList().Select(p => new { Value = p.Id, Text = p.Name }).ToList();
            cbCategory.ValueMember = "Value";
            cbCategory.DisplayMember = "Text";
            cbCategory.DataSource = (listCategory.ToArray());

            var listFood = foodService.GetAll().ToList().Select(p => new { Value = p.IdCategory, Text = p.FoodName }).ToList();
            cbFood.ValueMember = "Value";
            cbFood.DisplayMember = "Text";
            cbFood.DataSource = (listFood.ToArray());

            var listSwitchTable = foodTableService.GetAll().ToList().Select(p => new { Value = p.Id, Text= p.Name}).ToList();
            cbSwitchTable.ValueMember = "Value";
            cbSwitchTable.DisplayMember = "Text";
            cbSwitchTable.DataSource = (listSwitchTable.ToArray());

        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void personalInfoToolStripMenuItem_Click(object sender, EventArgs e) {
            AccountProfileForm form = new AccountProfileForm(acc);
            form.ShowDialog();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e) {
            AdminForm f = new AdminForm();
            f.ShowDialog();
        }

        private void dgvTableFood_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            lvBill.Items.Clear();

            var tableId = dgvTableFood.Rows[e.RowIndex].Cells[0].Value;
            var obj = foodTableService.GetAll().Where(p => p.Id.Equals(tableId)).FirstOrDefault();
            if (obj != null) {
                //chFoodName.SubItems.Text = "Test data";
                
                //chPrice.Text = "Test data";
                //chTotal.Text = "Test data";
                //chQuantity.Text = "Test data";
            }

            var listCategory = categoryService.GetAll().ToList().Select(p => new { Value = p.Id, Text = p.Name }).ToList();
            cbCategory.ValueMember = "Value";
            cbCategory.DisplayMember = "Text";
            cbCategory.DataSource = (listCategory.ToArray());
            if (e.RowIndex >= 0) {
                //ShowBill();
            }

        }

        private void TableManagerForm_Load(object sender, EventArgs e) {
            
        }

        private void btnSwitchTable_Click(object sender, EventArgs e) {
            //DataGridViewRow temp = dgvTableFood.Rows[Value];
            //dgvTableFood.Rows[Value] = cbSwitchTable.Items;
            //dgvTableFood.Rows[cbSwitchTable.Items] = temp;

            var list = foodTableService.GetAll().Select(p => new { p.Id, p.Name, p.Status }).ToList();
            dgvTableFood.DataSource = list;
        }

        private void btnAddFood_Click(object sender, EventArgs e) {
            ListViewItem lv = new ListViewItem(cbFood.SelectedValue.ToString());
            lv.SubItems.Add("***");
            lv.SubItems.Add("***");
            lv.SubItems.Add(nudFoodCount.Value.ToString());
            lvBill.Items.Add(lv);
        }
    }
}
