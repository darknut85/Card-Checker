
namespace Card_Checker
{
    partial class AddSet
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
            this.AddThisSet = new System.Windows.Forms.Button();
            this.CancelThisSet = new System.Windows.Forms.Button();
            this.SetName = new System.Windows.Forms.TextBox();
            this.SetNameLabel = new System.Windows.Forms.Label();
            this.SetDateLabel = new System.Windows.Forms.Label();
            this.SetRelease = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AddThisSet
            // 
            this.AddThisSet.Location = new System.Drawing.Point(12, 59);
            this.AddThisSet.Name = "AddThisSet";
            this.AddThisSet.Size = new System.Drawing.Size(75, 23);
            this.AddThisSet.TabIndex = 0;
            this.AddThisSet.Text = "Add";
            this.AddThisSet.UseVisualStyleBackColor = true;
            this.AddThisSet.Click += new System.EventHandler(this.AddThisSet_Click);
            // 
            // CancelThisSet
            // 
            this.CancelThisSet.Location = new System.Drawing.Point(96, 59);
            this.CancelThisSet.Name = "CancelThisSet";
            this.CancelThisSet.Size = new System.Drawing.Size(75, 23);
            this.CancelThisSet.TabIndex = 1;
            this.CancelThisSet.Text = "Cancel";
            this.CancelThisSet.UseVisualStyleBackColor = true;
            this.CancelThisSet.Click += new System.EventHandler(this.CancelThisSet_Click);
            // 
            // SetName
            // 
            this.SetName.Location = new System.Drawing.Point(96, 5);
            this.SetName.Name = "SetName";
            this.SetName.Size = new System.Drawing.Size(174, 20);
            this.SetName.TabIndex = 2;
            // 
            // SetNameLabel
            // 
            this.SetNameLabel.AutoSize = true;
            this.SetNameLabel.Location = new System.Drawing.Point(12, 9);
            this.SetNameLabel.Name = "SetNameLabel";
            this.SetNameLabel.Size = new System.Drawing.Size(38, 13);
            this.SetNameLabel.TabIndex = 3;
            this.SetNameLabel.Text = "Name:";
            // 
            // SetDateLabel
            // 
            this.SetDateLabel.AutoSize = true;
            this.SetDateLabel.Location = new System.Drawing.Point(12, 32);
            this.SetDateLabel.Name = "SetDateLabel";
            this.SetDateLabel.Size = new System.Drawing.Size(75, 13);
            this.SetDateLabel.TabIndex = 6;
            this.SetDateLabel.Text = "Release Date:";
            // 
            // SetRelease
            // 
            this.SetRelease.Location = new System.Drawing.Point(96, 32);
            this.SetRelease.Name = "SetRelease";
            this.SetRelease.Size = new System.Drawing.Size(100, 20);
            this.SetRelease.TabIndex = 7;
            // 
            // AddSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 142);
            this.Controls.Add(this.SetRelease);
            this.Controls.Add(this.SetDateLabel);
            this.Controls.Add(this.SetNameLabel);
            this.Controls.Add(this.SetName);
            this.Controls.Add(this.CancelThisSet);
            this.Controls.Add(this.AddThisSet);
            this.Name = "AddSet";
            this.Text = "Add a Set";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddSet_FormClosed);
            this.Load += new System.EventHandler(this.AddSet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddThisSet;
        private System.Windows.Forms.Button CancelThisSet;
        private System.Windows.Forms.TextBox SetName;
        private System.Windows.Forms.Label SetNameLabel;
        private System.Windows.Forms.Label SetDateLabel;
        private System.Windows.Forms.TextBox SetRelease;
    }
}