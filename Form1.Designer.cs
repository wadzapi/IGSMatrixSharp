namespace Matrixes
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelA = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.MatrixOperOpts = new System.Windows.Forms.GroupBox();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton12 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton13 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton11 = new System.Windows.Forms.RadioButton();
            this.MatrixFillOpts = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.MatrixTypeOpts = new System.Windows.Forms.GroupBox();
            this.MatrixOperOpts.SuspendLayout();
            this.MatrixFillOpts.SuspendLayout();
            this.MatrixTypeOpts.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelA.Location = new System.Drawing.Point(36, 123);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(75, 20);
            this.labelA.TabIndex = 0;
            this.labelA.Text = "Матрица A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(400, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Матрица B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(400, 362);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Результат";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(521, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 36);
            this.button1.TabIndex = 6;
            this.button1.Text = "Заполнить A";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(521, 61);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 37);
            this.button2.TabIndex = 7;
            this.button2.Text = "Заполнить B";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(21, 558);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(339, 40);
            this.button3.TabIndex = 8;
            this.button3.Text = "Посчитать";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // MatrixOperOpts
            // 
            this.MatrixOperOpts.Controls.Add(this.radioButton6);
            this.MatrixOperOpts.Controls.Add(this.textBox5);
            this.MatrixOperOpts.Controls.Add(this.radioButton5);
            this.MatrixOperOpts.Controls.Add(this.radioButton10);
            this.MatrixOperOpts.Controls.Add(this.textBox4);
            this.MatrixOperOpts.Controls.Add(this.radioButton7);
            this.MatrixOperOpts.Controls.Add(this.radioButton8);
            this.MatrixOperOpts.Controls.Add(this.radioButton12);
            this.MatrixOperOpts.Controls.Add(this.radioButton4);
            this.MatrixOperOpts.Controls.Add(this.radioButton9);
            this.MatrixOperOpts.Controls.Add(this.radioButton13);
            this.MatrixOperOpts.Controls.Add(this.radioButton11);
            this.MatrixOperOpts.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MatrixOperOpts.Location = new System.Drawing.Point(12, 370);
            this.MatrixOperOpts.Name = "MatrixOperOpts";
            this.MatrixOperOpts.Size = new System.Drawing.Size(348, 167);
            this.MatrixOperOpts.TabIndex = 10;
            this.MatrixOperOpts.TabStop = false;
            this.MatrixOperOpts.Text = "Операции над матрицами";
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(193, 83);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(126, 20);
            this.radioButton6.TabIndex = 2;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Транспонировать A";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(131, 108);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(26, 22);
            this.textBox5.TabIndex = 11;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(23, 21);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(100, 20);
            this.radioButton5.TabIndex = 1;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Сложить A + B";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.Location = new System.Drawing.Point(23, 47);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(97, 20);
            this.radioButton10.TabIndex = 7;
            this.radioButton10.TabStop = true;
            this.radioButton10.Text = "Вычесть A - B";
            this.radioButton10.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(301, 108);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(28, 22);
            this.textBox4.TabIndex = 6;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(193, 57);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(112, 20);
            this.radioButton7.TabIndex = 3;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "Умножить B на A";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(23, 105);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(102, 20);
            this.radioButton8.TabIndex = 4;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "Умножить A на";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton12
            // 
            this.radioButton12.AutoSize = true;
            this.radioButton12.Location = new System.Drawing.Point(23, 79);
            this.radioButton12.Name = "radioButton12";
            this.radioButton12.Size = new System.Drawing.Size(126, 20);
            this.radioButton12.TabIndex = 9;
            this.radioButton12.TabStop = true;
            this.radioButton12.Text = "Транспонировать B";
            this.radioButton12.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Checked = true;
            this.radioButton4.Location = new System.Drawing.Point(193, 31);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(112, 20);
            this.radioButton4.TabIndex = 0;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Умножить A на B";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton13
            // 
            this.radioButton13.AutoSize = true;
            this.radioButton13.Location = new System.Drawing.Point(193, 110);
            this.radioButton13.Name = "radioButton13";
            this.radioButton13.Size = new System.Drawing.Size(102, 20);
            this.radioButton13.TabIndex = 10;
            this.radioButton13.TabStop = true;
            this.radioButton13.Text = "Умножить B на";
            this.radioButton13.UseVisualStyleBackColor = true;
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Location = new System.Drawing.Point(23, 134);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(110, 20);
            this.radioButton9.TabIndex = 5;
            this.radioButton9.TabStop = true;
            this.radioButton9.Text = "Определитель А";
            this.radioButton9.UseVisualStyleBackColor = true;
            // 
            // radioButton11
            // 
            this.radioButton11.AutoSize = true;
            this.radioButton11.Location = new System.Drawing.Point(193, 134);
            this.radioButton11.Name = "radioButton11";
            this.radioButton11.Size = new System.Drawing.Size(110, 20);
            this.radioButton11.TabIndex = 8;
            this.radioButton11.TabStop = true;
            this.radioButton11.Text = "Определитель B";
            this.radioButton11.UseVisualStyleBackColor = true;
            // 
            // MatrixFillOpts
            // 
            this.MatrixFillOpts.Controls.Add(this.textBox3);
            this.MatrixFillOpts.Controls.Add(this.radioButton3);
            this.MatrixFillOpts.Controls.Add(this.radioButton2);
            this.MatrixFillOpts.Controls.Add(this.radioButton1);
            this.MatrixFillOpts.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MatrixFillOpts.Location = new System.Drawing.Point(323, 12);
            this.MatrixFillOpts.Name = "MatrixFillOpts";
            this.MatrixFillOpts.Size = new System.Drawing.Size(174, 108);
            this.MatrixFillOpts.TabIndex = 11;
            this.MatrixFillOpts.TabStop = false;
            this.MatrixFillOpts.Text = "Параметры заполнения";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(83, 71);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(34, 22);
            this.textBox3.TabIndex = 3;
            this.textBox3.Text = "10";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(11, 71);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(66, 20);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "Числом ";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(11, 45);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(136, 20);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Случайными числами";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(11, 23);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(71, 20);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Вручную";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Вид матрицы";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Прямоугольная",
            "Диагональная",
            "Трехдиагональная",
            "Верхняя треугольная",
            "Нижняя треугольная"});
            this.comboBox1.Location = new System.Drawing.Point(9, 64);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(237, 24);
            this.comboBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Размерность";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(91, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(29, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "10";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(128, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "x";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(148, 21);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(29, 22);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "10";
            // 
            // MatrixTypeOpts
            // 
            this.MatrixTypeOpts.Controls.Add(this.comboBox1);
            this.MatrixTypeOpts.Controls.Add(this.textBox2);
            this.MatrixTypeOpts.Controls.Add(this.label5);
            this.MatrixTypeOpts.Controls.Add(this.label4);
            this.MatrixTypeOpts.Controls.Add(this.textBox1);
            this.MatrixTypeOpts.Controls.Add(this.label1);
            this.MatrixTypeOpts.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MatrixTypeOpts.Location = new System.Drawing.Point(12, 12);
            this.MatrixTypeOpts.Name = "MatrixTypeOpts";
            this.MatrixTypeOpts.Size = new System.Drawing.Size(305, 108);
            this.MatrixTypeOpts.TabIndex = 9;
            this.MatrixTypeOpts.TabStop = false;
            this.MatrixTypeOpts.Text = "Параметры матрицы";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 610);
            this.Controls.Add(this.MatrixFillOpts);
            this.Controls.Add(this.MatrixOperOpts);
            this.Controls.Add(this.MatrixTypeOpts);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelA);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Матричные операции - Записочный В.В. 4011П-2Д";
            this.MatrixOperOpts.ResumeLayout(false);
            this.MatrixOperOpts.PerformLayout();
            this.MatrixFillOpts.ResumeLayout(false);
            this.MatrixFillOpts.PerformLayout();
            this.MatrixTypeOpts.ResumeLayout(false);
            this.MatrixTypeOpts.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox MatrixOperOpts;
        private System.Windows.Forms.GroupBox MatrixFillOpts;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox MatrixTypeOpts;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.RadioButton radioButton13;
        private System.Windows.Forms.RadioButton radioButton12;
        private System.Windows.Forms.RadioButton radioButton11;
        private System.Windows.Forms.RadioButton radioButton10;
        private System.Windows.Forms.TextBox textBox4;
    }
}

