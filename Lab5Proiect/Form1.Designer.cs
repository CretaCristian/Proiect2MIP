namespace Lab5Proiect
{
    partial class Magazin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Magazin));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.produsNouToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maresteCantitateaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvProduse = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.EvidentaCumparaturiButton = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduse)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produsNouToolStripMenuItem,
            this.maresteCantitateaToolStripMenuItem});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(39, 24);
            this.toolStripSplitButton1.Text = "Add product";
            // 
            // produsNouToolStripMenuItem
            // 
            this.produsNouToolStripMenuItem.Name = "produsNouToolStripMenuItem";
            this.produsNouToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.produsNouToolStripMenuItem.Text = "Produs nou";
            this.produsNouToolStripMenuItem.Click += new System.EventHandler(this.produsNouToolStripMenuItem_Click);
            // 
            // maresteCantitateaToolStripMenuItem
            // 
            this.maresteCantitateaToolStripMenuItem.Name = "maresteCantitateaToolStripMenuItem";
            this.maresteCantitateaToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.maresteCantitateaToolStripMenuItem.Text = "Mareste cantitatea";
            this.maresteCantitateaToolStripMenuItem.Click += new System.EventHandler(this.maresteCantitateaToolStripMenuItem_Click);
            // 
            // dgvProduse
            // 
            this.dgvProduse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduse.Location = new System.Drawing.Point(12, 70);
            this.dgvProduse.Name = "dgvProduse";
            this.dgvProduse.RowHeadersWidth = 51;
            this.dgvProduse.RowTemplate.Height = 24;
            this.dgvProduse.Size = new System.Drawing.Size(706, 368);
            this.dgvProduse.TabIndex = 2;
            this.dgvProduse.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduse_CellDoubleClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(724, 77);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(197, 42);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(100, 22);
            this.SearchBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cauta produs dupa nume";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(312, 42);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // EvidentaCumparaturiButton
            // 
            this.EvidentaCumparaturiButton.Location = new System.Drawing.Point(407, 42);
            this.EvidentaCumparaturiButton.Name = "EvidentaCumparaturiButton";
            this.EvidentaCumparaturiButton.Size = new System.Drawing.Size(144, 23);
            this.EvidentaCumparaturiButton.TabIndex = 7;
            this.EvidentaCumparaturiButton.Text = "Evidenta cumparaturi";
            this.EvidentaCumparaturiButton.UseVisualStyleBackColor = true;
            this.EvidentaCumparaturiButton.Click += new System.EventHandler(this.EvidentaCumparaturiButton_Click);
            // 
            // Magazin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EvidentaCumparaturiButton);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dgvProduse);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Magazin";
            this.Text = "Magazin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Magazin_FormClosing);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem produsNouToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maresteCantitateaToolStripMenuItem;
        public System.Windows.Forms.DataGridView dgvProduse;
        private System.Windows.Forms.Button EvidentaCumparaturiButton;
    }
}

