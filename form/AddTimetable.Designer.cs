
namespace form
{
    partial class AddTimetable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTimetable));
            this.StartTimeTable_name = new System.Windows.Forms.Label();
            this.StartTimeTable = new System.Windows.Forms.DateTimePicker();
            this.EndTimeTable_name = new System.Windows.Forms.Label();
            this.EndTimeTable = new System.Windows.Forms.DateTimePicker();
            this.EmployeeChoose = new System.Windows.Forms.Button();
            this.WorkDay = new System.Windows.Forms.Label();
            this.Sunday = new System.Windows.Forms.CheckBox();
            this.Saturday = new System.Windows.Forms.CheckBox();
            this.Friday = new System.Windows.Forms.CheckBox();
            this.Thursday = new System.Windows.Forms.CheckBox();
            this.Wednesday = new System.Windows.Forms.CheckBox();
            this.Tuesday = new System.Windows.Forms.CheckBox();
            this.Monday = new System.Windows.Forms.CheckBox();
            this.Employee = new System.Windows.Forms.LinkLabel();
            this.Employee_name = new System.Windows.Forms.Label();
            this.CancelEmployee = new System.Windows.Forms.Button();
            this.SaveEmployee = new System.Windows.Forms.Button();
            this.IDTimetable_name = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.IDTimetable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StartTimeTable_name
            // 
            this.StartTimeTable_name.AutoSize = true;
            this.StartTimeTable_name.Location = new System.Drawing.Point(13, 55);
            this.StartTimeTable_name.Name = "StartTimeTable_name";
            this.StartTimeTable_name.Size = new System.Drawing.Size(151, 17);
            this.StartTimeTable_name.TabIndex = 0;
            this.StartTimeTable_name.Text = "Начало рабочего дня";
            // 
            // StartTimeTable
            // 
            this.StartTimeTable.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.StartTimeTable.Location = new System.Drawing.Point(203, 50);
            this.StartTimeTable.Name = "StartTimeTable";
            this.StartTimeTable.ShowUpDown = true;
            this.StartTimeTable.Size = new System.Drawing.Size(92, 22);
            this.StartTimeTable.TabIndex = 87;
            // 
            // EndTimeTable_name
            // 
            this.EndTimeTable_name.AutoSize = true;
            this.EndTimeTable_name.Location = new System.Drawing.Point(13, 89);
            this.EndTimeTable_name.Name = "EndTimeTable_name";
            this.EndTimeTable_name.Size = new System.Drawing.Size(175, 17);
            this.EndTimeTable_name.TabIndex = 88;
            this.EndTimeTable_name.Text = "Окончание рабочего дня";
            // 
            // EndTimeTable
            // 
            this.EndTimeTable.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.EndTimeTable.Location = new System.Drawing.Point(203, 89);
            this.EndTimeTable.Name = "EndTimeTable";
            this.EndTimeTable.ShowUpDown = true;
            this.EndTimeTable.Size = new System.Drawing.Size(92, 22);
            this.EndTimeTable.TabIndex = 89;
            // 
            // EmployeeChoose
            // 
            this.EmployeeChoose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EmployeeChoose.BackgroundImage")));
            this.EmployeeChoose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.EmployeeChoose.Location = new System.Drawing.Point(334, 206);
            this.EmployeeChoose.Name = "EmployeeChoose";
            this.EmployeeChoose.Size = new System.Drawing.Size(35, 25);
            this.EmployeeChoose.TabIndex = 112;
            this.EmployeeChoose.UseVisualStyleBackColor = false;
            this.EmployeeChoose.Click += new System.EventHandler(this.EmployeeChoose_Click);
            // 
            // WorkDay
            // 
            this.WorkDay.AutoSize = true;
            this.WorkDay.Location = new System.Drawing.Point(13, 138);
            this.WorkDay.Name = "WorkDay";
            this.WorkDay.Size = new System.Drawing.Size(93, 17);
            this.WorkDay.TabIndex = 145;
            this.WorkDay.Text = "Рабочие дни";
            // 
            // Sunday
            // 
            this.Sunday.AutoSize = true;
            this.Sunday.Location = new System.Drawing.Point(334, 158);
            this.Sunday.Name = "Sunday";
            this.Sunday.Size = new System.Drawing.Size(46, 21);
            this.Sunday.TabIndex = 144;
            this.Sunday.Text = "Вс";
            this.Sunday.UseVisualStyleBackColor = true;
            // 
            // Saturday
            // 
            this.Saturday.AutoSize = true;
            this.Saturday.Location = new System.Drawing.Point(281, 158);
            this.Saturday.Name = "Saturday";
            this.Saturday.Size = new System.Drawing.Size(47, 21);
            this.Saturday.TabIndex = 143;
            this.Saturday.Text = "Сб";
            this.Saturday.UseVisualStyleBackColor = true;
            // 
            // Friday
            // 
            this.Friday.AutoSize = true;
            this.Friday.Location = new System.Drawing.Point(228, 158);
            this.Friday.Name = "Friday";
            this.Friday.Size = new System.Drawing.Size(47, 21);
            this.Friday.TabIndex = 142;
            this.Friday.Text = "Пт";
            this.Friday.UseVisualStyleBackColor = true;
            // 
            // Thursday
            // 
            this.Thursday.AutoSize = true;
            this.Thursday.Location = new System.Drawing.Point(175, 158);
            this.Thursday.Name = "Thursday";
            this.Thursday.Size = new System.Drawing.Size(47, 21);
            this.Thursday.TabIndex = 141;
            this.Thursday.Text = "Чт";
            this.Thursday.UseVisualStyleBackColor = true;
            // 
            // Wednesday
            // 
            this.Wednesday.AutoSize = true;
            this.Wednesday.Location = new System.Drawing.Point(122, 158);
            this.Wednesday.Name = "Wednesday";
            this.Wednesday.Size = new System.Drawing.Size(47, 21);
            this.Wednesday.TabIndex = 140;
            this.Wednesday.Text = "Ср";
            this.Wednesday.UseVisualStyleBackColor = true;
            // 
            // Tuesday
            // 
            this.Tuesday.AutoSize = true;
            this.Tuesday.Location = new System.Drawing.Point(70, 158);
            this.Tuesday.Name = "Tuesday";
            this.Tuesday.Size = new System.Drawing.Size(46, 21);
            this.Tuesday.TabIndex = 139;
            this.Tuesday.Text = "Вт";
            this.Tuesday.UseVisualStyleBackColor = true;
            // 
            // Monday
            // 
            this.Monday.AutoSize = true;
            this.Monday.Location = new System.Drawing.Point(16, 158);
            this.Monday.Name = "Monday";
            this.Monday.Size = new System.Drawing.Size(48, 21);
            this.Monday.TabIndex = 138;
            this.Monday.Text = "Пн";
            this.Monday.UseVisualStyleBackColor = true;
            // 
            // Employee
            // 
            this.Employee.AutoSize = true;
            this.Employee.Location = new System.Drawing.Point(120, 210);
            this.Employee.Name = "Employee";
            this.Employee.Size = new System.Drawing.Size(72, 17);
            this.Employee.TabIndex = 147;
            this.Employee.TabStop = true;
            this.Employee.Text = "linkLabel1";
            // 
            // Employee_name
            // 
            this.Employee_name.AutoSize = true;
            this.Employee_name.Location = new System.Drawing.Point(13, 210);
            this.Employee_name.Name = "Employee_name";
            this.Employee_name.Size = new System.Drawing.Size(78, 17);
            this.Employee_name.TabIndex = 146;
            this.Employee_name.Text = "Сотрудник";
            // 
            // CancelEmployee
            // 
            this.CancelEmployee.Location = new System.Drawing.Point(292, 273);
            this.CancelEmployee.Name = "CancelEmployee";
            this.CancelEmployee.Size = new System.Drawing.Size(88, 24);
            this.CancelEmployee.TabIndex = 149;
            this.CancelEmployee.Text = "Отмена";
            this.CancelEmployee.UseVisualStyleBackColor = true;
            // 
            // SaveEmployee
            // 
            this.SaveEmployee.Location = new System.Drawing.Point(198, 273);
            this.SaveEmployee.Name = "SaveEmployee";
            this.SaveEmployee.Size = new System.Drawing.Size(88, 24);
            this.SaveEmployee.TabIndex = 148;
            this.SaveEmployee.Text = "Сохранить";
            this.SaveEmployee.UseVisualStyleBackColor = true;
            // 
            // IDTimetable_name
            // 
            this.IDTimetable_name.AutoSize = true;
            this.IDTimetable_name.Location = new System.Drawing.Point(13, 9);
            this.IDTimetable_name.Name = "IDTimetable_name";
            this.IDTimetable_name.Size = new System.Drawing.Size(21, 17);
            this.IDTimetable_name.TabIndex = 150;
            this.IDTimetable_name.Text = "ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(200, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 17);
            this.label6.TabIndex = 151;
            // 
            // IDTimetable
            // 
            this.IDTimetable.AutoSize = true;
            this.IDTimetable.Location = new System.Drawing.Point(45, 9);
            this.IDTimetable.Name = "IDTimetable";
            this.IDTimetable.Size = new System.Drawing.Size(46, 17);
            this.IDTimetable.TabIndex = 153;
            this.IDTimetable.Text = "label8";
            // 
            // AddTimetable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 310);
            this.Controls.Add(this.IDTimetable);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.IDTimetable_name);
            this.Controls.Add(this.CancelEmployee);
            this.Controls.Add(this.SaveEmployee);
            this.Controls.Add(this.Employee);
            this.Controls.Add(this.Employee_name);
            this.Controls.Add(this.WorkDay);
            this.Controls.Add(this.Sunday);
            this.Controls.Add(this.Saturday);
            this.Controls.Add(this.Friday);
            this.Controls.Add(this.Thursday);
            this.Controls.Add(this.Wednesday);
            this.Controls.Add(this.Tuesday);
            this.Controls.Add(this.Monday);
            this.Controls.Add(this.EmployeeChoose);
            this.Controls.Add(this.EndTimeTable);
            this.Controls.Add(this.EndTimeTable_name);
            this.Controls.Add(this.StartTimeTable);
            this.Controls.Add(this.StartTimeTable_name);
            this.Name = "AddTimetable";
            this.Text = "Добавление/изменение расписания работника";
            this.Load += new System.EventHandler(this.Timetable_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StartTimeTable_name;
        private System.Windows.Forms.DateTimePicker StartTimeTable;
        private System.Windows.Forms.Label EndTimeTable_name;
        private System.Windows.Forms.DateTimePicker EndTimeTable;
        private System.Windows.Forms.Button EmployeeChoose;
        private System.Windows.Forms.Label WorkDay;
        private System.Windows.Forms.CheckBox Sunday;
        private System.Windows.Forms.CheckBox Saturday;
        private System.Windows.Forms.CheckBox Friday;
        private System.Windows.Forms.CheckBox Thursday;
        private System.Windows.Forms.CheckBox Wednesday;
        private System.Windows.Forms.CheckBox Tuesday;
        private System.Windows.Forms.CheckBox Monday;
        private System.Windows.Forms.LinkLabel Employee;
        private System.Windows.Forms.Label Employee_name;
        private System.Windows.Forms.Button CancelEmployee;
        private System.Windows.Forms.Button SaveEmployee;
        private System.Windows.Forms.Label IDTimetable_name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label IDTimetable;
    }
}