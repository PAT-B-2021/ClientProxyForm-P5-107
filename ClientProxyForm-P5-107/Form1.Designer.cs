using System;

namespace ClientProxyForm_P5_107
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
            this.buttonHasil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelpenjumlahan = new System.Windows.Forms.Label();
            this.labelpengurangan = new System.Windows.Forms.Label();
            this.labelperkalian = new System.Windows.Forms.Label();
            this.labelpembagian = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonHasil
            // 
            this.buttonHasil.Location = new System.Drawing.Point(328, 289);
            this.buttonHasil.Name = "buttonHasil";
            this.buttonHasil.Size = new System.Drawing.Size(104, 48);
            this.buttonHasil.TabIndex = 0;
            this.buttonHasil.Text = "Hasil";
            this.buttonHasil.UseVisualStyleBackColor = true;
            this.buttonHasil.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(210, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Angka 1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Angka 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(562, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Hasil Penjumlahan :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(562, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Hasil pengurangan :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(562, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Hasil Perkalian :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(562, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Hasil pembagian :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(281, 211);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(252, 26);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(281, 151);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(252, 26);
            this.textBox2.TabIndex = 8;
            // 
            // labelpenjumlahan
            // 
            this.labelpenjumlahan.AutoSize = true;
            this.labelpenjumlahan.Location = new System.Drawing.Point(708, 122);
            this.labelpenjumlahan.Name = "labelpenjumlahan";
            this.labelpenjumlahan.Size = new System.Drawing.Size(0, 20);
            this.labelpenjumlahan.TabIndex = 9;
            // 
            // labelpengurangan
            // 
            this.labelpengurangan.AutoSize = true;
            this.labelpengurangan.Location = new System.Drawing.Point(708, 173);
            this.labelpengurangan.Name = "labelpengurangan";
            this.labelpengurangan.Size = new System.Drawing.Size(0, 20);
            this.labelpengurangan.TabIndex = 10;
            // 
            // labelperkalian
            // 
            this.labelperkalian.AutoSize = true;
            this.labelperkalian.Location = new System.Drawing.Point(708, 227);
            this.labelperkalian.Name = "labelperkalian";
            this.labelperkalian.Size = new System.Drawing.Size(0, 20);
            this.labelperkalian.TabIndex = 11;
            // 
            // labelpembagian
            // 
            this.labelpembagian.AutoSize = true;
            this.labelpembagian.Location = new System.Drawing.Point(708, 278);
            this.labelpembagian.Name = "labelpembagian";
            this.labelpembagian.Size = new System.Drawing.Size(0, 20);
            this.labelpembagian.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelpembagian);
            this.Controls.Add(this.labelperkalian);
            this.Controls.Add(this.labelpengurangan);
            this.Controls.Add(this.labelpenjumlahan);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonHasil);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button buttonHasil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labelpenjumlahan;
        private System.Windows.Forms.Label labelpengurangan;
        private System.Windows.Forms.Label labelperkalian;
        private System.Windows.Forms.Label labelpembagian;
    }
}

