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
            this.panel1 = new System.Windows.Forms.Panel();
            this.PosLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DrawCanvas)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DrawCanvas
            // 
            this.DrawCanvas.BackColor = System.Drawing.Color.White;
            this.DrawCanvas.Location = new System.Drawing.Point(524, 18);
            this.DrawCanvas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DrawCanvas.Name = "DrawCanvas";
            this.DrawCanvas.Size = new System.Drawing.Size(675, 680);
            this.DrawCanvas.TabIndex = 0;
            this.DrawCanvas.TabStop = false;
            // 
            // ProceedButt
            // 
            this.ProceedButt.Location = new System.Drawing.Point(18, 232);
            this.ProceedButt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProceedButt.Name = "ProceedButt";
            this.ProceedButt.Size = new System.Drawing.Size(496, 35);
            this.ProceedButt.TabIndex = 1;
            this.ProceedButt.Text = "Apply";
            this.ProceedButt.UseVisualStyleBackColor = true;
            this.ProceedButt.Click += new System.EventHandler(this.ProceedButt_Click);
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
            this.label1.Location = new System.Drawing.Point(48, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Scale";
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
            this.label6.Location = new System.Drawing.Point(28, 120);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Rotation";
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
            this.label7.Size = new System.Drawing.Size(91, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Angle (deg)";
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
            this.label11.Location = new System.Drawing.Point(10, 197);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 20);
            this.label11.TabIndex = 16;
            this.label11.Text = "Translation";
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
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 17);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(125, 20);
            this.label12.TabIndex = 20;
            this.label12.Text = "Current position:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PosLabel);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Location = new System.Drawing.Point(33, 646);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 52);
            this.panel1.TabIndex = 22;
            // 
            // PosLabel
            // 
            this.PosLabel.AutoSize = true;
            this.PosLabel.Location = new System.Drawing.Point(148, 17);
            this.PosLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PosLabel.Name = "PosLabel";
            this.PosLabel.Size = new System.Drawing.Size(45, 20);
            this.PosLabel.TabIndex = 23;
            this.PosLabel.Text = "(0, 0)";
            // 
            // MainForm
            // 
            this.AcceptButton = this.ProceedButt;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 717);
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
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label PosLabel;
    }
}