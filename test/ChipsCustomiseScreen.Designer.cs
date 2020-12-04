
namespace test
{
    partial class ChipsCustomiseScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChipsCustomiseScreen));
            this.chipsPictureBox = new System.Windows.Forms.PictureBox();
            this.chipsOptionsLabel = new System.Windows.Forms.Label();
            this.chipsCustomiseCheckBox = new System.Windows.Forms.CheckedListBox();
            this.addToOrderButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chipsPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // chipsPictureBox
            // 
            this.chipsPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("chipsPictureBox.Image")));
            this.chipsPictureBox.Location = new System.Drawing.Point(54, 33);
            this.chipsPictureBox.Name = "chipsPictureBox";
            this.chipsPictureBox.Size = new System.Drawing.Size(500, 500);
            this.chipsPictureBox.TabIndex = 1;
            this.chipsPictureBox.TabStop = false;
            // 
            // chipsOptionsLabel
            // 
            this.chipsOptionsLabel.AutoSize = true;
            this.chipsOptionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chipsOptionsLabel.Location = new System.Drawing.Point(661, 68);
            this.chipsOptionsLabel.Name = "chipsOptionsLabel";
            this.chipsOptionsLabel.Size = new System.Drawing.Size(141, 24);
            this.chipsOptionsLabel.TabIndex = 5;
            this.chipsOptionsLabel.Text = "Chips Options";
            // 
            // chipsCustomiseCheckBox
            // 
            this.chipsCustomiseCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chipsCustomiseCheckBox.FormattingEnabled = true;
            this.chipsCustomiseCheckBox.Items.AddRange(new object[] {
            "Salt",
            "Pepper",
            "Add Cheese (+£0.20)",
            "Ketchup Dip"});
            this.chipsCustomiseCheckBox.Location = new System.Drawing.Point(665, 106);
            this.chipsCustomiseCheckBox.Name = "chipsCustomiseCheckBox";
            this.chipsCustomiseCheckBox.Size = new System.Drawing.Size(425, 292);
            this.chipsCustomiseCheckBox.TabIndex = 6;
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
            this.backButton.TabIndex = 10;
            this.backButton.Text = "BACK";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // ChipsCustomiseScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 580);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.addToOrderButton);
            this.Controls.Add(this.chipsCustomiseCheckBox);
            this.Controls.Add(this.chipsOptionsLabel);
            this.Controls.Add(this.chipsPictureBox);
            this.Name = "ChipsCustomiseScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChipsCustomiseScreen";
            this.Load += new System.EventHandler(this.ChipsCustomiseScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chipsPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox chipsPictureBox;
        private System.Windows.Forms.Label chipsOptionsLabel;
        private System.Windows.Forms.CheckedListBox chipsCustomiseCheckBox;
        private System.Windows.Forms.Button addToOrderButton;
        private System.Windows.Forms.Button backButton;
    }
}