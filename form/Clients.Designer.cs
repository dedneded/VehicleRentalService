
namespace form
{
    partial class Clients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clients));
            this.AllClients = new System.Windows.Forms.DataGridView();
            this.Id_client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fio_client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone_client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FiltersClients = new System.Windows.Forms.GroupBox();
            this.SortDesc_Clients = new System.Windows.Forms.Button();
            this.ApplyFilters = new System.Windows.Forms.Button();
            this.ResetFilters = new System.Windows.Forms.Button();
            this.IDClients = new System.Windows.Forms.TextBox();
            this.IDClients_name = new System.Windows.Forms.Label();
            this.ClientsSorting = new System.Windows.Forms.ComboBox();
            this.ClinetsSorting_name = new System.Windows.Forms.Label();
            this.PhoneClients = new System.Windows.Forms.TextBox();
            this.PhoneClients_name = new System.Windows.Forms.Label();
            this.FIOClients = new System.Windows.Forms.TextBox();
            this.FIOClients_name = new System.Windows.Forms.Label();
            this.QuantityOrdersClients = new System.Windows.Forms.GroupBox();
            this.To_name = new System.Windows.Forms.Label();
            this.ToClients = new System.Windows.Forms.TextBox();
            this.From_name = new System.Windows.Forms.Label();
            this.From = new System.Windows.Forms.TextBox();
            this.find_page = new System.Windows.Forms.TextBox();
            this.page_number = new System.Windows.Forms.Label();
            this.next = new System.Windows.Forms.Button();
            this.ChooseClinets = new System.Windows.Forms.Button();
            this.prev = new System.Windows.Forms.Button();
            this.FindClients = new System.Windows.Forms.Button();
            this.ErrorId = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrorFio = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrorFrom = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrorTo = new System.Windows.Forms.ErrorProvider(this.components);
            this.AddClinets = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AllClients)).BeginInit();
            this.FiltersClients.SuspendLayout();
            this.QuantityOrdersClients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorFio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorTo)).BeginInit();
            this.SuspendLayout();
            // 
            // AllClients
            // 
            this.AllClients.AllowUserToAddRows = false;
            this.AllClients.AllowUserToDeleteRows = false;
            this.AllClients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AllClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AllClients.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AllClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_client,
            this.Fio_client,
            this.Phone_client});
            this.AllClients.Location = new System.Drawing.Point(7, 204);
            this.AllClients.Name = "AllClients";
            this.AllClients.RowHeadersWidth = 51;
            this.AllClients.RowTemplate.Height = 24;
            this.AllClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AllClients.Size = new System.Drawing.Size(832, 351);
            this.AllClients.TabIndex = 74;
            this.AllClients.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AllClients_CellDoubleClick);
            // 
            // Id_client
            // 
            this.Id_client.HeaderText = "ID";
            this.Id_client.MinimumWidth = 6;
            this.Id_client.Name = "Id_client";
            this.Id_client.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Fio_client
            // 
            this.Fio_client.HeaderText = "ФИО";
            this.Fio_client.MinimumWidth = 6;
            this.Fio_client.Name = "Fio_client";
            this.Fio_client.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Phone_client
            // 
            this.Phone_client.HeaderText = "Номер телефона";
            this.Phone_client.MinimumWidth = 6;
            this.Phone_client.Name = "Phone_client";
            this.Phone_client.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // FiltersClients
            // 
            this.FiltersClients.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FiltersClients.Controls.Add(this.SortDesc_Clients);
            this.FiltersClients.Controls.Add(this.ApplyFilters);
            this.FiltersClients.Controls.Add(this.ResetFilters);
            this.FiltersClients.Controls.Add(this.IDClients);
            this.FiltersClients.Controls.Add(this.IDClients_name);
            this.FiltersClients.Controls.Add(this.ClientsSorting);
            this.FiltersClients.Controls.Add(this.ClinetsSorting_name);
            this.FiltersClients.Controls.Add(this.PhoneClients);
            this.FiltersClients.Controls.Add(this.PhoneClients_name);
            this.FiltersClients.Controls.Add(this.FIOClients);
            this.FiltersClients.Controls.Add(this.FIOClients_name);
            this.FiltersClients.Controls.Add(this.QuantityOrdersClients);
            this.FiltersClients.Location = new System.Drawing.Point(7, 4);
            this.FiltersClients.Name = "FiltersClients";
            this.FiltersClients.Size = new System.Drawing.Size(832, 194);
            this.FiltersClients.TabIndex = 88;
            this.FiltersClients.TabStop = false;
            this.FiltersClients.Text = "Фильтры";
            // 
            // SortDesc_Clients
            // 
            this.SortDesc_Clients.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SortDesc_Clients.BackgroundImage")));
            this.SortDesc_Clients.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SortDesc_Clients.Location = new System.Drawing.Point(464, 108);
            this.SortDesc_Clients.Name = "SortDesc_Clients";
            this.SortDesc_Clients.Size = new System.Drawing.Size(36, 26);
            this.SortDesc_Clients.TabIndex = 206;
            this.SortDesc_Clients.UseVisualStyleBackColor = true;
            this.SortDesc_Clients.Click += new System.EventHandler(this.SortDesc_Clients_Click);
            // 
            // ApplyFilters
            // 
            this.ApplyFilters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ApplyFilters.BackColor = System.Drawing.Color.White;
            this.ApplyFilters.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.ApplyFilters.FlatAppearance.BorderSize = 2;
            this.ApplyFilters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ApplyFilters.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ApplyFilters.ForeColor = System.Drawing.Color.DarkOrange;
            this.ApplyFilters.Location = new System.Drawing.Point(715, 127);
            this.ApplyFilters.Name = "ApplyFilters";
            this.ApplyFilters.Size = new System.Drawing.Size(110, 28);
            this.ApplyFilters.TabIndex = 196;
            this.ApplyFilters.Text = "Применить";
            this.ApplyFilters.UseVisualStyleBackColor = false;
            this.ApplyFilters.Click += new System.EventHandler(this.ApplyFilters_Click);
            this.ApplyFilters.MouseEnter += new System.EventHandler(this.ApplyFilters_MouseEnter);
            this.ApplyFilters.MouseLeave += new System.EventHandler(this.ApplyFilters_MouseLeave);
            // 
            // ResetFilters
            // 
            this.ResetFilters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ResetFilters.BackColor = System.Drawing.Color.White;
            this.ResetFilters.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.ResetFilters.FlatAppearance.BorderSize = 2;
            this.ResetFilters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetFilters.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResetFilters.ForeColor = System.Drawing.Color.DarkOrange;
            this.ResetFilters.Location = new System.Drawing.Point(715, 160);
            this.ResetFilters.Name = "ResetFilters";
            this.ResetFilters.Size = new System.Drawing.Size(110, 28);
            this.ResetFilters.TabIndex = 195;
            this.ResetFilters.Text = "Сбросить";
            this.ResetFilters.UseVisualStyleBackColor = false;
            this.ResetFilters.Click += new System.EventHandler(this.ResetFilters_Click);
            this.ResetFilters.MouseEnter += new System.EventHandler(this.ResetFilters_MouseEnter);
            this.ResetFilters.MouseLeave += new System.EventHandler(this.ResetFilters_MouseLeave);
            // 
            // IDClients
            // 
            this.IDClients.Location = new System.Drawing.Point(187, 26);
            this.IDClients.Name = "IDClients";
            this.IDClients.Size = new System.Drawing.Size(263, 22);
            this.IDClients.TabIndex = 107;
            this.IDClients.TextChanged += new System.EventHandler(this.IDClients_TextChanged);
            // 
            // IDClients_name
            // 
            this.IDClients_name.AutoSize = true;
            this.IDClients_name.Location = new System.Drawing.Point(14, 29);
            this.IDClients_name.Name = "IDClients_name";
            this.IDClients_name.Size = new System.Drawing.Size(21, 17);
            this.IDClients_name.TabIndex = 106;
            this.IDClients_name.Text = "ID";
            // 
            // ClientsSorting
            // 
            this.ClientsSorting.FormattingEnabled = true;
            this.ClientsSorting.Location = new System.Drawing.Point(187, 110);
            this.ClientsSorting.Name = "ClientsSorting";
            this.ClientsSorting.Size = new System.Drawing.Size(263, 24);
            this.ClientsSorting.TabIndex = 105;
            this.ClientsSorting.SelectedIndexChanged += new System.EventHandler(this.ClientsSorting_SelectedIndexChanged);
            // 
            // ClinetsSorting_name
            // 
            this.ClinetsSorting_name.AutoSize = true;
            this.ClinetsSorting_name.Location = new System.Drawing.Point(14, 113);
            this.ClinetsSorting_name.Name = "ClinetsSorting_name";
            this.ClinetsSorting_name.Size = new System.Drawing.Size(93, 17);
            this.ClinetsSorting_name.TabIndex = 104;
            this.ClinetsSorting_name.Text = "Сортировать";
            // 
            // PhoneClients
            // 
            this.PhoneClients.Location = new System.Drawing.Point(187, 82);
            this.PhoneClients.Name = "PhoneClients";
            this.PhoneClients.Size = new System.Drawing.Size(263, 22);
            this.PhoneClients.TabIndex = 100;
            // 
            // PhoneClients_name
            // 
            this.PhoneClients_name.AutoSize = true;
            this.PhoneClients_name.Location = new System.Drawing.Point(14, 85);
            this.PhoneClients_name.Name = "PhoneClients_name";
            this.PhoneClients_name.Size = new System.Drawing.Size(121, 17);
            this.PhoneClients_name.TabIndex = 99;
            this.PhoneClients_name.Text = "Номер телефона";
            // 
            // FIOClients
            // 
            this.FIOClients.Location = new System.Drawing.Point(187, 54);
            this.FIOClients.Name = "FIOClients";
            this.FIOClients.Size = new System.Drawing.Size(263, 22);
            this.FIOClients.TabIndex = 98;
            this.FIOClients.TextChanged += new System.EventHandler(this.FIOClients_TextChanged);
            // 
            // FIOClients_name
            // 
            this.FIOClients_name.AutoSize = true;
            this.FIOClients_name.Location = new System.Drawing.Point(14, 57);
            this.FIOClients_name.Name = "FIOClients_name";
            this.FIOClients_name.Size = new System.Drawing.Size(42, 17);
            this.FIOClients_name.TabIndex = 97;
            this.FIOClients_name.Text = "ФИО";
            // 
            // QuantityOrdersClients
            // 
            this.QuantityOrdersClients.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.QuantityOrdersClients.Controls.Add(this.To_name);
            this.QuantityOrdersClients.Controls.Add(this.ToClients);
            this.QuantityOrdersClients.Controls.Add(this.From_name);
            this.QuantityOrdersClients.Controls.Add(this.From);
            this.QuantityOrdersClients.Location = new System.Drawing.Point(516, 21);
            this.QuantityOrdersClients.Name = "QuantityOrdersClients";
            this.QuantityOrdersClients.Size = new System.Drawing.Size(200, 100);
            this.QuantityOrdersClients.TabIndex = 102;
            this.QuantityOrdersClients.TabStop = false;
            this.QuantityOrdersClients.Text = "Количество заказов";
            // 
            // To_name
            // 
            this.To_name.AutoSize = true;
            this.To_name.Location = new System.Drawing.Point(17, 70);
            this.To_name.Name = "To_name";
            this.To_name.Size = new System.Drawing.Size(27, 17);
            this.To_name.TabIndex = 56;
            this.To_name.Text = "До";
            // 
            // ToClients
            // 
            this.ToClients.Location = new System.Drawing.Point(67, 67);
            this.ToClients.Name = "ToClients";
            this.ToClients.Size = new System.Drawing.Size(100, 22);
            this.ToClients.TabIndex = 57;
            this.ToClients.TextChanged += new System.EventHandler(this.ToClients_TextChanged);
            // 
            // From_name
            // 
            this.From_name.AutoSize = true;
            this.From_name.Location = new System.Drawing.Point(19, 26);
            this.From_name.Name = "From_name";
            this.From_name.Size = new System.Drawing.Size(26, 17);
            this.From_name.TabIndex = 54;
            this.From_name.Text = "От";
            // 
            // From
            // 
            this.From.Location = new System.Drawing.Point(67, 26);
            this.From.Name = "From";
            this.From.Size = new System.Drawing.Size(100, 22);
            this.From.TabIndex = 55;
            this.From.TextChanged += new System.EventHandler(this.From_TextChanged);
            // 
            // find_page
            // 
            this.find_page.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.find_page.Location = new System.Drawing.Point(373, 578);
            this.find_page.Margin = new System.Windows.Forms.Padding(4);
            this.find_page.Name = "find_page";
            this.find_page.Size = new System.Drawing.Size(65, 22);
            this.find_page.TabIndex = 191;
            // 
            // page_number
            // 
            this.page_number.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.page_number.AutoSize = true;
            this.page_number.Location = new System.Drawing.Point(447, 583);
            this.page_number.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.page_number.Name = "page_number";
            this.page_number.Size = new System.Drawing.Size(46, 17);
            this.page_number.TabIndex = 190;
            this.page_number.Text = "label1";
            // 
            // next
            // 
            this.next.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.next.Location = new System.Drawing.Point(280, 578);
            this.next.Margin = new System.Windows.Forms.Padding(4);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(34, 25);
            this.next.TabIndex = 189;
            this.next.Text = "<";
            this.next.UseVisualStyleBackColor = true;
            // 
            // ChooseClinets
            // 
            this.ChooseClinets.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ChooseClinets.BackColor = System.Drawing.Color.DarkOrange;
            this.ChooseClinets.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.ChooseClinets.FlatAppearance.BorderSize = 3;
            this.ChooseClinets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChooseClinets.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChooseClinets.ForeColor = System.Drawing.Color.White;
            this.ChooseClinets.Location = new System.Drawing.Point(7, 569);
            this.ChooseClinets.Name = "ChooseClinets";
            this.ChooseClinets.Size = new System.Drawing.Size(135, 39);
            this.ChooseClinets.TabIndex = 193;
            this.ChooseClinets.Text = "Выбрать";
            this.ChooseClinets.UseVisualStyleBackColor = false;
            this.ChooseClinets.Click += new System.EventHandler(this.ChooseClinets_Click);
            this.ChooseClinets.MouseEnter += new System.EventHandler(this.ChooseClinets_MouseEnter);
            this.ChooseClinets.MouseLeave += new System.EventHandler(this.ChooseClinets_MouseLeave);
            // 
            // prev
            // 
            this.prev.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.prev.Location = new System.Drawing.Point(499, 577);
            this.prev.Margin = new System.Windows.Forms.Padding(4);
            this.prev.Name = "prev";
            this.prev.Size = new System.Drawing.Size(39, 25);
            this.prev.TabIndex = 188;
            this.prev.Text = ">";
            this.prev.UseVisualStyleBackColor = true;
            // 
            // FindClients
            // 
            this.FindClients.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.FindClients.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FindClients.BackgroundImage")));
            this.FindClients.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FindClients.Location = new System.Drawing.Point(322, 578);
            this.FindClients.Margin = new System.Windows.Forms.Padding(4);
            this.FindClients.Name = "FindClients";
            this.FindClients.Size = new System.Drawing.Size(43, 25);
            this.FindClients.TabIndex = 231;
            this.FindClients.UseVisualStyleBackColor = true;
            // 
            // ErrorId
            // 
            this.ErrorId.ContainerControl = this;
            // 
            // ErrorFio
            // 
            this.ErrorFio.ContainerControl = this;
            // 
            // ErrorFrom
            // 
            this.ErrorFrom.ContainerControl = this;
            // 
            // ErrorTo
            // 
            this.ErrorTo.ContainerControl = this;
            // 
            // AddClinets
            // 
            this.AddClinets.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddClinets.BackColor = System.Drawing.Color.DarkOrange;
            this.AddClinets.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.AddClinets.FlatAppearance.BorderSize = 3;
            this.AddClinets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddClinets.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddClinets.ForeColor = System.Drawing.Color.White;
            this.AddClinets.Location = new System.Drawing.Point(704, 569);
            this.AddClinets.Name = "AddClinets";
            this.AddClinets.Size = new System.Drawing.Size(135, 40);
            this.AddClinets.TabIndex = 192;
            this.AddClinets.Text = "Добавить";
            this.AddClinets.UseVisualStyleBackColor = false;
            this.AddClinets.Click += new System.EventHandler(this.AddClinets_Click);
            this.AddClinets.MouseEnter += new System.EventHandler(this.AddClinets_MouseEnter);
            this.AddClinets.MouseLeave += new System.EventHandler(this.AddClinets_MouseLeave);
            // 
            // Clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(851, 617);
            this.Controls.Add(this.FindClients);
            this.Controls.Add(this.find_page);
            this.Controls.Add(this.page_number);
            this.Controls.Add(this.next);
            this.Controls.Add(this.ChooseClinets);
            this.Controls.Add(this.AddClinets);
            this.Controls.Add(this.prev);
            this.Controls.Add(this.FiltersClients);
            this.Controls.Add(this.AllClients);
            this.Name = "Clients";
            this.Text = "Клиенты(Clients)";
            this.Load += new System.EventHandler(this.Clients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AllClients)).EndInit();
            this.FiltersClients.ResumeLayout(false);
            this.FiltersClients.PerformLayout();
            this.QuantityOrdersClients.ResumeLayout(false);
            this.QuantityOrdersClients.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorFio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorTo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView AllClients;
        private System.Windows.Forms.GroupBox FiltersClients;
        private System.Windows.Forms.TextBox PhoneClients;
        private System.Windows.Forms.Label PhoneClients_name;
        private System.Windows.Forms.TextBox FIOClients;
        private System.Windows.Forms.Label FIOClients_name;
        private System.Windows.Forms.GroupBox QuantityOrdersClients;
        private System.Windows.Forms.Label To_name;
        private System.Windows.Forms.TextBox ToClients;
        private System.Windows.Forms.Label From_name;
        private System.Windows.Forms.TextBox From;
        private System.Windows.Forms.ComboBox ClientsSorting;
        private System.Windows.Forms.Label ClinetsSorting_name;
        private System.Windows.Forms.TextBox IDClients;
        private System.Windows.Forms.Label IDClients_name;
        private System.Windows.Forms.TextBox find_page;
        private System.Windows.Forms.Label page_number;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Button prev;
        private System.Windows.Forms.Button ApplyFilters;
        private System.Windows.Forms.Button ResetFilters;
        private System.Windows.Forms.Button FindClients;
        private System.Windows.Forms.Button SortDesc_Clients;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_client;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fio_client;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone_client;
        private System.Windows.Forms.ErrorProvider ErrorId;
        private System.Windows.Forms.ErrorProvider ErrorFio;
        private System.Windows.Forms.ErrorProvider ErrorFrom;
        private System.Windows.Forms.ErrorProvider ErrorTo;
        private System.Windows.Forms.Button ChooseClinets;
        private System.Windows.Forms.Button AddClinets;
    }
}