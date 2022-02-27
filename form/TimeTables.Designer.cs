
namespace form
{
    partial class TimeTables
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimeTables));
            this.FiltersTimeTables = new System.Windows.Forms.GroupBox();
            this.ApplyTimeTable = new System.Windows.Forms.Button();
            this.ResetTimeTable = new System.Windows.Forms.Button();
            this.SortingTimeTables_name = new System.Windows.Forms.Label();
            this.SortingTimeTables = new System.Windows.Forms.ComboBox();
            this.ToDayBranchTimeTables = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.BranchTimeTablesDay = new System.Windows.Forms.DateTimePicker();
            this.DateTimeTables_name = new System.Windows.Forms.Label();
            this.EndFromBranchTimeTables = new System.Windows.Forms.DateTimePicker();
            this.ToEnd = new System.Windows.Forms.Label();
            this.StartToBranchTimeTables = new System.Windows.Forms.DateTimePicker();
            this.ToStart = new System.Windows.Forms.Label();
            this.EndToBranchTimeTables = new System.Windows.Forms.DateTimePicker();
            this.StartFromBranchTimeTables = new System.Windows.Forms.DateTimePicker();
            this.EndBranchTimeTables_name = new System.Windows.Forms.Label();
            this.StartBranchTimeTables_name = new System.Windows.Forms.Label();
            this.IDTimeTables = new System.Windows.Forms.TextBox();
            this.IDTimeTables_name = new System.Windows.Forms.Label();
            this.AllTimeTables = new System.Windows.Forms.DataGridView();
            this.PageTimeTables = new System.Windows.Forms.TextBox();
            this.PagesTimeTables = new System.Windows.Forms.Label();
            this.BackTimeTables = new System.Windows.Forms.Button();
            this.ChooseTimeTables = new System.Windows.Forms.Button();
            this.AddTimeTables = new System.Windows.Forms.Button();
            this.ToTimeTables = new System.Windows.Forms.Button();
            this.FindTimeTables = new System.Windows.Forms.Button();
            this.IdTimetable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartShift = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndShift = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SortDescTime = new System.Windows.Forms.Button();
            this.FiltersTimeTables.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AllTimeTables)).BeginInit();
            this.SuspendLayout();
            // 
            // FiltersTimeTables
            // 
            this.FiltersTimeTables.Controls.Add(this.SortDescTime);
            this.FiltersTimeTables.Controls.Add(this.ApplyTimeTable);
            this.FiltersTimeTables.Controls.Add(this.ResetTimeTable);
            this.FiltersTimeTables.Controls.Add(this.SortingTimeTables_name);
            this.FiltersTimeTables.Controls.Add(this.SortingTimeTables);
            this.FiltersTimeTables.Controls.Add(this.ToDayBranchTimeTables);
            this.FiltersTimeTables.Controls.Add(this.label10);
            this.FiltersTimeTables.Controls.Add(this.BranchTimeTablesDay);
            this.FiltersTimeTables.Controls.Add(this.DateTimeTables_name);
            this.FiltersTimeTables.Controls.Add(this.EndFromBranchTimeTables);
            this.FiltersTimeTables.Controls.Add(this.ToEnd);
            this.FiltersTimeTables.Controls.Add(this.StartToBranchTimeTables);
            this.FiltersTimeTables.Controls.Add(this.ToStart);
            this.FiltersTimeTables.Controls.Add(this.EndToBranchTimeTables);
            this.FiltersTimeTables.Controls.Add(this.StartFromBranchTimeTables);
            this.FiltersTimeTables.Controls.Add(this.EndBranchTimeTables_name);
            this.FiltersTimeTables.Controls.Add(this.StartBranchTimeTables_name);
            this.FiltersTimeTables.Controls.Add(this.IDTimeTables);
            this.FiltersTimeTables.Controls.Add(this.IDTimeTables_name);
            this.FiltersTimeTables.Location = new System.Drawing.Point(12, 12);
            this.FiltersTimeTables.Name = "FiltersTimeTables";
            this.FiltersTimeTables.Size = new System.Drawing.Size(1008, 215);
            this.FiltersTimeTables.TabIndex = 0;
            this.FiltersTimeTables.TabStop = false;
            this.FiltersTimeTables.Text = "Фильтры";
            // 
            // ApplyTimeTable
            // 
            this.ApplyTimeTable.Location = new System.Drawing.Point(858, 19);
            this.ApplyTimeTable.Name = "ApplyTimeTable";
            this.ApplyTimeTable.Size = new System.Drawing.Size(144, 25);
            this.ApplyTimeTable.TabIndex = 210;
            this.ApplyTimeTable.Text = "Применить";
            this.ApplyTimeTable.UseVisualStyleBackColor = true;
            this.ApplyTimeTable.Click += new System.EventHandler(this.ApplyTimeTable_Click);
            // 
            // ResetTimeTable
            // 
            this.ResetTimeTable.Location = new System.Drawing.Point(858, 52);
            this.ResetTimeTable.Name = "ResetTimeTable";
            this.ResetTimeTable.Size = new System.Drawing.Size(144, 25);
            this.ResetTimeTable.TabIndex = 209;
            this.ResetTimeTable.Text = "Сбросить";
            this.ResetTimeTable.UseVisualStyleBackColor = true;
            this.ResetTimeTable.Click += new System.EventHandler(this.ResetTimeTable_Click);
            // 
            // SortingTimeTables_name
            // 
            this.SortingTimeTables_name.AutoSize = true;
            this.SortingTimeTables_name.Location = new System.Drawing.Point(6, 65);
            this.SortingTimeTables_name.Name = "SortingTimeTables_name";
            this.SortingTimeTables_name.Size = new System.Drawing.Size(93, 17);
            this.SortingTimeTables_name.TabIndex = 190;
            this.SortingTimeTables_name.Text = "Сортировать";
            // 
            // SortingTimeTables
            // 
            this.SortingTimeTables.FormattingEnabled = true;
            this.SortingTimeTables.Location = new System.Drawing.Point(105, 62);
            this.SortingTimeTables.Name = "SortingTimeTables";
            this.SortingTimeTables.Size = new System.Drawing.Size(160, 24);
            this.SortingTimeTables.TabIndex = 191;
            this.SortingTimeTables.SelectedIndexChanged += new System.EventHandler(this.SortingTimeTables_SelectedIndexChanged);
            // 
            // ToDayBranchTimeTables
            // 
            this.ToDayBranchTimeTables.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ToDayBranchTimeTables.Location = new System.Drawing.Point(704, 24);
            this.ToDayBranchTimeTables.Name = "ToDayBranchTimeTables";
            this.ToDayBranchTimeTables.Size = new System.Drawing.Size(140, 22);
            this.ToDayBranchTimeTables.TabIndex = 97;
            this.ToDayBranchTimeTables.ValueChanged += new System.EventHandler(this.ToDayBranchTimeTables_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(674, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 17);
            this.label10.TabIndex = 96;
            this.label10.Text = "до";
            // 
            // BranchTimeTablesDay
            // 
            this.BranchTimeTablesDay.CustomFormat = "";
            this.BranchTimeTablesDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.BranchTimeTablesDay.Location = new System.Drawing.Point(528, 24);
            this.BranchTimeTablesDay.Name = "BranchTimeTablesDay";
            this.BranchTimeTablesDay.Size = new System.Drawing.Size(140, 22);
            this.BranchTimeTablesDay.TabIndex = 95;
            this.BranchTimeTablesDay.ValueChanged += new System.EventHandler(this.BranchTimeTablesDay_ValueChanged);
            // 
            // DateTimeTables_name
            // 
            this.DateTimeTables_name.AutoSize = true;
            this.DateTimeTables_name.Location = new System.Drawing.Point(461, 24);
            this.DateTimeTables_name.Name = "DateTimeTables_name";
            this.DateTimeTables_name.Size = new System.Drawing.Size(61, 17);
            this.DateTimeTables_name.TabIndex = 94;
            this.DateTimeTables_name.Text = "Дата от";
            // 
            // EndFromBranchTimeTables
            // 
            this.EndFromBranchTimeTables.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.EndFromBranchTimeTables.Location = new System.Drawing.Point(741, 117);
            this.EndFromBranchTimeTables.Name = "EndFromBranchTimeTables";
            this.EndFromBranchTimeTables.ShowUpDown = true;
            this.EndFromBranchTimeTables.Size = new System.Drawing.Size(92, 22);
            this.EndFromBranchTimeTables.TabIndex = 93;
            // 
            // ToEnd
            // 
            this.ToEnd.AutoSize = true;
            this.ToEnd.Location = new System.Drawing.Point(711, 117);
            this.ToEnd.Name = "ToEnd";
            this.ToEnd.Size = new System.Drawing.Size(24, 17);
            this.ToEnd.TabIndex = 92;
            this.ToEnd.Text = "до";
            // 
            // StartToBranchTimeTables
            // 
            this.StartToBranchTimeTables.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.StartToBranchTimeTables.Location = new System.Drawing.Point(741, 78);
            this.StartToBranchTimeTables.Name = "StartToBranchTimeTables";
            this.StartToBranchTimeTables.ShowUpDown = true;
            this.StartToBranchTimeTables.Size = new System.Drawing.Size(92, 22);
            this.StartToBranchTimeTables.TabIndex = 91;
            // 
            // ToStart
            // 
            this.ToStart.AutoSize = true;
            this.ToStart.Location = new System.Drawing.Point(711, 78);
            this.ToStart.Name = "ToStart";
            this.ToStart.Size = new System.Drawing.Size(24, 17);
            this.ToStart.TabIndex = 90;
            this.ToStart.Text = "до";
            // 
            // EndToBranchTimeTables
            // 
            this.EndToBranchTimeTables.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.EndToBranchTimeTables.Location = new System.Drawing.Point(613, 117);
            this.EndToBranchTimeTables.Name = "EndToBranchTimeTables";
            this.EndToBranchTimeTables.ShowUpDown = true;
            this.EndToBranchTimeTables.Size = new System.Drawing.Size(92, 22);
            this.EndToBranchTimeTables.TabIndex = 89;
            // 
            // StartFromBranchTimeTables
            // 
            this.StartFromBranchTimeTables.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.StartFromBranchTimeTables.Location = new System.Drawing.Point(613, 78);
            this.StartFromBranchTimeTables.Name = "StartFromBranchTimeTables";
            this.StartFromBranchTimeTables.ShowUpDown = true;
            this.StartFromBranchTimeTables.Size = new System.Drawing.Size(92, 22);
            this.StartFromBranchTimeTables.TabIndex = 88;
            // 
            // EndBranchTimeTables_name
            // 
            this.EndBranchTimeTables_name.AutoSize = true;
            this.EndBranchTimeTables_name.Location = new System.Drawing.Point(461, 117);
            this.EndBranchTimeTables_name.Name = "EndBranchTimeTables_name";
            this.EndBranchTimeTables_name.Size = new System.Drawing.Size(138, 17);
            this.EndBranchTimeTables_name.TabIndex = 8;
            this.EndBranchTimeTables_name.Text = "Завершение дня от";
            // 
            // StartBranchTimeTables_name
            // 
            this.StartBranchTimeTables_name.AutoSize = true;
            this.StartBranchTimeTables_name.Location = new System.Drawing.Point(461, 78);
            this.StartBranchTimeTables_name.Name = "StartBranchTimeTables_name";
            this.StartBranchTimeTables_name.Size = new System.Drawing.Size(105, 17);
            this.StartBranchTimeTables_name.TabIndex = 7;
            this.StartBranchTimeTables_name.Text = "Начало дня от";
            // 
            // IDTimeTables
            // 
            this.IDTimeTables.Location = new System.Drawing.Point(105, 22);
            this.IDTimeTables.Name = "IDTimeTables";
            this.IDTimeTables.Size = new System.Drawing.Size(160, 22);
            this.IDTimeTables.TabIndex = 1;
            // 
            // IDTimeTables_name
            // 
            this.IDTimeTables_name.AutoSize = true;
            this.IDTimeTables_name.Location = new System.Drawing.Point(6, 27);
            this.IDTimeTables_name.Name = "IDTimeTables_name";
            this.IDTimeTables_name.Size = new System.Drawing.Size(21, 17);
            this.IDTimeTables_name.TabIndex = 0;
            this.IDTimeTables_name.Text = "ID";
            // 
            // AllTimeTables
            // 
            this.AllTimeTables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllTimeTables.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdTimetable,
            this.StartShift,
            this.EndShift});
            this.AllTimeTables.Location = new System.Drawing.Point(12, 243);
            this.AllTimeTables.Name = "AllTimeTables";
            this.AllTimeTables.RowHeadersWidth = 51;
            this.AllTimeTables.RowTemplate.Height = 24;
            this.AllTimeTables.Size = new System.Drawing.Size(1008, 390);
            this.AllTimeTables.TabIndex = 1;
            // 
            // PageTimeTables
            // 
            this.PageTimeTables.Location = new System.Drawing.Point(430, 660);
            this.PageTimeTables.Margin = new System.Windows.Forms.Padding(4);
            this.PageTimeTables.Name = "PageTimeTables";
            this.PageTimeTables.Size = new System.Drawing.Size(65, 22);
            this.PageTimeTables.TabIndex = 191;
            // 
            // PagesTimeTables
            // 
            this.PagesTimeTables.AutoSize = true;
            this.PagesTimeTables.Location = new System.Drawing.Point(503, 663);
            this.PagesTimeTables.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PagesTimeTables.Name = "PagesTimeTables";
            this.PagesTimeTables.Size = new System.Drawing.Size(46, 17);
            this.PagesTimeTables.TabIndex = 190;
            this.PagesTimeTables.Text = "label1";
            // 
            // BackTimeTables
            // 
            this.BackTimeTables.Location = new System.Drawing.Point(269, 659);
            this.BackTimeTables.Margin = new System.Windows.Forms.Padding(4);
            this.BackTimeTables.Name = "BackTimeTables";
            this.BackTimeTables.Size = new System.Drawing.Size(71, 25);
            this.BackTimeTables.TabIndex = 189;
            this.BackTimeTables.Text = "<";
            this.BackTimeTables.UseVisualStyleBackColor = true;
            // 
            // ChooseTimeTables
            // 
            this.ChooseTimeTables.Location = new System.Drawing.Point(104, 655);
            this.ChooseTimeTables.Name = "ChooseTimeTables";
            this.ChooseTimeTables.Size = new System.Drawing.Size(95, 25);
            this.ChooseTimeTables.TabIndex = 193;
            this.ChooseTimeTables.Text = "Выбрать";
            this.ChooseTimeTables.UseVisualStyleBackColor = true;
            // 
            // AddTimeTables
            // 
            this.AddTimeTables.Location = new System.Drawing.Point(819, 658);
            this.AddTimeTables.Name = "AddTimeTables";
            this.AddTimeTables.Size = new System.Drawing.Size(94, 25);
            this.AddTimeTables.TabIndex = 192;
            this.AddTimeTables.Text = "Добавить";
            this.AddTimeTables.UseVisualStyleBackColor = true;
            this.AddTimeTables.Click += new System.EventHandler(this.AddTimeTables_Click);
            // 
            // ToTimeTables
            // 
            this.ToTimeTables.Location = new System.Drawing.Point(572, 659);
            this.ToTimeTables.Margin = new System.Windows.Forms.Padding(4);
            this.ToTimeTables.Name = "ToTimeTables";
            this.ToTimeTables.Size = new System.Drawing.Size(71, 25);
            this.ToTimeTables.TabIndex = 188;
            this.ToTimeTables.Text = ">";
            this.ToTimeTables.UseVisualStyleBackColor = true;
            // 
            // FindTimeTables
            // 
            this.FindTimeTables.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FindTimeTables.BackgroundImage")));
            this.FindTimeTables.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FindTimeTables.Location = new System.Drawing.Point(357, 657);
            this.FindTimeTables.Margin = new System.Windows.Forms.Padding(4);
            this.FindTimeTables.Name = "FindTimeTables";
            this.FindTimeTables.Size = new System.Drawing.Size(43, 25);
            this.FindTimeTables.TabIndex = 236;
            this.FindTimeTables.UseVisualStyleBackColor = true;
            // 
            // IdTimetable
            // 
            this.IdTimetable.HeaderText = "Id";
            this.IdTimetable.MinimumWidth = 6;
            this.IdTimetable.Name = "IdTimetable";
            this.IdTimetable.Width = 70;
            // 
            // StartShift
            // 
            this.StartShift.HeaderText = "Начало смены";
            this.StartShift.MinimumWidth = 6;
            this.StartShift.Name = "StartShift";
            this.StartShift.Width = 200;
            // 
            // EndShift
            // 
            this.EndShift.HeaderText = "Окончание смены";
            this.EndShift.MinimumWidth = 6;
            this.EndShift.Name = "EndShift";
            this.EndShift.Width = 200;
            // 
            // SortDescTime
            // 
            this.SortDescTime.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SortDescTime.BackgroundImage")));
            this.SortDescTime.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SortDescTime.Location = new System.Drawing.Point(271, 60);
            this.SortDescTime.Name = "SortDescTime";
            this.SortDescTime.Size = new System.Drawing.Size(36, 26);
            this.SortDescTime.TabIndex = 211;
            this.SortDescTime.UseVisualStyleBackColor = true;
            this.SortDescTime.Click += new System.EventHandler(this.SortDescTime_Click);
            // 
            // TimeTables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 714);
            this.Controls.Add(this.FindTimeTables);
            this.Controls.Add(this.PageTimeTables);
            this.Controls.Add(this.PagesTimeTables);
            this.Controls.Add(this.BackTimeTables);
            this.Controls.Add(this.ChooseTimeTables);
            this.Controls.Add(this.AddTimeTables);
            this.Controls.Add(this.ToTimeTables);
            this.Controls.Add(this.AllTimeTables);
            this.Controls.Add(this.FiltersTimeTables);
            this.Name = "TimeTables";
            this.Text = "Расписания работников(Timetables)";
            this.Load += new System.EventHandler(this.TimeTables_Load);
            this.FiltersTimeTables.ResumeLayout(false);
            this.FiltersTimeTables.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AllTimeTables)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox FiltersTimeTables;
        private System.Windows.Forms.DataGridView AllTimeTables;
        private System.Windows.Forms.Label EndBranchTimeTables_name;
        private System.Windows.Forms.Label StartBranchTimeTables_name;
        private System.Windows.Forms.TextBox IDTimeTables;
        private System.Windows.Forms.Label IDTimeTables_name;
        private System.Windows.Forms.Label DateTimeTables_name;
        private System.Windows.Forms.DateTimePicker EndFromBranchTimeTables;
        private System.Windows.Forms.Label ToEnd;
        private System.Windows.Forms.DateTimePicker StartToBranchTimeTables;
        private System.Windows.Forms.Label ToStart;
        private System.Windows.Forms.DateTimePicker EndToBranchTimeTables;
        private System.Windows.Forms.DateTimePicker StartFromBranchTimeTables;
        private System.Windows.Forms.DateTimePicker ToDayBranchTimeTables;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker BranchTimeTablesDay;
        private System.Windows.Forms.Label SortingTimeTables_name;
        private System.Windows.Forms.ComboBox SortingTimeTables;
        private System.Windows.Forms.TextBox PageTimeTables;
        private System.Windows.Forms.Label PagesTimeTables;
        private System.Windows.Forms.Button BackTimeTables;
        private System.Windows.Forms.Button ChooseTimeTables;
        private System.Windows.Forms.Button AddTimeTables;
        private System.Windows.Forms.Button ToTimeTables;
        private System.Windows.Forms.Button ApplyTimeTable;
        private System.Windows.Forms.Button ResetTimeTable;
        private System.Windows.Forms.Button FindTimeTables;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTimetable;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartShift;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndShift;
        private System.Windows.Forms.Button SortDescTime;
    }
}