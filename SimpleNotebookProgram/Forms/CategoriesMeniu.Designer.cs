namespace SimpleNotebookProgram
{
    partial class categoriesMenu
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.categoriesCreateButton = new System.Windows.Forms.Button();
            this.editCategoryButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.categoryNameTextBox = new System.Windows.Forms.TextBox();
            this.dataCategoriesGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.goToNotesMenu = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.userIdTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataCategoriesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Delete Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Edit Category";
            // 
            // categoriesCreateButton
            // 
            this.categoriesCreateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categoriesCreateButton.ForeColor = System.Drawing.Color.White;
            this.categoriesCreateButton.Location = new System.Drawing.Point(343, 179);
            this.categoriesCreateButton.Name = "categoriesCreateButton";
            this.categoriesCreateButton.Size = new System.Drawing.Size(162, 23);
            this.categoriesCreateButton.TabIndex = 3;
            this.categoriesCreateButton.Text = "Create";
            this.categoriesCreateButton.UseVisualStyleBackColor = true;
            this.categoriesCreateButton.Click += new System.EventHandler(this.categoriesCreateButton_Click);
            // 
            // editCategoryButton
            // 
            this.editCategoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editCategoryButton.ForeColor = System.Drawing.Color.White;
            this.editCategoryButton.Location = new System.Drawing.Point(343, 258);
            this.editCategoryButton.Name = "editCategoryButton";
            this.editCategoryButton.Size = new System.Drawing.Size(162, 23);
            this.editCategoryButton.TabIndex = 4;
            this.editCategoryButton.Text = "Edit";
            this.editCategoryButton.UseVisualStyleBackColor = true;
            this.editCategoryButton.Click += new System.EventHandler(this.editCategoryButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.ForeColor = System.Drawing.Color.White;
            this.deleteButton.Location = new System.Drawing.Point(343, 309);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(162, 23);
            this.deleteButton.TabIndex = 5;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(326, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 30);
            this.label4.TabIndex = 6;
            this.label4.Text = "Categories Menu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(216, 30);
            this.label5.TabIndex = 8;
            this.label5.Text = "Insert Category Name";
            // 
            // categoryNameTextBox
            // 
            this.categoryNameTextBox.Location = new System.Drawing.Point(343, 99);
            this.categoryNameTextBox.Name = "categoryNameTextBox";
            this.categoryNameTextBox.Size = new System.Drawing.Size(162, 23);
            this.categoryNameTextBox.TabIndex = 9;
            // 
            // dataCategoriesGridView
            // 
            this.dataCategoriesGridView.AllowUserToAddRows = false;
            this.dataCategoriesGridView.AllowUserToDeleteRows = false;
            this.dataCategoriesGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataCategoriesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCategoriesGridView.Location = new System.Drawing.Point(534, 99);
            this.dataCategoriesGridView.Name = "dataCategoriesGridView";
            this.dataCategoriesGridView.RowTemplate.Height = 25;
            this.dataCategoriesGridView.Size = new System.Drawing.Size(333, 424);
            this.dataCategoriesGridView.TabIndex = 10;
            this.dataCategoriesGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataCategoriesGridView_RowHeaderMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 30);
            this.label1.TabIndex = 11;
            this.label1.Text = "Create Category";
            // 
            // goToNotesMenu
            // 
            this.goToNotesMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goToNotesMenu.ForeColor = System.Drawing.Color.White;
            this.goToNotesMenu.Location = new System.Drawing.Point(343, 500);
            this.goToNotesMenu.Name = "goToNotesMenu";
            this.goToNotesMenu.Size = new System.Drawing.Size(162, 23);
            this.goToNotesMenu.TabIndex = 12;
            this.goToNotesMenu.Text = "Create Note";
            this.goToNotesMenu.UseVisualStyleBackColor = true;
            this.goToNotesMenu.Click += new System.EventHandler(this.goToNotesMenu_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(12, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 30);
            this.label6.TabIndex = 13;
            this.label6.Text = "Insert User Id";
            // 
            // userIdTextBox
            // 
            this.userIdTextBox.Location = new System.Drawing.Point(343, 139);
            this.userIdTextBox.Name = "userIdTextBox";
            this.userIdTextBox.Size = new System.Drawing.Size(162, 23);
            this.userIdTextBox.TabIndex = 14;
            // 
            // categoriesMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(907, 599);
            this.Controls.Add(this.userIdTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.goToNotesMenu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataCategoriesGridView);
            this.Controls.Add(this.categoryNameTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editCategoryButton);
            this.Controls.Add(this.categoriesCreateButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "categoriesMenu";
            this.Text = "Categories Menu";
            ((System.ComponentModel.ISupportInitialize)(this.dataCategoriesGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button categoriesCreateButton;
        private System.Windows.Forms.Button editCategoryButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox categoryNameTextBox;
        private System.Windows.Forms.DataGridView dataCategoriesGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button goToNotesMenu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox userIdTextBox;
    }
}