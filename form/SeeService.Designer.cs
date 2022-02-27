
namespace form
{
    partial class SeeService
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeeService));
            this.button3 = new System.Windows.Forms.Button();
            this.QuantityOrdersService = new System.Windows.Forms.Label();
            this.QuantityOrdersService_name = new System.Windows.Forms.Label();
            this.IDServiceInfo = new System.Windows.Forms.Label();
            this.IDServiceInfo_name = new System.Windows.Forms.Label();
            this.ChangeService = new System.Windows.Forms.Button();
            this.DelService = new System.Windows.Forms.Button();
            this.NameServiceInfo = new System.Windows.Forms.Label();
            this.DescriptionService_name = new System.Windows.Forms.Label();
            this.NameServiceInfo_name = new System.Windows.Forms.Label();
            this.DescriptionService = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Location = new System.Drawing.Point(196, 84);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(37, 23);
            this.button3.TabIndex = 217;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // QuantityOrdersService
            // 
            this.QuantityOrdersService.AutoSize = true;
            this.QuantityOrdersService.Location = new System.Drawing.Point(137, 87);
            this.QuantityOrdersService.Name = "QuantityOrdersService";
            this.QuantityOrdersService.Size = new System.Drawing.Size(54, 17);
            this.QuantityOrdersService.TabIndex = 216;
            this.QuantityOrdersService.Text = "label13";
            // 
            // QuantityOrdersService_name
            // 
            this.QuantityOrdersService_name.AutoSize = true;
            this.QuantityOrdersService_name.Location = new System.Drawing.Point(14, 87);
            this.QuantityOrdersService_name.Name = "QuantityOrdersService_name";
            this.QuantityOrdersService_name.Size = new System.Drawing.Size(109, 17);
            this.QuantityOrdersService_name.TabIndex = 215;
            this.QuantityOrdersService_name.Text = "Кол-во заказов";
            // 
            // IDServiceInfo
            // 
            this.IDServiceInfo.AutoSize = true;
            this.IDServiceInfo.Location = new System.Drawing.Point(38, 27);
            this.IDServiceInfo.Name = "IDServiceInfo";
            this.IDServiceInfo.Size = new System.Drawing.Size(46, 17);
            this.IDServiceInfo.TabIndex = 214;
            this.IDServiceInfo.Text = "label5";
            // 
            // IDServiceInfo_name
            // 
            this.IDServiceInfo_name.AutoSize = true;
            this.IDServiceInfo_name.Location = new System.Drawing.Point(12, 27);
            this.IDServiceInfo_name.Name = "IDServiceInfo_name";
            this.IDServiceInfo_name.Size = new System.Drawing.Size(21, 17);
            this.IDServiceInfo_name.TabIndex = 213;
            this.IDServiceInfo_name.Text = "ID";
            // 
            // ChangeService
            // 
            this.ChangeService.Location = new System.Drawing.Point(310, 328);
            this.ChangeService.Name = "ChangeService";
            this.ChangeService.Size = new System.Drawing.Size(82, 25);
            this.ChangeService.TabIndex = 212;
            this.ChangeService.Text = "Изменить";
            this.ChangeService.UseVisualStyleBackColor = true;
            // 
            // DelService
            // 
            this.DelService.BackColor = System.Drawing.Color.Pink;
            this.DelService.Location = new System.Drawing.Point(398, 328);
            this.DelService.Name = "DelService";
            this.DelService.Size = new System.Drawing.Size(82, 25);
            this.DelService.TabIndex = 211;
            this.DelService.Text = "Удалить";
            this.DelService.UseVisualStyleBackColor = false;
            // 
            // NameServiceInfo
            // 
            this.NameServiceInfo.AutoSize = true;
            this.NameServiceInfo.Location = new System.Drawing.Point(137, 59);
            this.NameServiceInfo.Name = "NameServiceInfo";
            this.NameServiceInfo.Size = new System.Drawing.Size(46, 17);
            this.NameServiceInfo.TabIndex = 210;
            this.NameServiceInfo.Text = "label3";
            // 
            // DescriptionService_name
            // 
            this.DescriptionService_name.AutoSize = true;
            this.DescriptionService_name.Location = new System.Drawing.Point(14, 119);
            this.DescriptionService_name.Name = "DescriptionService_name";
            this.DescriptionService_name.Size = new System.Drawing.Size(74, 17);
            this.DescriptionService_name.TabIndex = 208;
            this.DescriptionService_name.Text = "Описание";
            // 
            // NameServiceInfo_name
            // 
            this.NameServiceInfo_name.AutoSize = true;
            this.NameServiceInfo_name.Location = new System.Drawing.Point(14, 59);
            this.NameServiceInfo_name.Name = "NameServiceInfo_name";
            this.NameServiceInfo_name.Size = new System.Drawing.Size(72, 17);
            this.NameServiceInfo_name.TabIndex = 207;
            this.NameServiceInfo_name.Text = "Название";
            // 
            // DescriptionService
            // 
            this.DescriptionService.Location = new System.Drawing.Point(17, 152);
            this.DescriptionService.Multiline = true;
            this.DescriptionService.Name = "DescriptionService";
            this.DescriptionService.Size = new System.Drawing.Size(463, 112);
            this.DescriptionService.TabIndex = 220;
            // 
            // SeeService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 368);
            this.Controls.Add(this.DescriptionService);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.QuantityOrdersService);
            this.Controls.Add(this.QuantityOrdersService_name);
            this.Controls.Add(this.IDServiceInfo);
            this.Controls.Add(this.IDServiceInfo_name);
            this.Controls.Add(this.ChangeService);
            this.Controls.Add(this.DelService);
            this.Controls.Add(this.NameServiceInfo);
            this.Controls.Add(this.DescriptionService_name);
            this.Controls.Add(this.NameServiceInfo_name);
            this.Name = "SeeService";
            this.Text = "Информация об услуге";
            this.Load += new System.EventHandler(this.SeeService_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label QuantityOrdersService;
        private System.Windows.Forms.Label QuantityOrdersService_name;
        private System.Windows.Forms.Label IDServiceInfo;
        private System.Windows.Forms.Label IDServiceInfo_name;
        private System.Windows.Forms.Button ChangeService;
        private System.Windows.Forms.Button DelService;
        private System.Windows.Forms.Label NameServiceInfo;
        private System.Windows.Forms.Label DescriptionService_name;
        private System.Windows.Forms.Label NameServiceInfo_name;
        private System.Windows.Forms.TextBox DescriptionService;
    }
}