namespace Library.Presentation.Forms.ViewForms
{
    partial class ViewCurrentBorrowEventsForm
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
            this.CurrentBorrowEventsListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.Gold;
            this.TitleLabel.Location = new System.Drawing.Point(397, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(222, 31);
            this.TitleLabel.TabIndex = 20;
            this.TitleLabel.Text = "CURRENT RENTS";
            // 
            // CurrentBorrowEventsListBox
            // 
            this.CurrentBorrowEventsListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CurrentBorrowEventsListBox.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentBorrowEventsListBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.CurrentBorrowEventsListBox.FormattingEnabled = true;
            this.CurrentBorrowEventsListBox.ItemHeight = 23;
            this.CurrentBorrowEventsListBox.Location = new System.Drawing.Point(23, 68);
            this.CurrentBorrowEventsListBox.Name = "CurrentBorrowEventsListBox";
            this.CurrentBorrowEventsListBox.Size = new System.Drawing.Size(981, 349);
            this.CurrentBorrowEventsListBox.TabIndex = 19;
            // 
            // ViewCurrentBorrowEventsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1016, 442);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.CurrentBorrowEventsListBox);
            this.Name = "ViewCurrentBorrowEventsForm";
            this.Text = "ViewCurrentRentsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.ListBox CurrentBorrowEventsListBox;
    }
}