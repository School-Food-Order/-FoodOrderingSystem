﻿namespace test
{
    partial class KitchenLiveOrderScreen
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
            this.preparingListBox = new System.Windows.Forms.ListBox();
            this.preparingLabel = new System.Windows.Forms.Label();
            this.foodReadyListBox = new System.Windows.Forms.ListBox();
            this.collectionReadyLabel = new System.Windows.Forms.Label();
            this.rdyCollectionButton = new System.Windows.Forms.Button();
            this.orderDetailsPanel = new System.Windows.Forms.Panel();
            this.orderDetailsTextBox = new System.Windows.Forms.TextBox();
            this.orderDetailsLabel = new System.Windows.Forms.Label();
            this.showDetailsButton = new System.Windows.Forms.Button();
            this.showRdyDetailsButton = new System.Windows.Forms.Button();
            this.orderDetailsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // preparingListBox
            // 
            this.preparingListBox.FormattingEnabled = true;
            this.preparingListBox.Location = new System.Drawing.Point(21, 144);
            this.preparingListBox.Name = "preparingListBox";
            this.preparingListBox.Size = new System.Drawing.Size(269, 550);
            this.preparingListBox.TabIndex = 0;
            // 
            // preparingLabel
            // 
            this.preparingLabel.AutoSize = true;
            this.preparingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preparingLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.preparingLabel.Location = new System.Drawing.Point(39, 99);
            this.preparingLabel.Name = "preparingLabel";
            this.preparingLabel.Size = new System.Drawing.Size(141, 33);
            this.preparingLabel.TabIndex = 1;
            this.preparingLabel.Text = "Preparing";
            // 
            // foodReadyListBox
            // 
            this.foodReadyListBox.FormattingEnabled = true;
            this.foodReadyListBox.Location = new System.Drawing.Point(844, 138);
            this.foodReadyListBox.Name = "foodReadyListBox";
            this.foodReadyListBox.Size = new System.Drawing.Size(330, 550);
            this.foodReadyListBox.TabIndex = 2;
            // 
            // collectionReadyLabel
            // 
            this.collectionReadyLabel.AutoSize = true;
            this.collectionReadyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.collectionReadyLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.collectionReadyLabel.Location = new System.Drawing.Point(865, 99);
            this.collectionReadyLabel.Name = "collectionReadyLabel";
            this.collectionReadyLabel.Size = new System.Drawing.Size(288, 33);
            this.collectionReadyLabel.TabIndex = 3;
            this.collectionReadyLabel.Text = "Ready For Collection";
            // 
            // rdyCollectionButton
            // 
            this.rdyCollectionButton.Location = new System.Drawing.Point(742, 144);
            this.rdyCollectionButton.Name = "rdyCollectionButton";
            this.rdyCollectionButton.Size = new System.Drawing.Size(75, 67);
            this.rdyCollectionButton.TabIndex = 6;
            this.rdyCollectionButton.Text = ">";
            this.rdyCollectionButton.UseVisualStyleBackColor = true;
            this.rdyCollectionButton.Click += new System.EventHandler(this.rdyCollectionButton_Click);
            // 
            // orderDetailsPanel
            // 
            this.orderDetailsPanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.orderDetailsPanel.Controls.Add(this.orderDetailsTextBox);
            this.orderDetailsPanel.Location = new System.Drawing.Point(433, 99);
            this.orderDetailsPanel.Name = "orderDetailsPanel";
            this.orderDetailsPanel.Size = new System.Drawing.Size(292, 595);
            this.orderDetailsPanel.TabIndex = 10;
            // 
            // orderDetailsTextBox
            // 
            this.orderDetailsTextBox.Location = new System.Drawing.Point(18, 13);
            this.orderDetailsTextBox.Multiline = true;
            this.orderDetailsTextBox.Name = "orderDetailsTextBox";
            this.orderDetailsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.orderDetailsTextBox.Size = new System.Drawing.Size(259, 566);
            this.orderDetailsTextBox.TabIndex = 0;
            // 
            // orderDetailsLabel
            // 
            this.orderDetailsLabel.AutoSize = true;
            this.orderDetailsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderDetailsLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.orderDetailsLabel.Location = new System.Drawing.Point(445, 49);
            this.orderDetailsLabel.Name = "orderDetailsLabel";
            this.orderDetailsLabel.Size = new System.Drawing.Size(188, 33);
            this.orderDetailsLabel.TabIndex = 11;
            this.orderDetailsLabel.Text = "Order Details";
            // 
            // showDetailsButton
            // 
            this.showDetailsButton.Location = new System.Drawing.Point(321, 217);
            this.showDetailsButton.Name = "showDetailsButton";
            this.showDetailsButton.Size = new System.Drawing.Size(82, 81);
            this.showDetailsButton.TabIndex = 12;
            this.showDetailsButton.Text = "Show Details";
            this.showDetailsButton.UseVisualStyleBackColor = true;
            this.showDetailsButton.Click += new System.EventHandler(this.showDetailsButton_Click);
            // 
            // showRdyDetailsButton
            // 
            this.showRdyDetailsButton.Location = new System.Drawing.Point(1218, 244);
            this.showRdyDetailsButton.Name = "showRdyDetailsButton";
            this.showRdyDetailsButton.Size = new System.Drawing.Size(82, 81);
            this.showRdyDetailsButton.TabIndex = 13;
            this.showRdyDetailsButton.Text = "Show Details";
            this.showRdyDetailsButton.UseVisualStyleBackColor = true;
            this.showRdyDetailsButton.Click += new System.EventHandler(this.showRdyDetailsButton_Click);
            // 
            // KitchenLiveOrderScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1501, 761);
            this.Controls.Add(this.showRdyDetailsButton);
            this.Controls.Add(this.showDetailsButton);
            this.Controls.Add(this.orderDetailsLabel);
            this.Controls.Add(this.orderDetailsPanel);
            this.Controls.Add(this.rdyCollectionButton);
            this.Controls.Add(this.collectionReadyLabel);
            this.Controls.Add(this.foodReadyListBox);
            this.Controls.Add(this.preparingLabel);
            this.Controls.Add(this.preparingListBox);
            this.Name = "KitchenLiveOrderScreen";
            this.Text = "KitchenLiveOrderScreen";
            this.Load += new System.EventHandler(this.KitchenLiveOrderScreen_Load);
            this.orderDetailsPanel.ResumeLayout(false);
            this.orderDetailsPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox preparingListBox;
        private System.Windows.Forms.Label preparingLabel;
        private System.Windows.Forms.ListBox foodReadyListBox;
        private System.Windows.Forms.Label collectionReadyLabel;
        private System.Windows.Forms.Button rdyCollectionButton;
        private System.Windows.Forms.Panel orderDetailsPanel;
        private System.Windows.Forms.Label orderDetailsLabel;
        private System.Windows.Forms.TextBox orderDetailsTextBox;
        private System.Windows.Forms.Button showDetailsButton;
        private System.Windows.Forms.Button showRdyDetailsButton;
    }
}