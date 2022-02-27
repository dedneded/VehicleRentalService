
namespace form
{
    partial class Services
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Services));
            this.FiltersServices = new System.Windows.Forms.GroupBox();
            this.SortDescServices = new System.Windows.Forms.Button();
            this.ApplyService = new System.Windows.Forms.Button();
            this.ResetServices = new System.Windows.Forms.Button();
            this.NameServices = new System.Windows.Forms.TextBox();
            this.FindServices_name = new System.Windows.Forms.Label();
            this.SortingServices = new System.Windows.Forms.ComboBox();
            this.SortingServices_name = new System.Windows.Forms.Label();
            this.IDServices = new System.Windows.Forms.TextBox();
            this.IDServices_name = new System.Windows.Forms.Label();
            this.AllServices = new System.Windows.Forms.DataGridView();
            this.CheckServices = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ID_service = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_service = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Parent_service = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PageServices = new System.Windows.Forms.TextBox();
            this.PagesServices = new System.Windows.Forms.Label();
            this.BackServices = new System.Windows.Forms.Button();
            this.ChooseServices = new System.Windows.Forms.Button();
            this.AddServices = new System.Windows.Forms.Button();
            this.ToServices = new System.Windows.Forms.Button();
            this.FindService = new System.Windows.Forms.Button();
            this.FiltersServices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AllServices)).BeginInit();
            this.SuspendLayout();
            // 
            // FiltersServices
            // 
            this.FiltersServices.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FiltersServices.Controls.Add(this.SortDescServices);
            this.FiltersServices.Controls.Add(this.ApplyService);
            this.FiltersServices.Controls.Add(this.ResetServices);
            this.FiltersServices.Controls.Add(this.NameServices);
            this.FiltersServices.Controls.Add(this.FindServices_name);
            this.FiltersServices.Controls.Add(this.SortingServices);
            this.FiltersServices.Controls.Add(this.SortingServices_name);
            this.FiltersServices.Controls.Add(this.IDServices);
            this.FiltersServices.Controls.Add(this.IDServices_name);
            this.FiltersServices.Location = new System.Drawing.Point(4, 3);
            this.FiltersServices.Name = "FiltersServices";
            this.FiltersServices.Size = new System.Drawing.Size(777, 139);
            this.FiltersServices.TabIndex = 0;
            this.FiltersServices.TabStop = false;
            this.FiltersServices.Text = "Фильтры";
            // 
            // SortDescServices
            // 
            this.SortDescServices.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SortDescServices.BackgroundImage")));
            this.SortDescServices.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SortDescServices.Location = new System.Drawing.Point(295, 85);
            this.SortDescServices.Name = "SortDescServices";
            this.SortDescServices.Size = new System.Drawing.Size(36, 24);
            this.SortDescServices.TabIndex = 236;
            this.SortDescServices.UseVisualStyleBackColor = true;
            this.SortDescServices.Click += new System.EventHandler(this.SortDescServices_Click);
            // 
            // ApplyService
            // 
            this.ApplyService.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ApplyService.BackColor = System.Drawing.Color.White;
            this.ApplyService.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.ApplyService.FlatAppearance.BorderSize = 2;
            this.ApplyService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ApplyService.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ApplyService.ForeColor = System.Drawing.Color.DarkOrange;
            this.ApplyService.Location = new System.Drawing.Point(664, 71);
            this.ApplyService.Name = "ApplyService";
            this.ApplyService.Size = new System.Drawing.Size(110, 28);
            this.ApplyService.TabIndex = 208;
            this.ApplyService.Text = "Применить";
            this.ApplyService.UseVisualStyleBackColor = false;
            this.ApplyService.Click += new System.EventHandler(this.ApplyService_Click);
            this.ApplyService.MouseEnter += new System.EventHandler(this.ApplyService_MouseEnter);
            this.ApplyService.MouseLeave += new System.EventHandler(this.ApplyService_MouseLeave);
            // 
            // ResetServices
            // 
            this.ResetServices.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ResetServices.BackColor = System.Drawing.Color.White;
            this.ResetServices.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.ResetServices.FlatAppearance.BorderSize = 2;
            this.ResetServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResetServices.ForeColor = System.Drawing.Color.DarkOrange;
            this.ResetServices.Location = new System.Drawing.Point(664, 105);
            this.ResetServices.Name = "ResetServices";
            this.ResetServices.Size = new System.Drawing.Size(110, 28);
            this.ResetServices.TabIndex = 207;
            this.ResetServices.Text = "Сбросить";
            this.ResetServices.UseVisualStyleBackColor = false;
            this.ResetServices.Click += new System.EventHandler(this.ResetServices_Click);
            this.ResetServices.MouseEnter += new System.EventHandler(this.ResetServices_MouseEnter);
            this.ResetServices.MouseLeave += new System.EventHandler(this.ResetServices_MouseLeave);
            // 
            // NameServices
            // 
            this.NameServices.Location = new System.Drawing.Point(108, 57);
            this.NameServices.Name = "NameServices";
            this.NameServices.Size = new System.Drawing.Size(181, 22);
            this.NameServices.TabIndex = 175;
            // 
            // FindServices_name
            // 
            this.FindServices_name.AutoSize = true;
            this.FindServices_name.Location = new System.Drawing.Point(9, 60);
            this.FindServices_name.Name = "FindServices_name";
            this.FindServices_name.Size = new System.Drawing.Size(72, 17);
            this.FindServices_name.TabIndex = 174;
            this.FindServices_name.Text = "Название";
            // 
            // SortingServices
            // 
            this.SortingServices.FormattingEnabled = true;
            this.SortingServices.Location = new System.Drawing.Point(108, 85);
            this.SortingServices.Name = "SortingServices";
            this.SortingServices.Size = new System.Drawing.Size(181, 24);
            this.SortingServices.TabIndex = 3;
            this.SortingServices.SelectedIndexChanged += new System.EventHandler(this.SortingServices_SelectedIndexChanged);
            // 
            // SortingServices_name
            // 
            this.SortingServices_name.AutoSize = true;
            this.SortingServices_name.Location = new System.Drawing.Point(9, 88);
            this.SortingServices_name.Name = "SortingServices_name";
            this.SortingServices_name.Size = new System.Drawing.Size(93, 17);
            this.SortingServices_name.TabIndex = 2;
            this.SortingServices_name.Text = "Сортировать";
            // 
            // IDServices
            // 
            this.IDServices.Location = new System.Drawing.Point(108, 29);
            this.IDServices.Name = "IDServices";
            this.IDServices.Size = new System.Drawing.Size(181, 22);
            this.IDServices.TabIndex = 1;
            // 
            // IDServices_name
            // 
            this.IDServices_name.AutoSize = true;
            this.IDServices_name.Location = new System.Drawing.Point(9, 32);
            this.IDServices_name.Name = "IDServices_name";
            this.IDServices_name.Size = new System.Drawing.Size(21, 17);
            this.IDServices_name.TabIndex = 0;
            this.IDServices_name.Text = "ID";
            // 
            // AllServices
            // 
            this.AllServices.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AllServices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AllServices.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AllServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllServices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CheckServices,
            this.ID_service,
            this.Name_service,
            this.Parent_service});
            this.AllServices.Location = new System.Drawing.Point(5, 148);
            this.AllServices.Name = "AllServices";
            this.AllServices.RowHeadersWidth = 51;
            this.AllServices.RowTemplate.Height = 24;
            this.AllServices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AllServices.Size = new System.Drawing.Size(778, 429);
            this.AllServices.TabIndex = 181;
            this.AllServices.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AllServices_CellDoubleClick);
            // 
            // CheckServices
            // 
            this.CheckServices.HeaderText = "";
            this.CheckServices.MinimumWidth = 6;
            this.CheckServices.Name = "CheckServices";
            this.CheckServices.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CheckServices.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ID_service
            // 
            this.ID_service.HeaderText = "ID";
            this.ID_service.MinimumWidth = 6;
            this.ID_service.Name = "ID_service";
            this.ID_service.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Name_service
            // 
            this.Name_service.HeaderText = "Название";
            this.Name_service.MinimumWidth = 6;
            this.Name_service.Name = "Name_service";
            this.Name_service.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Parent_service
            // 
            this.Parent_service.HeaderText = "Parent";
            this.Parent_service.MinimumWidth = 6;
            this.Parent_service.Name = "Parent_service";
            // 
            // PageServices
            // 
            this.PageServices.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.PageServices.Location = new System.Drawing.Point(362, 601);
            this.PageServices.Margin = new System.Windows.Forms.Padding(4);
            this.PageServices.Name = "PageServices";
            this.PageServices.Size = new System.Drawing.Size(65, 22);
            this.PageServices.TabIndex = 185;
            // 
            // PagesServices
            // 
            this.PagesServices.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.PagesServices.AutoSize = true;
            this.PagesServices.Location = new System.Drawing.Point(435, 604);
            this.PagesServices.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PagesServices.Name = "PagesServices";
            this.PagesServices.Size = new System.Drawing.Size(46, 17);
            this.PagesServices.TabIndex = 184;
            this.PagesServices.Text = "label1";
            // 
            // BackServices
            // 
            this.BackServices.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BackServices.Location = new System.Drawing.Point(212, 600);
            this.BackServices.Margin = new System.Windows.Forms.Padding(4);
            this.BackServices.Name = "BackServices";
            this.BackServices.Size = new System.Drawing.Size(71, 25);
            this.BackServices.TabIndex = 183;
            this.BackServices.Text = "<";
            this.BackServices.UseVisualStyleBackColor = true;
            // 
            // ChooseServices
            // 
            this.ChooseServices.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ChooseServices.BackColor = System.Drawing.Color.DarkOrange;
            this.ChooseServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChooseServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChooseServices.ForeColor = System.Drawing.Color.White;
            this.ChooseServices.Location = new System.Drawing.Point(4, 592);
            this.ChooseServices.Name = "ChooseServices";
            this.ChooseServices.Size = new System.Drawing.Size(135, 39);
            this.ChooseServices.TabIndex = 187;
            this.ChooseServices.Text = "Выбрать";
            this.ChooseServices.UseVisualStyleBackColor = false;
            this.ChooseServices.Click += new System.EventHandler(this.ChooseServices_Click);
            this.ChooseServices.MouseEnter += new System.EventHandler(this.ChooseServices_MouseEnter);
            this.ChooseServices.MouseLeave += new System.EventHandler(this.ChooseServices_MouseLeave);
            // 
            // AddServices
            // 
            this.AddServices.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddServices.BackColor = System.Drawing.Color.DarkOrange;
            this.AddServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddServices.ForeColor = System.Drawing.Color.White;
            this.AddServices.Location = new System.Drawing.Point(646, 592);
            this.AddServices.Name = "AddServices";
            this.AddServices.Size = new System.Drawing.Size(135, 39);
            this.AddServices.TabIndex = 186;
            this.AddServices.Text = "Добавить";
            this.AddServices.UseVisualStyleBackColor = false;
            this.AddServices.Click += new System.EventHandler(this.AddServices_Click);
            this.AddServices.MouseEnter += new System.EventHandler(this.AddServices_MouseEnter);
            this.AddServices.MouseLeave += new System.EventHandler(this.AddServices_MouseLeave);
            // 
            // ToServices
            // 
            this.ToServices.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ToServices.Location = new System.Drawing.Point(504, 600);
            this.ToServices.Margin = new System.Windows.Forms.Padding(4);
            this.ToServices.Name = "ToServices";
            this.ToServices.Size = new System.Drawing.Size(71, 25);
            this.ToServices.TabIndex = 182;
            this.ToServices.Text = ">";
            this.ToServices.UseVisualStyleBackColor = true;
            // 
            // FindService
            // 
            this.FindService.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.FindService.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FindService.BackgroundImage")));
            this.FindService.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FindService.Location = new System.Drawing.Point(302, 601);
            this.FindService.Margin = new System.Windows.Forms.Padding(4);
            this.FindService.Name = "FindService";
            this.FindService.Size = new System.Drawing.Size(43, 25);
            this.FindService.TabIndex = 235;
            this.FindService.UseVisualStyleBackColor = true;
            // 
            // Services
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(790, 651);
            this.Controls.Add(this.FindService);
            this.Controls.Add(this.PageServices);
            this.Controls.Add(this.PagesServices);
            this.Controls.Add(this.BackServices);
            this.Controls.Add(this.ChooseServices);
            this.Controls.Add(this.AddServices);
            this.Controls.Add(this.ToServices);
            this.Controls.Add(this.AllServices);
            this.Controls.Add(this.FiltersServices);
            this.Name = "Services";
            this.Text = "Услуги(Services)";
            this.Load += new System.EventHandler(this.Services_Load);
            this.FiltersServices.ResumeLayout(false);
            this.FiltersServices.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AllServices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox FiltersServices;
        private System.Windows.Forms.ComboBox SortingServices;
        private System.Windows.Forms.Label SortingServices_name;
        private System.Windows.Forms.TextBox IDServices;
        private System.Windows.Forms.Label IDServices_name;
        private System.Windows.Forms.DataGridView AllServices;
        private System.Windows.Forms.TextBox NameServices;
        private System.Windows.Forms.Label FindServices_name;
        private System.Windows.Forms.TextBox PageServices;
        private System.Windows.Forms.Label PagesServices;
        private System.Windows.Forms.Button BackServices;
        private System.Windows.Forms.Button ChooseServices;
        private System.Windows.Forms.Button AddServices;
        private System.Windows.Forms.Button ToServices;
        private System.Windows.Forms.Button ApplyService;
        private System.Windows.Forms.Button ResetServices;
        private System.Windows.Forms.Button FindService;
        private System.Windows.Forms.Button SortDescServices;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckServices;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_service;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_service;
        private System.Windows.Forms.DataGridViewTextBoxColumn Parent_service;
    }
}