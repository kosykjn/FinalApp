namespace KosykFinalApp.Forms
{
    partial class CustomerForm
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
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.tabPageNewOrder = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lvProducts = new System.Windows.Forms.ListView();
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnUpdateProducts = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lvBag = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddToBag = new System.Windows.Forms.Button();
            this.btnRemoveFromBag = new System.Windows.Forms.Button();
            this.btnGenerateOrder = new System.Windows.Forms.Button();
            this.tabPageOrderHistory = new System.Windows.Forms.TabPage();
            this.lvCustomerOrders = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnUpdateCustomerOrders = new System.Windows.Forms.Button();
            this.lvOrderDetails = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mainTabControl.SuspendLayout();
            this.tabPageNewOrder.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPageOrderHistory.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.tabPageNewOrder);
            this.mainTabControl.Controls.Add(this.tabPageOrderHistory);
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.Location = new System.Drawing.Point(0, 0);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(617, 540);
            this.mainTabControl.TabIndex = 0;
            // 
            // tabPageNewOrder
            // 
            this.tabPageNewOrder.Controls.Add(this.panel1);
            this.tabPageNewOrder.Controls.Add(this.panel2);
            this.tabPageNewOrder.Location = new System.Drawing.Point(4, 22);
            this.tabPageNewOrder.Name = "tabPageNewOrder";
            this.tabPageNewOrder.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNewOrder.Size = new System.Drawing.Size(609, 514);
            this.tabPageNewOrder.TabIndex = 0;
            this.tabPageNewOrder.Text = "Новый заказ";
            this.tabPageNewOrder.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lvProducts);
            this.panel1.Controls.Add(this.btnUpdateProducts);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(274, 508);
            this.panel1.TabIndex = 12;
            // 
            // lvProducts
            // 
            this.lvProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnName,
            this.columnPrice});
            this.lvProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvProducts.FullRowSelect = true;
            this.lvProducts.HideSelection = false;
            this.lvProducts.Location = new System.Drawing.Point(0, 23);
            this.lvProducts.MultiSelect = false;
            this.lvProducts.Name = "lvProducts";
            this.lvProducts.Size = new System.Drawing.Size(274, 485);
            this.lvProducts.TabIndex = 5;
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
            // btnUpdateProducts
            // 
            this.btnUpdateProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUpdateProducts.Location = new System.Drawing.Point(0, 0);
            this.btnUpdateProducts.Name = "btnUpdateProducts";
            this.btnUpdateProducts.Size = new System.Drawing.Size(274, 23);
            this.btnUpdateProducts.TabIndex = 11;
            this.btnUpdateProducts.Text = "Обновить список продуктов";
            this.btnUpdateProducts.UseVisualStyleBackColor = true;
            this.btnUpdateProducts.Click += new System.EventHandler(this.btnUpdateProducts_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lvBag);
            this.panel2.Controls.Add(this.btnAddToBag);
            this.panel2.Controls.Add(this.btnRemoveFromBag);
            this.panel2.Controls.Add(this.btnGenerateOrder);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(277, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(329, 508);
            this.panel2.TabIndex = 13;
            // 
            // lvBag
            // 
            this.lvBag.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvBag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvBag.FullRowSelect = true;
            this.lvBag.HideSelection = false;
            this.lvBag.Location = new System.Drawing.Point(0, 0);
            this.lvBag.Name = "lvBag";
            this.lvBag.Size = new System.Drawing.Size(329, 439);
            this.lvBag.TabIndex = 11;
            this.lvBag.UseCompatibleStateImageBehavior = false;
            this.lvBag.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Название";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Цена";
            this.columnHeader2.Width = 115;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Кол-во";
            // 
            // btnAddToBag
            // 
            this.btnAddToBag.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAddToBag.Location = new System.Drawing.Point(0, 439);
            this.btnAddToBag.Name = "btnAddToBag";
            this.btnAddToBag.Size = new System.Drawing.Size(329, 23);
            this.btnAddToBag.TabIndex = 12;
            this.btnAddToBag.Text = "Добавить в корзину";
            this.btnAddToBag.UseVisualStyleBackColor = true;
            this.btnAddToBag.Click += new System.EventHandler(this.btnAddToBag_Click);
            // 
            // btnRemoveFromBag
            // 
            this.btnRemoveFromBag.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnRemoveFromBag.Location = new System.Drawing.Point(0, 462);
            this.btnRemoveFromBag.Name = "btnRemoveFromBag";
            this.btnRemoveFromBag.Size = new System.Drawing.Size(329, 23);
            this.btnRemoveFromBag.TabIndex = 13;
            this.btnRemoveFromBag.Text = "Удалить из корзины";
            this.btnRemoveFromBag.UseVisualStyleBackColor = true;
            this.btnRemoveFromBag.Click += new System.EventHandler(this.btnRemoveFromBag_Click);
            // 
            // btnGenerateOrder
            // 
            this.btnGenerateOrder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnGenerateOrder.Location = new System.Drawing.Point(0, 485);
            this.btnGenerateOrder.Name = "btnGenerateOrder";
            this.btnGenerateOrder.Size = new System.Drawing.Size(329, 23);
            this.btnGenerateOrder.TabIndex = 14;
            this.btnGenerateOrder.Text = "Сгенерировать заказ";
            this.btnGenerateOrder.UseVisualStyleBackColor = true;
            this.btnGenerateOrder.Click += new System.EventHandler(this.btnGenerateOrder_Click);
            // 
            // tabPageOrderHistory
            // 
            this.tabPageOrderHistory.Controls.Add(this.lvCustomerOrders);
            this.tabPageOrderHistory.Controls.Add(this.btnUpdateCustomerOrders);
            this.tabPageOrderHistory.Controls.Add(this.lvOrderDetails);
            this.tabPageOrderHistory.Location = new System.Drawing.Point(4, 22);
            this.tabPageOrderHistory.Name = "tabPageOrderHistory";
            this.tabPageOrderHistory.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOrderHistory.Size = new System.Drawing.Size(609, 514);
            this.tabPageOrderHistory.TabIndex = 1;
            this.tabPageOrderHistory.Text = "История заказов";
            this.tabPageOrderHistory.UseVisualStyleBackColor = true;
            // 
            // lvCustomerOrders
            // 
            this.lvCustomerOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5});
            this.lvCustomerOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvCustomerOrders.HideSelection = false;
            this.lvCustomerOrders.Location = new System.Drawing.Point(3, 26);
            this.lvCustomerOrders.MultiSelect = false;
            this.lvCustomerOrders.Name = "lvCustomerOrders";
            this.lvCustomerOrders.Size = new System.Drawing.Size(239, 485);
            this.lvCustomerOrders.TabIndex = 0;
            this.lvCustomerOrders.UseCompatibleStateImageBehavior = false;
            this.lvCustomerOrders.View = System.Windows.Forms.View.Details;
            this.lvCustomerOrders.SelectedIndexChanged += new System.EventHandler(this.lvCustomerOrders_SelectedIndexChanged);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Дата";
            this.columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Общая стоимость";
            this.columnHeader5.Width = 115;
            // 
            // btnUpdateCustomerOrders
            // 
            this.btnUpdateCustomerOrders.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUpdateCustomerOrders.Location = new System.Drawing.Point(3, 3);
            this.btnUpdateCustomerOrders.Name = "btnUpdateCustomerOrders";
            this.btnUpdateCustomerOrders.Size = new System.Drawing.Size(239, 23);
            this.btnUpdateCustomerOrders.TabIndex = 9;
            this.btnUpdateCustomerOrders.Text = "Обновить список заказов";
            this.btnUpdateCustomerOrders.UseVisualStyleBackColor = true;
            this.btnUpdateCustomerOrders.Click += new System.EventHandler(this.btnUpdateCustomerOrders_Click);
            // 
            // lvOrderDetails
            // 
            this.lvOrderDetails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lvOrderDetails.Dock = System.Windows.Forms.DockStyle.Right;
            this.lvOrderDetails.FullRowSelect = true;
            this.lvOrderDetails.HideSelection = false;
            this.lvOrderDetails.Location = new System.Drawing.Point(242, 3);
            this.lvOrderDetails.Name = "lvOrderDetails";
            this.lvOrderDetails.Size = new System.Drawing.Size(364, 508);
            this.lvOrderDetails.TabIndex = 8;
            this.lvOrderDetails.UseCompatibleStateImageBehavior = false;
            this.lvOrderDetails.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Название";
            this.columnHeader6.Width = 150;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Цена";
            this.columnHeader7.Width = 115;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Кол-во";
            this.columnHeader8.Width = 95;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 540);
            this.Controls.Add(this.mainTabControl);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerForm";
            this.mainTabControl.ResumeLayout(false);
            this.tabPageNewOrder.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tabPageOrderHistory.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage tabPageNewOrder;
        private System.Windows.Forms.TabPage tabPageOrderHistory;
        private System.Windows.Forms.ListView lvProducts;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnPrice;
        private System.Windows.Forms.ListView lvCustomerOrders;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ListView lvOrderDetails;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Button btnUpdateCustomerOrders;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUpdateProducts;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnGenerateOrder;
        private System.Windows.Forms.Button btnRemoveFromBag;
        private System.Windows.Forms.Button btnAddToBag;
        private System.Windows.Forms.ListView lvBag;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}