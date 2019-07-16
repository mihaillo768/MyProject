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
            this.multi = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
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
            // Plus
            // 
            this.Plus.Location = new System.Drawing.Point(12, 157);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(139, 52);
            this.Plus.TabIndex = 10;
            this.Plus.Text = "+";
            this.Plus.UseVisualStyleBackColor = true;
            this.Plus.Click += new System.EventHandler(this.buttons);
            // 
            // Minus
            // 
            this.Minus.Location = new System.Drawing.Point(167, 157);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(139, 52);
            this.Minus.TabIndex = 11;
            this.Minus.Text = "-";
            this.Minus.UseVisualStyleBackColor = true;
            this.Minus.Click += new System.EventHandler(this.buttons);
            // 
            // multi
            // 
            this.multi.Location = new System.Drawing.Point(12, 229);
            this.multi.Name = "multi";
            this.multi.Size = new System.Drawing.Size(139, 52);
            this.multi.TabIndex = 12;
            this.multi.Text = "*";
            this.multi.UseVisualStyleBackColor = true;
            this.multi.Click += new System.EventHandler(this.buttons);
            // 
            // div
            // 
            this.div.Location = new System.Drawing.Point(167, 229);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(139, 52);
            this.div.TabIndex = 13;
            this.div.Text = "/";
            this.div.UseVisualStyleBackColor = true;
            this.div.Click += new System.EventHandler(this.buttons);
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
            this.Controls.Add(this.div);
            this.Controls.Add(this.multi);
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
        private System.Windows.Forms.Button multi;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.TextBox argument_2;
        private System.Windows.Forms.TextBox TotalResult;
    }
}

