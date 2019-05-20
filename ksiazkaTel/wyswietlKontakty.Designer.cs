namespace ksiazkaTel
{
    partial class wyswietlKontakty
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
            this.btWroc2 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btWyswietl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btWroc2
            // 
            this.btWroc2.Location = new System.Drawing.Point(12, 12);
            this.btWroc2.Name = "btWroc2";
            this.btWroc2.Size = new System.Drawing.Size(75, 23);
            this.btWroc2.TabIndex = 8;
            this.btWroc2.Text = "<-- wroc";
            this.btWroc2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btWroc2.UseVisualStyleBackColor = true;
            this.btWroc2.Click += new System.EventHandler(this.btWroc2_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.Location = new System.Drawing.Point(12, 62);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(260, 187);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 26;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Imie";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Nazwisko";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Numer";
            this.columnHeader4.Width = 76;
            // 
            // btWyswietl
            // 
            this.btWyswietl.Location = new System.Drawing.Point(126, 12);
            this.btWyswietl.Name = "btWyswietl";
            this.btWyswietl.Size = new System.Drawing.Size(135, 23);
            this.btWyswietl.TabIndex = 10;
            this.btWyswietl.Text = "Wyswietl(aktualizacja)";
            this.btWyswietl.UseVisualStyleBackColor = true;
            this.btWyswietl.Click += new System.EventHandler(this.btWyswietl_Click);
            // 
            // wyswietlKontakty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btWyswietl);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btWroc2);
            this.Name = "wyswietlKontakty";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "wyswietlKontakty";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btWroc2;
        public System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btWyswietl;
    }
}