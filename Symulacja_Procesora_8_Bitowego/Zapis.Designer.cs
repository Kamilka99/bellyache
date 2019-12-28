namespace Symulacja_Procesora_8_Bitowego
{
    partial class Zapis
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
            this.wynik = new System.Windows.Forms.Label();
            this.input = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.test = new System.Windows.Forms.Label();
            this.test2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // wynik
            // 
            this.wynik.AutoSize = true;
            this.wynik.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wynik.ForeColor = System.Drawing.Color.Lime;
            this.wynik.Location = new System.Drawing.Point(12, 143);
            this.wynik.Name = "wynik";
            this.wynik.Size = new System.Drawing.Size(138, 27);
            this.wynik.TabIndex = 4;
            this.wynik.Text = "konwersja";
            this.wynik.Click += new System.EventHandler(this.Label1_Click);
            // 
            // input
            // 
            this.input.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.input.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.input.Location = new System.Drawing.Point(17, 45);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(151, 35);
            this.input.TabIndex = 5;
            this.input.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.Color.Lime;
            this.button1.Location = new System.Drawing.Point(188, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(299, 59);
            this.button1.TabIndex = 6;
            this.button1.Text = "zamień na dwójkowy";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // test
            // 
            this.test.AutoSize = true;
            this.test.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.test.ForeColor = System.Drawing.Color.Lime;
            this.test.Location = new System.Drawing.Point(198, 143);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(250, 27);
            this.test.TabIndex = 7;
            this.test.Text = "zapis w rejestrze";
            // 
            // test2
            // 
            this.test2.AutoSize = true;
            this.test2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.test2.ForeColor = System.Drawing.Color.Lime;
            this.test2.Location = new System.Drawing.Point(198, 190);
            this.test2.Name = "test2";
            this.test2.Size = new System.Drawing.Size(236, 27);
            this.test2.TabIndex = 8;
            this.test2.Text = "numer rejestru i";
            // 
            // Zapis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(514, 252);
            this.Controls.Add(this.test2);
            this.Controls.Add(this.test);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.input);
            this.Controls.Add(this.wynik);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Zapis";
            this.Text = "Zapis";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label wynik;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label test;
        private System.Windows.Forms.Label test2;
    }
}