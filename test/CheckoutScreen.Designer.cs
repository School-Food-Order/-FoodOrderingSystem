namespace test
{
    partial class CheckoutScreen
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
            this.yourOrderLabel = new System.Windows.Forms.Label();
            this.checkoutListBox = new System.Windows.Forms.ListBox();
            this.orderTotalLabel = new System.Windows.Forms.Label();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.checkoutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // yourOrderLabel
            // 
            this.yourOrderLabel.AutoSize = true;
            this.yourOrderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yourOrderLabel.Location = new System.Drawing.Point(21, 20);
            this.yourOrderLabel.Name = "yourOrderLabel";
            this.yourOrderLabel.Size = new System.Drawing.Size(163, 24);
            this.yourOrderLabel.TabIndex = 0;
            this.yourOrderLabel.Text = "YOUR ORDER : ";
            // 
            // checkoutListBox
            // 
            this.checkoutListBox.FormattingEnabled = true;
            this.checkoutListBox.Location = new System.Drawing.Point(40, 47);
            this.checkoutListBox.Name = "checkoutListBox";
            this.checkoutListBox.Size = new System.Drawing.Size(317, 381);
            this.checkoutListBox.TabIndex = 1;
            // 
            // orderTotalLabel
            // 
            this.orderTotalLabel.AutoSize = true;
            this.orderTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderTotalLabel.Location = new System.Drawing.Point(156, 442);
            this.orderTotalLabel.Name = "orderTotalLabel";
            this.orderTotalLabel.Size = new System.Drawing.Size(95, 24);
            this.orderTotalLabel.TabIndex = 2;
            this.orderTotalLabel.Text = "TOTAL : ";
            // 
            // totalTextBox
            // 
            this.totalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTextBox.Location = new System.Drawing.Point(257, 442);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.ReadOnly = true;
            this.totalTextBox.Size = new System.Drawing.Size(100, 26);
            this.totalTextBox.TabIndex = 3;
            // 
            // checkoutButton
            // 
            this.checkoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkoutButton.Location = new System.Drawing.Point(393, 437);
            this.checkoutButton.Name = "checkoutButton";
            this.checkoutButton.Size = new System.Drawing.Size(104, 37);
            this.checkoutButton.TabIndex = 4;
            this.checkoutButton.Text = "Check-out";
            this.checkoutButton.UseVisualStyleBackColor = true;
            this.checkoutButton.Click += new System.EventHandler(this.checkoutButton_Click);
            // 
            // CheckoutScreen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 505);
            this.Controls.Add(this.checkoutButton);
            this.Controls.Add(this.totalTextBox);
            this.Controls.Add(this.orderTotalLabel);
            this.Controls.Add(this.checkoutListBox);
            this.Controls.Add(this.yourOrderLabel);
            this.Name = "CheckoutScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Checkout";
            this.Load += new System.EventHandler(this.CheckoutScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label yourOrderLabel;
        private System.Windows.Forms.ListBox checkoutListBox;
        private System.Windows.Forms.Label orderTotalLabel;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.Button checkoutButton;
    }
}