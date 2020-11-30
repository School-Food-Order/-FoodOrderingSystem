namespace test
{
    partial class TakeoutSelectionScreen
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
            this.eatInButton = new System.Windows.Forms.Button();
            this.takeOutButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tableNumberTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // eatInButton
            // 
            this.eatInButton.Location = new System.Drawing.Point(96, 173);
            this.eatInButton.Name = "eatInButton";
            this.eatInButton.Size = new System.Drawing.Size(267, 227);
            this.eatInButton.TabIndex = 0;
            this.eatInButton.Text = "Eat In";
            this.eatInButton.UseVisualStyleBackColor = true;
            this.eatInButton.Click += new System.EventHandler(this.eatInButton_Click);
            // 
            // takeOutButton
            // 
            this.takeOutButton.Location = new System.Drawing.Point(600, 159);
            this.takeOutButton.Name = "takeOutButton";
            this.takeOutButton.Size = new System.Drawing.Size(269, 227);
            this.takeOutButton.TabIndex = 1;
            this.takeOutButton.Text = "Take Out";
            this.takeOutButton.UseVisualStyleBackColor = true;
            this.takeOutButton.Click += new System.EventHandler(this.takeoutButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 420);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter your table number:";
            // 
            // tableNumberTextBox
            // 
            this.tableNumberTextBox.Location = new System.Drawing.Point(194, 417);
            this.tableNumberTextBox.Name = "tableNumberTextBox";
            this.tableNumberTextBox.Size = new System.Drawing.Size(169, 20);
            this.tableNumberTextBox.TabIndex = 3;
            // 
            // takeoutSelectionScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.tableNumberTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.takeOutButton);
            this.Controls.Add(this.eatInButton);
            this.Name = "takeoutSelectionScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Takeout or Eat In";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button eatInButton;
        private System.Windows.Forms.Button takeOutButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tableNumberTextBox;
    }
}