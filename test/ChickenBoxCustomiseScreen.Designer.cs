
namespace test
{
    partial class ChickenBoxCustomiseScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChickenBoxCustomiseScreen));
            this.chickenPictureBox = new System.Windows.Forms.PictureBox();
            this.chickenBoxLabel = new System.Windows.Forms.Label();
            this.chickenCustomizeCheckBox = new System.Windows.Forms.CheckedListBox();
            this.addToOrderButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chickenPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // chickenPictureBox
            // 
            this.chickenPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("chickenPictureBox.Image")));
            this.chickenPictureBox.Location = new System.Drawing.Point(54, 33);
            this.chickenPictureBox.Name = "chickenPictureBox";
            this.chickenPictureBox.Size = new System.Drawing.Size(500, 500);
            this.chickenPictureBox.TabIndex = 0;
            this.chickenPictureBox.TabStop = false;
            // 
            // chickenBoxLabel
            // 
            this.chickenBoxLabel.AutoSize = true;
            this.chickenBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chickenBoxLabel.Location = new System.Drawing.Point(661, 68);
            this.chickenBoxLabel.Name = "chickenBoxLabel";
            this.chickenBoxLabel.Size = new System.Drawing.Size(206, 24);
            this.chickenBoxLabel.TabIndex = 5;
            this.chickenBoxLabel.Text = "Chicken Box Options";
            // 
            // chickenCustomizeCheckBox
            // 
            this.chickenCustomizeCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chickenCustomizeCheckBox.FormattingEnabled = true;
            this.chickenCustomizeCheckBox.Items.AddRange(new object[] {
            "6 x Chicken Wing",
            "2 x Chicken Breast",
            "2 x Chicken Drumstick",
            "1 x Popcorn Chicken",
            "Ketchup Dip",
            "BBQ Dip",
            "Sweet Chilli Dip",
            "Curry Dip",
            "Gravy (+0.20)"});
            this.chickenCustomizeCheckBox.Location = new System.Drawing.Point(665, 106);
            this.chickenCustomizeCheckBox.Name = "chickenCustomizeCheckBox";
            this.chickenCustomizeCheckBox.Size = new System.Drawing.Size(425, 292);
            this.chickenCustomizeCheckBox.TabIndex = 6;
            this.chickenCustomizeCheckBox.Tag = "";
            this.chickenCustomizeCheckBox.SelectedIndexChanged += new System.EventHandler(this.chickenCustomizeCheckBox_SelectedIndexChanged);
            // 
            // addToOrderButton
            // 
            this.addToOrderButton.BackColor = System.Drawing.Color.Green;
            this.addToOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addToOrderButton.Location = new System.Drawing.Point(665, 404);
            this.addToOrderButton.Name = "addToOrderButton";
            this.addToOrderButton.Size = new System.Drawing.Size(425, 62);
            this.addToOrderButton.TabIndex = 7;
            this.addToOrderButton.Text = "ADD TO ORDER";
            this.addToOrderButton.UseVisualStyleBackColor = false;
            this.addToOrderButton.Click += new System.EventHandler(this.addToOrderButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.IndianRed;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(665, 471);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(425, 62);
            this.backButton.TabIndex = 8;
            this.backButton.Text = "BACK";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // ChickenCustomiseScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 580);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.addToOrderButton);
            this.Controls.Add(this.chickenCustomizeCheckBox);
            this.Controls.Add(this.chickenBoxLabel);
            this.Controls.Add(this.chickenPictureBox);
            this.Name = "ChickenCustomiseScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customise Chicken Box";
            this.Load += new System.EventHandler(this.ChickenCustomiseScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chickenPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox chickenPictureBox;
        private System.Windows.Forms.Label chickenBoxLabel;
        private System.Windows.Forms.CheckedListBox chickenCustomizeCheckBox;
        private System.Windows.Forms.Button addToOrderButton;
        private System.Windows.Forms.Button backButton;
    }
}