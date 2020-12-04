namespace test
{
    partial class ChickenSubCustomiseScreen
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
            this.backButton = new System.Windows.Forms.Button();
            this.burgerOptionsLabel = new System.Windows.Forms.Label();
            this.ChickenSubCustomiseCheckBox = new System.Windows.Forms.CheckedListBox();
            this.addToOrderButton = new System.Windows.Forms.Button();
            this.burgerPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.burgerPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.IndianRed;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(685, 478);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(425, 62);
            this.backButton.TabIndex = 14;
            this.backButton.Text = "BACK";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // burgerOptionsLabel
            // 
            this.burgerOptionsLabel.AutoSize = true;
            this.burgerOptionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.burgerOptionsLabel.Location = new System.Drawing.Point(681, 75);
            this.burgerOptionsLabel.Name = "burgerOptionsLabel";
            this.burgerOptionsLabel.Size = new System.Drawing.Size(207, 24);
            this.burgerOptionsLabel.TabIndex = 13;
            this.burgerOptionsLabel.Text = "Chicken Sub Options";
            // 
            // ChickenSubCustomiseCheckBox
            // 
            this.ChickenSubCustomiseCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChickenSubCustomiseCheckBox.FormattingEnabled = true;
            this.ChickenSubCustomiseCheckBox.Items.AddRange(new object[] {
            "Chicken Tenders",
            "American Cheese",
            "Lettuce",
            "Cucumber",
            "Sweet Chilli Sauce",
            "Bageutte Roll",
            "Extra Chicken Tenders (+£0.89)",
            "Extra American Cheese (+£0.20)",
            "Extra Lettuce (+£0.25)",
            "Extra Cucumber(+£0.25)",
            "Extra Sweet Chilli Sauce"});
            this.ChickenSubCustomiseCheckBox.Location = new System.Drawing.Point(685, 113);
            this.ChickenSubCustomiseCheckBox.Name = "ChickenSubCustomiseCheckBox";
            this.ChickenSubCustomiseCheckBox.Size = new System.Drawing.Size(425, 292);
            this.ChickenSubCustomiseCheckBox.TabIndex = 12;
            // 
            // addToOrderButton
            // 
            this.addToOrderButton.BackColor = System.Drawing.Color.Green;
            this.addToOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addToOrderButton.Location = new System.Drawing.Point(685, 410);
            this.addToOrderButton.Name = "addToOrderButton";
            this.addToOrderButton.Size = new System.Drawing.Size(425, 62);
            this.addToOrderButton.TabIndex = 11;
            this.addToOrderButton.Text = "ADD TO ORDER";
            this.addToOrderButton.UseVisualStyleBackColor = false;
            this.addToOrderButton.Click += new System.EventHandler(this.addToOrderButton_Click);
            // 
            // burgerPictureBox
            // 
            this.burgerPictureBox.Image = global::test.Properties.Resources.iconSubroll;
            this.burgerPictureBox.Location = new System.Drawing.Point(74, 40);
            this.burgerPictureBox.Name = "burgerPictureBox";
            this.burgerPictureBox.Size = new System.Drawing.Size(500, 500);
            this.burgerPictureBox.TabIndex = 10;
            this.burgerPictureBox.TabStop = false;
            // 
            // ChickenSubCustomiseScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 580);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.burgerOptionsLabel);
            this.Controls.Add(this.ChickenSubCustomiseCheckBox);
            this.Controls.Add(this.addToOrderButton);
            this.Controls.Add(this.burgerPictureBox);
            this.Name = "ChickenSubCustomiseScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChickenSubCustomiseScreen";
            this.Load += new System.EventHandler(this.ChickenSubCustomiseScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.burgerPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label burgerOptionsLabel;
        private System.Windows.Forms.CheckedListBox ChickenSubCustomiseCheckBox;
        private System.Windows.Forms.Button addToOrderButton;
        private System.Windows.Forms.PictureBox burgerPictureBox;
    }
}