
namespace form
{
    partial class Employees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employees));
            this.EmployeeFilters = new System.Windows.Forms.GroupBox();
            this.SortDesc = new System.Windows.Forms.Button();
            this.ApplyEmployees = new System.Windows.Forms.Button();
            this.ResetEmployees = new System.Windows.Forms.Button();
            this.BranchEmployeesChoose = new System.Windows.Forms.Button();
            this.BranchEmployees = new System.Windows.Forms.LinkLabel();
            this.BranchEmployees_name = new System.Windows.Forms.Label();
            this.IDEmployees_name = new System.Windows.Forms.Label();
            this.SalaryEmployeesTo = new System.Windows.Forms.TextBox();
            this.IDEmployees = new System.Windows.Forms.TextBox();
            this.SalaryEmployeesTo_name = new System.Windows.Forms.Label();
            this.SalaryEmployeesFrom = new System.Windows.Forms.TextBox();
            this.SalaryEmployeesFrom_name = new System.Windows.Forms.Label();
            this.FIOemployees_name = new System.Windows.Forms.Label();
            this.PhoneEmployees_name = new System.Windows.Forms.Label();
            this.SortingEmployees_name = new System.Windows.Forms.Label();
            this.FIOemployees = new System.Windows.Forms.TextBox();
            this.SortingEmployees = new System.Windows.Forms.ComboBox();
            this.PhoneEmployees = new System.Windows.Forms.TextBox();
            this.AllEmployees = new System.Windows.Forms.DataGridView();
            this.Id_employee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fio_employee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone_employee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role_employee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Branch_employee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PageEmployees = new System.Windows.Forms.TextBox();
            this.PagesEmployees = new System.Windows.Forms.Label();
            this.BackEmployees = new System.Windows.Forms.Button();
            this.ChooseEmployees = new System.Windows.Forms.Button();
            this.AddEmployees = new System.Windows.Forms.Button();
            this.ToEmployees = new System.Windows.Forms.Button();
            this.FindEmployees = new System.Windows.Forms.Button();
            this.EmployeeFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AllEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // EmployeeFilters
            // 
            this.EmployeeFilters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmployeeFilters.Controls.Add(this.SortDesc);
            this.EmployeeFilters.Controls.Add(this.ApplyEmployees);
            this.EmployeeFilters.Controls.Add(this.ResetEmployees);
            this.EmployeeFilters.Controls.Add(this.BranchEmployeesChoose);
            this.EmployeeFilters.Controls.Add(this.BranchEmployees);
            this.EmployeeFilters.Controls.Add(this.BranchEmployees_name);
            this.EmployeeFilters.Controls.Add(this.IDEmployees_name);
            this.EmployeeFilters.Controls.Add(this.SalaryEmployeesTo);
            this.EmployeeFilters.Controls.Add(this.IDEmployees);
            this.EmployeeFilters.Controls.Add(this.SalaryEmployeesTo_name);
            this.EmployeeFilters.Controls.Add(this.SalaryEmployeesFrom);
            this.EmployeeFilters.Controls.Add(this.SalaryEmployeesFrom_name);
            this.EmployeeFilters.Controls.Add(this.FIOemployees_name);
            this.EmployeeFilters.Controls.Add(this.PhoneEmployees_name);
            this.EmployeeFilters.Controls.Add(this.SortingEmployees_name);
            this.EmployeeFilters.Controls.Add(this.FIOemployees);
            this.EmployeeFilters.Controls.Add(this.SortingEmployees);
            this.EmployeeFilters.Controls.Add(this.PhoneEmployees);
            this.EmployeeFilters.Location = new System.Drawing.Point(12, 12);
            this.EmployeeFilters.Name = "EmployeeFilters";
            this.EmployeeFilters.Size = new System.Drawing.Size(1078, 208);
            this.EmployeeFilters.TabIndex = 0;
            this.EmployeeFilters.TabStop = false;
            this.EmployeeFilters.Text = "Фильтры";
            this.EmployeeFilters.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // SortDesc
            // 
            this.SortDesc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SortDesc.BackgroundImage")));
            this.SortDesc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SortDesc.Location = new System.Drawing.Point(469, 114);
            this.SortDesc.Name = "SortDesc";
            this.SortDesc.Size = new System.Drawing.Size(36, 26);
            this.SortDesc.TabIndex = 205;
            this.SortDesc.UseVisualStyleBackColor = true;
            this.SortDesc.Click += new System.EventHandler(this.SortDesc_Click_1);
            // 
            // ApplyEmployees
            // 
            this.ApplyEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ApplyEmployees.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.ApplyEmployees.FlatAppearance.BorderSize = 2;
            this.ApplyEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ApplyEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ApplyEmployees.ForeColor = System.Drawing.Color.DarkOrange;
            this.ApplyEmployees.Location = new System.Drawing.Point(962, 138);
            this.ApplyEmployees.Name = "ApplyEmployees";
            this.ApplyEmployees.Size = new System.Drawing.Size(110, 28);
            this.ApplyEmployees.TabIndex = 204;
            this.ApplyEmployees.Text = "Применить";
            this.ApplyEmployees.UseVisualStyleBackColor = true;
            this.ApplyEmployees.Click += new System.EventHandler(this.ApplyEmployees_Click);
            this.ApplyEmployees.MouseEnter += new System.EventHandler(this.ApplyEmployees_MouseEnter);
            this.ApplyEmployees.MouseLeave += new System.EventHandler(this.ApplyEmployees_MouseLeave);
            // 
            // ResetEmployees
            // 
            this.ResetEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ResetEmployees.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.ResetEmployees.FlatAppearance.BorderSize = 2;
            this.ResetEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResetEmployees.ForeColor = System.Drawing.Color.DarkOrange;
            this.ResetEmployees.Location = new System.Drawing.Point(962, 174);
            this.ResetEmployees.Name = "ResetEmployees";
            this.ResetEmployees.Size = new System.Drawing.Size(110, 28);
            this.ResetEmployees.TabIndex = 203;
            this.ResetEmployees.Text = "Сбросить";
            this.ResetEmployees.UseVisualStyleBackColor = true;
            this.ResetEmployees.Click += new System.EventHandler(this.ResetEmployees_Click);
            this.ResetEmployees.MouseEnter += new System.EventHandler(this.ResetEmployees_MouseEnter);
            this.ResetEmployees.MouseLeave += new System.EventHandler(this.ResetEmployees_MouseLeave);
            // 
            // BranchEmployeesChoose
            // 
            this.BranchEmployeesChoose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BranchEmployeesChoose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BranchEmployeesChoose.BackgroundImage")));
            this.BranchEmployeesChoose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BranchEmployeesChoose.Location = new System.Drawing.Point(861, 22);
            this.BranchEmployeesChoose.Name = "BranchEmployeesChoose";
            this.BranchEmployeesChoose.Size = new System.Drawing.Size(35, 25);
            this.BranchEmployeesChoose.TabIndex = 187;
            this.BranchEmployeesChoose.UseVisualStyleBackColor = false;
            this.BranchEmployeesChoose.Click += new System.EventHandler(this.BranchEmployeesChoose_Click);
            // 
            // BranchEmployees
            // 
            this.BranchEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BranchEmployees.AutoSize = true;
            this.BranchEmployees.Location = new System.Drawing.Point(724, 22);
            this.BranchEmployees.Name = "BranchEmployees";
            this.BranchEmployees.Size = new System.Drawing.Size(85, 17);
            this.BranchEmployees.TabIndex = 186;
            this.BranchEmployees.TabStop = true;
            this.BranchEmployees.Text = "не выбрано";
            // 
            // BranchEmployees_name
            // 
            this.BranchEmployees_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BranchEmployees_name.AutoSize = true;
            this.BranchEmployees_name.Location = new System.Drawing.Point(631, 22);
            this.BranchEmployees_name.Name = "BranchEmployees_name";
            this.BranchEmployees_name.Size = new System.Drawing.Size(61, 17);
            this.BranchEmployees_name.TabIndex = 185;
            this.BranchEmployees_name.Text = "Филиал";
            // 
            // IDEmployees_name
            // 
            this.IDEmployees_name.AutoSize = true;
            this.IDEmployees_name.Location = new System.Drawing.Point(6, 35);
            this.IDEmployees_name.Name = "IDEmployees_name";
            this.IDEmployees_name.Size = new System.Drawing.Size(21, 17);
            this.IDEmployees_name.TabIndex = 194;
            this.IDEmployees_name.Text = "ID";
            // 
            // SalaryEmployeesTo
            // 
            this.SalaryEmployeesTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SalaryEmployeesTo.Location = new System.Drawing.Point(727, 91);
            this.SalaryEmployeesTo.Name = "SalaryEmployeesTo";
            this.SalaryEmployeesTo.Size = new System.Drawing.Size(169, 22);
            this.SalaryEmployeesTo.TabIndex = 201;
            // 
            // IDEmployees
            // 
            this.IDEmployees.Location = new System.Drawing.Point(200, 30);
            this.IDEmployees.Name = "IDEmployees";
            this.IDEmployees.Size = new System.Drawing.Size(263, 22);
            this.IDEmployees.TabIndex = 195;
            // 
            // SalaryEmployeesTo_name
            // 
            this.SalaryEmployeesTo_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SalaryEmployeesTo_name.AutoSize = true;
            this.SalaryEmployeesTo_name.Location = new System.Drawing.Point(631, 94);
            this.SalaryEmployeesTo_name.Name = "SalaryEmployeesTo_name";
            this.SalaryEmployeesTo_name.Size = new System.Drawing.Size(49, 17);
            this.SalaryEmployeesTo_name.TabIndex = 199;
            this.SalaryEmployeesTo_name.Text = "З/п до";
            // 
            // SalaryEmployeesFrom
            // 
            this.SalaryEmployeesFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SalaryEmployeesFrom.Location = new System.Drawing.Point(727, 63);
            this.SalaryEmployeesFrom.Name = "SalaryEmployeesFrom";
            this.SalaryEmployeesFrom.Size = new System.Drawing.Size(169, 22);
            this.SalaryEmployeesFrom.TabIndex = 200;
            // 
            // SalaryEmployeesFrom_name
            // 
            this.SalaryEmployeesFrom_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SalaryEmployeesFrom_name.AutoSize = true;
            this.SalaryEmployeesFrom_name.Location = new System.Drawing.Point(631, 66);
            this.SalaryEmployeesFrom_name.Name = "SalaryEmployeesFrom_name";
            this.SalaryEmployeesFrom_name.Size = new System.Drawing.Size(48, 17);
            this.SalaryEmployeesFrom_name.TabIndex = 196;
            this.SalaryEmployeesFrom_name.Text = "З/п от";
            // 
            // FIOemployees_name
            // 
            this.FIOemployees_name.AutoSize = true;
            this.FIOemployees_name.Location = new System.Drawing.Point(6, 63);
            this.FIOemployees_name.Name = "FIOemployees_name";
            this.FIOemployees_name.Size = new System.Drawing.Size(42, 17);
            this.FIOemployees_name.TabIndex = 188;
            this.FIOemployees_name.Text = "ФИО";
            // 
            // PhoneEmployees_name
            // 
            this.PhoneEmployees_name.AutoSize = true;
            this.PhoneEmployees_name.Location = new System.Drawing.Point(6, 91);
            this.PhoneEmployees_name.Name = "PhoneEmployees_name";
            this.PhoneEmployees_name.Size = new System.Drawing.Size(121, 17);
            this.PhoneEmployees_name.TabIndex = 190;
            this.PhoneEmployees_name.Text = "Номер телефона";
            // 
            // SortingEmployees_name
            // 
            this.SortingEmployees_name.AutoSize = true;
            this.SortingEmployees_name.Location = new System.Drawing.Point(6, 119);
            this.SortingEmployees_name.Name = "SortingEmployees_name";
            this.SortingEmployees_name.Size = new System.Drawing.Size(113, 17);
            this.SortingEmployees_name.TabIndex = 192;
            this.SortingEmployees_name.Text = "Сортировать по";
            // 
            // FIOemployees
            // 
            this.FIOemployees.Location = new System.Drawing.Point(200, 58);
            this.FIOemployees.Name = "FIOemployees";
            this.FIOemployees.Size = new System.Drawing.Size(263, 22);
            this.FIOemployees.TabIndex = 189;
            // 
            // SortingEmployees
            // 
            this.SortingEmployees.FormattingEnabled = true;
            this.SortingEmployees.Location = new System.Drawing.Point(200, 114);
            this.SortingEmployees.Name = "SortingEmployees";
            this.SortingEmployees.Size = new System.Drawing.Size(263, 24);
            this.SortingEmployees.TabIndex = 193;
            this.SortingEmployees.SelectedIndexChanged += new System.EventHandler(this.SortingEmployees_SelectedIndexChanged);
            // 
            // PhoneEmployees
            // 
            this.PhoneEmployees.Location = new System.Drawing.Point(200, 86);
            this.PhoneEmployees.Name = "PhoneEmployees";
            this.PhoneEmployees.Size = new System.Drawing.Size(263, 22);
            this.PhoneEmployees.TabIndex = 191;
            // 
            // AllEmployees
            // 
            this.AllEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AllEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AllEmployees.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AllEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_employee,
            this.Fio_employee,
            this.Phone_employee,
            this.Role_employee,
            this.Branch_employee});
            this.AllEmployees.Location = new System.Drawing.Point(12, 239);
            this.AllEmployees.Name = "AllEmployees";
            this.AllEmployees.RowHeadersWidth = 51;
            this.AllEmployees.RowTemplate.Height = 24;
            this.AllEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AllEmployees.Size = new System.Drawing.Size(1083, 424);
            this.AllEmployees.TabIndex = 77;
            this.AllEmployees.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AllEmployees_CellDoubleClick);
            // 
            // Id_employee
            // 
            this.Id_employee.HeaderText = "Id";
            this.Id_employee.MinimumWidth = 6;
            this.Id_employee.Name = "Id_employee";
            this.Id_employee.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Fio_employee
            // 
            this.Fio_employee.HeaderText = "ФИО";
            this.Fio_employee.MinimumWidth = 6;
            this.Fio_employee.Name = "Fio_employee";
            this.Fio_employee.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Phone_employee
            // 
            this.Phone_employee.HeaderText = "Телефон";
            this.Phone_employee.MinimumWidth = 6;
            this.Phone_employee.Name = "Phone_employee";
            this.Phone_employee.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Role_employee
            // 
            this.Role_employee.HeaderText = "Должность";
            this.Role_employee.MinimumWidth = 6;
            this.Role_employee.Name = "Role_employee";
            this.Role_employee.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Branch_employee
            // 
            this.Branch_employee.HeaderText = "Филиал";
            this.Branch_employee.MinimumWidth = 6;
            this.Branch_employee.Name = "Branch_employee";
            this.Branch_employee.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // PageEmployees
            // 
            this.PageEmployees.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.PageEmployees.Location = new System.Drawing.Point(512, 682);
            this.PageEmployees.Margin = new System.Windows.Forms.Padding(4);
            this.PageEmployees.Name = "PageEmployees";
            this.PageEmployees.Size = new System.Drawing.Size(65, 22);
            this.PageEmployees.TabIndex = 221;
            // 
            // PagesEmployees
            // 
            this.PagesEmployees.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.PagesEmployees.AutoSize = true;
            this.PagesEmployees.Location = new System.Drawing.Point(585, 685);
            this.PagesEmployees.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PagesEmployees.Name = "PagesEmployees";
            this.PagesEmployees.Size = new System.Drawing.Size(46, 17);
            this.PagesEmployees.TabIndex = 220;
            this.PagesEmployees.Text = "label1";
            // 
            // BackEmployees
            // 
            this.BackEmployees.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BackEmployees.Location = new System.Drawing.Point(329, 681);
            this.BackEmployees.Margin = new System.Windows.Forms.Padding(4);
            this.BackEmployees.Name = "BackEmployees";
            this.BackEmployees.Size = new System.Drawing.Size(71, 25);
            this.BackEmployees.TabIndex = 219;
            this.BackEmployees.Text = "<";
            this.BackEmployees.UseVisualStyleBackColor = true;
            // 
            // ChooseEmployees
            // 
            this.ChooseEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ChooseEmployees.BackColor = System.Drawing.Color.DarkOrange;
            this.ChooseEmployees.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.ChooseEmployees.FlatAppearance.BorderSize = 3;
            this.ChooseEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChooseEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChooseEmployees.ForeColor = System.Drawing.Color.White;
            this.ChooseEmployees.Location = new System.Drawing.Point(12, 682);
            this.ChooseEmployees.Name = "ChooseEmployees";
            this.ChooseEmployees.Size = new System.Drawing.Size(135, 39);
            this.ChooseEmployees.TabIndex = 223;
            this.ChooseEmployees.Text = "Выбрать";
            this.ChooseEmployees.UseVisualStyleBackColor = false;
            this.ChooseEmployees.Click += new System.EventHandler(this.ChooseEmployees_Click);
            this.ChooseEmployees.MouseEnter += new System.EventHandler(this.ChooseEmployees_MouseEnter);
            this.ChooseEmployees.MouseLeave += new System.EventHandler(this.ChooseEmployees_MouseLeave);
            // 
            // AddEmployees
            // 
            this.AddEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddEmployees.BackColor = System.Drawing.Color.DarkOrange;
            this.AddEmployees.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.AddEmployees.FlatAppearance.BorderSize = 3;
            this.AddEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddEmployees.ForeColor = System.Drawing.Color.White;
            this.AddEmployees.Location = new System.Drawing.Point(960, 681);
            this.AddEmployees.Name = "AddEmployees";
            this.AddEmployees.Size = new System.Drawing.Size(135, 39);
            this.AddEmployees.TabIndex = 222;
            this.AddEmployees.Text = "Добавить";
            this.AddEmployees.UseVisualStyleBackColor = false;
            this.AddEmployees.Click += new System.EventHandler(this.AddEmployees_Click);
            this.AddEmployees.MouseEnter += new System.EventHandler(this.AddEmployees_MouseEnter);
            this.AddEmployees.MouseLeave += new System.EventHandler(this.AddEmployees_MouseLeave);
            // 
            // ToEmployees
            // 
            this.ToEmployees.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ToEmployees.Location = new System.Drawing.Point(654, 681);
            this.ToEmployees.Margin = new System.Windows.Forms.Padding(4);
            this.ToEmployees.Name = "ToEmployees";
            this.ToEmployees.Size = new System.Drawing.Size(71, 25);
            this.ToEmployees.TabIndex = 218;
            this.ToEmployees.Text = ">";
            this.ToEmployees.UseVisualStyleBackColor = true;
            // 
            // FindEmployees
            // 
            this.FindEmployees.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.FindEmployees.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FindEmployees.BackgroundImage")));
            this.FindEmployees.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FindEmployees.Location = new System.Drawing.Point(432, 682);
            this.FindEmployees.Margin = new System.Windows.Forms.Padding(4);
            this.FindEmployees.Name = "FindEmployees";
            this.FindEmployees.Size = new System.Drawing.Size(43, 25);
            this.FindEmployees.TabIndex = 233;
            this.FindEmployees.UseVisualStyleBackColor = true;
            // 
            // Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1102, 730);
            this.Controls.Add(this.FindEmployees);
            this.Controls.Add(this.PageEmployees);
            this.Controls.Add(this.PagesEmployees);
            this.Controls.Add(this.BackEmployees);
            this.Controls.Add(this.ChooseEmployees);
            this.Controls.Add(this.AddEmployees);
            this.Controls.Add(this.ToEmployees);
            this.Controls.Add(this.AllEmployees);
            this.Controls.Add(this.EmployeeFilters);
            this.Name = "Employees";
            this.Text = "Работники(Employees)";
            this.Load += new System.EventHandler(this.Employees_Load);
            this.EmployeeFilters.ResumeLayout(false);
            this.EmployeeFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AllEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox EmployeeFilters;
        private System.Windows.Forms.DataGridView AllEmployees;
        private System.Windows.Forms.Button BranchEmployeesChoose;
        private System.Windows.Forms.LinkLabel BranchEmployees;
        private System.Windows.Forms.Label BranchEmployees_name;
        private System.Windows.Forms.Label IDEmployees_name;
        private System.Windows.Forms.TextBox SalaryEmployeesTo;
        private System.Windows.Forms.TextBox IDEmployees;
        private System.Windows.Forms.Label SalaryEmployeesTo_name;
        private System.Windows.Forms.TextBox SalaryEmployeesFrom;
        private System.Windows.Forms.Label SalaryEmployeesFrom_name;
        private System.Windows.Forms.Label FIOemployees_name;
        private System.Windows.Forms.Label PhoneEmployees_name;
        private System.Windows.Forms.Label SortingEmployees_name;
        private System.Windows.Forms.TextBox FIOemployees;
        private System.Windows.Forms.ComboBox SortingEmployees;
        private System.Windows.Forms.TextBox PhoneEmployees;
        private System.Windows.Forms.TextBox PageEmployees;
        private System.Windows.Forms.Label PagesEmployees;
        private System.Windows.Forms.Button BackEmployees;
        private System.Windows.Forms.Button ChooseEmployees;
        private System.Windows.Forms.Button AddEmployees;
        private System.Windows.Forms.Button ToEmployees;
        private System.Windows.Forms.Button ApplyEmployees;
        private System.Windows.Forms.Button ResetEmployees;
        private System.Windows.Forms.Button FindEmployees;
        private System.Windows.Forms.Button SortDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_employee;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fio_employee;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone_employee;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role_employee;
        private System.Windows.Forms.DataGridViewTextBoxColumn Branch_employee;
    }
}