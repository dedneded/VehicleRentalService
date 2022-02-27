
namespace form
{
    partial class FillCategoryOfVehicle
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
            this.CategoryOfVehicle = new System.Windows.Forms.RadioButton();
            this.Subcategory = new System.Windows.Forms.RadioButton();
            this.WhatCreate = new System.Windows.Forms.GroupBox();
            this.ChooseParent = new System.Windows.Forms.Label();
            this.NewCategory = new System.Windows.Forms.ComboBox();
            this.NameCategory = new System.Windows.Forms.Label();
            this.CategoryOfVehicleNew = new System.Windows.Forms.TextBox();
            this.SaveCategory = new System.Windows.Forms.Button();
            this.CancelCategory = new System.Windows.Forms.Button();
            this.WhatCreate.SuspendLayout();
            this.SuspendLayout();
            // 
            // CategoryOfVehicle
            // 
            this.CategoryOfVehicle.AutoSize = true;
            this.CategoryOfVehicle.Location = new System.Drawing.Point(20, 33);
            this.CategoryOfVehicle.Name = "CategoryOfVehicle";
            this.CategoryOfVehicle.Size = new System.Drawing.Size(100, 21);
            this.CategoryOfVehicle.TabIndex = 0;
            this.CategoryOfVehicle.TabStop = true;
            this.CategoryOfVehicle.Text = "Категорию";
            this.CategoryOfVehicle.UseVisualStyleBackColor = true;
            this.CategoryOfVehicle.CheckedChanged += new System.EventHandler(this.CategoryOfVehicle_CheckedChanged);
            // 
            // Subcategory
            // 
            this.Subcategory.AutoSize = true;
            this.Subcategory.Location = new System.Drawing.Point(20, 60);
            this.Subcategory.Name = "Subcategory";
            this.Subcategory.Size = new System.Drawing.Size(124, 21);
            this.Subcategory.TabIndex = 1;
            this.Subcategory.TabStop = true;
            this.Subcategory.Text = "Подкатегорию";
            this.Subcategory.UseVisualStyleBackColor = true;
            // 
            // WhatCreate
            // 
            this.WhatCreate.Controls.Add(this.Subcategory);
            this.WhatCreate.Controls.Add(this.CategoryOfVehicle);
            this.WhatCreate.Location = new System.Drawing.Point(12, 12);
            this.WhatCreate.Name = "WhatCreate";
            this.WhatCreate.Size = new System.Drawing.Size(200, 100);
            this.WhatCreate.TabIndex = 2;
            this.WhatCreate.TabStop = false;
            this.WhatCreate.Text = "Что хотите создать?";
            // 
            // ChooseParent
            // 
            this.ChooseParent.AutoSize = true;
            this.ChooseParent.Location = new System.Drawing.Point(9, 139);
            this.ChooseParent.Name = "ChooseParent";
            this.ChooseParent.Size = new System.Drawing.Size(77, 17);
            this.ChooseParent.TabIndex = 3;
            this.ChooseParent.Text = "Категория";
            // 
            // NewCategory
            // 
            this.NewCategory.FormattingEnabled = true;
            this.NewCategory.Location = new System.Drawing.Point(12, 159);
            this.NewCategory.Name = "NewCategory";
            this.NewCategory.Size = new System.Drawing.Size(295, 24);
            this.NewCategory.TabIndex = 4;
            // 
            // NameCategory
            // 
            this.NameCategory.AutoSize = true;
            this.NameCategory.Location = new System.Drawing.Point(12, 210);
            this.NameCategory.Name = "NameCategory";
            this.NameCategory.Size = new System.Drawing.Size(215, 17);
            this.NameCategory.TabIndex = 5;
            this.NameCategory.Text = "Новая категория/подкатегория";
            // 
            // CategoryOfVehicleNew
            // 
            this.CategoryOfVehicleNew.Location = new System.Drawing.Point(12, 230);
            this.CategoryOfVehicleNew.Name = "CategoryOfVehicleNew";
            this.CategoryOfVehicleNew.Size = new System.Drawing.Size(295, 22);
            this.CategoryOfVehicleNew.TabIndex = 6;
            // 
            // SaveCategory
            // 
            this.SaveCategory.Location = new System.Drawing.Point(228, 274);
            this.SaveCategory.Name = "SaveCategory";
            this.SaveCategory.Size = new System.Drawing.Size(85, 23);
            this.SaveCategory.TabIndex = 7;
            this.SaveCategory.Text = "Сохранить";
            this.SaveCategory.UseVisualStyleBackColor = true;
            this.SaveCategory.Click += new System.EventHandler(this.SaveCategory_Click);
            // 
            // CancelCategory
            // 
            this.CancelCategory.Location = new System.Drawing.Point(319, 274);
            this.CancelCategory.Name = "CancelCategory";
            this.CancelCategory.Size = new System.Drawing.Size(85, 23);
            this.CancelCategory.TabIndex = 8;
            this.CancelCategory.Text = "Отменить";
            this.CancelCategory.UseVisualStyleBackColor = true;
            // 
            // FillCategoryOfVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 309);
            this.Controls.Add(this.CancelCategory);
            this.Controls.Add(this.SaveCategory);
            this.Controls.Add(this.CategoryOfVehicleNew);
            this.Controls.Add(this.NameCategory);
            this.Controls.Add(this.NewCategory);
            this.Controls.Add(this.ChooseParent);
            this.Controls.Add(this.WhatCreate);
            this.Name = "FillCategoryOfVehicle";
            this.Text = "Создание категории/подкатегории";
            this.Load += new System.EventHandler(this.FillCategoryOfVehicle_Load);
            this.WhatCreate.ResumeLayout(false);
            this.WhatCreate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton CategoryOfVehicle;
        private System.Windows.Forms.RadioButton Subcategory;
        private System.Windows.Forms.GroupBox WhatCreate;
        private System.Windows.Forms.Label ChooseParent;
        private System.Windows.Forms.ComboBox NewCategory;
        private System.Windows.Forms.Label NameCategory;
        private System.Windows.Forms.TextBox CategoryOfVehicleNew;
        private System.Windows.Forms.Button SaveCategory;
        private System.Windows.Forms.Button CancelCategory;
    }
}