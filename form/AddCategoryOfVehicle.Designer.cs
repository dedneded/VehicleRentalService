
namespace form
{
    partial class AddCategoryOfVehicle
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
            this.CategoriesOfVehicle = new System.Windows.Forms.TreeView();
            this.ChooseCaregoryOfVehicle = new System.Windows.Forms.Button();
            this.NewCategory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CategoriesOfVehicle
            // 
            this.CategoriesOfVehicle.Location = new System.Drawing.Point(12, 12);
            this.CategoriesOfVehicle.Name = "CategoriesOfVehicle";
            this.CategoriesOfVehicle.Size = new System.Drawing.Size(757, 325);
            this.CategoriesOfVehicle.TabIndex = 206;
            this.CategoriesOfVehicle.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.CategoriesOfVehicle_AfterSelect);
            // 
            // ChooseCaregoryOfVehicle
            // 
            this.ChooseCaregoryOfVehicle.Location = new System.Drawing.Point(12, 358);
            this.ChooseCaregoryOfVehicle.Name = "ChooseCaregoryOfVehicle";
            this.ChooseCaregoryOfVehicle.Size = new System.Drawing.Size(75, 23);
            this.ChooseCaregoryOfVehicle.TabIndex = 210;
            this.ChooseCaregoryOfVehicle.Text = "Выбрать";
            this.ChooseCaregoryOfVehicle.UseVisualStyleBackColor = true;
            this.ChooseCaregoryOfVehicle.Click += new System.EventHandler(this.ChooseCaregoryOfVehicle_Click);
            // 
            // NewCategory
            // 
            this.NewCategory.Location = new System.Drawing.Point(683, 358);
            this.NewCategory.Name = "NewCategory";
            this.NewCategory.Size = new System.Drawing.Size(86, 23);
            this.NewCategory.TabIndex = 211;
            this.NewCategory.Text = "Добавить";
            this.NewCategory.UseVisualStyleBackColor = true;
            this.NewCategory.Click += new System.EventHandler(this.NewCategory_Click);
            // 
            // AddCategoryOfVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 402);
            this.Controls.Add(this.NewCategory);
            this.Controls.Add(this.ChooseCaregoryOfVehicle);
            this.Controls.Add(this.CategoriesOfVehicle);
            this.Name = "AddCategoryOfVehicle";
            this.Text = "Категории техники(CategoryOfVehicle)";
            this.Load += new System.EventHandler(this.AddCategoryOfVehicle_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TreeView CategoriesOfVehicle;
        private System.Windows.Forms.Button ChooseCaregoryOfVehicle;
        private System.Windows.Forms.Button NewCategory;
    }
}