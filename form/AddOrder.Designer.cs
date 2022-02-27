
namespace form
{
    partial class AddOrder
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddOrder));
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.Find_discounts = new System.Windows.Forms.Button();
            this.Page_discounts = new System.Windows.Forms.TextBox();
            this.AllPages_discounts = new System.Windows.Forms.Label();
            this.Back_discounts = new System.Windows.Forms.Button();
            this.Choose_discounts = new System.Windows.Forms.Button();
            this.Add_discounts = new System.Windows.Forms.Button();
            this.Forward_discounts = new System.Windows.Forms.Button();
            this.Discounts = new System.Windows.Forms.DataGridView();
            this.ID_discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceModifier_Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.DelService = new System.Windows.Forms.Button();
            this.FindServices = new System.Windows.Forms.Button();
            this.PageServices = new System.Windows.Forms.TextBox();
            this.AllPagesServices = new System.Windows.Forms.Label();
            this.BackServices = new System.Windows.Forms.Button();
            this.Choose = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.ForwardServices = new System.Windows.Forms.Button();
            this.Services = new System.Windows.Forms.DataGridView();
            this.Name_servcie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Driver_service = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vehicle_service = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeliveryDriver_service = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeliviryVehicle_service = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Start_service = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.End_service = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartFrom_service = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndFrom_service = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.CommOrder = new System.Windows.Forms.TextBox();
            this.ClientName = new System.Windows.Forms.LinkLabel();
            this.IDOrder = new System.Windows.Forms.Label();
            this.IDOrder_name = new System.Windows.Forms.Label();
            this.CancelOrder = new System.Windows.Forms.Button();
            this.SaveOrder = new System.Windows.Forms.Button();
            this.AddClient = new System.Windows.Forms.Button();
            this.ChooseClient = new System.Windows.Forms.Button();
            this.EndOrderTime = new System.Windows.Forms.DateTimePicker();
            this.EndOrderDate = new System.Windows.Forms.DateTimePicker();
            this.EndOrder_name = new System.Windows.Forms.Label();
            this.CreateOrderTime = new System.Windows.Forms.DateTimePicker();
            this.CreateOrderDate = new System.Windows.Forms.DateTimePicker();
            this.CreateOrder_name = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.TextBox();
            this.Client_name = new System.Windows.Forms.Label();
            this.ServiceQuantity = new System.Windows.Forms.Label();
            this.AllPrice = new System.Windows.Forms.Label();
            this.AllPrice_name = new System.Windows.Forms.Label();
            this.ServiceQuantity_name = new System.Windows.Forms.Label();
            this.CommOrder_name = new System.Windows.Forms.Label();
            this.ByCash = new System.Windows.Forms.CheckBox();
            this.Price = new System.Windows.Forms.Label();
            this.Price_name = new System.Windows.Forms.Label();
            this.Distance = new System.Windows.Forms.Label();
            this.Distance_name = new System.Windows.Forms.Label();
            this.Address_name = new System.Windows.Forms.Label();
            this.Menu_Order = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Discounts)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Services)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.Menu_Order.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.Find_discounts);
            this.tabPage4.Controls.Add(this.Page_discounts);
            this.tabPage4.Controls.Add(this.AllPages_discounts);
            this.tabPage4.Controls.Add(this.Back_discounts);
            this.tabPage4.Controls.Add(this.Choose_discounts);
            this.tabPage4.Controls.Add(this.Add_discounts);
            this.tabPage4.Controls.Add(this.Forward_discounts);
            this.tabPage4.Controls.Add(this.Discounts);
            this.tabPage4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1318, 506);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Скидки";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // Find_discounts
            // 
            this.Find_discounts.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Find_discounts.BackgroundImage")));
            this.Find_discounts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Find_discounts.Location = new System.Drawing.Point(101, 461);
            this.Find_discounts.Margin = new System.Windows.Forms.Padding(4);
            this.Find_discounts.Name = "Find_discounts";
            this.Find_discounts.Size = new System.Drawing.Size(43, 25);
            this.Find_discounts.TabIndex = 231;
            this.Find_discounts.UseVisualStyleBackColor = true;
            // 
            // Page_discounts
            // 
            this.Page_discounts.Location = new System.Drawing.Point(166, 462);
            this.Page_discounts.Margin = new System.Windows.Forms.Padding(4);
            this.Page_discounts.Name = "Page_discounts";
            this.Page_discounts.Size = new System.Drawing.Size(65, 22);
            this.Page_discounts.TabIndex = 227;
            // 
            // AllPages_discounts
            // 
            this.AllPages_discounts.AutoSize = true;
            this.AllPages_discounts.Location = new System.Drawing.Point(239, 466);
            this.AllPages_discounts.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AllPages_discounts.Name = "AllPages_discounts";
            this.AllPages_discounts.Size = new System.Drawing.Size(46, 17);
            this.AllPages_discounts.TabIndex = 226;
            this.AllPages_discounts.Text = "label1";
            // 
            // Back_discounts
            // 
            this.Back_discounts.Location = new System.Drawing.Point(12, 461);
            this.Back_discounts.Margin = new System.Windows.Forms.Padding(4);
            this.Back_discounts.Name = "Back_discounts";
            this.Back_discounts.Size = new System.Drawing.Size(71, 25);
            this.Back_discounts.TabIndex = 225;
            this.Back_discounts.Text = "<";
            this.Back_discounts.UseVisualStyleBackColor = true;
            // 
            // Choose_discounts
            // 
            this.Choose_discounts.Location = new System.Drawing.Point(471, 460);
            this.Choose_discounts.Name = "Choose_discounts";
            this.Choose_discounts.Size = new System.Drawing.Size(95, 25);
            this.Choose_discounts.TabIndex = 229;
            this.Choose_discounts.Text = "Выбрать";
            this.Choose_discounts.UseVisualStyleBackColor = true;
            // 
            // Add_discounts
            // 
            this.Add_discounts.Location = new System.Drawing.Point(371, 459);
            this.Add_discounts.Name = "Add_discounts";
            this.Add_discounts.Size = new System.Drawing.Size(94, 25);
            this.Add_discounts.TabIndex = 228;
            this.Add_discounts.Text = "Добавить";
            this.Add_discounts.UseVisualStyleBackColor = true;
            this.Add_discounts.Click += new System.EventHandler(this.Add_discounts_Click);
            // 
            // Forward_discounts
            // 
            this.Forward_discounts.Location = new System.Drawing.Point(293, 460);
            this.Forward_discounts.Margin = new System.Windows.Forms.Padding(4);
            this.Forward_discounts.Name = "Forward_discounts";
            this.Forward_discounts.Size = new System.Drawing.Size(71, 25);
            this.Forward_discounts.TabIndex = 224;
            this.Forward_discounts.Text = ">";
            this.Forward_discounts.UseVisualStyleBackColor = true;
            // 
            // Discounts
            // 
            this.Discounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Discounts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_discount,
            this.Name_discount,
            this.PriceModifier_Discount});
            this.Discounts.Location = new System.Drawing.Point(12, 12);
            this.Discounts.Name = "Discounts";
            this.Discounts.RowHeadersWidth = 51;
            this.Discounts.RowTemplate.Height = 24;
            this.Discounts.Size = new System.Drawing.Size(554, 425);
            this.Discounts.TabIndex = 0;
            // 
            // ID_discount
            // 
            this.ID_discount.HeaderText = "ID";
            this.ID_discount.MinimumWidth = 6;
            this.ID_discount.Name = "ID_discount";
            this.ID_discount.Width = 125;
            // 
            // Name_discount
            // 
            this.Name_discount.HeaderText = "Название";
            this.Name_discount.MinimumWidth = 6;
            this.Name_discount.Name = "Name_discount";
            this.Name_discount.Width = 250;
            // 
            // PriceModifier_Discount
            // 
            this.PriceModifier_Discount.HeaderText = "Размер(%)";
            this.PriceModifier_Discount.MinimumWidth = 6;
            this.PriceModifier_Discount.Name = "PriceModifier_Discount";
            this.PriceModifier_Discount.Width = 125;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.DelService);
            this.tabPage3.Controls.Add(this.FindServices);
            this.tabPage3.Controls.Add(this.PageServices);
            this.tabPage3.Controls.Add(this.AllPagesServices);
            this.tabPage3.Controls.Add(this.BackServices);
            this.tabPage3.Controls.Add(this.Choose);
            this.tabPage3.Controls.Add(this.Add);
            this.tabPage3.Controls.Add(this.ForwardServices);
            this.tabPage3.Controls.Add(this.Services);
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1318, 506);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Услуги";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // DelService
            // 
            this.DelService.Location = new System.Drawing.Point(3, 475);
            this.DelService.Name = "DelService";
            this.DelService.Size = new System.Drawing.Size(94, 25);
            this.DelService.TabIndex = 231;
            this.DelService.Text = "Удалить";
            this.DelService.UseVisualStyleBackColor = true;
            this.DelService.Click += new System.EventHandler(this.DelService_Click);
            // 
            // FindServices
            // 
            this.FindServices.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FindServices.BackgroundImage")));
            this.FindServices.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FindServices.Location = new System.Drawing.Point(541, 468);
            this.FindServices.Margin = new System.Windows.Forms.Padding(4);
            this.FindServices.Name = "FindServices";
            this.FindServices.Size = new System.Drawing.Size(43, 25);
            this.FindServices.TabIndex = 230;
            this.FindServices.UseVisualStyleBackColor = true;
            // 
            // PageServices
            // 
            this.PageServices.Location = new System.Drawing.Point(611, 470);
            this.PageServices.Margin = new System.Windows.Forms.Padding(4);
            this.PageServices.Name = "PageServices";
            this.PageServices.Size = new System.Drawing.Size(65, 22);
            this.PageServices.TabIndex = 227;
            // 
            // AllPagesServices
            // 
            this.AllPagesServices.AutoSize = true;
            this.AllPagesServices.Location = new System.Drawing.Point(697, 475);
            this.AllPagesServices.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AllPagesServices.Name = "AllPagesServices";
            this.AllPagesServices.Size = new System.Drawing.Size(46, 17);
            this.AllPagesServices.TabIndex = 226;
            this.AllPagesServices.Text = "label1";
            // 
            // BackServices
            // 
            this.BackServices.Location = new System.Drawing.Point(450, 468);
            this.BackServices.Margin = new System.Windows.Forms.Padding(4);
            this.BackServices.Name = "BackServices";
            this.BackServices.Size = new System.Drawing.Size(71, 25);
            this.BackServices.TabIndex = 225;
            this.BackServices.Text = "<";
            this.BackServices.UseVisualStyleBackColor = true;
            // 
            // Choose
            // 
            this.Choose.Location = new System.Drawing.Point(1212, 468);
            this.Choose.Name = "Choose";
            this.Choose.Size = new System.Drawing.Size(95, 25);
            this.Choose.TabIndex = 229;
            this.Choose.Text = "Выбрать";
            this.Choose.UseVisualStyleBackColor = true;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(1112, 467);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(94, 25);
            this.Add.TabIndex = 228;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // ForwardServices
            // 
            this.ForwardServices.Location = new System.Drawing.Point(751, 468);
            this.ForwardServices.Margin = new System.Windows.Forms.Padding(4);
            this.ForwardServices.Name = "ForwardServices";
            this.ForwardServices.Size = new System.Drawing.Size(71, 25);
            this.ForwardServices.TabIndex = 224;
            this.ForwardServices.Text = ">";
            this.ForwardServices.UseVisualStyleBackColor = true;
            // 
            // Services
            // 
            this.Services.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Services.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name_servcie,
            this.Driver_service,
            this.Vehicle_service,
            this.DeliveryDriver_service,
            this.DeliviryVehicle_service,
            this.Start_service,
            this.End_service,
            this.StartFrom_service,
            this.EndFrom_service});
            this.Services.Location = new System.Drawing.Point(3, 3);
            this.Services.Name = "Services";
            this.Services.RowHeadersWidth = 51;
            this.Services.RowTemplate.Height = 24;
            this.Services.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Services.Size = new System.Drawing.Size(1319, 442);
            this.Services.TabIndex = 70;
            this.Services.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Services_CellDoubleClick);
            // 
            // Name_servcie
            // 
            this.Name_servcie.HeaderText = "Название";
            this.Name_servcie.MinimumWidth = 6;
            this.Name_servcie.Name = "Name_servcie";
            this.Name_servcie.Width = 125;
            // 
            // Driver_service
            // 
            this.Driver_service.HeaderText = "Водитель";
            this.Driver_service.MinimumWidth = 6;
            this.Driver_service.Name = "Driver_service";
            this.Driver_service.Width = 125;
            // 
            // Vehicle_service
            // 
            this.Vehicle_service.HeaderText = "Техника";
            this.Vehicle_service.MinimumWidth = 6;
            this.Vehicle_service.Name = "Vehicle_service";
            this.Vehicle_service.Width = 125;
            // 
            // DeliveryDriver_service
            // 
            this.DeliveryDriver_service.HeaderText = "Водитель доставки";
            this.DeliveryDriver_service.MinimumWidth = 6;
            this.DeliveryDriver_service.Name = "DeliveryDriver_service";
            this.DeliveryDriver_service.Width = 125;
            // 
            // DeliviryVehicle_service
            // 
            this.DeliviryVehicle_service.HeaderText = "Доставочная техника";
            this.DeliviryVehicle_service.MinimumWidth = 6;
            this.DeliviryVehicle_service.Name = "DeliviryVehicle_service";
            this.DeliviryVehicle_service.Width = 125;
            // 
            // Start_service
            // 
            this.Start_service.HeaderText = "Начало";
            this.Start_service.MinimumWidth = 6;
            this.Start_service.Name = "Start_service";
            this.Start_service.Width = 125;
            // 
            // End_service
            // 
            this.End_service.HeaderText = "Окончание";
            this.End_service.MinimumWidth = 6;
            this.End_service.Name = "End_service";
            this.End_service.Width = 125;
            // 
            // StartFrom_service
            // 
            this.StartFrom_service.HeaderText = "Начало доставки от клиента";
            this.StartFrom_service.MinimumWidth = 6;
            this.StartFrom_service.Name = "StartFrom_service";
            this.StartFrom_service.Width = 125;
            // 
            // EndFrom_service
            // 
            this.EndFrom_service.HeaderText = "Окончание доставки от клиента";
            this.EndFrom_service.MinimumWidth = 6;
            this.EndFrom_service.Name = "EndFrom_service";
            this.EndFrom_service.Width = 125;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1451, 382);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 23);
            this.button2.TabIndex = 69;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.CommOrder);
            this.tabPage1.Controls.Add(this.ClientName);
            this.tabPage1.Controls.Add(this.IDOrder);
            this.tabPage1.Controls.Add(this.IDOrder_name);
            this.tabPage1.Controls.Add(this.CancelOrder);
            this.tabPage1.Controls.Add(this.SaveOrder);
            this.tabPage1.Controls.Add(this.AddClient);
            this.tabPage1.Controls.Add(this.ChooseClient);
            this.tabPage1.Controls.Add(this.EndOrderTime);
            this.tabPage1.Controls.Add(this.EndOrderDate);
            this.tabPage1.Controls.Add(this.EndOrder_name);
            this.tabPage1.Controls.Add(this.CreateOrderTime);
            this.tabPage1.Controls.Add(this.CreateOrderDate);
            this.tabPage1.Controls.Add(this.CreateOrder_name);
            this.tabPage1.Controls.Add(this.Address);
            this.tabPage1.Controls.Add(this.Client_name);
            this.tabPage1.Controls.Add(this.ServiceQuantity);
            this.tabPage1.Controls.Add(this.AllPrice);
            this.tabPage1.Controls.Add(this.AllPrice_name);
            this.tabPage1.Controls.Add(this.ServiceQuantity_name);
            this.tabPage1.Controls.Add(this.CommOrder_name);
            this.tabPage1.Controls.Add(this.ByCash);
            this.tabPage1.Controls.Add(this.Price);
            this.tabPage1.Controls.Add(this.Price_name);
            this.tabPage1.Controls.Add(this.Distance);
            this.tabPage1.Controls.Add(this.Distance_name);
            this.tabPage1.Controls.Add(this.Address_name);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1318, 506);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Основная информация";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // CommOrder
            // 
            this.CommOrder.Location = new System.Drawing.Point(11, 272);
            this.CommOrder.Multiline = true;
            this.CommOrder.Name = "CommOrder";
            this.CommOrder.Size = new System.Drawing.Size(564, 168);
            this.CommOrder.TabIndex = 217;
            // 
            // ClientName
            // 
            this.ClientName.AutoSize = true;
            this.ClientName.Location = new System.Drawing.Point(169, 31);
            this.ClientName.Name = "ClientName";
            this.ClientName.Size = new System.Drawing.Size(72, 17);
            this.ClientName.TabIndex = 216;
            this.ClientName.TabStop = true;
            this.ClientName.Text = "linkLabel1";
            // 
            // IDOrder
            // 
            this.IDOrder.AutoSize = true;
            this.IDOrder.Location = new System.Drawing.Point(60, 11);
            this.IDOrder.Name = "IDOrder";
            this.IDOrder.Size = new System.Drawing.Size(46, 17);
            this.IDOrder.TabIndex = 215;
            this.IDOrder.Text = "label5";
            // 
            // IDOrder_name
            // 
            this.IDOrder_name.AutoSize = true;
            this.IDOrder_name.Location = new System.Drawing.Point(3, 11);
            this.IDOrder_name.Name = "IDOrder_name";
            this.IDOrder_name.Size = new System.Drawing.Size(21, 17);
            this.IDOrder_name.TabIndex = 214;
            this.IDOrder_name.Text = "ID";
            // 
            // CancelOrder
            // 
            this.CancelOrder.Location = new System.Drawing.Point(1220, 476);
            this.CancelOrder.Name = "CancelOrder";
            this.CancelOrder.Size = new System.Drawing.Size(92, 24);
            this.CancelOrder.TabIndex = 213;
            this.CancelOrder.Text = "Отмена";
            this.CancelOrder.UseVisualStyleBackColor = true;
            // 
            // SaveOrder
            // 
            this.SaveOrder.Location = new System.Drawing.Point(6, 475);
            this.SaveOrder.Name = "SaveOrder";
            this.SaveOrder.Size = new System.Drawing.Size(88, 25);
            this.SaveOrder.TabIndex = 212;
            this.SaveOrder.Text = "Сохранить";
            this.SaveOrder.UseVisualStyleBackColor = true;
            this.SaveOrder.Click += new System.EventHandler(this.SaveOrder_Click);
            // 
            // AddClient
            // 
            this.AddClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AddClient.Location = new System.Drawing.Point(470, 31);
            this.AddClient.Name = "AddClient";
            this.AddClient.Size = new System.Drawing.Size(43, 32);
            this.AddClient.TabIndex = 194;
            this.AddClient.Text = "+";
            this.AddClient.UseVisualStyleBackColor = false;
            this.AddClient.Click += new System.EventHandler(this.AddClient_Click);
            // 
            // ChooseClient
            // 
            this.ChooseClient.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ChooseClient.BackgroundImage")));
            this.ChooseClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ChooseClient.Location = new System.Drawing.Point(522, 31);
            this.ChooseClient.Name = "ChooseClient";
            this.ChooseClient.Size = new System.Drawing.Size(43, 32);
            this.ChooseClient.TabIndex = 193;
            this.ChooseClient.UseVisualStyleBackColor = false;
            this.ChooseClient.Click += new System.EventHandler(this.ChooseClient_Click);
            // 
            // EndOrderTime
            // 
            this.EndOrderTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.EndOrderTime.Location = new System.Drawing.Point(1209, 34);
            this.EndOrderTime.Name = "EndOrderTime";
            this.EndOrderTime.ShowUpDown = true;
            this.EndOrderTime.Size = new System.Drawing.Size(92, 22);
            this.EndOrderTime.TabIndex = 88;
            // 
            // EndOrderDate
            // 
            this.EndOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EndOrderDate.Location = new System.Drawing.Point(1069, 34);
            this.EndOrderDate.Name = "EndOrderDate";
            this.EndOrderDate.Size = new System.Drawing.Size(134, 22);
            this.EndOrderDate.TabIndex = 87;
            // 
            // EndOrder_name
            // 
            this.EndOrder_name.AutoSize = true;
            this.EndOrder_name.Location = new System.Drawing.Point(902, 39);
            this.EndOrder_name.Name = "EndOrder_name";
            this.EndOrder_name.Size = new System.Drawing.Size(140, 17);
            this.EndOrder_name.TabIndex = 86;
            this.EndOrder_name.Text = "Завершение заявки";
            // 
            // CreateOrderTime
            // 
            this.CreateOrderTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.CreateOrderTime.Location = new System.Drawing.Point(1209, 6);
            this.CreateOrderTime.Name = "CreateOrderTime";
            this.CreateOrderTime.ShowUpDown = true;
            this.CreateOrderTime.Size = new System.Drawing.Size(92, 22);
            this.CreateOrderTime.TabIndex = 85;
            // 
            // CreateOrderDate
            // 
            this.CreateOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.CreateOrderDate.Location = new System.Drawing.Point(1069, 6);
            this.CreateOrderDate.Name = "CreateOrderDate";
            this.CreateOrderDate.Size = new System.Drawing.Size(134, 22);
            this.CreateOrderDate.TabIndex = 84;
            // 
            // CreateOrder_name
            // 
            this.CreateOrder_name.AutoSize = true;
            this.CreateOrder_name.Location = new System.Drawing.Point(902, 11);
            this.CreateOrder_name.Name = "CreateOrder_name";
            this.CreateOrder_name.Size = new System.Drawing.Size(121, 17);
            this.CreateOrder_name.TabIndex = 83;
            this.CreateOrder_name.Text = "Создание заявки";
            // 
            // Address
            // 
            this.Address.Location = new System.Drawing.Point(172, 64);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(278, 22);
            this.Address.TabIndex = 21;
            // 
            // Client_name
            // 
            this.Client_name.AutoSize = true;
            this.Client_name.Location = new System.Drawing.Point(3, 36);
            this.Client_name.Name = "Client_name";
            this.Client_name.Size = new System.Drawing.Size(56, 17);
            this.Client_name.TabIndex = 75;
            this.Client_name.Text = "Клиент";
            // 
            // ServiceQuantity
            // 
            this.ServiceQuantity.AutoSize = true;
            this.ServiceQuantity.Location = new System.Drawing.Point(169, 121);
            this.ServiceQuantity.Name = "ServiceQuantity";
            this.ServiceQuantity.Size = new System.Drawing.Size(38, 17);
            this.ServiceQuantity.TabIndex = 73;
            this.ServiceQuantity.Text = "label";
            // 
            // AllPrice
            // 
            this.AllPrice.AutoSize = true;
            this.AllPrice.Location = new System.Drawing.Point(169, 174);
            this.AllPrice.Name = "AllPrice";
            this.AllPrice.Size = new System.Drawing.Size(38, 17);
            this.AllPrice.TabIndex = 72;
            this.AllPrice.Text = "label";
            // 
            // AllPrice_name
            // 
            this.AllPrice_name.AutoSize = true;
            this.AllPrice_name.Location = new System.Drawing.Point(5, 174);
            this.AllPrice_name.Name = "AllPrice_name";
            this.AllPrice_name.Size = new System.Drawing.Size(126, 17);
            this.AllPrice_name.TabIndex = 71;
            this.AllPrice_name.Text = "Общая стоимость";
            // 
            // ServiceQuantity_name
            // 
            this.ServiceQuantity_name.AutoSize = true;
            this.ServiceQuantity_name.Location = new System.Drawing.Point(5, 118);
            this.ServiceQuantity_name.Name = "ServiceQuantity_name";
            this.ServiceQuantity_name.Size = new System.Drawing.Size(124, 17);
            this.ServiceQuantity_name.TabIndex = 70;
            this.ServiceQuantity_name.Text = "Количество услуг";
            // 
            // CommOrder_name
            // 
            this.CommOrder_name.AutoSize = true;
            this.CommOrder_name.Location = new System.Drawing.Point(8, 238);
            this.CommOrder_name.Name = "CommOrder_name";
            this.CommOrder_name.Size = new System.Drawing.Size(98, 17);
            this.CommOrder_name.TabIndex = 45;
            this.CommOrder_name.Text = "Комментарий";
            // 
            // ByCash
            // 
            this.ByCash.AutoSize = true;
            this.ByCash.Location = new System.Drawing.Point(8, 204);
            this.ByCash.Name = "ByCash";
            this.ByCash.Size = new System.Drawing.Size(159, 21);
            this.ByCash.TabIndex = 28;
            this.ByCash.Text = "Оплата наличными";
            this.ByCash.UseVisualStyleBackColor = true;
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Location = new System.Drawing.Point(169, 146);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(38, 17);
            this.Price.TabIndex = 25;
            this.Price.Text = "label";
            // 
            // Price_name
            // 
            this.Price_name.AutoSize = true;
            this.Price_name.Location = new System.Drawing.Point(5, 146);
            this.Price_name.Name = "Price_name";
            this.Price_name.Size = new System.Drawing.Size(160, 17);
            this.Price_name.TabIndex = 24;
            this.Price_name.Text = "Стоимость(без скидки)";
            // 
            // Distance
            // 
            this.Distance.AutoSize = true;
            this.Distance.Location = new System.Drawing.Point(169, 95);
            this.Distance.Name = "Distance";
            this.Distance.Size = new System.Drawing.Size(38, 17);
            this.Distance.TabIndex = 23;
            this.Distance.Text = "label";
            // 
            // Distance_name
            // 
            this.Distance_name.AutoSize = true;
            this.Distance_name.Location = new System.Drawing.Point(3, 92);
            this.Distance_name.Name = "Distance_name";
            this.Distance_name.Size = new System.Drawing.Size(86, 17);
            this.Distance_name.TabIndex = 22;
            this.Distance_name.Text = "Расстояние";
            // 
            // Address_name
            // 
            this.Address_name.AutoSize = true;
            this.Address_name.Location = new System.Drawing.Point(3, 64);
            this.Address_name.Name = "Address_name";
            this.Address_name.Size = new System.Drawing.Size(48, 17);
            this.Address_name.TabIndex = 20;
            this.Address_name.Text = "Адрес";
            // 
            // Menu_Order
            // 
            this.Menu_Order.Controls.Add(this.tabPage1);
            this.Menu_Order.Controls.Add(this.tabPage3);
            this.Menu_Order.Controls.Add(this.tabPage4);
            this.Menu_Order.Controls.Add(this.tabPage2);
            this.Menu_Order.Location = new System.Drawing.Point(12, 12);
            this.Menu_Order.Name = "Menu_Order";
            this.Menu_Order.SelectedIndex = 0;
            this.Menu_Order.Size = new System.Drawing.Size(1326, 535);
            this.Menu_Order.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1318, 506);
            this.tabPage2.TabIndex = 4;
            this.tabPage2.Text = "История";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // AddOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 559);
            this.Controls.Add(this.Menu_Order);
            this.Name = "AddOrder";
            this.Text = "Создание заказа(AddOrder)";
            this.Load += new System.EventHandler(this.AddOrder_Load);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Discounts)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Services)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.Menu_Order.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView Discounts;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView Services;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DateTimePicker EndOrderTime;
        private System.Windows.Forms.DateTimePicker EndOrderDate;
        private System.Windows.Forms.Label EndOrder_name;
        private System.Windows.Forms.DateTimePicker CreateOrderTime;
        private System.Windows.Forms.DateTimePicker CreateOrderDate;
        private System.Windows.Forms.Label CreateOrder_name;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.Label Client_name;
        private System.Windows.Forms.Label ServiceQuantity;
        private System.Windows.Forms.Label AllPrice;
        private System.Windows.Forms.Label AllPrice_name;
        private System.Windows.Forms.Label ServiceQuantity_name;
        private System.Windows.Forms.Label CommOrder_name;
        private System.Windows.Forms.CheckBox ByCash;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.Label Price_name;
        private System.Windows.Forms.Label Distance;
        private System.Windows.Forms.Label Distance_name;
        private System.Windows.Forms.Label Address_name;
        private System.Windows.Forms.TabControl Menu_Order;
        private System.Windows.Forms.Button ChooseClient;
        private System.Windows.Forms.Button AddClient;
        private System.Windows.Forms.TextBox Page_discounts;
        private System.Windows.Forms.Label AllPages_discounts;
        private System.Windows.Forms.Button Back_discounts;
        private System.Windows.Forms.Button Choose_discounts;
        private System.Windows.Forms.Button Add_discounts;
        private System.Windows.Forms.Button Forward_discounts;
        private System.Windows.Forms.TextBox PageServices;
        private System.Windows.Forms.Label AllPagesServices;
        private System.Windows.Forms.Button BackServices;
        private System.Windows.Forms.Button Choose;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button ForwardServices;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceModifier_Discount;
        private System.Windows.Forms.Button CancelOrder;
        private System.Windows.Forms.Button SaveOrder;
        private System.Windows.Forms.Label IDOrder;
        private System.Windows.Forms.Label IDOrder_name;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button FindServices;
        private System.Windows.Forms.Button Find_discounts;
        private System.Windows.Forms.LinkLabel ClientName;
        private System.Windows.Forms.TextBox CommOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_servcie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Driver_service;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vehicle_service;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeliveryDriver_service;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeliviryVehicle_service;
        private System.Windows.Forms.DataGridViewTextBoxColumn Start_service;
        private System.Windows.Forms.DataGridViewTextBoxColumn End_service;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartFrom_service;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndFrom_service;
        private System.Windows.Forms.Button DelService;
    }
}

