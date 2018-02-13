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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.RedoButt = new System.Windows.Forms.Button();
            this.UndoButt = new System.Windows.Forms.Button();
            this.ToolTipElem = new System.Windows.Forms.ToolTip(this.components);
            this.UndoInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DrawCanvas)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DrawCanvas
            // 
            this.DrawCanvas.BackColor = System.Drawing.Color.White;
            this.DrawCanvas.Location = new System.Drawing.Point(349, 12);
            this.DrawCanvas.Name = "DrawCanvas";
            this.DrawCanvas.Size = new System.Drawing.Size(450, 442);
            this.DrawCanvas.TabIndex = 0;
            this.DrawCanvas.TabStop = false;
            // 
            // ProceedButt
            // 
            this.ProceedButt.Location = new System.Drawing.Point(12, 151);
            this.ProceedButt.Name = "ProceedButt";
            this.ProceedButt.Size = new System.Drawing.Size(331, 23);
            this.ProceedButt.TabIndex = 1;
            this.ProceedButt.Text = "Apply";
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
            this.label1.Location = new System.Drawing.Point(32, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Scale";
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
            this.label6.Location = new System.Drawing.Point(19, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Rotation";
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
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Angle (deg)";
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
            this.label11.Location = new System.Drawing.Point(7, 128);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Translation";
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
            // panel1
            // 
            this.panel1.Controls.Add(this.label12);
            this.panel1.Location = new System.Drawing.Point(12, 180);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 71);
            this.panel1.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 11);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(187, 52);
            this.label12.TabIndex = 20;
            this.label12.Text = "Modifications are applyed in this order:\r\n1) Scale\r\n2) Rotation\r\n3) Translation";
            // 
            // RedoButt
            // 
            this.RedoButt.Location = new System.Drawing.Point(91, 431);
            this.RedoButt.Name = "RedoButt";
            this.RedoButt.Size = new System.Drawing.Size(75, 23);
            this.RedoButt.TabIndex = 23;
            this.RedoButt.Text = "Redo";
            this.ToolTipElem.SetToolTip(this.RedoButt, "Shortcut: Ctrl + Y");
            this.RedoButt.UseVisualStyleBackColor = true;
            this.RedoButt.Click += new System.EventHandler(this.RedoButt_Click);
            // 
            // UndoButt
            // 
            this.UndoButt.Location = new System.Drawing.Point(10, 431);
            this.UndoButt.Name = "UndoButt";
            this.UndoButt.Size = new System.Drawing.Size(75, 23);
            this.UndoButt.TabIndex = 24;
            this.UndoButt.Text = "Undo";
            this.ToolTipElem.SetToolTip(this.UndoButt, "Shotcut: Ctrl + Z");
            this.UndoButt.UseVisualStyleBackColor = true;
            this.UndoButt.Click += new System.EventHandler(this.UndoButt_Click);
            // 
            // UndoInfo
            // 
            this.UndoInfo.AutoSize = true;
            this.UndoInfo.Location = new System.Drawing.Point(172, 436);
            this.UndoInfo.Name = "UndoInfo";
            this.UndoInfo.Size = new System.Drawing.Size(108, 13);
            this.UndoInfo.TabIndex = 25;
            this.UndoInfo.Text = "Count of undo steps: ";
            // 
            // MainForm
            // 
            this.AcceptButton = this.ProceedButt;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 466);
            this.Controls.Add(this.UndoInfo);
            this.Controls.Add(this.UndoButt);
            this.Controls.Add(this.RedoButt);
            this.Controls.Add(this.panel1);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.DrawCanvas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button RedoButt;
        private System.Windows.Forms.Button UndoButt;
        private System.Windows.Forms.ToolTip ToolTipElem;
        private System.Windows.Forms.Label UndoInfo;
    }
}