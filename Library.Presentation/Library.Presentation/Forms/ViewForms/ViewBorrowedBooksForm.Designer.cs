namespace Library.Presentation.Forms.ViewForms
{
    partial class ViewBorrowedBooksForm
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
            this.BookInfoListBox = new System.Windows.Forms.ListBox();
            this.BooksListBox = new System.Windows.Forms.CheckedListBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(709, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 90);
            this.label1.TabIndex = 22;
            this.label1.Text = "Students that have a copy of the book";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BookInfoListBox
            // 
            this.BookInfoListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BookInfoListBox.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookInfoListBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BookInfoListBox.FormattingEnabled = true;
            this.BookInfoListBox.ItemHeight = 23;
            this.BookInfoListBox.Location = new System.Drawing.Point(709, 178);
            this.BookInfoListBox.Name = "BookInfoListBox";
            this.BookInfoListBox.Size = new System.Drawing.Size(354, 211);
            this.BookInfoListBox.TabIndex = 21;
            // 
            // BooksListBox
            // 
            this.BooksListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BooksListBox.CheckOnClick = true;
            this.BooksListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BooksListBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BooksListBox.FormattingEnabled = true;
            this.BooksListBox.Location = new System.Drawing.Point(23, 85);
            this.BooksListBox.Name = "BooksListBox";
            this.BooksListBox.Size = new System.Drawing.Size(644, 304);
            this.BooksListBox.TabIndex = 20;
            this.BooksListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.BooksListBox_ItemCheck);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.Gold;
            this.TitleLabel.Location = new System.Drawing.Point(429, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(238, 31);
            this.TitleLabel.TabIndex = 19;
            this.TitleLabel.Text = "BORROWED BOOKS";
            // 
            // ViewBorrowedBooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1100, 430);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BookInfoListBox);
            this.Controls.Add(this.BooksListBox);
            this.Controls.Add(this.TitleLabel);
            this.Name = "ViewBorrowedBooksForm";
            this.Text = "ViewBorrowedBooks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox BookInfoListBox;
        private System.Windows.Forms.CheckedListBox BooksListBox;
        private System.Windows.Forms.Label TitleLabel;
    }
}