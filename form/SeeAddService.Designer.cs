
namespace form
{
    partial class SeeAddService
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
            this.label1 = new System.Windows.Forms.Label();
            this.Vehicles = new System.Windows.Forms.Label();
            this.Workers = new System.Windows.Forms.Label();
            this.Vehicles_name = new System.Windows.Forms.Label();
            this.Workers_name = new System.Windows.Forms.Label();
            this.EndWork_name = new System.Windows.Forms.Label();
            this.StartWork_name = new System.Windows.Forms.Label();
            this.ServiceId = new System.Windows.Forms.LinkLabel();
            this.IdService = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.StartWork = new System.Windows.Forms.Label();
            this.EndWork = new System.Windows.Forms.Label();
            this.Duration = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(456, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 152;
            this.label1.Text = "Длительность(ч)";
            // 
            // Vehicles
            // 
            this.Vehicles.AutoSize = true;
            this.Vehicles.Location = new System.Drawing.Point(101, 144);
            this.Vehicles.Name = "Vehicles";
            this.Vehicles.Size = new System.Drawing.Size(54, 17);
            this.Vehicles.TabIndex = 151;
            this.Vehicles.Text = "label13";
            // 
            // Workers
            // 
            this.Workers.AutoSize = true;
            this.Workers.Location = new System.Drawing.Point(101, 115);
            this.Workers.Name = "Workers";
            this.Workers.Size = new System.Drawing.Size(54, 17);
            this.Workers.TabIndex = 150;
            this.Workers.Text = "label12";
            // 
            // Vehicles_name
            // 
            this.Vehicles_name.AutoSize = true;
            this.Vehicles_name.Location = new System.Drawing.Point(16, 144);
            this.Vehicles_name.Name = "Vehicles_name";
            this.Vehicles_name.Size = new System.Drawing.Size(62, 17);
            this.Vehicles_name.TabIndex = 149;
            this.Vehicles_name.Text = "Техника";
            // 
            // Workers_name
            // 
            this.Workers_name.AutoSize = true;
            this.Workers_name.Location = new System.Drawing.Point(16, 115);
            this.Workers_name.Name = "Workers_name";
            this.Workers_name.Size = new System.Drawing.Size(79, 17);
            this.Workers_name.TabIndex = 148;
            this.Workers_name.Text = "Работники";
            // 
            // EndWork_name
            // 
            this.EndWork_name.AutoSize = true;
            this.EndWork_name.Location = new System.Drawing.Point(16, 83);
            this.EndWork_name.Name = "EndWork_name";
            this.EndWork_name.Size = new System.Drawing.Size(134, 17);
            this.EndWork_name.TabIndex = 147;
            this.EndWork_name.Text = "Завершение работ";
            // 
            // StartWork_name
            // 
            this.StartWork_name.AutoSize = true;
            this.StartWork_name.Location = new System.Drawing.Point(14, 54);
            this.StartWork_name.Name = "StartWork_name";
            this.StartWork_name.Size = new System.Drawing.Size(101, 17);
            this.StartWork_name.TabIndex = 146;
            this.StartWork_name.Text = "Начало работ";
            // 
            // ServiceId
            // 
            this.ServiceId.AutoSize = true;
            this.ServiceId.Location = new System.Drawing.Point(102, 9);
            this.ServiceId.Name = "ServiceId";
            this.ServiceId.Size = new System.Drawing.Size(72, 17);
            this.ServiceId.TabIndex = 145;
            this.ServiceId.TabStop = true;
            this.ServiceId.Text = "linkLabel1";
            // 
            // IdService
            // 
            this.IdService.AutoSize = true;
            this.IdService.Location = new System.Drawing.Point(12, 9);
            this.IdService.Name = "IdService";
            this.IdService.Size = new System.Drawing.Size(65, 17);
            this.IdService.TabIndex = 144;
            this.IdService.Text = "Id услуги";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(180, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 23);
            this.button1.TabIndex = 159;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // StartWork
            // 
            this.StartWork.AutoSize = true;
            this.StartWork.Location = new System.Drawing.Point(177, 54);
            this.StartWork.Name = "StartWork";
            this.StartWork.Size = new System.Drawing.Size(46, 17);
            this.StartWork.TabIndex = 160;
            this.StartWork.Text = "label2";
            // 
            // EndWork
            // 
            this.EndWork.AutoSize = true;
            this.EndWork.Location = new System.Drawing.Point(177, 83);
            this.EndWork.Name = "EndWork";
            this.EndWork.Size = new System.Drawing.Size(46, 17);
            this.EndWork.TabIndex = 161;
            this.EndWork.Text = "label3";
            // 
            // Duration
            // 
            this.Duration.AutoSize = true;
            this.Duration.Location = new System.Drawing.Point(456, 83);
            this.Duration.Name = "Duration";
            this.Duration.Size = new System.Drawing.Size(46, 17);
            this.Duration.TabIndex = 162;
            this.Duration.Text = "label4";
            // 
            // SeeAddService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 194);
            this.Controls.Add(this.Duration);
            this.Controls.Add(this.EndWork);
            this.Controls.Add(this.StartWork);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Vehicles);
            this.Controls.Add(this.Workers);
            this.Controls.Add(this.Vehicles_name);
            this.Controls.Add(this.Workers_name);
            this.Controls.Add(this.EndWork_name);
            this.Controls.Add(this.StartWork_name);
            this.Controls.Add(this.ServiceId);
            this.Controls.Add(this.IdService);
            this.Name = "SeeAddService";
            this.Text = "SeeAddService";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Vehicles;
        private System.Windows.Forms.Label Workers;
        private System.Windows.Forms.Label Vehicles_name;
        private System.Windows.Forms.Label Workers_name;
        private System.Windows.Forms.Label EndWork_name;
        private System.Windows.Forms.Label StartWork_name;
        private System.Windows.Forms.LinkLabel ServiceId;
        private System.Windows.Forms.Label IdService;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label StartWork;
        private System.Windows.Forms.Label EndWork;
        private System.Windows.Forms.Label Duration;
    }
}