
namespace test
{
    partial class DrinkCustomiseScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DrinkCustomiseScreen));
            this.drinkPictureBox = new System.Windows.Forms.PictureBox();
            this.drinkOptionsLabel = new System.Windows.Forms.Label();
            this.drinkCustomiseCheckBox = new System.Windows.Forms.CheckedListBox();
            this.addToOrderButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.smallRadioButton = new System.Windows.Forms.RadioButton();
            this.mediumRadioButton = new System.Windows.Forms.RadioButton();
            this.largeRadioButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.drinkPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // drinkPictureBox
            // 
            this.drinkPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("drinkPictureBox.Image")));
            this.drinkPictureBox.Location = new System.Drawing.Point(54, 33);
            this.drinkPictureBox.Name = "drinkPictureBox";
            this.drinkPictureBox.Size = new System.Drawing.Size(500, 500);
            this.drinkPictureBox.TabIndex = 2;
            this.drinkPictureBox.TabStop = false;
            // 
            // drinkOptionsLabel
            // 
            this.drinkOptionsLabel.AutoSize = true;
            this.drinkOptionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drinkOptionsLabel.Location = new System.Drawing.Point(661, 68);
            this.drinkOptionsLabel.Name = "drinkOptionsLabel";
            this.drinkOptionsLabel.Size = new System.Drawing.Size(136, 24);
            this.drinkOptionsLabel.TabIndex = 6;
            this.drinkOptionsLabel.Text = "Drink Options";
            // 
            // drinkCustomiseCheckBox
            // 
            this.drinkCustomiseCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drinkCustomiseCheckBox.FormattingEnabled = true;
            this.drinkCustomiseCheckBox.Items.AddRange(new object[] {
            "Ice",
            "Extra Ice"});
            this.drinkCustomiseCheckBox.Location = new System.Drawing.Point(665, 276);
            this.drinkCustomiseCheckBox.Name = "drinkCustomiseCheckBox";
            this.drinkCustomiseCheckBox.Size = new System.Drawing.Size(425, 100);
            this.drinkCustomiseCheckBox.TabIndex = 7;
            // 
            // addToOrderButton
            // 
            this.addToOrderButton.BackColor = System.Drawing.Color.Green;
            this.addToOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addToOrderButton.Location = new System.Drawing.Point(665, 404);
            this.addToOrderButton.Name = "addToOrderButton";
            this.addToOrderButton.Size = new System.Drawing.Size(425, 62);
            this.addToOrderButton.TabIndex = 8;
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
            this.backButton.TabIndex = 11;
            this.backButton.Text = "BACK";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // smallRadioButton
            // 
            this.smallRadioButton.AutoSize = true;
            this.smallRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.smallRadioButton.Location = new System.Drawing.Point(664, 142);
            this.smallRadioButton.Name = "smallRadioButton";
            this.smallRadioButton.Size = new System.Drawing.Size(74, 28);
            this.smallRadioButton.TabIndex = 12;
            this.smallRadioButton.TabStop = true;
            this.smallRadioButton.Text = "Small";
            this.smallRadioButton.UseVisualStyleBackColor = true;
            // 
            // mediumRadioButton
            // 
            this.mediumRadioButton.AutoSize = true;
            this.mediumRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.mediumRadioButton.Location = new System.Drawing.Point(664, 176);
            this.mediumRadioButton.Name = "mediumRadioButton";
            this.mediumRadioButton.Size = new System.Drawing.Size(97, 28);
            this.mediumRadioButton.TabIndex = 13;
            this.mediumRadioButton.TabStop = true;
            this.mediumRadioButton.Text = "Medium";
            this.mediumRadioButton.UseVisualStyleBackColor = true;
            // 
            // largeRadioButton
            // 
            this.largeRadioButton.AutoSize = true;
            this.largeRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.largeRadioButton.Location = new System.Drawing.Point(664, 210);
            this.largeRadioButton.Name = "largeRadioButton";
            this.largeRadioButton.Size = new System.Drawing.Size(76, 28);
            this.largeRadioButton.TabIndex = 14;
            this.largeRadioButton.TabStop = true;
            this.largeRadioButton.Text = "Large";
            this.largeRadioButton.UseVisualStyleBackColor = true;
            // 
            // DrinkCustomiseScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 580);
            this.Controls.Add(this.largeRadioButton);
            this.Controls.Add(this.mediumRadioButton);
            this.Controls.Add(this.smallRadioButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.addToOrderButton);
            this.Controls.Add(this.drinkCustomiseCheckBox);
            this.Controls.Add(this.drinkOptionsLabel);
            this.Controls.Add(this.drinkPictureBox);
            this.Name = "DrinkCustomiseScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customise Drink";
            this.Load += new System.EventHandler(this.DrinkCustomiseScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.drinkPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox drinkPictureBox;
        private System.Windows.Forms.Label drinkOptionsLabel;
        private System.Windows.Forms.CheckedListBox drinkCustomiseCheckBox;
        private System.Windows.Forms.Button addToOrderButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.RadioButton smallRadioButton;
        private System.Windows.Forms.RadioButton mediumRadioButton;
        private System.Windows.Forms.RadioButton largeRadioButton;
    }
}