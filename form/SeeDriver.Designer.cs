
namespace form
{
    partial class SeeDriver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeeDriver));
            this.TimeTableDriver = new System.Windows.Forms.Button();
            this.InfoOrderDriver = new System.Windows.Forms.Button();
            this.QuantityOrderDriver = new System.Windows.Forms.Label();
            this.QuantityOrderDriver_name = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.All = new System.Windows.Forms.CheckBox();
            this.C1E = new System.Windows.Forms.CheckBox();
            this.C1 = new System.Windows.Forms.CheckBox();
            this.CE = new System.Windows.Forms.CheckBox();
            this.C = new System.Windows.Forms.CheckBox();
            this.LisenceCategoryInfo_name = new System.Windows.Forms.Label();
            this.ChangeDriverInfo = new System.Windows.Forms.Button();
            this.DelDriver = new System.Windows.Forms.Button();
            this.BranchDriverInfo = new System.Windows.Forms.LinkLabel();
            this.BranchDriverInfo_name = new System.Windows.Forms.Label();
            this.LisenceDriverInfo = new System.Windows.Forms.Label();
            this.PhoneDriverInfo = new System.Windows.Forms.Label();
            this.FIODriverInfo = new System.Windows.Forms.Label();
            this.IDDriverInfo = new System.Windows.Forms.Label();
            this.IDDriverInfo_name = new System.Windows.Forms.Label();
            this.LisenceDriverInfo_name = new System.Windows.Forms.Label();
            this.PhoneDriverInfo_name = new System.Windows.Forms.Label();
            this.FIODriverInfo_name = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TimeTableDriver
            // 
            this.TimeTableDriver.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TimeTableDriver.BackgroundImage")));
            this.TimeTableDriver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.TimeTableDriver.Location = new System.Drawing.Point(24, 342);
            this.TimeTableDriver.Name = "TimeTableDriver";
            this.TimeTableDriver.Size = new System.Drawing.Size(69, 45);
            this.TimeTableDriver.TabIndex = 202;
            this.TimeTableDriver.UseVisualStyleBackColor = true;
            this.TimeTableDriver.Click += new System.EventHandler(this.TimeTableDriver_Click);
            // 
            // InfoOrderDriver
            // 
            this.InfoOrderDriver.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("InfoOrderDriver.BackgroundImage")));
            this.InfoOrderDriver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.InfoOrderDriver.Location = new System.Drawing.Point(207, 306);
            this.InfoOrderDriver.Name = "InfoOrderDriver";
            this.InfoOrderDriver.Size = new System.Drawing.Size(37, 23);
            this.InfoOrderDriver.TabIndex = 201;
            this.InfoOrderDriver.UseVisualStyleBackColor = true;
            this.InfoOrderDriver.Click += new System.EventHandler(this.InfoOrderDriver_Click);
            // 
            // QuantityOrderDriver
            // 
            this.QuantityOrderDriver.AutoSize = true;
            this.QuantityOrderDriver.Location = new System.Drawing.Point(148, 309);
            this.QuantityOrderDriver.Name = "QuantityOrderDriver";
            this.QuantityOrderDriver.Size = new System.Drawing.Size(54, 17);
            this.QuantityOrderDriver.TabIndex = 200;
            this.QuantityOrderDriver.Text = "label13";
            // 
            // QuantityOrderDriver_name
            // 
            this.QuantityOrderDriver_name.AutoSize = true;
            this.QuantityOrderDriver_name.Location = new System.Drawing.Point(25, 309);
            this.QuantityOrderDriver_name.Name = "QuantityOrderDriver_name";
            this.QuantityOrderDriver_name.Size = new System.Drawing.Size(109, 17);
            this.QuantityOrderDriver_name.TabIndex = 199;
            this.QuantityOrderDriver_name.Text = "Кол-во заказов";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.All);
            this.panel1.Controls.Add(this.C1E);
            this.panel1.Controls.Add(this.C1);
            this.panel1.Controls.Add(this.CE);
            this.panel1.Controls.Add(this.C);
            this.panel1.Location = new System.Drawing.Point(24, 188);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 59);
            this.panel1.TabIndex = 198;
            // 
            // All
            // 
            this.All.AutoCheck = false;
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
            this.C1E.AutoCheck = false;
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
            this.C1.AutoCheck = false;
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
            this.CE.AutoCheck = false;
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
            this.C.AutoCheck = false;
            this.C.AutoSize = true;
            this.C.Location = new System.Drawing.Point(3, 5);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(39, 21);
            this.C.TabIndex = 0;
            this.C.Text = "C";
            this.C.UseVisualStyleBackColor = true;
            // 
            // LisenceCategoryInfo_name
            // 
            this.LisenceCategoryInfo_name.AutoSize = true;
            this.LisenceCategoryInfo_name.Location = new System.Drawing.Point(21, 168);
            this.LisenceCategoryInfo_name.Name = "LisenceCategoryInfo_name";
            this.LisenceCategoryInfo_name.Size = new System.Drawing.Size(112, 17);
            this.LisenceCategoryInfo_name.TabIndex = 197;
            this.LisenceCategoryInfo_name.Text = "Категория прав";
            // 
            // ChangeDriverInfo
            // 
            this.ChangeDriverInfo.Location = new System.Drawing.Point(267, 362);
            this.ChangeDriverInfo.Name = "ChangeDriverInfo";
            this.ChangeDriverInfo.Size = new System.Drawing.Size(82, 25);
            this.ChangeDriverInfo.TabIndex = 195;
            this.ChangeDriverInfo.Text = "Изменить";
            this.ChangeDriverInfo.UseVisualStyleBackColor = true;
            // 
            // DelDriver
            // 
            this.DelDriver.BackColor = System.Drawing.Color.Pink;
            this.DelDriver.Location = new System.Drawing.Point(355, 362);
            this.DelDriver.Name = "DelDriver";
            this.DelDriver.Size = new System.Drawing.Size(82, 25);
            this.DelDriver.TabIndex = 194;
            this.DelDriver.Text = "Удалить";
            this.DelDriver.UseVisualStyleBackColor = false;
            // 
            // BranchDriverInfo
            // 
            this.BranchDriverInfo.AutoSize = true;
            this.BranchDriverInfo.Location = new System.Drawing.Point(148, 269);
            this.BranchDriverInfo.Name = "BranchDriverInfo";
            this.BranchDriverInfo.Size = new System.Drawing.Size(72, 17);
            this.BranchDriverInfo.TabIndex = 196;
            this.BranchDriverInfo.TabStop = true;
            this.BranchDriverInfo.Text = "linkLabel1";
            // 
            // BranchDriverInfo_name
            // 
            this.BranchDriverInfo_name.AutoSize = true;
            this.BranchDriverInfo_name.Location = new System.Drawing.Point(24, 269);
            this.BranchDriverInfo_name.Name = "BranchDriverInfo_name";
            this.BranchDriverInfo_name.Size = new System.Drawing.Size(61, 17);
            this.BranchDriverInfo_name.TabIndex = 193;
            this.BranchDriverInfo_name.Text = "Филиал";
            // 
            // LisenceDriverInfo
            // 
            this.LisenceDriverInfo.AutoSize = true;
            this.LisenceDriverInfo.Location = new System.Drawing.Point(148, 137);
            this.LisenceDriverInfo.Name = "LisenceDriverInfo";
            this.LisenceDriverInfo.Size = new System.Drawing.Size(46, 17);
            this.LisenceDriverInfo.TabIndex = 192;
            this.LisenceDriverInfo.Text = "label9";
            // 
            // PhoneDriverInfo
            // 
            this.PhoneDriverInfo.AutoSize = true;
            this.PhoneDriverInfo.Location = new System.Drawing.Point(148, 103);
            this.PhoneDriverInfo.Name = "PhoneDriverInfo";
            this.PhoneDriverInfo.Size = new System.Drawing.Size(46, 17);
            this.PhoneDriverInfo.TabIndex = 191;
            this.PhoneDriverInfo.Text = "label8";
            // 
            // FIODriverInfo
            // 
            this.FIODriverInfo.AutoSize = true;
            this.FIODriverInfo.Location = new System.Drawing.Point(148, 68);
            this.FIODriverInfo.Name = "FIODriverInfo";
            this.FIODriverInfo.Size = new System.Drawing.Size(46, 17);
            this.FIODriverInfo.TabIndex = 190;
            this.FIODriverInfo.Text = "label7";
            // 
            // IDDriverInfo
            // 
            this.IDDriverInfo.AutoSize = true;
            this.IDDriverInfo.Location = new System.Drawing.Point(47, 29);
            this.IDDriverInfo.Name = "IDDriverInfo";
            this.IDDriverInfo.Size = new System.Drawing.Size(46, 17);
            this.IDDriverInfo.TabIndex = 189;
            this.IDDriverInfo.Text = "label6";
            // 
            // IDDriverInfo_name
            // 
            this.IDDriverInfo_name.AutoSize = true;
            this.IDDriverInfo_name.Location = new System.Drawing.Point(21, 29);
            this.IDDriverInfo_name.Name = "IDDriverInfo_name";
            this.IDDriverInfo_name.Size = new System.Drawing.Size(21, 17);
            this.IDDriverInfo_name.TabIndex = 188;
            this.IDDriverInfo_name.Text = "ID";
            // 
            // LisenceDriverInfo_name
            // 
            this.LisenceDriverInfo_name.AutoSize = true;
            this.LisenceDriverInfo_name.Location = new System.Drawing.Point(21, 137);
            this.LisenceDriverInfo_name.Name = "LisenceDriverInfo_name";
            this.LisenceDriverInfo_name.Size = new System.Drawing.Size(80, 17);
            this.LisenceDriverInfo_name.TabIndex = 187;
            this.LisenceDriverInfo_name.Text = "Вод. права";
            // 
            // PhoneDriverInfo_name
            // 
            this.PhoneDriverInfo_name.AutoSize = true;
            this.PhoneDriverInfo_name.Location = new System.Drawing.Point(21, 103);
            this.PhoneDriverInfo_name.Name = "PhoneDriverInfo_name";
            this.PhoneDriverInfo_name.Size = new System.Drawing.Size(121, 17);
            this.PhoneDriverInfo_name.TabIndex = 186;
            this.PhoneDriverInfo_name.Text = "Номер телефона";
            // 
            // FIODriverInfo_name
            // 
            this.FIODriverInfo_name.AutoSize = true;
            this.FIODriverInfo_name.Location = new System.Drawing.Point(22, 68);
            this.FIODriverInfo_name.Name = "FIODriverInfo_name";
            this.FIODriverInfo_name.Size = new System.Drawing.Size(42, 17);
            this.FIODriverInfo_name.TabIndex = 185;
            this.FIODriverInfo_name.Text = "ФИО";
            // 
            // SeeDriver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 416);
            this.Controls.Add(this.TimeTableDriver);
            this.Controls.Add(this.InfoOrderDriver);
            this.Controls.Add(this.QuantityOrderDriver);
            this.Controls.Add(this.QuantityOrderDriver_name);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LisenceCategoryInfo_name);
            this.Controls.Add(this.ChangeDriverInfo);
            this.Controls.Add(this.DelDriver);
            this.Controls.Add(this.BranchDriverInfo);
            this.Controls.Add(this.BranchDriverInfo_name);
            this.Controls.Add(this.LisenceDriverInfo);
            this.Controls.Add(this.PhoneDriverInfo);
            this.Controls.Add(this.FIODriverInfo);
            this.Controls.Add(this.IDDriverInfo);
            this.Controls.Add(this.IDDriverInfo_name);
            this.Controls.Add(this.LisenceDriverInfo_name);
            this.Controls.Add(this.PhoneDriverInfo_name);
            this.Controls.Add(this.FIODriverInfo_name);
            this.Name = "SeeDriver";
            this.Text = "Информация о водителе";
            this.Load += new System.EventHandler(this.SeeDriver_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TimeTableDriver;
        private System.Windows.Forms.Button InfoOrderDriver;
        private System.Windows.Forms.Label QuantityOrderDriver;
        private System.Windows.Forms.Label QuantityOrderDriver_name;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox All;
        private System.Windows.Forms.CheckBox C1E;
        private System.Windows.Forms.CheckBox C1;
        private System.Windows.Forms.CheckBox CE;
        private System.Windows.Forms.CheckBox C;
        private System.Windows.Forms.Label LisenceCategoryInfo_name;
        private System.Windows.Forms.Button ChangeDriverInfo;
        private System.Windows.Forms.Button DelDriver;
        private System.Windows.Forms.LinkLabel BranchDriverInfo;
        private System.Windows.Forms.Label BranchDriverInfo_name;
        private System.Windows.Forms.Label LisenceDriverInfo;
        private System.Windows.Forms.Label PhoneDriverInfo;
        private System.Windows.Forms.Label FIODriverInfo;
        private System.Windows.Forms.Label IDDriverInfo;
        private System.Windows.Forms.Label IDDriverInfo_name;
        private System.Windows.Forms.Label LisenceDriverInfo_name;
        private System.Windows.Forms.Label PhoneDriverInfo_name;
        private System.Windows.Forms.Label FIODriverInfo_name;
    }
}