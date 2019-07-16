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
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.argument_2 = new System.Windows.Forms.TextBox();
            this.TotalResult = new System.Windows.Forms.TextBox();
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
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(12, 157);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(139, 52);
            this.button10.TabIndex = 10;
            this.button10.Text = "+";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.buttonPlus);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(167, 157);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(139, 52);
            this.button11.TabIndex = 11;
            this.button11.Text = "-";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.buttonMinus);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(12, 229);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(139, 52);
            this.button12.TabIndex = 12;
            this.button12.Text = "*";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.buttonMultiplication);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(167, 229);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(139, 52);
            this.button13.TabIndex = 13;
            this.button13.Text = "/";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.buttonDevision);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 452);
            this.Controls.Add(this.TotalResult);
            this.Controls.Add(this.argument_2);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.argument_1);
            this.Name = "Form1";
            this.Text = "Калькулятор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox argument_1;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.TextBox argument_2;
        private System.Windows.Forms.TextBox TotalResult;
    }
}

