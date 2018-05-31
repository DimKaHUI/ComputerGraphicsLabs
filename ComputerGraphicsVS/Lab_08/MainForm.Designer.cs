namespace Lab_08
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.DrawingCanvas = new System.Windows.Forms.PictureBox();
            this.LinePointsTable = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PolygonPointsTable = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProceedButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.colorPanelResult = new System.Windows.Forms.Panel();
            this.colorPanelCutter = new System.Windows.Forms.Panel();
            this.colorPanelSource = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PolygonColorLabel = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DrawingCanvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LinePointsTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PolygonPointsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // DrawingCanvas
            // 
            this.DrawingCanvas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DrawingCanvas.BackColor = System.Drawing.Color.White;
            this.DrawingCanvas.Location = new System.Drawing.Point(411, 12);
            this.DrawingCanvas.Name = "DrawingCanvas";
            this.DrawingCanvas.Size = new System.Drawing.Size(761, 537);
            this.DrawingCanvas.TabIndex = 0;
            this.DrawingCanvas.TabStop = false;
            this.DrawingCanvas.Click += new System.EventHandler(this.DrawingCanvas_Click);
            // 
            // LinePointsTable
            // 
            this.LinePointsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LinePointsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.LinePointsTable.Location = new System.Drawing.Point(12, 12);
            this.LinePointsTable.Name = "LinePointsTable";
            this.LinePointsTable.Size = new System.Drawing.Size(344, 150);
            this.LinePointsTable.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "X1";
            this.Column1.Name = "Column1";
            this.Column1.Width = 75;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Y1";
            this.Column2.Name = "Column2";
            this.Column2.Width = 75;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "X2";
            this.Column3.Name = "Column3";
            this.Column3.Width = 75;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Y2";
            this.Column4.Name = "Column4";
            this.Column4.Width = 75;
            // 
            // PolygonPointsTable
            // 
            this.PolygonPointsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PolygonPointsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.PolygonPointsTable.Location = new System.Drawing.Point(12, 187);
            this.PolygonPointsTable.Name = "PolygonPointsTable";
            this.PolygonPointsTable.Size = new System.Drawing.Size(194, 150);
            this.PolygonPointsTable.TabIndex = 16;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "X";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 75;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Y";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 70;
            // 
            // ProceedButton
            // 
            this.ProceedButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProceedButton.Location = new System.Drawing.Point(12, 526);
            this.ProceedButton.Name = "ProceedButton";
            this.ProceedButton.Size = new System.Drawing.Size(344, 23);
            this.ProceedButton.TabIndex = 17;
            this.ProceedButton.Text = "Провести отсечение";
            this.ProceedButton.UseVisualStyleBackColor = true;
            this.ProceedButton.Click += new System.EventHandler(this.ProceedButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(12, 497);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(344, 23);
            this.ClearButton.TabIndex = 18;
            this.ClearButton.Text = "Очистить";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // colorPanelResult
            // 
            this.colorPanelResult.Location = new System.Drawing.Point(354, 232);
            this.colorPanelResult.Name = "colorPanelResult";
            this.colorPanelResult.Size = new System.Drawing.Size(20, 20);
            this.colorPanelResult.TabIndex = 25;
            // 
            // colorPanelCutter
            // 
            this.colorPanelCutter.Location = new System.Drawing.Point(354, 206);
            this.colorPanelCutter.Name = "colorPanelCutter";
            this.colorPanelCutter.Size = new System.Drawing.Size(20, 20);
            this.colorPanelCutter.TabIndex = 24;
            // 
            // colorPanelSource
            // 
            this.colorPanelSource.Location = new System.Drawing.Point(354, 180);
            this.colorPanelSource.Name = "colorPanelSource";
            this.colorPanelSource.Size = new System.Drawing.Size(20, 20);
            this.colorPanelSource.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Цвет результата: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(249, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Цвет отсекателя: ";
            // 
            // PolygonColorLabel
            // 
            this.PolygonColorLabel.AutoSize = true;
            this.PolygonColorLabel.Location = new System.Drawing.Point(212, 187);
            this.PolygonColorLabel.Name = "PolygonColorLabel";
            this.PolygonColorLabel.Size = new System.Drawing.Size(136, 13);
            this.PolygonColorLabel.TabIndex = 20;
            this.PolygonColorLabel.Text = "Цвет исходных отрезков:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 343);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(393, 148);
            this.richTextBox1.TabIndex = 19;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.colorPanelResult);
            this.Controls.Add(this.colorPanelCutter);
            this.Controls.Add(this.colorPanelSource);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PolygonColorLabel);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.ProceedButton);
            this.Controls.Add(this.PolygonPointsTable);
            this.Controls.Add(this.LinePointsTable);
            this.Controls.Add(this.DrawingCanvas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainForm";
            this.Text = "Lab_08";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DrawingCanvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LinePointsTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PolygonPointsTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox DrawingCanvas;
        private System.Windows.Forms.DataGridView LinePointsTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridView PolygonPointsTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button ProceedButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Panel colorPanelResult;
        private System.Windows.Forms.Panel colorPanelCutter;
        private System.Windows.Forms.Panel colorPanelSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label PolygonColorLabel;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

