namespace test
{
    partial class OrderScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderScreen));
            this.burgerMealButton = new System.Windows.Forms.Button();
            this.nuggetMealButton = new System.Windows.Forms.Button();
            this.chickenWrapButton = new System.Windows.Forms.Button();
            this.largeChipsButton = new System.Windows.Forms.Button();
            this.orderListBox = new System.Windows.Forms.ListBox();
            this.totalLabel = new System.Windows.Forms.Label();
            this.totalCostTextBox = new System.Windows.Forms.TextBox();
            this.checkoutLabel = new System.Windows.Forms.Button();
            this.yourOrderLabel = new System.Windows.Forms.Label();
            this.orderScreenRemoveButton = new System.Windows.Forms.Button();
            this.burgerCustomize = new System.Windows.Forms.Button();
            this.chickenSubCustomise = new System.Windows.Forms.Button();
            this.chickenBoxCustomise = new System.Windows.Forms.Button();
            this.friesCustomise = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // burgerMealButton
            // 
            this.burgerMealButton.Image = ((System.Drawing.Image)(resources.GetObject("burgerMealButton.Image")));
            this.burgerMealButton.Location = new System.Drawing.Point(229, 101);
            this.burgerMealButton.Name = "burgerMealButton";
            this.burgerMealButton.Size = new System.Drawing.Size(150, 150);
            this.burgerMealButton.TabIndex = 0;
            this.burgerMealButton.UseVisualStyleBackColor = true;
            this.burgerMealButton.Click += new System.EventHandler(this.burgerMealButton_Click);
            // 
            // nuggetMealButton
            // 
            this.nuggetMealButton.Image = ((System.Drawing.Image)(resources.GetObject("nuggetMealButton.Image")));
            this.nuggetMealButton.Location = new System.Drawing.Point(531, 101);
            this.nuggetMealButton.Name = "nuggetMealButton";
            this.nuggetMealButton.Size = new System.Drawing.Size(150, 150);
            this.nuggetMealButton.TabIndex = 1;
            this.nuggetMealButton.UseVisualStyleBackColor = true;
            this.nuggetMealButton.Click += new System.EventHandler(this.nuggetMealButton_Click);
            // 
            // chickenWrapButton
            // 
            this.chickenWrapButton.Image = ((System.Drawing.Image)(resources.GetObject("chickenWrapButton.Image")));
            this.chickenWrapButton.Location = new System.Drawing.Point(229, 328);
            this.chickenWrapButton.Name = "chickenWrapButton";
            this.chickenWrapButton.Size = new System.Drawing.Size(150, 150);
            this.chickenWrapButton.TabIndex = 2;
            this.chickenWrapButton.UseVisualStyleBackColor = true;
            this.chickenWrapButton.Click += new System.EventHandler(this.chickenWrapButton_Click);
            // 
            // largeChipsButton
            // 
            this.largeChipsButton.Image = ((System.Drawing.Image)(resources.GetObject("largeChipsButton.Image")));
            this.largeChipsButton.Location = new System.Drawing.Point(531, 328);
            this.largeChipsButton.Name = "largeChipsButton";
            this.largeChipsButton.Size = new System.Drawing.Size(150, 150);
            this.largeChipsButton.TabIndex = 3;
            this.largeChipsButton.UseVisualStyleBackColor = true;
            this.largeChipsButton.Click += new System.EventHandler(this.largeChipsButton_Click);
            // 
            // orderListBox
            // 
            this.orderListBox.FormattingEnabled = true;
            this.orderListBox.Location = new System.Drawing.Point(912, 76);
            this.orderListBox.Name = "orderListBox";
            this.orderListBox.Size = new System.Drawing.Size(291, 485);
            this.orderListBox.TabIndex = 4;
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(909, 579);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(106, 24);
            this.totalLabel.TabIndex = 5;
            this.totalLabel.Text = "TOTAL : £";
            // 
            // totalCostTextBox
            // 
            this.totalCostTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCostTextBox.Location = new System.Drawing.Point(1021, 577);
            this.totalCostTextBox.Name = "totalCostTextBox";
            this.totalCostTextBox.ReadOnly = true;
            this.totalCostTextBox.Size = new System.Drawing.Size(181, 26);
            this.totalCostTextBox.TabIndex = 6;
            this.totalCostTextBox.Text = "0.00";
            // 
            // checkoutLabel
            // 
            this.checkoutLabel.BackColor = System.Drawing.Color.LightGreen;
            this.checkoutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkoutLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkoutLabel.Location = new System.Drawing.Point(942, 626);
            this.checkoutLabel.Name = "checkoutLabel";
            this.checkoutLabel.Size = new System.Drawing.Size(247, 45);
            this.checkoutLabel.TabIndex = 7;
            this.checkoutLabel.Text = "CHECKOUT";
            this.checkoutLabel.UseVisualStyleBackColor = false;
            this.checkoutLabel.Click += new System.EventHandler(this.checkoutLabel_Click);
            // 
            // yourOrderLabel
            // 
            this.yourOrderLabel.AutoSize = true;
            this.yourOrderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yourOrderLabel.Location = new System.Drawing.Point(908, 36);
            this.yourOrderLabel.Name = "yourOrderLabel";
            this.yourOrderLabel.Size = new System.Drawing.Size(163, 24);
            this.yourOrderLabel.TabIndex = 8;
            this.yourOrderLabel.Text = "YOUR ORDER : ";
            // 
            // orderScreenRemoveButton
            // 
            this.orderScreenRemoveButton.BackColor = System.Drawing.Color.IndianRed;
            this.orderScreenRemoveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderScreenRemoveButton.Location = new System.Drawing.Point(942, 689);
            this.orderScreenRemoveButton.Name = "orderScreenRemoveButton";
            this.orderScreenRemoveButton.Size = new System.Drawing.Size(247, 49);
            this.orderScreenRemoveButton.TabIndex = 9;
            this.orderScreenRemoveButton.Text = "REMOVE ITEM";
            this.orderScreenRemoveButton.UseVisualStyleBackColor = false;
            this.orderScreenRemoveButton.Click += new System.EventHandler(this.orderScreenRemoveButton_Click_1);
            // 
            // burgerCustomize
            // 
            this.burgerCustomize.BackColor = System.Drawing.Color.Pink;
            this.burgerCustomize.Location = new System.Drawing.Point(229, 246);
            this.burgerCustomize.Name = "burgerCustomize";
            this.burgerCustomize.Size = new System.Drawing.Size(150, 45);
            this.burgerCustomize.TabIndex = 10;
            this.burgerCustomize.Text = "Customize";
            this.burgerCustomize.UseVisualStyleBackColor = false;
            this.burgerCustomize.Click += new System.EventHandler(this.burgerCustomize_Click);
            // 
            // chickenSubCustomise
            // 
            this.chickenSubCustomise.BackColor = System.Drawing.Color.Pink;
            this.chickenSubCustomise.Location = new System.Drawing.Point(229, 473);
            this.chickenSubCustomise.Name = "chickenSubCustomise";
            this.chickenSubCustomise.Size = new System.Drawing.Size(150, 45);
            this.chickenSubCustomise.TabIndex = 11;
            this.chickenSubCustomise.Text = "Customize";
            this.chickenSubCustomise.UseVisualStyleBackColor = false;
            // 
            // chickenBoxCustomise
            // 
            this.chickenBoxCustomise.BackColor = System.Drawing.Color.Pink;
            this.chickenBoxCustomise.Location = new System.Drawing.Point(531, 246);
            this.chickenBoxCustomise.Name = "chickenBoxCustomise";
            this.chickenBoxCustomise.Size = new System.Drawing.Size(150, 45);
            this.chickenBoxCustomise.TabIndex = 12;
            this.chickenBoxCustomise.Text = "Customize";
            this.chickenBoxCustomise.UseVisualStyleBackColor = false;
            this.chickenBoxCustomise.Click += new System.EventHandler(this.chickenBoxCustomise_Click);
            // 
            // friesCustomise
            // 
            this.friesCustomise.BackColor = System.Drawing.Color.Pink;
            this.friesCustomise.Location = new System.Drawing.Point(531, 473);
            this.friesCustomise.Name = "friesCustomise";
            this.friesCustomise.Size = new System.Drawing.Size(150, 45);
            this.friesCustomise.TabIndex = 13;
            this.friesCustomise.Text = "Customize";
            this.friesCustomise.UseVisualStyleBackColor = false;
            this.friesCustomise.Click += new System.EventHandler(this.friesCustomise_Click);
            // 
            // OrderScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1264, 985);
            this.Controls.Add(this.friesCustomise);
            this.Controls.Add(this.chickenBoxCustomise);
            this.Controls.Add(this.chickenSubCustomise);
            this.Controls.Add(this.burgerCustomize);
            this.Controls.Add(this.orderScreenRemoveButton);
            this.Controls.Add(this.largeChipsButton);
            this.Controls.Add(this.burgerMealButton);
            this.Controls.Add(this.nuggetMealButton);
            this.Controls.Add(this.chickenWrapButton);
            this.Controls.Add(this.yourOrderLabel);
            this.Controls.Add(this.checkoutLabel);
            this.Controls.Add(this.totalCostTextBox);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.orderListBox);
            this.Name = "OrderScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Food Order";
            this.Load += new System.EventHandler(this.OrderScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button burgerMealButton;
        private System.Windows.Forms.Button nuggetMealButton;
        private System.Windows.Forms.Button chickenWrapButton;
        private System.Windows.Forms.Button largeChipsButton;
        public System.Windows.Forms.ListBox orderListBox;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.TextBox totalCostTextBox;
        private System.Windows.Forms.Button checkoutLabel;
        private System.Windows.Forms.Label yourOrderLabel;
        private System.Windows.Forms.Button orderScreenRemoveButton;
        private System.Windows.Forms.Button burgerCustomize;
        private System.Windows.Forms.Button chickenSubCustomise;
        private System.Windows.Forms.Button chickenBoxCustomise;
        private System.Windows.Forms.Button friesCustomise;
    }
}

