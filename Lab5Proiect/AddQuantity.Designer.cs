namespace Lab5Proiect
{
    partial class AddQuantity
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
            this.label2 = new System.Windows.Forms.Label();
            this.IdProdusTextBox = new System.Windows.Forms.TextBox();
            this.CantitateDeAdaugatTextBox = new System.Windows.Forms.TextBox();
            this.AddCantitateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Produs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cantitate de adaugat";
            // 
            // IdProdusTextBox
            // 
            this.IdProdusTextBox.Location = new System.Drawing.Point(137, 18);
            this.IdProdusTextBox.Name = "IdProdusTextBox";
            this.IdProdusTextBox.Size = new System.Drawing.Size(100, 22);
            this.IdProdusTextBox.TabIndex = 2;
            // 
            // CantitateDeAdaugatTextBox
            // 
            this.CantitateDeAdaugatTextBox.Location = new System.Drawing.Point(137, 63);
            this.CantitateDeAdaugatTextBox.Name = "CantitateDeAdaugatTextBox";
            this.CantitateDeAdaugatTextBox.Size = new System.Drawing.Size(100, 22);
            this.CantitateDeAdaugatTextBox.TabIndex = 3;
            // 
            // AddCantitateButton
            // 
            this.AddCantitateButton.Location = new System.Drawing.Point(149, 106);
            this.AddCantitateButton.Name = "AddCantitateButton";
            this.AddCantitateButton.Size = new System.Drawing.Size(75, 23);
            this.AddCantitateButton.TabIndex = 4;
            this.AddCantitateButton.Text = "Add";
            this.AddCantitateButton.UseVisualStyleBackColor = true;
            this.AddCantitateButton.Click += new System.EventHandler(this.AddCantitateButton_Click);
            // 
            // AddQuantity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 274);
            this.Controls.Add(this.AddCantitateButton);
            this.Controls.Add(this.CantitateDeAdaugatTextBox);
            this.Controls.Add(this.IdProdusTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddQuantity";
            this.Text = "AddQuantity";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IdProdusTextBox;
        private System.Windows.Forms.TextBox CantitateDeAdaugatTextBox;
        private System.Windows.Forms.Button AddCantitateButton;
    }
}