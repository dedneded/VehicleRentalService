
namespace form
{
    partial class AddVehicle
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddVehicle));
            this.Category_name = new System.Windows.Forms.Label();
            this.IsBig = new System.Windows.Forms.CheckBox();
            this.BrandModel_name = new System.Windows.Forms.Label();
            this.BrandModel = new System.Windows.Forms.TextBox();
            this.PricePerHour_name = new System.Windows.Forms.Label();
            this.YearOfIssue = new System.Windows.Forms.TextBox();
            this.YearOfIssue_name = new System.Windows.Forms.Label();
            this.PricePerHour = new System.Windows.Forms.TextBox();
            this.Mass_name = new System.Windows.Forms.Label();
            this.Mass = new System.Windows.Forms.TextBox();
            this.DrivingCategories_name = new System.Windows.Forms.Label();
            this.AvgGas_name = new System.Windows.Forms.Label();
            this.AvgGas = new System.Windows.Forms.TextBox();
            this.AvgSpeed_name = new System.Windows.Forms.Label();
            this.AvgSpeed = new System.Windows.Forms.TextBox();
            this.ShipmentTime = new System.Windows.Forms.TextBox();
            this.ShipmentTime_name = new System.Windows.Forms.Label();
            this.CommVehicle_name = new System.Windows.Forms.Label();
            this.GosNum_name = new System.Windows.Forms.Label();
            this.GosNum = new System.Windows.Forms.TextBox();
            this.DrivingCategories = new System.Windows.Forms.ComboBox();
            this.CancelVehicle = new System.Windows.Forms.Button();
            this.SaveVehicle = new System.Windows.Forms.Button();
            this.IDVehicle_name = new System.Windows.Forms.Label();
            this.IDVehicle = new System.Windows.Forms.Label();
            this.CategoryChoose = new System.Windows.Forms.Button();
            this.CategoryText = new System.Windows.Forms.LinkLabel();
            this.CommVehicle = new System.Windows.Forms.TextBox();
            this.BranchInfoVehicle = new System.Windows.Forms.LinkLabel();
            this.ChooseBranchVehicle = new System.Windows.Forms.Button();
            this.BranchNameVehicle = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // Category_name
            // 
            this.Category_name.AutoSize = true;
            this.Category_name.Location = new System.Drawing.Point(14, 68);
            this.Category_name.Name = "Category_name";
            this.Category_name.Size = new System.Drawing.Size(77, 17);
            this.Category_name.TabIndex = 0;
            this.Category_name.Text = "Категория";
            // 
            // IsBig
            // 
            this.IsBig.AutoSize = true;
            this.IsBig.Location = new System.Drawing.Point(20, 255);
            this.IsBig.Name = "IsBig";
            this.IsBig.Size = new System.Drawing.Size(86, 21);
            this.IsBig.TabIndex = 2;
            this.IsBig.Text = "Крупная";
            this.IsBig.UseVisualStyleBackColor = true;
            // 
            // BrandModel_name
            // 
            this.BrandModel_name.AutoSize = true;
            this.BrandModel_name.Location = new System.Drawing.Point(18, 133);
            this.BrandModel_name.Name = "BrandModel_name";
            this.BrandModel_name.Size = new System.Drawing.Size(113, 17);
            this.BrandModel_name.TabIndex = 3;
            this.BrandModel_name.Text = "Бренд и модель";
            // 
            // BrandModel
            // 
            this.BrandModel.Location = new System.Drawing.Point(153, 130);
            this.BrandModel.Name = "BrandModel";
            this.BrandModel.Size = new System.Drawing.Size(207, 22);
            this.BrandModel.TabIndex = 4;
            // 
            // PricePerHour_name
            // 
            this.PricePerHour_name.AutoSize = true;
            this.PricePerHour_name.Location = new System.Drawing.Point(19, 219);
            this.PricePerHour_name.Name = "PricePerHour_name";
            this.PricePerHour_name.Size = new System.Drawing.Size(89, 17);
            this.PricePerHour_name.TabIndex = 5;
            this.PricePerHour_name.Text = "Цена за час";
            // 
            // YearOfIssue
            // 
            this.YearOfIssue.Location = new System.Drawing.Point(152, 158);
            this.YearOfIssue.Name = "YearOfIssue";
            this.YearOfIssue.Size = new System.Drawing.Size(207, 22);
            this.YearOfIssue.TabIndex = 6;
            this.YearOfIssue.TextChanged += new System.EventHandler(this.YearOfIssue_TextChanged);
            // 
            // YearOfIssue_name
            // 
            this.YearOfIssue_name.AutoSize = true;
            this.YearOfIssue_name.Location = new System.Drawing.Point(18, 161);
            this.YearOfIssue_name.Name = "YearOfIssue_name";
            this.YearOfIssue_name.Size = new System.Drawing.Size(90, 17);
            this.YearOfIssue_name.TabIndex = 7;
            this.YearOfIssue_name.Text = "Год выпуска";
            // 
            // PricePerHour
            // 
            this.PricePerHour.Location = new System.Drawing.Point(152, 216);
            this.PricePerHour.Name = "PricePerHour";
            this.PricePerHour.Size = new System.Drawing.Size(207, 22);
            this.PricePerHour.TabIndex = 8;
            this.PricePerHour.TextChanged += new System.EventHandler(this.PricePerHour_TextChanged);
            // 
            // Mass_name
            // 
            this.Mass_name.AutoSize = true;
            this.Mass_name.Location = new System.Drawing.Point(403, 135);
            this.Mass_name.Name = "Mass_name";
            this.Mass_name.Size = new System.Drawing.Size(49, 17);
            this.Mass_name.TabIndex = 11;
            this.Mass_name.Text = "Масса";
            // 
            // Mass
            // 
            this.Mass.Location = new System.Drawing.Point(537, 132);
            this.Mass.Name = "Mass";
            this.Mass.Size = new System.Drawing.Size(207, 22);
            this.Mass.TabIndex = 12;
            this.Mass.TextChanged += new System.EventHandler(this.Mass_TextChanged);
            // 
            // DrivingCategories_name
            // 
            this.DrivingCategories_name.AutoSize = true;
            this.DrivingCategories_name.Location = new System.Drawing.Point(19, 189);
            this.DrivingCategories_name.Name = "DrivingCategories_name";
            this.DrivingCategories_name.Size = new System.Drawing.Size(112, 17);
            this.DrivingCategories_name.TabIndex = 13;
            this.DrivingCategories_name.Text = "Категория прав";
            // 
            // AvgGas_name
            // 
            this.AvgGas_name.AutoSize = true;
            this.AvgGas_name.Location = new System.Drawing.Point(403, 194);
            this.AvgGas_name.Name = "AvgGas_name";
            this.AvgGas_name.Size = new System.Drawing.Size(113, 17);
            this.AvgGas_name.TabIndex = 15;
            this.AvgGas_name.Text = "Расход бензина";
            // 
            // AvgGas
            // 
            this.AvgGas.Location = new System.Drawing.Point(537, 191);
            this.AvgGas.Name = "AvgGas";
            this.AvgGas.Size = new System.Drawing.Size(207, 22);
            this.AvgGas.TabIndex = 16;
            this.AvgGas.TextChanged += new System.EventHandler(this.AvgGas_TextChanged);
            // 
            // AvgSpeed_name
            // 
            this.AvgSpeed_name.AutoSize = true;
            this.AvgSpeed_name.Location = new System.Drawing.Point(403, 163);
            this.AvgSpeed_name.Name = "AvgSpeed_name";
            this.AvgSpeed_name.Size = new System.Drawing.Size(128, 17);
            this.AvgSpeed_name.TabIndex = 17;
            this.AvgSpeed_name.Text = "Средняя скорость";
            // 
            // AvgSpeed
            // 
            this.AvgSpeed.Location = new System.Drawing.Point(537, 160);
            this.AvgSpeed.Name = "AvgSpeed";
            this.AvgSpeed.Size = new System.Drawing.Size(207, 22);
            this.AvgSpeed.TabIndex = 18;
            this.AvgSpeed.TextChanged += new System.EventHandler(this.AvgSpeed_TextChanged);
            // 
            // ShipmentTime
            // 
            this.ShipmentTime.Location = new System.Drawing.Point(537, 219);
            this.ShipmentTime.Name = "ShipmentTime";
            this.ShipmentTime.Size = new System.Drawing.Size(207, 22);
            this.ShipmentTime.TabIndex = 20;
            this.ShipmentTime.TextChanged += new System.EventHandler(this.ShipmentTime_TextChanged);
            // 
            // ShipmentTime_name
            // 
            this.ShipmentTime_name.AutoSize = true;
            this.ShipmentTime_name.Location = new System.Drawing.Point(403, 222);
            this.ShipmentTime_name.Name = "ShipmentTime_name";
            this.ShipmentTime_name.Size = new System.Drawing.Size(126, 17);
            this.ShipmentTime_name.TabIndex = 19;
            this.ShipmentTime_name.Text = "Погрузка(в часах)";
            // 
            // CommVehicle_name
            // 
            this.CommVehicle_name.AutoSize = true;
            this.CommVehicle_name.Location = new System.Drawing.Point(17, 286);
            this.CommVehicle_name.Name = "CommVehicle_name";
            this.CommVehicle_name.Size = new System.Drawing.Size(102, 17);
            this.CommVehicle_name.TabIndex = 43;
            this.CommVehicle_name.Text = "Комментарий:";
            // 
            // GosNum_name
            // 
            this.GosNum_name.AutoSize = true;
            this.GosNum_name.Location = new System.Drawing.Point(18, 102);
            this.GosNum_name.Name = "GosNum_name";
            this.GosNum_name.Size = new System.Drawing.Size(80, 17);
            this.GosNum_name.TabIndex = 73;
            this.GosNum_name.Text = "Гос. номер";
            // 
            // GosNum
            // 
            this.GosNum.Location = new System.Drawing.Point(153, 102);
            this.GosNum.Name = "GosNum";
            this.GosNum.Size = new System.Drawing.Size(207, 22);
            this.GosNum.TabIndex = 74;
            // 
            // DrivingCategories
            // 
            this.DrivingCategories.FormattingEnabled = true;
            this.DrivingCategories.Location = new System.Drawing.Point(153, 186);
            this.DrivingCategories.Name = "DrivingCategories";
            this.DrivingCategories.Size = new System.Drawing.Size(207, 24);
            this.DrivingCategories.TabIndex = 75;
            // 
            // CancelVehicle
            // 
            this.CancelVehicle.Location = new System.Drawing.Point(656, 450);
            this.CancelVehicle.Name = "CancelVehicle";
            this.CancelVehicle.Size = new System.Drawing.Size(88, 24);
            this.CancelVehicle.TabIndex = 196;
            this.CancelVehicle.Text = "Отмена";
            this.CancelVehicle.UseVisualStyleBackColor = true;
            this.CancelVehicle.Click += new System.EventHandler(this.CancelVehicle_Click);
            // 
            // SaveVehicle
            // 
            this.SaveVehicle.Location = new System.Drawing.Point(562, 450);
            this.SaveVehicle.Name = "SaveVehicle";
            this.SaveVehicle.Size = new System.Drawing.Size(88, 24);
            this.SaveVehicle.TabIndex = 195;
            this.SaveVehicle.Text = "Сохранить";
            this.SaveVehicle.UseVisualStyleBackColor = true;
            this.SaveVehicle.Click += new System.EventHandler(this.SaveVehicle_Click);
            // 
            // IDVehicle_name
            // 
            this.IDVehicle_name.AutoSize = true;
            this.IDVehicle_name.Location = new System.Drawing.Point(17, 9);
            this.IDVehicle_name.Name = "IDVehicle_name";
            this.IDVehicle_name.Size = new System.Drawing.Size(21, 17);
            this.IDVehicle_name.TabIndex = 197;
            this.IDVehicle_name.Text = "ID";
            // 
            // IDVehicle
            // 
            this.IDVehicle.AutoSize = true;
            this.IDVehicle.Location = new System.Drawing.Point(44, 9);
            this.IDVehicle.Name = "IDVehicle";
            this.IDVehicle.Size = new System.Drawing.Size(54, 17);
            this.IDVehicle.TabIndex = 198;
            this.IDVehicle.Text = "label13";
            // 
            // CategoryChoose
            // 
            this.CategoryChoose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CategoryChoose.BackgroundImage")));
            this.CategoryChoose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CategoryChoose.Location = new System.Drawing.Point(323, 60);
            this.CategoryChoose.Name = "CategoryChoose";
            this.CategoryChoose.Size = new System.Drawing.Size(36, 25);
            this.CategoryChoose.TabIndex = 207;
            this.CategoryChoose.UseVisualStyleBackColor = false;
            this.CategoryChoose.Click += new System.EventHandler(this.CategoryChoose_Click);
            // 
            // CategoryText
            // 
            this.CategoryText.AutoSize = true;
            this.CategoryText.Location = new System.Drawing.Point(149, 64);
            this.CategoryText.Name = "CategoryText";
            this.CategoryText.Size = new System.Drawing.Size(85, 17);
            this.CategoryText.TabIndex = 208;
            this.CategoryText.TabStop = true;
            this.CategoryText.Text = "не выбрано";
            // 
            // CommVehicle
            // 
            this.CommVehicle.Location = new System.Drawing.Point(18, 306);
            this.CommVehicle.Multiline = true;
            this.CommVehicle.Name = "CommVehicle";
            this.CommVehicle.Size = new System.Drawing.Size(726, 100);
            this.CommVehicle.TabIndex = 209;
            // 
            // BranchInfoVehicle
            // 
            this.BranchInfoVehicle.AutoSize = true;
            this.BranchInfoVehicle.Location = new System.Drawing.Point(149, 37);
            this.BranchInfoVehicle.Name = "BranchInfoVehicle";
            this.BranchInfoVehicle.Size = new System.Drawing.Size(85, 17);
            this.BranchInfoVehicle.TabIndex = 212;
            this.BranchInfoVehicle.TabStop = true;
            this.BranchInfoVehicle.Text = "не выбрано";
            // 
            // ChooseBranchVehicle
            // 
            this.ChooseBranchVehicle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ChooseBranchVehicle.BackgroundImage")));
            this.ChooseBranchVehicle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ChooseBranchVehicle.Location = new System.Drawing.Point(323, 33);
            this.ChooseBranchVehicle.Name = "ChooseBranchVehicle";
            this.ChooseBranchVehicle.Size = new System.Drawing.Size(36, 25);
            this.ChooseBranchVehicle.TabIndex = 211;
            this.ChooseBranchVehicle.UseVisualStyleBackColor = false;
            this.ChooseBranchVehicle.Click += new System.EventHandler(this.ChooseBranchVehicle_Click);
            // 
            // BranchNameVehicle
            // 
            this.BranchNameVehicle.AutoSize = true;
            this.BranchNameVehicle.Location = new System.Drawing.Point(14, 41);
            this.BranchNameVehicle.Name = "BranchNameVehicle";
            this.BranchNameVehicle.Size = new System.Drawing.Size(61, 17);
            this.BranchNameVehicle.TabIndex = 210;
            this.BranchNameVehicle.Text = "Филиал";
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // AddVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 490);
            this.Controls.Add(this.BranchInfoVehicle);
            this.Controls.Add(this.ChooseBranchVehicle);
            this.Controls.Add(this.BranchNameVehicle);
            this.Controls.Add(this.CommVehicle);
            this.Controls.Add(this.CategoryText);
            this.Controls.Add(this.CategoryChoose);
            this.Controls.Add(this.IDVehicle);
            this.Controls.Add(this.IDVehicle_name);
            this.Controls.Add(this.CancelVehicle);
            this.Controls.Add(this.SaveVehicle);
            this.Controls.Add(this.DrivingCategories);
            this.Controls.Add(this.GosNum);
            this.Controls.Add(this.GosNum_name);
            this.Controls.Add(this.CommVehicle_name);
            this.Controls.Add(this.ShipmentTime);
            this.Controls.Add(this.ShipmentTime_name);
            this.Controls.Add(this.AvgSpeed);
            this.Controls.Add(this.AvgSpeed_name);
            this.Controls.Add(this.AvgGas);
            this.Controls.Add(this.AvgGas_name);
            this.Controls.Add(this.DrivingCategories_name);
            this.Controls.Add(this.Mass);
            this.Controls.Add(this.Mass_name);
            this.Controls.Add(this.PricePerHour);
            this.Controls.Add(this.YearOfIssue_name);
            this.Controls.Add(this.YearOfIssue);
            this.Controls.Add(this.PricePerHour_name);
            this.Controls.Add(this.BrandModel);
            this.Controls.Add(this.BrandModel_name);
            this.Controls.Add(this.IsBig);
            this.Controls.Add(this.Category_name);
            this.Name = "AddVehicle";
            this.Text = "Добавление/изменение техники(AddVehicle)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddVehicle_FormClosing);
            this.Load += new System.EventHandler(this.Vehicle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Category_name;
        private System.Windows.Forms.CheckBox IsBig;
        private System.Windows.Forms.Label BrandModel_name;
        private System.Windows.Forms.TextBox BrandModel;
        private System.Windows.Forms.Label PricePerHour_name;
        private System.Windows.Forms.TextBox YearOfIssue;
        private System.Windows.Forms.Label YearOfIssue_name;
        private System.Windows.Forms.TextBox PricePerHour;
        private System.Windows.Forms.Label Mass_name;
        private System.Windows.Forms.TextBox Mass;
        private System.Windows.Forms.Label DrivingCategories_name;
        private System.Windows.Forms.Label AvgGas_name;
        private System.Windows.Forms.TextBox AvgGas;
        private System.Windows.Forms.Label AvgSpeed_name;
        private System.Windows.Forms.TextBox AvgSpeed;
        private System.Windows.Forms.TextBox ShipmentTime;
        private System.Windows.Forms.Label ShipmentTime_name;
        private System.Windows.Forms.Label CommVehicle_name;
        private System.Windows.Forms.Label GosNum_name;
        private System.Windows.Forms.TextBox GosNum;
        private System.Windows.Forms.ComboBox DrivingCategories;
        private System.Windows.Forms.Button CancelVehicle;
        private System.Windows.Forms.Button SaveVehicle;
        private System.Windows.Forms.Label IDVehicle_name;
        private System.Windows.Forms.Label IDVehicle;
        private System.Windows.Forms.Button CategoryChoose;
        private System.Windows.Forms.LinkLabel CategoryText;
        private System.Windows.Forms.TextBox CommVehicle;
        private System.Windows.Forms.LinkLabel BranchInfoVehicle;
        private System.Windows.Forms.Button ChooseBranchVehicle;
        private System.Windows.Forms.Label BranchNameVehicle;
        private System.Windows.Forms.ErrorProvider error;
    }
}