using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Repository.Models;
using Repository.Service;

namespace PRN211_Assignment_ThienDV {
    public partial class AccountProfileForm : Form {
        AccountService accountService = new AccountService();

        public AccountProfileForm(Account account) {
            InitializeComponent();
            var obj = accountService.GetAll().Where(p => p.Username.Equals(account.Username)).FirstOrDefault();
            if (obj != null) {
                tbUsername.Text = obj.Username;
                tbUsername.Enabled = false;
                tbDisplayName.Text = obj.DisplayName;
                tbPassword.Text = obj.Password;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnExit_Click_1(object sender, EventArgs e) {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e) {

            accountService = new AccountService();
            var Account = new Account();
            Account.Username = tbUsername.Text;
            
            if(tbNewPassword.Text == tbConfirm.Text && !tbNewPassword.Text.Equals("") && !tbDisplayName.Text.Equals("") && !tbPassword.Text.Equals("")) {
                Account.DisplayName = tbDisplayName.Text;
                Account.Password = tbNewPassword.Text;
                accountService.Update(Account);
                MessageBox.Show("Done");
            } else {
                MessageBox.Show("Please fulfil the inputs!");
                return;
            }
            
        }
    }
}
