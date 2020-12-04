namespace test
{
    partial class CustomerLiveOrderScreen
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
            this.CustomerLOScreen_Preparing = new System.Windows.Forms.Button();
            this.CustomerLOScreen_Collect = new System.Windows.Forms.Button();
            this.pleaseCollectListbox = new System.Windows.Forms.ListBox();
            this.preparingOrderListBox = new System.Windows.Forms.ListBox();
            this.burgerPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.burgerPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomerLOScreen_Preparing
            // 
            this.CustomerLOScreen_Preparing.BackColor = System.Drawing.Color.LightSlateGray;
            this.CustomerLOScreen_Preparing.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerLOScreen_Preparing.Location = new System.Drawing.Point(12, 12);
            this.CustomerLOScreen_Preparing.Name = "CustomerLOScreen_Preparing";
            this.CustomerLOScreen_Preparing.Size = new System.Drawing.Size(500, 40);
            this.CustomerLOScreen_Preparing.TabIndex = 2;
            this.CustomerLOScreen_Preparing.Text = "PREPARING...";
            this.CustomerLOScreen_Preparing.UseVisualStyleBackColor = false;
            // 
            // CustomerLOScreen_Collect
            // 
            this.CustomerLOScreen_Collect.BackColor = System.Drawing.Color.Green;
            this.CustomerLOScreen_Collect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerLOScreen_Collect.Location = new System.Drawing.Point(587, 12);
            this.CustomerLOScreen_Collect.Name = "CustomerLOScreen_Collect";
            this.CustomerLOScreen_Collect.Size = new System.Drawing.Size(500, 40);
            this.CustomerLOScreen_Collect.TabIndex = 3;
            this.CustomerLOScreen_Collect.Text = "PLEASE COLLECT";
            this.CustomerLOScreen_Collect.UseVisualStyleBackColor = false;
            // 
            // pleaseCollectListbox
            // 
            this.pleaseCollectListbox.FormattingEnabled = true;
            this.pleaseCollectListbox.Location = new System.Drawing.Point(587, 58);
            this.pleaseCollectListbox.Name = "pleaseCollectListbox";
            this.pleaseCollectListbox.Size = new System.Drawing.Size(500, 563);
            this.pleaseCollectListbox.TabIndex = 4;
            // 
            // preparingOrderListBox
            // 
            this.preparingOrderListBox.FormattingEnabled = true;
            this.preparingOrderListBox.Location = new System.Drawing.Point(12, 58);
            this.preparingOrderListBox.Name = "preparingOrderListBox";
            this.preparingOrderListBox.Size = new System.Drawing.Size(500, 563);
            this.preparingOrderListBox.TabIndex = 5;
            // 
            // burgerPictureBox
            // 
            this.burgerPictureBox.Image = global::test.Properties.Resources.iconHappyGuy;
            this.burgerPictureBox.Location = new System.Drawing.Point(1181, 344);
            this.burgerPictureBox.Name = "burgerPictureBox";
            this.burgerPictureBox.Size = new System.Drawing.Size(251, 254);
            this.burgerPictureBox.TabIndex = 6;
            this.burgerPictureBox.TabStop = false;
            // 
            // CustomerLiveOrderScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1450, 647);
            this.Controls.Add(this.burgerPictureBox);
            this.Controls.Add(this.preparingOrderListBox);
            this.Controls.Add(this.pleaseCollectListbox);
            this.Controls.Add(this.CustomerLOScreen_Collect);
            this.Controls.Add(this.CustomerLOScreen_Preparing);
            this.Name = "CustomerLiveOrderScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerLiveOrderScreen";
            ((System.ComponentModel.ISupportInitialize)(this.burgerPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CustomerLOScreen_Preparing;
        private System.Windows.Forms.Button CustomerLOScreen_Collect;
        private System.Windows.Forms.ListBox pleaseCollectListbox;
        private System.Windows.Forms.ListBox preparingOrderListBox;
        private System.Windows.Forms.PictureBox burgerPictureBox;
    }
}