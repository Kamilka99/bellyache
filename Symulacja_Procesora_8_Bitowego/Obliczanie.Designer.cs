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
            this.doda = new System.Windows.Forms.Button();
            this.wynik = new System.Windows.Forms.Label();
            this.odejm = new System.Windows.Forms.Button();
            this.mnoz = new System.Windows.Forms.Button();
            this.dziel = new System.Windows.Forms.Button();
            this.Dec1 = new System.Windows.Forms.Label();
            this.Dec2 = new System.Windows.Forms.Label();
            this.WynDec = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lista1
            // 
            this.lista1.BackColor = System.Drawing.Color.Black;
            this.lista1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lista1.ForeColor = System.Drawing.Color.Lime;
            this.lista1.FormattingEnabled = true;
            this.lista1.Location = new System.Drawing.Point(12, 12);
            this.lista1.Name = "lista1";
            this.lista1.Size = new System.Drawing.Size(201, 35);
            this.lista1.TabIndex = 0;
            this.lista1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // liczba1
            // 
            this.liczba1.AutoSize = true;
            this.liczba1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.liczba1.ForeColor = System.Drawing.Color.Lime;
            this.liczba1.Location = new System.Drawing.Point(52, 157);
            this.liczba1.Name = "liczba1";
            this.liczba1.Size = new System.Drawing.Size(110, 27);
            this.liczba1.TabIndex = 1;
            this.liczba1.Text = "liczba1";
            this.liczba1.Click += new System.EventHandler(this.Liczba1_Click);
            // 
            // liczba2
            // 
            this.liczba2.AutoSize = true;
            this.liczba2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.liczba2.ForeColor = System.Drawing.Color.Lime;
            this.liczba2.Location = new System.Drawing.Point(364, 157);
            this.liczba2.Name = "liczba2";
            this.liczba2.Size = new System.Drawing.Size(110, 27);
            this.liczba2.TabIndex = 2;
            this.liczba2.Text = "liczba2";
            // 
            // lista2
            // 
            this.lista2.BackColor = System.Drawing.Color.Black;
            this.lista2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lista2.ForeColor = System.Drawing.Color.Lime;
            this.lista2.FormattingEnabled = true;
            this.lista2.Location = new System.Drawing.Point(321, 12);
            this.lista2.Name = "lista2";
            this.lista2.Size = new System.Drawing.Size(201, 35);
            this.lista2.TabIndex = 3;
            this.lista2.SelectedIndexChanged += new System.EventHandler(this.Lista2_SelectedIndexChanged);
            // 
            // doda
            // 
            this.doda.BackColor = System.Drawing.Color.Black;
            this.doda.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.doda.ForeColor = System.Drawing.Color.Lime;
            this.doda.Location = new System.Drawing.Point(231, 71);
            this.doda.Name = "doda";
            this.doda.Size = new System.Drawing.Size(70, 45);
            this.doda.TabIndex = 6;
            this.doda.Text = "+";
            this.doda.UseVisualStyleBackColor = false;
            this.doda.Click += new System.EventHandler(this.Doda_Click_1);
            // 
            // wynik
            // 
            this.wynik.AutoSize = true;
            this.wynik.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wynik.ForeColor = System.Drawing.Color.Lime;
            this.wynik.Location = new System.Drawing.Point(590, 157);
            this.wynik.Name = "wynik";
            this.wynik.Size = new System.Drawing.Size(82, 27);
            this.wynik.TabIndex = 7;
            this.wynik.Text = "wynik";
            // 
            // odejm
            // 
            this.odejm.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.odejm.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.odejm.ForeColor = System.Drawing.Color.Lime;
            this.odejm.Location = new System.Drawing.Point(231, 122);
            this.odejm.Name = "odejm";
            this.odejm.Size = new System.Drawing.Size(70, 45);
            this.odejm.TabIndex = 8;
            this.odejm.Text = "-";
            this.odejm.UseVisualStyleBackColor = false;
            this.odejm.Click += new System.EventHandler(this.Odejm_Click);
            // 
            // mnoz
            // 
            this.mnoz.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mnoz.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mnoz.ForeColor = System.Drawing.Color.Lime;
            this.mnoz.Location = new System.Drawing.Point(231, 173);
            this.mnoz.Name = "mnoz";
            this.mnoz.Size = new System.Drawing.Size(70, 45);
            this.mnoz.TabIndex = 9;
            this.mnoz.Text = "*";
            this.mnoz.UseVisualStyleBackColor = false;
            this.mnoz.Click += new System.EventHandler(this.Mnoz_Click);
            // 
            // dziel
            // 
            this.dziel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dziel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dziel.ForeColor = System.Drawing.Color.Lime;
            this.dziel.Location = new System.Drawing.Point(231, 224);
            this.dziel.Name = "dziel";
            this.dziel.Size = new System.Drawing.Size(70, 45);
            this.dziel.TabIndex = 10;
            this.dziel.Text = "/";
            this.dziel.UseVisualStyleBackColor = false;
            this.dziel.Click += new System.EventHandler(this.Dziel_Click);
            // 
            // Dec1
            // 
            this.Dec1.AutoSize = true;
            this.Dec1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Dec1.ForeColor = System.Drawing.Color.Lime;
            this.Dec1.Location = new System.Drawing.Point(52, 318);
            this.Dec1.Name = "Dec1";
            this.Dec1.Size = new System.Drawing.Size(124, 27);
            this.Dec1.TabIndex = 11;
            this.Dec1.Text = "decimal1";
            // 
            // Dec2
            // 
            this.Dec2.AutoSize = true;
            this.Dec2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Dec2.ForeColor = System.Drawing.Color.Lime;
            this.Dec2.Location = new System.Drawing.Point(364, 318);
            this.Dec2.Name = "Dec2";
            this.Dec2.Size = new System.Drawing.Size(124, 27);
            this.Dec2.TabIndex = 12;
            this.Dec2.Text = "decimal2";
            // 
            // WynDec
            // 
            this.WynDec.AutoSize = true;
            this.WynDec.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WynDec.ForeColor = System.Drawing.Color.Lime;
            this.WynDec.Location = new System.Drawing.Point(590, 318);
            this.WynDec.Name = "WynDec";
            this.WynDec.Size = new System.Drawing.Size(82, 27);
            this.WynDec.TabIndex = 13;
            this.WynDec.Text = "wynik";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(515, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 27);
            this.label1.TabIndex = 15;
            this.label1.Text = "=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(515, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 27);
            this.label2.TabIndex = 16;
            this.label2.Text = "=";
            // 
            // Obliczanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(752, 394);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WynDec);
            this.Controls.Add(this.Dec2);
            this.Controls.Add(this.Dec1);
            this.Controls.Add(this.dziel);
            this.Controls.Add(this.mnoz);
            this.Controls.Add(this.odejm);
            this.Controls.Add(this.wynik);
            this.Controls.Add(this.doda);
            this.Controls.Add(this.lista2);
            this.Controls.Add(this.liczba2);
            this.Controls.Add(this.liczba1);
            this.Controls.Add(this.lista1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Obliczanie";
            this.Text = "Obliczanie";
            this.Load += new System.EventHandler(this.Obliczanie_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox lista1;
        private System.Windows.Forms.Label liczba1;
        private System.Windows.Forms.Label liczba2;
        private System.Windows.Forms.ComboBox lista2;
        private System.Windows.Forms.Button doda;
        private System.Windows.Forms.Label wynik;
        private System.Windows.Forms.Button odejm;
        private System.Windows.Forms.Button mnoz;
        private System.Windows.Forms.Button dziel;
        private System.Windows.Forms.Label Dec1;
        private System.Windows.Forms.Label Dec2;
        private System.Windows.Forms.Label WynDec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}