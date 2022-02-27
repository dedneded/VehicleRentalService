
namespace form
{
    partial class AddDriver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDriver));
            this.PhoneDriver = new System.Windows.Forms.TextBox();
            this.PhoneDriver_name = new System.Windows.Forms.Label();
            this.FIODriver = new System.Windows.Forms.TextBox();
            this.FIODriver_name = new System.Windows.Forms.Label();
            this.DrivingCategory_name = new System.Windows.Forms.Label();
            this.DrivingLicense_name = new System.Windows.Forms.Label();
            this.DrivingLicense = new System.Windows.Forms.TextBox();
            this.DrivingCategory = new System.Windows.Forms.Panel();
            this.All = new System.Windows.Forms.CheckBox();
            this.C1E = new System.Windows.Forms.CheckBox();
            this.C1 = new System.Windows.Forms.CheckBox();
            this.CE = new System.Windows.Forms.CheckBox();
            this.C = new System.Windows.Forms.CheckBox();
            this.BranchDriverChoose = new System.Windows.Forms.Button();
            this.BranchDriver = new System.Windows.Forms.LinkLabel();
            this.BranchDriver_name = new System.Windows.Forms.Label();
            this.IDDriver = new System.Windows.Forms.Label();
            this.IDDriver_name = new System.Windows.Forms.Label();
            this.CancelDriver = new System.Windows.Forms.Button();
            this.SaveDriver = new System.Windows.Forms.Button();
            this.RoleChoose = new System.Windows.Forms.Button();
            this.RoleName = new System.Windows.Forms.LinkLabel();
            this.Role = new System.Windows.Forms.Label();
            this.DrivingCategory.SuspendLayout();
            this.SuspendLayout();
            // 
            // PhoneDriver
            // 
            this.PhoneDriver.Location = new System.Drawing.Point(162, 53);
            this.PhoneDriver.Name = "PhoneDriver";
            this.PhoneDriver.Size = new System.Drawing.Size(289, 22);
            this.PhoneDriver.TabIndex = 7;
            // 
            // PhoneDriver_name
            // 
            this.PhoneDriver_name.AutoSize = true;
            this.PhoneDriver_name.Location = new System.Drawing.Point(12, 56);
            this.PhoneDriver_name.Name = "PhoneDriver_name";
            this.PhoneDriver_name.Size = new System.Drawing.Size(121, 17);
            this.PhoneDriver_name.TabIndex = 6;
            this.PhoneDriver_name.Text = "Номер телефона";
            // 
            // FIODriver
            // 
            this.FIODriver.Location = new System.Drawing.Point(162, 25);
            this.FIODriver.Name = "FIODriver";
            this.FIODriver.Size = new System.Drawing.Size(289, 22);
            this.FIODriver.TabIndex = 5;
            // 
            // FIODriver_name
            // 
            this.FIODriver_name.AutoSize = true;
            this.FIODriver_name.Location = new System.Drawing.Point(12, 28);
            this.FIODriver_name.Name = "FIODriver_name";
            this.FIODriver_name.Size = new System.Drawing.Size(42, 17);
            this.FIODriver_name.TabIndex = 4;
            this.FIODriver_name.Text = "ФИО";
            // 
            // DrivingCategory_name
            // 
            this.DrivingCategory_name.AutoSize = true;
            this.DrivingCategory_name.Location = new System.Drawing.Point(12, 113);
            this.DrivingCategory_name.Name = "DrivingCategory_name";
            this.DrivingCategory_name.Size = new System.Drawing.Size(112, 17);
            this.DrivingCategory_name.TabIndex = 10;
            this.DrivingCategory_name.Text = "Категория прав";
            // 
            // DrivingLicense_name
            // 
            this.DrivingLicense_name.AutoSize = true;
            this.DrivingLicense_name.Location = new System.Drawing.Point(12, 84);
            this.DrivingLicense_name.Name = "DrivingLicense_name";
            this.DrivingLicense_name.Size = new System.Drawing.Size(80, 17);
            this.DrivingLicense_name.TabIndex = 17;
            this.DrivingLicense_name.Text = "Вод. права";
            // 
            // DrivingLicense
            // 
            this.DrivingLicense.Location = new System.Drawing.Point(162, 81);
            this.DrivingLicense.Name = "DrivingLicense";
            this.DrivingLicense.Size = new System.Drawing.Size(289, 22);
            this.DrivingLicense.TabIndex = 18;
            // 
            // DrivingCategory
            // 
            this.DrivingCategory.Controls.Add(this.All);
            this.DrivingCategory.Controls.Add(this.C1E);
            this.DrivingCategory.Controls.Add(this.C1);
            this.DrivingCategory.Controls.Add(this.CE);
            this.DrivingCategory.Controls.Add(this.C);
            this.DrivingCategory.Location = new System.Drawing.Point(15, 133);
            this.DrivingCategory.Name = "DrivingCategory";
            this.DrivingCategory.Size = new System.Drawing.Size(220, 59);
            this.DrivingCategory.TabIndex = 23;
            // 
            // All
            // 
            this.All.AutoSize = true;
            this.All.Location = new System.Drawing.Point(163, 5);
            this.All.Name = "All";
            this.All.Size = new System.Drawing.Size(54, 21);
            this.All.TabIndex = 4;
            this.All.Text = "Все";
            this.All.UseVisualStyleBackColor = true;
            this.All.CheckedChanged += new System.EventHandler(this.All_CheckedChanged);
            // 
            // C1E
            // 
            this.C1E.AutoSize = true;
            this.C1E.Location = new System.Drawing.Point(88, 32);
            this.C1E.Name = "C1E";
            this.C1E.Size = new System.Drawing.Size(56, 21);
            this.C1E.TabIndex = 3;
            this.C1E.Text = "C1E";
            this.C1E.UseVisualStyleBackColor = true;
            // 
            // C1
            // 
            this.C1.AutoSize = true;
            this.C1.Location = new System.Drawing.Point(88, 5);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(47, 21);
            this.C1.TabIndex = 2;
            this.C1.Text = "C1";
            this.C1.UseVisualStyleBackColor = true;
            // 
            // CE
            // 
            this.CE.AutoSize = true;
            this.CE.Location = new System.Drawing.Point(3, 32);
            this.CE.Name = "CE";
            this.CE.Size = new System.Drawing.Size(48, 21);
            this.CE.TabIndex = 1;
            this.CE.Text = "CE";
            this.CE.UseVisualStyleBackColor = true;
            // 
            // C
            // 
            this.C.AutoSize = true;
            this.C.Location = new System.Drawing.Point(3, 5);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(39, 21);
            this.C.TabIndex = 0;
            this.C.Text = "C";
            this.C.UseVisualStyleBackColor = true;
            // 
            // BranchDriverChoose
            // 
            this.BranchDriverChoose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BranchDriverChoose.BackgroundImage")));
            this.BranchDriverChoose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BranchDriverChoose.Location = new System.Drawing.Point(209, 205);
            this.BranchDriverChoose.Name = "BranchDriverChoose";
            this.BranchDriverChoose.Size = new System.Drawing.Size(35, 25);
            this.BranchDriverChoose.TabIndex = 26;
            this.BranchDriverChoose.UseVisualStyleBackColor = false;
            this.BranchDriverChoose.Click += new System.EventHandler(this.BranchDriverChoose_Click);
            // 
            // BranchDriver
            // 
            this.BranchDriver.AutoSize = true;
            this.BranchDriver.Location = new System.Drawing.Point(110, 209);
            this.BranchDriver.Name = "BranchDriver";
            this.BranchDriver.Size = new System.Drawing.Size(85, 17);
            this.BranchDriver.TabIndex = 25;
            this.BranchDriver.TabStop = true;
            this.BranchDriver.Text = "не выбрано";
            // 
            // BranchDriver_name
            // 
            this.BranchDriver_name.AutoSize = true;
            this.BranchDriver_name.Location = new System.Drawing.Point(12, 209);
            this.BranchDriver_name.Name = "BranchDriver_name";
            this.BranchDriver_name.Size = new System.Drawing.Size(61, 17);
            this.BranchDriver_name.TabIndex = 24;
            this.BranchDriver_name.Text = "Филиал";
            // 
            // IDDriver
            // 
            this.IDDriver.AutoSize = true;
            this.IDDriver.Location = new System.Drawing.Point(46, 4);
            this.IDDriver.Name = "IDDriver";
            this.IDDriver.Size = new System.Drawing.Size(46, 17);
            this.IDDriver.TabIndex = 210;
            this.IDDriver.Text = "label6";
            // 
            // IDDriver_name
            // 
            this.IDDriver_name.AutoSize = true;
            this.IDDriver_name.Location = new System.Drawing.Point(12, 5);
            this.IDDriver_name.Name = "IDDriver_name";
            this.IDDriver_name.Size = new System.Drawing.Size(21, 17);
            this.IDDriver_name.TabIndex = 209;
            this.IDDriver_name.Text = "ID";
            // 
            // CancelDriver
            // 
            this.CancelDriver.Location = new System.Drawing.Point(359, 322);
            this.CancelDriver.Name = "CancelDriver";
            this.CancelDriver.Size = new System.Drawing.Size(92, 26);
            this.CancelDriver.TabIndex = 213;
            this.CancelDriver.Text = "Отмена";
            this.CancelDriver.UseVisualStyleBackColor = true;
            // 
            // SaveDriver
            // 
            this.SaveDriver.Location = new System.Drawing.Point(261, 322);
            this.SaveDriver.Name = "SaveDriver";
            this.SaveDriver.Size = new System.Drawing.Size(92, 26);
            this.SaveDriver.TabIndex = 212;
            this.SaveDriver.Text = "Сохранить";
            this.SaveDriver.UseVisualStyleBackColor = true;
            this.SaveDriver.Click += new System.EventHandler(this.SaveDriver_Click);
            // 
            // RoleChoose
            // 
            this.RoleChoose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RoleChoose.BackgroundImage")));
            this.RoleChoose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RoleChoose.Location = new System.Drawing.Point(209, 241);
            this.RoleChoose.Name = "RoleChoose";
            this.RoleChoose.Size = new System.Drawing.Size(35, 25);
            this.RoleChoose.TabIndex = 216;
            this.RoleChoose.UseVisualStyleBackColor = false;
            this.RoleChoose.Click += new System.EventHandler(this.RoleChoose_Click);
            // 
            // RoleName
            // 
            this.RoleName.AutoSize = true;
            this.RoleName.Location = new System.Drawing.Point(110, 245);
            this.RoleName.Name = "RoleName";
            this.RoleName.Size = new System.Drawing.Size(85, 17);
            this.RoleName.TabIndex = 215;
            this.RoleName.TabStop = true;
            this.RoleName.Text = "не выбрано";
            this.RoleName.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RoleName_LinkClicked);
            // 
            // Role
            // 
            this.Role.AutoSize = true;
            this.Role.Location = new System.Drawing.Point(15, 245);
            this.Role.Name = "Role";
            this.Role.Size = new System.Drawing.Size(81, 17);
            this.Role.TabIndex = 214;
            this.Role.Text = "Должность";
            this.Role.Click += new System.EventHandler(this.Role_Click);
            // 
            // AddDriver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 360);
            this.Controls.Add(this.RoleChoose);
            this.Controls.Add(this.RoleName);
            this.Controls.Add(this.Role);
            this.Controls.Add(this.CancelDriver);
            this.Controls.Add(this.SaveDriver);
            this.Controls.Add(this.IDDriver);
            this.Controls.Add(this.IDDriver_name);
            this.Controls.Add(this.BranchDriverChoose);
            this.Controls.Add(this.BranchDriver);
            this.Controls.Add(this.BranchDriver_name);
            this.Controls.Add(this.DrivingCategory);
            this.Controls.Add(this.DrivingLicense);
            this.Controls.Add(this.DrivingLicense_name);
            this.Controls.Add(this.DrivingCategory_name);
            this.Controls.Add(this.PhoneDriver);
            this.Controls.Add(this.PhoneDriver_name);
            this.Controls.Add(this.FIODriver);
            this.Controls.Add(this.FIODriver_name);
            this.Name = "AddDriver";
            this.Text = "Добавление/изменение водителя(AddDriver)";
            this.Load += new System.EventHandler(this.Driver_Load);
            this.DrivingCategory.ResumeLayout(false);
            this.DrivingCategory.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PhoneDriver;
        private System.Windows.Forms.Label PhoneDriver_name;
        private System.Windows.Forms.TextBox FIODriver;
        private System.Windows.Forms.Label FIODriver_name;
        private System.Windows.Forms.Label DrivingCategory_name;
        private System.Windows.Forms.Label DrivingLicense_name;
        private System.Windows.Forms.TextBox DrivingLicense;
        private System.Windows.Forms.Panel DrivingCategory;
        private System.Windows.Forms.CheckBox All;
        private System.Windows.Forms.CheckBox C1E;
        private System.Windows.Forms.CheckBox C1;
        private System.Windows.Forms.CheckBox CE;
        private System.Windows.Forms.CheckBox C;
        private System.Windows.Forms.Button BranchDriverChoose;
        private System.Windows.Forms.LinkLabel BranchDriver;
        private System.Windows.Forms.Label BranchDriver_name;
        private System.Windows.Forms.Label IDDriver;
        private System.Windows.Forms.Label IDDriver_name;
        private System.Windows.Forms.Button CancelDriver;
        private System.Windows.Forms.Button SaveDriver;
        private System.Windows.Forms.Button RoleChoose;
        private System.Windows.Forms.LinkLabel RoleName;
        private System.Windows.Forms.Label Role;
    }
}