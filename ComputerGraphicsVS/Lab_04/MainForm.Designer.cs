namespace Lab_04
{
    partial class MainForm
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
            this.DrawingCanvas = new System.Windows.Forms.PictureBox();
            this.AlgorithmBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.EllipseRadio = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.CircleRadio = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.BackWhiteRadio = new System.Windows.Forms.RadioButton();
            this.BackRedRadio = new System.Windows.Forms.RadioButton();
            this.BackBlackRadio = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.WhiteRadio = new System.Windows.Forms.RadioButton();
            this.RedRadio = new System.Windows.Forms.RadioButton();
            this.BlackRadio = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.DrawButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.CircleParamsPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CircleXBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CircleYBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.CircleRadiusBox = new System.Windows.Forms.TextBox();
            this.EllipseParamsPanel = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.EllipseYBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.EllipseXBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.EllipseBBox = new System.Windows.Forms.TextBox();
            this.EllipseABox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DrawingCanvas)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.CircleParamsPanel.SuspendLayout();
            this.EllipseParamsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DrawingCanvas
            // 
            this.DrawingCanvas.BackColor = System.Drawing.Color.White;
            this.DrawingCanvas.Location = new System.Drawing.Point(344, 12);
            this.DrawingCanvas.Name = "DrawingCanvas";
            this.DrawingCanvas.Size = new System.Drawing.Size(598, 488);
            this.DrawingCanvas.TabIndex = 0;
            this.DrawingCanvas.TabStop = false;
            // 
            // AlgorithmBox
            // 
            this.AlgorithmBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AlgorithmBox.FormattingEnabled = true;
            this.AlgorithmBox.Items.AddRange(new object[] {
            "Канонические уравнения",
            "Параметрические уравнения",
            "Брезенхема",
            "Средней точки",
            "Библиотечный"});
            this.AlgorithmBox.Location = new System.Drawing.Point(12, 35);
            this.AlgorithmBox.Name = "AlgorithmBox";
            this.AlgorithmBox.Size = new System.Drawing.Size(326, 21);
            this.AlgorithmBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Алгоритм:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.EllipseRadio);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.CircleRadio);
            this.panel1.Location = new System.Drawing.Point(15, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(323, 64);
            this.panel1.TabIndex = 3;
            // 
            // EllipseRadio
            // 
            this.EllipseRadio.AutoSize = true;
            this.EllipseRadio.Location = new System.Drawing.Point(6, 42);
            this.EllipseRadio.Name = "EllipseRadio";
            this.EllipseRadio.Size = new System.Drawing.Size(62, 17);
            this.EllipseRadio.TabIndex = 4;
            this.EllipseRadio.Text = "Эллипс";
            this.EllipseRadio.UseVisualStyleBackColor = true;
            this.EllipseRadio.CheckedChanged += new System.EventHandler(this.CircleRadio_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Фигура:";
            // 
            // CircleRadio
            // 
            this.CircleRadio.AutoSize = true;
            this.CircleRadio.Checked = true;
            this.CircleRadio.Location = new System.Drawing.Point(6, 19);
            this.CircleRadio.Name = "CircleRadio";
            this.CircleRadio.Size = new System.Drawing.Size(87, 17);
            this.CircleRadio.TabIndex = 0;
            this.CircleRadio.TabStop = true;
            this.CircleRadio.Text = "Окружность";
            this.CircleRadio.UseVisualStyleBackColor = true;
            this.CircleRadio.CheckedChanged += new System.EventHandler(this.CircleRadio_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(15, 145);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(323, 121);
            this.panel2.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(115, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Цвет фона:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.BackWhiteRadio);
            this.panel4.Controls.Add(this.BackRedRadio);
            this.panel4.Controls.Add(this.BackBlackRadio);
            this.panel4.Location = new System.Drawing.Point(115, 35);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(89, 77);
            this.panel4.TabIndex = 7;
            // 
            // BackWhiteRadio
            // 
            this.BackWhiteRadio.AutoSize = true;
            this.BackWhiteRadio.Checked = true;
            this.BackWhiteRadio.Location = new System.Drawing.Point(3, 30);
            this.BackWhiteRadio.Name = "BackWhiteRadio";
            this.BackWhiteRadio.Size = new System.Drawing.Size(58, 17);
            this.BackWhiteRadio.TabIndex = 4;
            this.BackWhiteRadio.TabStop = true;
            this.BackWhiteRadio.Text = "Белый";
            this.BackWhiteRadio.UseVisualStyleBackColor = true;
            // 
            // BackRedRadio
            // 
            this.BackRedRadio.AutoSize = true;
            this.BackRedRadio.Location = new System.Drawing.Point(3, 53);
            this.BackRedRadio.Name = "BackRedRadio";
            this.BackRedRadio.Size = new System.Drawing.Size(70, 17);
            this.BackRedRadio.TabIndex = 5;
            this.BackRedRadio.Text = "Красный";
            this.BackRedRadio.UseVisualStyleBackColor = true;
            // 
            // BackBlackRadio
            // 
            this.BackBlackRadio.AutoSize = true;
            this.BackBlackRadio.Location = new System.Drawing.Point(3, 7);
            this.BackBlackRadio.Name = "BackBlackRadio";
            this.BackBlackRadio.Size = new System.Drawing.Size(65, 17);
            this.BackBlackRadio.TabIndex = 0;
            this.BackBlackRadio.Text = "Черный";
            this.BackBlackRadio.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.WhiteRadio);
            this.panel3.Controls.Add(this.RedRadio);
            this.panel3.Controls.Add(this.BlackRadio);
            this.panel3.Location = new System.Drawing.Point(6, 35);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(89, 77);
            this.panel3.TabIndex = 6;
            // 
            // WhiteRadio
            // 
            this.WhiteRadio.AutoSize = true;
            this.WhiteRadio.Location = new System.Drawing.Point(3, 30);
            this.WhiteRadio.Name = "WhiteRadio";
            this.WhiteRadio.Size = new System.Drawing.Size(58, 17);
            this.WhiteRadio.TabIndex = 4;
            this.WhiteRadio.Text = "Белый";
            this.WhiteRadio.UseVisualStyleBackColor = true;
            // 
            // RedRadio
            // 
            this.RedRadio.AutoSize = true;
            this.RedRadio.Location = new System.Drawing.Point(3, 53);
            this.RedRadio.Name = "RedRadio";
            this.RedRadio.Size = new System.Drawing.Size(70, 17);
            this.RedRadio.TabIndex = 5;
            this.RedRadio.Text = "Красный";
            this.RedRadio.UseVisualStyleBackColor = true;
            // 
            // BlackRadio
            // 
            this.BlackRadio.AutoSize = true;
            this.BlackRadio.Checked = true;
            this.BlackRadio.Location = new System.Drawing.Point(3, 7);
            this.BlackRadio.Name = "BlackRadio";
            this.BlackRadio.Size = new System.Drawing.Size(65, 17);
            this.BlackRadio.TabIndex = 0;
            this.BlackRadio.TabStop = true;
            this.BlackRadio.Text = "Черный";
            this.BlackRadio.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Цвет изображения:";
            // 
            // DrawButton
            // 
            this.DrawButton.Location = new System.Drawing.Point(15, 477);
            this.DrawButton.Name = "DrawButton";
            this.DrawButton.Size = new System.Drawing.Size(102, 23);
            this.DrawButton.TabIndex = 6;
            this.DrawButton.Text = "Построить";
            this.DrawButton.UseVisualStyleBackColor = true;
            this.DrawButton.Click += new System.EventHandler(this.DrawButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(123, 477);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(102, 23);
            this.ClearButton.TabIndex = 7;
            this.ClearButton.Text = "Очистить";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // CircleParamsPanel
            // 
            this.CircleParamsPanel.Controls.Add(this.label10);
            this.CircleParamsPanel.Controls.Add(this.CircleRadiusBox);
            this.CircleParamsPanel.Controls.Add(this.label9);
            this.CircleParamsPanel.Controls.Add(this.label8);
            this.CircleParamsPanel.Controls.Add(this.CircleYBox);
            this.CircleParamsPanel.Controls.Add(this.label7);
            this.CircleParamsPanel.Controls.Add(this.CircleXBox);
            this.CircleParamsPanel.Controls.Add(this.label6);
            this.CircleParamsPanel.Controls.Add(this.label5);
            this.CircleParamsPanel.Location = new System.Drawing.Point(15, 272);
            this.CircleParamsPanel.Name = "CircleParamsPanel";
            this.CircleParamsPanel.Size = new System.Drawing.Size(323, 199);
            this.CircleParamsPanel.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Параметры построения:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(137, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "окружность";
            // 
            // CircleXBox
            // 
            this.CircleXBox.Location = new System.Drawing.Point(50, 48);
            this.CircleXBox.Name = "CircleXBox";
            this.CircleXBox.Size = new System.Drawing.Size(41, 20);
            this.CircleXBox.TabIndex = 2;
            this.CircleXBox.Text = "100";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Центр:";
            // 
            // CircleYBox
            // 
            this.CircleYBox.Location = new System.Drawing.Point(97, 48);
            this.CircleYBox.Name = "CircleYBox";
            this.CircleYBox.Size = new System.Drawing.Size(41, 20);
            this.CircleYBox.TabIndex = 4;
            this.CircleYBox.Text = "100";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(51, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "X:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(104, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Y:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Радиус:";
            // 
            // CircleRadiusBox
            // 
            this.CircleRadiusBox.Location = new System.Drawing.Point(50, 74);
            this.CircleRadiusBox.Name = "CircleRadiusBox";
            this.CircleRadiusBox.Size = new System.Drawing.Size(88, 20);
            this.CircleRadiusBox.TabIndex = 7;
            this.CircleRadiusBox.Text = "50";
            // 
            // EllipseParamsPanel
            // 
            this.EllipseParamsPanel.Controls.Add(this.label11);
            this.EllipseParamsPanel.Controls.Add(this.label17);
            this.EllipseParamsPanel.Controls.Add(this.EllipseBBox);
            this.EllipseParamsPanel.Controls.Add(this.EllipseABox);
            this.EllipseParamsPanel.Controls.Add(this.label12);
            this.EllipseParamsPanel.Controls.Add(this.label13);
            this.EllipseParamsPanel.Controls.Add(this.EllipseYBox);
            this.EllipseParamsPanel.Controls.Add(this.label14);
            this.EllipseParamsPanel.Controls.Add(this.EllipseXBox);
            this.EllipseParamsPanel.Controls.Add(this.label15);
            this.EllipseParamsPanel.Controls.Add(this.label16);
            this.EllipseParamsPanel.Location = new System.Drawing.Point(15, 272);
            this.EllipseParamsPanel.Name = "EllipseParamsPanel";
            this.EllipseParamsPanel.Size = new System.Drawing.Size(323, 199);
            this.EllipseParamsPanel.TabIndex = 9;
            this.EllipseParamsPanel.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(104, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Y:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(51, 32);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(17, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "X:";
            // 
            // EllipseYBox
            // 
            this.EllipseYBox.Location = new System.Drawing.Point(97, 48);
            this.EllipseYBox.Name = "EllipseYBox";
            this.EllipseYBox.Size = new System.Drawing.Size(41, 20);
            this.EllipseYBox.TabIndex = 4;
            this.EllipseYBox.Text = "200";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 51);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "Центр:";
            // 
            // EllipseXBox
            // 
            this.EllipseXBox.Location = new System.Drawing.Point(50, 48);
            this.EllipseXBox.Name = "EllipseXBox";
            this.EllipseXBox.Size = new System.Drawing.Size(41, 20);
            this.EllipseXBox.TabIndex = 2;
            this.EllipseXBox.Text = "200";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(137, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 13);
            this.label15.TabIndex = 1;
            this.label15.Text = "эллипс";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(3, 9);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(131, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "Параметры построения:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(94, 81);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Высота:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(44, 81);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(49, 13);
            this.label17.TabIndex = 9;
            this.label17.Text = "Ширина:";
            // 
            // EllipseBBox
            // 
            this.EllipseBBox.Location = new System.Drawing.Point(97, 97);
            this.EllipseBBox.Name = "EllipseBBox";
            this.EllipseBBox.Size = new System.Drawing.Size(41, 20);
            this.EllipseBBox.TabIndex = 8;
            this.EllipseBBox.Text = "40";
            // 
            // EllipseABox
            // 
            this.EllipseABox.Location = new System.Drawing.Point(50, 97);
            this.EllipseABox.Name = "EllipseABox";
            this.EllipseABox.Size = new System.Drawing.Size(41, 20);
            this.EllipseABox.TabIndex = 7;
            this.EllipseABox.Text = "120";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 512);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.DrawButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AlgorithmBox);
            this.Controls.Add(this.DrawingCanvas);
            this.Controls.Add(this.EllipseParamsPanel);
            this.Controls.Add(this.CircleParamsPanel);
            this.Name = "MainForm";
            this.Text = "Lab_04";
            ((System.ComponentModel.ISupportInitialize)(this.DrawingCanvas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.CircleParamsPanel.ResumeLayout(false);
            this.CircleParamsPanel.PerformLayout();
            this.EllipseParamsPanel.ResumeLayout(false);
            this.EllipseParamsPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox DrawingCanvas;
        private System.Windows.Forms.ComboBox AlgorithmBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton EllipseRadio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton CircleRadio;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton BackWhiteRadio;
        private System.Windows.Forms.RadioButton BackRedRadio;
        private System.Windows.Forms.RadioButton BackBlackRadio;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton WhiteRadio;
        private System.Windows.Forms.RadioButton RedRadio;
        private System.Windows.Forms.RadioButton BlackRadio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button DrawButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Panel CircleParamsPanel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox CircleRadiusBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox CircleYBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox CircleXBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel EllipseParamsPanel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox EllipseBBox;
        private System.Windows.Forms.TextBox EllipseABox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox EllipseYBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox EllipseXBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
    }
}

