using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Repository;
using Repository.Models;
using Repository.Service;

namespace PRN211_Assignment_ThienDV {
    public partial class AdminForm : Form {
        FoodService foodService = new FoodService();
        CategoryService categoryService = new CategoryService();
        AccountService accountService = new AccountService();
        FoodTableService foodTableService = new FoodTableService();

        public static Account _User = LoginForm.User;
        public AdminForm() {
            InitializeComponent();
            var listCategory = categoryService.GetAll().ToList().Select(p => new { Value = p.Id, Text = p.Id }).ToList();
            cbCategory.ValueMember = "Value";
            cbCategory.DisplayMember = "Text";
            cbCategory.DataSource = (listCategory.ToArray());
        }

        private void dgvFood_CellContentClick(object sender, DataGridViewCellEventArgs e) {


            var rowSelected = this.dgvFood.Rows[e.RowIndex];

            if (e.RowIndex >= 0) {
                nudFoodId.Enabled = false;
                nudFoodId.Value = Convert.ToInt32( rowSelected.Cells["FoodId"].Value.ToString());
                tbFoodName.Text = rowSelected.Cells["FoodName"].Value.ToString();
                cbCategory.Text = rowSelected.Cells["IdCategory"].Value.ToString();
                nudFoodPrice.Value = (decimal)Convert.ToDouble(rowSelected.Cells["Price"].Value.ToString());

            }
            btnAddFood.Enabled = false;
            btnDeleteFood.Enabled = true;
            btnUpdateFood.Enabled = true;
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e) {
            var Id = tbUsername.Text;
            var obj = accountService.GetAll().Where(p => p.Username.Equals(Id)).FirstOrDefault();
            accountService = new AccountService();
            var dialog = MessageBox.Show("Do you want to delete it?", "Warning", MessageBoxButtons.OKCancel);
            if (dialog == DialogResult.OK) {
                accountService.Delete(obj);
                MessageBox.Show("Done");
            } else {
                MessageBox.Show("Delete Account Failed!");
                return;
            }

        }

        private void dgvAccount_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            var rowSelected = this.dgvAccount.Rows[e.RowIndex];

            if (e.RowIndex >= 0) {
                tbUsername.Enabled = false;
                tbUsername.Text = rowSelected.Cells["Username"].Value.ToString();
                tbAccountName.Text = rowSelected.Cells["DisplayName"].Value.ToString();
                tbPassword.Text = rowSelected.Cells["Password"].Value.ToString();
            }
            btnAddAccount.Enabled = false;
            btnDeleteAccount.Enabled = true;
            btnUpdateAccount.Enabled = true;
        }

        private void btnViewAccount_Click(object sender, EventArgs e) {
            dgvAccount.DataSource = accountService.GetAll().ToList();
        }

        private void btnViewFood_Click(object sender, EventArgs e) {
            dgvFood.DataSource = foodService.GetAll().ToList();
        }

        private void btnViewCategory_Click(object sender, EventArgs e) {
            dgvCategory.DataSource = categoryService.GetAll().ToList();
        }

        private void dgvCategory_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            btnAddCategory.Enabled = true;
            btnUpdateCategory.Enabled = false;

            var Id = dgvCategory.Rows[e.RowIndex].Cells[0].Value;
            var obj = categoryService.GetAll().Where(p => p.Id.Equals(Id)).FirstOrDefault();
            if (obj != null) {
                nudCateID.Value = obj.Id;
                nudCateID.Enabled = false;
                tbCategoryName.Text = obj.Name;
            }
            btnAddCategory.Enabled = false;
            btnUpdateCategory.Enabled = true;
        }

        private void dgvTable_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            var rowSelected = this.dgvTable.Rows[e.RowIndex];

            if (e.RowIndex >= 0) {
                nudTable.Enabled = false;
                nudTable.Text = rowSelected.Cells["Id"].Value.ToString();
                tbTableName.Text = rowSelected.Cells["Name"].Value.ToString();
                cbTableStatus.Text = rowSelected.Cells["Status"].Value.ToString();

            }
            btnAddTable.Enabled = false;
            btnUpdateTable.Enabled = true;
        }

        private void btnViewTable_Click(object sender, EventArgs e) {
            dgvTable.DataSource = foodTableService.GetAll().ToList();
        }

        private void btnSearchFood_Click(object sender, EventArgs e) {
            var list = foodService.GetAll().Where(p => p.FoodName.ToLower().Contains(tbSearchFood.Text.ToLower())).OrderBy(p => p.FoodName)
                .Select(p => new { p.FoodId, p.FoodName, p.IdCategory, p.Price }).ToList();

            dgvFood.DataSource = list;
        }

        private void btnAddFood_Click(object sender, EventArgs e) {
            if (nudFoodId.Text == "" || tbFoodName.Text == "" || cbCategory.SelectedValue == "" ) {
                MessageBox.Show("All Input is not Null, please try again", "Notification", MessageBoxButtons.OK);
                return;
            } else {
                btnAddAccount.Enabled = true;

                var Id = nudFoodId.Value;
                var CheckId = foodService.GetAll().Where(p => p.FoodId.Equals(Id)).FirstOrDefault();

                if (CheckId != null) {
                    MessageBox.Show("Duplicate Id, Please try another Id", "Error", MessageBoxButtons.OK);
                    btnAddAccount.Enabled = true;
                    return;
                }
                var _food = new Food();
                _food.FoodId = (int)Id;
                _food.FoodName = tbFoodName.Text;
                _food.IdCategory = (int)cbCategory.SelectedValue;
                _food.Price = (double)nudFoodPrice.Value;
                //using (var transaction = db.Database.BeginTransaction()) {
                //    db.Database.ExecuteSqlRaw("SET IDENTITY_INSERT [dbo].[Food] ON");
                //    db.SaveChanges();
                //    db.Database.ExecuteSqlRaw("SET IDENTITY_INSERT [dbo].[Food] OFF");
                //    transaction.Commit();
                //}
                foodService.Create(_food);
                var listFood = foodService.GetAll().ToList();
                dgvFood.DataSource = listFood;
                btnAddFood.Enabled = true;

                nudFoodId.Value = 0;
                tbFoodName.Text = "";
                cbCategory.SelectedIndex = 0;
                nudFoodPrice.Value = 0;

                btnAddAccount.Enabled = true;
                btnUpdateFood.Enabled = false;
                btnDeleteFood.Enabled = false;
            }
        }

        private void btnDeleteFood_Click(object sender, EventArgs e) {
            var Id = (int)nudFoodId.Value;
            var obj = foodService.GetAll().Where(p => p.FoodId.Equals(Id)).FirstOrDefault();
            foodService = new FoodService();
            var dialog = MessageBox.Show("Do you want to delete it?", "Warning", MessageBoxButtons.OKCancel);
            if (dialog == DialogResult.OK) {
                foodService.Delete(obj);
                MessageBox.Show("Done");
            } else {
                return;
            }
        }

        private void btnUpdateFood_Click(object sender, EventArgs e) {
            if (!Validation()) {
                return;
            }
            foodService = new FoodService();
            var food = new Food();
            food.FoodId = (int)nudFoodId.Value;
            food.FoodName = tbFoodName.Text;
            food.IdCategory = (int)cbCategory.SelectedValue;
            food.Price = (double)nudFoodPrice.Value;
            foodService.Update(food);

            var list = foodService.GetAll().Select(p => new { p.FoodId, p.FoodName, p.IdCategory, p.Price }).ToList();
            dgvFood.DataSource = list;
        }
        public bool Validation() {
            var foodName = tbFoodName.Text;
            string pattern = @"^(?!.{21})[A-Z][a-z]{2,}(\s[A-Z][a-z]{2,})*$";
            if (!(new Regex(pattern)).Match(foodName).Success) {
                MessageBox.Show("Please Capital First letter of each word!", "", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e) {
            var Id = (int)nudCateID.Value;
            var obj = categoryService.GetAll().Where(p => p.Id.Equals(Id)).FirstOrDefault();
            categoryService = new CategoryService();
            var dialog = MessageBox.Show("Do you want to delete it?", "Warning", MessageBoxButtons.OKCancel);
            if (dialog == DialogResult.OK) {
                categoryService.Delete(obj);
            } else {
                return;
            }
        }

        private void btnUpdateCategory_Click(object sender, EventArgs e) {
            categoryService = new CategoryService();
            var category = new FoodCategory();
            category.Id = (int)nudCateID.Value;
            category.Name = tbCategoryName.Text;
            categoryService.Update(category);
            MessageBox.Show("Done");

            var list = categoryService.GetAll().Select(p => new { p.Id, p.Name }).ToList();
            dgvCategory.DataSource = list;
        }

        private void btnDeleteTable_Click(object sender, EventArgs e) {
            var Id = (int)nudTable.Value;
            var obj = foodTableService.GetAll().Where(p => p.Id.Equals(Id)).FirstOrDefault();
            foodTableService = new FoodTableService();
            var dialog = MessageBox.Show("Do you want to delete it?", "Warning", MessageBoxButtons.OKCancel);
            if (dialog == DialogResult.OK) {
                foodTableService.Delete(obj);
                MessageBox.Show("Done");
            } else {
                return;
            }
        }

        private void btnUpdateTable_Click(object sender, EventArgs e) {
            foodTableService = new FoodTableService();
            var table = new FoodTable();
            table.Id = (int)nudTable.Value;
            table.Name = tbTableName.Text;
            table.Status = cbTableStatus.Text;
            foodTableService.Update(table);
            MessageBox.Show("Done");

            var list = foodTableService.GetAll().Select(p => new { p.Id, p.Name, p.Status }).ToList();
            dgvTable.DataSource = list;
        }

        private void btnUpdateAccount_Click(object sender, EventArgs e) {
            accountService = new AccountService();
            var account = new Account();
            account.Username = tbUsername.Text;
            account.DisplayName = tbAccountName.Text;
            account.Password = tbPassword.Text;
            accountService.Update(account);

            var list = accountService.GetAll().Select(p => new { p.Username, p.DisplayName, p.Password, p.Type }).ToList();
            dgvAccount.DataSource = list;
        }

        private void btnAddAccount_Click(object sender, EventArgs e) {
            var account = new Account();
            accountService = new AccountService();
            account.Username = tbUsername.Text;
            if (accountService.GetAll().Where(p => p.Username.Equals(account.Username)).FirstOrDefault() != null) {
                MessageBox.Show("Username Existed ", "hello", MessageBoxButtons.OK);
                return;
            }
            if (tbUsername.Text != "" && tbAccountName.Text != null && tbPassword.Text != null) {
                account.DisplayName = tbAccountName.Text;
                account.Password = tbPassword.Text;
                accountService.Create(account);
            } else {
                MessageBox.Show("Please fulfil the inputs!");
                return;
            }
            
        }

        private void btnAddCategory_Click(object sender, EventArgs e) {

        }
    }
}
