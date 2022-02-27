
namespace form
{
    partial class Cart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cart));
            this.Menu_cart = new System.Windows.Forms.TabControl();
            this.SaveInfoVehicle = new System.Windows.Forms.TabPage();
            this.Info = new System.Windows.Forms.GroupBox();
            this.StartRentDay = new System.Windows.Forms.DateTimePicker();
            this.InfoSave = new System.Windows.Forms.Button();
            this.DeliveryVehicleCartDelete = new System.Windows.Forms.Button();
            this.StartRent_name = new System.Windows.Forms.Label();
            this.DeliveryVehicleCartChoose = new System.Windows.Forms.Button();
            this.EndRent_name = new System.Windows.Forms.Label();
            this.DeliveryVehicleCart = new System.Windows.Forms.LinkLabel();
            this.StartRentTime = new System.Windows.Forms.DateTimePicker();
            this.DeliveryVehicleCart_name = new System.Windows.Forms.Label();
            this.EndRentDay = new System.Windows.Forms.DateTimePicker();
            this.DeliveryDriverCartDelete = new System.Windows.Forms.Button();
            this.EndRentTime = new System.Windows.Forms.DateTimePicker();
            this.DeliveryDriverCartChoose = new System.Windows.Forms.Button();
            this.Duration_name = new System.Windows.Forms.Label();
            this.DeliveryDriverCart = new System.Windows.Forms.LinkLabel();
            this.Duration = new System.Windows.Forms.TextBox();
            this.DeliveryDriverCart_name = new System.Windows.Forms.Label();
            this.DriverInCart_name = new System.Windows.Forms.Label();
            this.DriverInCartDelete = new System.Windows.Forms.Button();
            this.DriverInCart = new System.Windows.Forms.LinkLabel();
            this.DriverInCartChoose = new System.Windows.Forms.Button();
            this.DeleteVehicleCart = new System.Windows.Forms.Button();
            this.AddVehicleCart = new System.Windows.Forms.Button();
            this.VehiclesCart = new System.Windows.Forms.DataGridView();
            this.ID_vehicle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryOfVehicel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrandAndModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GosNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PricePerHour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsNeedDelivery = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.DurationWork = new System.Windows.Forms.TextBox();
            this.EndWorkDay = new System.Windows.Forms.DateTimePicker();
            this.EndWorkTime = new System.Windows.Forms.DateTimePicker();
            this.StartWorkDay = new System.Windows.Forms.DateTimePicker();
            this.StartWorkTime = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.Vehicles = new System.Windows.Forms.Label();
            this.Workers = new System.Windows.Forms.Label();
            this.Choose = new System.Windows.Forms.Button();
            this.Vehicles_name = new System.Windows.Forms.Label();
            this.Workers_name = new System.Windows.Forms.Label();
            this.SaveInfoAddService = new System.Windows.Forms.Button();
            this.EndWork_name = new System.Windows.Forms.Label();
            this.StartWork_name = new System.Windows.Forms.Label();
            this.DeleteServiceCart = new System.Windows.Forms.Button();
            this.AddServiceCart = new System.Windows.Forms.Button();
            this.AddServicesCart = new System.Windows.Forms.DataGridView();
            this.ID_service = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_service = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrintOrder = new System.Windows.Forms.Button();
            this.Menu_cart.SuspendLayout();
            this.SaveInfoVehicle.SuspendLayout();
            this.Info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VehiclesCart)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddServicesCart)).BeginInit();
            this.SuspendLayout();
            // 
            // Menu_cart
            // 
            this.Menu_cart.Controls.Add(this.SaveInfoVehicle);
            this.Menu_cart.Controls.Add(this.tabPage4);
            this.Menu_cart.Location = new System.Drawing.Point(2, 12);
            this.Menu_cart.Name = "Menu_cart";
            this.Menu_cart.SelectedIndex = 0;
            this.Menu_cart.Size = new System.Drawing.Size(914, 634);
            this.Menu_cart.TabIndex = 0;
            // 
            // SaveInfoVehicle
            // 
            this.SaveInfoVehicle.Controls.Add(this.Info);
            this.SaveInfoVehicle.Controls.Add(this.DeleteVehicleCart);
            this.SaveInfoVehicle.Controls.Add(this.AddVehicleCart);
            this.SaveInfoVehicle.Controls.Add(this.VehiclesCart);
            this.SaveInfoVehicle.Location = new System.Drawing.Point(4, 25);
            this.SaveInfoVehicle.Name = "SaveInfoVehicle";
            this.SaveInfoVehicle.Padding = new System.Windows.Forms.Padding(3);
            this.SaveInfoVehicle.Size = new System.Drawing.Size(906, 605);
            this.SaveInfoVehicle.TabIndex = 0;
            this.SaveInfoVehicle.Text = "Техника";
            this.SaveInfoVehicle.UseVisualStyleBackColor = true;
            this.SaveInfoVehicle.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // Info
            // 
            this.Info.Controls.Add(this.StartRentDay);
            this.Info.Controls.Add(this.InfoSave);
            this.Info.Controls.Add(this.DeliveryVehicleCartDelete);
            this.Info.Controls.Add(this.StartRent_name);
            this.Info.Controls.Add(this.DeliveryVehicleCartChoose);
            this.Info.Controls.Add(this.EndRent_name);
            this.Info.Controls.Add(this.DeliveryVehicleCart);
            this.Info.Controls.Add(this.StartRentTime);
            this.Info.Controls.Add(this.DeliveryVehicleCart_name);
            this.Info.Controls.Add(this.EndRentDay);
            this.Info.Controls.Add(this.DeliveryDriverCartDelete);
            this.Info.Controls.Add(this.EndRentTime);
            this.Info.Controls.Add(this.DeliveryDriverCartChoose);
            this.Info.Controls.Add(this.Duration_name);
            this.Info.Controls.Add(this.DeliveryDriverCart);
            this.Info.Controls.Add(this.Duration);
            this.Info.Controls.Add(this.DeliveryDriverCart_name);
            this.Info.Controls.Add(this.DriverInCart_name);
            this.Info.Controls.Add(this.DriverInCartDelete);
            this.Info.Controls.Add(this.DriverInCart);
            this.Info.Controls.Add(this.DriverInCartChoose);
            this.Info.Location = new System.Drawing.Point(12, 396);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(698, 195);
            this.Info.TabIndex = 108;
            this.Info.TabStop = false;
            this.Info.Text = "ID";
            this.Info.Enter += new System.EventHandler(this.Info_Enter);
            // 
            // StartRentDay
            // 
            this.StartRentDay.CustomFormat = "";
            this.StartRentDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.StartRentDay.Location = new System.Drawing.Point(7, 40);
            this.StartRentDay.Name = "StartRentDay";
            this.StartRentDay.Size = new System.Drawing.Size(170, 22);
            this.StartRentDay.TabIndex = 89;
            // 
            // InfoSave
            // 
            this.InfoSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("InfoSave.BackgroundImage")));
            this.InfoSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.InfoSave.Location = new System.Drawing.Point(624, 159);
            this.InfoSave.Name = "InfoSave";
            this.InfoSave.Size = new System.Drawing.Size(68, 28);
            this.InfoSave.TabIndex = 93;
            this.InfoSave.UseVisualStyleBackColor = true;
            this.InfoSave.Click += new System.EventHandler(this.InfoSave_Click);
            // 
            // DeliveryVehicleCartDelete
            // 
            this.DeliveryVehicleCartDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DeliveryVehicleCartDelete.BackgroundImage")));
            this.DeliveryVehicleCartDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DeliveryVehicleCartDelete.Location = new System.Drawing.Point(324, 159);
            this.DeliveryVehicleCartDelete.Name = "DeliveryVehicleCartDelete";
            this.DeliveryVehicleCartDelete.Size = new System.Drawing.Size(35, 23);
            this.DeliveryVehicleCartDelete.TabIndex = 107;
            this.DeliveryVehicleCartDelete.UseVisualStyleBackColor = true;
            // 
            // StartRent_name
            // 
            this.StartRent_name.AutoSize = true;
            this.StartRent_name.Location = new System.Drawing.Point(4, 20);
            this.StartRent_name.Name = "StartRent_name";
            this.StartRent_name.Size = new System.Drawing.Size(112, 17);
            this.StartRent_name.TabIndex = 3;
            this.StartRent_name.Text = "Начало аренды";
            // 
            // DeliveryVehicleCartChoose
            // 
            this.DeliveryVehicleCartChoose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DeliveryVehicleCartChoose.BackgroundImage")));
            this.DeliveryVehicleCartChoose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DeliveryVehicleCartChoose.Location = new System.Drawing.Point(283, 158);
            this.DeliveryVehicleCartChoose.Name = "DeliveryVehicleCartChoose";
            this.DeliveryVehicleCartChoose.Size = new System.Drawing.Size(35, 25);
            this.DeliveryVehicleCartChoose.TabIndex = 106;
            this.DeliveryVehicleCartChoose.UseVisualStyleBackColor = false;
            this.DeliveryVehicleCartChoose.Click += new System.EventHandler(this.DeliveryVehicleCartChoose_Click);
            // 
            // EndRent_name
            // 
            this.EndRent_name.AutoSize = true;
            this.EndRent_name.Location = new System.Drawing.Point(457, 20);
            this.EndRent_name.Name = "EndRent_name";
            this.EndRent_name.Size = new System.Drawing.Size(145, 17);
            this.EndRent_name.TabIndex = 4;
            this.EndRent_name.Text = "Завершение аренды";
            // 
            // DeliveryVehicleCart
            // 
            this.DeliveryVehicleCart.AutoSize = true;
            this.DeliveryVehicleCart.Location = new System.Drawing.Point(168, 162);
            this.DeliveryVehicleCart.Name = "DeliveryVehicleCart";
            this.DeliveryVehicleCart.Size = new System.Drawing.Size(85, 17);
            this.DeliveryVehicleCart.TabIndex = 105;
            this.DeliveryVehicleCart.TabStop = true;
            this.DeliveryVehicleCart.Text = "не выбрано";
            // 
            // StartRentTime
            // 
            this.StartRentTime.CustomFormat = "HH:mm";
            this.StartRentTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.StartRentTime.Location = new System.Drawing.Point(183, 40);
            this.StartRentTime.Name = "StartRentTime";
            this.StartRentTime.ShowUpDown = true;
            this.StartRentTime.Size = new System.Drawing.Size(92, 22);
            this.StartRentTime.TabIndex = 90;
            // 
            // DeliveryVehicleCart_name
            // 
            this.DeliveryVehicleCart_name.AutoSize = true;
            this.DeliveryVehicleCart_name.Location = new System.Drawing.Point(6, 163);
            this.DeliveryVehicleCart_name.Name = "DeliveryVehicleCart_name";
            this.DeliveryVehicleCart_name.Size = new System.Drawing.Size(152, 17);
            this.DeliveryVehicleCart_name.TabIndex = 104;
            this.DeliveryVehicleCart_name.Text = "Доставочная техника";
            // 
            // EndRentDay
            // 
            this.EndRentDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EndRentDay.Location = new System.Drawing.Point(460, 40);
            this.EndRentDay.Name = "EndRentDay";
            this.EndRentDay.Size = new System.Drawing.Size(134, 22);
            this.EndRentDay.TabIndex = 91;
            // 
            // DeliveryDriverCartDelete
            // 
            this.DeliveryDriverCartDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DeliveryDriverCartDelete.BackgroundImage")));
            this.DeliveryDriverCartDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DeliveryDriverCartDelete.Location = new System.Drawing.Point(324, 122);
            this.DeliveryDriverCartDelete.Name = "DeliveryDriverCartDelete";
            this.DeliveryDriverCartDelete.Size = new System.Drawing.Size(35, 23);
            this.DeliveryDriverCartDelete.TabIndex = 103;
            this.DeliveryDriverCartDelete.UseVisualStyleBackColor = true;
            // 
            // EndRentTime
            // 
            this.EndRentTime.CustomFormat = "HH:mm";
            this.EndRentTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EndRentTime.Location = new System.Drawing.Point(600, 40);
            this.EndRentTime.Name = "EndRentTime";
            this.EndRentTime.ShowUpDown = true;
            this.EndRentTime.Size = new System.Drawing.Size(92, 22);
            this.EndRentTime.TabIndex = 92;
            // 
            // DeliveryDriverCartChoose
            // 
            this.DeliveryDriverCartChoose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DeliveryDriverCartChoose.BackgroundImage")));
            this.DeliveryDriverCartChoose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DeliveryDriverCartChoose.Location = new System.Drawing.Point(283, 121);
            this.DeliveryDriverCartChoose.Name = "DeliveryDriverCartChoose";
            this.DeliveryDriverCartChoose.Size = new System.Drawing.Size(35, 25);
            this.DeliveryDriverCartChoose.TabIndex = 102;
            this.DeliveryDriverCartChoose.UseVisualStyleBackColor = false;
            this.DeliveryDriverCartChoose.Click += new System.EventHandler(this.DeliveryDriverCartChoose_Click);
            // 
            // Duration_name
            // 
            this.Duration_name.AutoSize = true;
            this.Duration_name.Location = new System.Drawing.Point(290, 20);
            this.Duration_name.Name = "Duration_name";
            this.Duration_name.Size = new System.Drawing.Size(120, 17);
            this.Duration_name.TabIndex = 94;
            this.Duration_name.Text = "Длительность(ч)";
            // 
            // DeliveryDriverCart
            // 
            this.DeliveryDriverCart.AutoSize = true;
            this.DeliveryDriverCart.Location = new System.Drawing.Point(168, 126);
            this.DeliveryDriverCart.Name = "DeliveryDriverCart";
            this.DeliveryDriverCart.Size = new System.Drawing.Size(85, 17);
            this.DeliveryDriverCart.TabIndex = 101;
            this.DeliveryDriverCart.TabStop = true;
            this.DeliveryDriverCart.Text = "не выбрано";
            // 
            // Duration
            // 
            this.Duration.Location = new System.Drawing.Point(293, 42);
            this.Duration.Name = "Duration";
            this.Duration.Size = new System.Drawing.Size(117, 22);
            this.Duration.TabIndex = 95;
            this.Duration.TextChanged += new System.EventHandler(this.Duration_TextChanged);
            // 
            // DeliveryDriverCart_name
            // 
            this.DeliveryDriverCart_name.AutoSize = true;
            this.DeliveryDriverCart_name.Location = new System.Drawing.Point(6, 129);
            this.DeliveryDriverCart_name.Name = "DeliveryDriverCart_name";
            this.DeliveryDriverCart_name.Size = new System.Drawing.Size(135, 17);
            this.DeliveryDriverCart_name.TabIndex = 100;
            this.DeliveryDriverCart_name.Text = "Водитель доставки";
            // 
            // DriverInCart_name
            // 
            this.DriverInCart_name.AutoSize = true;
            this.DriverInCart_name.Location = new System.Drawing.Point(6, 93);
            this.DriverInCart_name.Name = "DriverInCart_name";
            this.DriverInCart_name.Size = new System.Drawing.Size(71, 17);
            this.DriverInCart_name.TabIndex = 96;
            this.DriverInCart_name.Text = "Водитель";
            // 
            // DriverInCartDelete
            // 
            this.DriverInCartDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DriverInCartDelete.BackgroundImage")));
            this.DriverInCartDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DriverInCartDelete.Location = new System.Drawing.Point(324, 90);
            this.DriverInCartDelete.Name = "DriverInCartDelete";
            this.DriverInCartDelete.Size = new System.Drawing.Size(35, 23);
            this.DriverInCartDelete.TabIndex = 99;
            this.DriverInCartDelete.UseVisualStyleBackColor = true;
            // 
            // DriverInCart
            // 
            this.DriverInCart.AutoSize = true;
            this.DriverInCart.Location = new System.Drawing.Point(168, 97);
            this.DriverInCart.Name = "DriverInCart";
            this.DriverInCart.Size = new System.Drawing.Size(85, 17);
            this.DriverInCart.TabIndex = 97;
            this.DriverInCart.TabStop = true;
            this.DriverInCart.Text = "не выбрано";
            // 
            // DriverInCartChoose
            // 
            this.DriverInCartChoose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DriverInCartChoose.BackgroundImage")));
            this.DriverInCartChoose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DriverInCartChoose.Location = new System.Drawing.Point(283, 89);
            this.DriverInCartChoose.Name = "DriverInCartChoose";
            this.DriverInCartChoose.Size = new System.Drawing.Size(35, 25);
            this.DriverInCartChoose.TabIndex = 98;
            this.DriverInCartChoose.UseVisualStyleBackColor = false;
            this.DriverInCartChoose.Click += new System.EventHandler(this.DriverInCartChoose_Click);
            // 
            // DeleteVehicleCart
            // 
            this.DeleteVehicleCart.Location = new System.Drawing.Point(810, 396);
            this.DeleteVehicleCart.Name = "DeleteVehicleCart";
            this.DeleteVehicleCart.Size = new System.Drawing.Size(88, 28);
            this.DeleteVehicleCart.TabIndex = 2;
            this.DeleteVehicleCart.Text = "Убрать";
            this.DeleteVehicleCart.UseVisualStyleBackColor = true;
            this.DeleteVehicleCart.Click += new System.EventHandler(this.DeleteVehicleCart_Click);
            // 
            // AddVehicleCart
            // 
            this.AddVehicleCart.Location = new System.Drawing.Point(716, 396);
            this.AddVehicleCart.Name = "AddVehicleCart";
            this.AddVehicleCart.Size = new System.Drawing.Size(88, 28);
            this.AddVehicleCart.TabIndex = 1;
            this.AddVehicleCart.Text = "Добавить";
            this.AddVehicleCart.UseVisualStyleBackColor = true;
            this.AddVehicleCart.Click += new System.EventHandler(this.AddVehicleCart_Click);
            // 
            // VehiclesCart
            // 
            this.VehiclesCart.AllowUserToAddRows = false;
            this.VehiclesCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VehiclesCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_vehicle,
            this.CategoryOfVehicel,
            this.BrandAndModel,
            this.GosNum,
            this.PricePerHour,
            this.IsNeedDelivery});
            this.VehiclesCart.Location = new System.Drawing.Point(12, 6);
            this.VehiclesCart.Name = "VehiclesCart";
            this.VehiclesCart.RowHeadersWidth = 51;
            this.VehiclesCart.RowTemplate.Height = 24;
            this.VehiclesCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.VehiclesCart.Size = new System.Drawing.Size(878, 384);
            this.VehiclesCart.TabIndex = 0;
            this.VehiclesCart.SelectionChanged += new System.EventHandler(this.VehiclesCart_SelectionChanged);
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
            this.CategoryOfVehicel.Width = 125;
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
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.DurationWork);
            this.tabPage4.Controls.Add(this.EndWorkDay);
            this.tabPage4.Controls.Add(this.EndWorkTime);
            this.tabPage4.Controls.Add(this.StartWorkDay);
            this.tabPage4.Controls.Add(this.StartWorkTime);
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Controls.Add(this.Vehicles);
            this.tabPage4.Controls.Add(this.Workers);
            this.tabPage4.Controls.Add(this.Choose);
            this.tabPage4.Controls.Add(this.Vehicles_name);
            this.tabPage4.Controls.Add(this.Workers_name);
            this.tabPage4.Controls.Add(this.SaveInfoAddService);
            this.tabPage4.Controls.Add(this.EndWork_name);
            this.tabPage4.Controls.Add(this.StartWork_name);
            this.tabPage4.Controls.Add(this.DeleteServiceCart);
            this.tabPage4.Controls.Add(this.AddServiceCart);
            this.tabPage4.Controls.Add(this.AddServicesCart);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(906, 605);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Доп.услуги";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // DurationWork
            // 
            this.DurationWork.Location = new System.Drawing.Point(456, 505);
            this.DurationWork.Name = "DurationWork";
            this.DurationWork.Size = new System.Drawing.Size(100, 22);
            this.DurationWork.TabIndex = 113;
            this.DurationWork.TextChanged += new System.EventHandler(this.DurationWork_TextChanged_1);
            // 
            // EndWorkDay
            // 
            this.EndWorkDay.CustomFormat = "";
            this.EndWorkDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EndWorkDay.Location = new System.Drawing.Point(165, 511);
            this.EndWorkDay.Name = "EndWorkDay";
            this.EndWorkDay.Size = new System.Drawing.Size(170, 22);
            this.EndWorkDay.TabIndex = 111;
            // 
            // EndWorkTime
            // 
            this.EndWorkTime.CustomFormat = "HH:mm";
            this.EndWorkTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EndWorkTime.Location = new System.Drawing.Point(341, 511);
            this.EndWorkTime.Name = "EndWorkTime";
            this.EndWorkTime.ShowUpDown = true;
            this.EndWorkTime.Size = new System.Drawing.Size(92, 22);
            this.EndWorkTime.TabIndex = 112;
            // 
            // StartWorkDay
            // 
            this.StartWorkDay.CustomFormat = "";
            this.StartWorkDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.StartWorkDay.Location = new System.Drawing.Point(165, 482);
            this.StartWorkDay.Name = "StartWorkDay";
            this.StartWorkDay.Size = new System.Drawing.Size(170, 22);
            this.StartWorkDay.TabIndex = 109;
            // 
            // StartWorkTime
            // 
            this.StartWorkTime.CustomFormat = "HH:mm";
            this.StartWorkTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.StartWorkTime.Location = new System.Drawing.Point(341, 482);
            this.StartWorkTime.Name = "StartWorkTime";
            this.StartWorkTime.ShowUpDown = true;
            this.StartWorkTime.Size = new System.Drawing.Size(92, 22);
            this.StartWorkTime.TabIndex = 110;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(453, 485);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 107;
            this.label1.Text = "Длительность(ч)";
            // 
            // Vehicles
            // 
            this.Vehicles.AutoSize = true;
            this.Vehicles.Location = new System.Drawing.Point(98, 577);
            this.Vehicles.Name = "Vehicles";
            this.Vehicles.Size = new System.Drawing.Size(54, 17);
            this.Vehicles.TabIndex = 106;
            this.Vehicles.Text = "label13";
            // 
            // Workers
            // 
            this.Workers.AutoSize = true;
            this.Workers.Location = new System.Drawing.Point(98, 548);
            this.Workers.Name = "Workers";
            this.Workers.Size = new System.Drawing.Size(54, 17);
            this.Workers.TabIndex = 105;
            this.Workers.Text = "label12";
            // 
            // Choose
            // 
            this.Choose.Location = new System.Drawing.Point(277, 572);
            this.Choose.Name = "Choose";
            this.Choose.Size = new System.Drawing.Size(33, 23);
            this.Choose.TabIndex = 103;
            this.Choose.Text = "...";
            this.Choose.UseVisualStyleBackColor = true;
            this.Choose.Click += new System.EventHandler(this.Choose_Click);
            // 
            // Vehicles_name
            // 
            this.Vehicles_name.AutoSize = true;
            this.Vehicles_name.Location = new System.Drawing.Point(13, 577);
            this.Vehicles_name.Name = "Vehicles_name";
            this.Vehicles_name.Size = new System.Drawing.Size(62, 17);
            this.Vehicles_name.TabIndex = 102;
            this.Vehicles_name.Text = "Техника";
            // 
            // Workers_name
            // 
            this.Workers_name.AutoSize = true;
            this.Workers_name.Location = new System.Drawing.Point(13, 548);
            this.Workers_name.Name = "Workers_name";
            this.Workers_name.Size = new System.Drawing.Size(79, 17);
            this.Workers_name.TabIndex = 101;
            this.Workers_name.Text = "Работники";
            // 
            // SaveInfoAddService
            // 
            this.SaveInfoAddService.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SaveInfoAddService.BackgroundImage")));
            this.SaveInfoAddService.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SaveInfoAddService.Location = new System.Drawing.Point(411, 572);
            this.SaveInfoAddService.Name = "SaveInfoAddService";
            this.SaveInfoAddService.Size = new System.Drawing.Size(36, 26);
            this.SaveInfoAddService.TabIndex = 100;
            this.SaveInfoAddService.UseVisualStyleBackColor = true;
            this.SaveInfoAddService.Click += new System.EventHandler(this.SaveInfoAddService_Click);
            // 
            // EndWork_name
            // 
            this.EndWork_name.AutoSize = true;
            this.EndWork_name.Location = new System.Drawing.Point(13, 516);
            this.EndWork_name.Name = "EndWork_name";
            this.EndWork_name.Size = new System.Drawing.Size(134, 17);
            this.EndWork_name.TabIndex = 95;
            this.EndWork_name.Text = "Завершение работ";
            // 
            // StartWork_name
            // 
            this.StartWork_name.AutoSize = true;
            this.StartWork_name.Location = new System.Drawing.Point(11, 487);
            this.StartWork_name.Name = "StartWork_name";
            this.StartWork_name.Size = new System.Drawing.Size(101, 17);
            this.StartWork_name.TabIndex = 94;
            this.StartWork_name.Text = "Начало работ";
            // 
            // DeleteServiceCart
            // 
            this.DeleteServiceCart.Location = new System.Drawing.Point(706, 548);
            this.DeleteServiceCart.Name = "DeleteServiceCart";
            this.DeleteServiceCart.Size = new System.Drawing.Size(87, 23);
            this.DeleteServiceCart.TabIndex = 4;
            this.DeleteServiceCart.Text = "Убрать";
            this.DeleteServiceCart.UseVisualStyleBackColor = true;
            this.DeleteServiceCart.Click += new System.EventHandler(this.DeleteServiceCart_Click);
            // 
            // AddServiceCart
            // 
            this.AddServiceCart.Location = new System.Drawing.Point(706, 519);
            this.AddServiceCart.Name = "AddServiceCart";
            this.AddServiceCart.Size = new System.Drawing.Size(87, 23);
            this.AddServiceCart.TabIndex = 3;
            this.AddServiceCart.Text = "Добавить";
            this.AddServiceCart.UseVisualStyleBackColor = true;
            this.AddServiceCart.Click += new System.EventHandler(this.AddServiceCart_Click);
            // 
            // AddServicesCart
            // 
            this.AddServicesCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AddServicesCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_service,
            this.Name_service});
            this.AddServicesCart.Location = new System.Drawing.Point(14, 3);
            this.AddServicesCart.Name = "AddServicesCart";
            this.AddServicesCart.RowHeadersWidth = 51;
            this.AddServicesCart.RowTemplate.Height = 24;
            this.AddServicesCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AddServicesCart.Size = new System.Drawing.Size(779, 459);
            this.AddServicesCart.TabIndex = 0;
            this.AddServicesCart.SelectionChanged += new System.EventHandler(this.AddServicesCart_SelectionChanged);
            // 
            // ID_service
            // 
            this.ID_service.HeaderText = "ID";
            this.ID_service.MinimumWidth = 6;
            this.ID_service.Name = "ID_service";
            this.ID_service.Width = 125;
            // 
            // Name_service
            // 
            this.Name_service.HeaderText = "Название";
            this.Name_service.MinimumWidth = 6;
            this.Name_service.Name = "Name_service";
            this.Name_service.Width = 600;
            // 
            // PrintOrder
            // 
            this.PrintOrder.BackColor = System.Drawing.Color.PaleGreen;
            this.PrintOrder.Location = new System.Drawing.Point(769, 646);
            this.PrintOrder.Name = "PrintOrder";
            this.PrintOrder.Size = new System.Drawing.Size(157, 33);
            this.PrintOrder.TabIndex = 1;
            this.PrintOrder.Text = "Сформировать заказ";
            this.PrintOrder.UseVisualStyleBackColor = false;
            this.PrintOrder.Click += new System.EventHandler(this.PrintOrder_Click);
            // 
            // Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 689);
            this.Controls.Add(this.PrintOrder);
            this.Controls.Add(this.Menu_cart);
            this.Name = "Cart";
            this.Text = "Корзина(Cart)";
            this.Load += new System.EventHandler(this.Cart_Load);
            this.Menu_cart.ResumeLayout(false);
            this.SaveInfoVehicle.ResumeLayout(false);
            this.Info.ResumeLayout(false);
            this.Info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VehiclesCart)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddServicesCart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Menu_cart;
        private System.Windows.Forms.TabPage SaveInfoVehicle;
        private System.Windows.Forms.Button DeleteVehicleCart;
        private System.Windows.Forms.Button AddVehicleCart;
        private System.Windows.Forms.DataGridView VehiclesCart;
        private System.Windows.Forms.Button PrintOrder;
        private System.Windows.Forms.Label EndRent_name;
        private System.Windows.Forms.Label StartRent_name;
        private System.Windows.Forms.DateTimePicker EndRentTime;
        private System.Windows.Forms.DateTimePicker EndRentDay;
        private System.Windows.Forms.DateTimePicker StartRentTime;
        private System.Windows.Forms.DateTimePicker StartRentDay;
        private System.Windows.Forms.Button InfoSave;
        private System.Windows.Forms.TextBox Duration;
        private System.Windows.Forms.Label Duration_name;
        private System.Windows.Forms.GroupBox Info;
        private System.Windows.Forms.Button DeliveryVehicleCartDelete;
        private System.Windows.Forms.Button DeliveryVehicleCartChoose;
        private System.Windows.Forms.LinkLabel DeliveryVehicleCart;
        private System.Windows.Forms.Label DeliveryVehicleCart_name;
        private System.Windows.Forms.Button DeliveryDriverCartDelete;
        private System.Windows.Forms.Button DeliveryDriverCartChoose;
        private System.Windows.Forms.LinkLabel DeliveryDriverCart;
        private System.Windows.Forms.Label DeliveryDriverCart_name;
        private System.Windows.Forms.Label DriverInCart_name;
        private System.Windows.Forms.Button DriverInCartDelete;
        private System.Windows.Forms.LinkLabel DriverInCart;
        private System.Windows.Forms.Button DriverInCartChoose;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_vehicle;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryOfVehicel;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrandAndModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn GosNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn PricePerHour;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsNeedDelivery;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DateTimePicker EndWorkDay;
        private System.Windows.Forms.DateTimePicker EndWorkTime;
        private System.Windows.Forms.DateTimePicker StartWorkDay;
        private System.Windows.Forms.DateTimePicker StartWorkTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Vehicles;
        private System.Windows.Forms.Label Workers;
        private System.Windows.Forms.Button Choose;
        private System.Windows.Forms.Label Vehicles_name;
        private System.Windows.Forms.Label Workers_name;
        private System.Windows.Forms.Button SaveInfoAddService;
        private System.Windows.Forms.Label EndWork_name;
        private System.Windows.Forms.Label StartWork_name;
        private System.Windows.Forms.Button DeleteServiceCart;
        private System.Windows.Forms.Button AddServiceCart;
        private System.Windows.Forms.DataGridView AddServicesCart;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_service;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_service;
        private System.Windows.Forms.TextBox DurationWork;
    }
}