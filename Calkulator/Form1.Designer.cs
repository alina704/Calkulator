namespace Calkulator
{
    partial class Calculator
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.plus = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.umnogenie = new System.Windows.Forms.Button();
            this.delenie = new System.Windows.Forms.Button();
            this.ochistit = new System.Windows.Forms.Button();
            this.ravno = new System.Windows.Forms.Label();
            this.znaki = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(11, 14);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(149, 28);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 59);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(148, 28);
            this.textBox2.TabIndex = 1;
            // 
            // plus
            // 
            this.plus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.plus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plus.Location = new System.Drawing.Point(26, 105);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(48, 27);
            this.plus.TabIndex = 2;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = false;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // minus
            // 
            this.minus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.minus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minus.Location = new System.Drawing.Point(93, 105);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(48, 27);
            this.minus.TabIndex = 3;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = false;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // umnogenie
            // 
            this.umnogenie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.umnogenie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.umnogenie.Location = new System.Drawing.Point(164, 105);
            this.umnogenie.Name = "umnogenie";
            this.umnogenie.Size = new System.Drawing.Size(48, 27);
            this.umnogenie.TabIndex = 4;
            this.umnogenie.Text = "*";
            this.umnogenie.UseVisualStyleBackColor = false;
            this.umnogenie.Click += new System.EventHandler(this.button3_Click);
            // 
            // delenie
            // 
            this.delenie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.delenie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delenie.Location = new System.Drawing.Point(26, 138);
            this.delenie.Name = "delenie";
            this.delenie.Size = new System.Drawing.Size(48, 27);
            this.delenie.TabIndex = 5;
            this.delenie.Text = "/";
            this.delenie.UseVisualStyleBackColor = false;
            this.delenie.Click += new System.EventHandler(this.delenie_Click);
            // 
            // ochistit
            // 
            this.ochistit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ochistit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ochistit.Location = new System.Drawing.Point(93, 138);
            this.ochistit.Name = "ochistit";
            this.ochistit.Size = new System.Drawing.Size(48, 27);
            this.ochistit.TabIndex = 6;
            this.ochistit.Text = "C";
            this.ochistit.UseVisualStyleBackColor = false;
            this.ochistit.Click += new System.EventHandler(this.ochistit_Click);
            // 
            // ravno
            // 
            this.ravno.AutoSize = true;
            this.ravno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ravno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ravno.Location = new System.Drawing.Point(172, 49);
            this.ravno.Name = "ravno";
            this.ravno.Size = new System.Drawing.Size(40, 13);
            this.ravno.TabIndex = 8;
            this.ravno.Text = "Вывод";
            this.ravno.Click += new System.EventHandler(this.ravno_Click);
            // 
            // znaki
            // 
            this.znaki.AutoSize = true;
            this.znaki.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.znaki.Location = new System.Drawing.Point(172, 36);
            this.znaki.Name = "znaki";
            this.znaki.Size = new System.Drawing.Size(0, 13);
            this.znaki.TabIndex = 9;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(215, 195);
            this.Controls.Add(this.znaki);
            this.Controls.Add(this.ravno);
            this.Controls.Add(this.ochistit);
            this.Controls.Add(this.delenie);
            this.Controls.Add(this.umnogenie);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Calculator";
            this.Text = "Calculator Abraskina";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button umnogenie;
        private System.Windows.Forms.Button delenie;
        private System.Windows.Forms.Button ochistit;
        private System.Windows.Forms.Label ravno;
        private System.Windows.Forms.Label znaki;
    }
}

