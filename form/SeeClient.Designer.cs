
namespace form
{
    partial class SeeClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeeClient));
            this.QuantityOrders = new System.Windows.Forms.Label();
            this.QuantityOrdersInfo = new System.Windows.Forms.Button();
            this.QuantityOrders_name = new System.Windows.Forms.Label();
            this.ChangeClientInfo = new System.Windows.Forms.Button();
            this.DelClient = new System.Windows.Forms.Button();
            this.IDClientsInfo = new System.Windows.Forms.Label();
            this.IDClientsInfo_name = new System.Windows.Forms.Label();
            this.FIOClientInfo = new System.Windows.Forms.Label();
            this.PhoneClientInfo = new System.Windows.Forms.Label();
            this.ComClientInfo_name = new System.Windows.Forms.Label();
            this.PhoneClientInfo_name = new System.Windows.Forms.Label();
            this.FIOClientInfo_name = new System.Windows.Forms.Label();
            this.CommClient = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // QuantityOrders
            // 
            this.QuantityOrders.AutoSize = true;
            this.QuantityOrders.Location = new System.Drawing.Point(143, 119);
            this.QuantityOrders.Name = "QuantityOrders";
            this.QuantityOrders.Size = new System.Drawing.Size(46, 17);
            this.QuantityOrders.TabIndex = 186;
            this.QuantityOrders.Text = "label7";
            // 
            // QuantityOrdersInfo
            // 
            this.QuantityOrdersInfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("QuantityOrdersInfo.BackgroundImage")));
            this.QuantityOrdersInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.QuantityOrdersInfo.Location = new System.Drawing.Point(195, 116);
            this.QuantityOrdersInfo.Name = "QuantityOrdersInfo";
            this.QuantityOrdersInfo.Size = new System.Drawing.Size(37, 23);
            this.QuantityOrdersInfo.TabIndex = 185;
            this.QuantityOrdersInfo.UseVisualStyleBackColor = true;
            this.QuantityOrdersInfo.Click += new System.EventHandler(this.QuantityOrdersInfo_Click);
            // 
            // QuantityOrders_name
            // 
            this.QuantityOrders_name.AutoSize = true;
            this.QuantityOrders_name.Location = new System.Drawing.Point(14, 113);
            this.QuantityOrders_name.Name = "QuantityOrders_name";
            this.QuantityOrders_name.Size = new System.Drawing.Size(109, 17);
            this.QuantityOrders_name.TabIndex = 184;
            this.QuantityOrders_name.Text = "Кол-во заказов";
            // 
            // ChangeClientInfo
            // 
            this.ChangeClientInfo.Location = new System.Drawing.Point(147, 298);
            this.ChangeClientInfo.Name = "ChangeClientInfo";
            this.ChangeClientInfo.Size = new System.Drawing.Size(82, 25);
            this.ChangeClientInfo.TabIndex = 183;
            this.ChangeClientInfo.Text = "Изменить";
            this.ChangeClientInfo.UseVisualStyleBackColor = true;
            this.ChangeClientInfo.Click += new System.EventHandler(this.ChangeClientInfo_Click);
            // 
            // DelClient
            // 
            this.DelClient.BackColor = System.Drawing.Color.Pink;
            this.DelClient.Location = new System.Drawing.Point(235, 298);
            this.DelClient.Name = "DelClient";
            this.DelClient.Size = new System.Drawing.Size(82, 25);
            this.DelClient.TabIndex = 182;
            this.DelClient.Text = "Удалить";
            this.DelClient.UseVisualStyleBackColor = false;
            this.DelClient.Click += new System.EventHandler(this.DelClient_Click);
            // 
            // IDClientsInfo
            // 
            this.IDClientsInfo.AutoSize = true;
            this.IDClientsInfo.Location = new System.Drawing.Point(32, 23);
            this.IDClientsInfo.Name = "IDClientsInfo";
            this.IDClientsInfo.Size = new System.Drawing.Size(46, 17);
            this.IDClientsInfo.TabIndex = 181;
            this.IDClientsInfo.Text = "label5";
            // 
            // IDClientsInfo_name
            // 
            this.IDClientsInfo_name.AutoSize = true;
            this.IDClientsInfo_name.Location = new System.Drawing.Point(14, 23);
            this.IDClientsInfo_name.Name = "IDClientsInfo_name";
            this.IDClientsInfo_name.Size = new System.Drawing.Size(21, 17);
            this.IDClientsInfo_name.TabIndex = 180;
            this.IDClientsInfo_name.Text = "ID";
            // 
            // FIOClientInfo
            // 
            this.FIOClientInfo.AutoSize = true;
            this.FIOClientInfo.Location = new System.Drawing.Point(143, 59);
            this.FIOClientInfo.Name = "FIOClientInfo";
            this.FIOClientInfo.Size = new System.Drawing.Size(46, 17);
            this.FIOClientInfo.TabIndex = 179;
            this.FIOClientInfo.Text = "label4";
            // 
            // PhoneClientInfo
            // 
            this.PhoneClientInfo.AutoSize = true;
            this.PhoneClientInfo.Location = new System.Drawing.Point(143, 90);
            this.PhoneClientInfo.Name = "PhoneClientInfo";
            this.PhoneClientInfo.Size = new System.Drawing.Size(46, 17);
            this.PhoneClientInfo.TabIndex = 178;
            this.PhoneClientInfo.Text = "label1";
            // 
            // ComClientInfo_name
            // 
            this.ComClientInfo_name.AutoSize = true;
            this.ComClientInfo_name.Location = new System.Drawing.Point(14, 146);
            this.ComClientInfo_name.Name = "ComClientInfo_name";
            this.ComClientInfo_name.Size = new System.Drawing.Size(98, 17);
            this.ComClientInfo_name.TabIndex = 176;
            this.ComClientInfo_name.Text = "Комментарий";
            // 
            // PhoneClientInfo_name
            // 
            this.PhoneClientInfo_name.AutoSize = true;
            this.PhoneClientInfo_name.Location = new System.Drawing.Point(14, 86);
            this.PhoneClientInfo_name.Name = "PhoneClientInfo_name";
            this.PhoneClientInfo_name.Size = new System.Drawing.Size(121, 17);
            this.PhoneClientInfo_name.TabIndex = 175;
            this.PhoneClientInfo_name.Text = "Номер телефона";
            // 
            // FIOClientInfo_name
            // 
            this.FIOClientInfo_name.AutoSize = true;
            this.FIOClientInfo_name.Location = new System.Drawing.Point(14, 59);
            this.FIOClientInfo_name.Name = "FIOClientInfo_name";
            this.FIOClientInfo_name.Size = new System.Drawing.Size(42, 17);
            this.FIOClientInfo_name.TabIndex = 174;
            this.FIOClientInfo_name.Text = "ФИО";
            // 
            // CommClient
            // 
            this.CommClient.Location = new System.Drawing.Point(17, 166);
            this.CommClient.Multiline = true;
            this.CommClient.Name = "CommClient";
            this.CommClient.Size = new System.Drawing.Size(300, 100);
            this.CommClient.TabIndex = 187;
            // 
            // SeeClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 340);
            this.Controls.Add(this.CommClient);
            this.Controls.Add(this.QuantityOrders);
            this.Controls.Add(this.QuantityOrdersInfo);
            this.Controls.Add(this.QuantityOrders_name);
            this.Controls.Add(this.ChangeClientInfo);
            this.Controls.Add(this.DelClient);
            this.Controls.Add(this.IDClientsInfo);
            this.Controls.Add(this.IDClientsInfo_name);
            this.Controls.Add(this.FIOClientInfo);
            this.Controls.Add(this.PhoneClientInfo);
            this.Controls.Add(this.ComClientInfo_name);
            this.Controls.Add(this.PhoneClientInfo_name);
            this.Controls.Add(this.FIOClientInfo_name);
            this.Name = "SeeClient";
            this.Text = "Информация о клиенте";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SeeClient_FormClosing);
            this.Load += new System.EventHandler(this.SeeClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label QuantityOrders;
        private System.Windows.Forms.Button QuantityOrdersInfo;
        private System.Windows.Forms.Label QuantityOrders_name;
        private System.Windows.Forms.Button ChangeClientInfo;
        private System.Windows.Forms.Button DelClient;
        private System.Windows.Forms.Label IDClientsInfo;
        private System.Windows.Forms.Label IDClientsInfo_name;
        private System.Windows.Forms.Label FIOClientInfo;
        private System.Windows.Forms.Label PhoneClientInfo;
        private System.Windows.Forms.Label ComClientInfo_name;
        private System.Windows.Forms.Label PhoneClientInfo_name;
        private System.Windows.Forms.Label FIOClientInfo_name;
        private System.Windows.Forms.TextBox CommClient;
    }
}