namespace Library.Presentation.Forms.EditForms
{
    partial class EditStudentForm
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
            this.CancelButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ClassComboBox = new System.Windows.Forms.ComboBox();
            this.SexComboBox = new System.Windows.Forms.ComboBox();
            this.ClassLabel = new System.Windows.Forms.Label();
            this.SexLabel = new System.Windows.Forms.Label();
            this.DateOfBirthLabel = new System.Windows.Forms.Label();
            this.DateOfBirthPicker = new System.Windows.Forms.DateTimePicker();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CancelButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.CancelButton.FlatAppearance.BorderSize = 0;
            this.CancelButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod;
            this.CancelButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod;
            this.CancelButton.Font = new System.Drawing.Font("Lucida Sans Typewriter", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.CancelButton.Location = new System.Drawing.Point(547, 259);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(125, 69);
            this.CancelButton.TabIndex = 45;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
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
            this.SaveButton.Location = new System.Drawing.Point(547, 151);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(125, 69);
            this.SaveButton.TabIndex = 44;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ClassComboBox
            // 
            this.ClassComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ClassComboBox.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassComboBox.FormattingEnabled = true;
            this.ClassComboBox.Location = new System.Drawing.Point(214, 297);
            this.ClassComboBox.Name = "ClassComboBox";
            this.ClassComboBox.Size = new System.Drawing.Size(239, 31);
            this.ClassComboBox.TabIndex = 43;
            // 
            // SexComboBox
            // 
            this.SexComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SexComboBox.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SexComboBox.FormattingEnabled = true;
            this.SexComboBox.Location = new System.Drawing.Point(213, 242);
            this.SexComboBox.Name = "SexComboBox";
            this.SexComboBox.Size = new System.Drawing.Size(239, 31);
            this.SexComboBox.TabIndex = 42;
            // 
            // ClassLabel
            // 
            this.ClassLabel.AutoSize = true;
            this.ClassLabel.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ClassLabel.Location = new System.Drawing.Point(32, 305);
            this.ClassLabel.Name = "ClassLabel";
            this.ClassLabel.Size = new System.Drawing.Size(70, 23);
            this.ClassLabel.TabIndex = 41;
            this.ClassLabel.Text = "Class";
            // 
            // SexLabel
            // 
            this.SexLabel.AutoSize = true;
            this.SexLabel.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SexLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.SexLabel.Location = new System.Drawing.Point(32, 250);
            this.SexLabel.Name = "SexLabel";
            this.SexLabel.Size = new System.Drawing.Size(46, 23);
            this.SexLabel.TabIndex = 40;
            this.SexLabel.Text = "Sex";
            // 
            // DateOfBirthLabel
            // 
            this.DateOfBirthLabel.AutoSize = true;
            this.DateOfBirthLabel.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateOfBirthLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.DateOfBirthLabel.Location = new System.Drawing.Point(32, 195);
            this.DateOfBirthLabel.Name = "DateOfBirthLabel";
            this.DateOfBirthLabel.Size = new System.Drawing.Size(166, 23);
            this.DateOfBirthLabel.TabIndex = 39;
            this.DateOfBirthLabel.Text = "Date of birth";
            // 
            // DateOfBirthPicker
            // 
            this.DateOfBirthPicker.CalendarFont = new System.Drawing.Font("Lucida Sans Typewriter", 15F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateOfBirthPicker.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateOfBirthPicker.Location = new System.Drawing.Point(213, 189);
            this.DateOfBirthPicker.MinDate = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            this.DateOfBirthPicker.Name = "DateOfBirthPicker";
            this.DateOfBirthPicker.Size = new System.Drawing.Size(240, 31);
            this.DateOfBirthPicker.TabIndex = 38;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.LastNameLabel.Location = new System.Drawing.Point(32, 141);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(118, 23);
            this.LastNameLabel.TabIndex = 37;
            this.LastNameLabel.Text = "Last name";
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameTextBox.Location = new System.Drawing.Point(213, 133);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(240, 31);
            this.LastNameTextBox.TabIndex = 36;
            this.LastNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LastNameTextBox_KeyPress);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.NameLabel.Location = new System.Drawing.Point(32, 81);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(58, 23);
            this.NameLabel.TabIndex = 35;
            this.NameLabel.Text = "Name";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTextBox.Location = new System.Drawing.Point(213, 73);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(240, 31);
            this.NameTextBox.TabIndex = 34;
            this.NameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameTextBox_KeyPress);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.Gold;
            this.TitleLabel.Location = new System.Drawing.Point(297, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(206, 31);
            this.TitleLabel.TabIndex = 33;
            this.TitleLabel.Text = "EDIT STUDENT";
            // 
            // EditStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(712, 355);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.ClassComboBox);
            this.Controls.Add(this.SexComboBox);
            this.Controls.Add(this.ClassLabel);
            this.Controls.Add(this.SexLabel);
            this.Controls.Add(this.DateOfBirthLabel);
            this.Controls.Add(this.DateOfBirthPicker);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.TitleLabel);
            this.Name = "EditStudentForm";
            this.Text = "EditStudentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private new System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.ComboBox ClassComboBox;
        private System.Windows.Forms.ComboBox SexComboBox;
        private System.Windows.Forms.Label ClassLabel;
        private System.Windows.Forms.Label SexLabel;
        private System.Windows.Forms.Label DateOfBirthLabel;
        private System.Windows.Forms.DateTimePicker DateOfBirthPicker;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label TitleLabel;
    }
}