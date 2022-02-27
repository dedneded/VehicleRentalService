
namespace form
{
    partial class Branches
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Branches));
            this.FiltersBranches = new System.Windows.Forms.GroupBox();
            this.StreetBranches = new System.Windows.Forms.TextBox();
            this.CityBranches = new System.Windows.Forms.TextBox();
            this.SortDesc_Branch = new System.Windows.Forms.Button();
            this.ApplyBranch = new System.Windows.Forms.Button();
            this.Sorting_branch_name = new System.Windows.Forms.Label();
            this.Sorting_branch = new System.Windows.Forms.ComboBox();
            this.Address_branch_name = new System.Windows.Forms.Label();
            this.City_branch_name = new System.Windows.Forms.Label();
            this.ResetBranch = new System.Windows.Forms.Button();
            this.ID_branch = new System.Windows.Forms.TextBox();
            this.ID_branch_name = new System.Windows.Forms.Label();
            this.AllBranches = new System.Windows.Forms.DataGridView();
            this.CheckColumns = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Id_branches = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone_branch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address_branches = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Page_branch = new System.Windows.Forms.TextBox();
            this.Pages_Branch = new System.Windows.Forms.Label();
            this.Back_branch = new System.Windows.Forms.Button();
            this.Choose_branch = new System.Windows.Forms.Button();
            this.Add_branch = new System.Windows.Forms.Button();
            this.To_branch = new System.Windows.Forms.Button();
            this.FindBranches = new System.Windows.Forms.Button();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.FiltersBranches.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AllBranches)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // FiltersBranches
            // 
            this.FiltersBranches.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FiltersBranches.Controls.Add(this.StreetBranches);
            this.FiltersBranches.Controls.Add(this.CityBranches);
            this.FiltersBranches.Controls.Add(this.SortDesc_Branch);
            this.FiltersBranches.Controls.Add(this.ApplyBranch);
            this.FiltersBranches.Controls.Add(this.Sorting_branch_name);
            this.FiltersBranches.Controls.Add(this.Sorting_branch);
            this.FiltersBranches.Controls.Add(this.Address_branch_name);
            this.FiltersBranches.Controls.Add(this.City_branch_name);
            this.FiltersBranches.Controls.Add(this.ResetBranch);
            this.FiltersBranches.Controls.Add(this.ID_branch);
            this.FiltersBranches.Controls.Add(this.ID_branch_name);
            this.FiltersBranches.Location = new System.Drawing.Point(12, 12);
            this.FiltersBranches.Name = "FiltersBranches";
            this.FiltersBranches.Size = new System.Drawing.Size(743, 150);
            this.FiltersBranches.TabIndex = 0;
            this.FiltersBranches.TabStop = false;
            this.FiltersBranches.Text = "Фильтры";
            // 
            // StreetBranches
            // 
            this.StreetBranches.Location = new System.Drawing.Point(139, 83);
            this.StreetBranches.Name = "StreetBranches";
            this.StreetBranches.Size = new System.Drawing.Size(269, 22);
            this.StreetBranches.TabIndex = 208;
            this.StreetBranches.TextChanged += new System.EventHandler(this.StreetBranches_TextChanged);
            // 
            // CityBranches
            // 
            this.CityBranches.Location = new System.Drawing.Point(139, 50);
            this.CityBranches.Name = "CityBranches";
            this.CityBranches.Size = new System.Drawing.Size(269, 22);
            this.CityBranches.TabIndex = 207;
            this.CityBranches.TextChanged += new System.EventHandler(this.CityBranches_TextChanged);
            // 
            // SortDesc_Branch
            // 
            this.SortDesc_Branch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SortDesc_Branch.BackgroundImage")));
            this.SortDesc_Branch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SortDesc_Branch.Location = new System.Drawing.Point(416, 108);
            this.SortDesc_Branch.Name = "SortDesc_Branch";
            this.SortDesc_Branch.Size = new System.Drawing.Size(36, 26);
            this.SortDesc_Branch.TabIndex = 206;
            this.SortDesc_Branch.UseVisualStyleBackColor = true;
            this.SortDesc_Branch.Click += new System.EventHandler(this.SortDesc_Branch_Click);
            // 
            // ApplyBranch
            // 
            this.ApplyBranch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ApplyBranch.BackColor = System.Drawing.Color.White;
            this.ApplyBranch.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.ApplyBranch.FlatAppearance.BorderSize = 2;
            this.ApplyBranch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ApplyBranch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ApplyBranch.ForeColor = System.Drawing.Color.DarkOrange;
            this.ApplyBranch.Location = new System.Drawing.Point(626, 80);
            this.ApplyBranch.Name = "ApplyBranch";
            this.ApplyBranch.Size = new System.Drawing.Size(110, 28);
            this.ApplyBranch.TabIndex = 194;
            this.ApplyBranch.Text = "Применить";
            this.ApplyBranch.UseVisualStyleBackColor = false;
            this.ApplyBranch.Click += new System.EventHandler(this.ApplyBranch_Click);
            this.ApplyBranch.MouseEnter += new System.EventHandler(this.ApplyBranch_MouseEnter);
            this.ApplyBranch.MouseLeave += new System.EventHandler(this.ApplyBranch_MouseLeave);
            // 
            // Sorting_branch_name
            // 
            this.Sorting_branch_name.AutoSize = true;
            this.Sorting_branch_name.Location = new System.Drawing.Point(6, 113);
            this.Sorting_branch_name.Name = "Sorting_branch_name";
            this.Sorting_branch_name.Size = new System.Drawing.Size(93, 17);
            this.Sorting_branch_name.TabIndex = 192;
            this.Sorting_branch_name.Text = "Сортировать";
            // 
            // Sorting_branch
            // 
            this.Sorting_branch.FormattingEnabled = true;
            this.Sorting_branch.Location = new System.Drawing.Point(139, 110);
            this.Sorting_branch.Name = "Sorting_branch";
            this.Sorting_branch.Size = new System.Drawing.Size(269, 24);
            this.Sorting_branch.TabIndex = 193;
            this.Sorting_branch.SelectedIndexChanged += new System.EventHandler(this.Sorting_branch_SelectedIndexChanged);
            // 
            // Address_branch_name
            // 
            this.Address_branch_name.AutoSize = true;
            this.Address_branch_name.Location = new System.Drawing.Point(6, 83);
            this.Address_branch_name.Name = "Address_branch_name";
            this.Address_branch_name.Size = new System.Drawing.Size(49, 17);
            this.Address_branch_name.TabIndex = 4;
            this.Address_branch_name.Text = "Улица";
            // 
            // City_branch_name
            // 
            this.City_branch_name.AutoSize = true;
            this.City_branch_name.Location = new System.Drawing.Point(6, 53);
            this.City_branch_name.Name = "City_branch_name";
            this.City_branch_name.Size = new System.Drawing.Size(48, 17);
            this.City_branch_name.TabIndex = 2;
            this.City_branch_name.Text = "Город";
            // 
            // ResetBranch
            // 
            this.ResetBranch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ResetBranch.BackColor = System.Drawing.Color.White;
            this.ResetBranch.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.ResetBranch.FlatAppearance.BorderSize = 2;
            this.ResetBranch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetBranch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResetBranch.ForeColor = System.Drawing.Color.DarkOrange;
            this.ResetBranch.Location = new System.Drawing.Point(626, 116);
            this.ResetBranch.Name = "ResetBranch";
            this.ResetBranch.Size = new System.Drawing.Size(110, 28);
            this.ResetBranch.TabIndex = 181;
            this.ResetBranch.Text = "Сбросить";
            this.ResetBranch.UseVisualStyleBackColor = false;
            this.ResetBranch.Click += new System.EventHandler(this.ResetBranch_Click);
            this.ResetBranch.MouseEnter += new System.EventHandler(this.ResetBranch_MouseEnter);
            this.ResetBranch.MouseLeave += new System.EventHandler(this.ResetBranch_MouseLeave);
            // 
            // ID_branch
            // 
            this.ID_branch.Location = new System.Drawing.Point(139, 22);
            this.ID_branch.Name = "ID_branch";
            this.ID_branch.Size = new System.Drawing.Size(269, 22);
            this.ID_branch.TabIndex = 1;
            this.ID_branch.TextChanged += new System.EventHandler(this.ID_branch_TextChanged);
            // 
            // ID_branch_name
            // 
            this.ID_branch_name.AutoSize = true;
            this.ID_branch_name.Location = new System.Drawing.Point(6, 25);
            this.ID_branch_name.Name = "ID_branch_name";
            this.ID_branch_name.Size = new System.Drawing.Size(21, 17);
            this.ID_branch_name.TabIndex = 0;
            this.ID_branch_name.Text = "ID";
            // 
            // AllBranches
            // 
            this.AllBranches.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AllBranches.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AllBranches.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AllBranches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllBranches.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CheckColumns,
            this.Id_branches,
            this.Phone_branch,
            this.Address_branches});
            this.AllBranches.Location = new System.Drawing.Point(12, 168);
            this.AllBranches.Name = "AllBranches";
            this.AllBranches.RowHeadersWidth = 51;
            this.AllBranches.RowTemplate.Height = 24;
            this.AllBranches.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AllBranches.Size = new System.Drawing.Size(736, 344);
            this.AllBranches.TabIndex = 1;
            this.AllBranches.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AllBranches_CellDoubleClick);
            // 
            // CheckColumns
            // 
            this.CheckColumns.HeaderText = "";
            this.CheckColumns.MinimumWidth = 6;
            this.CheckColumns.Name = "CheckColumns";
            this.CheckColumns.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CheckColumns.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Id_branches
            // 
            this.Id_branches.HeaderText = "Id";
            this.Id_branches.MinimumWidth = 6;
            this.Id_branches.Name = "Id_branches";
            // 
            // Phone_branch
            // 
            this.Phone_branch.HeaderText = "Телефон";
            this.Phone_branch.MinimumWidth = 6;
            this.Phone_branch.Name = "Phone_branch";
            // 
            // Address_branches
            // 
            this.Address_branches.HeaderText = "Адрес";
            this.Address_branches.MinimumWidth = 6;
            this.Address_branches.Name = "Address_branches";
            // 
            // Page_branch
            // 
            this.Page_branch.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Page_branch.Location = new System.Drawing.Point(355, 532);
            this.Page_branch.Margin = new System.Windows.Forms.Padding(4);
            this.Page_branch.Name = "Page_branch";
            this.Page_branch.Size = new System.Drawing.Size(65, 22);
            this.Page_branch.TabIndex = 185;
            // 
            // Pages_Branch
            // 
            this.Pages_Branch.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Pages_Branch.AutoSize = true;
            this.Pages_Branch.Location = new System.Drawing.Point(428, 535);
            this.Pages_Branch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Pages_Branch.Name = "Pages_Branch";
            this.Pages_Branch.Size = new System.Drawing.Size(46, 17);
            this.Pages_Branch.TabIndex = 184;
            this.Pages_Branch.Text = "label1";
            // 
            // Back_branch
            // 
            this.Back_branch.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Back_branch.Location = new System.Drawing.Point(200, 531);
            this.Back_branch.Margin = new System.Windows.Forms.Padding(4);
            this.Back_branch.Name = "Back_branch";
            this.Back_branch.Size = new System.Drawing.Size(71, 25);
            this.Back_branch.TabIndex = 183;
            this.Back_branch.Text = "<";
            this.Back_branch.UseVisualStyleBackColor = true;
            // 
            // Choose_branch
            // 
            this.Choose_branch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Choose_branch.BackColor = System.Drawing.Color.DarkOrange;
            this.Choose_branch.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.Choose_branch.FlatAppearance.BorderSize = 3;
            this.Choose_branch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Choose_branch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Choose_branch.ForeColor = System.Drawing.Color.White;
            this.Choose_branch.Location = new System.Drawing.Point(12, 523);
            this.Choose_branch.Name = "Choose_branch";
            this.Choose_branch.Size = new System.Drawing.Size(135, 39);
            this.Choose_branch.TabIndex = 187;
            this.Choose_branch.Text = "Выбрать";
            this.Choose_branch.UseVisualStyleBackColor = false;
            this.Choose_branch.Click += new System.EventHandler(this.Choose_branch_Click);
            this.Choose_branch.MouseEnter += new System.EventHandler(this.Choose_branch_MouseEnter);
            this.Choose_branch.MouseLeave += new System.EventHandler(this.Choose_branch_MouseLeave);
            // 
            // Add_branch
            // 
            this.Add_branch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Add_branch.BackColor = System.Drawing.Color.DarkOrange;
            this.Add_branch.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.Add_branch.FlatAppearance.BorderSize = 3;
            this.Add_branch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_branch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add_branch.ForeColor = System.Drawing.Color.White;
            this.Add_branch.Location = new System.Drawing.Point(613, 523);
            this.Add_branch.Name = "Add_branch";
            this.Add_branch.Size = new System.Drawing.Size(135, 39);
            this.Add_branch.TabIndex = 186;
            this.Add_branch.Text = "Добавить";
            this.Add_branch.UseVisualStyleBackColor = false;
            this.Add_branch.Click += new System.EventHandler(this.Add_branch_Click);
            this.Add_branch.MouseEnter += new System.EventHandler(this.Add_branch_MouseEnter);
            this.Add_branch.MouseLeave += new System.EventHandler(this.Add_branch_MouseLeave);
            // 
            // To_branch
            // 
            this.To_branch.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.To_branch.Location = new System.Drawing.Point(497, 531);
            this.To_branch.Margin = new System.Windows.Forms.Padding(4);
            this.To_branch.Name = "To_branch";
            this.To_branch.Size = new System.Drawing.Size(71, 25);
            this.To_branch.TabIndex = 182;
            this.To_branch.Text = ">";
            this.To_branch.UseVisualStyleBackColor = true;
            // 
            // FindBranches
            // 
            this.FindBranches.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.FindBranches.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FindBranches.BackgroundImage")));
            this.FindBranches.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FindBranches.Location = new System.Drawing.Point(288, 529);
            this.FindBranches.Margin = new System.Windows.Forms.Padding(4);
            this.FindBranches.Name = "FindBranches";
            this.FindBranches.Size = new System.Drawing.Size(43, 25);
            this.FindBranches.TabIndex = 231;
            this.FindBranches.UseVisualStyleBackColor = true;
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // Branches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(767, 574);
            this.Controls.Add(this.FindBranches);
            this.Controls.Add(this.Page_branch);
            this.Controls.Add(this.Pages_Branch);
            this.Controls.Add(this.Back_branch);
            this.Controls.Add(this.Choose_branch);
            this.Controls.Add(this.Add_branch);
            this.Controls.Add(this.To_branch);
            this.Controls.Add(this.AllBranches);
            this.Controls.Add(this.FiltersBranches);
            this.Name = "Branches";
            this.Text = "Филиалы(Branches)";
            this.Load += new System.EventHandler(this.Branches_Load);
            this.FiltersBranches.ResumeLayout(false);
            this.FiltersBranches.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AllBranches)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox FiltersBranches;
        private System.Windows.Forms.TextBox ID_branch;
        private System.Windows.Forms.Label ID_branch_name;
        private System.Windows.Forms.Label Address_branch_name;
        private System.Windows.Forms.Label City_branch_name;
        private System.Windows.Forms.Label Sorting_branch_name;
        private System.Windows.Forms.ComboBox Sorting_branch;
        private System.Windows.Forms.DataGridView AllBranches;
        private System.Windows.Forms.Button ResetBranch;
        private System.Windows.Forms.TextBox Page_branch;
        private System.Windows.Forms.Label Pages_Branch;
        private System.Windows.Forms.Button Back_branch;
        private System.Windows.Forms.Button Choose_branch;
        private System.Windows.Forms.Button Add_branch;
        private System.Windows.Forms.Button To_branch;
        private System.Windows.Forms.Button ApplyBranch;
        private System.Windows.Forms.Button FindBranches;
        private System.Windows.Forms.Button SortDesc_Branch;
        private System.Windows.Forms.TextBox CityBranches;
        private System.Windows.Forms.TextBox StreetBranches;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckColumns;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_branches;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone_branch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address_branches;
        private System.Windows.Forms.ErrorProvider error;
    }
}