
namespace SimpleDataApp
{
    partial class NewCustomer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private int parsedCustomerID;
        private int orderID;
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
            this.AddAccount = new System.Windows.Forms.GroupBox();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.addAccLabel2 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.addAccLabel1 = new System.Windows.Forms.Label();
            this.CreateOrder = new System.Windows.Forms.GroupBox();
            this.dtpOrderDate = new System.Windows.Forms.DateTimePicker();
            this.numOrderAmount = new System.Windows.Forms.NumericUpDown();
            this.crtOrderLabel1 = new System.Windows.Forms.Label();
            this.crtOrderLabel2 = new System.Windows.Forms.Label();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.btnAddFinish = new System.Windows.Forms.Button();
            this.btnAddAnotherAccount = new System.Windows.Forms.Button();
            this.AddAccount.SuspendLayout();
            this.CreateOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOrderAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // AddAccount
            // 
            this.AddAccount.Controls.Add(this.txtCustomerID);
            this.AddAccount.Controls.Add(this.addAccLabel2);
            this.AddAccount.Controls.Add(this.txtCustomerName);
            this.AddAccount.Controls.Add(this.addAccLabel1);
            this.AddAccount.Location = new System.Drawing.Point(12, 57);
            this.AddAccount.Name = "AddAccount";
            this.AddAccount.Size = new System.Drawing.Size(442, 150);
            this.AddAccount.TabIndex = 0;
            this.AddAccount.TabStop = false;
            this.AddAccount.Text = "Add Account";
            this.AddAccount.Enter += new System.EventHandler(this.AddAccount_Enter);
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(155, 91);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.ReadOnly = true;
            this.txtCustomerID.Size = new System.Drawing.Size(145, 31);
            this.txtCustomerID.TabIndex = 3;
            // 
            // addAccLabel2
            // 
            this.addAccLabel2.AutoSize = true;
            this.addAccLabel2.Location = new System.Drawing.Point(7, 91);
            this.addAccLabel2.Name = "addAccLabel2";
            this.addAccLabel2.Size = new System.Drawing.Size(112, 25);
            this.addAccLabel2.TabIndex = 2;
            this.addAccLabel2.Text = "Customer ID";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(155, 31);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(212, 31);
            this.txtCustomerName.TabIndex = 1;
            // 
            // addAccLabel1
            // 
            this.addAccLabel1.AutoSize = true;
            this.addAccLabel1.Location = new System.Drawing.Point(7, 31);
            this.addAccLabel1.Name = "addAccLabel1";
            this.addAccLabel1.Size = new System.Drawing.Size(141, 25);
            this.addAccLabel1.TabIndex = 0;
            this.addAccLabel1.Text = "Customer Name";
            // 
            // CreateOrder
            // 
            this.CreateOrder.Controls.Add(this.dtpOrderDate);
            this.CreateOrder.Controls.Add(this.numOrderAmount);
            this.CreateOrder.Controls.Add(this.crtOrderLabel1);
            this.CreateOrder.Location = new System.Drawing.Point(12, 213);
            this.CreateOrder.Name = "CreateOrder";
            this.CreateOrder.Size = new System.Drawing.Size(442, 150);
            this.CreateOrder.TabIndex = 1;
            this.CreateOrder.TabStop = false;
            this.CreateOrder.Text = "Create Order";
            this.CreateOrder.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dtpOrderDate
            // 
            this.dtpOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOrderDate.Location = new System.Drawing.Point(154, 99);
            this.dtpOrderDate.Name = "dtpOrderDate";
            this.dtpOrderDate.Size = new System.Drawing.Size(213, 31);
            this.dtpOrderDate.TabIndex = 3;
            // 
            // numOrderAmount
            // 
            this.numOrderAmount.Location = new System.Drawing.Point(154, 27);
            this.numOrderAmount.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numOrderAmount.Name = "numOrderAmount";
            this.numOrderAmount.Size = new System.Drawing.Size(145, 31);
            this.numOrderAmount.TabIndex = 1;
            this.numOrderAmount.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // crtOrderLabel1
            // 
            this.crtOrderLabel1.AutoSize = true;
            this.crtOrderLabel1.Location = new System.Drawing.Point(6, 27);
            this.crtOrderLabel1.Name = "crtOrderLabel1";
            this.crtOrderLabel1.Size = new System.Drawing.Size(128, 25);
            this.crtOrderLabel1.TabIndex = 0;
            this.crtOrderLabel1.Text = "Order Amount";
            // 
            // crtOrderLabel2
            // 
            this.crtOrderLabel2.AutoSize = true;
            this.crtOrderLabel2.Location = new System.Drawing.Point(18, 312);
            this.crtOrderLabel2.Name = "crtOrderLabel2";
            this.crtOrderLabel2.Size = new System.Drawing.Size(100, 25);
            this.crtOrderLabel2.TabIndex = 2;
            this.crtOrderLabel2.Text = "Order Date";
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Location = new System.Drawing.Point(515, 173);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(225, 34);
            this.btnCreateAccount.TabIndex = 3;
            this.btnCreateAccount.Text = "Create Account";
            this.btnCreateAccount.UseVisualStyleBackColor = true;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Location = new System.Drawing.Point(515, 329);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(225, 34);
            this.btnPlaceOrder.TabIndex = 4;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAddFinish
            // 
            this.btnAddFinish.Location = new System.Drawing.Point(12, 404);
            this.btnAddFinish.Name = "btnAddFinish";
            this.btnAddFinish.Size = new System.Drawing.Size(112, 34);
            this.btnAddFinish.TabIndex = 5;
            this.btnAddFinish.Text = "Finish";
            this.btnAddFinish.UseVisualStyleBackColor = true;
            this.btnAddFinish.Click += new System.EventHandler(this.btnAddFinish_Click);
            // 
            // btnAddAnotherAccount
            // 
            this.btnAddAnotherAccount.Location = new System.Drawing.Point(229, 404);
            this.btnAddAnotherAccount.Name = "btnAddAnotherAccount";
            this.btnAddAnotherAccount.Size = new System.Drawing.Size(225, 34);
            this.btnAddAnotherAccount.TabIndex = 6;
            this.btnAddAnotherAccount.Text = "Add Another Account";
            this.btnAddAnotherAccount.UseVisualStyleBackColor = true;
            this.btnAddAnotherAccount.Click += new System.EventHandler(this.btnAddAnotherAccount_Click);
            // 
            // NewCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddAnotherAccount);
            this.Controls.Add(this.btnAddFinish);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.btnCreateAccount);
            this.Controls.Add(this.crtOrderLabel2);
            this.Controls.Add(this.CreateOrder);
            this.Controls.Add(this.AddAccount);
            this.Name = "NewCustomer";
            this.Text = "New Customer Service";
            this.AddAccount.ResumeLayout(false);
            this.AddAccount.PerformLayout();
            this.CreateOrder.ResumeLayout(false);
            this.CreateOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOrderAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox AddAccount;
        private System.Windows.Forms.GroupBox CreateOrder;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label addAccLabel1;
        private System.Windows.Forms.Label addAccLabel2;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.NumericUpDown numOrderAmount;
        private System.Windows.Forms.Label crtOrderLabel1;
        private System.Windows.Forms.Label crtOrderLabel2;
        private System.Windows.Forms.DateTimePicker dtpOrderDate;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Button btnAddFinish;
        private System.Windows.Forms.Button btnAddAnotherAccount;
    }
}