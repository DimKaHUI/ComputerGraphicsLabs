namespace Lab_05
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.BackGreenRadio = new System.Windows.Forms.RadioButton();
            this.BackRedRadio = new System.Windows.Forms.RadioButton();
            this.BackBlackRadio = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.GreenRadio = new System.Windows.Forms.RadioButton();
            this.RedRadio = new System.Windows.Forms.RadioButton();
            this.BlackRadio = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.XBox = new System.Windows.Forms.TextBox();
            this.YBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddVertexButton = new System.Windows.Forms.Button();
            this.FinilizeButton = new System.Windows.Forms.Button();
            this.FillButton = new System.Windows.Forms.Button();
            this.FillDelayedButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DrawingCanvas)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // DrawingCanvas
            // 
            this.DrawingCanvas.BackColor = System.Drawing.Color.White;
            this.DrawingCanvas.Location = new System.Drawing.Point(360, 12);
            this.DrawingCanvas.Name = "DrawingCanvas";
            this.DrawingCanvas.Size = new System.Drawing.Size(1000, 642);
            this.DrawingCanvas.TabIndex = 0;
            this.DrawingCanvas.TabStop = false;
            this.DrawingCanvas.Click += new System.EventHandler(this.DrawingCanvas_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(13, 14);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(340, 186);
            this.panel2.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(172, 29);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Цвет заливки:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.BackGreenRadio);
            this.panel4.Controls.Add(this.BackRedRadio);
            this.panel4.Controls.Add(this.BackBlackRadio);
            this.panel4.Location = new System.Drawing.Point(172, 54);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(134, 118);
            this.panel4.TabIndex = 7;
            // 
            // BackGreenRadio
            // 
            this.BackGreenRadio.AutoSize = true;
            this.BackGreenRadio.Location = new System.Drawing.Point(4, 46);
            this.BackGreenRadio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BackGreenRadio.Name = "BackGreenRadio";
            this.BackGreenRadio.Size = new System.Drawing.Size(102, 24);
            this.BackGreenRadio.TabIndex = 4;
            this.BackGreenRadio.Text = "Зеленый";
            this.BackGreenRadio.UseVisualStyleBackColor = true;
            // 
            // BackRedRadio
            // 
            this.BackRedRadio.AutoSize = true;
            this.BackRedRadio.Checked = true;
            this.BackRedRadio.Location = new System.Drawing.Point(4, 82);
            this.BackRedRadio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BackRedRadio.Name = "BackRedRadio";
            this.BackRedRadio.Size = new System.Drawing.Size(99, 24);
            this.BackRedRadio.TabIndex = 5;
            this.BackRedRadio.TabStop = true;
            this.BackRedRadio.Text = "Красный";
            this.BackRedRadio.UseVisualStyleBackColor = true;
            // 
            // BackBlackRadio
            // 
            this.BackBlackRadio.AutoSize = true;
            this.BackBlackRadio.Location = new System.Drawing.Point(4, 11);
            this.BackBlackRadio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BackBlackRadio.Name = "BackBlackRadio";
            this.BackBlackRadio.Size = new System.Drawing.Size(93, 24);
            this.BackBlackRadio.TabIndex = 0;
            this.BackBlackRadio.Text = "Черный";
            this.BackBlackRadio.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.GreenRadio);
            this.panel3.Controls.Add(this.RedRadio);
            this.panel3.Controls.Add(this.BlackRadio);
            this.panel3.Location = new System.Drawing.Point(9, 54);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(134, 118);
            this.panel3.TabIndex = 6;
            // 
            // GreenRadio
            // 
            this.GreenRadio.AutoSize = true;
            this.GreenRadio.Location = new System.Drawing.Point(4, 46);
            this.GreenRadio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GreenRadio.Name = "GreenRadio";
            this.GreenRadio.Size = new System.Drawing.Size(102, 24);
            this.GreenRadio.TabIndex = 4;
            this.GreenRadio.Text = "Зелёный";
            this.GreenRadio.UseVisualStyleBackColor = true;
            // 
            // RedRadio
            // 
            this.RedRadio.AutoSize = true;
            this.RedRadio.Location = new System.Drawing.Point(4, 82);
            this.RedRadio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RedRadio.Name = "RedRadio";
            this.RedRadio.Size = new System.Drawing.Size(99, 24);
            this.RedRadio.TabIndex = 5;
            this.RedRadio.Text = "Красный";
            this.RedRadio.UseVisualStyleBackColor = true;
            // 
            // BlackRadio
            // 
            this.BlackRadio.AutoSize = true;
            this.BlackRadio.Checked = true;
            this.BlackRadio.Location = new System.Drawing.Point(4, 11);
            this.BlackRadio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BlackRadio.Name = "BlackRadio";
            this.BlackRadio.Size = new System.Drawing.Size(93, 24);
            this.BlackRadio.TabIndex = 0;
            this.BlackRadio.TabStop = true;
            this.BlackRadio.Text = "Черный";
            this.BlackRadio.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 29);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Цвет рёбер:";
            // 
            // XBox
            // 
            this.XBox.Location = new System.Drawing.Point(22, 238);
            this.XBox.Name = "XBox";
            this.XBox.Size = new System.Drawing.Size(100, 26);
            this.XBox.TabIndex = 7;
            this.XBox.Text = "500";
            // 
            // YBox
            // 
            this.YBox.Location = new System.Drawing.Point(128, 238);
            this.YBox.Name = "YBox";
            this.YBox.Size = new System.Drawing.Size(100, 26);
            this.YBox.TabIndex = 8;
            this.YBox.Text = "300";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Y:";
            // 
            // AddVertexButton
            // 
            this.AddVertexButton.Location = new System.Drawing.Point(22, 271);
            this.AddVertexButton.Name = "AddVertexButton";
            this.AddVertexButton.Size = new System.Drawing.Size(206, 63);
            this.AddVertexButton.TabIndex = 11;
            this.AddVertexButton.Text = "Добавить вершину по координатам";
            this.AddVertexButton.UseVisualStyleBackColor = true;
            this.AddVertexButton.Click += new System.EventHandler(this.AddVertexButton_Click);
            // 
            // FinilizeButton
            // 
            this.FinilizeButton.Location = new System.Drawing.Point(22, 340);
            this.FinilizeButton.Name = "FinilizeButton";
            this.FinilizeButton.Size = new System.Drawing.Size(206, 63);
            this.FinilizeButton.TabIndex = 12;
            this.FinilizeButton.Text = "Замкнуть многоугольник";
            this.FinilizeButton.UseVisualStyleBackColor = true;
            this.FinilizeButton.Click += new System.EventHandler(this.FinilizeButton_Click);
            // 
            // FillButton
            // 
            this.FillButton.Location = new System.Drawing.Point(22, 445);
            this.FillButton.Name = "FillButton";
            this.FillButton.Size = new System.Drawing.Size(206, 63);
            this.FillButton.TabIndex = 13;
            this.FillButton.Text = "Закрасить";
            this.FillButton.UseVisualStyleBackColor = true;
            this.FillButton.Click += new System.EventHandler(this.FillButton_Click);
            // 
            // FillDelayedButton
            // 
            this.FillDelayedButton.Location = new System.Drawing.Point(22, 514);
            this.FillDelayedButton.Name = "FillDelayedButton";
            this.FillDelayedButton.Size = new System.Drawing.Size(206, 63);
            this.FillDelayedButton.TabIndex = 14;
            this.FillDelayedButton.Text = "Закрасить с задержкой";
            this.FillDelayedButton.UseVisualStyleBackColor = true;
            this.FillDelayedButton.Click += new System.EventHandler(this.FillDelayedButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(22, 583);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(206, 63);
            this.ClearButton.TabIndex = 15;
            this.ClearButton.Text = "Очистить";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 666);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.FillDelayedButton);
            this.Controls.Add(this.FillButton);
            this.Controls.Add(this.FinilizeButton);
            this.Controls.Add(this.AddVertexButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.YBox);
            this.Controls.Add(this.XBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.DrawingCanvas);
            this.Name = "MainForm";
            this.Text = "Lab_05";
            ((System.ComponentModel.ISupportInitialize)(this.DrawingCanvas)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox DrawingCanvas;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton BackGreenRadio;
        private System.Windows.Forms.RadioButton BackRedRadio;
        private System.Windows.Forms.RadioButton BackBlackRadio;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton GreenRadio;
        private System.Windows.Forms.RadioButton RedRadio;
        private System.Windows.Forms.RadioButton BlackRadio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox XBox;
        private System.Windows.Forms.TextBox YBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddVertexButton;
        private System.Windows.Forms.Button FinilizeButton;
        private System.Windows.Forms.Button FillButton;
        private System.Windows.Forms.Button FillDelayedButton;
        private System.Windows.Forms.Button ClearButton;
    }
}

