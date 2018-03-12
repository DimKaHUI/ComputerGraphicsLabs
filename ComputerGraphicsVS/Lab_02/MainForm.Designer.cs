namespace Lab_02
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.DrawCanvas = new System.Windows.Forms.PictureBox();
            this.ScaleButt = new System.Windows.Forms.Button();
            this.ScaleXBox = new System.Windows.Forms.TextBox();
            this.ScaleYBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.RotYBox = new System.Windows.Forms.TextBox();
            this.RotXBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.RotAngleBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TranDyBox = new System.Windows.Forms.TextBox();
            this.TranDxBox = new System.Windows.Forms.TextBox();
            this.RedoButt = new System.Windows.Forms.Button();
            this.UndoButt = new System.Windows.Forms.Button();
            this.ToolTipElem = new System.Windows.Forms.ToolTip(this.components);
            this.ResetButt = new System.Windows.Forms.Button();
            this.UndoInfo = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.ScaleYCBox = new System.Windows.Forms.TextBox();
            this.ScaleXCBox = new System.Windows.Forms.TextBox();
            this.RotButt = new System.Windows.Forms.Button();
            this.TranslateButt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DrawCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // DrawCanvas
            // 
            this.DrawCanvas.BackColor = System.Drawing.Color.White;
            this.DrawCanvas.Location = new System.Drawing.Point(537, 11);
            this.DrawCanvas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DrawCanvas.Name = "DrawCanvas";
            this.DrawCanvas.Size = new System.Drawing.Size(1348, 974);
            this.DrawCanvas.TabIndex = 0;
            this.DrawCanvas.TabStop = false;
            // 
            // ScaleButt
            // 
            this.ScaleButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ScaleButt.Location = new System.Drawing.Point(18, 232);
            this.ScaleButt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ScaleButt.Name = "ScaleButt";
            this.ScaleButt.Size = new System.Drawing.Size(260, 58);
            this.ScaleButt.TabIndex = 1;
            this.ScaleButt.Text = "Масштабирование";
            this.ToolTipElem.SetToolTip(this.ScaleButt, "Применяет трансформирование к текущему изображению\r\nShortcut: Enter");
            this.ScaleButt.UseVisualStyleBackColor = true;
            this.ScaleButt.Click += new System.EventHandler(this.ProceedButt_Click);
            // 
            // ScaleXBox
            // 
            this.ScaleXBox.Location = new System.Drawing.Point(106, 37);
            this.ScaleXBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ScaleXBox.Name = "ScaleXBox";
            this.ScaleXBox.Size = new System.Drawing.Size(97, 26);
            this.ScaleXBox.TabIndex = 2;
            this.ScaleXBox.Text = "1";
            // 
            // ScaleYBox
            // 
            this.ScaleYBox.Location = new System.Drawing.Point(214, 37);
            this.ScaleYBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ScaleYBox.Name = "ScaleYBox";
            this.ScaleYBox.Size = new System.Drawing.Size(97, 26);
            this.ScaleYBox.TabIndex = 3;
            this.ScaleYBox.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Масштаб";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kx";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(249, 12);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ky";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(249, 91);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Yc";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(146, 91);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Xc";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 118);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Поворот";
            // 
            // RotYBox
            // 
            this.RotYBox.Location = new System.Drawing.Point(214, 115);
            this.RotYBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RotYBox.Name = "RotYBox";
            this.RotYBox.Size = new System.Drawing.Size(97, 26);
            this.RotYBox.TabIndex = 8;
            this.RotYBox.Text = "0";
            // 
            // RotXBox
            // 
            this.RotXBox.Location = new System.Drawing.Point(106, 115);
            this.RotXBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RotXBox.Name = "RotXBox";
            this.RotXBox.Size = new System.Drawing.Size(97, 26);
            this.RotXBox.TabIndex = 7;
            this.RotXBox.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(330, 91);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Угол (град)";
            // 
            // RotAngleBox
            // 
            this.RotAngleBox.Location = new System.Drawing.Point(322, 115);
            this.RotAngleBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RotAngleBox.Name = "RotAngleBox";
            this.RotAngleBox.Size = new System.Drawing.Size(97, 26);
            this.RotAngleBox.TabIndex = 12;
            this.RotAngleBox.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(249, 168);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "dY";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(146, 168);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 20);
            this.label10.TabIndex = 17;
            this.label10.Text = "dX";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 195);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 20);
            this.label11.TabIndex = 16;
            this.label11.Text = "Перенос";
            // 
            // TranDyBox
            // 
            this.TranDyBox.Location = new System.Drawing.Point(214, 192);
            this.TranDyBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TranDyBox.Name = "TranDyBox";
            this.TranDyBox.Size = new System.Drawing.Size(97, 26);
            this.TranDyBox.TabIndex = 15;
            this.TranDyBox.Text = "0";
            // 
            // TranDxBox
            // 
            this.TranDxBox.Location = new System.Drawing.Point(106, 192);
            this.TranDxBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TranDxBox.Name = "TranDxBox";
            this.TranDxBox.Size = new System.Drawing.Size(97, 26);
            this.TranDxBox.TabIndex = 14;
            this.TranDxBox.Text = "0";
            // 
            // RedoButt
            // 
            this.RedoButt.Location = new System.Drawing.Point(129, 872);
            this.RedoButt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RedoButt.Name = "RedoButt";
            this.RedoButt.Size = new System.Drawing.Size(112, 35);
            this.RedoButt.TabIndex = 23;
            this.RedoButt.Text = "Повтор";
            this.ToolTipElem.SetToolTip(this.RedoButt, "Нажмите \"Применить\" чтобы подтвердить операцию\r\nShortcut: Ctrl + Y");
            this.RedoButt.UseVisualStyleBackColor = true;
            this.RedoButt.Click += new System.EventHandler(this.RedoButt_Click);
            // 
            // UndoButt
            // 
            this.UndoButt.Location = new System.Drawing.Point(8, 872);
            this.UndoButt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UndoButt.Name = "UndoButt";
            this.UndoButt.Size = new System.Drawing.Size(112, 35);
            this.UndoButt.TabIndex = 24;
            this.UndoButt.Text = "Отмена";
            this.ToolTipElem.SetToolTip(this.UndoButt, "Нажмите \"Применить\" для подтверждения\r\nShotcut: Ctrl + Z");
            this.UndoButt.UseVisualStyleBackColor = true;
            this.UndoButt.Click += new System.EventHandler(this.UndoButt_Click);
            // 
            // ResetButt
            // 
            this.ResetButt.ForeColor = System.Drawing.Color.Red;
            this.ResetButt.Location = new System.Drawing.Point(282, 232);
            this.ResetButt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ResetButt.Name = "ResetButt";
            this.ResetButt.Size = new System.Drawing.Size(246, 58);
            this.ResetButt.TabIndex = 30;
            this.ResetButt.Text = "Сбосить/Отобразить исходный";
            this.ToolTipElem.SetToolTip(this.ResetButt, "Сброс изображения до исходного");
            this.ResetButt.UseVisualStyleBackColor = true;
            this.ResetButt.Click += new System.EventHandler(this.ResetButt_Click);
            // 
            // UndoInfo
            // 
            this.UndoInfo.AutoSize = true;
            this.UndoInfo.Location = new System.Drawing.Point(249, 878);
            this.UndoInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UndoInfo.Name = "UndoInfo";
            this.UndoInfo.Size = new System.Drawing.Size(161, 20);
            this.UndoInfo.TabIndex = 25;
            this.UndoInfo.Text = "Count of undo steps: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(464, 12);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 20);
            this.label8.TabIndex = 29;
            this.label8.Text = "Yc";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(360, 12);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(28, 20);
            this.label13.TabIndex = 28;
            this.label13.Text = "Xc";
            // 
            // ScaleYCBox
            // 
            this.ScaleYCBox.Location = new System.Drawing.Point(429, 37);
            this.ScaleYCBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ScaleYCBox.Name = "ScaleYCBox";
            this.ScaleYCBox.Size = new System.Drawing.Size(97, 26);
            this.ScaleYCBox.TabIndex = 27;
            this.ScaleYCBox.Text = "0";
            // 
            // ScaleXCBox
            // 
            this.ScaleXCBox.Location = new System.Drawing.Point(321, 37);
            this.ScaleXCBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ScaleXCBox.Name = "ScaleXCBox";
            this.ScaleXCBox.Size = new System.Drawing.Size(97, 26);
            this.ScaleXCBox.TabIndex = 26;
            this.ScaleXCBox.Text = "0";
            // 
            // RotButt
            // 
            this.RotButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RotButt.Location = new System.Drawing.Point(18, 300);
            this.RotButt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RotButt.Name = "RotButt";
            this.RotButt.Size = new System.Drawing.Size(260, 58);
            this.RotButt.TabIndex = 31;
            this.RotButt.Text = "Поворот";
            this.ToolTipElem.SetToolTip(this.RotButt, "Применяет трансформирование к текущему изображению\r\nShortcut: Enter");
            this.RotButt.UseVisualStyleBackColor = true;
            this.RotButt.Click += new System.EventHandler(this.RotButt_Click);
            // 
            // TranslateButt
            // 
            this.TranslateButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TranslateButt.Location = new System.Drawing.Point(18, 368);
            this.TranslateButt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TranslateButt.Name = "TranslateButt";
            this.TranslateButt.Size = new System.Drawing.Size(260, 58);
            this.TranslateButt.TabIndex = 32;
            this.TranslateButt.Text = "Перенос";
            this.ToolTipElem.SetToolTip(this.TranslateButt, "Применяет трансформирование к текущему изображению\r\nShortcut: Enter");
            this.TranslateButt.UseVisualStyleBackColor = true;
            this.TranslateButt.Click += new System.EventHandler(this.TranslateButt_Click);
            // 
            // MainForm
            // 
            this.AcceptButton = this.ScaleButt;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 692);
            this.Controls.Add(this.TranslateButt);
            this.Controls.Add(this.RotButt);
            this.Controls.Add(this.ResetButt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.ScaleYCBox);
            this.Controls.Add(this.ScaleXCBox);
            this.Controls.Add(this.UndoInfo);
            this.Controls.Add(this.UndoButt);
            this.Controls.Add(this.RedoButt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TranDyBox);
            this.Controls.Add(this.TranDxBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.RotAngleBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.RotYBox);
            this.Controls.Add(this.RotXBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ScaleYBox);
            this.Controls.Add(this.ScaleXBox);
            this.Controls.Add(this.ScaleButt);
            this.Controls.Add(this.DrawCanvas);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.DrawCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox DrawCanvas;
        private System.Windows.Forms.Button ScaleButt;
        private System.Windows.Forms.TextBox ScaleXBox;
        private System.Windows.Forms.TextBox ScaleYBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox RotYBox;
        private System.Windows.Forms.TextBox RotXBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox RotAngleBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TranDyBox;
        private System.Windows.Forms.TextBox TranDxBox;
        private System.Windows.Forms.Button RedoButt;
        private System.Windows.Forms.Button UndoButt;
        private System.Windows.Forms.ToolTip ToolTipElem;
        private System.Windows.Forms.Label UndoInfo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox ScaleYCBox;
        private System.Windows.Forms.TextBox ScaleXCBox;
        private System.Windows.Forms.Button ResetButt;
        private System.Windows.Forms.Button RotButt;
        private System.Windows.Forms.Button TranslateButt;
    }
}