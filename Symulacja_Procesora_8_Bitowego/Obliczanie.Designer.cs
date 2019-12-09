namespace Symulacja_Procesora_8_Bitowego
{
    partial class Obliczanie
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
            this.lista1 = new System.Windows.Forms.ComboBox();
            this.liczba1 = new System.Windows.Forms.Label();
            this.liczba2 = new System.Windows.Forms.Label();
            this.lista2 = new System.Windows.Forms.ComboBox();
            this.number1 = new System.Windows.Forms.TextBox();
            this.number2 = new System.Windows.Forms.TextBox();
            this.doda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lista1
            // 
            this.lista1.FormattingEnabled = true;
            this.lista1.Location = new System.Drawing.Point(12, 12);
            this.lista1.Name = "lista1";
            this.lista1.Size = new System.Drawing.Size(201, 28);
            this.lista1.TabIndex = 0;
            this.lista1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // liczba1
            // 
            this.liczba1.AutoSize = true;
            this.liczba1.Location = new System.Drawing.Point(189, 103);
            this.liczba1.Name = "liczba1";
            this.liczba1.Size = new System.Drawing.Size(58, 20);
            this.liczba1.TabIndex = 1;
            this.liczba1.Text = "liczba1";
            // 
            // liczba2
            // 
            this.liczba2.AutoSize = true;
            this.liczba2.Location = new System.Drawing.Point(488, 103);
            this.liczba2.Name = "liczba2";
            this.liczba2.Size = new System.Drawing.Size(58, 20);
            this.liczba2.TabIndex = 2;
            this.liczba2.Text = "liczba2";
            // 
            // lista2
            // 
            this.lista2.FormattingEnabled = true;
            this.lista2.Location = new System.Drawing.Point(12, 46);
            this.lista2.Name = "lista2";
            this.lista2.Size = new System.Drawing.Size(197, 28);
            this.lista2.TabIndex = 3;
            // 
            // number1
            // 
            this.number1.Location = new System.Drawing.Point(179, 138);
            this.number1.Name = "number1";
            this.number1.Size = new System.Drawing.Size(100, 26);
            this.number1.TabIndex = 4;
            // 
            // number2
            // 
            this.number2.Location = new System.Drawing.Point(481, 138);
            this.number2.Name = "number2";
            this.number2.Size = new System.Drawing.Size(112, 26);
            this.number2.TabIndex = 5;
            // 
            // doda
            // 
            this.doda.Location = new System.Drawing.Point(179, 189);
            this.doda.Name = "doda";
            this.doda.Size = new System.Drawing.Size(70, 45);
            this.doda.TabIndex = 6;
            this.doda.Text = "+";
            this.doda.UseVisualStyleBackColor = true;
       //     this.doda.Click += new System.EventHandler(this.Doda_Click);
            // 
            // Obliczanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 416);
            this.Controls.Add(this.doda);
            this.Controls.Add(this.number2);
            this.Controls.Add(this.number1);
            this.Controls.Add(this.lista2);
            this.Controls.Add(this.liczba2);
            this.Controls.Add(this.liczba1);
            this.Controls.Add(this.lista1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Obliczanie";
            this.Text = "Obliczanie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox lista1;
        private System.Windows.Forms.Label liczba1;
        private System.Windows.Forms.Label liczba2;
        private System.Windows.Forms.ComboBox lista2;
        private System.Windows.Forms.TextBox number1;
        private System.Windows.Forms.TextBox number2;
        private System.Windows.Forms.Button doda;
    }
}