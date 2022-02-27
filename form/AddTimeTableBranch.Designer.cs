
namespace form
{
    partial class AddTimeTableBranch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTimeTableBranch));
            this.EndBrach = new System.Windows.Forms.DateTimePicker();
            this.EndBrach_name = new System.Windows.Forms.Label();
            this.StartBtanch = new System.Windows.Forms.DateTimePicker();
            this.StartBranch_name = new System.Windows.Forms.Label();
            this.TimeTableBranchChoose = new System.Windows.Forms.Button();
            this.TimeTableBranch = new System.Windows.Forms.LinkLabel();
            this.TimeTableBranch_name = new System.Windows.Forms.Label();
            this.CancelTimeTableBranch = new System.Windows.Forms.Button();
            this.SaveTimeTableBranch = new System.Windows.Forms.Button();
            this.IDTimeTableBranch_name = new System.Windows.Forms.Label();
            this.IDTimeTableBranch = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EndBrach
            // 
            this.EndBrach.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.EndBrach.Location = new System.Drawing.Point(204, 87);
            this.EndBrach.Name = "EndBrach";
            this.EndBrach.ShowUpDown = true;
            this.EndBrach.Size = new System.Drawing.Size(92, 22);
            this.EndBrach.TabIndex = 93;
            // 
            // EndBrach_name
            // 
            this.EndBrach_name.AutoSize = true;
            this.EndBrach_name.Location = new System.Drawing.Point(13, 87);
            this.EndBrach_name.Name = "EndBrach_name";
            this.EndBrach_name.Size = new System.Drawing.Size(175, 17);
            this.EndBrach_name.TabIndex = 92;
            this.EndBrach_name.Text = "Окончание рабочего дня";
            // 
            // StartBtanch
            // 
            this.StartBtanch.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.StartBtanch.Location = new System.Drawing.Point(204, 50);
            this.StartBtanch.Name = "StartBtanch";
            this.StartBtanch.ShowUpDown = true;
            this.StartBtanch.Size = new System.Drawing.Size(92, 22);
            this.StartBtanch.TabIndex = 91;
            // 
            // StartBranch_name
            // 
            this.StartBranch_name.AutoSize = true;
            this.StartBranch_name.Location = new System.Drawing.Point(13, 55);
            this.StartBranch_name.Name = "StartBranch_name";
            this.StartBranch_name.Size = new System.Drawing.Size(151, 17);
            this.StartBranch_name.TabIndex = 90;
            this.StartBranch_name.Text = "Начало рабочего дня";
            // 
            // TimeTableBranchChoose
            // 
            this.TimeTableBranchChoose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TimeTableBranchChoose.BackgroundImage")));
            this.TimeTableBranchChoose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.TimeTableBranchChoose.Location = new System.Drawing.Point(261, 163);
            this.TimeTableBranchChoose.Name = "TimeTableBranchChoose";
            this.TimeTableBranchChoose.Size = new System.Drawing.Size(35, 25);
            this.TimeTableBranchChoose.TabIndex = 115;
            this.TimeTableBranchChoose.UseVisualStyleBackColor = false;
            this.TimeTableBranchChoose.Click += new System.EventHandler(this.TimeTableBranchChoose_Click);
            // 
            // TimeTableBranch
            // 
            this.TimeTableBranch.AutoSize = true;
            this.TimeTableBranch.Location = new System.Drawing.Point(79, 167);
            this.TimeTableBranch.Name = "TimeTableBranch";
            this.TimeTableBranch.Size = new System.Drawing.Size(85, 17);
            this.TimeTableBranch.TabIndex = 114;
            this.TimeTableBranch.TabStop = true;
            this.TimeTableBranch.Text = "не выбрано";
            // 
            // TimeTableBranch_name
            // 
            this.TimeTableBranch_name.AutoSize = true;
            this.TimeTableBranch_name.Location = new System.Drawing.Point(13, 167);
            this.TimeTableBranch_name.Name = "TimeTableBranch_name";
            this.TimeTableBranch_name.Size = new System.Drawing.Size(61, 17);
            this.TimeTableBranch_name.TabIndex = 113;
            this.TimeTableBranch_name.Text = "Филиал";
            // 
            // CancelTimeTableBranch
            // 
            this.CancelTimeTableBranch.Location = new System.Drawing.Point(207, 222);
            this.CancelTimeTableBranch.Name = "CancelTimeTableBranch";
            this.CancelTimeTableBranch.Size = new System.Drawing.Size(88, 24);
            this.CancelTimeTableBranch.TabIndex = 117;
            this.CancelTimeTableBranch.Text = "Отмена";
            this.CancelTimeTableBranch.UseVisualStyleBackColor = true;
            // 
            // SaveTimeTableBranch
            // 
            this.SaveTimeTableBranch.Location = new System.Drawing.Point(113, 222);
            this.SaveTimeTableBranch.Name = "SaveTimeTableBranch";
            this.SaveTimeTableBranch.Size = new System.Drawing.Size(88, 24);
            this.SaveTimeTableBranch.TabIndex = 116;
            this.SaveTimeTableBranch.Text = "Сохранить";
            this.SaveTimeTableBranch.UseVisualStyleBackColor = true;
            // 
            // IDTimeTableBranch_name
            // 
            this.IDTimeTableBranch_name.AutoSize = true;
            this.IDTimeTableBranch_name.Location = new System.Drawing.Point(15, 9);
            this.IDTimeTableBranch_name.Name = "IDTimeTableBranch_name";
            this.IDTimeTableBranch_name.Size = new System.Drawing.Size(21, 17);
            this.IDTimeTableBranch_name.TabIndex = 118;
            this.IDTimeTableBranch_name.Text = "ID";
            // 
            // IDTimeTableBranch
            // 
            this.IDTimeTableBranch.AutoSize = true;
            this.IDTimeTableBranch.Location = new System.Drawing.Point(42, 9);
            this.IDTimeTableBranch.Name = "IDTimeTableBranch";
            this.IDTimeTableBranch.Size = new System.Drawing.Size(46, 17);
            this.IDTimeTableBranch.TabIndex = 119;
            this.IDTimeTableBranch.Text = "label5";
            // 
            // AddTimeTableBranch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 268);
            this.Controls.Add(this.IDTimeTableBranch);
            this.Controls.Add(this.IDTimeTableBranch_name);
            this.Controls.Add(this.CancelTimeTableBranch);
            this.Controls.Add(this.SaveTimeTableBranch);
            this.Controls.Add(this.TimeTableBranchChoose);
            this.Controls.Add(this.TimeTableBranch);
            this.Controls.Add(this.TimeTableBranch_name);
            this.Controls.Add(this.EndBrach);
            this.Controls.Add(this.EndBrach_name);
            this.Controls.Add(this.StartBtanch);
            this.Controls.Add(this.StartBranch_name);
            this.Name = "AddTimeTableBranch";
            this.Text = "Добавление/изменение расписания филиала";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker EndBrach;
        private System.Windows.Forms.Label EndBrach_name;
        private System.Windows.Forms.DateTimePicker StartBtanch;
        private System.Windows.Forms.Label StartBranch_name;
        private System.Windows.Forms.Button TimeTableBranchChoose;
        private System.Windows.Forms.LinkLabel TimeTableBranch;
        private System.Windows.Forms.Label TimeTableBranch_name;
        private System.Windows.Forms.Button CancelTimeTableBranch;
        private System.Windows.Forms.Button SaveTimeTableBranch;
        private System.Windows.Forms.Label IDTimeTableBranch_name;
        private System.Windows.Forms.Label IDTimeTableBranch;
    }
}