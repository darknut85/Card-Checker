
namespace Card_Checker
{
    partial class Form1
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
            this.Sets = new System.Windows.Forms.ListBox();
            this.TotalInSet = new System.Windows.Forms.ListBox();
            this.AddSet = new System.Windows.Forms.Button();
            this.AddCard = new System.Windows.Forms.Button();
            this.SearchSet = new System.Windows.Forms.TextBox();
            this.SearchCard = new System.Windows.Forms.TextBox();
            this.CardName = new System.Windows.Forms.Label();
            this.SetName = new System.Windows.Forms.Label();
            this.Number = new System.Windows.Forms.Label();
            this.HasCard = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.SetLabel = new System.Windows.Forms.Label();
            this.NumberLabel = new System.Windows.Forms.Label();
            this.HasCardLabel = new System.Windows.Forms.Label();
            this.DeleteSet = new System.Windows.Forms.Button();
            this.DeleteCard = new System.Windows.Forms.Button();
            this.UpdateCard = new System.Windows.Forms.Button();
            this.UpdateSet = new System.Windows.Forms.Button();
            this.ReleaseDate = new System.Windows.Forms.Label();
            this.ReleaseDateLabel = new System.Windows.Forms.Label();
            this.Collection = new System.Windows.Forms.Label();
            this.OwnedOfTotal = new System.Windows.Forms.Label();
            this.slash = new System.Windows.Forms.Label();
            this.InSetLabel = new System.Windows.Forms.Label();
            this.CheckOwned = new System.Windows.Forms.CheckBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // Sets
            // 
            this.Sets.FormattingEnabled = true;
            this.Sets.Location = new System.Drawing.Point(12, 44);
            this.Sets.Name = "Sets";
            this.Sets.Size = new System.Drawing.Size(239, 394);
            this.Sets.TabIndex = 0;
            this.Sets.SelectedIndexChanged += new System.EventHandler(this.Sets_SelectedIndexChanged);
            // 
            // TotalInSet
            // 
            this.TotalInSet.FormattingEnabled = true;
            this.TotalInSet.Location = new System.Drawing.Point(257, 44);
            this.TotalInSet.Name = "TotalInSet";
            this.TotalInSet.Size = new System.Drawing.Size(237, 394);
            this.TotalInSet.TabIndex = 1;
            this.TotalInSet.SelectedIndexChanged += new System.EventHandler(this.CardsOfSet_SelectedIndexChanged);
            this.TotalInSet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TotalInSet_KeyPress);
            // 
            // AddSet
            // 
            this.AddSet.Location = new System.Drawing.Point(13, 15);
            this.AddSet.Name = "AddSet";
            this.AddSet.Size = new System.Drawing.Size(75, 23);
            this.AddSet.TabIndex = 2;
            this.AddSet.Text = "Add Set";
            this.AddSet.UseVisualStyleBackColor = true;
            this.AddSet.Click += new System.EventHandler(this.AddSet_Click);
            // 
            // AddCard
            // 
            this.AddCard.Location = new System.Drawing.Point(257, 15);
            this.AddCard.Name = "AddCard";
            this.AddCard.Size = new System.Drawing.Size(75, 23);
            this.AddCard.TabIndex = 3;
            this.AddCard.Text = "Add Card";
            this.AddCard.UseVisualStyleBackColor = true;
            this.AddCard.Click += new System.EventHandler(this.AddCard_Click);
            // 
            // SearchSet
            // 
            this.SearchSet.Location = new System.Drawing.Point(12, 444);
            this.SearchSet.Name = "SearchSet";
            this.SearchSet.Size = new System.Drawing.Size(239, 20);
            this.SearchSet.TabIndex = 4;
            this.SearchSet.TextChanged += new System.EventHandler(this.SearchSet_TextChanged);
            // 
            // SearchCard
            // 
            this.SearchCard.Location = new System.Drawing.Point(257, 444);
            this.SearchCard.Name = "SearchCard";
            this.SearchCard.Size = new System.Drawing.Size(237, 20);
            this.SearchCard.TabIndex = 5;
            this.SearchCard.TextChanged += new System.EventHandler(this.SearchCard_TextChanged);
            // 
            // CardName
            // 
            this.CardName.AutoSize = true;
            this.CardName.Location = new System.Drawing.Point(500, 43);
            this.CardName.Name = "CardName";
            this.CardName.Size = new System.Drawing.Size(32, 13);
            this.CardName.TabIndex = 6;
            this.CardName.Text = "Card:";
            // 
            // SetName
            // 
            this.SetName.AutoSize = true;
            this.SetName.Location = new System.Drawing.Point(500, 65);
            this.SetName.Name = "SetName";
            this.SetName.Size = new System.Drawing.Size(26, 13);
            this.SetName.TabIndex = 7;
            this.SetName.Text = "Set:";
            // 
            // Number
            // 
            this.Number.AutoSize = true;
            this.Number.Location = new System.Drawing.Point(500, 88);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(47, 13);
            this.Number.TabIndex = 8;
            this.Number.Text = "Number:";
            // 
            // HasCard
            // 
            this.HasCard.AutoSize = true;
            this.HasCard.Location = new System.Drawing.Point(500, 112);
            this.HasCard.Name = "HasCard";
            this.HasCard.Size = new System.Drawing.Size(44, 13);
            this.HasCard.TabIndex = 9;
            this.HasCard.Text = "Owned:";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(541, 43);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(27, 13);
            this.NameLabel.TabIndex = 10;
            this.NameLabel.Text = "N/A";
            // 
            // SetLabel
            // 
            this.SetLabel.AutoSize = true;
            this.SetLabel.Location = new System.Drawing.Point(541, 65);
            this.SetLabel.Name = "SetLabel";
            this.SetLabel.Size = new System.Drawing.Size(27, 13);
            this.SetLabel.TabIndex = 11;
            this.SetLabel.Text = "N/A";
            // 
            // NumberLabel
            // 
            this.NumberLabel.AutoSize = true;
            this.NumberLabel.Location = new System.Drawing.Point(541, 88);
            this.NumberLabel.Name = "NumberLabel";
            this.NumberLabel.Size = new System.Drawing.Size(27, 13);
            this.NumberLabel.TabIndex = 12;
            this.NumberLabel.Text = "N/A";
            // 
            // HasCardLabel
            // 
            this.HasCardLabel.AutoSize = true;
            this.HasCardLabel.Location = new System.Drawing.Point(541, 112);
            this.HasCardLabel.Name = "HasCardLabel";
            this.HasCardLabel.Size = new System.Drawing.Size(32, 13);
            this.HasCardLabel.TabIndex = 13;
            this.HasCardLabel.Text = "False";
            // 
            // DeleteSet
            // 
            this.DeleteSet.Location = new System.Drawing.Point(176, 15);
            this.DeleteSet.Name = "DeleteSet";
            this.DeleteSet.Size = new System.Drawing.Size(75, 23);
            this.DeleteSet.TabIndex = 14;
            this.DeleteSet.Text = "Delete Set";
            this.DeleteSet.UseVisualStyleBackColor = true;
            this.DeleteSet.Click += new System.EventHandler(this.DeleteSet_Click);
            // 
            // DeleteCard
            // 
            this.DeleteCard.Location = new System.Drawing.Point(419, 15);
            this.DeleteCard.Name = "DeleteCard";
            this.DeleteCard.Size = new System.Drawing.Size(75, 23);
            this.DeleteCard.TabIndex = 15;
            this.DeleteCard.Text = "Delete Card";
            this.DeleteCard.UseVisualStyleBackColor = true;
            this.DeleteCard.Click += new System.EventHandler(this.DeleteCard_Click);
            // 
            // UpdateCard
            // 
            this.UpdateCard.Location = new System.Drawing.Point(338, 15);
            this.UpdateCard.Name = "UpdateCard";
            this.UpdateCard.Size = new System.Drawing.Size(75, 23);
            this.UpdateCard.TabIndex = 16;
            this.UpdateCard.Text = "Update Card";
            this.UpdateCard.UseVisualStyleBackColor = true;
            this.UpdateCard.Click += new System.EventHandler(this.UpdateCard_Click);
            // 
            // UpdateSet
            // 
            this.UpdateSet.Location = new System.Drawing.Point(94, 15);
            this.UpdateSet.Name = "UpdateSet";
            this.UpdateSet.Size = new System.Drawing.Size(76, 23);
            this.UpdateSet.TabIndex = 17;
            this.UpdateSet.Text = "Update Set";
            this.UpdateSet.UseVisualStyleBackColor = true;
            this.UpdateSet.Click += new System.EventHandler(this.UpdateSet_Click);
            // 
            // ReleaseDate
            // 
            this.ReleaseDate.AutoSize = true;
            this.ReleaseDate.Location = new System.Drawing.Point(500, 134);
            this.ReleaseDate.Name = "ReleaseDate";
            this.ReleaseDate.Size = new System.Drawing.Size(75, 13);
            this.ReleaseDate.TabIndex = 18;
            this.ReleaseDate.Text = "Release Date:";
            // 
            // ReleaseDateLabel
            // 
            this.ReleaseDateLabel.AutoSize = true;
            this.ReleaseDateLabel.Location = new System.Drawing.Point(581, 134);
            this.ReleaseDateLabel.Name = "ReleaseDateLabel";
            this.ReleaseDateLabel.Size = new System.Drawing.Size(27, 13);
            this.ReleaseDateLabel.TabIndex = 19;
            this.ReleaseDateLabel.Text = "N/A";
            // 
            // Collection
            // 
            this.Collection.AutoSize = true;
            this.Collection.Location = new System.Drawing.Point(500, 157);
            this.Collection.Name = "Collection";
            this.Collection.Size = new System.Drawing.Size(56, 13);
            this.Collection.TabIndex = 20;
            this.Collection.Text = "Collection:";
            // 
            // OwnedOfTotal
            // 
            this.OwnedOfTotal.AutoSize = true;
            this.OwnedOfTotal.Location = new System.Drawing.Point(562, 157);
            this.OwnedOfTotal.Name = "OwnedOfTotal";
            this.OwnedOfTotal.Size = new System.Drawing.Size(13, 13);
            this.OwnedOfTotal.TabIndex = 21;
            this.OwnedOfTotal.Text = "0";
            // 
            // slash
            // 
            this.slash.AutoSize = true;
            this.slash.Location = new System.Drawing.Point(592, 157);
            this.slash.Name = "slash";
            this.slash.Size = new System.Drawing.Size(12, 13);
            this.slash.TabIndex = 22;
            this.slash.Text = "/";
            // 
            // InSetLabel
            // 
            this.InSetLabel.AutoSize = true;
            this.InSetLabel.Location = new System.Drawing.Point(624, 157);
            this.InSetLabel.Name = "InSetLabel";
            this.InSetLabel.Size = new System.Drawing.Size(13, 13);
            this.InSetLabel.TabIndex = 23;
            this.InSetLabel.Text = "0";
            // 
            // CheckOwned
            // 
            this.CheckOwned.AutoSize = true;
            this.CheckOwned.Location = new System.Drawing.Point(579, 111);
            this.CheckOwned.Name = "CheckOwned";
            this.CheckOwned.Size = new System.Drawing.Size(15, 14);
            this.CheckOwned.TabIndex = 24;
            this.CheckOwned.UseVisualStyleBackColor = true;
            this.CheckOwned.CheckedChanged += new System.EventHandler(this.CheckOwned_CheckedChanged);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(500, 173);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(498, 265);
            this.listView1.TabIndex = 25;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 489);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.CheckOwned);
            this.Controls.Add(this.InSetLabel);
            this.Controls.Add(this.slash);
            this.Controls.Add(this.OwnedOfTotal);
            this.Controls.Add(this.Collection);
            this.Controls.Add(this.ReleaseDateLabel);
            this.Controls.Add(this.ReleaseDate);
            this.Controls.Add(this.UpdateSet);
            this.Controls.Add(this.UpdateCard);
            this.Controls.Add(this.DeleteCard);
            this.Controls.Add(this.DeleteSet);
            this.Controls.Add(this.HasCardLabel);
            this.Controls.Add(this.NumberLabel);
            this.Controls.Add(this.SetLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.HasCard);
            this.Controls.Add(this.Number);
            this.Controls.Add(this.SetName);
            this.Controls.Add(this.CardName);
            this.Controls.Add(this.SearchCard);
            this.Controls.Add(this.SearchSet);
            this.Controls.Add(this.AddCard);
            this.Controls.Add(this.AddSet);
            this.Controls.Add(this.TotalInSet);
            this.Controls.Add(this.Sets);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Sets;
        private System.Windows.Forms.ListBox TotalInSet;
        private System.Windows.Forms.Button AddSet;
        private System.Windows.Forms.Button AddCard;
        private System.Windows.Forms.TextBox SearchSet;
        private System.Windows.Forms.TextBox SearchCard;
        private System.Windows.Forms.Label CardName;
        private System.Windows.Forms.Label SetName;
        private System.Windows.Forms.Label Number;
        private System.Windows.Forms.Label HasCard;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label SetLabel;
        private System.Windows.Forms.Label NumberLabel;
        private System.Windows.Forms.Label HasCardLabel;
        private System.Windows.Forms.Button DeleteSet;
        private System.Windows.Forms.Button DeleteCard;
        private System.Windows.Forms.Button UpdateCard;
        private System.Windows.Forms.Button UpdateSet;
        private System.Windows.Forms.Label ReleaseDate;
        private System.Windows.Forms.Label ReleaseDateLabel;
        private System.Windows.Forms.Label Collection;
        private System.Windows.Forms.Label OwnedOfTotal;
        private System.Windows.Forms.Label slash;
        private System.Windows.Forms.Label InSetLabel;
        private System.Windows.Forms.CheckBox CheckOwned;
        private System.Windows.Forms.ListView listView1;
    }
}

