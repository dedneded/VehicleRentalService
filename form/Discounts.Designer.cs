
namespace form
{
    partial class Discounts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Discounts));
            this.FiltersDoscounts = new System.Windows.Forms.GroupBox();
            this.SortDesc_Discounts = new System.Windows.Forms.Button();
            this.CityDiscounts = new System.Windows.Forms.TextBox();
            this.ApplyDiscounts = new System.Windows.Forms.Button();
            this.ResetDiscounts = new System.Windows.Forms.Button();
            this.BranchDiscountsChoose = new System.Windows.Forms.Button();
            this.BranchDiscounts = new System.Windows.Forms.LinkLabel();
            this.BranchDiscounts_name = new System.Windows.Forms.Label();
            this.IDDiscounts = new System.Windows.Forms.TextBox();
            this.IDDiscounts_name = new System.Windows.Forms.Label();
            this.SortingDiscounts = new System.Windows.Forms.ComboBox();
            this.SortingDiscounts_name = new System.Windows.Forms.Label();
            this.CityDiscounts_name = new System.Windows.Forms.Label();
            this.NameDiscounts = new System.Windows.Forms.TextBox();
            this.NameDiscounts_name = new System.Windows.Forms.Label();
            this.DateOfDiscounts = new System.Windows.Forms.GroupBox();
            this.ToCheck = new System.Windows.Forms.CheckBox();
            this.FromCheck = new System.Windows.Forms.CheckBox();
            this.ToDiscounts = new System.Windows.Forms.DateTimePicker();
            this.FromDiscounts = new System.Windows.Forms.DateTimePicker();
            this.PageDiscounts = new System.Windows.Forms.TextBox();
            this.PagesDiscounts = new System.Windows.Forms.Label();
            this.BackDiscounts = new System.Windows.Forms.Button();
            this.ChooseDiscounts = new System.Windows.Forms.Button();
            this.AddDiscounts = new System.Windows.Forms.Button();
            this.DiscountsTo = new System.Windows.Forms.Button();
            this.AllDiscounts = new System.Windows.Forms.DataGridView();
            this.CheckDiscount = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Id_discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Start_discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.End_discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceModifier_Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Branch_discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FindDiscounts = new System.Windows.Forms.Button();
            this.FiltersDoscounts.SuspendLayout();
            this.DateOfDiscounts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AllDiscounts)).BeginInit();
            this.SuspendLayout();
            // 
            // FiltersDoscounts
            // 
            this.FiltersDoscounts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FiltersDoscounts.Controls.Add(this.SortDesc_Discounts);
            this.FiltersDoscounts.Controls.Add(this.CityDiscounts);
            this.FiltersDoscounts.Controls.Add(this.ApplyDiscounts);
            this.FiltersDoscounts.Controls.Add(this.ResetDiscounts);
            this.FiltersDoscounts.Controls.Add(this.BranchDiscountsChoose);
            this.FiltersDoscounts.Controls.Add(this.BranchDiscounts);
            this.FiltersDoscounts.Controls.Add(this.BranchDiscounts_name);
            this.FiltersDoscounts.Controls.Add(this.IDDiscounts);
            this.FiltersDoscounts.Controls.Add(this.IDDiscounts_name);
            this.FiltersDoscounts.Controls.Add(this.SortingDiscounts);
            this.FiltersDoscounts.Controls.Add(this.SortingDiscounts_name);
            this.FiltersDoscounts.Controls.Add(this.CityDiscounts_name);
            this.FiltersDoscounts.Controls.Add(this.NameDiscounts);
            this.FiltersDoscounts.Controls.Add(this.NameDiscounts_name);
            this.FiltersDoscounts.Controls.Add(this.DateOfDiscounts);
            this.FiltersDoscounts.Location = new System.Drawing.Point(12, 12);
            this.FiltersDoscounts.Name = "FiltersDoscounts";
            this.FiltersDoscounts.Size = new System.Drawing.Size(1166, 188);
            this.FiltersDoscounts.TabIndex = 89;
            this.FiltersDoscounts.TabStop = false;
            this.FiltersDoscounts.Text = "Фильтры";
            // 
            // SortDesc_Discounts
            // 
            this.SortDesc_Discounts.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SortDesc_Discounts.BackgroundImage")));
            this.SortDesc_Discounts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SortDesc_Discounts.Location = new System.Drawing.Point(433, 112);
            this.SortDesc_Discounts.Name = "SortDesc_Discounts";
            this.SortDesc_Discounts.Size = new System.Drawing.Size(36, 26);
            this.SortDesc_Discounts.TabIndex = 207;
            this.SortDesc_Discounts.UseVisualStyleBackColor = true;
            this.SortDesc_Discounts.Click += new System.EventHandler(this.SortDesc_Discounts_Click);
            // 
            // CityDiscounts
            // 
            this.CityDiscounts.Location = new System.Drawing.Point(164, 84);
            this.CityDiscounts.Name = "CityDiscounts";
            this.CityDiscounts.Size = new System.Drawing.Size(263, 22);
            this.CityDiscounts.TabIndex = 199;
            // 
            // ApplyDiscounts
            // 
            this.ApplyDiscounts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ApplyDiscounts.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.ApplyDiscounts.FlatAppearance.BorderSize = 2;
            this.ApplyDiscounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ApplyDiscounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ApplyDiscounts.ForeColor = System.Drawing.Color.DarkOrange;
            this.ApplyDiscounts.Location = new System.Drawing.Point(1050, 115);
            this.ApplyDiscounts.Name = "ApplyDiscounts";
            this.ApplyDiscounts.Size = new System.Drawing.Size(110, 28);
            this.ApplyDiscounts.TabIndex = 198;
            this.ApplyDiscounts.Text = "Применить";
            this.ApplyDiscounts.UseVisualStyleBackColor = true;
            this.ApplyDiscounts.Click += new System.EventHandler(this.ApplyDiscounts_Click);
            this.ApplyDiscounts.MouseEnter += new System.EventHandler(this.ApplyDiscounts_MouseEnter);
            this.ApplyDiscounts.MouseLeave += new System.EventHandler(this.ApplyDiscounts_MouseLeave);
            // 
            // ResetDiscounts
            // 
            this.ResetDiscounts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ResetDiscounts.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.ResetDiscounts.FlatAppearance.BorderSize = 2;
            this.ResetDiscounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetDiscounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResetDiscounts.ForeColor = System.Drawing.Color.DarkOrange;
            this.ResetDiscounts.Location = new System.Drawing.Point(1050, 151);
            this.ResetDiscounts.Name = "ResetDiscounts";
            this.ResetDiscounts.Size = new System.Drawing.Size(110, 28);
            this.ResetDiscounts.TabIndex = 197;
            this.ResetDiscounts.Text = "Сбросить";
            this.ResetDiscounts.UseVisualStyleBackColor = true;
            this.ResetDiscounts.Click += new System.EventHandler(this.ResetDiscounts_Click);
            this.ResetDiscounts.MouseEnter += new System.EventHandler(this.ResetDiscounts_MouseEnter);
            this.ResetDiscounts.MouseLeave += new System.EventHandler(this.ResetDiscounts_MouseLeave);
            // 
            // BranchDiscountsChoose
            // 
            this.BranchDiscountsChoose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BranchDiscountsChoose.BackgroundImage")));
            this.BranchDiscountsChoose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BranchDiscountsChoose.Location = new System.Drawing.Point(392, 141);
            this.BranchDiscountsChoose.Name = "BranchDiscountsChoose";
            this.BranchDiscountsChoose.Size = new System.Drawing.Size(35, 25);
            this.BranchDiscountsChoose.TabIndex = 111;
            this.BranchDiscountsChoose.UseVisualStyleBackColor = false;
            this.BranchDiscountsChoose.Click += new System.EventHandler(this.BranchDiscountsChoose_Click);
            // 
            // BranchDiscounts
            // 
            this.BranchDiscounts.AutoSize = true;
            this.BranchDiscounts.Location = new System.Drawing.Point(161, 145);
            this.BranchDiscounts.Name = "BranchDiscounts";
            this.BranchDiscounts.Size = new System.Drawing.Size(85, 17);
            this.BranchDiscounts.TabIndex = 110;
            this.BranchDiscounts.TabStop = true;
            this.BranchDiscounts.Text = "не выбрано";
            // 
            // BranchDiscounts_name
            // 
            this.BranchDiscounts_name.AutoSize = true;
            this.BranchDiscounts_name.Location = new System.Drawing.Point(6, 145);
            this.BranchDiscounts_name.Name = "BranchDiscounts_name";
            this.BranchDiscounts_name.Size = new System.Drawing.Size(61, 17);
            this.BranchDiscounts_name.TabIndex = 109;
            this.BranchDiscounts_name.Text = "Филиал";
            // 
            // IDDiscounts
            // 
            this.IDDiscounts.Location = new System.Drawing.Point(164, 24);
            this.IDDiscounts.Name = "IDDiscounts";
            this.IDDiscounts.Size = new System.Drawing.Size(263, 22);
            this.IDDiscounts.TabIndex = 107;
            // 
            // IDDiscounts_name
            // 
            this.IDDiscounts_name.AutoSize = true;
            this.IDDiscounts_name.Location = new System.Drawing.Point(6, 27);
            this.IDDiscounts_name.Name = "IDDiscounts_name";
            this.IDDiscounts_name.Size = new System.Drawing.Size(21, 17);
            this.IDDiscounts_name.TabIndex = 106;
            this.IDDiscounts_name.Text = "ID";
            // 
            // SortingDiscounts
            // 
            this.SortingDiscounts.FormattingEnabled = true;
            this.SortingDiscounts.Location = new System.Drawing.Point(164, 112);
            this.SortingDiscounts.Name = "SortingDiscounts";
            this.SortingDiscounts.Size = new System.Drawing.Size(263, 24);
            this.SortingDiscounts.TabIndex = 105;
            this.SortingDiscounts.SelectedIndexChanged += new System.EventHandler(this.SortingDiscounts_SelectedIndexChanged);
            // 
            // SortingDiscounts_name
            // 
            this.SortingDiscounts_name.AutoSize = true;
            this.SortingDiscounts_name.Location = new System.Drawing.Point(6, 115);
            this.SortingDiscounts_name.Name = "SortingDiscounts_name";
            this.SortingDiscounts_name.Size = new System.Drawing.Size(93, 17);
            this.SortingDiscounts_name.TabIndex = 104;
            this.SortingDiscounts_name.Text = "Сортировать";
            // 
            // CityDiscounts_name
            // 
            this.CityDiscounts_name.AutoSize = true;
            this.CityDiscounts_name.Location = new System.Drawing.Point(6, 83);
            this.CityDiscounts_name.Name = "CityDiscounts_name";
            this.CityDiscounts_name.Size = new System.Drawing.Size(48, 17);
            this.CityDiscounts_name.TabIndex = 99;
            this.CityDiscounts_name.Text = "Город";
            // 
            // NameDiscounts
            // 
            this.NameDiscounts.Location = new System.Drawing.Point(164, 52);
            this.NameDiscounts.Name = "NameDiscounts";
            this.NameDiscounts.Size = new System.Drawing.Size(263, 22);
            this.NameDiscounts.TabIndex = 98;
            // 
            // NameDiscounts_name
            // 
            this.NameDiscounts_name.AutoSize = true;
            this.NameDiscounts_name.Location = new System.Drawing.Point(6, 55);
            this.NameDiscounts_name.Name = "NameDiscounts_name";
            this.NameDiscounts_name.Size = new System.Drawing.Size(72, 17);
            this.NameDiscounts_name.TabIndex = 97;
            this.NameDiscounts_name.Text = "Название";
            // 
            // DateOfDiscounts
            // 
            this.DateOfDiscounts.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DateOfDiscounts.Controls.Add(this.ToCheck);
            this.DateOfDiscounts.Controls.Add(this.FromCheck);
            this.DateOfDiscounts.Controls.Add(this.ToDiscounts);
            this.DateOfDiscounts.Controls.Add(this.FromDiscounts);
            this.DateOfDiscounts.Location = new System.Drawing.Point(541, 15);
            this.DateOfDiscounts.Name = "DateOfDiscounts";
            this.DateOfDiscounts.Size = new System.Drawing.Size(247, 117);
            this.DateOfDiscounts.TabIndex = 103;
            this.DateOfDiscounts.TabStop = false;
            this.DateOfDiscounts.Text = "Дата проведения";
            // 
            // ToCheck
            // 
            this.ToCheck.AutoSize = true;
            this.ToCheck.Location = new System.Drawing.Point(6, 75);
            this.ToCheck.Name = "ToCheck";
            this.ToCheck.Size = new System.Drawing.Size(49, 21);
            this.ToCheck.TabIndex = 86;
            this.ToCheck.Text = "До";
            this.ToCheck.UseVisualStyleBackColor = true;
            this.ToCheck.CheckedChanged += new System.EventHandler(this.ToCheck_CheckedChanged);
            // 
            // FromCheck
            // 
            this.FromCheck.AutoSize = true;
            this.FromCheck.Location = new System.Drawing.Point(6, 30);
            this.FromCheck.Name = "FromCheck";
            this.FromCheck.Size = new System.Drawing.Size(48, 21);
            this.FromCheck.TabIndex = 85;
            this.FromCheck.Text = "От";
            this.FromCheck.UseVisualStyleBackColor = true;
            this.FromCheck.CheckedChanged += new System.EventHandler(this.FromCheck_CheckedChanged);
            // 
            // ToDiscounts
            // 
            this.ToDiscounts.Location = new System.Drawing.Point(60, 74);
            this.ToDiscounts.Name = "ToDiscounts";
            this.ToDiscounts.Size = new System.Drawing.Size(140, 22);
            this.ToDiscounts.TabIndex = 84;
            // 
            // FromDiscounts
            // 
            this.FromDiscounts.Location = new System.Drawing.Point(60, 29);
            this.FromDiscounts.Name = "FromDiscounts";
            this.FromDiscounts.Size = new System.Drawing.Size(140, 22);
            this.FromDiscounts.TabIndex = 83;
            // 
            // PageDiscounts
            // 
            this.PageDiscounts.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.PageDiscounts.Location = new System.Drawing.Point(577, 614);
            this.PageDiscounts.Margin = new System.Windows.Forms.Padding(4);
            this.PageDiscounts.Name = "PageDiscounts";
            this.PageDiscounts.Size = new System.Drawing.Size(65, 22);
            this.PageDiscounts.TabIndex = 197;
            // 
            // PagesDiscounts
            // 
            this.PagesDiscounts.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.PagesDiscounts.AutoSize = true;
            this.PagesDiscounts.Location = new System.Drawing.Point(650, 617);
            this.PagesDiscounts.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PagesDiscounts.Name = "PagesDiscounts";
            this.PagesDiscounts.Size = new System.Drawing.Size(46, 17);
            this.PagesDiscounts.TabIndex = 196;
            this.PagesDiscounts.Text = "label1";
            // 
            // BackDiscounts
            // 
            this.BackDiscounts.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BackDiscounts.Location = new System.Drawing.Point(400, 613);
            this.BackDiscounts.Margin = new System.Windows.Forms.Padding(4);
            this.BackDiscounts.Name = "BackDiscounts";
            this.BackDiscounts.Size = new System.Drawing.Size(71, 25);
            this.BackDiscounts.TabIndex = 195;
            this.BackDiscounts.Text = "<";
            this.BackDiscounts.UseVisualStyleBackColor = true;
            // 
            // ChooseDiscounts
            // 
            this.ChooseDiscounts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ChooseDiscounts.BackColor = System.Drawing.Color.DarkOrange;
            this.ChooseDiscounts.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.ChooseDiscounts.FlatAppearance.BorderSize = 3;
            this.ChooseDiscounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChooseDiscounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChooseDiscounts.ForeColor = System.Drawing.Color.White;
            this.ChooseDiscounts.Location = new System.Drawing.Point(12, 608);
            this.ChooseDiscounts.Name = "ChooseDiscounts";
            this.ChooseDiscounts.Size = new System.Drawing.Size(135, 39);
            this.ChooseDiscounts.TabIndex = 199;
            this.ChooseDiscounts.Text = "Выбрать";
            this.ChooseDiscounts.UseVisualStyleBackColor = false;
            this.ChooseDiscounts.Click += new System.EventHandler(this.ChooseDiscounts_Click);
            this.ChooseDiscounts.MouseEnter += new System.EventHandler(this.ChooseDiscounts_MouseEnter);
            this.ChooseDiscounts.MouseLeave += new System.EventHandler(this.ChooseDiscounts_MouseLeave);
            // 
            // AddDiscounts
            // 
            this.AddDiscounts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddDiscounts.BackColor = System.Drawing.Color.DarkOrange;
            this.AddDiscounts.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.AddDiscounts.FlatAppearance.BorderSize = 3;
            this.AddDiscounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddDiscounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddDiscounts.ForeColor = System.Drawing.Color.White;
            this.AddDiscounts.Location = new System.Drawing.Point(1043, 608);
            this.AddDiscounts.Name = "AddDiscounts";
            this.AddDiscounts.Size = new System.Drawing.Size(135, 39);
            this.AddDiscounts.TabIndex = 198;
            this.AddDiscounts.Text = "Добавить";
            this.AddDiscounts.UseVisualStyleBackColor = false;
            this.AddDiscounts.Click += new System.EventHandler(this.AddDiscounts_Click);
            this.AddDiscounts.MouseEnter += new System.EventHandler(this.AddDiscounts_MouseEnter);
            this.AddDiscounts.MouseLeave += new System.EventHandler(this.AddDiscounts_MouseLeave);
            // 
            // DiscountsTo
            // 
            this.DiscountsTo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.DiscountsTo.Location = new System.Drawing.Point(719, 613);
            this.DiscountsTo.Margin = new System.Windows.Forms.Padding(4);
            this.DiscountsTo.Name = "DiscountsTo";
            this.DiscountsTo.Size = new System.Drawing.Size(71, 25);
            this.DiscountsTo.TabIndex = 194;
            this.DiscountsTo.Text = ">";
            this.DiscountsTo.UseVisualStyleBackColor = true;
            // 
            // AllDiscounts
            // 
            this.AllDiscounts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AllDiscounts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AllDiscounts.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AllDiscounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllDiscounts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CheckDiscount,
            this.Id_discount,
            this.Name_discount,
            this.Start_discount,
            this.End_discount,
            this.PriceModifier_Discount,
            this.Branch_discount});
            this.AllDiscounts.Location = new System.Drawing.Point(12, 206);
            this.AllDiscounts.Name = "AllDiscounts";
            this.AllDiscounts.RowHeadersWidth = 51;
            this.AllDiscounts.RowTemplate.Height = 24;
            this.AllDiscounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AllDiscounts.Size = new System.Drawing.Size(1166, 381);
            this.AllDiscounts.TabIndex = 90;
            this.AllDiscounts.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AllDiscounts_CellDoubleClick);
            // 
            // CheckDiscount
            // 
            this.CheckDiscount.FalseValue = "";
            this.CheckDiscount.HeaderText = "";
            this.CheckDiscount.MinimumWidth = 6;
            this.CheckDiscount.Name = "CheckDiscount";
            this.CheckDiscount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Id_discount
            // 
            this.Id_discount.HeaderText = "Id";
            this.Id_discount.MinimumWidth = 6;
            this.Id_discount.Name = "Id_discount";
            // 
            // Name_discount
            // 
            this.Name_discount.HeaderText = "Название";
            this.Name_discount.MinimumWidth = 6;
            this.Name_discount.Name = "Name_discount";
            // 
            // Start_discount
            // 
            this.Start_discount.HeaderText = "Начало действия";
            this.Start_discount.MinimumWidth = 6;
            this.Start_discount.Name = "Start_discount";
            // 
            // End_discount
            // 
            this.End_discount.HeaderText = "Окончание действия";
            this.End_discount.MinimumWidth = 6;
            this.End_discount.Name = "End_discount";
            // 
            // PriceModifier_Discount
            // 
            this.PriceModifier_Discount.HeaderText = "Размер(%)";
            this.PriceModifier_Discount.MinimumWidth = 6;
            this.PriceModifier_Discount.Name = "PriceModifier_Discount";
            // 
            // Branch_discount
            // 
            this.Branch_discount.HeaderText = "Филиал";
            this.Branch_discount.MinimumWidth = 6;
            this.Branch_discount.Name = "Branch_discount";
            // 
            // FindDiscounts
            // 
            this.FindDiscounts.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.FindDiscounts.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FindDiscounts.BackgroundImage")));
            this.FindDiscounts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FindDiscounts.Location = new System.Drawing.Point(499, 613);
            this.FindDiscounts.Margin = new System.Windows.Forms.Padding(4);
            this.FindDiscounts.Name = "FindDiscounts";
            this.FindDiscounts.Size = new System.Drawing.Size(43, 25);
            this.FindDiscounts.TabIndex = 231;
            this.FindDiscounts.UseVisualStyleBackColor = true;
            // 
            // Discounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1190, 659);
            this.Controls.Add(this.FindDiscounts);
            this.Controls.Add(this.PageDiscounts);
            this.Controls.Add(this.PagesDiscounts);
            this.Controls.Add(this.BackDiscounts);
            this.Controls.Add(this.ChooseDiscounts);
            this.Controls.Add(this.AddDiscounts);
            this.Controls.Add(this.DiscountsTo);
            this.Controls.Add(this.AllDiscounts);
            this.Controls.Add(this.FiltersDoscounts);
            this.Name = "Discounts";
            this.Text = "Скидки(Discounts)";
            this.Load += new System.EventHandler(this.Discounts_Load);
            this.FiltersDoscounts.ResumeLayout(false);
            this.FiltersDoscounts.PerformLayout();
            this.DateOfDiscounts.ResumeLayout(false);
            this.DateOfDiscounts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AllDiscounts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox FiltersDoscounts;
        private System.Windows.Forms.TextBox IDDiscounts;
        private System.Windows.Forms.Label IDDiscounts_name;
        private System.Windows.Forms.ComboBox SortingDiscounts;
        private System.Windows.Forms.Label SortingDiscounts_name;
        private System.Windows.Forms.Label CityDiscounts_name;
        private System.Windows.Forms.TextBox NameDiscounts;
        private System.Windows.Forms.Label NameDiscounts_name;
        private System.Windows.Forms.GroupBox DateOfDiscounts;
        private System.Windows.Forms.DateTimePicker ToDiscounts;
        private System.Windows.Forms.DateTimePicker FromDiscounts;
        private System.Windows.Forms.Button BranchDiscountsChoose;
        private System.Windows.Forms.LinkLabel BranchDiscounts;
        private System.Windows.Forms.Label BranchDiscounts_name;
        private System.Windows.Forms.TextBox PageDiscounts;
        private System.Windows.Forms.Label PagesDiscounts;
        private System.Windows.Forms.Button BackDiscounts;
        private System.Windows.Forms.Button ChooseDiscounts;
        private System.Windows.Forms.Button AddDiscounts;
        private System.Windows.Forms.Button DiscountsTo;
        private System.Windows.Forms.DataGridView AllDiscounts;
        private System.Windows.Forms.Button ApplyDiscounts;
        private System.Windows.Forms.Button ResetDiscounts;
        private System.Windows.Forms.Button FindDiscounts;
        private System.Windows.Forms.TextBox CityDiscounts;
        private System.Windows.Forms.Button SortDesc_Discounts;
        private System.Windows.Forms.CheckBox ToCheck;
        private System.Windows.Forms.CheckBox FromCheck;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Start_discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn End_discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceModifier_Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Branch_discount;
    }
}