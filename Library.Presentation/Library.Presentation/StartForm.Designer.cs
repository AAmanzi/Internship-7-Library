namespace Library.Presentation
{
    partial class StartForm
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
            this.ManageButton = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.ViewButton = new System.Windows.Forms.Button();
            this.RentButton = new System.Windows.Forms.Button();
            this.RentReturnButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ManageButton
            // 
            this.ManageButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ManageButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.ManageButton.FlatAppearance.BorderSize = 0;
            this.ManageButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod;
            this.ManageButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod;
            this.ManageButton.Font = new System.Drawing.Font("Lucida Sans Typewriter", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ManageButton.Location = new System.Drawing.Point(13, 56);
            this.ManageButton.Name = "ManageButton";
            this.ManageButton.Size = new System.Drawing.Size(191, 69);
            this.ManageButton.TabIndex = 0;
            this.ManageButton.Text = "Manage";
            this.ManageButton.UseVisualStyleBackColor = false;
            this.ManageButton.Click += new System.EventHandler(this.ManageButton_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.Gold;
            this.TitleLabel.Location = new System.Drawing.Point(161, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(126, 31);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "LIBRARY";
            // 
            // ViewButton
            // 
            this.ViewButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ViewButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.ViewButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod;
            this.ViewButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod;
            this.ViewButton.Font = new System.Drawing.Font("Lucida Sans Typewriter", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ViewButton.Location = new System.Drawing.Point(239, 56);
            this.ViewButton.Name = "ViewButton";
            this.ViewButton.Size = new System.Drawing.Size(191, 69);
            this.ViewButton.TabIndex = 2;
            this.ViewButton.Text = "View";
            this.ViewButton.UseVisualStyleBackColor = false;
            this.ViewButton.Click += new System.EventHandler(this.ViewButton_Click);
            // 
            // RentButton
            // 
            this.RentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RentButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.RentButton.FlatAppearance.BorderSize = 0;
            this.RentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod;
            this.RentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod;
            this.RentButton.Font = new System.Drawing.Font("Lucida Sans Typewriter", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RentButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.RentButton.Location = new System.Drawing.Point(13, 161);
            this.RentButton.Name = "RentButton";
            this.RentButton.Size = new System.Drawing.Size(191, 69);
            this.RentButton.TabIndex = 3;
            this.RentButton.Text = "Rent a book";
            this.RentButton.UseVisualStyleBackColor = false;
            this.RentButton.Click += new System.EventHandler(this.RentButton_Click);
            // 
            // RentReturnButton
            // 
            this.RentReturnButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RentReturnButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.RentReturnButton.FlatAppearance.BorderSize = 0;
            this.RentReturnButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod;
            this.RentReturnButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod;
            this.RentReturnButton.Font = new System.Drawing.Font("Lucida Sans Typewriter", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RentReturnButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.RentReturnButton.Location = new System.Drawing.Point(239, 161);
            this.RentReturnButton.Name = "RentReturnButton";
            this.RentReturnButton.Size = new System.Drawing.Size(191, 69);
            this.RentReturnButton.TabIndex = 4;
            this.RentReturnButton.Text = "Return a book";
            this.RentReturnButton.UseVisualStyleBackColor = false;
            this.RentReturnButton.Click += new System.EventHandler(this.RentReturnButton_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(443, 256);
            this.Controls.Add(this.RentReturnButton);
            this.Controls.Add(this.RentButton);
            this.Controls.Add(this.ManageButton);
            this.Controls.Add(this.ViewButton);
            this.Controls.Add(this.TitleLabel);
            this.MaximizeBox = false;
            this.Name = "StartForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ManageButton;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button ViewButton;
        private System.Windows.Forms.Button RentButton;
        private System.Windows.Forms.Button RentReturnButton;
    }
}

