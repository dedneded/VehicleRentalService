
namespace form
{
    partial class AddService
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
            this.DescriptionService_name = new System.Windows.Forms.Label();
            this.SaveService = new System.Windows.Forms.Button();
            this.CancelService = new System.Windows.Forms.Button();
            this.IDService_name = new System.Windows.Forms.Label();
            this.IDService = new System.Windows.Forms.Label();
            this.NameService_name = new System.Windows.Forms.Label();
            this.NameService = new System.Windows.Forms.TextBox();
            this.DescriptionService = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // DescriptionService_name
            // 
            this.DescriptionService_name.AutoSize = true;
            this.DescriptionService_name.Location = new System.Drawing.Point(12, 86);
            this.DescriptionService_name.Name = "DescriptionService_name";
            this.DescriptionService_name.Size = new System.Drawing.Size(74, 17);
            this.DescriptionService_name.TabIndex = 2;
            this.DescriptionService_name.Text = "Описание";
            // 
            // SaveService
            // 
            this.SaveService.Location = new System.Drawing.Point(232, 220);
            this.SaveService.Name = "SaveService";
            this.SaveService.Size = new System.Drawing.Size(88, 24);
            this.SaveService.TabIndex = 4;
            this.SaveService.Text = "Сохранить";
            this.SaveService.UseVisualStyleBackColor = true;
            this.SaveService.Click += new System.EventHandler(this.SaveService_Click);
            // 
            // CancelService
            // 
            this.CancelService.Location = new System.Drawing.Point(326, 220);
            this.CancelService.Name = "CancelService";
            this.CancelService.Size = new System.Drawing.Size(88, 24);
            this.CancelService.TabIndex = 5;
            this.CancelService.Text = "Отмена";
            this.CancelService.UseVisualStyleBackColor = true;
            // 
            // IDService_name
            // 
            this.IDService_name.AutoSize = true;
            this.IDService_name.Location = new System.Drawing.Point(12, 21);
            this.IDService_name.Name = "IDService_name";
            this.IDService_name.Size = new System.Drawing.Size(21, 17);
            this.IDService_name.TabIndex = 6;
            this.IDService_name.Text = "ID";
            // 
            // IDService
            // 
            this.IDService.AutoSize = true;
            this.IDService.Location = new System.Drawing.Point(40, 21);
            this.IDService.Name = "IDService";
            this.IDService.Size = new System.Drawing.Size(46, 17);
            this.IDService.TabIndex = 10;
            this.IDService.Text = "label4";
            // 
            // NameService_name
            // 
            this.NameService_name.AutoSize = true;
            this.NameService_name.Location = new System.Drawing.Point(12, 54);
            this.NameService_name.Name = "NameService_name";
            this.NameService_name.Size = new System.Drawing.Size(72, 17);
            this.NameService_name.TabIndex = 11;
            this.NameService_name.Text = "Название";
            // 
            // NameService
            // 
            this.NameService.Location = new System.Drawing.Point(97, 49);
            this.NameService.Name = "NameService";
            this.NameService.Size = new System.Drawing.Size(317, 22);
            this.NameService.TabIndex = 12;
            // 
            // DescriptionService
            // 
            this.DescriptionService.Location = new System.Drawing.Point(97, 86);
            this.DescriptionService.Multiline = true;
            this.DescriptionService.Name = "DescriptionService";
            this.DescriptionService.Size = new System.Drawing.Size(317, 100);
            this.DescriptionService.TabIndex = 13;
            // 
            // AddService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 261);
            this.Controls.Add(this.DescriptionService);
            this.Controls.Add(this.NameService);
            this.Controls.Add(this.NameService_name);
            this.Controls.Add(this.IDService);
            this.Controls.Add(this.IDService_name);
            this.Controls.Add(this.CancelService);
            this.Controls.Add(this.SaveService);
            this.Controls.Add(this.DescriptionService_name);
            this.Name = "AddService";
            this.Text = "Добавление/изменение услуги(AddService)";
            this.Load += new System.EventHandler(this.AddService_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label DescriptionService_name;
        private System.Windows.Forms.Button SaveService;
        private System.Windows.Forms.Button CancelService;
        private System.Windows.Forms.Label IDService_name;
        private System.Windows.Forms.Label IDService;
        private System.Windows.Forms.Label NameService_name;
        private System.Windows.Forms.TextBox NameService;
        private System.Windows.Forms.TextBox DescriptionService;
    }
}