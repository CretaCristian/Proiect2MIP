namespace Lab5Proiect
{
    partial class DeleteUser
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
            this.DeleteUserTextBox = new System.Windows.Forms.TextBox();
            this.DeleteUserButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID-ul utilizatorului care sa fie sters";
            // 
            // DeleteUserTextBox
            // 
            this.DeleteUserTextBox.Location = new System.Drawing.Point(259, 41);
            this.DeleteUserTextBox.Name = "DeleteUserTextBox";
            this.DeleteUserTextBox.Size = new System.Drawing.Size(100, 22);
            this.DeleteUserTextBox.TabIndex = 1;
            // 
            // DeleteUserButton
            // 
            this.DeleteUserButton.Location = new System.Drawing.Point(149, 81);
            this.DeleteUserButton.Name = "DeleteUserButton";
            this.DeleteUserButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteUserButton.TabIndex = 2;
            this.DeleteUserButton.Text = "OK";
            this.DeleteUserButton.UseVisualStyleBackColor = true;
            this.DeleteUserButton.Click += new System.EventHandler(this.DeleteUserButton_Click);
            // 
            // DeleteUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 149);
            this.Controls.Add(this.DeleteUserButton);
            this.Controls.Add(this.DeleteUserTextBox);
            this.Controls.Add(this.label1);
            this.Name = "DeleteUser";
            this.Text = "DeleteUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DeleteUserTextBox;
        private System.Windows.Forms.Button DeleteUserButton;
    }
}