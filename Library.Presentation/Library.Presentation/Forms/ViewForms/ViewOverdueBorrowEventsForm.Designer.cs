namespace Library.Presentation.Forms.ViewForms
{
    partial class ViewOverdueBorrowEventsForm
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
            this.OverdueBorrowEventsListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.Gold;
            this.TitleLabel.Location = new System.Drawing.Point(377, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(222, 31);
            this.TitleLabel.TabIndex = 22;
            this.TitleLabel.Text = "OVERDUE RENTS";
            // 
            // OverdueBorrowEventsListBox
            // 
            this.OverdueBorrowEventsListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.OverdueBorrowEventsListBox.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OverdueBorrowEventsListBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.OverdueBorrowEventsListBox.FormattingEnabled = true;
            this.OverdueBorrowEventsListBox.ItemHeight = 23;
            this.OverdueBorrowEventsListBox.Location = new System.Drawing.Point(12, 58);
            this.OverdueBorrowEventsListBox.Name = "OverdueBorrowEventsListBox";
            this.OverdueBorrowEventsListBox.Size = new System.Drawing.Size(981, 349);
            this.OverdueBorrowEventsListBox.TabIndex = 21;
            // 
            // ViewOverdueBorrowEventsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1007, 429);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.OverdueBorrowEventsListBox);
            this.Name = "ViewOverdueBorrowEventsForm";
            this.Text = "ViewOverdueRentsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.ListBox OverdueBorrowEventsListBox;
    }
}