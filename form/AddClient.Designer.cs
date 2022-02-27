
namespace form
{
    partial class AddClient
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
            this.components = new System.ComponentModel.Container();
            this.Comm_Name = new System.Windows.Forms.Label();
            this.PhoneNumber = new System.Windows.Forms.TextBox();
            this.PhoneNumber_name = new System.Windows.Forms.Label();
            this.FIO = new System.Windows.Forms.TextBox();
            this.FIO_name = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.ID_name = new System.Windows.Forms.Label();
            this.QuantityOrders = new System.Windows.Forms.Label();
            this.QuantityOrders_Name = new System.Windows.Forms.Label();
            this.CancelClient = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.errorFio = new System.Windows.Forms.ErrorProvider(this.components);
            this.Comm = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorFio)).BeginInit();
            this.SuspendLayout();
            // 
            // Comm_Name
            // 
            this.Comm_Name.AutoSize = true;
            this.Comm_Name.Location = new System.Drawing.Point(14, 156);
            this.Comm_Name.Name = "Comm_Name";
            this.Comm_Name.Size = new System.Drawing.Size(102, 17);
            this.Comm_Name.TabIndex = 154;
            this.Comm_Name.Text = "Комментарий:";
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.Location = new System.Drawing.Point(154, 72);
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(288, 22);
            this.PhoneNumber.TabIndex = 153;
            // 
            // PhoneNumber_name
            // 
            this.PhoneNumber_name.AutoSize = true;
            this.PhoneNumber_name.Location = new System.Drawing.Point(14, 75);
            this.PhoneNumber_name.Name = "PhoneNumber_name";
            this.PhoneNumber_name.Size = new System.Drawing.Size(121, 17);
            this.PhoneNumber_name.TabIndex = 152;
            this.PhoneNumber_name.Text = "Номер телефона";
            // 
            // FIO
            // 
            this.FIO.Location = new System.Drawing.Point(154, 41);
            this.FIO.Name = "FIO";
            this.FIO.Size = new System.Drawing.Size(288, 22);
            this.FIO.TabIndex = 151;
            this.FIO.TextChanged += new System.EventHandler(this.FIO_TextChanged);
            // 
            // FIO_name
            // 
            this.FIO_name.AutoSize = true;
            this.FIO_name.Location = new System.Drawing.Point(14, 44);
            this.FIO_name.Name = "FIO_name";
            this.FIO_name.Size = new System.Drawing.Size(42, 17);
            this.FIO_name.TabIndex = 150;
            this.FIO_name.Text = "ФИО";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(151, 9);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(46, 17);
            this.ID.TabIndex = 202;
            this.ID.Text = "label1";
            // 
            // ID_name
            // 
            this.ID_name.AutoSize = true;
            this.ID_name.Location = new System.Drawing.Point(14, 9);
            this.ID_name.Name = "ID_name";
            this.ID_name.Size = new System.Drawing.Size(21, 17);
            this.ID_name.TabIndex = 201;
            this.ID_name.Text = "ID";
            // 
            // QuantityOrders
            // 
            this.QuantityOrders.AutoSize = true;
            this.QuantityOrders.Location = new System.Drawing.Point(151, 113);
            this.QuantityOrders.Name = "QuantityOrders";
            this.QuantityOrders.Size = new System.Drawing.Size(46, 17);
            this.QuantityOrders.TabIndex = 204;
            this.QuantityOrders.Text = "label8";
            // 
            // QuantityOrders_Name
            // 
            this.QuantityOrders_Name.AutoSize = true;
            this.QuantityOrders_Name.Location = new System.Drawing.Point(14, 112);
            this.QuantityOrders_Name.Name = "QuantityOrders_Name";
            this.QuantityOrders_Name.Size = new System.Drawing.Size(109, 17);
            this.QuantityOrders_Name.TabIndex = 203;
            this.QuantityOrders_Name.Text = "Кол-во заказов";
            // 
            // CancelClient
            // 
            this.CancelClient.Location = new System.Drawing.Point(354, 282);
            this.CancelClient.Name = "CancelClient";
            this.CancelClient.Size = new System.Drawing.Size(88, 24);
            this.CancelClient.TabIndex = 206;
            this.CancelClient.Text = "Отмена";
            this.CancelClient.UseVisualStyleBackColor = true;
            this.CancelClient.Click += new System.EventHandler(this.CancelClient_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(260, 282);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(88, 24);
            this.Save.TabIndex = 205;
            this.Save.Text = "Сохранить";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // errorFio
            // 
            this.errorFio.ContainerControl = this;
            // 
            // Comm
            // 
            this.Comm.Location = new System.Drawing.Point(154, 156);
            this.Comm.Multiline = true;
            this.Comm.Name = "Comm";
            this.Comm.Size = new System.Drawing.Size(288, 120);
            this.Comm.TabIndex = 207;
            // 
            // AddClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 327);
            this.Controls.Add(this.Comm);
            this.Controls.Add(this.CancelClient);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.QuantityOrders);
            this.Controls.Add(this.QuantityOrders_Name);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.ID_name);
            this.Controls.Add(this.Comm_Name);
            this.Controls.Add(this.PhoneNumber);
            this.Controls.Add(this.PhoneNumber_name);
            this.Controls.Add(this.FIO);
            this.Controls.Add(this.FIO_name);
            this.Name = "AddClient";
            this.Text = "Добавление/изменение клиента(AddClient)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddClient_FormClosing);
            this.Load += new System.EventHandler(this.AddClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorFio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Comm_Name;
        private System.Windows.Forms.TextBox PhoneNumber;
        private System.Windows.Forms.Label PhoneNumber_name;
        private System.Windows.Forms.TextBox FIO;
        private System.Windows.Forms.Label FIO_name;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label ID_name;
        private System.Windows.Forms.Label QuantityOrders;
        private System.Windows.Forms.Label QuantityOrders_Name;
        private System.Windows.Forms.Button CancelClient;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.ErrorProvider errorFio;
        private System.Windows.Forms.TextBox Comm;
    }
}