
namespace Card_Checker
{
    partial class UpdateSet
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
            this.OldName = new System.Windows.Forms.Label();
            this.NewName = new System.Windows.Forms.Label();
            this.UpdateText = new System.Windows.Forms.TextBox();
            this.NameOfSet = new System.Windows.Forms.Label();
            this.UpdateNameOfSet = new System.Windows.Forms.Button();
            this.CancelNewName = new System.Windows.Forms.Button();
            this.NewRelease = new System.Windows.Forms.Label();
            this.UpdateRelease = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // OldName
            // 
            this.OldName.AutoSize = true;
            this.OldName.Location = new System.Drawing.Point(12, 9);
            this.OldName.Name = "OldName";
            this.OldName.Size = new System.Drawing.Size(57, 13);
            this.OldName.TabIndex = 0;
            this.OldName.Text = "Old Name:";
            // 
            // NewName
            // 
            this.NewName.AutoSize = true;
            this.NewName.Location = new System.Drawing.Point(12, 37);
            this.NewName.Name = "NewName";
            this.NewName.Size = new System.Drawing.Size(63, 13);
            this.NewName.TabIndex = 1;
            this.NewName.Text = "New Name:";
            // 
            // UpdateText
            // 
            this.UpdateText.Location = new System.Drawing.Point(96, 34);
            this.UpdateText.Name = "UpdateText";
            this.UpdateText.Size = new System.Drawing.Size(210, 20);
            this.UpdateText.TabIndex = 3;
            // 
            // NameOfSet
            // 
            this.NameOfSet.AutoSize = true;
            this.NameOfSet.Location = new System.Drawing.Point(75, 9);
            this.NameOfSet.Name = "NameOfSet";
            this.NameOfSet.Size = new System.Drawing.Size(27, 13);
            this.NameOfSet.TabIndex = 4;
            this.NameOfSet.Text = "N/A";
            // 
            // UpdateNameOfSet
            // 
            this.UpdateNameOfSet.Location = new System.Drawing.Point(15, 86);
            this.UpdateNameOfSet.Name = "UpdateNameOfSet";
            this.UpdateNameOfSet.Size = new System.Drawing.Size(75, 23);
            this.UpdateNameOfSet.TabIndex = 5;
            this.UpdateNameOfSet.Text = "Update";
            this.UpdateNameOfSet.UseVisualStyleBackColor = true;
            this.UpdateNameOfSet.Click += new System.EventHandler(this.UpdateNameOfSet_Click);
            // 
            // CancelNewName
            // 
            this.CancelNewName.Location = new System.Drawing.Point(96, 86);
            this.CancelNewName.Name = "CancelNewName";
            this.CancelNewName.Size = new System.Drawing.Size(75, 23);
            this.CancelNewName.TabIndex = 6;
            this.CancelNewName.Text = "Cancel";
            this.CancelNewName.UseVisualStyleBackColor = true;
            this.CancelNewName.Click += new System.EventHandler(this.CancelNewName_Click);
            // 
            // NewRelease
            // 
            this.NewRelease.AutoSize = true;
            this.NewRelease.Location = new System.Drawing.Point(12, 63);
            this.NewRelease.Name = "NewRelease";
            this.NewRelease.Size = new System.Drawing.Size(75, 13);
            this.NewRelease.TabIndex = 7;
            this.NewRelease.Text = "Release Date:";
            // 
            // UpdateRelease
            // 
            this.UpdateRelease.Location = new System.Drawing.Point(96, 60);
            this.UpdateRelease.Name = "UpdateRelease";
            this.UpdateRelease.Size = new System.Drawing.Size(210, 20);
            this.UpdateRelease.TabIndex = 8;
            // 
            // UpdateSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 116);
            this.Controls.Add(this.UpdateRelease);
            this.Controls.Add(this.NewRelease);
            this.Controls.Add(this.CancelNewName);
            this.Controls.Add(this.UpdateNameOfSet);
            this.Controls.Add(this.NameOfSet);
            this.Controls.Add(this.UpdateText);
            this.Controls.Add(this.NewName);
            this.Controls.Add(this.OldName);
            this.Name = "UpdateSet";
            this.Text = "UpdateSet";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UpdateSet_FormClosed);
            this.Load += new System.EventHandler(this.UpdateSet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OldName;
        private System.Windows.Forms.Label NewName;
        private System.Windows.Forms.TextBox UpdateText;
        private System.Windows.Forms.Label NameOfSet;
        private System.Windows.Forms.Button UpdateNameOfSet;
        private System.Windows.Forms.Button CancelNewName;
        private System.Windows.Forms.Label NewRelease;
        private System.Windows.Forms.TextBox UpdateRelease;
    }
}