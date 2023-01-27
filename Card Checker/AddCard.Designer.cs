
namespace Card_Checker
{
    partial class AddCard
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
            this.CancelThisCard = new System.Windows.Forms.Button();
            this.AddThisCard = new System.Windows.Forms.Button();
            this.CardnameLabel = new System.Windows.Forms.Label();
            this.SetDropLabel = new System.Windows.Forms.Label();
            this.CardNumberLabel = new System.Windows.Forms.Label();
            this.OwnedLabel = new System.Windows.Forms.Label();
            this.CardNameText = new System.Windows.Forms.TextBox();
            this.CBSets = new System.Windows.Forms.ComboBox();
            this.TBNumber = new System.Windows.Forms.TextBox();
            this.OwnedCheckbox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // CancelThisCard
            // 
            this.CancelThisCard.Location = new System.Drawing.Point(93, 101);
            this.CancelThisCard.Name = "CancelThisCard";
            this.CancelThisCard.Size = new System.Drawing.Size(75, 23);
            this.CancelThisCard.TabIndex = 3;
            this.CancelThisCard.Text = "Cancel";
            this.CancelThisCard.UseVisualStyleBackColor = true;
            this.CancelThisCard.Click += new System.EventHandler(this.CancelThisCard_Click);
            // 
            // AddThisCard
            // 
            this.AddThisCard.Location = new System.Drawing.Point(12, 101);
            this.AddThisCard.Name = "AddThisCard";
            this.AddThisCard.Size = new System.Drawing.Size(75, 23);
            this.AddThisCard.TabIndex = 2;
            this.AddThisCard.Text = "Add";
            this.AddThisCard.UseVisualStyleBackColor = true;
            this.AddThisCard.Click += new System.EventHandler(this.AddThisCard_Click);
            // 
            // CardnameLabel
            // 
            this.CardnameLabel.AutoSize = true;
            this.CardnameLabel.Location = new System.Drawing.Point(12, 9);
            this.CardnameLabel.Name = "CardnameLabel";
            this.CardnameLabel.Size = new System.Drawing.Size(38, 13);
            this.CardnameLabel.TabIndex = 4;
            this.CardnameLabel.Text = "Name:";
            // 
            // SetDropLabel
            // 
            this.SetDropLabel.AutoSize = true;
            this.SetDropLabel.Location = new System.Drawing.Point(12, 34);
            this.SetDropLabel.Name = "SetDropLabel";
            this.SetDropLabel.Size = new System.Drawing.Size(26, 13);
            this.SetDropLabel.TabIndex = 5;
            this.SetDropLabel.Text = "Set:";
            // 
            // CardNumberLabel
            // 
            this.CardNumberLabel.AutoSize = true;
            this.CardNumberLabel.Location = new System.Drawing.Point(12, 61);
            this.CardNumberLabel.Name = "CardNumberLabel";
            this.CardNumberLabel.Size = new System.Drawing.Size(47, 13);
            this.CardNumberLabel.TabIndex = 6;
            this.CardNumberLabel.Text = "Number:";
            // 
            // OwnedLabel
            // 
            this.OwnedLabel.AutoSize = true;
            this.OwnedLabel.Location = new System.Drawing.Point(12, 82);
            this.OwnedLabel.Name = "OwnedLabel";
            this.OwnedLabel.Size = new System.Drawing.Size(44, 13);
            this.OwnedLabel.TabIndex = 7;
            this.OwnedLabel.Text = "Owned:";
            // 
            // CardNameText
            // 
            this.CardNameText.Location = new System.Drawing.Point(68, 6);
            this.CardNameText.Name = "CardNameText";
            this.CardNameText.Size = new System.Drawing.Size(213, 20);
            this.CardNameText.TabIndex = 8;
            // 
            // CBSets
            // 
            this.CBSets.FormattingEnabled = true;
            this.CBSets.Location = new System.Drawing.Point(68, 31);
            this.CBSets.Name = "CBSets";
            this.CBSets.Size = new System.Drawing.Size(213, 21);
            this.CBSets.TabIndex = 9;
            // 
            // TBNumber
            // 
            this.TBNumber.Location = new System.Drawing.Point(68, 58);
            this.TBNumber.Name = "TBNumber";
            this.TBNumber.Size = new System.Drawing.Size(100, 20);
            this.TBNumber.TabIndex = 10;
            // 
            // OwnedCheckbox
            // 
            this.OwnedCheckbox.AutoSize = true;
            this.OwnedCheckbox.Location = new System.Drawing.Point(68, 84);
            this.OwnedCheckbox.Name = "OwnedCheckbox";
            this.OwnedCheckbox.Size = new System.Drawing.Size(15, 14);
            this.OwnedCheckbox.TabIndex = 12;
            this.OwnedCheckbox.UseVisualStyleBackColor = true;
            // 
            // AddCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 131);
            this.Controls.Add(this.OwnedCheckbox);
            this.Controls.Add(this.TBNumber);
            this.Controls.Add(this.CBSets);
            this.Controls.Add(this.CardNameText);
            this.Controls.Add(this.OwnedLabel);
            this.Controls.Add(this.CardNumberLabel);
            this.Controls.Add(this.SetDropLabel);
            this.Controls.Add(this.CardnameLabel);
            this.Controls.Add(this.CancelThisCard);
            this.Controls.Add(this.AddThisCard);
            this.Name = "AddCard";
            this.Text = "AddCard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddCard_FormClosed);
            this.Load += new System.EventHandler(this.AddCard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelThisCard;
        private System.Windows.Forms.Button AddThisCard;
        private System.Windows.Forms.Label CardnameLabel;
        private System.Windows.Forms.Label SetDropLabel;
        private System.Windows.Forms.Label CardNumberLabel;
        private System.Windows.Forms.Label OwnedLabel;
        private System.Windows.Forms.TextBox CardNameText;
        private System.Windows.Forms.ComboBox CBSets;
        private System.Windows.Forms.TextBox TBNumber;
        private System.Windows.Forms.CheckBox OwnedCheckbox;
    }
}