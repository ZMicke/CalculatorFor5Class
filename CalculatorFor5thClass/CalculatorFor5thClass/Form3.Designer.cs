namespace CalculatorFor5thClass
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.sSSum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.firstNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.secondNumber = new System.Windows.Forms.TextBox();
            this.sumButton = new System.Windows.Forms.Button();
            this.resultSum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(587, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Введите систему счисления чисел, которые нужно сложить:";
            // 
            // sSSum
            // 
            this.sSSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sSSum.Location = new System.Drawing.Point(636, 73);
            this.sSSum.Multiline = true;
            this.sSSum.Name = "sSSum";
            this.sSSum.Size = new System.Drawing.Size(152, 32);
            this.sSSum.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Первое число:";
            // 
            // firstNumber
            // 
            this.firstNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstNumber.Location = new System.Drawing.Point(192, 21);
            this.firstNumber.Multiline = true;
            this.firstNumber.Name = "firstNumber";
            this.firstNumber.Size = new System.Drawing.Size(152, 32);
            this.firstNumber.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(394, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Второе число:";
            // 
            // secondNumber
            // 
            this.secondNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secondNumber.Location = new System.Drawing.Point(579, 21);
            this.secondNumber.Multiline = true;
            this.secondNumber.Name = "secondNumber";
            this.secondNumber.Size = new System.Drawing.Size(152, 32);
            this.secondNumber.TabIndex = 9;
            this.secondNumber.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // sumButton
            // 
            this.sumButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sumButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sumButton.Location = new System.Drawing.Point(294, 119);
            this.sumButton.Name = "sumButton";
            this.sumButton.Size = new System.Drawing.Size(173, 44);
            this.sumButton.TabIndex = 11;
            this.sumButton.Text = "Сложить!";
            this.sumButton.UseVisualStyleBackColor = true;
            this.sumButton.Click += new System.EventHandler(this.sumButton_Click);
            // 
            // resultSum
            // 
            this.resultSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultSum.Location = new System.Drawing.Point(620, 396);
            this.resultSum.Multiline = true;
            this.resultSum.Name = "resultSum";
            this.resultSum.Size = new System.Drawing.Size(152, 32);
            this.resultSum.TabIndex = 12;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultSum);
            this.Controls.Add(this.sumButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.secondNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.firstNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sSSum);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sSSum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox firstNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox secondNumber;
        private System.Windows.Forms.Button sumButton;
        private System.Windows.Forms.TextBox resultSum;
    }
}