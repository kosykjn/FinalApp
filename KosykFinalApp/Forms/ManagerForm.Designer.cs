namespace KosykFinalApp.Forms
{
    partial class ManagerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.диспетчерПользователейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAddNewCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmRemoveCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.lvProducts = new System.Windows.Forms.ListView();
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbCanceledOrders = new System.Windows.Forms.RadioButton();
            this.rbCompledOrders = new System.Windows.Forms.RadioButton();
            this.rbNewOrders = new System.Windows.Forms.RadioButton();
            this.lvAllOrders = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancelOrder = new System.Windows.Forms.Button();
            this.btnCompleteOrder = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.menuStrip1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.диспетчерПользователейToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(633, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // диспетчерПользователейToolStripMenuItem
            // 
            this.диспетчерПользователейToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAddNewCustomer,
            this.tsmRemoveCustomer});
            this.диспетчерПользователейToolStripMenuItem.Name = "диспетчерПользователейToolStripMenuItem";
            this.диспетчерПользователейToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.диспетчерПользователейToolStripMenuItem.Text = "Пользователи";
            // 
            // tsmAddNewCustomer
            // 
            this.tsmAddNewCustomer.Name = "tsmAddNewCustomer";
            this.tsmAddNewCustomer.Size = new System.Drawing.Size(204, 22);
            this.tsmAddNewCustomer.Text = "Добавить пользователя";
            this.tsmAddNewCustomer.Click += new System.EventHandler(this.tsmAddNewCustomer_Click);
            // 
            // tsmRemoveCustomer
            // 
            this.tsmRemoveCustomer.Name = "tsmRemoveCustomer";
            this.tsmRemoveCustomer.Size = new System.Drawing.Size(204, 22);
            this.tsmRemoveCustomer.Text = "Удалить пользователя";
            this.tsmRemoveCustomer.Click += new System.EventHandler(this.tsmRemoveCustomer_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnAddProduct);
            this.tabPage3.Controls.Add(this.lvProducts);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(625, 400);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Продукты";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(456, 6);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(161, 23);
            this.btnAddProduct.TabIndex = 7;
            this.btnAddProduct.Text = "Добавить новый продукт";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // lvProducts
            // 
            this.lvProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnName,
            this.columnPrice,
            this.columnDate});
            this.lvProducts.Dock = System.Windows.Forms.DockStyle.Left;
            this.lvProducts.FullRowSelect = true;
            this.lvProducts.HideSelection = false;
            this.lvProducts.Location = new System.Drawing.Point(3, 3);
            this.lvProducts.MultiSelect = false;
            this.lvProducts.Name = "lvProducts";
            this.lvProducts.Size = new System.Drawing.Size(447, 394);
            this.lvProducts.TabIndex = 6;
            this.lvProducts.UseCompatibleStateImageBehavior = false;
            this.lvProducts.View = System.Windows.Forms.View.Details;
            // 
            // columnName
            // 
            this.columnName.Text = "Название";
            this.columnName.Width = 152;
            // 
            // columnPrice
            // 
            this.columnPrice.Text = "Цена";
            this.columnPrice.Width = 115;
            // 
            // columnDate
            // 
            this.columnDate.Text = "Дата добавления";
            this.columnDate.Width = 152;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(625, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Заказы";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbCanceledOrders);
            this.panel1.Controls.Add(this.rbCompledOrders);
            this.panel1.Controls.Add(this.rbNewOrders);
            this.panel1.Controls.Add(this.lvAllOrders);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(447, 394);
            this.panel1.TabIndex = 1;
            // 
            // rbCanceledOrders
            // 
            this.rbCanceledOrders.AutoSize = true;
            this.rbCanceledOrders.Location = new System.Drawing.Point(310, 5);
            this.rbCanceledOrders.Name = "rbCanceledOrders";
            this.rbCanceledOrders.Size = new System.Drawing.Size(131, 17);
            this.rbCanceledOrders.TabIndex = 4;
            this.rbCanceledOrders.Text = "Отмененные заказы";
            this.rbCanceledOrders.UseVisualStyleBackColor = true;
            this.rbCanceledOrders.CheckedChanged += new System.EventHandler(this.rbOrders_CheckedChanged);
            // 
            // rbCompledOrders
            // 
            this.rbCompledOrders.AutoSize = true;
            this.rbCompledOrders.Location = new System.Drawing.Point(143, 5);
            this.rbCompledOrders.Name = "rbCompledOrders";
            this.rbCompledOrders.Size = new System.Drawing.Size(137, 17);
            this.rbCompledOrders.TabIndex = 3;
            this.rbCompledOrders.Text = "Выполненные заказы";
            this.rbCompledOrders.UseVisualStyleBackColor = true;
            this.rbCompledOrders.CheckedChanged += new System.EventHandler(this.rbOrders_CheckedChanged);
            // 
            // rbNewOrders
            // 
            this.rbNewOrders.AutoSize = true;
            this.rbNewOrders.Checked = true;
            this.rbNewOrders.Location = new System.Drawing.Point(5, 5);
            this.rbNewOrders.Name = "rbNewOrders";
            this.rbNewOrders.Size = new System.Drawing.Size(100, 17);
            this.rbNewOrders.TabIndex = 2;
            this.rbNewOrders.TabStop = true;
            this.rbNewOrders.Text = "Новые заказы";
            this.rbNewOrders.UseVisualStyleBackColor = true;
            this.rbNewOrders.CheckedChanged += new System.EventHandler(this.rbOrders_CheckedChanged);
            // 
            // lvAllOrders
            // 
            this.lvAllOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvAllOrders.FullRowSelect = true;
            this.lvAllOrders.HideSelection = false;
            this.lvAllOrders.Location = new System.Drawing.Point(0, 28);
            this.lvAllOrders.MultiSelect = false;
            this.lvAllOrders.Name = "lvAllOrders";
            this.lvAllOrders.Size = new System.Drawing.Size(447, 366);
            this.lvAllOrders.TabIndex = 1;
            this.lvAllOrders.UseCompatibleStateImageBehavior = false;
            this.lvAllOrders.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Дата заказа";
            this.columnHeader1.Width = 132;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Заказчик";
            this.columnHeader2.Width = 181;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Статус заказа";
            this.columnHeader3.Width = 130;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCancelOrder);
            this.panel2.Controls.Add(this.btnCompleteOrder);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(450, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(172, 394);
            this.panel2.TabIndex = 2;
            // 
            // btnCancelOrder
            // 
            this.btnCancelOrder.Location = new System.Drawing.Point(6, 28);
            this.btnCancelOrder.Name = "btnCancelOrder";
            this.btnCancelOrder.Size = new System.Drawing.Size(161, 23);
            this.btnCancelOrder.TabIndex = 1;
            this.btnCancelOrder.Text = "Отменить заказ";
            this.btnCancelOrder.UseVisualStyleBackColor = true;
            this.btnCancelOrder.Click += new System.EventHandler(this.btnCancelOrder_Click);
            // 
            // btnCompleteOrder
            // 
            this.btnCompleteOrder.Location = new System.Drawing.Point(6, 3);
            this.btnCompleteOrder.Name = "btnCompleteOrder";
            this.btnCompleteOrder.Size = new System.Drawing.Size(161, 23);
            this.btnCompleteOrder.TabIndex = 0;
            this.btnCompleteOrder.Text = "Выполнить заказ";
            this.btnCompleteOrder.UseVisualStyleBackColor = true;
            this.btnCompleteOrder.Click += new System.EventHandler(this.btnCompleteOrder_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(633, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminManagerForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManagerForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem диспетчерПользователейToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmAddNewCustomer;
        private System.Windows.Forms.ToolStripMenuItem tsmRemoveCustomer;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ListView lvAllOrders;
        private System.Windows.Forms.Button btnCancelOrder;
        private System.Windows.Forms.Button btnCompleteOrder;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.RadioButton rbCanceledOrders;
        private System.Windows.Forms.RadioButton rbCompledOrders;
        private System.Windows.Forms.RadioButton rbNewOrders;
        private System.Windows.Forms.ListView lvProducts;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnPrice;
        private System.Windows.Forms.ColumnHeader columnDate;
        private System.Windows.Forms.Button btnAddProduct;
    }
}