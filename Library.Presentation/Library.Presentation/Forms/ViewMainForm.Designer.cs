namespace Library.Presentation.Forms
{
    partial class ViewMainForm
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
            this.CurrentBorrowEventsButton = new System.Windows.Forms.Button();
            this.ReadOnlyBooksButton = new System.Windows.Forms.Button();
            this.BorrowedBooksButton = new System.Windows.Forms.Button();
            this.OverdueBorrowEventsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.Gold;
            this.TitleLabel.Location = new System.Drawing.Point(253, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(78, 31);
            this.TitleLabel.TabIndex = 11;
            this.TitleLabel.Text = "VIEW";
            // 
            // CurrentBorrowEventsButton
            // 
            this.CurrentBorrowEventsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CurrentBorrowEventsButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.CurrentBorrowEventsButton.FlatAppearance.BorderSize = 0;
            this.CurrentBorrowEventsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod;
            this.CurrentBorrowEventsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod;
            this.CurrentBorrowEventsButton.Font = new System.Drawing.Font("Lucida Sans Typewriter", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentBorrowEventsButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.CurrentBorrowEventsButton.Location = new System.Drawing.Point(26, 201);
            this.CurrentBorrowEventsButton.Name = "CurrentBorrowEventsButton";
            this.CurrentBorrowEventsButton.Size = new System.Drawing.Size(249, 69);
            this.CurrentBorrowEventsButton.TabIndex = 10;
            this.CurrentBorrowEventsButton.Text = "Current rents by students";
            this.CurrentBorrowEventsButton.UseVisualStyleBackColor = false;
            this.CurrentBorrowEventsButton.Click += new System.EventHandler(this.CurrentBorrowEventsButton_Click);
            // 
            // ReadOnlyBooksButton
            // 
            this.ReadOnlyBooksButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ReadOnlyBooksButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.ReadOnlyBooksButton.FlatAppearance.BorderSize = 0;
            this.ReadOnlyBooksButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod;
            this.ReadOnlyBooksButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod;
            this.ReadOnlyBooksButton.Font = new System.Drawing.Font("Lucida Sans Typewriter", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReadOnlyBooksButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ReadOnlyBooksButton.Location = new System.Drawing.Point(311, 63);
            this.ReadOnlyBooksButton.Name = "ReadOnlyBooksButton";
            this.ReadOnlyBooksButton.Size = new System.Drawing.Size(249, 69);
            this.ReadOnlyBooksButton.TabIndex = 9;
            this.ReadOnlyBooksButton.Text = "Books that cannot be rented";
            this.ReadOnlyBooksButton.UseVisualStyleBackColor = false;
            this.ReadOnlyBooksButton.Click += new System.EventHandler(this.ReadOnlyBooksButton_Click);
            // 
            // BorrowedBooksButton
            // 
            this.BorrowedBooksButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BorrowedBooksButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.BorrowedBooksButton.FlatAppearance.BorderSize = 0;
            this.BorrowedBooksButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod;
            this.BorrowedBooksButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod;
            this.BorrowedBooksButton.Font = new System.Drawing.Font("Lucida Sans Typewriter", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BorrowedBooksButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BorrowedBooksButton.Location = new System.Drawing.Point(26, 63);
            this.BorrowedBooksButton.Name = "BorrowedBooksButton";
            this.BorrowedBooksButton.Size = new System.Drawing.Size(249, 69);
            this.BorrowedBooksButton.TabIndex = 8;
            this.BorrowedBooksButton.Text = "Borrowed books";
            this.BorrowedBooksButton.UseVisualStyleBackColor = false;
            this.BorrowedBooksButton.Click += new System.EventHandler(this.BorrowedBooksButton_Click);
            // 
            // OverdueBorrowEventsButton
            // 
            this.OverdueBorrowEventsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.OverdueBorrowEventsButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.OverdueBorrowEventsButton.FlatAppearance.BorderSize = 0;
            this.OverdueBorrowEventsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod;
            this.OverdueBorrowEventsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod;
            this.OverdueBorrowEventsButton.Font = new System.Drawing.Font("Lucida Sans Typewriter", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OverdueBorrowEventsButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.OverdueBorrowEventsButton.Location = new System.Drawing.Point(311, 201);
            this.OverdueBorrowEventsButton.Name = "OverdueBorrowEventsButton";
            this.OverdueBorrowEventsButton.Size = new System.Drawing.Size(249, 69);
            this.OverdueBorrowEventsButton.TabIndex = 7;
            this.OverdueBorrowEventsButton.Text = "Overdue rents";
            this.OverdueBorrowEventsButton.UseVisualStyleBackColor = false;
            this.OverdueBorrowEventsButton.Click += new System.EventHandler(this.OverdueBorrowEventsButton_Click);
            // 
            // ViewMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(586, 307);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.CurrentBorrowEventsButton);
            this.Controls.Add(this.ReadOnlyBooksButton);
            this.Controls.Add(this.BorrowedBooksButton);
            this.Controls.Add(this.OverdueBorrowEventsButton);
            this.Name = "ViewMainForm";
            this.Text = "ViewMainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button CurrentBorrowEventsButton;
        private System.Windows.Forms.Button ReadOnlyBooksButton;
        private System.Windows.Forms.Button BorrowedBooksButton;
        private System.Windows.Forms.Button OverdueBorrowEventsButton;
    }
}