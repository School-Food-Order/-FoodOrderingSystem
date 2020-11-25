namespace test
{
    partial class takeoutSelection
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
            this.takeoutButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tableNumberButton = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // eatInButton
            // 
            this.eatInButton.Location = new System.Drawing.Point(47, 103);
            this.eatInButton.Name = "eatInButton";
            this.eatInButton.Size = new System.Drawing.Size(267, 227);
            this.eatInButton.TabIndex = 0;
            this.eatInButton.Text = "Eat In";
            this.eatInButton.UseVisualStyleBackColor = true;
            this.eatInButton.Click += new System.EventHandler(this.eatInButton_Click);
            // 
            // takeoutButton
            // 
            this.takeoutButton.Location = new System.Drawing.Point(436, 103);
            this.takeoutButton.Name = "takeoutButton";
            this.takeoutButton.Size = new System.Drawing.Size(269, 227);
            this.takeoutButton.TabIndex = 1;
            this.takeoutButton.Text = "Take Out";
            this.takeoutButton.UseVisualStyleBackColor = true;
            this.takeoutButton.Click += new System.EventHandler(this.takeoutButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 355);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter your table number:";
            // 
            // tableNumberButton
            // 
            this.tableNumberButton.Location = new System.Drawing.Point(172, 352);
            this.tableNumberButton.Name = "tableNumberButton";
            this.tableNumberButton.Size = new System.Drawing.Size(100, 20);
            this.tableNumberButton.TabIndex = 3;
            // 
            // takeoutSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableNumberButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.takeoutButton);
            this.Controls.Add(this.eatInButton);
            this.Name = "takeoutSelection";
            this.Text = "Takeout or Eat In";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button eatInButton;
        private System.Windows.Forms.Button takeoutButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tableNumberButton;
    }
}