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
            pictureBox = new System.Windows.Forms.PictureBox();
            btnCreate = new System.Windows.Forms.Button();
            btnMove = new System.Windows.Forms.Button();
            btnChange = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            btnCircle = new System.Windows.Forms.RadioButton();
            btnEllipse = new System.Windows.Forms.RadioButton();
            btnSquare = new System.Windows.Forms.RadioButton();
            btnTriangle = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            pictureBox.Location = new System.Drawing.Point(11, 16);
            pictureBox.Margin = new System.Windows.Forms.Padding(6);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new System.Drawing.Size(2741, 1072);
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            pictureBox.Click += pictureBox1_Click;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            btnCreate.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnCreate.Location = new System.Drawing.Point(26, 1132);
            btnCreate.Margin = new System.Windows.Forms.Padding(6);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new System.Drawing.Size(276, 113);
            btnCreate.TabIndex = 1;
            btnCreate.Text = "Создать (1шт)";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += button1_Click;
            // 
            // btnMove
            // 
            btnMove.BackColor = System.Drawing.SystemColors.ActiveBorder;
            btnMove.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnMove.Location = new System.Drawing.Point(344, 1132);
            btnMove.Margin = new System.Windows.Forms.Padding(6);
            btnMove.Name = "btnMove";
            btnMove.Size = new System.Drawing.Size(295, 113);
            btnMove.TabIndex = 2;
            btnMove.Text = "Переместить";
            btnMove.UseVisualStyleBackColor = false;
            btnMove.Click += btnMove_Click;
            // 
            // btnChange
            // 
            btnChange.BackColor = System.Drawing.SystemColors.ActiveBorder;
            btnChange.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnChange.Location = new System.Drawing.Point(26, 1296);
            btnChange.Margin = new System.Windows.Forms.Padding(6);
            btnChange.Name = "btnChange";
            btnChange.Size = new System.Drawing.Size(276, 111);
            btnChange.TabIndex = 3;
            btnChange.Text = "Изменить кол-во расположение";
            btnChange.UseVisualStyleBackColor = false;
            btnChange.Click += btnChange_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            btnDelete.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnDelete.Location = new System.Drawing.Point(344, 1296);
            btnDelete.Margin = new System.Windows.Forms.Padding(6);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(295, 111);
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
            btnCircle.Location = new System.Drawing.Point(752, 1158);
            btnCircle.Margin = new System.Windows.Forms.Padding(6);
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
            btnEllipse.Location = new System.Drawing.Point(1099, 1322);
            btnEllipse.Margin = new System.Windows.Forms.Padding(6);
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
            btnSquare.Location = new System.Drawing.Point(1099, 1158);
            btnSquare.Margin = new System.Windows.Forms.Padding(6);
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
            btnTriangle.Location = new System.Drawing.Point(752, 1322);
            btnTriangle.Margin = new System.Windows.Forms.Padding(6);
            btnTriangle.Name = "btnTriangle";
            btnTriangle.Size = new System.Drawing.Size(279, 52);
            btnTriangle.TabIndex = 8;
            btnTriangle.Text = "Треугольник";
            btnTriangle.UseVisualStyleBackColor = true;
            // 
            // CaptionForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(2765, 1431);
            Controls.Add(btnTriangle);
            Controls.Add(btnSquare);
            Controls.Add(btnEllipse);
            Controls.Add(btnCircle);
            Controls.Add(btnDelete);
            Controls.Add(btnChange);
            Controls.Add(btnMove);
            Controls.Add(btnCreate);
            Controls.Add(pictureBox);
            Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Margin = new System.Windows.Forms.Padding(6);
            Name = "CaptionForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.RadioButton btnCircle;
        private System.Windows.Forms.RadioButton btnEllipse;
        private System.Windows.Forms.RadioButton btnSquare;
        private System.Windows.Forms.RadioButton btnTriangle;
    }
}
