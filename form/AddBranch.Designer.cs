
namespace form
{
    partial class AddBranch
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
            this.PhoneBranch_name = new System.Windows.Forms.Label();
            this.PhoneBranch = new System.Windows.Forms.TextBox();
            this.CancelBranch = new System.Windows.Forms.Button();
            this.SaveBranch = new System.Windows.Forms.Button();
            this.IDBranch_name = new System.Windows.Forms.Label();
            this.IDBranch = new System.Windows.Forms.Label();
            this.AddressBranch = new System.Windows.Forms.GroupBox();
            this.CityBranchName = new System.Windows.Forms.Label();
            this.CityBranch = new System.Windows.Forms.TextBox();
            this.StreetBranchName = new System.Windows.Forms.Label();
            this.StreetBranch = new System.Windows.Forms.TextBox();
            this.HomeBranchName = new System.Windows.Forms.Label();
            this.HomeBranch = new System.Windows.Forms.TextBox();
            this.AddressBranch.SuspendLayout();
            this.SuspendLayout();
            // 
            // PhoneBranch_name
            // 
            this.PhoneBranch_name.AutoSize = true;
            this.PhoneBranch_name.Location = new System.Drawing.Point(18, 44);
            this.PhoneBranch_name.Name = "PhoneBranch_name";
            this.PhoneBranch_name.Size = new System.Drawing.Size(121, 17);
            this.PhoneBranch_name.TabIndex = 2;
            this.PhoneBranch_name.Text = "Номер телефона";
            // 
            // PhoneBranch
            // 
            this.PhoneBranch.Location = new System.Drawing.Point(146, 41);
            this.PhoneBranch.Name = "PhoneBranch";
            this.PhoneBranch.Size = new System.Drawing.Size(245, 22);
            this.PhoneBranch.TabIndex = 3;
            // 
            // CancelBranch
            // 
            this.CancelBranch.Location = new System.Drawing.Point(309, 236);
            this.CancelBranch.Name = "CancelBranch";
            this.CancelBranch.Size = new System.Drawing.Size(88, 24);
            this.CancelBranch.TabIndex = 7;
            this.CancelBranch.Text = "Отмена";
            this.CancelBranch.UseVisualStyleBackColor = true;
            // 
            // SaveBranch
            // 
            this.SaveBranch.Location = new System.Drawing.Point(215, 236);
            this.SaveBranch.Name = "SaveBranch";
            this.SaveBranch.Size = new System.Drawing.Size(88, 24);
            this.SaveBranch.TabIndex = 6;
            this.SaveBranch.Text = "Сохранить";
            this.SaveBranch.UseVisualStyleBackColor = true;
            this.SaveBranch.Click += new System.EventHandler(this.SaveBranch_Click);
            // 
            // IDBranch_name
            // 
            this.IDBranch_name.AutoSize = true;
            this.IDBranch_name.Location = new System.Drawing.Point(18, 9);
            this.IDBranch_name.Name = "IDBranch_name";
            this.IDBranch_name.Size = new System.Drawing.Size(21, 17);
            this.IDBranch_name.TabIndex = 8;
            this.IDBranch_name.Text = "ID";
            // 
            // IDBranch
            // 
            this.IDBranch.AutoSize = true;
            this.IDBranch.Location = new System.Drawing.Point(45, 9);
            this.IDBranch.Name = "IDBranch";
            this.IDBranch.Size = new System.Drawing.Size(46, 17);
            this.IDBranch.TabIndex = 9;
            this.IDBranch.Text = "label4";
            // 
            // AddressBranch
            // 
            this.AddressBranch.Controls.Add(this.HomeBranch);
            this.AddressBranch.Controls.Add(this.HomeBranchName);
            this.AddressBranch.Controls.Add(this.StreetBranch);
            this.AddressBranch.Controls.Add(this.StreetBranchName);
            this.AddressBranch.Controls.Add(this.CityBranch);
            this.AddressBranch.Controls.Add(this.CityBranchName);
            this.AddressBranch.Location = new System.Drawing.Point(12, 80);
            this.AddressBranch.Name = "AddressBranch";
            this.AddressBranch.Size = new System.Drawing.Size(385, 150);
            this.AddressBranch.TabIndex = 10;
            this.AddressBranch.TabStop = false;
            this.AddressBranch.Text = "Адрес";
            // 
            // CityBranchName
            // 
            this.CityBranchName.AutoSize = true;
            this.CityBranchName.Location = new System.Drawing.Point(68, 31);
            this.CityBranchName.Name = "CityBranchName";
            this.CityBranchName.Size = new System.Drawing.Size(48, 17);
            this.CityBranchName.TabIndex = 0;
            this.CityBranchName.Text = "Город";
            // 
            // CityBranch
            // 
            this.CityBranch.Location = new System.Drawing.Point(134, 26);
            this.CityBranch.Name = "CityBranch";
            this.CityBranch.Size = new System.Drawing.Size(245, 22);
            this.CityBranch.TabIndex = 1;
            // 
            // StreetBranchName
            // 
            this.StreetBranchName.AutoSize = true;
            this.StreetBranchName.Location = new System.Drawing.Point(68, 69);
            this.StreetBranchName.Name = "StreetBranchName";
            this.StreetBranchName.Size = new System.Drawing.Size(49, 17);
            this.StreetBranchName.TabIndex = 2;
            this.StreetBranchName.Text = "Улица";
            // 
            // StreetBranch
            // 
            this.StreetBranch.Location = new System.Drawing.Point(134, 62);
            this.StreetBranch.Name = "StreetBranch";
            this.StreetBranch.Size = new System.Drawing.Size(245, 22);
            this.StreetBranch.TabIndex = 3;
            // 
            // HomeBranchName
            // 
            this.HomeBranchName.AutoSize = true;
            this.HomeBranchName.Location = new System.Drawing.Point(68, 104);
            this.HomeBranchName.Name = "HomeBranchName";
            this.HomeBranchName.Size = new System.Drawing.Size(36, 17);
            this.HomeBranchName.TabIndex = 4;
            this.HomeBranchName.Text = "Дом";
            // 
            // HomeBranch
            // 
            this.HomeBranch.Location = new System.Drawing.Point(134, 102);
            this.HomeBranch.Name = "HomeBranch";
            this.HomeBranch.Size = new System.Drawing.Size(245, 22);
            this.HomeBranch.TabIndex = 5;
            // 
            // AddBranch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 281);
            this.Controls.Add(this.AddressBranch);
            this.Controls.Add(this.IDBranch);
            this.Controls.Add(this.IDBranch_name);
            this.Controls.Add(this.CancelBranch);
            this.Controls.Add(this.SaveBranch);
            this.Controls.Add(this.PhoneBranch);
            this.Controls.Add(this.PhoneBranch_name);
            this.Name = "AddBranch";
            this.Text = "Добавление/изменение филиала";
            this.Load += new System.EventHandler(this.AddBranch_Load);
            this.AddressBranch.ResumeLayout(false);
            this.AddressBranch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label PhoneBranch_name;
        private System.Windows.Forms.TextBox PhoneBranch;
        private System.Windows.Forms.Button CancelBranch;
        private System.Windows.Forms.Button SaveBranch;
        private System.Windows.Forms.Label IDBranch_name;
        private System.Windows.Forms.Label IDBranch;
        private System.Windows.Forms.GroupBox AddressBranch;
        private System.Windows.Forms.TextBox HomeBranch;
        private System.Windows.Forms.Label HomeBranchName;
        private System.Windows.Forms.TextBox StreetBranch;
        private System.Windows.Forms.Label StreetBranchName;
        private System.Windows.Forms.TextBox CityBranch;
        private System.Windows.Forms.Label CityBranchName;
    }
}