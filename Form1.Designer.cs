﻿namespace Sample3_LinqWindowsForm
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonAdd1 = new System.Windows.Forms.Button();
            this.buttonDisableSells2 = new System.Windows.Forms.Button();
            this.buttonDelete3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 375);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonAdd1
            // 
            this.buttonAdd1.Location = new System.Drawing.Point(12, 403);
            this.buttonAdd1.Name = "buttonAdd1";
            this.buttonAdd1.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd1.TabIndex = 1;
            this.buttonAdd1.Text = "Add";
            this.buttonAdd1.UseVisualStyleBackColor = true;
            this.buttonAdd1.Click += new System.EventHandler(this.buttonAdd1_Click);
            // 
            // buttonDisableSells2
            // 
            this.buttonDisableSells2.Location = new System.Drawing.Point(626, 403);
            this.buttonDisableSells2.Name = "buttonDisableSells2";
            this.buttonDisableSells2.Size = new System.Drawing.Size(75, 23);
            this.buttonDisableSells2.TabIndex = 2;
            this.buttonDisableSells2.Text = "Disable sells";
            this.buttonDisableSells2.UseVisualStyleBackColor = true;
            this.buttonDisableSells2.Click += new System.EventHandler(this.buttonDisableSells2_Click);
            // 
            // buttonDelete3
            // 
            this.buttonDelete3.Location = new System.Drawing.Point(713, 403);
            this.buttonDelete3.Name = "buttonDelete3";
            this.buttonDelete3.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete3.TabIndex = 3;
            this.buttonDelete3.Text = "Delete";
            this.buttonDelete3.UseVisualStyleBackColor = true;
            this.buttonDelete3.Click += new System.EventHandler(this.buttonDelete3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDelete3);
            this.Controls.Add(this.buttonDisableSells2);
            this.Controls.Add(this.buttonAdd1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonAdd1;
        private System.Windows.Forms.Button buttonDisableSells2;
        private System.Windows.Forms.Button buttonDelete3;
    }
}

