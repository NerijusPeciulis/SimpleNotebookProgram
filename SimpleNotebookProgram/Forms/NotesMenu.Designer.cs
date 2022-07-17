namespace SimpleNotebookProgram.Forms
{
    partial class notesMenu
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
            this.label7 = new System.Windows.Forms.Label();
            this.notesTextbox = new System.Windows.Forms.TextBox();
            this.noteSearchTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.noteNameTextbox = new System.Windows.Forms.TextBox();
            this.noteNameLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.noteDescription = new System.Windows.Forms.TextBox();
            this.dataNotesGridView = new System.Windows.Forms.DataGridView();
            this.backToCategoriesMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataNotesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(396, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 30);
            this.label4.TabIndex = 13;
            this.label4.Text = "Notes Menu";
            // 
            // deleteNoteButton
            // 
            this.deleteNoteButton.Location = new System.Drawing.Point(193, 478);
            this.deleteNoteButton.Name = "deleteNoteButton";
            this.deleteNoteButton.Size = new System.Drawing.Size(162, 23);
            this.deleteNoteButton.TabIndex = 12;
            this.deleteNoteButton.Text = "Delete";
            this.deleteNoteButton.UseVisualStyleBackColor = true;
            this.deleteNoteButton.Click += new System.EventHandler(this.deleteNoteButton_Click);
            // 
            // editNoteButton
            // 
            this.editNoteButton.Location = new System.Drawing.Point(193, 426);
            this.editNoteButton.Name = "editNoteButton";
            this.editNoteButton.Size = new System.Drawing.Size(162, 23);
            this.editNoteButton.TabIndex = 11;
            this.editNoteButton.Text = "Edit";
            this.editNoteButton.UseVisualStyleBackColor = true;
            this.editNoteButton.Click += new System.EventHandler(this.editNoteButton_Click);
            // 
            // createNoteButton
            // 
            this.createNoteButton.Location = new System.Drawing.Point(193, 84);
            this.createNoteButton.Name = "createNoteButton";
            this.createNoteButton.Size = new System.Drawing.Size(162, 23);
            this.createNoteButton.TabIndex = 10;
            this.createNoteButton.Text = "Create";
            this.createNoteButton.UseVisualStyleBackColor = true;
            this.createNoteButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 419);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 30);
            this.label3.TabIndex = 9;
            this.label3.Text = "Edit Note";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 471);
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(12, 532);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 30);
            this.label7.TabIndex = 19;
            this.label7.Text = "Search Note";
            // 
            // notesTextbox
            // 
            this.notesTextbox.Location = new System.Drawing.Point(561, 77);
            this.notesTextbox.Multiline = true;
            this.notesTextbox.Name = "notesTextbox";
            this.notesTextbox.Size = new System.Drawing.Size(437, 462);
            this.notesTextbox.TabIndex = 20;
            // 
            // noteSearchTextBox
            // 
            this.noteSearchTextBox.Location = new System.Drawing.Point(193, 539);
            this.noteSearchTextBox.Name = "noteSearchTextBox";
            this.noteSearchTextBox.Size = new System.Drawing.Size(162, 23);
            this.noteSearchTextBox.TabIndex = 21;
            this.noteSearchTextBox.TextChanged += new System.EventHandler(this.noteSearchTextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 30);
            this.label5.TabIndex = 23;
            this.label5.Text = "Note Name";
            // 
            // noteNameTextbox
            // 
            this.noteNameTextbox.Location = new System.Drawing.Point(193, 130);
            this.noteNameTextbox.Name = "noteNameTextbox";
            this.noteNameTextbox.Size = new System.Drawing.Size(162, 23);
            this.noteNameTextbox.TabIndex = 24;
            // 
            // noteNameLabel
            // 
            this.noteNameLabel.AutoSize = true;
            this.noteNameLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.noteNameLabel.Location = new System.Drawing.Point(710, 44);
            this.noteNameLabel.Name = "noteNameLabel";
            this.noteNameLabel.Size = new System.Drawing.Size(125, 30);
            this.noteNameLabel.TabIndex = 25;
            this.noteNameLabel.Text = "Create Note";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(12, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(170, 30);
            this.label8.TabIndex = 26;
            this.label8.Text = "Note Description";
            // 
            // noteDescription
            // 
            this.noteDescription.Location = new System.Drawing.Point(193, 175);
            this.noteDescription.Name = "noteDescription";
            this.noteDescription.Size = new System.Drawing.Size(162, 23);
            this.noteDescription.TabIndex = 27;
            // 
            // dataNotesGridView
            // 
            this.dataNotesGridView.AllowUserToDeleteRows = false;
            this.dataNotesGridView.AllowUserToOrderColumns = true;
            this.dataNotesGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataNotesGridView.Location = new System.Drawing.Point(12, 204);
            this.dataNotesGridView.Name = "dataNotesGridView";
            this.dataNotesGridView.RowTemplate.Height = 25;
            this.dataNotesGridView.Size = new System.Drawing.Size(534, 212);
            this.dataNotesGridView.TabIndex = 28;
            this.dataNotesGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataNotesGridView_RowHeaderMouseClick);
            // 
            // backToCategoriesMenu
            // 
            this.backToCategoriesMenu.Location = new System.Drawing.Point(368, 589);
            this.backToCategoriesMenu.Name = "backToCategoriesMenu";
            this.backToCategoriesMenu.Size = new System.Drawing.Size(162, 23);
            this.backToCategoriesMenu.TabIndex = 29;
            this.backToCategoriesMenu.Text = "Back To Categories";
            this.backToCategoriesMenu.UseVisualStyleBackColor = true;
            this.backToCategoriesMenu.Click += new System.EventHandler(this.backToCategoriesMenu_Click);
            // 
            // NotesMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 636);
            this.Controls.Add(this.backToCategoriesMenu);
            this.Controls.Add(this.dataNotesGridView);
            this.Controls.Add(this.noteDescription);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.noteNameLabel);
            this.Controls.Add(this.noteNameTextbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.noteSearchTextBox);
            this.Controls.Add(this.notesTextbox);
            this.Controls.Add(this.label7);
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox notesTextbox;
        private System.Windows.Forms.TextBox noteSearchTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox noteNameTextbox;
        private System.Windows.Forms.Label noteNameLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox noteDescription;
        private System.Windows.Forms.DataGridView dataNotesGridView;
        private System.Windows.Forms.Button backToCategoriesMenu;
    }
}