namespace CalculatorFor5thClass
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
            this.textInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sS = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textOutput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sourseBase = new System.Windows.Forms.TextBox();
            this.convertButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.переводToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.переводВРимскуюСистемуСчисленияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textExplain = new System.Windows.Forms.TextBox();
            this.сложениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textExplainInWords = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textInput
            // 
            this.textInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textInput.Location = new System.Drawing.Point(200, 37);
            this.textInput.Multiline = true;
            this.textInput.Name = "textInput";
            this.textInput.Size = new System.Drawing.Size(152, 32);
            this.textInput.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите число:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(470, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Введите нужную систему счисления(от 2 до 50):";
            // 
            // sS
            // 
            this.sS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sS.Location = new System.Drawing.Point(512, 94);
            this.sS.Multiline = true;
            this.sS.Name = "sS";
            this.sS.Size = new System.Drawing.Size(152, 32);
            this.sS.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(379, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Число в указанной системе счисления:";
            // 
            // textOutput
            // 
            this.textOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textOutput.Location = new System.Drawing.Point(435, 145);
            this.textOutput.Multiline = true;
            this.textOutput.Name = "textOutput";
            this.textOutput.Size = new System.Drawing.Size(152, 32);
            this.textOutput.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(387, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(237, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "его система счисления:";
            // 
            // sourseBase
            // 
            this.sourseBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sourseBase.Location = new System.Drawing.Point(661, 37);
            this.sourseBase.Multiline = true;
            this.sourseBase.Name = "sourseBase";
            this.sourseBase.Size = new System.Drawing.Size(152, 32);
            this.sourseBase.TabIndex = 8;
            // 
            // convertButton
            // 
            this.convertButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.convertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.convertButton.Location = new System.Drawing.Point(686, 94);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(296, 83);
            this.convertButton.TabIndex = 9;
            this.convertButton.Text = "Перевести!";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.переводToolStripMenuItem,
            this.переводВРимскуюСистемуСчисленияToolStripMenuItem,
            this.сложениеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(994, 28);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // переводToolStripMenuItem
            // 
            this.переводToolStripMenuItem.Name = "переводToolStripMenuItem";
            this.переводToolStripMenuItem.Size = new System.Drawing.Size(289, 24);
            this.переводToolStripMenuItem.Text = "Перевод в другую систему счисления ";
            // 
            // переводВРимскуюСистемуСчисленияToolStripMenuItem
            // 
            this.переводВРимскуюСистемуСчисленияToolStripMenuItem.Name = "переводВРимскуюСистемуСчисленияToolStripMenuItem";
            this.переводВРимскуюСистемуСчисленияToolStripMenuItem.Size = new System.Drawing.Size(298, 24);
            this.переводВРимскуюСистемуСчисленияToolStripMenuItem.Text = "Перевод в римскую систему счисления";
            this.переводВРимскуюСистемуСчисленияToolStripMenuItem.Click += new System.EventHandler(this.переводВРимскуюСистемуСчисленияToolStripMenuItem_Click);
            // 
            // textExplain
            // 
            this.textExplain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textExplain.Location = new System.Drawing.Point(0, 205);
            this.textExplain.Multiline = true;
            this.textExplain.Name = "textExplain";
            this.textExplain.Size = new System.Drawing.Size(587, 415);
            this.textExplain.TabIndex = 11;
            // 
            // сложениеToolStripMenuItem
            // 
            this.сложениеToolStripMenuItem.Name = "сложениеToolStripMenuItem";
            this.сложениеToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.сложениеToolStripMenuItem.Text = "Сложение";
            this.сложениеToolStripMenuItem.Click += new System.EventHandler(this.сложениеToolStripMenuItem_Click);
            // 
            // textExplainInWords
            // 
            this.textExplainInWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textExplainInWords.Location = new System.Drawing.Point(593, 205);
            this.textExplainInWords.Multiline = true;
            this.textExplainInWords.Name = "textExplainInWords";
            this.textExplainInWords.Size = new System.Drawing.Size(401, 415);
            this.textExplainInWords.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 620);
            this.Controls.Add(this.textExplainInWords);
            this.Controls.Add(this.textExplain);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.sourseBase);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textOutput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textInput);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textOutput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox sourseBase;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem переводToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem переводВРимскуюСистемуСчисленияToolStripMenuItem;
        private System.Windows.Forms.TextBox textExplain;
        private System.Windows.Forms.ToolStripMenuItem сложениеToolStripMenuItem;
        private System.Windows.Forms.TextBox textExplainInWords;
    }
}

