
namespace form
{
    partial class SeeServiceInOrder
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
            this.Duration = new System.Windows.Forms.Label();
            this.Vehicles = new System.Windows.Forms.Label();
            this.Workers = new System.Windows.Forms.Label();
            this.Choose = new System.Windows.Forms.Button();
            this.Vehicles_name = new System.Windows.Forms.Label();
            this.Workers_name = new System.Windows.Forms.Label();
            this.EndWork_name = new System.Windows.Forms.Label();
            this.StartWork_name = new System.Windows.Forms.Label();
            this.NameService = new System.Windows.Forms.Label();
            
            this.StartWork = new System.Windows.Forms.Label();
            this.DurationService = new System.Windows.Forms.Label();
            this.End = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Duration
            // 
            this.Duration.AutoSize = true;
            this.Duration.Location = new System.Drawing.Point(10, 102);
            this.Duration.Name = "Duration";
            this.Duration.Size = new System.Drawing.Size(120, 17);
            this.Duration.TabIndex = 122;
            this.Duration.Text = "Длительность(ч)";
            // 
            // Vehicles
            // 
            this.Vehicles.AutoSize = true;
            this.Vehicles.Location = new System.Drawing.Point(365, 49);
            this.Vehicles.Name = "Vehicles";
            this.Vehicles.Size = new System.Drawing.Size(54, 17);
            this.Vehicles.TabIndex = 121;
            this.Vehicles.Text = "label13";
            // 
            // Workers
            // 
            this.Workers.AutoSize = true;
            this.Workers.Location = new System.Drawing.Point(365, 20);
            this.Workers.Name = "Workers";
            this.Workers.Size = new System.Drawing.Size(54, 17);
            this.Workers.TabIndex = 120;
            this.Workers.Text = "label12";
            // 
            // Choose
            // 
            this.Choose.Location = new System.Drawing.Point(443, 43);
            this.Choose.Name = "Choose";
            this.Choose.Size = new System.Drawing.Size(33, 23);
            this.Choose.TabIndex = 119;
            this.Choose.Text = "...";
            this.Choose.UseVisualStyleBackColor = true;
            this.Choose.Click += new System.EventHandler(this.Choose_Click);
            // 
            // Vehicles_name
            // 
            this.Vehicles_name.AutoSize = true;
            this.Vehicles_name.Location = new System.Drawing.Point(280, 49);
            this.Vehicles_name.Name = "Vehicles_name";
            this.Vehicles_name.Size = new System.Drawing.Size(62, 17);
            this.Vehicles_name.TabIndex = 118;
            this.Vehicles_name.Text = "Техника";
            // 
            // Workers_name
            // 
            this.Workers_name.AutoSize = true;
            this.Workers_name.Location = new System.Drawing.Point(280, 20);
            this.Workers_name.Name = "Workers_name";
            this.Workers_name.Size = new System.Drawing.Size(79, 17);
            this.Workers_name.TabIndex = 117;
            this.Workers_name.Text = "Работники";
            // 
            // EndWork_name
            // 
            this.EndWork_name.AutoSize = true;
            this.EndWork_name.Location = new System.Drawing.Point(12, 135);
            this.EndWork_name.Name = "EndWork_name";
            this.EndWork_name.Size = new System.Drawing.Size(134, 17);
            this.EndWork_name.TabIndex = 115;
            this.EndWork_name.Text = "Завершение работ";
            // 
            // StartWork_name
            // 
            this.StartWork_name.AutoSize = true;
            this.StartWork_name.Location = new System.Drawing.Point(10, 63);
            this.StartWork_name.Name = "StartWork_name";
            this.StartWork_name.Size = new System.Drawing.Size(101, 17);
            this.StartWork_name.TabIndex = 114;
            this.StartWork_name.Text = "Начало работ";
            // 
            // NameService
            // 
            this.NameService.AutoSize = true;
            this.NameService.Location = new System.Drawing.Point(12, 21);
            this.NameService.Name = "NameService";
            this.NameService.Size = new System.Drawing.Size(72, 17);
            this.NameService.TabIndex = 128;
            this.NameService.Text = "Название";
            // 
            // Name
            // 
          
            // 
            // StartWork
            // 
            this.StartWork.AutoSize = true;
            this.StartWork.Location = new System.Drawing.Point(159, 63);
            this.StartWork.Name = "StartWork";
            this.StartWork.Size = new System.Drawing.Size(46, 17);
            this.StartWork.TabIndex = 131;
            this.StartWork.Text = "label2";
            // 
            // DurationService
            // 
            this.DurationService.AutoSize = true;
            this.DurationService.Location = new System.Drawing.Point(159, 102);
            this.DurationService.Name = "DurationService";
            this.DurationService.Size = new System.Drawing.Size(46, 17);
            this.DurationService.TabIndex = 132;
            this.DurationService.Text = "label3";
            // 
            // End
            // 
            this.End.AutoSize = true;
            this.End.Location = new System.Drawing.Point(159, 135);
            this.End.Name = "End";
            this.End.Size = new System.Drawing.Size(46, 17);
            this.End.TabIndex = 133;
            this.End.Text = "label4";
            // 
            // SeeServiceInOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 227);
            this.Controls.Add(this.End);
            this.Controls.Add(this.DurationService);
            this.Controls.Add(this.StartWork);
           
            this.Controls.Add(this.NameService);
            this.Controls.Add(this.Duration);
            this.Controls.Add(this.Vehicles);
            this.Controls.Add(this.Workers);
            this.Controls.Add(this.Choose);
            this.Controls.Add(this.Vehicles_name);
            this.Controls.Add(this.Workers_name);
            this.Controls.Add(this.EndWork_name);
            this.Controls.Add(this.StartWork_name);
            
            this.Text = "Информация об услуге(SeeServiceInOrder)";
            this.Load += new System.EventHandler(this.SeeServiceInOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Duration;
        private System.Windows.Forms.Label Vehicles;
        private System.Windows.Forms.Label Workers;
        private System.Windows.Forms.Button Choose;
        private System.Windows.Forms.Label Vehicles_name;
        private System.Windows.Forms.Label Workers_name;
        private System.Windows.Forms.Label EndWork_name;
        private System.Windows.Forms.Label StartWork_name;
        private System.Windows.Forms.Label NameService;
  
        private System.Windows.Forms.Label StartWork;
        private System.Windows.Forms.Label DurationService;
        private System.Windows.Forms.Label End;
    }
}