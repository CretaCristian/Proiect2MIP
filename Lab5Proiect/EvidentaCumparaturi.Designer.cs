namespace Lab5Proiect
{
    partial class EvidentaCumparaturi
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
            this.dgvIstoricCumparaturi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIstoricCumparaturi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvIstoricCumparaturi
            // 
            this.dgvIstoricCumparaturi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIstoricCumparaturi.Location = new System.Drawing.Point(12, 12);
            this.dgvIstoricCumparaturi.Name = "dgvIstoricCumparaturi";
            this.dgvIstoricCumparaturi.RowHeadersWidth = 51;
            this.dgvIstoricCumparaturi.RowTemplate.Height = 24;
            this.dgvIstoricCumparaturi.Size = new System.Drawing.Size(762, 426);
            this.dgvIstoricCumparaturi.TabIndex = 0;
            // 
            // EvidentaCumparaturi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvIstoricCumparaturi);
            this.Name = "EvidentaCumparaturi";
            this.Text = "EvidentaCumparaturi";
            ((System.ComponentModel.ISupportInitialize)(this.dgvIstoricCumparaturi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvIstoricCumparaturi;
    }
}