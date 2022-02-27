
namespace form
{
    partial class Drivers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Drivers));
            this.DriversFilters = new System.Windows.Forms.GroupBox();
            this.SortDesc_Drivers = new System.Windows.Forms.Button();
            this.ApplyDrivers = new System.Windows.Forms.Button();
            this.ResetDrivers = new System.Windows.Forms.Button();
            this.BranchDriversChoose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.All_drivers = new System.Windows.Forms.CheckBox();
            this.C1E_drivers = new System.Windows.Forms.CheckBox();
            this.C1_drivers = new System.Windows.Forms.CheckBox();
            this.CE_drivers = new System.Windows.Forms.CheckBox();
            this.C_drivers = new System.Windows.Forms.CheckBox();
            this.BranchDrivers = new System.Windows.Forms.LinkLabel();
            this.BranchDrivers_name = new System.Windows.Forms.Label();
            this.CategoryDrivers_name = new System.Windows.Forms.Label();
            this.IDDrivers_name = new System.Windows.Forms.Label();
            this.SalaryDriversTo = new System.Windows.Forms.TextBox();
            this.IDDrivers = new System.Windows.Forms.TextBox();
            this.SalaryDriversTo_name = new System.Windows.Forms.Label();
            this.SalaryDriversFrom = new System.Windows.Forms.TextBox();
            this.SalaryDriversFrom_name = new System.Windows.Forms.Label();
            this.FIODrivers_name = new System.Windows.Forms.Label();
            this.PhoneDrivers_name = new System.Windows.Forms.Label();
            this.SortingDrivers_name = new System.Windows.Forms.Label();
            this.FIODrivers = new System.Windows.Forms.TextBox();
            this.SortingDrivers = new System.Windows.Forms.ComboBox();
            this.PhoneDrivers = new System.Windows.Forms.TextBox();
            this.AllDrivers = new System.Windows.Forms.DataGridView();
            this.Id_driver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_driver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone_driver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DrivingLisense = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Branch_driver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PageDrivers = new System.Windows.Forms.TextBox();
            this.PagesDrivers = new System.Windows.Forms.Label();
            this.BackDrivers = new System.Windows.Forms.Button();
            this.ChooseDrivers = new System.Windows.Forms.Button();
            this.AddDrivers = new System.Windows.Forms.Button();
            this.ToDrivers = new System.Windows.Forms.Button();
            this.FindDrivers = new System.Windows.Forms.Button();
            this.DriversFilters.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AllDrivers)).BeginInit();
            this.SuspendLayout();
            // 
            // DriversFilters
            // 
            this.DriversFilters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DriversFilters.Controls.Add(this.SortDesc_Drivers);
            this.DriversFilters.Controls.Add(this.ApplyDrivers);
            this.DriversFilters.Controls.Add(this.ResetDrivers);
            this.DriversFilters.Controls.Add(this.BranchDriversChoose);
            this.DriversFilters.Controls.Add(this.panel1);
            this.DriversFilters.Controls.Add(this.BranchDrivers);
            this.DriversFilters.Controls.Add(this.BranchDrivers_name);
            this.DriversFilters.Controls.Add(this.CategoryDrivers_name);
            this.DriversFilters.Controls.Add(this.IDDrivers_name);
            this.DriversFilters.Controls.Add(this.SalaryDriversTo);
            this.DriversFilters.Controls.Add(this.IDDrivers);
            this.DriversFilters.Controls.Add(this.SalaryDriversTo_name);
            this.DriversFilters.Controls.Add(this.SalaryDriversFrom);
            this.DriversFilters.Controls.Add(this.SalaryDriversFrom_name);
            this.DriversFilters.Controls.Add(this.FIODrivers_name);
            this.DriversFilters.Controls.Add(this.PhoneDrivers_name);
            this.DriversFilters.Controls.Add(this.SortingDrivers_name);
            this.DriversFilters.Controls.Add(this.FIODrivers);
            this.DriversFilters.Controls.Add(this.SortingDrivers);
            this.DriversFilters.Controls.Add(this.PhoneDrivers);
            this.DriversFilters.Location = new System.Drawing.Point(12, 12);
            this.DriversFilters.Name = "DriversFilters";
            this.DriversFilters.Size = new System.Drawing.Size(1171, 161);
            this.DriversFilters.TabIndex = 0;
            this.DriversFilters.TabStop = false;
            this.DriversFilters.Text = "Фильтры";
            // 
            // SortDesc_Drivers
            // 
            this.SortDesc_Drivers.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SortDesc_Drivers.BackgroundImage")));
            this.SortDesc_Drivers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SortDesc_Drivers.Location = new System.Drawing.Point(426, 106);
            this.SortDesc_Drivers.Name = "SortDesc_Drivers";
            this.SortDesc_Drivers.Size = new System.Drawing.Size(36, 26);
            this.SortDesc_Drivers.TabIndex = 207;
            this.SortDesc_Drivers.UseVisualStyleBackColor = true;
            this.SortDesc_Drivers.Click += new System.EventHandler(this.SortDesc_Drivers_Click);
            // 
            // ApplyDrivers
            // 
            this.ApplyDrivers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ApplyDrivers.BackColor = System.Drawing.Color.White;
            this.ApplyDrivers.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.ApplyDrivers.FlatAppearance.BorderSize = 2;
            this.ApplyDrivers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ApplyDrivers.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ApplyDrivers.ForeColor = System.Drawing.Color.DarkOrange;
            this.ApplyDrivers.Location = new System.Drawing.Point(1055, 85);
            this.ApplyDrivers.Name = "ApplyDrivers";
            this.ApplyDrivers.Size = new System.Drawing.Size(110, 28);
            this.ApplyDrivers.TabIndex = 185;
            this.ApplyDrivers.Text = "Применить фильтры";
            this.ApplyDrivers.UseVisualStyleBackColor = false;
            this.ApplyDrivers.Click += new System.EventHandler(this.ApplyDrivers_Click);
            this.ApplyDrivers.MouseEnter += new System.EventHandler(this.ApplyDrivers_MouseEnter);
            this.ApplyDrivers.MouseLeave += new System.EventHandler(this.ApplyDrivers_MouseLeave);
            // 
            // ResetDrivers
            // 
            this.ResetDrivers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ResetDrivers.BackColor = System.Drawing.Color.White;
            this.ResetDrivers.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.ResetDrivers.FlatAppearance.BorderSize = 2;
            this.ResetDrivers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetDrivers.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResetDrivers.ForeColor = System.Drawing.Color.DarkOrange;
            this.ResetDrivers.Location = new System.Drawing.Point(1055, 119);
            this.ResetDrivers.Name = "ResetDrivers";
            this.ResetDrivers.Size = new System.Drawing.Size(110, 28);
            this.ResetDrivers.TabIndex = 184;
            this.ResetDrivers.Text = "Сбросить";
            this.ResetDrivers.UseVisualStyleBackColor = false;
            this.ResetDrivers.Click += new System.EventHandler(this.ResetDrivers_Click);
            this.ResetDrivers.MouseEnter += new System.EventHandler(this.ResetDrivers_MouseEnter);
            this.ResetDrivers.MouseLeave += new System.EventHandler(this.ResetDrivers_MouseLeave);
            // 
            // BranchDriversChoose
            // 
            this.BranchDriversChoose.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BranchDriversChoose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BranchDriversChoose.BackgroundImage")));
            this.BranchDriversChoose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BranchDriversChoose.Location = new System.Drawing.Point(713, 21);
            this.BranchDriversChoose.Name = "BranchDriversChoose";
            this.BranchDriversChoose.Size = new System.Drawing.Size(35, 25);
            this.BranchDriversChoose.TabIndex = 29;
            this.BranchDriversChoose.UseVisualStyleBackColor = false;
            this.BranchDriversChoose.Click += new System.EventHandler(this.BranchDriversChoose_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.All_drivers);
            this.panel1.Controls.Add(this.C1E_drivers);
            this.panel1.Controls.Add(this.C1_drivers);
            this.panel1.Controls.Add(this.CE_drivers);
            this.panel1.Controls.Add(this.C_drivers);
            this.panel1.Location = new System.Drawing.Point(788, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 59);
            this.panel1.TabIndex = 180;
            // 
            // All_drivers
            // 
            this.All_drivers.AutoSize = true;
            this.All_drivers.Location = new System.Drawing.Point(163, 5);
            this.All_drivers.Name = "All_drivers";
            this.All_drivers.Size = new System.Drawing.Size(54, 21);
            this.All_drivers.TabIndex = 4;
            this.All_drivers.Text = "Все";
            this.All_drivers.UseVisualStyleBackColor = true;
            // 
            // C1E_drivers
            // 
            this.C1E_drivers.AutoSize = true;
            this.C1E_drivers.Location = new System.Drawing.Point(88, 32);
            this.C1E_drivers.Name = "C1E_drivers";
            this.C1E_drivers.Size = new System.Drawing.Size(56, 21);
            this.C1E_drivers.TabIndex = 3;
            this.C1E_drivers.Text = "C1E";
            this.C1E_drivers.UseVisualStyleBackColor = true;
            // 
            // C1_drivers
            // 
            this.C1_drivers.AutoSize = true;
            this.C1_drivers.Location = new System.Drawing.Point(88, 5);
            this.C1_drivers.Name = "C1_drivers";
            this.C1_drivers.Size = new System.Drawing.Size(47, 21);
            this.C1_drivers.TabIndex = 2;
            this.C1_drivers.Text = "C1";
            this.C1_drivers.UseVisualStyleBackColor = true;
            // 
            // CE_drivers
            // 
            this.CE_drivers.AutoSize = true;
            this.CE_drivers.Location = new System.Drawing.Point(3, 32);
            this.CE_drivers.Name = "CE_drivers";
            this.CE_drivers.Size = new System.Drawing.Size(48, 21);
            this.CE_drivers.TabIndex = 1;
            this.CE_drivers.Text = "CE";
            this.CE_drivers.UseVisualStyleBackColor = true;
            // 
            // C_drivers
            // 
            this.C_drivers.AutoSize = true;
            this.C_drivers.Location = new System.Drawing.Point(3, 5);
            this.C_drivers.Name = "C_drivers";
            this.C_drivers.Size = new System.Drawing.Size(39, 21);
            this.C_drivers.TabIndex = 0;
            this.C_drivers.Text = "C";
            this.C_drivers.UseVisualStyleBackColor = true;
            // 
            // BranchDrivers
            // 
            this.BranchDrivers.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BranchDrivers.AutoSize = true;
            this.BranchDrivers.Location = new System.Drawing.Point(558, 29);
            this.BranchDrivers.Name = "BranchDrivers";
            this.BranchDrivers.Size = new System.Drawing.Size(85, 17);
            this.BranchDrivers.TabIndex = 28;
            this.BranchDrivers.TabStop = true;
            this.BranchDrivers.Text = "не выбрано";
            // 
            // BranchDrivers_name
            // 
            this.BranchDrivers_name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BranchDrivers_name.AutoSize = true;
            this.BranchDrivers_name.Location = new System.Drawing.Point(468, 29);
            this.BranchDrivers_name.Name = "BranchDrivers_name";
            this.BranchDrivers_name.Size = new System.Drawing.Size(61, 17);
            this.BranchDrivers_name.TabIndex = 27;
            this.BranchDrivers_name.Text = "Филиал";
            // 
            // CategoryDrivers_name
            // 
            this.CategoryDrivers_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CategoryDrivers_name.AutoSize = true;
            this.CategoryDrivers_name.Location = new System.Drawing.Point(785, 15);
            this.CategoryDrivers_name.Name = "CategoryDrivers_name";
            this.CategoryDrivers_name.Size = new System.Drawing.Size(112, 17);
            this.CategoryDrivers_name.TabIndex = 179;
            this.CategoryDrivers_name.Text = "Категория прав";
            // 
            // IDDrivers_name
            // 
            this.IDDrivers_name.AutoSize = true;
            this.IDDrivers_name.Location = new System.Drawing.Point(6, 29);
            this.IDDrivers_name.Name = "IDDrivers_name";
            this.IDDrivers_name.Size = new System.Drawing.Size(21, 17);
            this.IDDrivers_name.TabIndex = 173;
            this.IDDrivers_name.Text = "ID";
            // 
            // SalaryDriversTo
            // 
            this.SalaryDriversTo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SalaryDriversTo.Location = new System.Drawing.Point(579, 110);
            this.SalaryDriversTo.Name = "SalaryDriversTo";
            this.SalaryDriversTo.Size = new System.Drawing.Size(169, 22);
            this.SalaryDriversTo.TabIndex = 183;
            // 
            // IDDrivers
            // 
            this.IDDrivers.Location = new System.Drawing.Point(157, 24);
            this.IDDrivers.Name = "IDDrivers";
            this.IDDrivers.Size = new System.Drawing.Size(263, 22);
            this.IDDrivers.TabIndex = 174;
            // 
            // SalaryDriversTo_name
            // 
            this.SalaryDriversTo_name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SalaryDriversTo_name.AutoSize = true;
            this.SalaryDriversTo_name.Location = new System.Drawing.Point(468, 113);
            this.SalaryDriversTo_name.Name = "SalaryDriversTo_name";
            this.SalaryDriversTo_name.Size = new System.Drawing.Size(49, 17);
            this.SalaryDriversTo_name.TabIndex = 181;
            this.SalaryDriversTo_name.Text = "З/п до";
            // 
            // SalaryDriversFrom
            // 
            this.SalaryDriversFrom.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SalaryDriversFrom.Location = new System.Drawing.Point(579, 82);
            this.SalaryDriversFrom.Name = "SalaryDriversFrom";
            this.SalaryDriversFrom.Size = new System.Drawing.Size(169, 22);
            this.SalaryDriversFrom.TabIndex = 182;
            // 
            // SalaryDriversFrom_name
            // 
            this.SalaryDriversFrom_name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SalaryDriversFrom_name.AutoSize = true;
            this.SalaryDriversFrom_name.Location = new System.Drawing.Point(468, 85);
            this.SalaryDriversFrom_name.Name = "SalaryDriversFrom_name";
            this.SalaryDriversFrom_name.Size = new System.Drawing.Size(48, 17);
            this.SalaryDriversFrom_name.TabIndex = 178;
            this.SalaryDriversFrom_name.Text = "З/п от";
            // 
            // FIODrivers_name
            // 
            this.FIODrivers_name.AutoSize = true;
            this.FIODrivers_name.Location = new System.Drawing.Point(6, 57);
            this.FIODrivers_name.Name = "FIODrivers_name";
            this.FIODrivers_name.Size = new System.Drawing.Size(42, 17);
            this.FIODrivers_name.TabIndex = 159;
            this.FIODrivers_name.Text = "ФИО";
            // 
            // PhoneDrivers_name
            // 
            this.PhoneDrivers_name.AutoSize = true;
            this.PhoneDrivers_name.Location = new System.Drawing.Point(6, 85);
            this.PhoneDrivers_name.Name = "PhoneDrivers_name";
            this.PhoneDrivers_name.Size = new System.Drawing.Size(121, 17);
            this.PhoneDrivers_name.TabIndex = 161;
            this.PhoneDrivers_name.Text = "Номер телефона";
            // 
            // SortingDrivers_name
            // 
            this.SortingDrivers_name.AutoSize = true;
            this.SortingDrivers_name.Location = new System.Drawing.Point(6, 113);
            this.SortingDrivers_name.Name = "SortingDrivers_name";
            this.SortingDrivers_name.Size = new System.Drawing.Size(93, 17);
            this.SortingDrivers_name.TabIndex = 163;
            this.SortingDrivers_name.Text = "Сортировать";
            // 
            // FIODrivers
            // 
            this.FIODrivers.Location = new System.Drawing.Point(157, 52);
            this.FIODrivers.Name = "FIODrivers";
            this.FIODrivers.Size = new System.Drawing.Size(263, 22);
            this.FIODrivers.TabIndex = 160;
            // 
            // SortingDrivers
            // 
            this.SortingDrivers.FormattingEnabled = true;
            this.SortingDrivers.Location = new System.Drawing.Point(157, 108);
            this.SortingDrivers.Name = "SortingDrivers";
            this.SortingDrivers.Size = new System.Drawing.Size(263, 24);
            this.SortingDrivers.TabIndex = 164;
            this.SortingDrivers.SelectedIndexChanged += new System.EventHandler(this.SortingDrivers_SelectedIndexChanged);
            // 
            // PhoneDrivers
            // 
            this.PhoneDrivers.Location = new System.Drawing.Point(157, 80);
            this.PhoneDrivers.Name = "PhoneDrivers";
            this.PhoneDrivers.Size = new System.Drawing.Size(263, 22);
            this.PhoneDrivers.TabIndex = 162;
            // 
            // AllDrivers
            // 
            this.AllDrivers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AllDrivers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AllDrivers.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AllDrivers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllDrivers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_driver,
            this.Name_driver,
            this.Phone_driver,
            this.DrivingLisense,
            this.Branch_driver});
            this.AllDrivers.Location = new System.Drawing.Point(12, 179);
            this.AllDrivers.Name = "AllDrivers";
            this.AllDrivers.RowHeadersWidth = 51;
            this.AllDrivers.RowTemplate.Height = 24;
            this.AllDrivers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AllDrivers.Size = new System.Drawing.Size(1171, 474);
            this.AllDrivers.TabIndex = 158;
            this.AllDrivers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AllDrivers_CellDoubleClick);
            // 
            // Id_driver
            // 
            this.Id_driver.HeaderText = "Id";
            this.Id_driver.MinimumWidth = 6;
            this.Id_driver.Name = "Id_driver";
            this.Id_driver.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Name_driver
            // 
            this.Name_driver.HeaderText = "ФИО";
            this.Name_driver.MinimumWidth = 6;
            this.Name_driver.Name = "Name_driver";
            this.Name_driver.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Phone_driver
            // 
            this.Phone_driver.HeaderText = "Телефон";
            this.Phone_driver.MinimumWidth = 6;
            this.Phone_driver.Name = "Phone_driver";
            this.Phone_driver.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // DrivingLisense
            // 
            this.DrivingLisense.HeaderText = "Вод. удостоверение";
            this.DrivingLisense.MinimumWidth = 6;
            this.DrivingLisense.Name = "DrivingLisense";
            this.DrivingLisense.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Branch_driver
            // 
            this.Branch_driver.HeaderText = "Филиал";
            this.Branch_driver.MinimumWidth = 6;
            this.Branch_driver.Name = "Branch_driver";
            this.Branch_driver.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // PageDrivers
            // 
            this.PageDrivers.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.PageDrivers.Location = new System.Drawing.Point(547, 674);
            this.PageDrivers.Margin = new System.Windows.Forms.Padding(4);
            this.PageDrivers.Name = "PageDrivers";
            this.PageDrivers.Size = new System.Drawing.Size(65, 22);
            this.PageDrivers.TabIndex = 203;
            // 
            // PagesDrivers
            // 
            this.PagesDrivers.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.PagesDrivers.AutoSize = true;
            this.PagesDrivers.Location = new System.Drawing.Point(620, 677);
            this.PagesDrivers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PagesDrivers.Name = "PagesDrivers";
            this.PagesDrivers.Size = new System.Drawing.Size(46, 17);
            this.PagesDrivers.TabIndex = 202;
            this.PagesDrivers.Text = "label1";
            // 
            // BackDrivers
            // 
            this.BackDrivers.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BackDrivers.Location = new System.Drawing.Point(393, 673);
            this.BackDrivers.Margin = new System.Windows.Forms.Padding(4);
            this.BackDrivers.Name = "BackDrivers";
            this.BackDrivers.Size = new System.Drawing.Size(71, 25);
            this.BackDrivers.TabIndex = 201;
            this.BackDrivers.Text = "<";
            this.BackDrivers.UseVisualStyleBackColor = true;
            // 
            // ChooseDrivers
            // 
            this.ChooseDrivers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ChooseDrivers.BackColor = System.Drawing.Color.DarkOrange;
            this.ChooseDrivers.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.ChooseDrivers.FlatAppearance.BorderSize = 3;
            this.ChooseDrivers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChooseDrivers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChooseDrivers.ForeColor = System.Drawing.Color.White;
            this.ChooseDrivers.Location = new System.Drawing.Point(12, 673);
            this.ChooseDrivers.Name = "ChooseDrivers";
            this.ChooseDrivers.Size = new System.Drawing.Size(135, 39);
            this.ChooseDrivers.TabIndex = 205;
            this.ChooseDrivers.Text = "Выбрать";
            this.ChooseDrivers.UseVisualStyleBackColor = false;
            this.ChooseDrivers.Click += new System.EventHandler(this.ChooseDrivers_Click);
            this.ChooseDrivers.MouseEnter += new System.EventHandler(this.ChooseDrivers_MouseEnter);
            this.ChooseDrivers.MouseLeave += new System.EventHandler(this.ChooseDrivers_MouseLeave);
            // 
            // AddDrivers
            // 
            this.AddDrivers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddDrivers.BackColor = System.Drawing.Color.DarkOrange;
            this.AddDrivers.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.AddDrivers.FlatAppearance.BorderSize = 2;
            this.AddDrivers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddDrivers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddDrivers.ForeColor = System.Drawing.Color.White;
            this.AddDrivers.Location = new System.Drawing.Point(1048, 669);
            this.AddDrivers.Name = "AddDrivers";
            this.AddDrivers.Size = new System.Drawing.Size(135, 39);
            this.AddDrivers.TabIndex = 204;
            this.AddDrivers.Text = "Добавить";
            this.AddDrivers.UseVisualStyleBackColor = false;
            this.AddDrivers.Click += new System.EventHandler(this.AddDrivers_Click);
            this.AddDrivers.MouseEnter += new System.EventHandler(this.AddDrivers_MouseEnter);
            this.AddDrivers.MouseLeave += new System.EventHandler(this.AddDrivers_MouseLeave);
            // 
            // ToDrivers
            // 
            this.ToDrivers.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ToDrivers.Location = new System.Drawing.Point(689, 673);
            this.ToDrivers.Margin = new System.Windows.Forms.Padding(4);
            this.ToDrivers.Name = "ToDrivers";
            this.ToDrivers.Size = new System.Drawing.Size(71, 25);
            this.ToDrivers.TabIndex = 200;
            this.ToDrivers.Text = ">";
            this.ToDrivers.UseVisualStyleBackColor = true;
            // 
            // FindDrivers
            // 
            this.FindDrivers.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.FindDrivers.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FindDrivers.BackgroundImage")));
            this.FindDrivers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FindDrivers.Location = new System.Drawing.Point(483, 673);
            this.FindDrivers.Margin = new System.Windows.Forms.Padding(4);
            this.FindDrivers.Name = "FindDrivers";
            this.FindDrivers.Size = new System.Drawing.Size(43, 25);
            this.FindDrivers.TabIndex = 232;
            this.FindDrivers.UseVisualStyleBackColor = true;
            // 
            // Drivers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1195, 720);
            this.Controls.Add(this.FindDrivers);
            this.Controls.Add(this.PageDrivers);
            this.Controls.Add(this.PagesDrivers);
            this.Controls.Add(this.BackDrivers);
            this.Controls.Add(this.ChooseDrivers);
            this.Controls.Add(this.AddDrivers);
            this.Controls.Add(this.ToDrivers);
            this.Controls.Add(this.AllDrivers);
            this.Controls.Add(this.DriversFilters);
            this.Name = "Drivers";
            this.Text = "Водители(Drivers)";
            this.Load += new System.EventHandler(this.Drivers_Load);
            this.DriversFilters.ResumeLayout(false);
            this.DriversFilters.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AllDrivers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox DriversFilters;
        private System.Windows.Forms.Label IDDrivers_name;
        private System.Windows.Forms.TextBox IDDrivers;
        private System.Windows.Forms.Label FIODrivers_name;
        private System.Windows.Forms.Label PhoneDrivers_name;
        private System.Windows.Forms.Label SortingDrivers_name;
        private System.Windows.Forms.TextBox SalaryDriversTo;
        private System.Windows.Forms.TextBox SalaryDriversFrom;
        private System.Windows.Forms.Label SalaryDriversTo_name;
        private System.Windows.Forms.Label SalaryDriversFrom_name;
        private System.Windows.Forms.ComboBox SortingDrivers;
        private System.Windows.Forms.TextBox PhoneDrivers;
        private System.Windows.Forms.TextBox FIODrivers;
        private System.Windows.Forms.DataGridView AllDrivers;
        private System.Windows.Forms.TextBox PageDrivers;
        private System.Windows.Forms.Label PagesDrivers;
        private System.Windows.Forms.Button BackDrivers;
        private System.Windows.Forms.Button ChooseDrivers;
        private System.Windows.Forms.Button AddDrivers;
        private System.Windows.Forms.Button ToDrivers;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox All_drivers;
        private System.Windows.Forms.CheckBox C1E_drivers;
        private System.Windows.Forms.CheckBox C1_drivers;
        private System.Windows.Forms.CheckBox CE_drivers;
        private System.Windows.Forms.CheckBox C_drivers;
        private System.Windows.Forms.Label CategoryDrivers_name;
        private System.Windows.Forms.Button BranchDriversChoose;
        private System.Windows.Forms.LinkLabel BranchDrivers;
        private System.Windows.Forms.Label BranchDrivers_name;
        private System.Windows.Forms.Button ResetDrivers;
        private System.Windows.Forms.Button ApplyDrivers;
        private System.Windows.Forms.Button FindDrivers;
        private System.Windows.Forms.Button SortDesc_Drivers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_driver;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_driver;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone_driver;
        private System.Windows.Forms.DataGridViewTextBoxColumn DrivingLisense;
        private System.Windows.Forms.DataGridViewTextBoxColumn Branch_driver;
    }
}