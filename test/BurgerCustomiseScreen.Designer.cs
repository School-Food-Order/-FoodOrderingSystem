
namespace test
{
    partial class BurgerCustomiseScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BurgerCustomiseScreen));
            this.burgerPictureBox = new System.Windows.Forms.PictureBox();
            this.addToOrderButton = new System.Windows.Forms.Button();
            this.burgerCustomiseCheckBox = new System.Windows.Forms.CheckedListBox();
            this.burgerOptionsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.burgerPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // burgerPictureBox
            // 
            this.burgerPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("burgerPictureBox.Image")));
            this.burgerPictureBox.Location = new System.Drawing.Point(54, 33);
            this.burgerPictureBox.Name = "burgerPictureBox";
            this.burgerPictureBox.Size = new System.Drawing.Size(503, 518);
            this.burgerPictureBox.TabIndex = 0;
            this.burgerPictureBox.TabStop = false;
            // 
            // addToOrderButton
            // 
            this.addToOrderButton.BackColor = System.Drawing.Color.Green;
            this.addToOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addToOrderButton.Location = new System.Drawing.Point(665, 472);
            this.addToOrderButton.Name = "addToOrderButton";
            this.addToOrderButton.Size = new System.Drawing.Size(425, 79);
            this.addToOrderButton.TabIndex = 1;
            this.addToOrderButton.Text = "ADD TO ORDER";
            this.addToOrderButton.UseVisualStyleBackColor = false;
            this.addToOrderButton.Click += new System.EventHandler(this.addToOrderButton_Click);
            // 
            // burgerCustomiseCheckBox
            // 
            this.burgerCustomiseCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.burgerCustomiseCheckBox.FormattingEnabled = true;
            this.burgerCustomiseCheckBox.Items.AddRange(new object[] {
            "Beef Patty",
            "Cheese",
            "Pickles",
            "Onions",
            "Ketchup",
            "Bread Roll",
            "Extra Beef Patty (+£0.89)",
            "Extra Cheese (+£0.20)",
            "Extra Pickles (+£0.25)",
            "Extra Onions(+£0.25)",
            "Extra Ketchup"});
            this.burgerCustomiseCheckBox.Location = new System.Drawing.Point(665, 106);
            this.burgerCustomiseCheckBox.Name = "burgerCustomiseCheckBox";
            this.burgerCustomiseCheckBox.Size = new System.Drawing.Size(425, 292);
            this.burgerCustomiseCheckBox.TabIndex = 2;
            // 
            // burgerOptionsLabel
            // 
            this.burgerOptionsLabel.AutoSize = true;
            this.burgerOptionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.burgerOptionsLabel.Location = new System.Drawing.Point(661, 68);
            this.burgerOptionsLabel.Name = "burgerOptionsLabel";
            this.burgerOptionsLabel.Size = new System.Drawing.Size(151, 24);
            this.burgerOptionsLabel.TabIndex = 4;
            this.burgerOptionsLabel.Text = "Burger Options";
            // 
            // BurgerCustomiseScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 580);
            this.Controls.Add(this.burgerOptionsLabel);
            this.Controls.Add(this.burgerCustomiseCheckBox);
            this.Controls.Add(this.addToOrderButton);
            this.Controls.Add(this.burgerPictureBox);
            this.Name = "BurgerCustomiseScreen";
            this.Text = "Customize Burger";
            this.Load += new System.EventHandler(this.BurgerCustomiseScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.burgerPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox burgerPictureBox;
        private System.Windows.Forms.Button addToOrderButton;
        private System.Windows.Forms.CheckedListBox burgerCustomiseCheckBox;
        private System.Windows.Forms.Label burgerOptionsLabel;
    }
}