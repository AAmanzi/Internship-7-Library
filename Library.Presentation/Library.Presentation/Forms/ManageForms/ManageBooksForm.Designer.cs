namespace Library.Presentation.Forms.ManageForms
{
    partial class ManageBooksForm
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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.BooksListBox = new System.Windows.Forms.CheckedListBox();
            this.BookInfoListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NumberOfCopiesToAddTextBox = new System.Windows.Forms.TextBox();
            this.AddCopiesButton = new System.Windows.Forms.Button();
            this.DeleteCopiesButton = new System.Windows.Forms.Button();
            this.NumberOfCopiesToDeleteTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.Gold;
            this.TitleLabel.Location = new System.Drawing.Point(360, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(206, 31);
            this.TitleLabel.TabIndex = 7;
            this.TitleLabel.Text = "MANAGE BOOKS";
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DeleteButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.DeleteButton.FlatAppearance.BorderSize = 0;
            this.DeleteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod;
            this.DeleteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod;
            this.DeleteButton.Font = new System.Drawing.Font("Lucida Sans Typewriter", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.DeleteButton.Location = new System.Drawing.Point(842, 338);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(175, 69);
            this.DeleteButton.TabIndex = 8;
            this.DeleteButton.Text = "Delete book";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EditButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.EditButton.FlatAppearance.BorderSize = 0;
            this.EditButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod;
            this.EditButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod;
            this.EditButton.Font = new System.Drawing.Font("Lucida Sans Typewriter", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.EditButton.Location = new System.Drawing.Point(842, 223);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(175, 69);
            this.EditButton.TabIndex = 9;
            this.EditButton.Text = "Edit book";
            this.EditButton.UseVisualStyleBackColor = false;
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.AddButton.FlatAppearance.BorderSize = 0;
            this.AddButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod;
            this.AddButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod;
            this.AddButton.Font = new System.Drawing.Font("Lucida Sans Typewriter", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.AddButton.Location = new System.Drawing.Point(842, 103);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(175, 69);
            this.AddButton.TabIndex = 10;
            this.AddButton.Text = "Add book";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // BooksListBox
            // 
            this.BooksListBox.CheckOnClick = true;
            this.BooksListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BooksListBox.FormattingEnabled = true;
            this.BooksListBox.Location = new System.Drawing.Point(24, 103);
            this.BooksListBox.Name = "BooksListBox";
            this.BooksListBox.Size = new System.Drawing.Size(423, 304);
            this.BooksListBox.TabIndex = 11;
            this.BooksListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.BooksListBox_ItemCheck);
            // 
            // BookInfoListBox
            // 
            this.BookInfoListBox.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookInfoListBox.FormattingEnabled = true;
            this.BookInfoListBox.ItemHeight = 23;
            this.BookInfoListBox.Location = new System.Drawing.Point(470, 169);
            this.BookInfoListBox.Name = "BookInfoListBox";
            this.BookInfoListBox.Size = new System.Drawing.Size(294, 96);
            this.BookInfoListBox.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(541, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 31);
            this.label1.TabIndex = 18;
            this.label1.Text = "Book info";
            // 
            // NumberOfCopiesToAddTextBox
            // 
            this.NumberOfCopiesToAddTextBox.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberOfCopiesToAddTextBox.Location = new System.Drawing.Point(668, 309);
            this.NumberOfCopiesToAddTextBox.Name = "NumberOfCopiesToAddTextBox";
            this.NumberOfCopiesToAddTextBox.Size = new System.Drawing.Size(96, 31);
            this.NumberOfCopiesToAddTextBox.TabIndex = 35;
            // 
            // AddCopiesButton
            // 
            this.AddCopiesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddCopiesButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.AddCopiesButton.FlatAppearance.BorderSize = 0;
            this.AddCopiesButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod;
            this.AddCopiesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod;
            this.AddCopiesButton.Font = new System.Drawing.Font("Lucida Sans Typewriter", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCopiesButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.AddCopiesButton.Location = new System.Drawing.Point(470, 303);
            this.AddCopiesButton.Name = "AddCopiesButton";
            this.AddCopiesButton.Size = new System.Drawing.Size(192, 41);
            this.AddCopiesButton.TabIndex = 37;
            this.AddCopiesButton.Text = "Add copies";
            this.AddCopiesButton.UseVisualStyleBackColor = false;
            this.AddCopiesButton.Click += new System.EventHandler(this.AddCopiesButton_Click);
            // 
            // DeleteCopiesButton
            // 
            this.DeleteCopiesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DeleteCopiesButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.DeleteCopiesButton.FlatAppearance.BorderSize = 0;
            this.DeleteCopiesButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod;
            this.DeleteCopiesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod;
            this.DeleteCopiesButton.Font = new System.Drawing.Font("Lucida Sans Typewriter", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteCopiesButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.DeleteCopiesButton.Location = new System.Drawing.Point(470, 366);
            this.DeleteCopiesButton.Name = "DeleteCopiesButton";
            this.DeleteCopiesButton.Size = new System.Drawing.Size(192, 41);
            this.DeleteCopiesButton.TabIndex = 39;
            this.DeleteCopiesButton.Text = "Delete copies";
            this.DeleteCopiesButton.UseVisualStyleBackColor = false;
            this.DeleteCopiesButton.Click += new System.EventHandler(this.DeleteCopiesButton_Click);
            // 
            // NumberOfCopiesToDeleteTextBox
            // 
            this.NumberOfCopiesToDeleteTextBox.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberOfCopiesToDeleteTextBox.Location = new System.Drawing.Point(668, 372);
            this.NumberOfCopiesToDeleteTextBox.Name = "NumberOfCopiesToDeleteTextBox";
            this.NumberOfCopiesToDeleteTextBox.Size = new System.Drawing.Size(96, 31);
            this.NumberOfCopiesToDeleteTextBox.TabIndex = 38;
            // 
            // ManageBooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1046, 450);
            this.Controls.Add(this.DeleteCopiesButton);
            this.Controls.Add(this.NumberOfCopiesToDeleteTextBox);
            this.Controls.Add(this.AddCopiesButton);
            this.Controls.Add(this.NumberOfCopiesToAddTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BookInfoListBox);
            this.Controls.Add(this.BooksListBox);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.TitleLabel);
            this.Name = "ManageBooksForm";
            this.Text = "ManageBooksForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.CheckedListBox BooksListBox;
        private System.Windows.Forms.ListBox BookInfoListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NumberOfCopiesToAddTextBox;
        private System.Windows.Forms.Button AddCopiesButton;
        private System.Windows.Forms.Button DeleteCopiesButton;
        private System.Windows.Forms.TextBox NumberOfCopiesToDeleteTextBox;
    }
}