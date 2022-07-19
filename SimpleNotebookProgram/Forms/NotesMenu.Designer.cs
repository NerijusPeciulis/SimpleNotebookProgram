namespace SimpleNotebookProgram.Forms
{
    partial class NotesMenu
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
            this.label4 = new System.Windows.Forms.Label();
            this.deleteNoteButton = new System.Windows.Forms.Button();
            this.editNoteButton = new System.Windows.Forms.Button();
            this.createNoteButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.noteSearchTextBox = new System.Windows.Forms.TextBox();
            this.noteNameTextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.noteDescription = new System.Windows.Forms.TextBox();
            this.backToCategoriesMenu = new System.Windows.Forms.Button();
            this.dataNotesGridView = new System.Windows.Forms.DataGridView();
            this.addImageButton = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataNotesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(378, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 32);
            this.label4.TabIndex = 13;
            this.label4.Text = "Notes Menu";
            // 
            // deleteNoteButton
            // 
            this.deleteNoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteNoteButton.ForeColor = System.Drawing.Color.White;
            this.deleteNoteButton.Location = new System.Drawing.Point(370, 501);
            this.deleteNoteButton.Name = "deleteNoteButton";
            this.deleteNoteButton.Size = new System.Drawing.Size(162, 23);
            this.deleteNoteButton.TabIndex = 12;
            this.deleteNoteButton.Text = "Delete";
            this.deleteNoteButton.UseVisualStyleBackColor = true;
            this.deleteNoteButton.Click += new System.EventHandler(this.deleteNoteButton_Click);
            // 
            // editNoteButton
            // 
            this.editNoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editNoteButton.ForeColor = System.Drawing.Color.White;
            this.editNoteButton.Location = new System.Drawing.Point(370, 453);
            this.editNoteButton.Name = "editNoteButton";
            this.editNoteButton.Size = new System.Drawing.Size(162, 23);
            this.editNoteButton.TabIndex = 11;
            this.editNoteButton.Text = "Edit";
            this.editNoteButton.UseVisualStyleBackColor = true;
            this.editNoteButton.Click += new System.EventHandler(this.editNoteButton_Click);
            // 
            // createNoteButton
            // 
            this.createNoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createNoteButton.ForeColor = System.Drawing.Color.White;
            this.createNoteButton.Location = new System.Drawing.Point(370, 84);
            this.createNoteButton.Name = "createNoteButton";
            this.createNoteButton.Size = new System.Drawing.Size(162, 23);
            this.createNoteButton.TabIndex = 10;
            this.createNoteButton.Text = "Create";
            this.createNoteButton.UseVisualStyleBackColor = true;
            this.createNoteButton.Click += new System.EventHandler(this.createNoteButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 446);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 30);
            this.label3.TabIndex = 9;
            this.label3.Text = "Edit Note";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 493);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 30);
            this.label2.TabIndex = 8;
            this.label2.Text = "Delete Note";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 30);
            this.label1.TabIndex = 7;
            this.label1.Text = "Create Note";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(14, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 30);
            this.label6.TabIndex = 18;
            this.label6.Text = "Note Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(14, 536);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 30);
            this.label7.TabIndex = 19;
            this.label7.Text = "Search Note";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(553, 77);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(436, 491);
            this.textBox1.TabIndex = 20;
            // 
            // noteSearchTextBox
            // 
            this.noteSearchTextBox.Location = new System.Drawing.Point(370, 545);
            this.noteSearchTextBox.Name = "noteSearchTextBox";
            this.noteSearchTextBox.Size = new System.Drawing.Size(162, 23);
            this.noteSearchTextBox.TabIndex = 21;
            this.noteSearchTextBox.TextChanged += new System.EventHandler(this.noteSearchTextBox_TextChanged);
            // 
            // noteNameTextbox
            // 
            this.noteNameTextbox.Location = new System.Drawing.Point(370, 140);
            this.noteNameTextbox.Name = "noteNameTextbox";
            this.noteNameTextbox.Size = new System.Drawing.Size(162, 23);
            this.noteNameTextbox.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(14, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 30);
            this.label5.TabIndex = 23;
            this.label5.Text = "Note Description";
            // 
            // noteDescription
            // 
            this.noteDescription.Location = new System.Drawing.Point(370, 191);
            this.noteDescription.Name = "noteDescription";
            this.noteDescription.Size = new System.Drawing.Size(162, 23);
            this.noteDescription.TabIndex = 24;
            // 
            // backToCategoriesMenu
            // 
            this.backToCategoriesMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backToCategoriesMenu.ForeColor = System.Drawing.Color.White;
            this.backToCategoriesMenu.Location = new System.Drawing.Point(370, 589);
            this.backToCategoriesMenu.Name = "backToCategoriesMenu";
            this.backToCategoriesMenu.Size = new System.Drawing.Size(162, 23);
            this.backToCategoriesMenu.TabIndex = 25;
            this.backToCategoriesMenu.Text = "Back To Categories";
            this.backToCategoriesMenu.UseVisualStyleBackColor = true;
            this.backToCategoriesMenu.Click += new System.EventHandler(this.backToCategoriesMenu_Click);
            // 
            // dataNotesGridView
            // 
            this.dataNotesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataNotesGridView.Location = new System.Drawing.Point(14, 230);
            this.dataNotesGridView.Name = "dataNotesGridView";
            this.dataNotesGridView.RowTemplate.Height = 25;
            this.dataNotesGridView.Size = new System.Drawing.Size(518, 200);
            this.dataNotesGridView.TabIndex = 26;
            this.dataNotesGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataNotesGridView_RowHeaderMouseClick);
            // 
            // addImageButton
            // 
            this.addImageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addImageButton.ForeColor = System.Drawing.Color.White;
            this.addImageButton.Location = new System.Drawing.Point(704, 518);
            this.addImageButton.Name = "addImageButton";
            this.addImageButton.Size = new System.Drawing.Size(162, 23);
            this.addImageButton.TabIndex = 27;
            this.addImageButton.Text = "Add Image";
            this.addImageButton.UseVisualStyleBackColor = true;
            this.addImageButton.Click += new System.EventHandler(this.addImageButton_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(704, 334);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(162, 162);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 28;
            this.pictureBox.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // NotesMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1010, 636);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.addImageButton);
            this.Controls.Add(this.dataNotesGridView);
            this.Controls.Add(this.backToCategoriesMenu);
            this.Controls.Add(this.noteDescription);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.noteNameTextbox);
            this.Controls.Add(this.noteSearchTextBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.deleteNoteButton);
            this.Controls.Add(this.editNoteButton);
            this.Controls.Add(this.createNoteButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NotesMenu";
            this.Text = "NotesMenu";
            this.Load += new System.EventHandler(this.NotesMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataNotesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button deleteNoteButton;
        private System.Windows.Forms.Button editNoteButton;
        private System.Windows.Forms.Button createNoteButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox noteSearchTextBox;
        private System.Windows.Forms.TextBox noteNameTextbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox noteDescription;
        private System.Windows.Forms.Button backToCategoriesMenu;
        private System.Windows.Forms.DataGridView dataNotesGridView;
        private System.Windows.Forms.Button addImageButton;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}