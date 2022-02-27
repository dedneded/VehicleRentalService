
namespace form
{
    partial class TimetablesBranch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimetablesBranch));
            this.AllTimeBranch = new System.Windows.Forms.DataGridView();
            this.StartDayBranch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDayBranch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RelevantFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RelevantUntil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FiltersTimeBtanch = new System.Windows.Forms.GroupBox();
            this.ApplyTimeBranch = new System.Windows.Forms.Button();
            this.ResetTimeBranch = new System.Windows.Forms.Button();
            this.SortingTimeBtanch_name = new System.Windows.Forms.Label();
            this.SortingTimeBtanch = new System.Windows.Forms.ComboBox();
            this.ToDateTimeBranch = new System.Windows.Forms.DateTimePicker();
            this.To = new System.Windows.Forms.Label();
            this.DateTimeBranch = new System.Windows.Forms.DateTimePicker();
            this.DateTimeBranch_name = new System.Windows.Forms.Label();
            this.PageTimeBranch = new System.Windows.Forms.TextBox();
            this.PagesTimeBranch = new System.Windows.Forms.Label();
            this.BackTimeBranch = new System.Windows.Forms.Button();
            this.DeleteTimeBranch = new System.Windows.Forms.Button();
            this.AddTimeBranch = new System.Windows.Forms.Button();
            this.ToTimeBranch = new System.Windows.Forms.Button();
            this.FindTimeBranch = new System.Windows.Forms.Button();
            this.SortDescTime = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AllTimeBranch)).BeginInit();
            this.FiltersTimeBtanch.SuspendLayout();
            this.SuspendLayout();
            // 
            // AllTimeBranch
            // 
            this.AllTimeBranch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllTimeBranch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StartDayBranch,
            this.EndDayBranch,
            this.RelevantFrom,
            this.RelevantUntil});
            this.AllTimeBranch.Location = new System.Drawing.Point(12, 241);
            this.AllTimeBranch.Name = "AllTimeBranch";
            this.AllTimeBranch.RowHeadersWidth = 51;
            this.AllTimeBranch.RowTemplate.Height = 24;
            this.AllTimeBranch.Size = new System.Drawing.Size(924, 364);
            this.AllTimeBranch.TabIndex = 182;
            // 
            // StartDayBranch
            // 
            this.StartDayBranch.HeaderText = "Начало работы";
            this.StartDayBranch.MinimumWidth = 6;
            this.StartDayBranch.Name = "StartDayBranch";
            this.StartDayBranch.Width = 200;
            // 
            // EndDayBranch
            // 
            this.EndDayBranch.HeaderText = "Завершение работы";
            this.EndDayBranch.MinimumWidth = 6;
            this.EndDayBranch.Name = "EndDayBranch";
            this.EndDayBranch.Width = 200;
            // 
            // RelevantFrom
            // 
            this.RelevantFrom.HeaderText = "Актуально с";
            this.RelevantFrom.MinimumWidth = 6;
            this.RelevantFrom.Name = "RelevantFrom";
            this.RelevantFrom.Width = 200;
            // 
            // RelevantUntil
            // 
            this.RelevantUntil.HeaderText = "Актуально до";
            this.RelevantUntil.MinimumWidth = 6;
            this.RelevantUntil.Name = "RelevantUntil";
            this.RelevantUntil.Width = 200;
            // 
            // FiltersTimeBtanch
            // 
            this.FiltersTimeBtanch.Controls.Add(this.SortDescTime);
            this.FiltersTimeBtanch.Controls.Add(this.ApplyTimeBranch);
            this.FiltersTimeBtanch.Controls.Add(this.ResetTimeBranch);
            this.FiltersTimeBtanch.Controls.Add(this.SortingTimeBtanch_name);
            this.FiltersTimeBtanch.Controls.Add(this.SortingTimeBtanch);
            this.FiltersTimeBtanch.Controls.Add(this.ToDateTimeBranch);
            this.FiltersTimeBtanch.Controls.Add(this.To);
            this.FiltersTimeBtanch.Controls.Add(this.DateTimeBranch);
            this.FiltersTimeBtanch.Controls.Add(this.DateTimeBranch_name);
            this.FiltersTimeBtanch.Location = new System.Drawing.Point(12, 11);
            this.FiltersTimeBtanch.Name = "FiltersTimeBtanch";
            this.FiltersTimeBtanch.Size = new System.Drawing.Size(1008, 215);
            this.FiltersTimeBtanch.TabIndex = 181;
            this.FiltersTimeBtanch.TabStop = false;
            this.FiltersTimeBtanch.Text = "Фильтры";
            this.FiltersTimeBtanch.Enter += new System.EventHandler(this.FiltersTimeBtanch_Enter);
            // 
            // ApplyTimeBranch
            // 
            this.ApplyTimeBranch.Location = new System.Drawing.Point(858, 14);
            this.ApplyTimeBranch.Name = "ApplyTimeBranch";
            this.ApplyTimeBranch.Size = new System.Drawing.Size(144, 25);
            this.ApplyTimeBranch.TabIndex = 223;
            this.ApplyTimeBranch.Text = "Применить";
            this.ApplyTimeBranch.UseVisualStyleBackColor = true;
            this.ApplyTimeBranch.Click += new System.EventHandler(this.ApplyTimeBranch_Click);
            // 
            // ResetTimeBranch
            // 
            this.ResetTimeBranch.Location = new System.Drawing.Point(858, 47);
            this.ResetTimeBranch.Name = "ResetTimeBranch";
            this.ResetTimeBranch.Size = new System.Drawing.Size(144, 25);
            this.ResetTimeBranch.TabIndex = 222;
            this.ResetTimeBranch.Text = "Сбросить";
            this.ResetTimeBranch.UseVisualStyleBackColor = true;
            this.ResetTimeBranch.Click += new System.EventHandler(this.ResetTimeBranch_Click);
            // 
            // SortingTimeBtanch_name
            // 
            this.SortingTimeBtanch_name.AutoSize = true;
            this.SortingTimeBtanch_name.Location = new System.Drawing.Point(9, 36);
            this.SortingTimeBtanch_name.Name = "SortingTimeBtanch_name";
            this.SortingTimeBtanch_name.Size = new System.Drawing.Size(93, 17);
            this.SortingTimeBtanch_name.TabIndex = 215;
            this.SortingTimeBtanch_name.Text = "Сортировать";
            // 
            // SortingTimeBtanch
            // 
            this.SortingTimeBtanch.FormattingEnabled = true;
            this.SortingTimeBtanch.Location = new System.Drawing.Point(108, 36);
            this.SortingTimeBtanch.Name = "SortingTimeBtanch";
            this.SortingTimeBtanch.Size = new System.Drawing.Size(160, 24);
            this.SortingTimeBtanch.TabIndex = 216;
            this.SortingTimeBtanch.SelectedIndexChanged += new System.EventHandler(this.SortingTimeBtanch_SelectedIndexChanged);
            // 
            // ToDateTimeBranch
            // 
            this.ToDateTimeBranch.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ToDateTimeBranch.Location = new System.Drawing.Point(600, 34);
            this.ToDateTimeBranch.Name = "ToDateTimeBranch";
            this.ToDateTimeBranch.Size = new System.Drawing.Size(140, 22);
            this.ToDateTimeBranch.TabIndex = 211;
            this.ToDateTimeBranch.ValueChanged += new System.EventHandler(this.ToDateTimeBranch_ValueChanged);
            // 
            // To
            // 
            this.To.AutoSize = true;
            this.To.Location = new System.Drawing.Point(570, 34);
            this.To.Name = "To";
            this.To.Size = new System.Drawing.Size(24, 17);
            this.To.TabIndex = 210;
            this.To.Text = "до";
            // 
            // DateTimeBranch
            // 
            this.DateTimeBranch.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimeBranch.Location = new System.Drawing.Point(424, 34);
            this.DateTimeBranch.Name = "DateTimeBranch";
            this.DateTimeBranch.Size = new System.Drawing.Size(140, 22);
            this.DateTimeBranch.TabIndex = 209;
            this.DateTimeBranch.ValueChanged += new System.EventHandler(this.DateTimeBranch_ValueChanged);
            // 
            // DateTimeBranch_name
            // 
            this.DateTimeBranch_name.AutoSize = true;
            this.DateTimeBranch_name.Location = new System.Drawing.Point(357, 34);
            this.DateTimeBranch_name.Name = "DateTimeBranch_name";
            this.DateTimeBranch_name.Size = new System.Drawing.Size(61, 17);
            this.DateTimeBranch_name.TabIndex = 208;
            this.DateTimeBranch_name.Text = "Дата от";
            // 
            // PageTimeBranch
            // 
            this.PageTimeBranch.Location = new System.Drawing.Point(436, 633);
            this.PageTimeBranch.Margin = new System.Windows.Forms.Padding(4);
            this.PageTimeBranch.Name = "PageTimeBranch";
            this.PageTimeBranch.Size = new System.Drawing.Size(65, 22);
            this.PageTimeBranch.TabIndex = 197;
            // 
            // PagesTimeBranch
            // 
            this.PagesTimeBranch.AutoSize = true;
            this.PagesTimeBranch.Location = new System.Drawing.Point(509, 636);
            this.PagesTimeBranch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PagesTimeBranch.Name = "PagesTimeBranch";
            this.PagesTimeBranch.Size = new System.Drawing.Size(46, 17);
            this.PagesTimeBranch.TabIndex = 196;
            this.PagesTimeBranch.Text = "label1";
            // 
            // BackTimeBranch
            // 
            this.BackTimeBranch.Location = new System.Drawing.Point(280, 628);
            this.BackTimeBranch.Margin = new System.Windows.Forms.Padding(4);
            this.BackTimeBranch.Name = "BackTimeBranch";
            this.BackTimeBranch.Size = new System.Drawing.Size(71, 25);
            this.BackTimeBranch.TabIndex = 195;
            this.BackTimeBranch.Text = "<";
            this.BackTimeBranch.UseVisualStyleBackColor = true;
            // 
            // DeleteTimeBranch
            // 
            this.DeleteTimeBranch.Location = new System.Drawing.Point(870, 636);
            this.DeleteTimeBranch.Name = "DeleteTimeBranch";
            this.DeleteTimeBranch.Size = new System.Drawing.Size(95, 25);
            this.DeleteTimeBranch.TabIndex = 199;
            this.DeleteTimeBranch.Text = "Удалить";
            this.DeleteTimeBranch.UseVisualStyleBackColor = true;
            // 
            // AddTimeBranch
            // 
            this.AddTimeBranch.Location = new System.Drawing.Point(66, 636);
            this.AddTimeBranch.Name = "AddTimeBranch";
            this.AddTimeBranch.Size = new System.Drawing.Size(94, 25);
            this.AddTimeBranch.TabIndex = 198;
            this.AddTimeBranch.Text = "Добавить";
            this.AddTimeBranch.UseVisualStyleBackColor = true;
            this.AddTimeBranch.Click += new System.EventHandler(this.AddTimeBranch_Click);
            // 
            // ToTimeBranch
            // 
            this.ToTimeBranch.Location = new System.Drawing.Point(578, 632);
            this.ToTimeBranch.Margin = new System.Windows.Forms.Padding(4);
            this.ToTimeBranch.Name = "ToTimeBranch";
            this.ToTimeBranch.Size = new System.Drawing.Size(71, 25);
            this.ToTimeBranch.TabIndex = 194;
            this.ToTimeBranch.Text = ">";
            this.ToTimeBranch.UseVisualStyleBackColor = true;
            // 
            // FindTimeBranch
            // 
            this.FindTimeBranch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FindTimeBranch.BackgroundImage")));
            this.FindTimeBranch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FindTimeBranch.Location = new System.Drawing.Point(371, 632);
            this.FindTimeBranch.Margin = new System.Windows.Forms.Padding(4);
            this.FindTimeBranch.Name = "FindTimeBranch";
            this.FindTimeBranch.Size = new System.Drawing.Size(43, 25);
            this.FindTimeBranch.TabIndex = 237;
            this.FindTimeBranch.UseVisualStyleBackColor = true;
            // 
            // SortDescTime
            // 
            this.SortDescTime.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SortDescTime.BackgroundImage")));
            this.SortDescTime.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SortDescTime.Location = new System.Drawing.Point(274, 34);
            this.SortDescTime.Name = "SortDescTime";
            this.SortDescTime.Size = new System.Drawing.Size(36, 26);
            this.SortDescTime.TabIndex = 224;
            this.SortDescTime.UseVisualStyleBackColor = true;
            this.SortDescTime.Click += new System.EventHandler(this.SortDescTime_Click);
            // 
            // TimetablesBranch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 689);
            this.Controls.Add(this.FindTimeBranch);
            this.Controls.Add(this.PageTimeBranch);
            this.Controls.Add(this.PagesTimeBranch);
            this.Controls.Add(this.BackTimeBranch);
            this.Controls.Add(this.DeleteTimeBranch);
            this.Controls.Add(this.AddTimeBranch);
            this.Controls.Add(this.ToTimeBranch);
            this.Controls.Add(this.AllTimeBranch);
            this.Controls.Add(this.FiltersTimeBtanch);
            this.Name = "TimetablesBranch";
            this.Text = "Расписания филиалов(TimetablesBranch)";
            this.Load += new System.EventHandler(this.TimetablesBranch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AllTimeBranch)).EndInit();
            this.FiltersTimeBtanch.ResumeLayout(false);
            this.FiltersTimeBtanch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView AllTimeBranch;
        private System.Windows.Forms.GroupBox FiltersTimeBtanch;
        private System.Windows.Forms.Label SortingTimeBtanch_name;
        private System.Windows.Forms.ComboBox SortingTimeBtanch;
        private System.Windows.Forms.DateTimePicker ToDateTimeBranch;
        private System.Windows.Forms.Label To;
        private System.Windows.Forms.DateTimePicker DateTimeBranch;
        private System.Windows.Forms.Label DateTimeBranch_name;
        private System.Windows.Forms.TextBox PageTimeBranch;
        private System.Windows.Forms.Label PagesTimeBranch;
        private System.Windows.Forms.Button BackTimeBranch;
        private System.Windows.Forms.Button DeleteTimeBranch;
        private System.Windows.Forms.Button AddTimeBranch;
        private System.Windows.Forms.Button ToTimeBranch;
        private System.Windows.Forms.Button ApplyTimeBranch;
        private System.Windows.Forms.Button ResetTimeBranch;
        private System.Windows.Forms.Button FindTimeBranch;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDayBranch;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndDayBranch;
        private System.Windows.Forms.DataGridViewTextBoxColumn RelevantFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn RelevantUntil;
        private System.Windows.Forms.Button SortDescTime;
    }
}