namespace Library.Presentation.Forms.ManageForms
{
    partial class ManagePublishersForm
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
            this.PublishersListBox = new System.Windows.Forms.CheckedListBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PublisherInfoListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // PublishersListBox
            // 
            this.PublishersListBox.CheckOnClick = true;
            this.PublishersListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PublishersListBox.FormattingEnabled = true;
            this.PublishersListBox.Location = new System.Drawing.Point(27, 80);
            this.PublishersListBox.Name = "PublishersListBox";
            this.PublishersListBox.Size = new System.Drawing.Size(313, 254);
            this.PublishersListBox.TabIndex = 20;
            this.PublishersListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.PublishersListBox_ItemCheck);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.Gold;
            this.TitleLabel.Location = new System.Drawing.Point(199, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(286, 31);
            this.TitleLabel.TabIndex = 19;
            this.TitleLabel.Text = "MANAGE PUBLISHERS";
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
            this.AddButton.Location = new System.Drawing.Point(612, 80);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(232, 69);
            this.AddButton.TabIndex = 18;
            this.AddButton.Text = "Add publisher";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
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
            this.EditButton.Location = new System.Drawing.Point(612, 173);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(232, 69);
            this.EditButton.TabIndex = 17;
            this.EditButton.Text = "Edit publisher";
            this.EditButton.UseVisualStyleBackColor = false;
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
            this.DeleteButton.Location = new System.Drawing.Point(612, 265);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(232, 69);
            this.DeleteButton.TabIndex = 16;
            this.DeleteButton.Text = "Delete publisher";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(435, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 31);
            this.label1.TabIndex = 22;
            this.label1.Text = "Books";
            // 
            // PublisherInfoListBox
            // 
            this.PublisherInfoListBox.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PublisherInfoListBox.FormattingEnabled = true;
            this.PublisherInfoListBox.ItemHeight = 23;
            this.PublisherInfoListBox.Location = new System.Drawing.Point(361, 123);
            this.PublisherInfoListBox.Name = "PublisherInfoListBox";
            this.PublisherInfoListBox.Size = new System.Drawing.Size(232, 211);
            this.PublisherInfoListBox.TabIndex = 21;
            // 
            // ManagePublishersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 363);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PublisherInfoListBox);
            this.Controls.Add(this.PublishersListBox);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.DeleteButton);
            this.Name = "ManagePublishersForm";
            this.Text = "ManagePublishersForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox PublishersListBox;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox PublisherInfoListBox;
    }
}