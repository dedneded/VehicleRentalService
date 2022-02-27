
namespace form
{
    partial class ChooseEmployee
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
            this.ChoseeEmp = new System.Windows.Forms.Label();
            this.DriverAdd = new System.Windows.Forms.Button();
            this.ManagerAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ChoseeEmp
            // 
            this.ChoseeEmp.AutoSize = true;
            this.ChoseeEmp.Location = new System.Drawing.Point(100, 29);
            this.ChoseeEmp.Name = "ChoseeEmp";
            this.ChoseeEmp.Size = new System.Drawing.Size(159, 17);
            this.ChoseeEmp.TabIndex = 0;
            this.ChoseeEmp.Text = "Кого хотите добавить?";
            // 
            // DriverAdd
            // 
            this.DriverAdd.Location = new System.Drawing.Point(60, 99);
            this.DriverAdd.Name = "DriverAdd";
            this.DriverAdd.Size = new System.Drawing.Size(88, 23);
            this.DriverAdd.TabIndex = 1;
            this.DriverAdd.Text = "Водителя";
            this.DriverAdd.UseVisualStyleBackColor = true;
            this.DriverAdd.Click += new System.EventHandler(this.DriverAdd_Click);
            // 
            // ManagerAdd
            // 
            this.ManagerAdd.Location = new System.Drawing.Point(208, 99);
            this.ManagerAdd.Name = "ManagerAdd";
            this.ManagerAdd.Size = new System.Drawing.Size(105, 23);
            this.ManagerAdd.TabIndex = 2;
            this.ManagerAdd.Text = "Менеджера";
            this.ManagerAdd.UseVisualStyleBackColor = true;
            this.ManagerAdd.Click += new System.EventHandler(this.ManagerAdd_Click);
            // 
            // ChooseEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 224);
            this.Controls.Add(this.ManagerAdd);
            this.Controls.Add(this.DriverAdd);
            this.Controls.Add(this.ChoseeEmp);
            this.Name = "ChooseEmployee";
            this.Text = "ChooseEmployee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ChoseeEmp;
        private System.Windows.Forms.Button DriverAdd;
        private System.Windows.Forms.Button ManagerAdd;
    }
}