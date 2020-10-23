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
            this.burgerMealButton = new System.Windows.Forms.Button();
            this.nuggetMealButton = new System.Windows.Forms.Button();
            this.chickenWrapButton = new System.Windows.Forms.Button();
            this.largeChipsButton = new System.Windows.Forms.Button();
            this.orderListBox = new System.Windows.Forms.ListBox();
            this.totalLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkoutLabel = new System.Windows.Forms.Button();
            this.yourOrderLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // burgerMealButton
            // 
            this.burgerMealButton.Location = new System.Drawing.Point(229, 203);
            this.burgerMealButton.Name = "burgerMealButton";
            this.burgerMealButton.Size = new System.Drawing.Size(216, 120);
            this.burgerMealButton.TabIndex = 0;
            this.burgerMealButton.Text = "Burger Meal £5";
            this.burgerMealButton.UseVisualStyleBackColor = true;
            this.burgerMealButton.Click += new System.EventHandler(this.burgerMealButton_Click);
            // 
            // nuggetMealButton
            // 
            this.nuggetMealButton.Location = new System.Drawing.Point(531, 203);
            this.nuggetMealButton.Name = "nuggetMealButton";
            this.nuggetMealButton.Size = new System.Drawing.Size(216, 120);
            this.nuggetMealButton.TabIndex = 1;
            this.nuggetMealButton.Text = "Nugget meal £6";
            this.nuggetMealButton.UseVisualStyleBackColor = true;
            this.nuggetMealButton.Click += new System.EventHandler(this.nuggetMealButton_Click);
            // 
            // chickenWrapButton
            // 
            this.chickenWrapButton.Location = new System.Drawing.Point(229, 358);
            this.chickenWrapButton.Name = "chickenWrapButton";
            this.chickenWrapButton.Size = new System.Drawing.Size(216, 120);
            this.chickenWrapButton.TabIndex = 2;
            this.chickenWrapButton.Text = "Chicken wrap £3";
            this.chickenWrapButton.UseVisualStyleBackColor = true;
            this.chickenWrapButton.Click += new System.EventHandler(this.chickenWrapButton_Click);
            // 
            // largeChipsButton
            // 
            this.largeChipsButton.Location = new System.Drawing.Point(531, 358);
            this.largeChipsButton.Name = "largeChipsButton";
            this.largeChipsButton.Size = new System.Drawing.Size(216, 120);
            this.largeChipsButton.TabIndex = 3;
            this.largeChipsButton.Text = "Large Chips";
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
            this.totalLabel.Location = new System.Drawing.Point(920, 577);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(95, 24);
            this.totalLabel.TabIndex = 5;
            this.totalLabel.Text = "TOTAL : ";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(1021, 577);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(181, 26);
            this.textBox1.TabIndex = 6;
            // 
            // checkoutLabel
            // 
            this.checkoutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkoutLabel.Location = new System.Drawing.Point(1061, 626);
            this.checkoutLabel.Name = "checkoutLabel";
            this.checkoutLabel.Size = new System.Drawing.Size(142, 31);
            this.checkoutLabel.TabIndex = 7;
            this.checkoutLabel.Text = "CHECKOUT";
            this.checkoutLabel.UseVisualStyleBackColor = true;
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
            // OrderScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1264, 985);
            this.Controls.Add(this.largeChipsButton);
            this.Controls.Add(this.burgerMealButton);
            this.Controls.Add(this.nuggetMealButton);
            this.Controls.Add(this.chickenWrapButton);
            this.Controls.Add(this.yourOrderLabel);
            this.Controls.Add(this.checkoutLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.orderListBox);
            this.Name = "OrderScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Food Order";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button burgerMealButton;
        private System.Windows.Forms.Button nuggetMealButton;
        private System.Windows.Forms.Button chickenWrapButton;
        private System.Windows.Forms.Button largeChipsButton;
        private System.Windows.Forms.ListBox orderListBox;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button checkoutLabel;
        private System.Windows.Forms.Label yourOrderLabel;
    }
}

