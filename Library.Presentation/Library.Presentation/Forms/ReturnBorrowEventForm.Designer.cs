namespace Library.Presentation.Forms
{
    partial class ReturnBorrowEventForm
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
            this.DateOfReturnLabel = new System.Windows.Forms.Label();
            this.DateOfReturnPicker = new System.Windows.Forms.DateTimePicker();
            this.BooksListBox = new System.Windows.Forms.CheckedListBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.StudentComboBox = new System.Windows.Forms.ComboBox();
            this.StudentLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.DateOfRentLabel = new System.Windows.Forms.Label();
            this.DateOfRentTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // DateOfReturnLabel
            // 
            this.DateOfReturnLabel.AutoSize = true;
            this.DateOfReturnLabel.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateOfReturnLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.DateOfReturnLabel.Location = new System.Drawing.Point(65, 202);
            this.DateOfReturnLabel.Name = "DateOfReturnLabel";
            this.DateOfReturnLabel.Size = new System.Drawing.Size(178, 23);
            this.DateOfReturnLabel.TabIndex = 62;
            this.DateOfReturnLabel.Text = "Date of return";
            // 
            // DateOfReturnPicker
            // 
            this.DateOfReturnPicker.CalendarFont = new System.Drawing.Font("Lucida Sans Typewriter", 15F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateOfReturnPicker.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateOfReturnPicker.Location = new System.Drawing.Point(251, 194);
            this.DateOfReturnPicker.Name = "DateOfReturnPicker";
            this.DateOfReturnPicker.Size = new System.Drawing.Size(316, 31);
            this.DateOfReturnPicker.TabIndex = 61;
            // 
            // BooksListBox
            // 
            this.BooksListBox.CheckOnClick = true;
            this.BooksListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BooksListBox.FormattingEnabled = true;
            this.BooksListBox.Location = new System.Drawing.Point(69, 255);
            this.BooksListBox.Name = "BooksListBox";
            this.BooksListBox.Size = new System.Drawing.Size(498, 179);
            this.BooksListBox.TabIndex = 60;
            this.BooksListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.BooksListBox_ItemCheck);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ExitButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod;
            this.ExitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod;
            this.ExitButton.Font = new System.Drawing.Font("Lucida Sans Typewriter", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ExitButton.Location = new System.Drawing.Point(629, 433);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(125, 69);
            this.ExitButton.TabIndex = 59;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SaveButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.SaveButton.FlatAppearance.BorderSize = 0;
            this.SaveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod;
            this.SaveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod;
            this.SaveButton.Font = new System.Drawing.Font("Lucida Sans Typewriter", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.SaveButton.Location = new System.Drawing.Point(629, 325);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(125, 69);
            this.SaveButton.TabIndex = 58;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // StudentComboBox
            // 
            this.StudentComboBox.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentComboBox.FormattingEnabled = true;
            this.StudentComboBox.Location = new System.Drawing.Point(251, 119);
            this.StudentComboBox.Name = "StudentComboBox";
            this.StudentComboBox.Size = new System.Drawing.Size(316, 31);
            this.StudentComboBox.TabIndex = 57;
            this.StudentComboBox.SelectedIndexChanged += new System.EventHandler(this.StudentComboBox_SelectedIndexChanged);
            // 
            // StudentLabel
            // 
            this.StudentLabel.AutoSize = true;
            this.StudentLabel.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.StudentLabel.Location = new System.Drawing.Point(65, 127);
            this.StudentLabel.Name = "StudentLabel";
            this.StudentLabel.Size = new System.Drawing.Size(94, 23);
            this.StudentLabel.TabIndex = 56;
            this.StudentLabel.Text = "Student";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.Gold;
            this.TitleLabel.Location = new System.Drawing.Point(286, 23);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(222, 31);
            this.TitleLabel.TabIndex = 55;
            this.TitleLabel.Text = "RETURN A BOOK";
            // 
            // DateOfRentLabel
            // 
            this.DateOfRentLabel.AutoSize = true;
            this.DateOfRentLabel.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateOfRentLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.DateOfRentLabel.Location = new System.Drawing.Point(65, 479);
            this.DateOfRentLabel.Name = "DateOfRentLabel";
            this.DateOfRentLabel.Size = new System.Drawing.Size(154, 23);
            this.DateOfRentLabel.TabIndex = 63;
            this.DateOfRentLabel.Text = "Date of rent";
            // 
            // DateOfRentTextBox
            // 
            this.DateOfRentTextBox.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateOfRentTextBox.HideSelection = false;
            this.DateOfRentTextBox.Location = new System.Drawing.Point(251, 471);
            this.DateOfRentTextBox.Name = "DateOfRentTextBox";
            this.DateOfRentTextBox.ReadOnly = true;
            this.DateOfRentTextBox.Size = new System.Drawing.Size(316, 31);
            this.DateOfRentTextBox.TabIndex = 64;
            // 
            // ReturnBorrowEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 532);
            this.Controls.Add(this.DateOfRentTextBox);
            this.Controls.Add(this.DateOfRentLabel);
            this.Controls.Add(this.DateOfReturnLabel);
            this.Controls.Add(this.DateOfReturnPicker);
            this.Controls.Add(this.BooksListBox);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.StudentComboBox);
            this.Controls.Add(this.StudentLabel);
            this.Controls.Add(this.TitleLabel);
            this.Name = "ReturnBorrowEventForm";
            this.Text = "ReturnBorrowEventForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DateOfReturnLabel;
        private System.Windows.Forms.DateTimePicker DateOfReturnPicker;
        private System.Windows.Forms.CheckedListBox BooksListBox;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.ComboBox StudentComboBox;
        private System.Windows.Forms.Label StudentLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label DateOfRentLabel;
        private System.Windows.Forms.TextBox DateOfRentTextBox;
    }
}