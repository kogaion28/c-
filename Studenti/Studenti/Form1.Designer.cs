namespace Studenti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label2 = new System.Windows.Forms.Label();
            this.nume = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.oras = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.adresa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cnp = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.id_student = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nume student";
            // 
            // nume
            // 
            this.nume.Location = new System.Drawing.Point(106, 42);
            this.nume.Name = "nume";
            this.nume.Size = new System.Drawing.Size(396, 20);
            this.nume.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Oras student";
            // 
            // oras
            // 
            this.oras.Location = new System.Drawing.Point(106, 73);
            this.oras.Name = "oras";
            this.oras.Size = new System.Drawing.Size(396, 20);
            this.oras.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Adresa student";
            // 
            // adresa
            // 
            this.adresa.Location = new System.Drawing.Point(106, 96);
            this.adresa.Name = "adresa";
            this.adresa.Size = new System.Drawing.Size(396, 20);
            this.adresa.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "CNP student";
            // 
            // cnp
            // 
            this.cnp.Location = new System.Drawing.Point(106, 126);
            this.cnp.Name = "cnp";
            this.cnp.Size = new System.Drawing.Size(396, 20);
            this.cnp.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 399);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Inserare student";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(542, 399);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Afiseaza studenti";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(747, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Baza de date  studenti";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(714, 399);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(144, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "Gloleste lista";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(162, 399);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(70, 23);
            this.button4.TabIndex = 14;
            this.button4.Text = "Sterge";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // id_student
            // 
            this.id_student.Location = new System.Drawing.Point(310, 397);
            this.id_student.Name = "id_student";
            this.id_student.Size = new System.Drawing.Size(54, 20);
            this.id_student.TabIndex = 15;
            this.id_student.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(198, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Adaugati studenti in baza de date";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 208);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(870, 173);
            this.listBox1.TabIndex = 21;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(252, 404);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Sterge ID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(894, 450);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.id_student);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cnp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.adresa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.oras);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nume);
            this.Controls.Add(this.label2);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = " Baza de date cu studentii";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nume;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox oras;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox adresa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cnp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox id_student;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label12;
    }
}

