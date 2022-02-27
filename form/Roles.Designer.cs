
namespace form
{
    partial class Roles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Roles));
            this.FindTimeTables = new System.Windows.Forms.Button();
            this.PageTimeTables = new System.Windows.Forms.TextBox();
            this.PagesTimeTables = new System.Windows.Forms.Label();
            this.BackTimeTables = new System.Windows.Forms.Button();
            this.ChooseTimeTables = new System.Windows.Forms.Button();
            this.AddTimeTables = new System.Windows.Forms.Button();
            this.ToTimeTables = new System.Windows.Forms.Button();
            this.AllRoles = new System.Windows.Forms.DataGridView();
            this.IdRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FiltersRoles = new System.Windows.Forms.GroupBox();
            this.RolesName = new System.Windows.Forms.TextBox();
            this.NameRoles = new System.Windows.Forms.Label();
            this.SortDescRole = new System.Windows.Forms.Button();
            this.ApplyRoles = new System.Windows.Forms.Button();
            this.ResetRoles = new System.Windows.Forms.Button();
            this.SortingRoles_name = new System.Windows.Forms.Label();
            this.SortingRoles = new System.Windows.Forms.ComboBox();
            this.IDRoles = new System.Windows.Forms.TextBox();
            this.IDRoles_name = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AllRoles)).BeginInit();
            this.FiltersRoles.SuspendLayout();
            this.SuspendLayout();
            // 
            // FindTimeTables
            // 
            this.FindTimeTables.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FindTimeTables.BackgroundImage")));
            this.FindTimeTables.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FindTimeTables.Location = new System.Drawing.Point(268, 656);
            this.FindTimeTables.Margin = new System.Windows.Forms.Padding(4);
            this.FindTimeTables.Name = "FindTimeTables";
            this.FindTimeTables.Size = new System.Drawing.Size(43, 25);
            this.FindTimeTables.TabIndex = 245;
            this.FindTimeTables.UseVisualStyleBackColor = true;
            // 
            // PageTimeTables
            // 
            this.PageTimeTables.Location = new System.Drawing.Point(341, 659);
            this.PageTimeTables.Margin = new System.Windows.Forms.Padding(4);
            this.PageTimeTables.Name = "PageTimeTables";
            this.PageTimeTables.Size = new System.Drawing.Size(65, 22);
            this.PageTimeTables.TabIndex = 242;
            // 
            // PagesTimeTables
            // 
            this.PagesTimeTables.AutoSize = true;
            this.PagesTimeTables.Location = new System.Drawing.Point(414, 662);
            this.PagesTimeTables.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PagesTimeTables.Name = "PagesTimeTables";
            this.PagesTimeTables.Size = new System.Drawing.Size(46, 17);
            this.PagesTimeTables.TabIndex = 241;
            this.PagesTimeTables.Text = "label1";
            // 
            // BackTimeTables
            // 
            this.BackTimeTables.Location = new System.Drawing.Point(180, 658);
            this.BackTimeTables.Margin = new System.Windows.Forms.Padding(4);
            this.BackTimeTables.Name = "BackTimeTables";
            this.BackTimeTables.Size = new System.Drawing.Size(71, 25);
            this.BackTimeTables.TabIndex = 240;
            this.BackTimeTables.Text = "<";
            this.BackTimeTables.UseVisualStyleBackColor = true;
            // 
            // ChooseTimeTables
            // 
            this.ChooseTimeTables.Location = new System.Drawing.Point(15, 654);
            this.ChooseTimeTables.Name = "ChooseTimeTables";
            this.ChooseTimeTables.Size = new System.Drawing.Size(95, 25);
            this.ChooseTimeTables.TabIndex = 244;
            this.ChooseTimeTables.Text = "Выбрать";
            this.ChooseTimeTables.UseVisualStyleBackColor = true;
            // 
            // AddTimeTables
            // 
            this.AddTimeTables.Location = new System.Drawing.Point(582, 656);
            this.AddTimeTables.Name = "AddTimeTables";
            this.AddTimeTables.Size = new System.Drawing.Size(94, 25);
            this.AddTimeTables.TabIndex = 243;
            this.AddTimeTables.Text = "Добавить";
            this.AddTimeTables.UseVisualStyleBackColor = true;
            // 
            // ToTimeTables
            // 
            this.ToTimeTables.Location = new System.Drawing.Point(483, 658);
            this.ToTimeTables.Margin = new System.Windows.Forms.Padding(4);
            this.ToTimeTables.Name = "ToTimeTables";
            this.ToTimeTables.Size = new System.Drawing.Size(71, 25);
            this.ToTimeTables.TabIndex = 239;
            this.ToTimeTables.Text = ">";
            this.ToTimeTables.UseVisualStyleBackColor = true;
            // 
            // AllRoles
            // 
            this.AllRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllRoles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdRole,
            this.NameRole});
            this.AllRoles.Location = new System.Drawing.Point(12, 243);
            this.AllRoles.Name = "AllRoles";
            this.AllRoles.RowHeadersWidth = 51;
            this.AllRoles.RowTemplate.Height = 24;
            this.AllRoles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AllRoles.Size = new System.Drawing.Size(774, 390);
            this.AllRoles.TabIndex = 238;
            this.AllRoles.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AllRoles_CellDoubleClick);
            // 
            // IdRole
            // 
            this.IdRole.HeaderText = "Id";
            this.IdRole.MinimumWidth = 6;
            this.IdRole.Name = "IdRole";
            this.IdRole.Width = 70;
            // 
            // NameRole
            // 
            this.NameRole.HeaderText = "Название";
            this.NameRole.MinimumWidth = 6;
            this.NameRole.Name = "NameRole";
            this.NameRole.Width = 250;
            // 
            // FiltersRoles
            // 
            this.FiltersRoles.Controls.Add(this.RolesName);
            this.FiltersRoles.Controls.Add(this.NameRoles);
            this.FiltersRoles.Controls.Add(this.SortDescRole);
            this.FiltersRoles.Controls.Add(this.ApplyRoles);
            this.FiltersRoles.Controls.Add(this.ResetRoles);
            this.FiltersRoles.Controls.Add(this.SortingRoles_name);
            this.FiltersRoles.Controls.Add(this.SortingRoles);
            this.FiltersRoles.Controls.Add(this.IDRoles);
            this.FiltersRoles.Controls.Add(this.IDRoles_name);
            this.FiltersRoles.Location = new System.Drawing.Point(12, 12);
            this.FiltersRoles.Name = "FiltersRoles";
            this.FiltersRoles.Size = new System.Drawing.Size(774, 215);
            this.FiltersRoles.TabIndex = 237;
            this.FiltersRoles.TabStop = false;
            this.FiltersRoles.Text = "Фильтры";
            // 
            // RolesName
            // 
            this.RolesName.Location = new System.Drawing.Point(105, 108);
            this.RolesName.Name = "RolesName";
            this.RolesName.Size = new System.Drawing.Size(160, 22);
            this.RolesName.TabIndex = 213;
            // 
            // NameRoles
            // 
            this.NameRoles.AutoSize = true;
            this.NameRoles.Location = new System.Drawing.Point(6, 113);
            this.NameRoles.Name = "NameRoles";
            this.NameRoles.Size = new System.Drawing.Size(72, 17);
            this.NameRoles.TabIndex = 212;
            this.NameRoles.Text = "Название";
            // 
            // SortDescRole
            // 
            this.SortDescRole.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SortDescRole.BackgroundImage")));
            this.SortDescRole.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SortDescRole.Location = new System.Drawing.Point(271, 60);
            this.SortDescRole.Name = "SortDescRole";
            this.SortDescRole.Size = new System.Drawing.Size(36, 26);
            this.SortDescRole.TabIndex = 211;
            this.SortDescRole.UseVisualStyleBackColor = true;
            this.SortDescRole.Click += new System.EventHandler(this.SortDescRole_Click);
            // 
            // ApplyRoles
            // 
            this.ApplyRoles.Location = new System.Drawing.Point(608, 24);
            this.ApplyRoles.Name = "ApplyRoles";
            this.ApplyRoles.Size = new System.Drawing.Size(144, 25);
            this.ApplyRoles.TabIndex = 210;
            this.ApplyRoles.Text = "Применить";
            this.ApplyRoles.UseVisualStyleBackColor = true;
            this.ApplyRoles.Click += new System.EventHandler(this.ApplyRoles_Click);
            // 
            // ResetRoles
            // 
            this.ResetRoles.Location = new System.Drawing.Point(608, 57);
            this.ResetRoles.Name = "ResetRoles";
            this.ResetRoles.Size = new System.Drawing.Size(144, 25);
            this.ResetRoles.TabIndex = 209;
            this.ResetRoles.Text = "Сбросить";
            this.ResetRoles.UseVisualStyleBackColor = true;
            this.ResetRoles.Click += new System.EventHandler(this.ResetRoles_Click);
            // 
            // SortingRoles_name
            // 
            this.SortingRoles_name.AutoSize = true;
            this.SortingRoles_name.Location = new System.Drawing.Point(6, 65);
            this.SortingRoles_name.Name = "SortingRoles_name";
            this.SortingRoles_name.Size = new System.Drawing.Size(93, 17);
            this.SortingRoles_name.TabIndex = 190;
            this.SortingRoles_name.Text = "Сортировать";
            // 
            // SortingRoles
            // 
            this.SortingRoles.FormattingEnabled = true;
            this.SortingRoles.Location = new System.Drawing.Point(105, 62);
            this.SortingRoles.Name = "SortingRoles";
            this.SortingRoles.Size = new System.Drawing.Size(160, 24);
            this.SortingRoles.TabIndex = 191;
            this.SortingRoles.SelectedIndexChanged += new System.EventHandler(this.SortingRoles_SelectedIndexChanged);
            // 
            // IDRoles
            // 
            this.IDRoles.Location = new System.Drawing.Point(105, 22);
            this.IDRoles.Name = "IDRoles";
            this.IDRoles.Size = new System.Drawing.Size(160, 22);
            this.IDRoles.TabIndex = 1;
            // 
            // IDRoles_name
            // 
            this.IDRoles_name.AutoSize = true;
            this.IDRoles_name.Location = new System.Drawing.Point(6, 27);
            this.IDRoles_name.Name = "IDRoles_name";
            this.IDRoles_name.Size = new System.Drawing.Size(21, 17);
            this.IDRoles_name.TabIndex = 0;
            this.IDRoles_name.Text = "ID";
            // 
            // Roles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 702);
            this.Controls.Add(this.FindTimeTables);
            this.Controls.Add(this.PageTimeTables);
            this.Controls.Add(this.PagesTimeTables);
            this.Controls.Add(this.BackTimeTables);
            this.Controls.Add(this.ChooseTimeTables);
            this.Controls.Add(this.AddTimeTables);
            this.Controls.Add(this.ToTimeTables);
            this.Controls.Add(this.AllRoles);
            this.Controls.Add(this.FiltersRoles);
            this.Name = "Roles";
            this.Text = "Roles";
            this.Load += new System.EventHandler(this.Roles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AllRoles)).EndInit();
            this.FiltersRoles.ResumeLayout(false);
            this.FiltersRoles.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FindTimeTables;
        private System.Windows.Forms.TextBox PageTimeTables;
        private System.Windows.Forms.Label PagesTimeTables;
        private System.Windows.Forms.Button BackTimeTables;
        private System.Windows.Forms.Button ChooseTimeTables;
        private System.Windows.Forms.Button AddTimeTables;
        private System.Windows.Forms.Button ToTimeTables;
        private System.Windows.Forms.DataGridView AllRoles;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameRole;
        private System.Windows.Forms.GroupBox FiltersRoles;
        private System.Windows.Forms.TextBox RolesName;
        private System.Windows.Forms.Label NameRoles;
        private System.Windows.Forms.Button SortDescRole;
        private System.Windows.Forms.Button ApplyRoles;
        private System.Windows.Forms.Button ResetRoles;
        private System.Windows.Forms.Label SortingRoles_name;
        private System.Windows.Forms.ComboBox SortingRoles;
        private System.Windows.Forms.TextBox IDRoles;
        private System.Windows.Forms.Label IDRoles_name;
    }
}