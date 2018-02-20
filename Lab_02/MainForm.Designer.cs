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
            this.ProceedButt = new System.Windows.Forms.Button();
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
            this.label12 = new System.Windows.Forms.Label();
            this.RedoButt = new System.Windows.Forms.Button();
            this.UndoButt = new System.Windows.Forms.Button();
            this.ToolTipElem = new System.Windows.Forms.ToolTip(this.components);
            this.ResetButt = new System.Windows.Forms.Button();
            this.UndoInfo = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.ScaleYCBox = new System.Windows.Forms.TextBox();
            this.ScaleXCBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DrawCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // DrawCanvas
            // 
            this.DrawCanvas.BackColor = System.Drawing.Color.White;
            this.DrawCanvas.Location = new System.Drawing.Point(358, 7);
            this.DrawCanvas.Name = "DrawCanvas";
            this.DrawCanvas.Size = new System.Drawing.Size(899, 633);
            this.DrawCanvas.TabIndex = 0;
            this.DrawCanvas.TabStop = false;
            // 
            // ProceedButt
            // 
            this.ProceedButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProceedButt.Location = new System.Drawing.Point(12, 151);
            this.ProceedButt.Name = "ProceedButt";
            this.ProceedButt.Size = new System.Drawing.Size(173, 38);
            this.ProceedButt.TabIndex = 1;
            this.ProceedButt.Text = "Применить";
            this.ToolTipElem.SetToolTip(this.ProceedButt, "Applies transformation relatively to current state.\r\nShortcut: Enter");
            this.ProceedButt.UseVisualStyleBackColor = true;
            this.ProceedButt.Click += new System.EventHandler(this.ProceedButt_Click);
            // 
            // ScaleXBox
            // 
            this.ScaleXBox.Location = new System.Drawing.Point(71, 24);
            this.ScaleXBox.Name = "ScaleXBox";
            this.ScaleXBox.Size = new System.Drawing.Size(66, 20);
            this.ScaleXBox.TabIndex = 2;
            this.ScaleXBox.Text = "1";
            // 
            // ScaleYBox
            // 
            this.ScaleYBox.Location = new System.Drawing.Point(143, 24);
            this.ScaleYBox.Name = "ScaleYBox";
            this.ScaleYBox.Size = new System.Drawing.Size(66, 20);
            this.ScaleYBox.TabIndex = 3;
            this.ScaleYBox.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Масштаб";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kx";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(166, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ky";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(166, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Yc";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(97, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Xc";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Поворот";
            // 
            // RotYBox
            // 
            this.RotYBox.Location = new System.Drawing.Point(143, 75);
            this.RotYBox.Name = "RotYBox";
            this.RotYBox.Size = new System.Drawing.Size(66, 20);
            this.RotYBox.TabIndex = 8;
            this.RotYBox.Text = "0";
            // 
            // RotXBox
            // 
            this.RotXBox.Location = new System.Drawing.Point(71, 75);
            this.RotXBox.Name = "RotXBox";
            this.RotXBox.Size = new System.Drawing.Size(66, 20);
            this.RotXBox.TabIndex = 7;
            this.RotXBox.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(220, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Угол (град)";
            // 
            // RotAngleBox
            // 
            this.RotAngleBox.Location = new System.Drawing.Point(215, 75);
            this.RotAngleBox.Name = "RotAngleBox";
            this.RotAngleBox.Size = new System.Drawing.Size(66, 20);
            this.RotAngleBox.TabIndex = 12;
            this.RotAngleBox.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(166, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "dY";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(97, 109);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "dX";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 127);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Перенос";
            // 
            // TranDyBox
            // 
            this.TranDyBox.Location = new System.Drawing.Point(143, 125);
            this.TranDyBox.Name = "TranDyBox";
            this.TranDyBox.Size = new System.Drawing.Size(66, 20);
            this.TranDyBox.TabIndex = 15;
            this.TranDyBox.Text = "0";
            // 
            // TranDxBox
            // 
            this.TranDxBox.Location = new System.Drawing.Point(71, 125);
            this.TranDxBox.Name = "TranDxBox";
            this.TranDxBox.Size = new System.Drawing.Size(66, 20);
            this.TranDxBox.TabIndex = 14;
            this.TranDxBox.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 192);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(191, 52);
            this.label12.TabIndex = 20;
            this.label12.Text = "Изменения применяются в порядке\r\n1) Масштабирование\r\n2) Поворот\r\n3) Перенос";
            // 
            // RedoButt
            // 
            this.RedoButt.Location = new System.Drawing.Point(86, 567);
            this.RedoButt.Name = "RedoButt";
            this.RedoButt.Size = new System.Drawing.Size(75, 23);
            this.RedoButt.TabIndex = 23;
            this.RedoButt.Text = "Redo";
            this.ToolTipElem.SetToolTip(this.RedoButt, "Press \"Apply\" to confirm action\r\nShortcut: Ctrl + Y");
            this.RedoButt.UseVisualStyleBackColor = true;
            this.RedoButt.Click += new System.EventHandler(this.RedoButt_Click);
            // 
            // UndoButt
            // 
            this.UndoButt.Location = new System.Drawing.Point(5, 567);
            this.UndoButt.Name = "UndoButt";
            this.UndoButt.Size = new System.Drawing.Size(75, 23);
            this.UndoButt.TabIndex = 24;
            this.UndoButt.Text = "Undo";
            this.ToolTipElem.SetToolTip(this.UndoButt, "Press \"Apply\" to confirm action\r\nShotcut: Ctrl + Z");
            this.UndoButt.UseVisualStyleBackColor = true;
            this.UndoButt.Click += new System.EventHandler(this.UndoButt_Click);
            // 
            // ResetButt
            // 
            this.ResetButt.ForeColor = System.Drawing.Color.Red;
            this.ResetButt.Location = new System.Drawing.Point(188, 151);
            this.ResetButt.Name = "ResetButt";
            this.ResetButt.Size = new System.Drawing.Size(164, 38);
            this.ResetButt.TabIndex = 30;
            this.ResetButt.Text = "Сбосить/Отобразить исходный";
            this.ToolTipElem.SetToolTip(this.ResetButt, "Applies transformation relatively to current state.\r\nShortcut: Enter");
            this.ResetButt.UseVisualStyleBackColor = true;
            this.ResetButt.Click += new System.EventHandler(this.ResetButt_Click);
            // 
            // UndoInfo
            // 
            this.UndoInfo.AutoSize = true;
            this.UndoInfo.Location = new System.Drawing.Point(166, 571);
            this.UndoInfo.Name = "UndoInfo";
            this.UndoInfo.Size = new System.Drawing.Size(108, 13);
            this.UndoInfo.TabIndex = 25;
            this.UndoInfo.Text = "Count of undo steps: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(309, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Yc";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(240, 8);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(20, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "Xc";
            // 
            // ScaleYCBox
            // 
            this.ScaleYCBox.Location = new System.Drawing.Point(286, 24);
            this.ScaleYCBox.Name = "ScaleYCBox";
            this.ScaleYCBox.Size = new System.Drawing.Size(66, 20);
            this.ScaleYCBox.TabIndex = 27;
            this.ScaleYCBox.Text = "0";
            // 
            // ScaleXCBox
            // 
            this.ScaleXCBox.Location = new System.Drawing.Point(214, 24);
            this.ScaleXCBox.Name = "ScaleXCBox";
            this.ScaleXCBox.Size = new System.Drawing.Size(66, 20);
            this.ScaleXCBox.TabIndex = 26;
            this.ScaleXCBox.Text = "0";
            // 
            // MainForm
            // 
            this.AcceptButton = this.ProceedButt;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 450);
            this.Controls.Add(this.ResetButt);
            this.Controls.Add(this.label12);
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
            this.Controls.Add(this.ProceedButt);
            this.Controls.Add(this.DrawCanvas);
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.DrawCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox DrawCanvas;
        private System.Windows.Forms.Button ProceedButt;
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
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button RedoButt;
        private System.Windows.Forms.Button UndoButt;
        private System.Windows.Forms.ToolTip ToolTipElem;
        private System.Windows.Forms.Label UndoInfo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox ScaleYCBox;
        private System.Windows.Forms.TextBox ScaleXCBox;
        private System.Windows.Forms.Button ResetButt;
    }
}