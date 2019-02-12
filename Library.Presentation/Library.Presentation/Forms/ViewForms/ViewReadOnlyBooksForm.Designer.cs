namespace Library.Presentation.Forms.ViewForms
{
    partial class ViewReadOnlyBooksForm
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
            this.ReadOnlyBooksListBox = new System.Windows.Forms.ListBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ReadOnlyBooksListBox
            // 
            this.ReadOnlyBooksListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ReadOnlyBooksListBox.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReadOnlyBooksListBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ReadOnlyBooksListBox.FormattingEnabled = true;
            this.ReadOnlyBooksListBox.ItemHeight = 23;
            this.ReadOnlyBooksListBox.Location = new System.Drawing.Point(12, 62);
            this.ReadOnlyBooksListBox.Name = "ReadOnlyBooksListBox";
            this.ReadOnlyBooksListBox.Size = new System.Drawing.Size(776, 349);
            this.ReadOnlyBooksListBox.TabIndex = 17;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.Gold;
            this.TitleLabel.Location = new System.Drawing.Point(174, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(446, 31);
            this.TitleLabel.TabIndex = 18;
            this.TitleLabel.Text = "BOOKS THAT CANNOT BE RENTED";
            // 
            // ViewReadOnlyBooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 431);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.ReadOnlyBooksListBox);
            this.Name = "ViewReadOnlyBooksForm";
            this.Text = "ViewReadOnlyBooksForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ReadOnlyBooksListBox;
        private System.Windows.Forms.Label TitleLabel;
    }
}