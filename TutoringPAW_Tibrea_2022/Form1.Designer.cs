namespace TutoringPAW_Tibrea_2022
{
    partial class Form1
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
            this.btnAdauga = new System.Windows.Forms.Button();
            this.lvPacienti = new System.Windows.Forms.ListView();
            this.colNume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colVarsta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTarif = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnEditare = new System.Windows.Forms.Button();
            this.btnStergere = new System.Windows.Forms.Button();
            this.tbVenit = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.calculeazaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGrafic = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdauga
            // 
            this.btnAdauga.Location = new System.Drawing.Point(23, 67);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(139, 44);
            this.btnAdauga.TabIndex = 0;
            this.btnAdauga.Text = "Adauga pacient";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // lvPacienti
            // 
            this.lvPacienti.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colNume,
            this.colVarsta,
            this.colTarif});
            this.lvPacienti.ContextMenuStrip = this.contextMenuStrip1;
            this.lvPacienti.GridLines = true;
            this.lvPacienti.HideSelection = false;
            this.lvPacienti.Location = new System.Drawing.Point(206, 67);
            this.lvPacienti.Name = "lvPacienti";
            this.lvPacienti.Size = new System.Drawing.Size(307, 238);
            this.lvPacienti.TabIndex = 1;
            this.lvPacienti.UseCompatibleStateImageBehavior = false;
            this.lvPacienti.View = System.Windows.Forms.View.Details;
            // 
            // colNume
            // 
            this.colNume.Text = "Nume";
            this.colNume.Width = 81;
            // 
            // colVarsta
            // 
            this.colVarsta.Text = "Varsta";
            this.colVarsta.Width = 86;
            // 
            // colTarif
            // 
            this.colTarif.Text = "Tarif";
            this.colTarif.Width = 79;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(206, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(307, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnEditare
            // 
            this.btnEditare.Location = new System.Drawing.Point(23, 135);
            this.btnEditare.Name = "btnEditare";
            this.btnEditare.Size = new System.Drawing.Size(139, 42);
            this.btnEditare.TabIndex = 3;
            this.btnEditare.Text = "Editare";
            this.btnEditare.UseVisualStyleBackColor = true;
            this.btnEditare.Click += new System.EventHandler(this.btnEditare_Click);
            // 
            // btnStergere
            // 
            this.btnStergere.Location = new System.Drawing.Point(23, 201);
            this.btnStergere.Name = "btnStergere";
            this.btnStergere.Size = new System.Drawing.Size(139, 40);
            this.btnStergere.TabIndex = 4;
            this.btnStergere.Text = "Stergere";
            this.btnStergere.UseVisualStyleBackColor = true;
            this.btnStergere.Click += new System.EventHandler(this.btnStergere_Click);
            // 
            // tbVenit
            // 
            this.tbVenit.Location = new System.Drawing.Point(206, 312);
            this.tbVenit.Name = "tbVenit";
            this.tbVenit.ReadOnly = true;
            this.tbVenit.Size = new System.Drawing.Size(307, 22);
            this.tbVenit.TabIndex = 5;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculeazaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(231, 28);
            // 
            // calculeazaToolStripMenuItem
            // 
            this.calculeazaToolStripMenuItem.Name = "calculeazaToolStripMenuItem";
            this.calculeazaToolStripMenuItem.Size = new System.Drawing.Size(230, 24);
            this.calculeazaToolStripMenuItem.Text = "Calculeaza venit medic";
            this.calculeazaToolStripMenuItem.Click += new System.EventHandler(this.calculeazaToolStripMenuItem_Click);
            // 
            // btnGrafic
            // 
            this.btnGrafic.Location = new System.Drawing.Point(23, 268);
            this.btnGrafic.Name = "btnGrafic";
            this.btnGrafic.Size = new System.Drawing.Size(139, 37);
            this.btnGrafic.TabIndex = 7;
            this.btnGrafic.Text = "Grafic";
            this.btnGrafic.UseVisualStyleBackColor = true;
            this.btnGrafic.Click += new System.EventHandler(this.btnGrafic_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGrafic);
            this.Controls.Add(this.tbVenit);
            this.Controls.Add(this.btnStergere);
            this.Controls.Add(this.btnEditare);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lvPacienti);
            this.Controls.Add(this.btnAdauga);
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.ListView lvPacienti;
        private System.Windows.Forms.ColumnHeader colNume;
        private System.Windows.Forms.ColumnHeader colVarsta;
        private System.Windows.Forms.ColumnHeader colTarif;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnEditare;
        private System.Windows.Forms.Button btnStergere;
        private System.Windows.Forms.TextBox tbVenit;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem calculeazaToolStripMenuItem;
        private System.Windows.Forms.Button btnGrafic;
    }
}

