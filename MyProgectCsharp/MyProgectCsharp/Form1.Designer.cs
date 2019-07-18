namespace MyProgectCsharp
{
    partial class Form1
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
            this.argument_1 = new System.Windows.Forms.TextBox();
            this.Plus = new System.Windows.Forms.Button();
            this.Minus = new System.Windows.Forms.Button();
            this.Multiplier = new System.Windows.Forms.Button();
            this.Divider = new System.Windows.Forms.Button();
            this.argument_2 = new System.Windows.Forms.TextBox();
            this.TotalResult = new System.Windows.Forms.TextBox();
            this.Sinus = new System.Windows.Forms.Button();
            this.Cosinus = new System.Windows.Forms.Button();
            this.Tangens = new System.Windows.Forms.Button();
            this.Catangens = new System.Windows.Forms.Button();
            this.ArcSinus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // argument_1
            // 
            this.argument_1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.argument_1.Location = new System.Drawing.Point(12, 12);
            this.argument_1.Multiline = true;
            this.argument_1.Name = "argument_1";
            this.argument_1.Size = new System.Drawing.Size(139, 50);
            this.argument_1.TabIndex = 1;
            this.argument_1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Plus
            // 
            this.Plus.Location = new System.Drawing.Point(12, 157);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(49, 52);
            this.Plus.TabIndex = 10;
            this.Plus.Text = "+";
            this.Plus.UseVisualStyleBackColor = true;
            this.Plus.Click += new System.EventHandler(this.twoargumentcalculate);
            // 
            // Minus
            // 
            this.Minus.Location = new System.Drawing.Point(67, 157);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(50, 52);
            this.Minus.TabIndex = 11;
            this.Minus.Text = "-";
            this.Minus.UseVisualStyleBackColor = true;
            this.Minus.Click += new System.EventHandler(this.twoargumentcalculate);
            // 
            // Multiplier
            // 
            this.Multiplier.Location = new System.Drawing.Point(12, 229);
            this.Multiplier.Name = "Multiplier";
            this.Multiplier.Size = new System.Drawing.Size(49, 52);
            this.Multiplier.TabIndex = 12;
            this.Multiplier.Text = "*";
            this.Multiplier.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Multiplier.UseVisualStyleBackColor = true;
            this.Multiplier.Click += new System.EventHandler(this.twoargumentcalculate);
            // 
            // Divider
            // 
            this.Divider.Location = new System.Drawing.Point(67, 229);
            this.Divider.Name = "Divider";
            this.Divider.Size = new System.Drawing.Size(50, 52);
            this.Divider.TabIndex = 13;
            this.Divider.Text = "/";
            this.Divider.UseVisualStyleBackColor = true;
            this.Divider.Click += new System.EventHandler(this.twoargumentcalculate);
            // 
            // argument_2
            // 
            this.argument_2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.argument_2.Location = new System.Drawing.Point(167, 12);
            this.argument_2.Multiline = true;
            this.argument_2.Name = "argument_2";
            this.argument_2.Size = new System.Drawing.Size(139, 50);
            this.argument_2.TabIndex = 16;
            this.argument_2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // TotalResult
            // 
            this.TotalResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalResult.Location = new System.Drawing.Point(12, 79);
            this.TotalResult.Multiline = true;
            this.TotalResult.Name = "TotalResult";
            this.TotalResult.Size = new System.Drawing.Size(294, 50);
            this.TotalResult.TabIndex = 17;
            this.TotalResult.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Sinus
            // 
            this.Sinus.Location = new System.Drawing.Point(12, 297);
            this.Sinus.Name = "Sinus";
            this.Sinus.Size = new System.Drawing.Size(49, 50);
            this.Sinus.TabIndex = 18;
            this.Sinus.Text = "Sin";
            this.Sinus.UseVisualStyleBackColor = true;
            this.Sinus.Click += new System.EventHandler(this.oneargumentfunction);
            // 
            // Cosinus
            // 
            this.Cosinus.Location = new System.Drawing.Point(67, 297);
            this.Cosinus.Name = "Cosinus";
            this.Cosinus.Size = new System.Drawing.Size(50, 50);
            this.Cosinus.TabIndex = 19;
            this.Cosinus.Text = "Cos";
            this.Cosinus.UseVisualStyleBackColor = true;
            this.Cosinus.Click += new System.EventHandler(this.oneargumentfunction);
            // 
            // Tangens
            // 
            this.Tangens.Location = new System.Drawing.Point(12, 353);
            this.Tangens.Name = "Tangens";
            this.Tangens.Size = new System.Drawing.Size(49, 50);
            this.Tangens.TabIndex = 20;
            this.Tangens.Text = "Tan";
            this.Tangens.UseVisualStyleBackColor = true;
            this.Tangens.Click += new System.EventHandler(this.oneargumentfunction);
            // 
            // Catangens
            // 
            this.Catangens.Location = new System.Drawing.Point(67, 353);
            this.Catangens.Name = "Catangens";
            this.Catangens.Size = new System.Drawing.Size(49, 50);
            this.Catangens.TabIndex = 21;
            this.Catangens.Text = "Ctan";
            this.Catangens.UseVisualStyleBackColor = true;
            this.Catangens.Click += new System.EventHandler(this.oneargumentfunction);
            // 
            // ArcSinus
            // 
            this.ArcSinus.Location = new System.Drawing.Point(123, 159);
            this.ArcSinus.Name = "ArcSinus";
            this.ArcSinus.Size = new System.Drawing.Size(49, 50);
            this.ArcSinus.TabIndex = 22;
            this.ArcSinus.Text = "Arcsin";
            this.ArcSinus.UseVisualStyleBackColor = true;
            this.ArcSinus.Click += new System.EventHandler(this.oneargumentfunction);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 452);
            this.Controls.Add(this.ArcSinus);
            this.Controls.Add(this.Catangens);
            this.Controls.Add(this.Tangens);
            this.Controls.Add(this.Cosinus);
            this.Controls.Add(this.Sinus);
            this.Controls.Add(this.TotalResult);
            this.Controls.Add(this.argument_2);
            this.Controls.Add(this.Divider);
            this.Controls.Add(this.Multiplier);
            this.Controls.Add(this.Minus);
            this.Controls.Add(this.Plus);
            this.Controls.Add(this.argument_1);
            this.Name = "Form1";
            this.Text = "Калькулятор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox argument_1;
        private System.Windows.Forms.Button Plus;
        private System.Windows.Forms.Button Minus;
        private System.Windows.Forms.Button Multiplier;
        private System.Windows.Forms.Button Divider;
        private System.Windows.Forms.TextBox argument_2;
        private System.Windows.Forms.TextBox TotalResult;
        private System.Windows.Forms.Button Sinus;
        private System.Windows.Forms.Button Cosinus;
        private System.Windows.Forms.Button Tangens;
        private System.Windows.Forms.Button Catangens;
        private System.Windows.Forms.Button ArcSinus;
    }
}

