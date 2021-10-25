
namespace SimpleDataApp
{
    partial class FillOrCancel
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.orderIdLabel = new System.Windows.Forms.Label();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.buttbtnFindByOrderID = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFillDate = new System.Windows.Forms.DateTimePicker();
            this.dgvCustomerOrders = new System.Windows.Forms.DataGridView();
            this.btnCancelOrder = new System.Windows.Forms.Button();
            this.btnFinishUpdates = new System.Windows.Forms.Button();
            this.btnFillOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // orderIdLabel
            // 
            this.orderIdLabel.AutoSize = true;
            this.orderIdLabel.Location = new System.Drawing.Point(29, 28);
            this.orderIdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.orderIdLabel.Name = "orderIdLabel";
            this.orderIdLabel.Size = new System.Drawing.Size(54, 15);
            this.orderIdLabel.TabIndex = 0;
            this.orderIdLabel.Text = "Order ID:";
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(93, 28);
            this.txtOrderID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(106, 23);
            this.txtOrderID.TabIndex = 1;
            // 
            // buttbtnFindByOrderID
            // 
            this.buttbtnFindByOrderID.Location = new System.Drawing.Point(202, 28);
            this.buttbtnFindByOrderID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttbtnFindByOrderID.Name = "buttbtnFindByOrderID";
            this.buttbtnFindByOrderID.Size = new System.Drawing.Size(78, 23);
            this.buttbtnFindByOrderID.TabIndex = 2;
            this.buttbtnFindByOrderID.Text = "Find Order";
            this.buttbtnFindByOrderID.UseVisualStyleBackColor = true;
            this.buttbtnFindByOrderID.Click += new System.EventHandler(this.buttbtnFindByOrderIDon1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 104);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "If filling an order, specify filled date:";
            // 
            // dtpFillDate
            // 
            this.dtpFillDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFillDate.Location = new System.Drawing.Point(239, 104);
            this.dtpFillDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpFillDate.Name = "dtpFillDate";
            this.dtpFillDate.Size = new System.Drawing.Size(106, 23);
            this.dtpFillDate.TabIndex = 4;
            // 
            // dgvCustomerOrders
            // 
            this.dgvCustomerOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomerOrders.Location = new System.Drawing.Point(29, 136);
            this.dgvCustomerOrders.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvCustomerOrders.Name = "dgvCustomerOrders";
            this.dgvCustomerOrders.ReadOnly = true;
            this.dgvCustomerOrders.RowHeadersVisible = false;
            this.dgvCustomerOrders.RowHeadersWidth = 62;
            this.dgvCustomerOrders.RowTemplate.Height = 33;
            this.dgvCustomerOrders.Size = new System.Drawing.Size(502, 78);
            this.dgvCustomerOrders.TabIndex = 5;
            // 
            // btnCancelOrder
            // 
            this.btnCancelOrder.Location = new System.Drawing.Point(29, 235);
            this.btnCancelOrder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancelOrder.Name = "btnCancelOrder";
            this.btnCancelOrder.Size = new System.Drawing.Size(102, 20);
            this.btnCancelOrder.TabIndex = 6;
            this.btnCancelOrder.Text = "Cancel Order";
            this.btnCancelOrder.UseVisualStyleBackColor = true;
            this.btnCancelOrder.Click += new System.EventHandler(this.btnCancelOrder_Click);
            // 
            // btnFinishUpdates
            // 
            this.btnFinishUpdates.Location = new System.Drawing.Point(452, 235);
            this.btnFinishUpdates.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFinishUpdates.Name = "btnFinishUpdates";
            this.btnFinishUpdates.Size = new System.Drawing.Size(78, 20);
            this.btnFinishUpdates.TabIndex = 7;
            this.btnFinishUpdates.Text = "Finish";
            this.btnFinishUpdates.UseVisualStyleBackColor = true;
            this.btnFinishUpdates.Click += new System.EventHandler(this.btnFinishUpdates_Click);
            // 
            // btnFillOrder
            // 
            this.btnFillOrder.Location = new System.Drawing.Point(156, 235);
            this.btnFillOrder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFillOrder.Name = "btnFillOrder";
            this.btnFillOrder.Size = new System.Drawing.Size(78, 20);
            this.btnFillOrder.TabIndex = 8;
            this.btnFillOrder.Text = "Fill Order";
            this.btnFillOrder.UseVisualStyleBackColor = true;
            this.btnFillOrder.Click += new System.EventHandler(this.btnFillOrder_Click);
            // 
            // FillOrCancel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 270);
            this.Controls.Add(this.btnFillOrder);
            this.Controls.Add(this.btnFinishUpdates);
            this.Controls.Add(this.btnCancelOrder);
            this.Controls.Add(this.dgvCustomerOrders);
            this.Controls.Add(this.dtpFillDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttbtnFindByOrderID);
            this.Controls.Add(this.txtOrderID);
            this.Controls.Add(this.orderIdLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FillOrCancel";
            this.Text = "Fill Or Cancel Order";
            this.Load += new System.EventHandler(this.FillOrCancel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label orderIdLabel;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.Button buttbtnFindByOrderID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFillDate;
        private System.Windows.Forms.DataGridView dgvCustomerOrders;
        private System.Windows.Forms.Button btnCancelOrder;
        private System.Windows.Forms.Button btnFinishUpdates;
        private System.Windows.Forms.Button btnFillOrder;
    }
}

