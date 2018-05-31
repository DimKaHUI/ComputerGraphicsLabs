namespace Lab_09
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.DrawingCanvas = new System.Windows.Forms.PictureBox();
            this.proceedButton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.PolygonColorLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.colorPanelPolygon = new System.Windows.Forms.Panel();
            this.colorPanelCutter = new System.Windows.Forms.Panel();
            this.colorPanelResult = new System.Windows.Forms.Panel();
            this.HiddenLabel = new System.Windows.Forms.Label();
            this.xBox = new System.Windows.Forms.TextBox();
            this.yBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DrawingCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // DrawingCanvas
            // 
            this.DrawingCanvas.BackColor = System.Drawing.Color.White;
            this.DrawingCanvas.Location = new System.Drawing.Point(18, 18);
            this.DrawingCanvas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DrawingCanvas.Name = "DrawingCanvas";
            this.DrawingCanvas.Size = new System.Drawing.Size(1016, 823);
            this.DrawingCanvas.TabIndex = 0;
            this.DrawingCanvas.TabStop = false;
            this.DrawingCanvas.Click += new System.EventHandler(this.DrawingCanvas_Click);
            // 
            // proceedButton
            // 
            this.proceedButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.proceedButton.Location = new System.Drawing.Point(1042, 762);
            this.proceedButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.proceedButton.Name = "proceedButton";
            this.proceedButton.Size = new System.Drawing.Size(566, 35);
            this.proceedButton.TabIndex = 1;
            this.proceedButton.Text = "Отсечь";
            this.proceedButton.UseVisualStyleBackColor = true;
            this.proceedButton.Click += new System.EventHandler(this.proceedButton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(1042, 605);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(564, 146);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(1042, 806);
            this.clearButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(566, 35);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Очистить";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // PolygonColorLabel
            // 
            this.PolygonColorLabel.AutoSize = true;
            this.PolygonColorLabel.Location = new System.Drawing.Point(1042, 435);
            this.PolygonColorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PolygonColorLabel.Name = "PolygonColorLabel";
            this.PolygonColorLabel.Size = new System.Drawing.Size(264, 20);
            this.PolygonColorLabel.TabIndex = 4;
            this.PolygonColorLabel.Text = "Цвет исходного многоугольника: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1162, 475);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Цвет отсекателя: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1164, 515);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Цвет результата: ";
            // 
            // colorPanelPolygon
            // 
            this.colorPanelPolygon.Location = new System.Drawing.Point(1320, 435);
            this.colorPanelPolygon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.colorPanelPolygon.Name = "colorPanelPolygon";
            this.colorPanelPolygon.Size = new System.Drawing.Size(30, 31);
            this.colorPanelPolygon.TabIndex = 7;
            // 
            // colorPanelCutter
            // 
            this.colorPanelCutter.Location = new System.Drawing.Point(1320, 475);
            this.colorPanelCutter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.colorPanelCutter.Name = "colorPanelCutter";
            this.colorPanelCutter.Size = new System.Drawing.Size(30, 31);
            this.colorPanelCutter.TabIndex = 8;
            // 
            // colorPanelResult
            // 
            this.colorPanelResult.Location = new System.Drawing.Point(1320, 515);
            this.colorPanelResult.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.colorPanelResult.Name = "colorPanelResult";
            this.colorPanelResult.Size = new System.Drawing.Size(30, 31);
            this.colorPanelResult.TabIndex = 9;
            // 
            // HiddenLabel
            // 
            this.HiddenLabel.AutoSize = true;
            this.HiddenLabel.Location = new System.Drawing.Point(1042, 18);
            this.HiddenLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HiddenLabel.Name = "HiddenLabel";
            this.HiddenLabel.Size = new System.Drawing.Size(0, 20);
            this.HiddenLabel.TabIndex = 10;
            // 
            // xBox
            // 
            this.xBox.Location = new System.Drawing.Point(1041, 195);
            this.xBox.Name = "xBox";
            this.xBox.Size = new System.Drawing.Size(122, 26);
            this.xBox.TabIndex = 11;
            // 
            // yBox
            // 
            this.yBox.Location = new System.Drawing.Point(1185, 195);
            this.yBox.Name = "yBox";
            this.yBox.Size = new System.Drawing.Size(121, 26);
            this.yBox.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1042, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "X";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1181, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Y";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1041, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 68);
            this.button1.TabIndex = 15;
            this.button1.Text = "Добавить к отсекателю";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1184, 227);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 68);
            this.button2.TabIndex = 16;
            this.button2.Text = "Добавить к многоугольнику";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1618, 860);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.yBox);
            this.Controls.Add(this.xBox);
            this.Controls.Add(this.HiddenLabel);
            this.Controls.Add(this.colorPanelResult);
            this.Controls.Add(this.colorPanelCutter);
            this.Controls.Add(this.colorPanelPolygon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PolygonColorLabel);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.proceedButton);
            this.Controls.Add(this.DrawingCanvas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Lab_09";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DrawingCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox DrawingCanvas;
        private System.Windows.Forms.Button proceedButton;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label PolygonColorLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel colorPanelPolygon;
        private System.Windows.Forms.Panel colorPanelCutter;
        private System.Windows.Forms.Panel colorPanelResult;
        private System.Windows.Forms.Label HiddenLabel;
        private System.Windows.Forms.TextBox xBox;
        private System.Windows.Forms.TextBox yBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

