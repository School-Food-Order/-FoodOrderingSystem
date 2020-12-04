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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TakeoutSelectionScreen));
            this.eatInButton = new System.Windows.Forms.Button();
            this.takeOutButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tableNumberTextBox = new System.Windows.Forms.TextBox();
            this.helpButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // eatInButton
            // 
            this.eatInButton.BackColor = System.Drawing.Color.Pink;
            this.eatInButton.Image = ((System.Drawing.Image)(resources.GetObject("eatInButton.Image")));
            this.eatInButton.Location = new System.Drawing.Point(23, 32);
            this.eatInButton.Name = "eatInButton";
            this.eatInButton.Size = new System.Drawing.Size(525, 525);
            this.eatInButton.TabIndex = 0;
            this.eatInButton.UseVisualStyleBackColor = false;
            this.eatInButton.Click += new System.EventHandler(this.eatInButton_Click);
            // 
            // takeOutButton
            // 
            this.takeOutButton.BackColor = System.Drawing.Color.Pink;
            this.takeOutButton.Image = ((System.Drawing.Image)(resources.GetObject("takeOutButton.Image")));
            this.takeOutButton.Location = new System.Drawing.Point(615, 32);
            this.takeOutButton.Name = "takeOutButton";
            this.takeOutButton.Size = new System.Drawing.Size(525, 525);
            this.takeOutButton.TabIndex = 1;
            this.takeOutButton.UseVisualStyleBackColor = false;
            this.takeOutButton.Click += new System.EventHandler(this.takeoutButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 587);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter your table number:";
            // 
            // tableNumberTextBox
            // 
            this.tableNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableNumberTextBox.Location = new System.Drawing.Point(407, 587);
            this.tableNumberTextBox.Name = "tableNumberTextBox";
            this.tableNumberTextBox.Size = new System.Drawing.Size(140, 40);
            this.tableNumberTextBox.TabIndex = 3;
            // 
            // helpButton
            // 
            this.helpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpButton.Location = new System.Drawing.Point(1050, 587);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(90, 40);
            this.helpButton.TabIndex = 7;
            this.helpButton.Text = "Help";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // TakeoutSelectionScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.tableNumberTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.takeOutButton);
            this.Controls.Add(this.eatInButton);
            this.Name = "TakeoutSelectionScreen";
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
        private System.Windows.Forms.Button helpButton;
    }
}