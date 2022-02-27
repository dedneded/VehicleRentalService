
namespace form
{
    partial class AddDiscount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDiscount));
            this.Discount_name = new System.Windows.Forms.Label();
            this.BranchDiscount_name = new System.Windows.Forms.Label();
            this.Discount = new System.Windows.Forms.TextBox();
            this.BranchDiscount = new System.Windows.Forms.LinkLabel();
            this.BranchDiscountChoose = new System.Windows.Forms.Button();
            this.NameDiscount_name = new System.Windows.Forms.Label();
            this.NameDiscount = new System.Windows.Forms.TextBox();
            this.StartDiscount_name = new System.Windows.Forms.Label();
            this.EndDiscount_name = new System.Windows.Forms.Label();
            this.EndDiscountDay = new System.Windows.Forms.DateTimePicker();
            this.StartDiscountDay = new System.Windows.Forms.DateTimePicker();
            this.AllBranchesDiscount = new System.Windows.Forms.CheckBox();
            this.IDDiscount_name = new System.Windows.Forms.Label();
            this.CanselDiscount = new System.Windows.Forms.Button();
            this.SaveDiscount = new System.Windows.Forms.Button();
            this.IDDiscount = new System.Windows.Forms.Label();
            this.CategoryOfVehicle_name = new System.Windows.Forms.Label();
            this.CategoryOfVehicleChoose = new System.Windows.Forms.Button();
            this.AllVehicles = new System.Windows.Forms.CheckBox();
            this.IsOptional = new System.Windows.Forms.CheckBox();
            this.AllServiceDiscount = new System.Windows.Forms.CheckBox();
            this.ChooseServiceDiscount = new System.Windows.Forms.Button();
            this.ServicesDiscount = new System.Windows.Forms.LinkLabel();
            this.ServiceDiscountName = new System.Windows.Forms.Label();
            this.CategoryOfVehicle = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // Discount_name
            // 
            this.Discount_name.AutoSize = true;
            this.Discount_name.Location = new System.Drawing.Point(14, 63);
            this.Discount_name.Name = "Discount_name";
            this.Discount_name.Size = new System.Drawing.Size(82, 17);
            this.Discount_name.TabIndex = 0;
            this.Discount_name.Text = "Скидка в %";
            // 
            // BranchDiscount_name
            // 
            this.BranchDiscount_name.AutoSize = true;
            this.BranchDiscount_name.Location = new System.Drawing.Point(15, 198);
            this.BranchDiscount_name.Name = "BranchDiscount_name";
            this.BranchDiscount_name.Size = new System.Drawing.Size(61, 17);
            this.BranchDiscount_name.TabIndex = 1;
            this.BranchDiscount_name.Text = "Филиал";
            // 
            // Discount
            // 
            this.Discount.Location = new System.Drawing.Point(110, 60);
            this.Discount.Name = "Discount";
            this.Discount.Size = new System.Drawing.Size(237, 22);
            this.Discount.TabIndex = 2;
            // 
            // BranchDiscount
            // 
            this.BranchDiscount.AutoSize = true;
            this.BranchDiscount.Location = new System.Drawing.Point(159, 197);
            this.BranchDiscount.Name = "BranchDiscount";
            this.BranchDiscount.Size = new System.Drawing.Size(85, 17);
            this.BranchDiscount.TabIndex = 4;
            this.BranchDiscount.TabStop = true;
            this.BranchDiscount.Text = "не выбрано";
            // 
            // BranchDiscountChoose
            // 
            this.BranchDiscountChoose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BranchDiscountChoose.BackgroundImage")));
            this.BranchDiscountChoose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BranchDiscountChoose.Location = new System.Drawing.Point(250, 192);
            this.BranchDiscountChoose.Name = "BranchDiscountChoose";
            this.BranchDiscountChoose.Size = new System.Drawing.Size(35, 25);
            this.BranchDiscountChoose.TabIndex = 5;
            this.BranchDiscountChoose.UseVisualStyleBackColor = false;
            this.BranchDiscountChoose.Click += new System.EventHandler(this.BranchDiscountChoose_Click);
            // 
            // NameDiscount_name
            // 
            this.NameDiscount_name.AutoSize = true;
            this.NameDiscount_name.Location = new System.Drawing.Point(14, 37);
            this.NameDiscount_name.Name = "NameDiscount_name";
            this.NameDiscount_name.Size = new System.Drawing.Size(72, 17);
            this.NameDiscount_name.TabIndex = 8;
            this.NameDiscount_name.Text = "Название";
            // 
            // NameDiscount
            // 
            this.NameDiscount.Location = new System.Drawing.Point(110, 32);
            this.NameDiscount.Name = "NameDiscount";
            this.NameDiscount.Size = new System.Drawing.Size(237, 22);
            this.NameDiscount.TabIndex = 9;
            // 
            // StartDiscount_name
            // 
            this.StartDiscount_name.AutoSize = true;
            this.StartDiscount_name.Location = new System.Drawing.Point(15, 101);
            this.StartDiscount_name.Name = "StartDiscount_name";
            this.StartDiscount_name.Size = new System.Drawing.Size(62, 17);
            this.StartDiscount_name.TabIndex = 10;
            this.StartDiscount_name.Text = "Начало ";
            // 
            // EndDiscount_name
            // 
            this.EndDiscount_name.AutoSize = true;
            this.EndDiscount_name.Location = new System.Drawing.Point(15, 129);
            this.EndDiscount_name.Name = "EndDiscount_name";
            this.EndDiscount_name.Size = new System.Drawing.Size(49, 17);
            this.EndDiscount_name.TabIndex = 11;
            this.EndDiscount_name.Text = "Конец";
            // 
            // EndDiscountDay
            // 
            this.EndDiscountDay.CustomFormat = "dd.MM.yyyy HH:mm:ss";
            this.EndDiscountDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EndDiscountDay.Location = new System.Drawing.Point(110, 124);
            this.EndDiscountDay.Name = "EndDiscountDay";
            this.EndDiscountDay.Size = new System.Drawing.Size(237, 22);
            this.EndDiscountDay.TabIndex = 91;
            // 
            // StartDiscountDay
            // 
            this.StartDiscountDay.CustomFormat = "dd.MM.yyyy HH:mm:ss";
            this.StartDiscountDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.StartDiscountDay.Location = new System.Drawing.Point(110, 96);
            this.StartDiscountDay.Name = "StartDiscountDay";
            this.StartDiscountDay.Size = new System.Drawing.Size(237, 22);
            this.StartDiscountDay.TabIndex = 89;
            this.StartDiscountDay.ValueChanged += new System.EventHandler(this.StartDiscountDay_ValueChanged);
            // 
            // AllBranchesDiscount
            // 
            this.AllBranchesDiscount.AutoSize = true;
            this.AllBranchesDiscount.Location = new System.Drawing.Point(293, 196);
            this.AllBranchesDiscount.Name = "AllBranchesDiscount";
            this.AllBranchesDiscount.Size = new System.Drawing.Size(54, 21);
            this.AllBranchesDiscount.TabIndex = 93;
            this.AllBranchesDiscount.Text = "Все";
            this.AllBranchesDiscount.UseVisualStyleBackColor = true;
            this.AllBranchesDiscount.CheckedChanged += new System.EventHandler(this.AllBranchesDiscount_CheckedChanged);
            // 
            // IDDiscount_name
            // 
            this.IDDiscount_name.AutoSize = true;
            this.IDDiscount_name.Location = new System.Drawing.Point(14, 9);
            this.IDDiscount_name.Name = "IDDiscount_name";
            this.IDDiscount_name.Size = new System.Drawing.Size(21, 17);
            this.IDDiscount_name.TabIndex = 94;
            this.IDDiscount_name.Text = "ID";
            // 
            // CanselDiscount
            // 
            this.CanselDiscount.Location = new System.Drawing.Point(258, 316);
            this.CanselDiscount.Name = "CanselDiscount";
            this.CanselDiscount.Size = new System.Drawing.Size(88, 24);
            this.CanselDiscount.TabIndex = 97;
            this.CanselDiscount.Text = "Отмена";
            this.CanselDiscount.UseVisualStyleBackColor = true;
            // 
            // SaveDiscount
            // 
            this.SaveDiscount.Location = new System.Drawing.Point(164, 316);
            this.SaveDiscount.Name = "SaveDiscount";
            this.SaveDiscount.Size = new System.Drawing.Size(88, 24);
            this.SaveDiscount.TabIndex = 96;
            this.SaveDiscount.Text = "Сохранить";
            this.SaveDiscount.UseVisualStyleBackColor = true;
            this.SaveDiscount.Click += new System.EventHandler(this.SaveDiscount_Click);
            // 
            // IDDiscount
            // 
            this.IDDiscount.AutoSize = true;
            this.IDDiscount.Location = new System.Drawing.Point(41, 9);
            this.IDDiscount.Name = "IDDiscount";
            this.IDDiscount.Size = new System.Drawing.Size(46, 17);
            this.IDDiscount.TabIndex = 98;
            this.IDDiscount.Text = "label7";
            // 
            // CategoryOfVehicle_name
            // 
            this.CategoryOfVehicle_name.AutoSize = true;
            this.CategoryOfVehicle_name.Location = new System.Drawing.Point(15, 168);
            this.CategoryOfVehicle_name.Name = "CategoryOfVehicle_name";
            this.CategoryOfVehicle_name.Size = new System.Drawing.Size(133, 17);
            this.CategoryOfVehicle_name.TabIndex = 99;
            this.CategoryOfVehicle_name.Text = "Категория техники";
            // 
            // CategoryOfVehicleChoose
            // 
            this.CategoryOfVehicleChoose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CategoryOfVehicleChoose.BackgroundImage")));
            this.CategoryOfVehicleChoose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CategoryOfVehicleChoose.Location = new System.Drawing.Point(250, 164);
            this.CategoryOfVehicleChoose.Name = "CategoryOfVehicleChoose";
            this.CategoryOfVehicleChoose.Size = new System.Drawing.Size(35, 25);
            this.CategoryOfVehicleChoose.TabIndex = 101;
            this.CategoryOfVehicleChoose.UseVisualStyleBackColor = false;
            this.CategoryOfVehicleChoose.Click += new System.EventHandler(this.CategoryOfVehicle_Choose_Click);
            // 
            // AllVehicles
            // 
            this.AllVehicles.AutoSize = true;
            this.AllVehicles.Location = new System.Drawing.Point(293, 168);
            this.AllVehicles.Name = "AllVehicles";
            this.AllVehicles.Size = new System.Drawing.Size(54, 21);
            this.AllVehicles.TabIndex = 102;
            this.AllVehicles.Text = "Все";
            this.AllVehicles.UseVisualStyleBackColor = true;
            this.AllVehicles.CheckedChanged += new System.EventHandler(this.AllVehicles_CheckedChanged);
            // 
            // IsOptional
            // 
            this.IsOptional.AutoSize = true;
            this.IsOptional.Location = new System.Drawing.Point(12, 278);
            this.IsOptional.Name = "IsOptional";
            this.IsOptional.Size = new System.Drawing.Size(141, 21);
            this.IsOptional.TabIndex = 104;
            this.IsOptional.Text = "Необязательная";
            this.IsOptional.UseVisualStyleBackColor = true;
            // 
            // AllServiceDiscount
            // 
            this.AllServiceDiscount.AutoSize = true;
            this.AllServiceDiscount.Location = new System.Drawing.Point(293, 225);
            this.AllServiceDiscount.Name = "AllServiceDiscount";
            this.AllServiceDiscount.Size = new System.Drawing.Size(54, 21);
            this.AllServiceDiscount.TabIndex = 108;
            this.AllServiceDiscount.Text = "Все";
            this.AllServiceDiscount.UseVisualStyleBackColor = true;
            this.AllServiceDiscount.CheckedChanged += new System.EventHandler(this.AllServiceDiscount_CheckedChanged);
            // 
            // ChooseServiceDiscount
            // 
            this.ChooseServiceDiscount.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ChooseServiceDiscount.BackgroundImage")));
            this.ChooseServiceDiscount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ChooseServiceDiscount.Location = new System.Drawing.Point(250, 221);
            this.ChooseServiceDiscount.Name = "ChooseServiceDiscount";
            this.ChooseServiceDiscount.Size = new System.Drawing.Size(35, 25);
            this.ChooseServiceDiscount.TabIndex = 107;
            this.ChooseServiceDiscount.UseVisualStyleBackColor = false;
            this.ChooseServiceDiscount.Click += new System.EventHandler(this.ChooseServiceDiscount_Click);
            // 
            // ServicesDiscount
            // 
            this.ServicesDiscount.AutoSize = true;
            this.ServicesDiscount.Location = new System.Drawing.Point(159, 226);
            this.ServicesDiscount.Name = "ServicesDiscount";
            this.ServicesDiscount.Size = new System.Drawing.Size(85, 17);
            this.ServicesDiscount.TabIndex = 106;
            this.ServicesDiscount.TabStop = true;
            this.ServicesDiscount.Text = "не выбрано";
            // 
            // ServiceDiscountName
            // 
            this.ServiceDiscountName.AutoSize = true;
            this.ServiceDiscountName.Location = new System.Drawing.Point(15, 227);
            this.ServiceDiscountName.Name = "ServiceDiscountName";
            this.ServiceDiscountName.Size = new System.Drawing.Size(52, 17);
            this.ServiceDiscountName.TabIndex = 105;
            this.ServiceDiscountName.Text = "Услуга";
            // 
            // CategoryOfVehicle
            // 
            this.CategoryOfVehicle.AutoSize = true;
            this.CategoryOfVehicle.Location = new System.Drawing.Point(159, 168);
            this.CategoryOfVehicle.Name = "CategoryOfVehicle";
            this.CategoryOfVehicle.Size = new System.Drawing.Size(85, 17);
            this.CategoryOfVehicle.TabIndex = 109;
            this.CategoryOfVehicle.TabStop = true;
            this.CategoryOfVehicle.Text = "не выбрано";
            // 
            // AddDiscount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 352);
            this.Controls.Add(this.CategoryOfVehicle);
            this.Controls.Add(this.AllServiceDiscount);
            this.Controls.Add(this.ChooseServiceDiscount);
            this.Controls.Add(this.ServicesDiscount);
            this.Controls.Add(this.ServiceDiscountName);
            this.Controls.Add(this.IsOptional);
            this.Controls.Add(this.AllVehicles);
            this.Controls.Add(this.CategoryOfVehicleChoose);
            this.Controls.Add(this.CategoryOfVehicle_name);
            this.Controls.Add(this.IDDiscount);
            this.Controls.Add(this.CanselDiscount);
            this.Controls.Add(this.SaveDiscount);
            this.Controls.Add(this.IDDiscount_name);
            this.Controls.Add(this.AllBranchesDiscount);
            this.Controls.Add(this.EndDiscountDay);
            this.Controls.Add(this.StartDiscountDay);
            this.Controls.Add(this.EndDiscount_name);
            this.Controls.Add(this.StartDiscount_name);
            this.Controls.Add(this.NameDiscount);
            this.Controls.Add(this.NameDiscount_name);
            this.Controls.Add(this.BranchDiscountChoose);
            this.Controls.Add(this.BranchDiscount);
            this.Controls.Add(this.Discount);
            this.Controls.Add(this.BranchDiscount_name);
            this.Controls.Add(this.Discount_name);
            this.Name = "AddDiscount";
            this.Text = "Добавление/изменение скидки";
            this.Load += new System.EventHandler(this.AddDiscount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Discount_name;
        private System.Windows.Forms.Label BranchDiscount_name;
        private System.Windows.Forms.TextBox Discount;
        private System.Windows.Forms.LinkLabel BranchDiscount;
        private System.Windows.Forms.Button BranchDiscountChoose;
        private System.Windows.Forms.Label NameDiscount_name;
        private System.Windows.Forms.TextBox NameDiscount;
        private System.Windows.Forms.Label StartDiscount_name;
        private System.Windows.Forms.Label EndDiscount_name;
        private System.Windows.Forms.DateTimePicker EndDiscountDay;
        private System.Windows.Forms.DateTimePicker StartDiscountDay;
        private System.Windows.Forms.CheckBox AllBranchesDiscount;
        private System.Windows.Forms.Label IDDiscount_name;
        private System.Windows.Forms.Button CanselDiscount;
        private System.Windows.Forms.Button SaveDiscount;
        private System.Windows.Forms.Label IDDiscount;
        private System.Windows.Forms.Label CategoryOfVehicle_name;
        private System.Windows.Forms.Button CategoryOfVehicleChoose;
        private System.Windows.Forms.CheckBox AllVehicles;
        private System.Windows.Forms.CheckBox IsOptional;
        private System.Windows.Forms.CheckBox AllServiceDiscount;
        private System.Windows.Forms.Button ChooseServiceDiscount;
        private System.Windows.Forms.LinkLabel ServicesDiscount;
        private System.Windows.Forms.Label ServiceDiscountName;
        private System.Windows.Forms.LinkLabel CategoryOfVehicle;
    }
}