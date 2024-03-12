namespace Sample3_LinqWindowsForm
{
    partial class FormAdd
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
            this.textBoxName1 = new System.Windows.Forms.TextBox();
            this.textBoxProductNumber2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxColor3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxStockLevel4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxReorder5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxLastPrice6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxSize7 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonAdd1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // textBoxName1
            // 
            this.textBoxName1.Location = new System.Drawing.Point(111, 22);
            this.textBoxName1.Name = "textBoxName1";
            this.textBoxName1.Size = new System.Drawing.Size(100, 20);
            this.textBoxName1.TabIndex = 1;
            // 
            // textBoxProductNumber2
            // 
            this.textBoxProductNumber2.Location = new System.Drawing.Point(111, 58);
            this.textBoxProductNumber2.Name = "textBoxProductNumber2";
            this.textBoxProductNumber2.Size = new System.Drawing.Size(100, 20);
            this.textBoxProductNumber2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Product number";
            // 
            // textBoxColor3
            // 
            this.textBoxColor3.Location = new System.Drawing.Point(111, 98);
            this.textBoxColor3.Name = "textBoxColor3";
            this.textBoxColor3.Size = new System.Drawing.Size(100, 20);
            this.textBoxColor3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Color";
            // 
            // textBoxStockLevel4
            // 
            this.textBoxStockLevel4.Location = new System.Drawing.Point(111, 134);
            this.textBoxStockLevel4.Name = "textBoxStockLevel4";
            this.textBoxStockLevel4.Size = new System.Drawing.Size(100, 20);
            this.textBoxStockLevel4.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Safety stock level";
            // 
            // textBoxReorder5
            // 
            this.textBoxReorder5.Location = new System.Drawing.Point(111, 175);
            this.textBoxReorder5.Name = "textBoxReorder5";
            this.textBoxReorder5.Size = new System.Drawing.Size(100, 20);
            this.textBoxReorder5.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Reorder point";
            // 
            // textBoxLastPrice6
            // 
            this.textBoxLastPrice6.Location = new System.Drawing.Point(111, 214);
            this.textBoxLastPrice6.Name = "textBoxLastPrice6";
            this.textBoxLastPrice6.Size = new System.Drawing.Size(100, 20);
            this.textBoxLastPrice6.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "List price";
            // 
            // textBoxSize7
            // 
            this.textBoxSize7.Location = new System.Drawing.Point(111, 250);
            this.textBoxSize7.Name = "textBoxSize7";
            this.textBoxSize7.Size = new System.Drawing.Size(100, 20);
            this.textBoxSize7.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Size";
            // 
            // buttonAdd1
            // 
            this.buttonAdd1.Location = new System.Drawing.Point(169, 300);
            this.buttonAdd1.Name = "buttonAdd1";
            this.buttonAdd1.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd1.TabIndex = 14;
            this.buttonAdd1.Text = "Add";
            this.buttonAdd1.UseVisualStyleBackColor = true;
            this.buttonAdd1.Click += new System.EventHandler(this.buttonAdd1_Click);
            // 
            // FormAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 335);
            this.Controls.Add(this.buttonAdd1);
            this.Controls.Add(this.textBoxSize7);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxLastPrice6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxReorder5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxStockLevel4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxColor3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxProductNumber2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxName1);
            this.Controls.Add(this.label1);
            this.Name = "FormAdd";
            this.Text = "FormAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxName1;
        private System.Windows.Forms.TextBox textBoxProductNumber2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxColor3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxStockLevel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxReorder5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxLastPrice6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxSize7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonAdd1;
    }
}