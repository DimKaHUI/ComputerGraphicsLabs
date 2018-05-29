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
            ((System.ComponentModel.ISupportInitialize)(this.DrawingCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // DrawingCanvas
            // 
            this.DrawingCanvas.BackColor = System.Drawing.Color.White;
            this.DrawingCanvas.Location = new System.Drawing.Point(12, 12);
            this.DrawingCanvas.Name = "DrawingCanvas";
            this.DrawingCanvas.Size = new System.Drawing.Size(677, 535);
            this.DrawingCanvas.TabIndex = 0;
            this.DrawingCanvas.TabStop = false;
            this.DrawingCanvas.Click += new System.EventHandler(this.DrawingCanvas_Click);
            // 
            // proceedButton
            // 
            this.proceedButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.proceedButton.Location = new System.Drawing.Point(695, 495);
            this.proceedButton.Name = "proceedButton";
            this.proceedButton.Size = new System.Drawing.Size(377, 23);
            this.proceedButton.TabIndex = 1;
            this.proceedButton.Text = "Отсечь";
            this.proceedButton.UseVisualStyleBackColor = true;
            this.proceedButton.Click += new System.EventHandler(this.proceedButton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(695, 393);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(377, 96);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(695, 524);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(377, 23);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Очистить";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // PolygonColorLabel
            // 
            this.PolygonColorLabel.AutoSize = true;
            this.PolygonColorLabel.Location = new System.Drawing.Point(695, 283);
            this.PolygonColorLabel.Name = "PolygonColorLabel";
            this.PolygonColorLabel.Size = new System.Drawing.Size(179, 13);
            this.PolygonColorLabel.TabIndex = 4;
            this.PolygonColorLabel.Text = "Цвет исходного многоугольника: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(775, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Цвет отсекателя: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(776, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Цвет результата: ";
            // 
            // colorPanelPolygon
            // 
            this.colorPanelPolygon.Location = new System.Drawing.Point(880, 283);
            this.colorPanelPolygon.Name = "colorPanelPolygon";
            this.colorPanelPolygon.Size = new System.Drawing.Size(20, 20);
            this.colorPanelPolygon.TabIndex = 7;
            // 
            // colorPanelCutter
            // 
            this.colorPanelCutter.Location = new System.Drawing.Point(880, 309);
            this.colorPanelCutter.Name = "colorPanelCutter";
            this.colorPanelCutter.Size = new System.Drawing.Size(20, 20);
            this.colorPanelCutter.TabIndex = 8;
            // 
            // colorPanelResult
            // 
            this.colorPanelResult.Location = new System.Drawing.Point(880, 335);
            this.colorPanelResult.Name = "colorPanelResult";
            this.colorPanelResult.Size = new System.Drawing.Size(20, 20);
            this.colorPanelResult.TabIndex = 9;
            // 
            // HiddenLabel
            // 
            this.HiddenLabel.AutoSize = true;
            this.HiddenLabel.Location = new System.Drawing.Point(695, 12);
            this.HiddenLabel.Name = "HiddenLabel";
            this.HiddenLabel.Size = new System.Drawing.Size(0, 13);
            this.HiddenLabel.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 559);
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
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

