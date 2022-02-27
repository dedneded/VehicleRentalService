
namespace form
{
    partial class AddManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddManager));
            this.PhoneEmployee = new System.Windows.Forms.TextBox();
            this.PhoneEmployee_name = new System.Windows.Forms.Label();
            this.FIOEmployee = new System.Windows.Forms.TextBox();
            this.FIOEmployee_name = new System.Windows.Forms.Label();
            this.BranchEmployee = new System.Windows.Forms.LinkLabel();
            this.BranchEmployeeChoose = new System.Windows.Forms.Button();
            this.CancelEmployee = new System.Windows.Forms.Button();
            this.SaveEmployee = new System.Windows.Forms.Button();
            this.BranchEmployee_name = new System.Windows.Forms.Label();
            this.IDEmployee = new System.Windows.Forms.Label();
            this.IDEmployee_name = new System.Windows.Forms.Label();
            this.RoleChooseManager = new System.Windows.Forms.Button();
            this.RoleNameManager = new System.Windows.Forms.LinkLabel();
            this.RoleManagerName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PhoneEmployee
            // 
            this.PhoneEmployee.Location = new System.Drawing.Point(162, 62);
            this.PhoneEmployee.Name = "PhoneEmployee";
            this.PhoneEmployee.Size = new System.Drawing.Size(289, 22);
            this.PhoneEmployee.TabIndex = 216;
            // 
            // PhoneEmployee_name
            // 
            this.PhoneEmployee_name.AutoSize = true;
            this.PhoneEmployee_name.Location = new System.Drawing.Point(12, 65);
            this.PhoneEmployee_name.Name = "PhoneEmployee_name";
            this.PhoneEmployee_name.Size = new System.Drawing.Size(121, 17);
            this.PhoneEmployee_name.TabIndex = 215;
            this.PhoneEmployee_name.Text = "Номер телефона";
            // 
            // FIOEmployee
            // 
            this.FIOEmployee.Location = new System.Drawing.Point(162, 34);
            this.FIOEmployee.Name = "FIOEmployee";
            this.FIOEmployee.Size = new System.Drawing.Size(289, 22);
            this.FIOEmployee.TabIndex = 214;
            // 
            // FIOEmployee_name
            // 
            this.FIOEmployee_name.AutoSize = true;
            this.FIOEmployee_name.Location = new System.Drawing.Point(12, 37);
            this.FIOEmployee_name.Name = "FIOEmployee_name";
            this.FIOEmployee_name.Size = new System.Drawing.Size(42, 17);
            this.FIOEmployee_name.TabIndex = 213;
            this.FIOEmployee_name.Text = "ФИО";
            // 
            // BranchEmployee
            // 
            this.BranchEmployee.AutoSize = true;
            this.BranchEmployee.Location = new System.Drawing.Point(159, 94);
            this.BranchEmployee.Name = "BranchEmployee";
            this.BranchEmployee.Size = new System.Drawing.Size(85, 17);
            this.BranchEmployee.TabIndex = 212;
            this.BranchEmployee.TabStop = true;
            this.BranchEmployee.Text = "не выбрано";
            // 
            // BranchEmployeeChoose
            // 
            this.BranchEmployeeChoose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BranchEmployeeChoose.BackgroundImage")));
            this.BranchEmployeeChoose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BranchEmployeeChoose.Location = new System.Drawing.Point(416, 90);
            this.BranchEmployeeChoose.Name = "BranchEmployeeChoose";
            this.BranchEmployeeChoose.Size = new System.Drawing.Size(35, 25);
            this.BranchEmployeeChoose.TabIndex = 211;
            this.BranchEmployeeChoose.UseVisualStyleBackColor = false;
            this.BranchEmployeeChoose.Click += new System.EventHandler(this.BranchEmployeeChoose_Click);
            // 
            // CancelEmployee
            // 
            this.CancelEmployee.Location = new System.Drawing.Point(363, 147);
            this.CancelEmployee.Name = "CancelEmployee";
            this.CancelEmployee.Size = new System.Drawing.Size(88, 26);
            this.CancelEmployee.TabIndex = 209;
            this.CancelEmployee.Text = "Отмена";
            this.CancelEmployee.UseVisualStyleBackColor = true;
            // 
            // SaveEmployee
            // 
            this.SaveEmployee.Location = new System.Drawing.Point(269, 147);
            this.SaveEmployee.Name = "SaveEmployee";
            this.SaveEmployee.Size = new System.Drawing.Size(88, 26);
            this.SaveEmployee.TabIndex = 208;
            this.SaveEmployee.Text = "Сохранить";
            this.SaveEmployee.UseVisualStyleBackColor = true;
            this.SaveEmployee.Click += new System.EventHandler(this.SaveEmployee_Click);
            // 
            // BranchEmployee_name
            // 
            this.BranchEmployee_name.AutoSize = true;
            this.BranchEmployee_name.Location = new System.Drawing.Point(12, 94);
            this.BranchEmployee_name.Name = "BranchEmployee_name";
            this.BranchEmployee_name.Size = new System.Drawing.Size(61, 17);
            this.BranchEmployee_name.TabIndex = 205;
            this.BranchEmployee_name.Text = "Филиал";
            // 
            // IDEmployee
            // 
            this.IDEmployee.AutoSize = true;
            this.IDEmployee.Location = new System.Drawing.Point(159, 9);
            this.IDEmployee.Name = "IDEmployee";
            this.IDEmployee.Size = new System.Drawing.Size(46, 17);
            this.IDEmployee.TabIndex = 218;
            this.IDEmployee.Text = "label6";
            // 
            // IDEmployee_name
            // 
            this.IDEmployee_name.AutoSize = true;
            this.IDEmployee_name.Location = new System.Drawing.Point(12, 9);
            this.IDEmployee_name.Name = "IDEmployee_name";
            this.IDEmployee_name.Size = new System.Drawing.Size(21, 17);
            this.IDEmployee_name.TabIndex = 217;
            this.IDEmployee_name.Text = "ID";
            // 
            // RoleChooseManager
            // 
            this.RoleChooseManager.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RoleChooseManager.BackgroundImage")));
            this.RoleChooseManager.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RoleChooseManager.Location = new System.Drawing.Point(416, 118);
            this.RoleChooseManager.Name = "RoleChooseManager";
            this.RoleChooseManager.Size = new System.Drawing.Size(35, 25);
            this.RoleChooseManager.TabIndex = 221;
            this.RoleChooseManager.UseVisualStyleBackColor = false;
            this.RoleChooseManager.Click += new System.EventHandler(this.RoleChooseManager_Click);
            // 
            // RoleNameManager
            // 
            this.RoleNameManager.AutoSize = true;
            this.RoleNameManager.Location = new System.Drawing.Point(159, 126);
            this.RoleNameManager.Name = "RoleNameManager";
            this.RoleNameManager.Size = new System.Drawing.Size(85, 17);
            this.RoleNameManager.TabIndex = 220;
            this.RoleNameManager.TabStop = true;
            this.RoleNameManager.Text = "не выбрано";
            // 
            // RoleManagerName
            // 
            this.RoleManagerName.AutoSize = true;
            this.RoleManagerName.Location = new System.Drawing.Point(15, 126);
            this.RoleManagerName.Name = "RoleManagerName";
            this.RoleManagerName.Size = new System.Drawing.Size(81, 17);
            this.RoleManagerName.TabIndex = 219;
            this.RoleManagerName.Text = "Должность";
            // 
            // AddManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 184);
            this.Controls.Add(this.RoleChooseManager);
            this.Controls.Add(this.RoleNameManager);
            this.Controls.Add(this.RoleManagerName);
            this.Controls.Add(this.IDEmployee);
            this.Controls.Add(this.IDEmployee_name);
            this.Controls.Add(this.PhoneEmployee);
            this.Controls.Add(this.PhoneEmployee_name);
            this.Controls.Add(this.FIOEmployee);
            this.Controls.Add(this.FIOEmployee_name);
            this.Controls.Add(this.BranchEmployee);
            this.Controls.Add(this.BranchEmployeeChoose);
            this.Controls.Add(this.CancelEmployee);
            this.Controls.Add(this.SaveEmployee);
            this.Controls.Add(this.BranchEmployee_name);
            this.Name = "AddManager";
            this.Text = "Добавление/удаление работника(AddEmployee)";
            this.Load += new System.EventHandler(this.Employee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PhoneEmployee;
        private System.Windows.Forms.Label PhoneEmployee_name;
        private System.Windows.Forms.TextBox FIOEmployee;
        private System.Windows.Forms.Label FIOEmployee_name;
        private System.Windows.Forms.LinkLabel BranchEmployee;
        private System.Windows.Forms.Button BranchEmployeeChoose;
        private System.Windows.Forms.Button CancelEmployee;
        private System.Windows.Forms.Button SaveEmployee;
        private System.Windows.Forms.Label BranchEmployee_name;
        private System.Windows.Forms.Label IDEmployee;
        private System.Windows.Forms.Label IDEmployee_name;
        private System.Windows.Forms.Button RoleChooseManager;
        private System.Windows.Forms.LinkLabel RoleNameManager;
        private System.Windows.Forms.Label RoleManagerName;
    }
}