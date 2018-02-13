using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Lab_01
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private IContainer components = null;

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
            this.components = new System.ComponentModel.Container();
            this.DrawCanvas = new System.Windows.Forms.PictureBox();
            this.PointGrid = new System.Windows.Forms.DataGridView();
            this.PointX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PointY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IndexCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProceedButton = new System.Windows.Forms.Button();
            this.GeneratePointsButton = new System.Windows.Forms.Button();
            this.GenInputBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.DelRowButt = new System.Windows.Forms.Button();
            this.DeleteAllButton = new System.Windows.Forms.Button();
            this.ToolTipDef = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DrawCanvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PointGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // DrawCanvas
            // 
            this.DrawCanvas.BackColor = System.Drawing.Color.White;
            this.DrawCanvas.Location = new System.Drawing.Point(538, 12);
            this.DrawCanvas.Name = "DrawCanvas";
            this.DrawCanvas.Size = new System.Drawing.Size(550, 550);
            this.DrawCanvas.TabIndex = 0;
            this.DrawCanvas.TabStop = false;
            // 
            // PointGrid
            // 
            this.PointGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PointGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PointX,
            this.PointY,
            this.IndexCol});
            this.PointGrid.Location = new System.Drawing.Point(12, 12);
            this.PointGrid.Name = "PointGrid";
            this.PointGrid.RowTemplate.Height = 28;
            this.PointGrid.Size = new System.Drawing.Size(428, 550);
            this.PointGrid.TabIndex = 1;
            this.PointGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PointGrid_CellContentClick);
            this.PointGrid.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.PointGrid_RowsAdded);
            this.PointGrid.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.PointGrid_RowsRemoved);
            // 
            // PointX
            // 
            this.PointX.HeaderText = "X";
            this.PointX.Name = "PointX";
            this.PointX.Width = 80;
            // 
            // PointY
            // 
            this.PointY.DividerWidth = 5;
            this.PointY.HeaderText = "Y";
            this.PointY.Name = "PointY";
            this.PointY.Width = 80;
            // 
            // IndexCol
            // 
            this.IndexCol.HeaderText = "Index";
            this.IndexCol.Name = "IndexCol";
            this.IndexCol.ReadOnly = true;
            this.IndexCol.Width = 60;
            // 
            // ProceedButton
            // 
            this.ProceedButton.Location = new System.Drawing.Point(12, 573);
            this.ProceedButton.Name = "ProceedButton";
            this.ProceedButton.Size = new System.Drawing.Size(82, 35);
            this.ProceedButton.TabIndex = 2;
            this.ProceedButton.Text = "Proceed";
            this.ToolTipDef.SetToolTip(this.ProceedButton, "Finds the triangle and draws it");
            this.ProceedButton.UseVisualStyleBackColor = true;
            this.ProceedButton.Click += new System.EventHandler(this.ProceedButton_Click);
            // 
            // GeneratePointsButton
            // 
            this.GeneratePointsButton.Location = new System.Drawing.Point(109, 573);
            this.GeneratePointsButton.Name = "GeneratePointsButton";
            this.GeneratePointsButton.Size = new System.Drawing.Size(92, 35);
            this.GeneratePointsButton.TabIndex = 3;
            this.GeneratePointsButton.Text = "Generate";
            this.ToolTipDef.SetToolTip(this.GeneratePointsButton, "Generates points randomly. Amount can be set up in text box to the right");
            this.GeneratePointsButton.UseVisualStyleBackColor = true;
            this.GeneratePointsButton.Click += new System.EventHandler(this.GeneratePointsButton_Click);
            // 
            // GenInputBox
            // 
            this.GenInputBox.Location = new System.Drawing.Point(207, 577);
            this.GenInputBox.Name = "GenInputBox";
            this.GenInputBox.Size = new System.Drawing.Size(100, 26);
            this.GenInputBox.TabIndex = 4;
            this.ToolTipDef.SetToolTip(this.GenInputBox, "Amount of points to generate");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(313, 580);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "points";
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(534, 580);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(0, 20);
            this.ResultLabel.TabIndex = 6;
            // 
            // DelRowButt
            // 
            this.DelRowButt.Location = new System.Drawing.Point(446, 12);
            this.DelRowButt.Name = "DelRowButt";
            this.DelRowButt.Size = new System.Drawing.Size(75, 32);
            this.DelRowButt.TabIndex = 7;
            this.DelRowButt.Text = "Delete";
            this.ToolTipDef.SetToolTip(this.DelRowButt, "Deletes row, which cell is selected");
            this.DelRowButt.UseVisualStyleBackColor = true;
            this.DelRowButt.Click += new System.EventHandler(this.DelRowButt_Click);
            // 
            // DeleteAllButton
            // 
            this.DeleteAllButton.Location = new System.Drawing.Point(446, 50);
            this.DeleteAllButton.Name = "DeleteAllButton";
            this.DeleteAllButton.Size = new System.Drawing.Size(75, 32);
            this.DeleteAllButton.TabIndex = 8;
            this.DeleteAllButton.Text = "Del All";
            this.ToolTipDef.SetToolTip(this.DeleteAllButton, "Deletes all points");
            this.DeleteAllButton.UseVisualStyleBackColor = true;
            this.DeleteAllButton.Click += new System.EventHandler(this.DeleteAllButton_Click);
            // 
            // MainForm
            // 
            this.AcceptButton = this.ProceedButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 622);
            this.Controls.Add(this.DeleteAllButton);
            this.Controls.Add(this.DelRowButt);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GenInputBox);
            this.Controls.Add(this.GeneratePointsButton);
            this.Controls.Add(this.ProceedButton);
            this.Controls.Add(this.PointGrid);
            this.Controls.Add(this.DrawCanvas);
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.Text = "Task One";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DrawCanvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PointGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox DrawCanvas;
        private DataGridView PointGrid;
        private Button ProceedButton;
        private Button GeneratePointsButton;
        private TextBox GenInputBox;
        private Label label1;
        private Label ResultLabel;
        private Button DelRowButt;
        private DataGridViewTextBoxColumn PointX;
        private DataGridViewTextBoxColumn PointY;
        private DataGridViewTextBoxColumn IndexCol;
        private Button DeleteAllButton;
        private ToolTip ToolTipDef;
    }
}

