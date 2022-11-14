namespace PRN211_Assignment_ThienDV {
    partial class TableManagerForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Beef salad with vinegar",
            "60000",
            "120000",
            "2"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "Ostrid Ramen",
            "40000",
            "160000",
            "4"}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "Fried Chicken",
            "36500",
            "36500",
            "1"}, -1);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("");
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personalInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lvBill = new System.Windows.Forms.ListView();
            this.chFoodName = new System.Windows.Forms.ColumnHeader();
            this.chPrice = new System.Windows.Forms.ColumnHeader();
            this.chTotal = new System.Windows.Forms.ColumnHeader();
            this.chQuantity = new System.Windows.Forms.ColumnHeader();
            this.panel4 = new System.Windows.Forms.Panel();
            this.nudFoodCount = new System.Windows.Forms.NumericUpDown();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.cbFood = new System.Windows.Forms.ComboBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
            this.dgvTableFood = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSwitchTable = new System.Windows.Forms.Button();
            this.cbSwitchTable = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFoodCount)).BeginInit();
            this.flpTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableFood)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.accountInformationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1062, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // accountInformationToolStripMenuItem
            // 
            this.accountInformationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personalInfoToolStripMenuItem,
            this.signOutToolStripMenuItem});
            this.accountInformationToolStripMenuItem.Name = "accountInformationToolStripMenuItem";
            this.accountInformationToolStripMenuItem.Size = new System.Drawing.Size(159, 24);
            this.accountInformationToolStripMenuItem.Text = "Account Information";
            // 
            // personalInfoToolStripMenuItem
            // 
            this.personalInfoToolStripMenuItem.Name = "personalInfoToolStripMenuItem";
            this.personalInfoToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.personalInfoToolStripMenuItem.Text = "Personal Info";
            this.personalInfoToolStripMenuItem.Click += new System.EventHandler(this.personalInfoToolStripMenuItem_Click);
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.signOutToolStripMenuItem.Text = "Sign Out";
            this.signOutToolStripMenuItem.Click += new System.EventHandler(this.signOutToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lvBill);
            this.panel2.Location = new System.Drawing.Point(594, 130);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(461, 478);
            this.panel2.TabIndex = 2;
            // 
            // lvBill
            // 
            this.lvBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chFoodName,
            this.chPrice,
            this.chTotal,
            this.chQuantity});
            this.lvBill.GridLines = true;
            this.lvBill.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4});
            this.lvBill.Location = new System.Drawing.Point(3, 3);
            this.lvBill.Name = "lvBill";
            this.lvBill.Size = new System.Drawing.Size(454, 472);
            this.lvBill.TabIndex = 0;
            this.lvBill.UseCompatibleStateImageBehavior = false;
            this.lvBill.View = System.Windows.Forms.View.Details;
            // 
            // chFoodName
            // 
            this.chFoodName.Text = "Food Name";
            this.chFoodName.Width = 180;
            // 
            // chPrice
            // 
            this.chPrice.Text = "Price";
            this.chPrice.Width = 80;
            // 
            // chTotal
            // 
            this.chTotal.Text = "Total";
            this.chTotal.Width = 100;
            // 
            // chQuantity
            // 
            this.chQuantity.Text = "Quantity";
            this.chQuantity.Width = 90;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.nudFoodCount);
            this.panel4.Controls.Add(this.btnAddFood);
            this.panel4.Controls.Add(this.cbFood);
            this.panel4.Controls.Add(this.cbCategory);
            this.panel4.Location = new System.Drawing.Point(594, 34);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(461, 90);
            this.panel4.TabIndex = 4;
            // 
            // nudFoodCount
            // 
            this.nudFoodCount.Location = new System.Drawing.Point(362, 36);
            this.nudFoodCount.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudFoodCount.Name = "nudFoodCount";
            this.nudFoodCount.Size = new System.Drawing.Size(69, 27);
            this.nudFoodCount.TabIndex = 3;
            // 
            // btnAddFood
            // 
            this.btnAddFood.Location = new System.Drawing.Point(245, 15);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(101, 66);
            this.btnAddFood.TabIndex = 2;
            this.btnAddFood.Text = "Add Food";
            this.btnAddFood.UseVisualStyleBackColor = true;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // cbFood
            // 
            this.cbFood.FormattingEnabled = true;
            this.cbFood.Location = new System.Drawing.Point(7, 53);
            this.cbFood.Name = "cbFood";
            this.cbFood.Size = new System.Drawing.Size(232, 28);
            this.cbFood.TabIndex = 1;
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(7, 15);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(232, 28);
            this.cbCategory.TabIndex = 0;
            // 
            // flpTable
            // 
            this.flpTable.AutoScroll = true;
            this.flpTable.Controls.Add(this.dgvTableFood);
            this.flpTable.Location = new System.Drawing.Point(12, 31);
            this.flpTable.Name = "flpTable";
            this.flpTable.Size = new System.Drawing.Size(576, 690);
            this.flpTable.TabIndex = 5;
            // 
            // dgvTableFood
            // 
            this.dgvTableFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTableFood.Location = new System.Drawing.Point(3, 3);
            this.dgvTableFood.Name = "dgvTableFood";
            this.dgvTableFood.RowHeadersWidth = 51;
            this.dgvTableFood.RowTemplate.Height = 29;
            this.dgvTableFood.Size = new System.Drawing.Size(569, 683);
            this.dgvTableFood.TabIndex = 0;
            this.dgvTableFood.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTableFood_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(160, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 101);
            this.button1.TabIndex = 3;
            this.button1.Text = "Check Out";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.btnSwitchTable);
            this.panel3.Controls.Add(this.cbSwitchTable);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Location = new System.Drawing.Point(594, 611);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(461, 107);
            this.panel3.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(323, 76);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(138, 27);
            this.textBox1.TabIndex = 8;
            // 
            // btnSwitchTable
            // 
            this.btnSwitchTable.Location = new System.Drawing.Point(7, 3);
            this.btnSwitchTable.Name = "btnSwitchTable";
            this.btnSwitchTable.Size = new System.Drawing.Size(147, 67);
            this.btnSwitchTable.TabIndex = 7;
            this.btnSwitchTable.Text = "Switch Table";
            this.btnSwitchTable.UseVisualStyleBackColor = true;
            this.btnSwitchTable.Click += new System.EventHandler(this.btnSwitchTable_Click);
            // 
            // cbSwitchTable
            // 
            this.cbSwitchTable.FormattingEnabled = true;
            this.cbSwitchTable.Location = new System.Drawing.Point(7, 76);
            this.cbSwitchTable.Name = "cbSwitchTable";
            this.cbSwitchTable.Size = new System.Drawing.Size(147, 28);
            this.cbSwitchTable.TabIndex = 6;
            // 
            // TableManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 726);
            this.Controls.Add(this.flpTable);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TableManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Food Restaurant";
            this.Load += new System.EventHandler(this.TableManagerForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudFoodCount)).EndInit();
            this.flpTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableFood)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem adminToolStripMenuItem;
        private ToolStripMenuItem accountInformationToolStripMenuItem;
        private ToolStripMenuItem personalInfoToolStripMenuItem;
        private ToolStripMenuItem signOutToolStripMenuItem;
        private Panel panel2;
        private ListView lvBill;
        private Panel panel4;
        private NumericUpDown nudFoodCount;
        private Button btnAddFood;
        private ComboBox cbFood;
        private ComboBox cbCategory;
        private FlowLayoutPanel flpTable;
        private Button button1;
        private Panel panel3;
        private Button btnSwitchTable;
        private ComboBox cbSwitchTable;
        private ColumnHeader chFoodName;
        private ColumnHeader chPrice;
        private DataGridView dgvTableFood;
        private ColumnHeader chQuantity;
        private ColumnHeader chTotal;
        private TextBox textBox1;
    }
}