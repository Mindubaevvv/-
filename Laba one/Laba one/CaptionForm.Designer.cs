namespace Laba_one
{
    partial class CaptionForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            PictureBox = new System.Windows.Forms.PictureBox();
            btnCreate = new System.Windows.Forms.Button();
            btnChange = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            btnCircle = new System.Windows.Forms.RadioButton();
            btnEllipse = new System.Windows.Forms.RadioButton();
            btnSquare = new System.Windows.Forms.RadioButton();
            btnTriangle = new System.Windows.Forms.RadioButton();
            btnUp = new System.Windows.Forms.Button();
            btnDown = new System.Windows.Forms.Button();
            btnRight = new System.Windows.Forms.Button();
            btnLeft = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)PictureBox).BeginInit();
            SuspendLayout();
            // 
            // PictureBox
            // 
            PictureBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            PictureBox.Location = new System.Drawing.Point(11, 16);
            PictureBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            PictureBox.Name = "PictureBox";
            PictureBox.Size = new System.Drawing.Size(2741, 1072);
            PictureBox.TabIndex = 0;
            PictureBox.TabStop = false;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            btnCreate.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnCreate.Location = new System.Drawing.Point(26, 1132);
            btnCreate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new System.Drawing.Size(276, 119);
            btnCreate.TabIndex = 1;
            btnCreate.Text = "Создать";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += BtnCreate_Click;
            // 
            // btnChange
            // 
            btnChange.BackColor = System.Drawing.SystemColors.ActiveBorder;
            btnChange.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnChange.Location = new System.Drawing.Point(26, 1275);
            btnChange.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            btnChange.Name = "btnChange";
            btnChange.Size = new System.Drawing.Size(276, 139);
            btnChange.TabIndex = 3;
            btnChange.Text = "Изменить кол-во";
            btnChange.UseVisualStyleBackColor = false;
            btnChange.Click += btnChange_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            btnDelete.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnDelete.Location = new System.Drawing.Point(2448, 1308);
            btnDelete.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(295, 117);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Удалить";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnCircle
            // 
            btnCircle.AutoSize = true;
            btnCircle.Checked = true;
            btnCircle.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnCircle.Location = new System.Drawing.Point(842, 1162);
            btnCircle.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            btnCircle.Name = "btnCircle";
            btnCircle.Size = new System.Drawing.Size(136, 52);
            btnCircle.TabIndex = 5;
            btnCircle.TabStop = true;
            btnCircle.Text = "Круг";
            btnCircle.UseVisualStyleBackColor = true;
            // 
            // btnEllipse
            // 
            btnEllipse.AutoSize = true;
            btnEllipse.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnEllipse.Location = new System.Drawing.Point(1207, 1322);
            btnEllipse.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            btnEllipse.Name = "btnEllipse";
            btnEllipse.Size = new System.Drawing.Size(185, 52);
            btnEllipse.TabIndex = 6;
            btnEllipse.Text = "Эллипс";
            btnEllipse.UseVisualStyleBackColor = true;
            // 
            // btnSquare
            // 
            btnSquare.AutoSize = true;
            btnSquare.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnSquare.Location = new System.Drawing.Point(1207, 1162);
            btnSquare.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            btnSquare.Name = "btnSquare";
            btnSquare.Size = new System.Drawing.Size(199, 52);
            btnSquare.TabIndex = 7;
            btnSquare.Text = "Квадрат";
            btnSquare.UseVisualStyleBackColor = true;
            // 
            // btnTriangle
            // 
            btnTriangle.AutoSize = true;
            btnTriangle.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnTriangle.Location = new System.Drawing.Point(842, 1322);
            btnTriangle.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            btnTriangle.Name = "btnTriangle";
            btnTriangle.Size = new System.Drawing.Size(279, 52);
            btnTriangle.TabIndex = 8;
            btnTriangle.Text = "Треугольник";
            btnTriangle.UseVisualStyleBackColor = true;
            // 
            // btnUp
            // 
            btnUp.BackColor = System.Drawing.SystemColors.ActiveBorder;
            btnUp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnUp.Location = new System.Drawing.Point(510, 1136);
            btnUp.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            btnUp.Name = "btnUp";
            btnUp.Size = new System.Drawing.Size(159, 86);
            btnUp.TabIndex = 9;
            btnUp.Text = "Вверх";
            btnUp.UseVisualStyleBackColor = false;
            btnUp.Click += btnUp_Click;
            // 
            // btnDown
            // 
            btnDown.BackColor = System.Drawing.SystemColors.ActiveBorder;
            btnDown.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnDown.Location = new System.Drawing.Point(510, 1326);
            btnDown.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            btnDown.Name = "btnDown";
            btnDown.Size = new System.Drawing.Size(159, 88);
            btnDown.TabIndex = 10;
            btnDown.Text = "Вниз";
            btnDown.UseVisualStyleBackColor = false;
            // 
            // btnRight
            // 
            btnRight.BackColor = System.Drawing.SystemColors.ActiveCaption;
            btnRight.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnRight.Location = new System.Drawing.Point(652, 1234);
            btnRight.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            btnRight.Name = "btnRight";
            btnRight.Size = new System.Drawing.Size(174, 80);
            btnRight.TabIndex = 11;
            btnRight.Text = "->";
            btnRight.UseVisualStyleBackColor = false;
            // 
            // btnLeft
            // 
            btnLeft.BackColor = System.Drawing.SystemColors.ActiveCaption;
            btnLeft.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnLeft.Location = new System.Drawing.Point(351, 1234);
            btnLeft.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            btnLeft.Name = "btnLeft";
            btnLeft.Size = new System.Drawing.Size(174, 80);
            btnLeft.TabIndex = 12;
            btnLeft.Text = "<-";
            btnLeft.UseVisualStyleBackColor = false;
            btnLeft.Click += btnLeft_Click;
            // 
            // CaptionForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(2769, 1439);
            Controls.Add(btnLeft);
            Controls.Add(btnRight);
            Controls.Add(btnDown);
            Controls.Add(btnUp);
            Controls.Add(btnTriangle);
            Controls.Add(btnSquare);
            Controls.Add(btnEllipse);
            Controls.Add(btnCircle);
            Controls.Add(btnDelete);
            Controls.Add(btnChange);
            Controls.Add(btnCreate);
            Controls.Add(PictureBox);
            Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            Name = "CaptionForm";
            Text = "CaptionForm";
            ((System.ComponentModel.ISupportInitialize)PictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.RadioButton btnCircle;
        private System.Windows.Forms.RadioButton btnEllipse;
        private System.Windows.Forms.RadioButton btnSquare;
        private System.Windows.Forms.RadioButton btnTriangle;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnLeft;
    }
}
