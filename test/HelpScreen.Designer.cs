namespace test
{
    partial class HelpScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpScreen));
            this.checkoutBackButton = new System.Windows.Forms.Button();
            this.helpRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // checkoutBackButton
            // 
            this.checkoutBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkoutBackButton.Location = new System.Drawing.Point(683, 436);
            this.checkoutBackButton.Name = "checkoutBackButton";
            this.checkoutBackButton.Size = new System.Drawing.Size(89, 37);
            this.checkoutBackButton.TabIndex = 6;
            this.checkoutBackButton.Text = "Back";
            this.checkoutBackButton.UseVisualStyleBackColor = true;
            this.checkoutBackButton.Click += new System.EventHandler(this.checkoutBackButton_Click);
            // 
            // helpRichTextBox
            // 
            this.helpRichTextBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.helpRichTextBox.Location = new System.Drawing.Point(12, 23);
            this.helpRichTextBox.Name = "helpRichTextBox";
            this.helpRichTextBox.ReadOnly = true;
            this.helpRichTextBox.Size = new System.Drawing.Size(600, 450);
            this.helpRichTextBox.TabIndex = 7;
            this.helpRichTextBox.Text = resources.GetString("helpRichTextBox.Text");
            // 
            // HelpScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 492);
            this.Controls.Add(this.helpRichTextBox);
            this.Controls.Add(this.checkoutBackButton);
            this.Name = "HelpScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HelpScreen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button checkoutBackButton;
        private System.Windows.Forms.RichTextBox helpRichTextBox;
    }
}