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
            PictureBox.Location = new System.Drawing.Point(5, 8);
            PictureBox.Name = "PictureBox";
            PictureBox.Size = new System.Drawing.Size(1290, 523);
            PictureBox.TabIndex = 0;
            PictureBox.TabStop = false;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            btnCreate.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnCreate.Location = new System.Drawing.Point(12, 552);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new System.Drawing.Size(130, 58);
            btnCreate.TabIndex = 1;
            btnCreate.Text = "Создать";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += BtnCreate_Click;
            // 
            // btnChange
            // 
            btnChange.BackColor = System.Drawing.SystemColors.ActiveBorder;
            btnChange.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnChange.Location = new System.Drawing.Point(12, 622);
            btnChange.Name = "btnChange";
            btnChange.Size = new System.Drawing.Size(130, 68);
            btnChange.TabIndex = 3;
            btnChange.Text = "Изменить кол-во";
            btnChange.UseVisualStyleBackColor = false;
            btnChange.Click += btnChange_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            btnDelete.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnDelete.Location = new System.Drawing.Point(1152, 638);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(139, 57);
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
            btnCircle.Location = new System.Drawing.Point(396, 567);
            btnCircle.Name = "btnCircle";
            btnCircle.Size = new System.Drawing.Size(73, 29);
            btnCircle.TabIndex = 5;
            btnCircle.TabStop = true;
            btnCircle.Text = "Круг";
            btnCircle.UseVisualStyleBackColor = true;
            // 
            // btnEllipse
            // 
            btnEllipse.AutoSize = true;
            btnEllipse.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnEllipse.Location = new System.Drawing.Point(568, 645);
            btnEllipse.Name = "btnEllipse";
            btnEllipse.Size = new System.Drawing.Size(97, 29);
            btnEllipse.TabIndex = 6;
            btnEllipse.Text = "Эллипс";
            btnEllipse.UseVisualStyleBackColor = true;
            // 
            // btnSquare
            // 
            btnSquare.AutoSize = true;
            btnSquare.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnSquare.Location = new System.Drawing.Point(568, 567);
            btnSquare.Name = "btnSquare";
            btnSquare.Size = new System.Drawing.Size(105, 29);
            btnSquare.TabIndex = 7;
            btnSquare.Text = "Квадрат";
            btnSquare.UseVisualStyleBackColor = true;
            // 
            // btnTriangle
            // 
            btnTriangle.AutoSize = true;
            btnTriangle.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnTriangle.Location = new System.Drawing.Point(396, 645);
            btnTriangle.Name = "btnTriangle";
            btnTriangle.Size = new System.Drawing.Size(145, 29);
            btnTriangle.TabIndex = 8;
            btnTriangle.Text = "Треугольник";
            btnTriangle.UseVisualStyleBackColor = true;
            // 
            // btnUp
            // 
            btnUp.BackColor = System.Drawing.SystemColors.ActiveBorder;
            btnUp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnUp.Location = new System.Drawing.Point(240, 554);
            btnUp.Name = "btnUp";
            btnUp.Size = new System.Drawing.Size(75, 42);
            btnUp.TabIndex = 9;
            btnUp.Text = "Вверх";
            btnUp.UseVisualStyleBackColor = false;
            // 
            // btnDown
            // 
            btnDown.BackColor = System.Drawing.SystemColors.ActiveBorder;
            btnDown.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnDown.Location = new System.Drawing.Point(240, 647);
            btnDown.Name = "btnDown";
            btnDown.Size = new System.Drawing.Size(75, 43);
            btnDown.TabIndex = 10;
            btnDown.Text = "Вниз";
            btnDown.UseVisualStyleBackColor = false;
            // 
            // btnRight
            // 
            btnRight.BackColor = System.Drawing.SystemColors.ActiveCaption;
            btnRight.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnRight.Location = new System.Drawing.Point(307, 602);
            btnRight.Name = "btnRight";
            btnRight.Size = new System.Drawing.Size(82, 39);
            btnRight.TabIndex = 11;
            btnRight.Text = "->";
            btnRight.UseVisualStyleBackColor = false;
            // 
            // btnLeft
            // 
            btnLeft.BackColor = System.Drawing.SystemColors.ActiveCaption;
            btnLeft.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnLeft.Location = new System.Drawing.Point(165, 602);
            btnLeft.Name = "btnLeft";
            btnLeft.Size = new System.Drawing.Size(82, 39);
            btnLeft.TabIndex = 12;
            btnLeft.Text = "<-";
            btnLeft.UseVisualStyleBackColor = false;
            btnLeft.Click += btnLeft_Click;
            // 
            // CaptionForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1303, 702);
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
