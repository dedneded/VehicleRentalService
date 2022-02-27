
namespace form
{
    partial class ServiceDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiceDetails));
            this.MenuVehicleService = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.FindVehiclesDetails = new System.Windows.Forms.Button();
            this.DelVehiclesDetails = new System.Windows.Forms.Button();
            this.PageVehilceDetails = new System.Windows.Forms.TextBox();
            this.PagesVehilceDetails = new System.Windows.Forms.Label();
            this.BackVehilceDetails = new System.Windows.Forms.Button();
            this.AddVehiclesDetails = new System.Windows.Forms.Button();
            this.ToVehilceDetails = new System.Windows.Forms.Button();
            this.VehiclesDetails = new System.Windows.Forms.DataGridView();
            this.ID_vehicle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryOfVehicel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrandAndModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GosNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PricePerHour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsNeedDelivery = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Filters = new System.Windows.Forms.GroupBox();
            this.ApplyVehiclesDetails_name = new System.Windows.Forms.Button();
            this.ResetVehiclesDetails = new System.Windows.Forms.Button();
            this.CategoryVehicle = new System.Windows.Forms.ComboBox();
            this.OrdersVehicle = new System.Windows.Forms.LinkLabel();
            this.ChangeOrdersVehicle = new System.Windows.Forms.Button();
            this.DelOrdersVehicle = new System.Windows.Forms.Button();
            this.OrdersVehicle_name = new System.Windows.Forms.Label();
            this.CategoryVehicle_name = new System.Windows.Forms.Label();
            this.GosNumVehicleDetails = new System.Windows.Forms.TextBox();
            this.IDVehicleDetails = new System.Windows.Forms.TextBox();
            this.GosNumVehicleDetails_name = new System.Windows.Forms.Label();
            this.IDVehicleDetails_name = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Workers = new System.Windows.Forms.DataGridView();
            this.Id_employee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fio_employee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone_employee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role_employee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FindWorkers = new System.Windows.Forms.Button();
            this.PageWorkers = new System.Windows.Forms.TextBox();
            this.PagesWorkers = new System.Windows.Forms.Label();
            this.BackWorkers = new System.Windows.Forms.Button();
            this.DelWorkers = new System.Windows.Forms.Button();
            this.AddWorker = new System.Windows.Forms.Button();
            this.ToWorkers = new System.Windows.Forms.Button();
            this.FiltersWorkers = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ResetFilters = new System.Windows.Forms.Button();
            this.ChangeBranchWorkers = new System.Windows.Forms.Button();
            this.BranchWorkers = new System.Windows.Forms.LinkLabel();
            this.BranchWorkers_name = new System.Windows.Forms.Label();
            this.IDWorker_name = new System.Windows.Forms.Label();
            this.SalaryWorkerTo = new System.Windows.Forms.TextBox();
            this.IDWorker = new System.Windows.Forms.TextBox();
            this.SalaryWorkerTo_name = new System.Windows.Forms.Label();
            this.SalaryWorker = new System.Windows.Forms.TextBox();
            this.SalaryWorker_name = new System.Windows.Forms.Label();
            this.FIOWorker_name = new System.Windows.Forms.Label();
            this.PhoneWorker_name = new System.Windows.Forms.Label();
            this.SortingWorkers_name = new System.Windows.Forms.Label();
            this.FIOWorker = new System.Windows.Forms.TextBox();
            this.SortingWorkers = new System.Windows.Forms.ComboBox();
            this.PhoneWorker = new System.Windows.Forms.TextBox();
            this.SaveDetails = new System.Windows.Forms.Button();
            this.MenuVehicleService.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VehiclesDetails)).BeginInit();
            this.Filters.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Workers)).BeginInit();
            this.FiltersWorkers.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuVehicleService
            // 
            this.MenuVehicleService.Controls.Add(this.tabPage1);
            this.MenuVehicleService.Controls.Add(this.tabPage2);
            this.MenuVehicleService.Location = new System.Drawing.Point(3, 3);
            this.MenuVehicleService.Name = "MenuVehicleService";
            this.MenuVehicleService.SelectedIndex = 0;
            this.MenuVehicleService.Size = new System.Drawing.Size(991, 621);
            this.MenuVehicleService.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.FindVehiclesDetails);
            this.tabPage1.Controls.Add(this.DelVehiclesDetails);
            this.tabPage1.Controls.Add(this.PageVehilceDetails);
            this.tabPage1.Controls.Add(this.PagesVehilceDetails);
            this.tabPage1.Controls.Add(this.BackVehilceDetails);
            this.tabPage1.Controls.Add(this.AddVehiclesDetails);
            this.tabPage1.Controls.Add(this.ToVehilceDetails);
            this.tabPage1.Controls.Add(this.VehiclesDetails);
            this.tabPage1.Controls.Add(this.Filters);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(983, 592);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Техника";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // FindVehiclesDetails
            // 
            this.FindVehiclesDetails.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FindVehiclesDetails.BackgroundImage")));
            this.FindVehiclesDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FindVehiclesDetails.Location = new System.Drawing.Point(322, 558);
            this.FindVehiclesDetails.Margin = new System.Windows.Forms.Padding(4);
            this.FindVehiclesDetails.Name = "FindVehiclesDetails";
            this.FindVehiclesDetails.Size = new System.Drawing.Size(43, 25);
            this.FindVehiclesDetails.TabIndex = 232;
            this.FindVehiclesDetails.UseVisualStyleBackColor = true;
            // 
            // DelVehiclesDetails
            // 
            this.DelVehiclesDetails.Location = new System.Drawing.Point(859, 561);
            this.DelVehiclesDetails.Name = "DelVehiclesDetails";
            this.DelVehiclesDetails.Size = new System.Drawing.Size(94, 25);
            this.DelVehiclesDetails.TabIndex = 213;
            this.DelVehiclesDetails.Text = "Убрать";
            this.DelVehiclesDetails.UseVisualStyleBackColor = true;
            // 
            // PageVehilceDetails
            // 
            this.PageVehilceDetails.Location = new System.Drawing.Point(402, 558);
            this.PageVehilceDetails.Margin = new System.Windows.Forms.Padding(4);
            this.PageVehilceDetails.Name = "PageVehilceDetails";
            this.PageVehilceDetails.Size = new System.Drawing.Size(65, 22);
            this.PageVehilceDetails.TabIndex = 211;
            // 
            // PagesVehilceDetails
            // 
            this.PagesVehilceDetails.AutoSize = true;
            this.PagesVehilceDetails.Location = new System.Drawing.Point(475, 561);
            this.PagesVehilceDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PagesVehilceDetails.Name = "PagesVehilceDetails";
            this.PagesVehilceDetails.Size = new System.Drawing.Size(46, 17);
            this.PagesVehilceDetails.TabIndex = 210;
            this.PagesVehilceDetails.Text = "label1";
            // 
            // BackVehilceDetails
            // 
            this.BackVehilceDetails.Location = new System.Drawing.Point(234, 555);
            this.BackVehilceDetails.Margin = new System.Windows.Forms.Padding(4);
            this.BackVehilceDetails.Name = "BackVehilceDetails";
            this.BackVehilceDetails.Size = new System.Drawing.Size(71, 25);
            this.BackVehilceDetails.TabIndex = 209;
            this.BackVehilceDetails.Text = "<";
            this.BackVehilceDetails.UseVisualStyleBackColor = true;
            // 
            // AddVehiclesDetails
            // 
            this.AddVehiclesDetails.Location = new System.Drawing.Point(17, 557);
            this.AddVehiclesDetails.Name = "AddVehiclesDetails";
            this.AddVehiclesDetails.Size = new System.Drawing.Size(94, 25);
            this.AddVehiclesDetails.TabIndex = 212;
            this.AddVehiclesDetails.Text = "Добавить";
            this.AddVehiclesDetails.UseVisualStyleBackColor = true;
            this.AddVehiclesDetails.Click += new System.EventHandler(this.AddVehiclesDetails_Click);
            // 
            // ToVehilceDetails
            // 
            this.ToVehilceDetails.Location = new System.Drawing.Point(544, 557);
            this.ToVehilceDetails.Margin = new System.Windows.Forms.Padding(4);
            this.ToVehilceDetails.Name = "ToVehilceDetails";
            this.ToVehilceDetails.Size = new System.Drawing.Size(71, 25);
            this.ToVehilceDetails.TabIndex = 208;
            this.ToVehilceDetails.Text = ">";
            this.ToVehilceDetails.UseVisualStyleBackColor = true;
            // 
            // VehiclesDetails
            // 
            this.VehiclesDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VehiclesDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_vehicle,
            this.CategoryOfVehicel,
            this.BrandAndModel,
            this.GosNum,
            this.PricePerHour,
            this.IsNeedDelivery});
            this.VehiclesDetails.Location = new System.Drawing.Point(6, 131);
            this.VehiclesDetails.Name = "VehiclesDetails";
            this.VehiclesDetails.RowHeadersWidth = 51;
            this.VehiclesDetails.RowTemplate.Height = 24;
            this.VehiclesDetails.Size = new System.Drawing.Size(952, 420);
            this.VehiclesDetails.TabIndex = 207;
            // 
            // ID_vehicle
            // 
            this.ID_vehicle.HeaderText = "ID";
            this.ID_vehicle.MinimumWidth = 6;
            this.ID_vehicle.Name = "ID_vehicle";
            this.ID_vehicle.Width = 125;
            // 
            // CategoryOfVehicel
            // 
            this.CategoryOfVehicel.HeaderText = "Категория";
            this.CategoryOfVehicel.MinimumWidth = 6;
            this.CategoryOfVehicel.Name = "CategoryOfVehicel";
            this.CategoryOfVehicel.Width = 200;
            // 
            // BrandAndModel
            // 
            this.BrandAndModel.HeaderText = "Марка и модель";
            this.BrandAndModel.MinimumWidth = 6;
            this.BrandAndModel.Name = "BrandAndModel";
            this.BrandAndModel.Width = 200;
            // 
            // GosNum
            // 
            this.GosNum.HeaderText = "Гос. номер";
            this.GosNum.MinimumWidth = 6;
            this.GosNum.Name = "GosNum";
            this.GosNum.Width = 125;
            // 
            // PricePerHour
            // 
            this.PricePerHour.HeaderText = "Стоимость за час";
            this.PricePerHour.MinimumWidth = 6;
            this.PricePerHour.Name = "PricePerHour";
            this.PricePerHour.Width = 125;
            // 
            // IsNeedDelivery
            // 
            this.IsNeedDelivery.HeaderText = "Нужна доставка";
            this.IsNeedDelivery.MinimumWidth = 6;
            this.IsNeedDelivery.Name = "IsNeedDelivery";
            this.IsNeedDelivery.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IsNeedDelivery.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.IsNeedDelivery.Width = 125;
            // 
            // Filters
            // 
            this.Filters.Controls.Add(this.ApplyVehiclesDetails_name);
            this.Filters.Controls.Add(this.ResetVehiclesDetails);
            this.Filters.Controls.Add(this.CategoryVehicle);
            this.Filters.Controls.Add(this.OrdersVehicle);
            this.Filters.Controls.Add(this.ChangeOrdersVehicle);
            this.Filters.Controls.Add(this.DelOrdersVehicle);
            this.Filters.Controls.Add(this.OrdersVehicle_name);
            this.Filters.Controls.Add(this.CategoryVehicle_name);
            this.Filters.Controls.Add(this.GosNumVehicleDetails);
            this.Filters.Controls.Add(this.IDVehicleDetails);
            this.Filters.Controls.Add(this.GosNumVehicleDetails_name);
            this.Filters.Controls.Add(this.IDVehicleDetails_name);
            this.Filters.Location = new System.Drawing.Point(4, 5);
            this.Filters.Name = "Filters";
            this.Filters.Size = new System.Drawing.Size(952, 120);
            this.Filters.TabIndex = 206;
            this.Filters.TabStop = false;
            this.Filters.Text = "Фильтры";
            // 
            // ApplyVehiclesDetails_name
            // 
            this.ApplyVehiclesDetails_name.Location = new System.Drawing.Point(802, 14);
            this.ApplyVehiclesDetails_name.Name = "ApplyVehiclesDetails_name";
            this.ApplyVehiclesDetails_name.Size = new System.Drawing.Size(144, 27);
            this.ApplyVehiclesDetails_name.TabIndex = 206;
            this.ApplyVehiclesDetails_name.Text = "Применить";
            this.ApplyVehiclesDetails_name.UseVisualStyleBackColor = true;
            // 
            // ResetVehiclesDetails
            // 
            this.ResetVehiclesDetails.Location = new System.Drawing.Point(802, 50);
            this.ResetVehiclesDetails.Name = "ResetVehiclesDetails";
            this.ResetVehiclesDetails.Size = new System.Drawing.Size(144, 27);
            this.ResetVehiclesDetails.TabIndex = 205;
            this.ResetVehiclesDetails.Text = "Сбросить";
            this.ResetVehiclesDetails.UseVisualStyleBackColor = true;
            // 
            // CategoryVehicle
            // 
            this.CategoryVehicle.FormattingEnabled = true;
            this.CategoryVehicle.Location = new System.Drawing.Point(138, 78);
            this.CategoryVehicle.Name = "CategoryVehicle";
            this.CategoryVehicle.Size = new System.Drawing.Size(153, 24);
            this.CategoryVehicle.TabIndex = 196;
            // 
            // OrdersVehicle
            // 
            this.OrdersVehicle.AutoSize = true;
            this.OrdersVehicle.Location = new System.Drawing.Point(412, 20);
            this.OrdersVehicle.Name = "OrdersVehicle";
            this.OrdersVehicle.Size = new System.Drawing.Size(85, 17);
            this.OrdersVehicle.TabIndex = 195;
            this.OrdersVehicle.TabStop = true;
            this.OrdersVehicle.Text = "не выбрано";
            // 
            // ChangeOrdersVehicle
            // 
            this.ChangeOrdersVehicle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ChangeOrdersVehicle.BackgroundImage")));
            this.ChangeOrdersVehicle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ChangeOrdersVehicle.Location = new System.Drawing.Point(559, 17);
            this.ChangeOrdersVehicle.Name = "ChangeOrdersVehicle";
            this.ChangeOrdersVehicle.Size = new System.Drawing.Size(35, 25);
            this.ChangeOrdersVehicle.TabIndex = 194;
            this.ChangeOrdersVehicle.UseVisualStyleBackColor = false;
            this.ChangeOrdersVehicle.Click += new System.EventHandler(this.ChangeOrdersVehicle_Click);
            // 
            // DelOrdersVehicle
            // 
            this.DelOrdersVehicle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DelOrdersVehicle.BackgroundImage")));
            this.DelOrdersVehicle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DelOrdersVehicle.Location = new System.Drawing.Point(600, 17);
            this.DelOrdersVehicle.Name = "DelOrdersVehicle";
            this.DelOrdersVehicle.Size = new System.Drawing.Size(35, 25);
            this.DelOrdersVehicle.TabIndex = 193;
            this.DelOrdersVehicle.UseVisualStyleBackColor = true;
            // 
            // OrdersVehicle_name
            // 
            this.OrdersVehicle_name.AutoSize = true;
            this.OrdersVehicle_name.Location = new System.Drawing.Point(359, 20);
            this.OrdersVehicle_name.Name = "OrdersVehicle_name";
            this.OrdersVehicle_name.Size = new System.Drawing.Size(47, 17);
            this.OrdersVehicle_name.TabIndex = 80;
            this.OrdersVehicle_name.Text = "Заказ";
            // 
            // CategoryVehicle_name
            // 
            this.CategoryVehicle_name.AutoSize = true;
            this.CategoryVehicle_name.Location = new System.Drawing.Point(15, 81);
            this.CategoryVehicle_name.Name = "CategoryVehicle_name";
            this.CategoryVehicle_name.Size = new System.Drawing.Size(77, 17);
            this.CategoryVehicle_name.TabIndex = 76;
            this.CategoryVehicle_name.Text = "Категория";
            // 
            // GosNumVehicleDetails
            // 
            this.GosNumVehicleDetails.Location = new System.Drawing.Point(138, 50);
            this.GosNumVehicleDetails.Name = "GosNumVehicleDetails";
            this.GosNumVehicleDetails.Size = new System.Drawing.Size(153, 22);
            this.GosNumVehicleDetails.TabIndex = 74;
            // 
            // IDVehicleDetails
            // 
            this.IDVehicleDetails.Location = new System.Drawing.Point(138, 22);
            this.IDVehicleDetails.Name = "IDVehicleDetails";
            this.IDVehicleDetails.Size = new System.Drawing.Size(153, 22);
            this.IDVehicleDetails.TabIndex = 75;
            // 
            // GosNumVehicleDetails_name
            // 
            this.GosNumVehicleDetails_name.AutoSize = true;
            this.GosNumVehicleDetails_name.Location = new System.Drawing.Point(15, 53);
            this.GosNumVehicleDetails_name.Name = "GosNumVehicleDetails_name";
            this.GosNumVehicleDetails_name.Size = new System.Drawing.Size(80, 17);
            this.GosNumVehicleDetails_name.TabIndex = 73;
            this.GosNumVehicleDetails_name.Text = "Гос. номер";
            // 
            // IDVehicleDetails_name
            // 
            this.IDVehicleDetails_name.AutoSize = true;
            this.IDVehicleDetails_name.Location = new System.Drawing.Point(15, 25);
            this.IDVehicleDetails_name.Name = "IDVehicleDetails_name";
            this.IDVehicleDetails_name.Size = new System.Drawing.Size(21, 17);
            this.IDVehicleDetails_name.TabIndex = 74;
            this.IDVehicleDetails_name.Text = "ID";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Workers);
            this.tabPage2.Controls.Add(this.FindWorkers);
            this.tabPage2.Controls.Add(this.PageWorkers);
            this.tabPage2.Controls.Add(this.PagesWorkers);
            this.tabPage2.Controls.Add(this.BackWorkers);
            this.tabPage2.Controls.Add(this.DelWorkers);
            this.tabPage2.Controls.Add(this.AddWorker);
            this.tabPage2.Controls.Add(this.ToWorkers);
            this.tabPage2.Controls.Add(this.FiltersWorkers);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(983, 592);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Работники";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Workers
            // 
            this.Workers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Workers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_employee,
            this.Fio_employee,
            this.Phone_employee,
            this.Role_employee});
            this.Workers.Location = new System.Drawing.Point(15, 165);
            this.Workers.Name = "Workers";
            this.Workers.RowHeadersWidth = 51;
            this.Workers.RowTemplate.Height = 24;
            this.Workers.Size = new System.Drawing.Size(823, 360);
            this.Workers.TabIndex = 234;
            // 
            // Id_employee
            // 
            this.Id_employee.HeaderText = "Id";
            this.Id_employee.MinimumWidth = 6;
            this.Id_employee.Name = "Id_employee";
            this.Id_employee.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Id_employee.Width = 70;
            // 
            // Fio_employee
            // 
            this.Fio_employee.HeaderText = "ФИО";
            this.Fio_employee.MinimumWidth = 6;
            this.Fio_employee.Name = "Fio_employee";
            this.Fio_employee.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Fio_employee.Width = 300;
            // 
            // Phone_employee
            // 
            this.Phone_employee.HeaderText = "Телефон";
            this.Phone_employee.MinimumWidth = 6;
            this.Phone_employee.Name = "Phone_employee";
            this.Phone_employee.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Phone_employee.Width = 150;
            // 
            // Role_employee
            // 
            this.Role_employee.HeaderText = "Должность";
            this.Role_employee.MinimumWidth = 6;
            this.Role_employee.Name = "Role_employee";
            this.Role_employee.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Role_employee.Width = 250;
            // 
            // FindWorkers
            // 
            this.FindWorkers.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FindWorkers.BackgroundImage")));
            this.FindWorkers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FindWorkers.Location = new System.Drawing.Point(351, 547);
            this.FindWorkers.Margin = new System.Windows.Forms.Padding(4);
            this.FindWorkers.Name = "FindWorkers";
            this.FindWorkers.Size = new System.Drawing.Size(43, 25);
            this.FindWorkers.TabIndex = 233;
            this.FindWorkers.UseVisualStyleBackColor = true;
            // 
            // PageWorkers
            // 
            this.PageWorkers.Location = new System.Drawing.Point(411, 550);
            this.PageWorkers.Margin = new System.Windows.Forms.Padding(4);
            this.PageWorkers.Name = "PageWorkers";
            this.PageWorkers.Size = new System.Drawing.Size(65, 22);
            this.PageWorkers.TabIndex = 229;
            // 
            // PagesWorkers
            // 
            this.PagesWorkers.AutoSize = true;
            this.PagesWorkers.Location = new System.Drawing.Point(498, 551);
            this.PagesWorkers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PagesWorkers.Name = "PagesWorkers";
            this.PagesWorkers.Size = new System.Drawing.Size(46, 17);
            this.PagesWorkers.TabIndex = 228;
            this.PagesWorkers.Text = "label1";
            // 
            // BackWorkers
            // 
            this.BackWorkers.Location = new System.Drawing.Point(262, 547);
            this.BackWorkers.Margin = new System.Windows.Forms.Padding(4);
            this.BackWorkers.Name = "BackWorkers";
            this.BackWorkers.Size = new System.Drawing.Size(71, 25);
            this.BackWorkers.TabIndex = 227;
            this.BackWorkers.Text = "<";
            this.BackWorkers.UseVisualStyleBackColor = true;
            // 
            // DelWorkers
            // 
            this.DelWorkers.Location = new System.Drawing.Point(882, 544);
            this.DelWorkers.Name = "DelWorkers";
            this.DelWorkers.Size = new System.Drawing.Size(95, 24);
            this.DelWorkers.TabIndex = 231;
            this.DelWorkers.Text = "Убрать";
            this.DelWorkers.UseVisualStyleBackColor = true;
            // 
            // AddWorker
            // 
            this.AddWorker.Location = new System.Drawing.Point(15, 551);
            this.AddWorker.Name = "AddWorker";
            this.AddWorker.Size = new System.Drawing.Size(94, 25);
            this.AddWorker.TabIndex = 230;
            this.AddWorker.Text = "Добавить";
            this.AddWorker.UseVisualStyleBackColor = true;
            this.AddWorker.Click += new System.EventHandler(this.AddWorker_Click);
            // 
            // ToWorkers
            // 
            this.ToWorkers.Location = new System.Drawing.Point(569, 547);
            this.ToWorkers.Margin = new System.Windows.Forms.Padding(4);
            this.ToWorkers.Name = "ToWorkers";
            this.ToWorkers.Size = new System.Drawing.Size(71, 25);
            this.ToWorkers.TabIndex = 226;
            this.ToWorkers.Text = ">";
            this.ToWorkers.UseVisualStyleBackColor = true;
            // 
            // FiltersWorkers
            // 
            this.FiltersWorkers.Controls.Add(this.button1);
            this.FiltersWorkers.Controls.Add(this.ResetFilters);
            this.FiltersWorkers.Controls.Add(this.ChangeBranchWorkers);
            this.FiltersWorkers.Controls.Add(this.BranchWorkers);
            this.FiltersWorkers.Controls.Add(this.BranchWorkers_name);
            this.FiltersWorkers.Controls.Add(this.IDWorker_name);
            this.FiltersWorkers.Controls.Add(this.SalaryWorkerTo);
            this.FiltersWorkers.Controls.Add(this.IDWorker);
            this.FiltersWorkers.Controls.Add(this.SalaryWorkerTo_name);
            this.FiltersWorkers.Controls.Add(this.SalaryWorker);
            this.FiltersWorkers.Controls.Add(this.SalaryWorker_name);
            this.FiltersWorkers.Controls.Add(this.FIOWorker_name);
            this.FiltersWorkers.Controls.Add(this.PhoneWorker_name);
            this.FiltersWorkers.Controls.Add(this.SortingWorkers_name);
            this.FiltersWorkers.Controls.Add(this.FIOWorker);
            this.FiltersWorkers.Controls.Add(this.SortingWorkers);
            this.FiltersWorkers.Controls.Add(this.PhoneWorker);
            this.FiltersWorkers.Location = new System.Drawing.Point(6, 6);
            this.FiltersWorkers.Name = "FiltersWorkers";
            this.FiltersWorkers.Size = new System.Drawing.Size(971, 153);
            this.FiltersWorkers.TabIndex = 224;
            this.FiltersWorkers.TabStop = false;
            this.FiltersWorkers.Text = "Фильтры";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(784, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 25);
            this.button1.TabIndex = 203;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ResetFilters
            // 
            this.ResetFilters.Location = new System.Drawing.Point(820, 21);
            this.ResetFilters.Name = "ResetFilters";
            this.ResetFilters.Size = new System.Drawing.Size(151, 27);
            this.ResetFilters.TabIndex = 202;
            this.ResetFilters.Text = "Сбросить фильтры";
            this.ResetFilters.UseVisualStyleBackColor = true;
            // 
            // ChangeBranchWorkers
            // 
            this.ChangeBranchWorkers.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ChangeBranchWorkers.BackgroundImage")));
            this.ChangeBranchWorkers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ChangeBranchWorkers.Location = new System.Drawing.Point(743, 35);
            this.ChangeBranchWorkers.Name = "ChangeBranchWorkers";
            this.ChangeBranchWorkers.Size = new System.Drawing.Size(35, 25);
            this.ChangeBranchWorkers.TabIndex = 187;
            this.ChangeBranchWorkers.UseVisualStyleBackColor = false;
            this.ChangeBranchWorkers.Click += new System.EventHandler(this.ChangeBranchWorkers_Click);
            // 
            // BranchWorkers
            // 
            this.BranchWorkers.AutoSize = true;
            this.BranchWorkers.Location = new System.Drawing.Point(619, 37);
            this.BranchWorkers.Name = "BranchWorkers";
            this.BranchWorkers.Size = new System.Drawing.Size(85, 17);
            this.BranchWorkers.TabIndex = 186;
            this.BranchWorkers.TabStop = true;
            this.BranchWorkers.Text = "не выбрано";
            // 
            // BranchWorkers_name
            // 
            this.BranchWorkers_name.AutoSize = true;
            this.BranchWorkers_name.Location = new System.Drawing.Point(526, 37);
            this.BranchWorkers_name.Name = "BranchWorkers_name";
            this.BranchWorkers_name.Size = new System.Drawing.Size(61, 17);
            this.BranchWorkers_name.TabIndex = 185;
            this.BranchWorkers_name.Text = "Филиал";
            // 
            // IDWorker_name
            // 
            this.IDWorker_name.AutoSize = true;
            this.IDWorker_name.Location = new System.Drawing.Point(6, 35);
            this.IDWorker_name.Name = "IDWorker_name";
            this.IDWorker_name.Size = new System.Drawing.Size(21, 17);
            this.IDWorker_name.TabIndex = 194;
            this.IDWorker_name.Text = "ID";
            // 
            // SalaryWorkerTo
            // 
            this.SalaryWorkerTo.Location = new System.Drawing.Point(631, 91);
            this.SalaryWorkerTo.Name = "SalaryWorkerTo";
            this.SalaryWorkerTo.Size = new System.Drawing.Size(169, 22);
            this.SalaryWorkerTo.TabIndex = 201;
            // 
            // IDWorker
            // 
            this.IDWorker.Location = new System.Drawing.Point(134, 32);
            this.IDWorker.Name = "IDWorker";
            this.IDWorker.Size = new System.Drawing.Size(263, 22);
            this.IDWorker.TabIndex = 195;
            // 
            // SalaryWorkerTo_name
            // 
            this.SalaryWorkerTo_name.AutoSize = true;
            this.SalaryWorkerTo_name.Location = new System.Drawing.Point(535, 94);
            this.SalaryWorkerTo_name.Name = "SalaryWorkerTo_name";
            this.SalaryWorkerTo_name.Size = new System.Drawing.Size(49, 17);
            this.SalaryWorkerTo_name.TabIndex = 199;
            this.SalaryWorkerTo_name.Text = "З/п до";
            // 
            // SalaryWorker
            // 
            this.SalaryWorker.Location = new System.Drawing.Point(631, 63);
            this.SalaryWorker.Name = "SalaryWorker";
            this.SalaryWorker.Size = new System.Drawing.Size(169, 22);
            this.SalaryWorker.TabIndex = 200;
            // 
            // SalaryWorker_name
            // 
            this.SalaryWorker_name.AutoSize = true;
            this.SalaryWorker_name.Location = new System.Drawing.Point(535, 66);
            this.SalaryWorker_name.Name = "SalaryWorker_name";
            this.SalaryWorker_name.Size = new System.Drawing.Size(48, 17);
            this.SalaryWorker_name.TabIndex = 196;
            this.SalaryWorker_name.Text = "З/п от";
            // 
            // FIOWorker_name
            // 
            this.FIOWorker_name.AutoSize = true;
            this.FIOWorker_name.Location = new System.Drawing.Point(6, 63);
            this.FIOWorker_name.Name = "FIOWorker_name";
            this.FIOWorker_name.Size = new System.Drawing.Size(42, 17);
            this.FIOWorker_name.TabIndex = 188;
            this.FIOWorker_name.Text = "ФИО";
            // 
            // PhoneWorker_name
            // 
            this.PhoneWorker_name.AutoSize = true;
            this.PhoneWorker_name.Location = new System.Drawing.Point(6, 91);
            this.PhoneWorker_name.Name = "PhoneWorker_name";
            this.PhoneWorker_name.Size = new System.Drawing.Size(121, 17);
            this.PhoneWorker_name.TabIndex = 190;
            this.PhoneWorker_name.Text = "Номер телефона";
            // 
            // SortingWorkers_name
            // 
            this.SortingWorkers_name.AutoSize = true;
            this.SortingWorkers_name.Location = new System.Drawing.Point(6, 119);
            this.SortingWorkers_name.Name = "SortingWorkers_name";
            this.SortingWorkers_name.Size = new System.Drawing.Size(93, 17);
            this.SortingWorkers_name.TabIndex = 192;
            this.SortingWorkers_name.Text = "Сортировать";
            // 
            // FIOWorker
            // 
            this.FIOWorker.Location = new System.Drawing.Point(134, 60);
            this.FIOWorker.Name = "FIOWorker";
            this.FIOWorker.Size = new System.Drawing.Size(263, 22);
            this.FIOWorker.TabIndex = 189;
            // 
            // SortingWorkers
            // 
            this.SortingWorkers.FormattingEnabled = true;
            this.SortingWorkers.Location = new System.Drawing.Point(134, 116);
            this.SortingWorkers.Name = "SortingWorkers";
            this.SortingWorkers.Size = new System.Drawing.Size(263, 24);
            this.SortingWorkers.TabIndex = 193;
            // 
            // PhoneWorker
            // 
            this.PhoneWorker.Location = new System.Drawing.Point(134, 88);
            this.PhoneWorker.Name = "PhoneWorker";
            this.PhoneWorker.Size = new System.Drawing.Size(263, 22);
            this.PhoneWorker.TabIndex = 191;
            // 
            // SaveDetails
            // 
            this.SaveDetails.BackColor = System.Drawing.Color.PaleGreen;
            this.SaveDetails.Location = new System.Drawing.Point(833, 630);
            this.SaveDetails.Name = "SaveDetails";
            this.SaveDetails.Size = new System.Drawing.Size(157, 33);
            this.SaveDetails.TabIndex = 2;
            this.SaveDetails.Text = "Сохранить";
            this.SaveDetails.UseVisualStyleBackColor = false;
            this.SaveDetails.Click += new System.EventHandler(this.SaveDetails_Click);
            // 
            // ServiceDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 681);
            this.Controls.Add(this.SaveDetails);
            this.Controls.Add(this.MenuVehicleService);
            this.Name = "ServiceDetails";
            this.Text = "Техника и работники услуги(ServiceDetails)";
            this.Load += new System.EventHandler(this.ServiceDetails_Load);
            this.MenuVehicleService.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VehiclesDetails)).EndInit();
            this.Filters.ResumeLayout(false);
            this.Filters.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Workers)).EndInit();
            this.FiltersWorkers.ResumeLayout(false);
            this.FiltersWorkers.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MenuVehicleService;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox PageVehilceDetails;
        private System.Windows.Forms.Label PagesVehilceDetails;
        private System.Windows.Forms.Button BackVehilceDetails;
        private System.Windows.Forms.Button AddVehiclesDetails;
        private System.Windows.Forms.Button ToVehilceDetails;
        private System.Windows.Forms.DataGridView VehiclesDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_vehicle;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryOfVehicel;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrandAndModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn GosNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn PricePerHour;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsNeedDelivery;
        private System.Windows.Forms.GroupBox Filters;
        private System.Windows.Forms.ComboBox CategoryVehicle;
        private System.Windows.Forms.LinkLabel OrdersVehicle;
        private System.Windows.Forms.Button ChangeOrdersVehicle;
        private System.Windows.Forms.Button DelOrdersVehicle;
        private System.Windows.Forms.Label OrdersVehicle_name;
        private System.Windows.Forms.Label CategoryVehicle_name;
        private System.Windows.Forms.TextBox GosNumVehicleDetails;
        private System.Windows.Forms.TextBox IDVehicleDetails;
        private System.Windows.Forms.Label GosNumVehicleDetails_name;
        private System.Windows.Forms.Label IDVehicleDetails_name;
        private System.Windows.Forms.Button DelVehiclesDetails;
        private System.Windows.Forms.TextBox PageWorkers;
        private System.Windows.Forms.Label PagesWorkers;
        private System.Windows.Forms.Button BackWorkers;
        private System.Windows.Forms.Button DelWorkers;
        private System.Windows.Forms.Button AddWorker;
        private System.Windows.Forms.Button ToWorkers;
        private System.Windows.Forms.GroupBox FiltersWorkers;
        private System.Windows.Forms.Button ResetFilters;
        private System.Windows.Forms.Button ChangeBranchWorkers;
        private System.Windows.Forms.LinkLabel BranchWorkers;
        private System.Windows.Forms.Label BranchWorkers_name;
        private System.Windows.Forms.Label IDWorker_name;
        private System.Windows.Forms.TextBox SalaryWorkerTo;
        private System.Windows.Forms.TextBox IDWorker;
        private System.Windows.Forms.Label SalaryWorkerTo_name;
        private System.Windows.Forms.TextBox SalaryWorker;
        private System.Windows.Forms.Label SalaryWorker_name;
        private System.Windows.Forms.Label FIOWorker_name;
        private System.Windows.Forms.Label PhoneWorker_name;
        private System.Windows.Forms.Label SortingWorkers_name;
        private System.Windows.Forms.TextBox FIOWorker;
        private System.Windows.Forms.ComboBox SortingWorkers;
        private System.Windows.Forms.TextBox PhoneWorker;
        private System.Windows.Forms.Button ApplyVehiclesDetails_name;
        private System.Windows.Forms.Button ResetVehiclesDetails;
        private System.Windows.Forms.Button FindVehiclesDetails;
        private System.Windows.Forms.Button FindWorkers;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView Workers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_employee;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fio_employee;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone_employee;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role_employee;
        private System.Windows.Forms.Button SaveDetails;
    }
}