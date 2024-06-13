namespace TutoringPAW_Tibrea_2022
{
    partial class Form2
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
            this.tbNume = new System.Windows.Forms.TextBox();
            this.tbVarsta = new System.Windows.Forms.TextBox();
            this.tbTarif = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdaugaPacient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(169, 53);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(145, 22);
            this.tbNume.TabIndex = 0;
            // 
            // tbVarsta
            // 
            this.tbVarsta.Location = new System.Drawing.Point(169, 116);
            this.tbVarsta.Name = "tbVarsta";
            this.tbVarsta.Size = new System.Drawing.Size(145, 22);
            this.tbVarsta.TabIndex = 1;
            // 
            // tbTarif
            // 
            this.tbTarif.Location = new System.Drawing.Point(169, 186);
            this.tbTarif.Name = "tbTarif";
            this.tbTarif.Size = new System.Drawing.Size(145, 22);
            this.tbTarif.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nume";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Varsta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tarif";
            // 
            // btnAdaugaPacient
            // 
            this.btnAdaugaPacient.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAdaugaPacient.Location = new System.Drawing.Point(72, 249);
            this.btnAdaugaPacient.Name = "btnAdaugaPacient";
            this.btnAdaugaPacient.Size = new System.Drawing.Size(242, 40);
            this.btnAdaugaPacient.TabIndex = 6;
            this.btnAdaugaPacient.Text = "Adauga pacient";
            this.btnAdaugaPacient.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 379);
            this.Controls.Add(this.btnAdaugaPacient);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbTarif);
            this.Controls.Add(this.tbVarsta);
            this.Controls.Add(this.tbNume);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox tbNume;
        public System.Windows.Forms.TextBox tbVarsta;
        public System.Windows.Forms.TextBox tbTarif;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdaugaPacient;
    }
}