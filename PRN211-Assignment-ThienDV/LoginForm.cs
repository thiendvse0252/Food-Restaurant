using Microsoft.VisualBasic.ApplicationServices;
using Repository;
using Repository.Models;
using Repository.Service;

namespace PRN211_Assignment_ThienDV {
    public partial class LoginForm : Form {
        public static Account User = new Account();
        AccountService accountService;
        public LoginForm() {
            accountService = new AccountService();
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e) {
            string username = tbUsername.Text;
            string password = tbPassword.Text;
            var _user = accountService.GetAll().Where(o => o.Username.Equals(username) && o.Password.Equals(password)).FirstOrDefault();
            User = _user;
            if (User != null) {
                
                TableManagerForm obj = new TableManagerForm(User);
                obj.ShowDialog();
                this.Hide();
            } else {
                MessageBox.Show("Incorrect Username or Password!", "Login fail", MessageBoxButtons.OK, MessageBoxIcon.Warning);  
            }

        }

        private void btnExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e) {
            if(MessageBox.Show("Do you want to exit?", "Notification", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK) {
                e.Cancel = true;
            }
        }
    }
}