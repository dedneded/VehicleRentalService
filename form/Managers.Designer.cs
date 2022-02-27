
namespace form
{
    partial class Managers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Managers));
            this.ApplyManager = new System.Windows.Forms.Button();
            this.ResetManager = new System.Windows.Forms.Button();
            this.BranchManager = new System.Windows.Forms.LinkLabel();
            this.BranchManager_name = new System.Windows.Forms.Label();
            this.IDManager_name = new System.Windows.Forms.Label();
            this.SalaryManagersTo = new System.Windows.Forms.TextBox();
            this.IDManager = new System.Windows.Forms.TextBox();
            this.SalaryEmployeesTo_name = new System.Windows.Forms.Label();
            this.PageManager = new System.Windows.Forms.TextBox();
            this.PagesManager = new System.Windows.Forms.Label();
            this.BackManager = new System.Windows.Forms.Button();
            this.ChooseManager = new System.Windows.Forms.Button();
            this.AddManager = new System.Windows.Forms.Button();
            this.SalaryManagersFrom = new System.Windows.Forms.TextBox();
            this.SalaryEmployeesFrom_name = new System.Windows.Forms.Label();
            this.FIOManager_name = new System.Windows.Forms.Label();
            this.PhoneManager_name = new System.Windows.Forms.Label();
            this.SortingManager_name = new System.Windows.Forms.Label();
            this.FindManager = new System.Windows.Forms.Button();
            this.FIOManager = new System.Windows.Forms.TextBox();
            this.AllManagers = new System.Windows.Forms.DataGridView();
            this.Id_manager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fio_manager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone_manager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Branch_manager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SortingManager = new System.Windows.Forms.ComboBox();
            this.PhoneManager = new System.Windows.Forms.TextBox();
            this.ToManager = new System.Windows.Forms.Button();
            this.ManagerFilters = new System.Windows.Forms.GroupBox();
            this.SortDesc_Managers = new System.Windows.Forms.Button();
            this.BranchManagerChoose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AllManagers)).BeginInit();
            this.ManagerFilters.SuspendLayout();
            this.SuspendLayout();
            // 
            // ApplyManager
            // 
            this.ApplyManager.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ApplyManager.BackColor = System.Drawing.Color.White;
            this.ApplyManager.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.ApplyManager.FlatAppearance.BorderSize = 2;
            this.ApplyManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ApplyManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ApplyManager.ForeColor = System.Drawing.Color.DarkOrange;
            this.ApplyManager.Location = new System.Drawing.Point(960, 138);
            this.ApplyManager.Name = "ApplyManager";
            this.ApplyManager.Size = new System.Drawing.Size(110, 28);
            this.ApplyManager.TabIndex = 204;
            this.ApplyManager.Text = "Применить";
            this.ApplyManager.UseVisualStyleBackColor = false;
            this.ApplyManager.Click += new System.EventHandler(this.ApplyManager_Click);
            this.ApplyManager.MouseEnter += new System.EventHandler(this.ApplyManager_MouseEnter);
            this.ApplyManager.MouseLeave += new System.EventHandler(this.ApplyManager_MouseLeave);
            // 
            // ResetManager
            // 
            this.ResetManager.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ResetManager.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.ResetManager.FlatAppearance.BorderSize = 2;
            this.ResetManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResetManager.ForeColor = System.Drawing.Color.DarkOrange;
            this.ResetManager.Location = new System.Drawing.Point(960, 174);
            this.ResetManager.Name = "ResetManager";
            this.ResetManager.Size = new System.Drawing.Size(110, 28);
            this.ResetManager.TabIndex = 203;
            this.ResetManager.Text = "Сбросить";
            this.ResetManager.UseVisualStyleBackColor = true;
            this.ResetManager.Click += new System.EventHandler(this.ResetManager_Click);
            this.ResetManager.MouseEnter += new System.EventHandler(this.ResetManager_MouseEnter);
            this.ResetManager.MouseLeave += new System.EventHandler(this.ResetManager_MouseLeave);
            // 
            // BranchManager
            // 
            this.BranchManager.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BranchManager.AutoSize = true;
            this.BranchManager.Location = new System.Drawing.Point(674, 23);
            this.BranchManager.Name = "BranchManager";
            this.BranchManager.Size = new System.Drawing.Size(85, 17);
            this.BranchManager.TabIndex = 186;
            this.BranchManager.TabStop = true;
            this.BranchManager.Text = "не выбрано";
            // 
            // BranchManager_name
            // 
            this.BranchManager_name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BranchManager_name.AutoSize = true;
            this.BranchManager_name.Location = new System.Drawing.Point(581, 23);
            this.BranchManager_name.Name = "BranchManager_name";
            this.BranchManager_name.Size = new System.Drawing.Size(61, 17);
            this.BranchManager_name.TabIndex = 185;
            this.BranchManager_name.Text = "Филиал";
            // 
            // IDManager_name
            // 
            this.IDManager_name.AutoSize = true;
            this.IDManager_name.Location = new System.Drawing.Point(6, 35);
            this.IDManager_name.Name = "IDManager_name";
            this.IDManager_name.Size = new System.Drawing.Size(21, 17);
            this.IDManager_name.TabIndex = 194;
            this.IDManager_name.Text = "ID";
            // 
            // SalaryManagersTo
            // 
            this.SalaryManagersTo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SalaryManagersTo.Location = new System.Drawing.Point(677, 104);
            this.SalaryManagersTo.Name = "SalaryManagersTo";
            this.SalaryManagersTo.Size = new System.Drawing.Size(169, 22);
            this.SalaryManagersTo.TabIndex = 201;
            // 
            // IDManager
            // 
            this.IDManager.Location = new System.Drawing.Point(188, 32);
            this.IDManager.Name = "IDManager";
            this.IDManager.Size = new System.Drawing.Size(263, 22);
            this.IDManager.TabIndex = 195;
            // 
            // SalaryEmployeesTo_name
            // 
            this.SalaryEmployeesTo_name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SalaryEmployeesTo_name.AutoSize = true;
            this.SalaryEmployeesTo_name.Location = new System.Drawing.Point(581, 107);
            this.SalaryEmployeesTo_name.Name = "SalaryEmployeesTo_name";
            this.SalaryEmployeesTo_name.Size = new System.Drawing.Size(49, 17);
            this.SalaryEmployeesTo_name.TabIndex = 199;
            this.SalaryEmployeesTo_name.Text = "З/п до";
            // 
            // PageManager
            // 
            this.PageManager.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.PageManager.Location = new System.Drawing.Point(512, 706);
            this.PageManager.Margin = new System.Windows.Forms.Padding(4);
            this.PageManager.Name = "PageManager";
            this.PageManager.Size = new System.Drawing.Size(65, 22);
            this.PageManager.TabIndex = 239;
            // 
            // PagesManager
            // 
            this.PagesManager.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.PagesManager.AutoSize = true;
            this.PagesManager.Location = new System.Drawing.Point(585, 709);
            this.PagesManager.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PagesManager.Name = "PagesManager";
            this.PagesManager.Size = new System.Drawing.Size(46, 17);
            this.PagesManager.TabIndex = 238;
            this.PagesManager.Text = "label1";
            // 
            // BackManager
            // 
            this.BackManager.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BackManager.Location = new System.Drawing.Point(329, 705);
            this.BackManager.Margin = new System.Windows.Forms.Padding(4);
            this.BackManager.Name = "BackManager";
            this.BackManager.Size = new System.Drawing.Size(71, 25);
            this.BackManager.TabIndex = 237;
            this.BackManager.Text = "<";
            this.BackManager.UseVisualStyleBackColor = true;
            // 
            // ChooseManager
            // 
            this.ChooseManager.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ChooseManager.BackColor = System.Drawing.Color.DarkOrange;
            this.ChooseManager.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.ChooseManager.FlatAppearance.BorderSize = 3;
            this.ChooseManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChooseManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChooseManager.ForeColor = System.Drawing.Color.White;
            this.ChooseManager.Location = new System.Drawing.Point(12, 703);
            this.ChooseManager.Name = "ChooseManager";
            this.ChooseManager.Size = new System.Drawing.Size(135, 39);
            this.ChooseManager.TabIndex = 241;
            this.ChooseManager.Text = "Выбрать";
            this.ChooseManager.UseVisualStyleBackColor = false;
            this.ChooseManager.MouseEnter += new System.EventHandler(this.ChooseManager_MouseEnter);
            this.ChooseManager.MouseLeave += new System.EventHandler(this.ChooseManager_MouseLeave);
            // 
            // AddManager
            // 
            this.AddManager.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddManager.BackColor = System.Drawing.Color.DarkOrange;
            this.AddManager.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.AddManager.FlatAppearance.BorderSize = 3;
            this.AddManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddManager.ForeColor = System.Drawing.Color.White;
            this.AddManager.Location = new System.Drawing.Point(953, 703);
            this.AddManager.Name = "AddManager";
            this.AddManager.Size = new System.Drawing.Size(135, 39);
            this.AddManager.TabIndex = 240;
            this.AddManager.Text = "Добавить";
            this.AddManager.UseVisualStyleBackColor = false;
            this.AddManager.Click += new System.EventHandler(this.AddManager_Click);
            this.AddManager.MouseEnter += new System.EventHandler(this.AddManager_MouseEnter);
            this.AddManager.MouseLeave += new System.EventHandler(this.AddManager_MouseLeave);
            // 
            // SalaryManagersFrom
            // 
            this.SalaryManagersFrom.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SalaryManagersFrom.Location = new System.Drawing.Point(677, 76);
            this.SalaryManagersFrom.Name = "SalaryManagersFrom";
            this.SalaryManagersFrom.Size = new System.Drawing.Size(169, 22);
            this.SalaryManagersFrom.TabIndex = 200;
            // 
            // SalaryEmployeesFrom_name
            // 
            this.SalaryEmployeesFrom_name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SalaryEmployeesFrom_name.AutoSize = true;
            this.SalaryEmployeesFrom_name.Location = new System.Drawing.Point(581, 79);
            this.SalaryEmployeesFrom_name.Name = "SalaryEmployeesFrom_name";
            this.SalaryEmployeesFrom_name.Size = new System.Drawing.Size(48, 17);
            this.SalaryEmployeesFrom_name.TabIndex = 196;
            this.SalaryEmployeesFrom_name.Text = "З/п от";
            // 
            // FIOManager_name
            // 
            this.FIOManager_name.AutoSize = true;
            this.FIOManager_name.Location = new System.Drawing.Point(6, 63);
            this.FIOManager_name.Name = "FIOManager_name";
            this.FIOManager_name.Size = new System.Drawing.Size(42, 17);
            this.FIOManager_name.TabIndex = 188;
            this.FIOManager_name.Text = "ФИО";
            // 
            // PhoneManager_name
            // 
            this.PhoneManager_name.AutoSize = true;
            this.PhoneManager_name.Location = new System.Drawing.Point(6, 91);
            this.PhoneManager_name.Name = "PhoneManager_name";
            this.PhoneManager_name.Size = new System.Drawing.Size(121, 17);
            this.PhoneManager_name.TabIndex = 190;
            this.PhoneManager_name.Text = "Номер телефона";
            // 
            // SortingManager_name
            // 
            this.SortingManager_name.AutoSize = true;
            this.SortingManager_name.Location = new System.Drawing.Point(6, 119);
            this.SortingManager_name.Name = "SortingManager_name";
            this.SortingManager_name.Size = new System.Drawing.Size(93, 17);
            this.SortingManager_name.TabIndex = 192;
            this.SortingManager_name.Text = "Сортировать";
            // 
            // FindManager
            // 
            this.FindManager.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.FindManager.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FindManager.BackgroundImage")));
            this.FindManager.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FindManager.Location = new System.Drawing.Point(432, 706);
            this.FindManager.Margin = new System.Windows.Forms.Padding(4);
            this.FindManager.Name = "FindManager";
            this.FindManager.Size = new System.Drawing.Size(43, 25);
            this.FindManager.TabIndex = 242;
            this.FindManager.UseVisualStyleBackColor = true;
            // 
            // FIOManager
            // 
            this.FIOManager.Location = new System.Drawing.Point(188, 60);
            this.FIOManager.Name = "FIOManager";
            this.FIOManager.Size = new System.Drawing.Size(263, 22);
            this.FIOManager.TabIndex = 189;
            // 
            // AllManagers
            // 
            this.AllManagers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AllManagers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AllManagers.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AllManagers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllManagers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_manager,
            this.Fio_manager,
            this.Phone_manager,
            this.Branch_manager});
            this.AllManagers.Location = new System.Drawing.Point(12, 239);
            this.AllManagers.Name = "AllManagers";
            this.AllManagers.RowHeadersWidth = 51;
            this.AllManagers.RowTemplate.Height = 24;
            this.AllManagers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AllManagers.Size = new System.Drawing.Size(1076, 440);
            this.AllManagers.TabIndex = 235;
            // 
            // Id_manager
            // 
            this.Id_manager.HeaderText = "Id";
            this.Id_manager.MinimumWidth = 6;
            this.Id_manager.Name = "Id_manager";
            // 
            // Fio_manager
            // 
            this.Fio_manager.HeaderText = "Fio";
            this.Fio_manager.MinimumWidth = 6;
            this.Fio_manager.Name = "Fio_manager";
            // 
            // Phone_manager
            // 
            this.Phone_manager.HeaderText = "Phone";
            this.Phone_manager.MinimumWidth = 6;
            this.Phone_manager.Name = "Phone_manager";
            // 
            // Branch_manager
            // 
            this.Branch_manager.HeaderText = "Филиал";
            this.Branch_manager.MinimumWidth = 6;
            this.Branch_manager.Name = "Branch_manager";
            // 
            // SortingManager
            // 
            this.SortingManager.FormattingEnabled = true;
            this.SortingManager.Location = new System.Drawing.Point(188, 116);
            this.SortingManager.Name = "SortingManager";
            this.SortingManager.Size = new System.Drawing.Size(263, 24);
            this.SortingManager.TabIndex = 193;
            this.SortingManager.SelectedIndexChanged += new System.EventHandler(this.SortingManager_SelectedIndexChanged);
            // 
            // PhoneManager
            // 
            this.PhoneManager.Location = new System.Drawing.Point(188, 88);
            this.PhoneManager.Name = "PhoneManager";
            this.PhoneManager.Size = new System.Drawing.Size(263, 22);
            this.PhoneManager.TabIndex = 191;
            // 
            // ToManager
            // 
            this.ToManager.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ToManager.Location = new System.Drawing.Point(654, 705);
            this.ToManager.Margin = new System.Windows.Forms.Padding(4);
            this.ToManager.Name = "ToManager";
            this.ToManager.Size = new System.Drawing.Size(71, 25);
            this.ToManager.TabIndex = 236;
            this.ToManager.Text = ">";
            this.ToManager.UseVisualStyleBackColor = true;
            // 
            // ManagerFilters
            // 
            this.ManagerFilters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ManagerFilters.Controls.Add(this.SortDesc_Managers);
            this.ManagerFilters.Controls.Add(this.BranchManagerChoose);
            this.ManagerFilters.Controls.Add(this.ApplyManager);
            this.ManagerFilters.Controls.Add(this.ResetManager);
            this.ManagerFilters.Controls.Add(this.BranchManager);
            this.ManagerFilters.Controls.Add(this.BranchManager_name);
            this.ManagerFilters.Controls.Add(this.IDManager_name);
            this.ManagerFilters.Controls.Add(this.SalaryManagersTo);
            this.ManagerFilters.Controls.Add(this.IDManager);
            this.ManagerFilters.Controls.Add(this.SalaryEmployeesTo_name);
            this.ManagerFilters.Controls.Add(this.SalaryManagersFrom);
            this.ManagerFilters.Controls.Add(this.SalaryEmployeesFrom_name);
            this.ManagerFilters.Controls.Add(this.FIOManager_name);
            this.ManagerFilters.Controls.Add(this.PhoneManager_name);
            this.ManagerFilters.Controls.Add(this.SortingManager_name);
            this.ManagerFilters.Controls.Add(this.FIOManager);
            this.ManagerFilters.Controls.Add(this.SortingManager);
            this.ManagerFilters.Controls.Add(this.PhoneManager);
            this.ManagerFilters.Location = new System.Drawing.Point(12, 12);
            this.ManagerFilters.Name = "ManagerFilters";
            this.ManagerFilters.Size = new System.Drawing.Size(1076, 208);
            this.ManagerFilters.TabIndex = 234;
            this.ManagerFilters.TabStop = false;
            this.ManagerFilters.Text = "Фильтры";
            // 
            // SortDesc_Managers
            // 
            this.SortDesc_Managers.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SortDesc_Managers.BackgroundImage")));
            this.SortDesc_Managers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SortDesc_Managers.Location = new System.Drawing.Point(457, 116);
            this.SortDesc_Managers.Name = "SortDesc_Managers";
            this.SortDesc_Managers.Size = new System.Drawing.Size(36, 26);
            this.SortDesc_Managers.TabIndex = 207;
            this.SortDesc_Managers.UseVisualStyleBackColor = true;
            this.SortDesc_Managers.Click += new System.EventHandler(this.SortDesc_Managers_Click);
            // 
            // BranchManagerChoose
            // 
            this.BranchManagerChoose.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BranchManagerChoose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BranchManagerChoose.BackgroundImage")));
            this.BranchManagerChoose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BranchManagerChoose.Location = new System.Drawing.Point(782, 19);
            this.BranchManagerChoose.Name = "BranchManagerChoose";
            this.BranchManagerChoose.Size = new System.Drawing.Size(35, 25);
            this.BranchManagerChoose.TabIndex = 205;
            this.BranchManagerChoose.UseVisualStyleBackColor = false;
            // 
            // Managers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 754);
            this.Controls.Add(this.PageManager);
            this.Controls.Add(this.PagesManager);
            this.Controls.Add(this.BackManager);
            this.Controls.Add(this.ChooseManager);
            this.Controls.Add(this.AddManager);
            this.Controls.Add(this.FindManager);
            this.Controls.Add(this.AllManagers);
            this.Controls.Add(this.ToManager);
            this.Controls.Add(this.ManagerFilters);
            this.Name = "Managers";
            this.Text = "Managers";
            this.Load += new System.EventHandler(this.Managers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AllManagers)).EndInit();
            this.ManagerFilters.ResumeLayout(false);
            this.ManagerFilters.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ApplyManager;
        private System.Windows.Forms.Button ResetManager;
        private System.Windows.Forms.LinkLabel BranchManager;
        private System.Windows.Forms.Label BranchManager_name;
        private System.Windows.Forms.Label IDManager_name;
        private System.Windows.Forms.TextBox SalaryManagersTo;
        private System.Windows.Forms.TextBox IDManager;
        private System.Windows.Forms.Label SalaryEmployeesTo_name;
        private System.Windows.Forms.TextBox PageManager;
        private System.Windows.Forms.Label PagesManager;
        private System.Windows.Forms.Button BackManager;
        private System.Windows.Forms.Button ChooseManager;
        private System.Windows.Forms.Button AddManager;
        private System.Windows.Forms.TextBox SalaryManagersFrom;
        private System.Windows.Forms.Label SalaryEmployeesFrom_name;
        private System.Windows.Forms.Label FIOManager_name;
        private System.Windows.Forms.Label PhoneManager_name;
        private System.Windows.Forms.Label SortingManager_name;
        private System.Windows.Forms.Button FindManager;
        private System.Windows.Forms.TextBox FIOManager;
        private System.Windows.Forms.DataGridView AllManagers;
        private System.Windows.Forms.ComboBox SortingManager;
        private System.Windows.Forms.TextBox PhoneManager;
        private System.Windows.Forms.Button ToManager;
        private System.Windows.Forms.GroupBox ManagerFilters;
        private System.Windows.Forms.Button BranchManagerChoose;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_manager;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fio_manager;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone_manager;
        private System.Windows.Forms.DataGridViewTextBoxColumn Branch_manager;
        private System.Windows.Forms.Button SortDesc_Managers;
    }
}