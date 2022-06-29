namespace Lab5Proiect
{
    partial class Form3
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
            this.components = new System.ComponentModel.Container();
            this.labelDetaliiProdus = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.labelNume = new System.Windows.Forms.Label();
            this.labelCantitate = new System.Windows.Forms.Label();
            this.labelVanzare = new System.Windows.Forms.Label();
            this.textBoxVinde = new System.Windows.Forms.TextBox();
            this.buttonVinde = new System.Windows.Forms.Button();
            this.labelul1 = new System.Windows.Forms.Label();
            this.labelul2 = new System.Windows.Forms.Label();
            this.labelul3 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDetaliiProdus
            // 
            this.labelDetaliiProdus.AutoSize = true;
            this.labelDetaliiProdus.Location = new System.Drawing.Point(12, 9);
            this.labelDetaliiProdus.Name = "labelDetaliiProdus";
            this.labelDetaliiProdus.Size = new System.Drawing.Size(96, 16);
            this.labelDetaliiProdus.TabIndex = 0;
            this.labelDetaliiProdus.Text = "Detalii produs: ";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(12, 39);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(20, 16);
            this.labelID.TabIndex = 1;
            this.labelID.Text = "ID";
            // 
            // labelNume
            // 
            this.labelNume.AutoSize = true;
            this.labelNume.Location = new System.Drawing.Point(12, 64);
            this.labelNume.Name = "labelNume";
            this.labelNume.Size = new System.Drawing.Size(43, 16);
            this.labelNume.TabIndex = 2;
            this.labelNume.Text = "Nume";
            // 
            // labelCantitate
            // 
            this.labelCantitate.AutoSize = true;
            this.labelCantitate.Location = new System.Drawing.Point(12, 93);
            this.labelCantitate.Name = "labelCantitate";
            this.labelCantitate.Size = new System.Drawing.Size(59, 16);
            this.labelCantitate.TabIndex = 3;
            this.labelCantitate.Text = "Cantitate";
            // 
            // labelVanzare
            // 
            this.labelVanzare.AutoSize = true;
            this.labelVanzare.Location = new System.Drawing.Point(64, 154);
            this.labelVanzare.Name = "labelVanzare";
            this.labelVanzare.Size = new System.Drawing.Size(127, 16);
            this.labelVanzare.TabIndex = 7;
            this.labelVanzare.Text = "Cantitate de vandut: ";
            // 
            // textBoxVinde
            // 
            this.textBoxVinde.Location = new System.Drawing.Point(77, 187);
            this.textBoxVinde.Name = "textBoxVinde";
            this.textBoxVinde.Size = new System.Drawing.Size(100, 22);
            this.textBoxVinde.TabIndex = 8;
            this.textBoxVinde.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxVinde_Validating);
            // 
            // buttonVinde
            // 
            this.buttonVinde.Location = new System.Drawing.Point(88, 224);
            this.buttonVinde.Name = "buttonVinde";
            this.buttonVinde.Size = new System.Drawing.Size(75, 23);
            this.buttonVinde.TabIndex = 9;
            this.buttonVinde.Text = "OK";
            this.buttonVinde.UseVisualStyleBackColor = true;
            this.buttonVinde.Click += new System.EventHandler(this.buttonVinde_Click);
            // 
            // labelul1
            // 
            this.labelul1.AutoSize = true;
            this.labelul1.Location = new System.Drawing.Point(132, 39);
            this.labelul1.Name = "labelul1";
            this.labelul1.Size = new System.Drawing.Size(62, 16);
            this.labelul1.TabIndex = 10;
            this.labelul1.Text = "labelul1d";
            // 
            // labelul2
            // 
            this.labelul2.AutoSize = true;
            this.labelul2.Location = new System.Drawing.Point(135, 64);
            this.labelul2.Name = "labelul2";
            this.labelul2.Size = new System.Drawing.Size(44, 16);
            this.labelul2.TabIndex = 11;
            this.labelul2.Text = "label1";
            // 
            // labelul3
            // 
            this.labelul3.AutoSize = true;
            this.labelul3.Location = new System.Drawing.Point(135, 93);
            this.labelul3.Name = "labelul3";
            this.labelul3.Size = new System.Drawing.Size(44, 16);
            this.labelul3.TabIndex = 12;
            this.labelul3.Text = "label2";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 336);
            this.Controls.Add(this.labelul3);
            this.Controls.Add(this.labelul2);
            this.Controls.Add(this.labelul1);
            this.Controls.Add(this.buttonVinde);
            this.Controls.Add(this.textBoxVinde);
            this.Controls.Add(this.labelVanzare);
            this.Controls.Add(this.labelCantitate);
            this.Controls.Add(this.labelNume);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.labelDetaliiProdus);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDetaliiProdus;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelNume;
        private System.Windows.Forms.Label labelCantitate;
        private System.Windows.Forms.Label labelVanzare;
        private System.Windows.Forms.TextBox textBoxVinde;
        private System.Windows.Forms.Button buttonVinde;
        public System.Windows.Forms.Label labelul1;
        private System.Windows.Forms.Label labelul2;
        private System.Windows.Forms.Label labelul3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}