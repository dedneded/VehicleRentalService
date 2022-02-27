
namespace form
{
    partial class Vehicles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vehicles));
            this.FiltersVehicles = new System.Windows.Forms.GroupBox();
            this.DeliveryCheck = new System.Windows.Forms.CheckBox();
            this.SortDescVehicles = new System.Windows.Forms.Button();
            this.SortingVehicles_name = new System.Windows.Forms.Label();
            this.SortingVehicles = new System.Windows.Forms.ComboBox();
            this.CategoryVehicles = new System.Windows.Forms.LinkLabel();
            this.CategoryChoose = new System.Windows.Forms.Button();
            this.DelCategory = new System.Windows.Forms.Button();
            this.BranchVehicles = new System.Windows.Forms.LinkLabel();
            this.ChangeTimeBranch = new System.Windows.Forms.Button();
            this.DelTimeBranch = new System.Windows.Forms.Button();
            this.TimeBranch_name = new System.Windows.Forms.Label();
            this.ApplyVehicles = new System.Windows.Forms.Button();
            this.ResetVehicles = new System.Windows.Forms.Button();
            this.OrdersVehilcles = new System.Windows.Forms.LinkLabel();
            this.ChangeOrdersVehilcles = new System.Windows.Forms.Button();
            this.DelOrdersVehilcles = new System.Windows.Forms.Button();
            this.OrdersVehilcles_name = new System.Windows.Forms.Label();
            this.CategoryVehilcles_name = new System.Windows.Forms.Label();
            this.GosNumVehilcles = new System.Windows.Forms.TextBox();
            this.IDVehilcles = new System.Windows.Forms.TextBox();
            this.GosNumVehilcles_name = new System.Windows.Forms.Label();
            this.IDVehilcles_name = new System.Windows.Forms.Label();
            this.AllVehicles = new System.Windows.Forms.DataGridView();
            this.ID_vehicle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryOfVehicel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrandAndModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GosNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PricePerHour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsNeedDelivery = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PageVehicles = new System.Windows.Forms.TextBox();
            this.PagesVehicles = new System.Windows.Forms.Label();
            this.BackVehicles = new System.Windows.Forms.Button();
            this.ChooseVehicles = new System.Windows.Forms.Button();
            this.AddVehicles = new System.Windows.Forms.Button();
            this.ToVehicles = new System.Windows.Forms.Button();
            this.FindVehicles = new System.Windows.Forms.Button();
            this.errorId = new System.Windows.Forms.ErrorProvider(this.components);
            this.FiltersVehicles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AllVehicles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorId)).BeginInit();
            this.SuspendLayout();
            // 
            // FiltersVehicles
            // 
            this.FiltersVehicles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FiltersVehicles.Controls.Add(this.DeliveryCheck);
            this.FiltersVehicles.Controls.Add(this.SortDescVehicles);
            this.FiltersVehicles.Controls.Add(this.SortingVehicles_name);
            this.FiltersVehicles.Controls.Add(this.SortingVehicles);
            this.FiltersVehicles.Controls.Add(this.CategoryVehicles);
            this.FiltersVehicles.Controls.Add(this.CategoryChoose);
            this.FiltersVehicles.Controls.Add(this.DelCategory);
            this.FiltersVehicles.Controls.Add(this.BranchVehicles);
            this.FiltersVehicles.Controls.Add(this.ChangeTimeBranch);
            this.FiltersVehicles.Controls.Add(this.DelTimeBranch);
            this.FiltersVehicles.Controls.Add(this.TimeBranch_name);
            this.FiltersVehicles.Controls.Add(this.ApplyVehicles);
            this.FiltersVehicles.Controls.Add(this.ResetVehicles);
            this.FiltersVehicles.Controls.Add(this.OrdersVehilcles);
            this.FiltersVehicles.Controls.Add(this.ChangeOrdersVehilcles);
            this.FiltersVehicles.Controls.Add(this.DelOrdersVehilcles);
            this.FiltersVehicles.Controls.Add(this.OrdersVehilcles_name);
            this.FiltersVehicles.Controls.Add(this.CategoryVehilcles_name);
            this.FiltersVehicles.Controls.Add(this.GosNumVehilcles);
            this.FiltersVehicles.Controls.Add(this.IDVehilcles);
            this.FiltersVehicles.Controls.Add(this.GosNumVehilcles_name);
            this.FiltersVehicles.Controls.Add(this.IDVehilcles_name);
            this.FiltersVehicles.Location = new System.Drawing.Point(12, 12);
            this.FiltersVehicles.Name = "FiltersVehicles";
            this.FiltersVehicles.Size = new System.Drawing.Size(952, 209);
            this.FiltersVehicles.TabIndex = 0;
            this.FiltersVehicles.TabStop = false;
            this.FiltersVehicles.Text = "Фильтры";
            this.FiltersVehicles.Enter += new System.EventHandler(this.FiltersVehicles_Enter);
            // 
            // DeliveryCheck
            // 
            this.DeliveryCheck.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DeliveryCheck.AutoSize = true;
            this.DeliveryCheck.ForeColor = System.Drawing.Color.Black;
            this.DeliveryCheck.Location = new System.Drawing.Point(444, 75);
            this.DeliveryCheck.Name = "DeliveryCheck";
            this.DeliveryCheck.Size = new System.Drawing.Size(136, 21);
            this.DeliveryCheck.TabIndex = 236;
            this.DeliveryCheck.Text = "Нужна доставка";
            this.DeliveryCheck.UseVisualStyleBackColor = true;
            this.DeliveryCheck.CheckedChanged += new System.EventHandler(this.DeliveryCheck_CheckedChanged);
            // 
            // SortDescVehicles
            // 
            this.SortDescVehicles.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SortDescVehicles.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SortDescVehicles.BackgroundImage")));
            this.SortDescVehicles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SortDescVehicles.Location = new System.Drawing.Point(866, 25);
            this.SortDescVehicles.Name = "SortDescVehicles";
            this.SortDescVehicles.Size = new System.Drawing.Size(36, 26);
            this.SortDescVehicles.TabIndex = 235;
            this.SortDescVehicles.UseVisualStyleBackColor = true;
            this.SortDescVehicles.Click += new System.EventHandler(this.SortDescVehicles_Click);
            // 
            // SortingVehicles_name
            // 
            this.SortingVehicles_name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SortingVehicles_name.AutoSize = true;
            this.SortingVehicles_name.ForeColor = System.Drawing.Color.Black;
            this.SortingVehicles_name.Location = new System.Drawing.Point(442, 28);
            this.SortingVehicles_name.Name = "SortingVehicles_name";
            this.SortingVehicles_name.Size = new System.Drawing.Size(113, 17);
            this.SortingVehicles_name.TabIndex = 233;
            this.SortingVehicles_name.Text = "Сортировать по";
            // 
            // SortingVehicles
            // 
            this.SortingVehicles.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SortingVehicles.FormattingEnabled = true;
            this.SortingVehicles.Location = new System.Drawing.Point(597, 25);
            this.SortingVehicles.Name = "SortingVehicles";
            this.SortingVehicles.Size = new System.Drawing.Size(263, 24);
            this.SortingVehicles.TabIndex = 234;
            this.SortingVehicles.SelectedIndexChanged += new System.EventHandler(this.SortingVehicles_SelectedIndexChanged);
            // 
            // CategoryVehicles
            // 
            this.CategoryVehicles.AutoSize = true;
            this.CategoryVehicles.Location = new System.Drawing.Point(135, 92);
            this.CategoryVehicles.Name = "CategoryVehicles";
            this.CategoryVehicles.Size = new System.Drawing.Size(85, 17);
            this.CategoryVehicles.TabIndex = 232;
            this.CategoryVehicles.TabStop = true;
            this.CategoryVehicles.Text = "не выбрано";
            // 
            // CategoryChoose
            // 
            this.CategoryChoose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CategoryChoose.BackgroundImage")));
            this.CategoryChoose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CategoryChoose.Location = new System.Drawing.Point(301, 88);
            this.CategoryChoose.Name = "CategoryChoose";
            this.CategoryChoose.Size = new System.Drawing.Size(35, 25);
            this.CategoryChoose.TabIndex = 231;
            this.CategoryChoose.UseVisualStyleBackColor = false;
            this.CategoryChoose.Click += new System.EventHandler(this.CategoryChoose_Click);
            // 
            // DelCategory
            // 
            this.DelCategory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DelCategory.BackgroundImage")));
            this.DelCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DelCategory.Location = new System.Drawing.Point(342, 88);
            this.DelCategory.Name = "DelCategory";
            this.DelCategory.Size = new System.Drawing.Size(35, 25);
            this.DelCategory.TabIndex = 230;
            this.DelCategory.UseVisualStyleBackColor = true;
            this.DelCategory.Click += new System.EventHandler(this.DelCategory_Click);
            // 
            // BranchVehicles
            // 
            this.BranchVehicles.AutoSize = true;
            this.BranchVehicles.Location = new System.Drawing.Point(135, 160);
            this.BranchVehicles.Name = "BranchVehicles";
            this.BranchVehicles.Size = new System.Drawing.Size(85, 17);
            this.BranchVehicles.TabIndex = 229;
            this.BranchVehicles.TabStop = true;
            this.BranchVehicles.Text = "не выбрано";
            // 
            // ChangeTimeBranch
            // 
            this.ChangeTimeBranch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ChangeTimeBranch.BackgroundImage")));
            this.ChangeTimeBranch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ChangeTimeBranch.Location = new System.Drawing.Point(301, 157);
            this.ChangeTimeBranch.Name = "ChangeTimeBranch";
            this.ChangeTimeBranch.Size = new System.Drawing.Size(35, 25);
            this.ChangeTimeBranch.TabIndex = 228;
            this.ChangeTimeBranch.UseVisualStyleBackColor = false;
            this.ChangeTimeBranch.Click += new System.EventHandler(this.ChangeTimeBranch_Click);
            // 
            // DelTimeBranch
            // 
            this.DelTimeBranch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DelTimeBranch.BackgroundImage")));
            this.DelTimeBranch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DelTimeBranch.Location = new System.Drawing.Point(342, 157);
            this.DelTimeBranch.Name = "DelTimeBranch";
            this.DelTimeBranch.Size = new System.Drawing.Size(35, 25);
            this.DelTimeBranch.TabIndex = 227;
            this.DelTimeBranch.UseVisualStyleBackColor = true;
            this.DelTimeBranch.Click += new System.EventHandler(this.DelTimeBranch_Click);
            // 
            // TimeBranch_name
            // 
            this.TimeBranch_name.AutoSize = true;
            this.TimeBranch_name.ForeColor = System.Drawing.Color.Black;
            this.TimeBranch_name.Location = new System.Drawing.Point(17, 161);
            this.TimeBranch_name.Name = "TimeBranch_name";
            this.TimeBranch_name.Size = new System.Drawing.Size(61, 17);
            this.TimeBranch_name.TabIndex = 226;
            this.TimeBranch_name.Text = "Филиал";
            // 
            // ApplyVehicles
            // 
            this.ApplyVehicles.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ApplyVehicles.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.ApplyVehicles.FlatAppearance.BorderSize = 2;
            this.ApplyVehicles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ApplyVehicles.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ApplyVehicles.ForeColor = System.Drawing.Color.DarkOrange;
            this.ApplyVehicles.Location = new System.Drawing.Point(836, 144);
            this.ApplyVehicles.Name = "ApplyVehicles";
            this.ApplyVehicles.Size = new System.Drawing.Size(110, 28);
            this.ApplyVehicles.TabIndex = 225;
            this.ApplyVehicles.Text = "Применить";
            this.ApplyVehicles.UseVisualStyleBackColor = true;
            this.ApplyVehicles.Click += new System.EventHandler(this.ApplyVehicles_Click);
            this.ApplyVehicles.MouseEnter += new System.EventHandler(this.ApplyVehicles_MouseEnter);
            this.ApplyVehicles.MouseLeave += new System.EventHandler(this.ApplyVehicles_MouseLeave);
            // 
            // ResetVehicles
            // 
            this.ResetVehicles.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ResetVehicles.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.ResetVehicles.FlatAppearance.BorderSize = 2;
            this.ResetVehicles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetVehicles.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResetVehicles.ForeColor = System.Drawing.Color.DarkOrange;
            this.ResetVehicles.Location = new System.Drawing.Point(836, 178);
            this.ResetVehicles.Name = "ResetVehicles";
            this.ResetVehicles.Size = new System.Drawing.Size(110, 28);
            this.ResetVehicles.TabIndex = 224;
            this.ResetVehicles.Text = "Сбросить";
            this.ResetVehicles.UseVisualStyleBackColor = true;
            this.ResetVehicles.Click += new System.EventHandler(this.ResetVehicles_Click);
            this.ResetVehicles.MouseEnter += new System.EventHandler(this.ResetVehicles_MouseEnter);
            this.ResetVehicles.MouseLeave += new System.EventHandler(this.ResetVehicles_MouseLeave);
            // 
            // OrdersVehilcles
            // 
            this.OrdersVehilcles.AutoSize = true;
            this.OrdersVehilcles.Location = new System.Drawing.Point(135, 123);
            this.OrdersVehilcles.Name = "OrdersVehilcles";
            this.OrdersVehilcles.Size = new System.Drawing.Size(85, 17);
            this.OrdersVehilcles.TabIndex = 195;
            this.OrdersVehilcles.TabStop = true;
            this.OrdersVehilcles.Text = "не выбрано";
            // 
            // ChangeOrdersVehilcles
            // 
            this.ChangeOrdersVehilcles.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ChangeOrdersVehilcles.BackgroundImage")));
            this.ChangeOrdersVehilcles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ChangeOrdersVehilcles.Location = new System.Drawing.Point(301, 119);
            this.ChangeOrdersVehilcles.Name = "ChangeOrdersVehilcles";
            this.ChangeOrdersVehilcles.Size = new System.Drawing.Size(35, 25);
            this.ChangeOrdersVehilcles.TabIndex = 194;
            this.ChangeOrdersVehilcles.UseVisualStyleBackColor = false;
            this.ChangeOrdersVehilcles.Click += new System.EventHandler(this.ChangeOrdersVehilcles_Click);
            // 
            // DelOrdersVehilcles
            // 
            this.DelOrdersVehilcles.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DelOrdersVehilcles.BackgroundImage")));
            this.DelOrdersVehilcles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DelOrdersVehilcles.Location = new System.Drawing.Point(342, 119);
            this.DelOrdersVehilcles.Name = "DelOrdersVehilcles";
            this.DelOrdersVehilcles.Size = new System.Drawing.Size(35, 25);
            this.DelOrdersVehilcles.TabIndex = 193;
            this.DelOrdersVehilcles.UseVisualStyleBackColor = true;
            this.DelOrdersVehilcles.Click += new System.EventHandler(this.DelOrdersVehilcles_Click);
            // 
            // OrdersVehilcles_name
            // 
            this.OrdersVehilcles_name.AutoSize = true;
            this.OrdersVehilcles_name.ForeColor = System.Drawing.Color.Black;
            this.OrdersVehilcles_name.Location = new System.Drawing.Point(15, 123);
            this.OrdersVehilcles_name.Name = "OrdersVehilcles_name";
            this.OrdersVehilcles_name.Size = new System.Drawing.Size(47, 17);
            this.OrdersVehilcles_name.TabIndex = 80;
            this.OrdersVehilcles_name.Text = "Заказ";
            // 
            // CategoryVehilcles_name
            // 
            this.CategoryVehilcles_name.AutoSize = true;
            this.CategoryVehilcles_name.ForeColor = System.Drawing.Color.Black;
            this.CategoryVehilcles_name.Location = new System.Drawing.Point(15, 92);
            this.CategoryVehilcles_name.Name = "CategoryVehilcles_name";
            this.CategoryVehilcles_name.Size = new System.Drawing.Size(77, 17);
            this.CategoryVehilcles_name.TabIndex = 76;
            this.CategoryVehilcles_name.Text = "Категория";
            // 
            // GosNumVehilcles
            // 
            this.GosNumVehilcles.Location = new System.Drawing.Point(138, 50);
            this.GosNumVehilcles.Name = "GosNumVehilcles";
            this.GosNumVehilcles.Size = new System.Drawing.Size(153, 22);
            this.GosNumVehilcles.TabIndex = 74;
            // 
            // IDVehilcles
            // 
            this.IDVehilcles.Location = new System.Drawing.Point(138, 22);
            this.IDVehilcles.Name = "IDVehilcles";
            this.IDVehilcles.Size = new System.Drawing.Size(153, 22);
            this.IDVehilcles.TabIndex = 75;
            this.IDVehilcles.TextChanged += new System.EventHandler(this.IDVehilcles_TextChanged);
            // 
            // GosNumVehilcles_name
            // 
            this.GosNumVehilcles_name.AutoSize = true;
            this.GosNumVehilcles_name.ForeColor = System.Drawing.Color.Black;
            this.GosNumVehilcles_name.Location = new System.Drawing.Point(15, 53);
            this.GosNumVehilcles_name.Name = "GosNumVehilcles_name";
            this.GosNumVehilcles_name.Size = new System.Drawing.Size(80, 17);
            this.GosNumVehilcles_name.TabIndex = 73;
            this.GosNumVehilcles_name.Text = "Гос. номер";
            // 
            // IDVehilcles_name
            // 
            this.IDVehilcles_name.AutoSize = true;
            this.IDVehilcles_name.ForeColor = System.Drawing.Color.Black;
            this.IDVehilcles_name.Location = new System.Drawing.Point(15, 25);
            this.IDVehilcles_name.Name = "IDVehilcles_name";
            this.IDVehilcles_name.Size = new System.Drawing.Size(21, 17);
            this.IDVehilcles_name.TabIndex = 74;
            this.IDVehilcles_name.Text = "ID";
            // 
            // AllVehicles
            // 
            this.AllVehicles.AllowUserToAddRows = false;
            this.AllVehicles.AllowUserToDeleteRows = false;
            this.AllVehicles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AllVehicles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AllVehicles.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AllVehicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllVehicles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_vehicle,
            this.CategoryOfVehicel,
            this.BrandAndModel,
            this.GosNum,
            this.PricePerHour,
            this.IsNeedDelivery});
            this.AllVehicles.Location = new System.Drawing.Point(11, 250);
            this.AllVehicles.Name = "AllVehicles";
            this.AllVehicles.RowHeadersWidth = 51;
            this.AllVehicles.RowTemplate.Height = 24;
            this.AllVehicles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AllVehicles.Size = new System.Drawing.Size(952, 420);
            this.AllVehicles.TabIndex = 88;
            this.AllVehicles.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AllVehicles_CellDoubleClick);
            // 
            // ID_vehicle
            // 
            this.ID_vehicle.HeaderText = "ID";
            this.ID_vehicle.MinimumWidth = 6;
            this.ID_vehicle.Name = "ID_vehicle";
            // 
            // CategoryOfVehicel
            // 
            this.CategoryOfVehicel.HeaderText = "Категория";
            this.CategoryOfVehicel.MinimumWidth = 6;
            this.CategoryOfVehicel.Name = "CategoryOfVehicel";
            // 
            // BrandAndModel
            // 
            this.BrandAndModel.HeaderText = "Марка и модель";
            this.BrandAndModel.MinimumWidth = 6;
            this.BrandAndModel.Name = "BrandAndModel";
            // 
            // GosNum
            // 
            this.GosNum.HeaderText = "Гос. номер";
            this.GosNum.MinimumWidth = 6;
            this.GosNum.Name = "GosNum";
            // 
            // PricePerHour
            // 
            this.PricePerHour.HeaderText = "Стоимость за час";
            this.PricePerHour.MinimumWidth = 6;
            this.PricePerHour.Name = "PricePerHour";
            // 
            // IsNeedDelivery
            // 
            this.IsNeedDelivery.HeaderText = "Нужна доставка";
            this.IsNeedDelivery.MinimumWidth = 6;
            this.IsNeedDelivery.Name = "IsNeedDelivery";
            this.IsNeedDelivery.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IsNeedDelivery.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // PageVehicles
            // 
            this.PageVehicles.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.PageVehicles.Location = new System.Drawing.Point(467, 697);
            this.PageVehicles.Margin = new System.Windows.Forms.Padding(4);
            this.PageVehicles.Name = "PageVehicles";
            this.PageVehicles.Size = new System.Drawing.Size(65, 22);
            this.PageVehicles.TabIndex = 203;
            // 
            // PagesVehicles
            // 
            this.PagesVehicles.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.PagesVehicles.AutoSize = true;
            this.PagesVehicles.ForeColor = System.Drawing.Color.Black;
            this.PagesVehicles.Location = new System.Drawing.Point(540, 700);
            this.PagesVehicles.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PagesVehicles.Name = "PagesVehicles";
            this.PagesVehicles.Size = new System.Drawing.Size(46, 17);
            this.PagesVehicles.TabIndex = 202;
            this.PagesVehicles.Text = "label1";
            // 
            // BackVehicles
            // 
            this.BackVehicles.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BackVehicles.ForeColor = System.Drawing.Color.Black;
            this.BackVehicles.Location = new System.Drawing.Point(314, 694);
            this.BackVehicles.Margin = new System.Windows.Forms.Padding(4);
            this.BackVehicles.Name = "BackVehicles";
            this.BackVehicles.Size = new System.Drawing.Size(71, 25);
            this.BackVehicles.TabIndex = 201;
            this.BackVehicles.Text = "<";
            this.BackVehicles.UseVisualStyleBackColor = true;
            // 
            // ChooseVehicles
            // 
            this.ChooseVehicles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ChooseVehicles.BackColor = System.Drawing.Color.DarkOrange;
            this.ChooseVehicles.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.ChooseVehicles.FlatAppearance.BorderSize = 3;
            this.ChooseVehicles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChooseVehicles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChooseVehicles.ForeColor = System.Drawing.Color.White;
            this.ChooseVehicles.Location = new System.Drawing.Point(12, 688);
            this.ChooseVehicles.Name = "ChooseVehicles";
            this.ChooseVehicles.Size = new System.Drawing.Size(135, 39);
            this.ChooseVehicles.TabIndex = 205;
            this.ChooseVehicles.Text = "Выбрать";
            this.ChooseVehicles.UseVisualStyleBackColor = false;
            this.ChooseVehicles.Click += new System.EventHandler(this.ChooseVehicles_Click);
            this.ChooseVehicles.MouseEnter += new System.EventHandler(this.ChooseVehicles_MouseEnter);
            this.ChooseVehicles.MouseLeave += new System.EventHandler(this.ChooseVehicles_MouseLeave);
            // 
            // AddVehicles
            // 
            this.AddVehicles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddVehicles.BackColor = System.Drawing.Color.DarkOrange;
            this.AddVehicles.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.AddVehicles.FlatAppearance.BorderSize = 3;
            this.AddVehicles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddVehicles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddVehicles.ForeColor = System.Drawing.Color.White;
            this.AddVehicles.Location = new System.Drawing.Point(825, 688);
            this.AddVehicles.Name = "AddVehicles";
            this.AddVehicles.Size = new System.Drawing.Size(135, 39);
            this.AddVehicles.TabIndex = 204;
            this.AddVehicles.Text = "Добавить";
            this.AddVehicles.UseVisualStyleBackColor = false;
            this.AddVehicles.Click += new System.EventHandler(this.AddVehicles_Click);
            this.AddVehicles.MouseEnter += new System.EventHandler(this.AddVehicles_MouseEnter);
            this.AddVehicles.MouseLeave += new System.EventHandler(this.AddVehicles_MouseLeave);
            // 
            // ToVehicles
            // 
            this.ToVehicles.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ToVehicles.ForeColor = System.Drawing.Color.Black;
            this.ToVehicles.Location = new System.Drawing.Point(609, 696);
            this.ToVehicles.Margin = new System.Windows.Forms.Padding(4);
            this.ToVehicles.Name = "ToVehicles";
            this.ToVehicles.Size = new System.Drawing.Size(71, 25);
            this.ToVehicles.TabIndex = 200;
            this.ToVehicles.Text = ">";
            this.ToVehicles.UseVisualStyleBackColor = true;
            // 
            // FindVehicles
            // 
            this.FindVehicles.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.FindVehicles.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FindVehicles.BackgroundImage")));
            this.FindVehicles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FindVehicles.Location = new System.Drawing.Point(405, 697);
            this.FindVehicles.Margin = new System.Windows.Forms.Padding(4);
            this.FindVehicles.Name = "FindVehicles";
            this.FindVehicles.Size = new System.Drawing.Size(43, 25);
            this.FindVehicles.TabIndex = 238;
            this.FindVehicles.UseVisualStyleBackColor = true;
            // 
            // errorId
            // 
            this.errorId.ContainerControl = this;
            // 
            // Vehicles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(974, 739);
            this.Controls.Add(this.FindVehicles);
            this.Controls.Add(this.PageVehicles);
            this.Controls.Add(this.PagesVehicles);
            this.Controls.Add(this.BackVehicles);
            this.Controls.Add(this.ChooseVehicles);
            this.Controls.Add(this.AddVehicles);
            this.Controls.Add(this.ToVehicles);
            this.Controls.Add(this.AllVehicles);
            this.Controls.Add(this.FiltersVehicles);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Vehicles";
            this.Text = "Техника(Vehicles)";
            this.Load += new System.EventHandler(this.Vehicles_Load);
            this.FiltersVehicles.ResumeLayout(false);
            this.FiltersVehicles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AllVehicles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox FiltersVehicles;
        private System.Windows.Forms.Label OrdersVehilcles_name;
        private System.Windows.Forms.Label CategoryVehilcles_name;
        private System.Windows.Forms.TextBox IDVehilcles;
        private System.Windows.Forms.Label IDVehilcles_name;
        private System.Windows.Forms.TextBox GosNumVehilcles;
        private System.Windows.Forms.Label GosNumVehilcles_name;
        private System.Windows.Forms.DataGridView AllVehicles;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_vehicle;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryOfVehicel;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrandAndModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn GosNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn PricePerHour;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsNeedDelivery;
        private System.Windows.Forms.LinkLabel OrdersVehilcles;
        private System.Windows.Forms.Button ChangeOrdersVehilcles;
        private System.Windows.Forms.Button DelOrdersVehilcles;
        private System.Windows.Forms.TextBox PageVehicles;
        private System.Windows.Forms.Label PagesVehicles;
        private System.Windows.Forms.Button BackVehicles;
        private System.Windows.Forms.Button ChooseVehicles;
        private System.Windows.Forms.Button AddVehicles;
        private System.Windows.Forms.Button ToVehicles;
        private System.Windows.Forms.Button ApplyVehicles;
        private System.Windows.Forms.Button ResetVehicles;
        private System.Windows.Forms.Button FindVehicles;
        private System.Windows.Forms.LinkLabel BranchVehicles;
        private System.Windows.Forms.Button ChangeTimeBranch;
        private System.Windows.Forms.Button DelTimeBranch;
        private System.Windows.Forms.Label TimeBranch_name;
        private System.Windows.Forms.LinkLabel CategoryVehicles;
        private System.Windows.Forms.Button CategoryChoose;
        private System.Windows.Forms.Button DelCategory;
        private System.Windows.Forms.Button SortDescVehicles;
        private System.Windows.Forms.Label SortingVehicles_name;
        private System.Windows.Forms.ComboBox SortingVehicles;
        private System.Windows.Forms.CheckBox DeliveryCheck;
        private System.Windows.Forms.ErrorProvider errorId;
    }
}