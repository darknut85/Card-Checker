
namespace Card_Checker
{
    partial class UpdateCard
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
            this.NewName = new System.Windows.Forms.Label();
            this.OldNameOfCard = new System.Windows.Forms.Label();
            this.NewSet = new System.Windows.Forms.Label();
            this.NewNumber = new System.Windows.Forms.Label();
            this.NewOwned = new System.Windows.Forms.Label();
            this.UpdateAllOfCard = new System.Windows.Forms.Button();
            this.CancelSetUpdate = new System.Windows.Forms.Button();
            this.UpdateNameOfCard = new System.Windows.Forms.TextBox();
            this.UpdateSetOfCard = new System.Windows.Forms.ComboBox();
            this.UpdateNumberOfCard = new System.Windows.Forms.TextBox();
            this.UpdateOwnedOfCard = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // NewName
            // 
            this.NewName.AutoSize = true;
            this.NewName.Location = new System.Drawing.Point(12, 35);
            this.NewName.Name = "NewName";
            this.NewName.Size = new System.Drawing.Size(38, 13);
            this.NewName.TabIndex = 0;
            this.NewName.Text = "Name:";
            // 
            // OldNameOfCard
            // 
            this.OldNameOfCard.AutoSize = true;
            this.OldNameOfCard.Location = new System.Drawing.Point(12, 9);
            this.OldNameOfCard.Name = "OldNameOfCard";
            this.OldNameOfCard.Size = new System.Drawing.Size(27, 13);
            this.OldNameOfCard.TabIndex = 1;
            this.OldNameOfCard.Text = "N/A";
            // 
            // NewSet
            // 
            this.NewSet.AutoSize = true;
            this.NewSet.Location = new System.Drawing.Point(12, 62);
            this.NewSet.Name = "NewSet";
            this.NewSet.Size = new System.Drawing.Size(26, 13);
            this.NewSet.TabIndex = 2;
            this.NewSet.Text = "Set:";
            // 
            // NewNumber
            // 
            this.NewNumber.AutoSize = true;
            this.NewNumber.Location = new System.Drawing.Point(12, 87);
            this.NewNumber.Name = "NewNumber";
            this.NewNumber.Size = new System.Drawing.Size(47, 13);
            this.NewNumber.TabIndex = 3;
            this.NewNumber.Text = "Number:";
            // 
            // NewOwned
            // 
            this.NewOwned.AutoSize = true;
            this.NewOwned.Location = new System.Drawing.Point(12, 113);
            this.NewOwned.Name = "NewOwned";
            this.NewOwned.Size = new System.Drawing.Size(41, 13);
            this.NewOwned.TabIndex = 4;
            this.NewOwned.Text = "Owned";
            // 
            // UpdateAllOfCard
            // 
            this.UpdateAllOfCard.Location = new System.Drawing.Point(12, 141);
            this.UpdateAllOfCard.Name = "UpdateAllOfCard";
            this.UpdateAllOfCard.Size = new System.Drawing.Size(75, 23);
            this.UpdateAllOfCard.TabIndex = 5;
            this.UpdateAllOfCard.Text = "Update";
            this.UpdateAllOfCard.UseVisualStyleBackColor = true;
            this.UpdateAllOfCard.Click += new System.EventHandler(this.UpdateAllOfCard_Click);
            // 
            // CancelSetUpdate
            // 
            this.CancelSetUpdate.Location = new System.Drawing.Point(93, 141);
            this.CancelSetUpdate.Name = "CancelSetUpdate";
            this.CancelSetUpdate.Size = new System.Drawing.Size(75, 23);
            this.CancelSetUpdate.TabIndex = 6;
            this.CancelSetUpdate.Text = "Cancel";
            this.CancelSetUpdate.UseVisualStyleBackColor = true;
            this.CancelSetUpdate.Click += new System.EventHandler(this.CancelSetUpdate_Click);
            // 
            // UpdateNameOfCard
            // 
            this.UpdateNameOfCard.Location = new System.Drawing.Point(68, 32);
            this.UpdateNameOfCard.Name = "UpdateNameOfCard";
            this.UpdateNameOfCard.Size = new System.Drawing.Size(239, 20);
            this.UpdateNameOfCard.TabIndex = 7;
            // 
            // UpdateSetOfCard
            // 
            this.UpdateSetOfCard.FormattingEnabled = true;
            this.UpdateSetOfCard.Location = new System.Drawing.Point(68, 59);
            this.UpdateSetOfCard.Name = "UpdateSetOfCard";
            this.UpdateSetOfCard.Size = new System.Drawing.Size(121, 21);
            this.UpdateSetOfCard.TabIndex = 8;
            // 
            // UpdateNumberOfCard
            // 
            this.UpdateNumberOfCard.Location = new System.Drawing.Point(68, 87);
            this.UpdateNumberOfCard.Name = "UpdateNumberOfCard";
            this.UpdateNumberOfCard.Size = new System.Drawing.Size(61, 20);
            this.UpdateNumberOfCard.TabIndex = 9;
            // 
            // UpdateOwnedOfCard
            // 
            this.UpdateOwnedOfCard.AutoSize = true;
            this.UpdateOwnedOfCard.Location = new System.Drawing.Point(68, 112);
            this.UpdateOwnedOfCard.Name = "UpdateOwnedOfCard";
            this.UpdateOwnedOfCard.Size = new System.Drawing.Size(15, 14);
            this.UpdateOwnedOfCard.TabIndex = 13;
            this.UpdateOwnedOfCard.UseVisualStyleBackColor = true;
            // 
            // UpdateCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 180);
            this.Controls.Add(this.UpdateOwnedOfCard);
            this.Controls.Add(this.UpdateNumberOfCard);
            this.Controls.Add(this.UpdateSetOfCard);
            this.Controls.Add(this.UpdateNameOfCard);
            this.Controls.Add(this.CancelSetUpdate);
            this.Controls.Add(this.UpdateAllOfCard);
            this.Controls.Add(this.NewOwned);
            this.Controls.Add(this.NewNumber);
            this.Controls.Add(this.NewSet);
            this.Controls.Add(this.OldNameOfCard);
            this.Controls.Add(this.NewName);
            this.Name = "UpdateCard";
            this.Text = "UpdateCard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UpdateCard_FormClosed);
            this.Load += new System.EventHandler(this.UpdateCard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NewName;
        private System.Windows.Forms.Label OldNameOfCard;
        private System.Windows.Forms.Label NewSet;
        private System.Windows.Forms.Label NewNumber;
        private System.Windows.Forms.Label NewOwned;
        private System.Windows.Forms.Button UpdateAllOfCard;
        private System.Windows.Forms.Button CancelSetUpdate;
        private System.Windows.Forms.TextBox UpdateNameOfCard;
        private System.Windows.Forms.ComboBox UpdateSetOfCard;
        private System.Windows.Forms.TextBox UpdateNumberOfCard;
        private System.Windows.Forms.CheckBox UpdateOwnedOfCard;
    }
}