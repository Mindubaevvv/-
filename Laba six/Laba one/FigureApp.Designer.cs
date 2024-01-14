namespace Laba_one
{
    partial class FigureApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FigureApp));
            PictureBox = new System.Windows.Forms.PictureBox();
            btnCreate = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            btnUp = new System.Windows.Forms.Button();
            btnDown = new System.Windows.Forms.Button();
            btnRight = new System.Windows.Forms.Button();
            btnLeft = new System.Windows.Forms.Button();
            btnPlus = new System.Windows.Forms.Button();
            btnMinus = new System.Windows.Forms.Button();
            btnHide = new System.Windows.Forms.Button();
            btnShow = new System.Windows.Forms.Button();
            btnAllMassive = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)PictureBox).BeginInit();
            SuspendLayout();
            // 
            // PictureBox
            // 
            PictureBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            PictureBox.Location = new System.Drawing.Point(5, 8);
            PictureBox.Name = "PictureBox";
            PictureBox.Size = new System.Drawing.Size(1029, 523);
            PictureBox.TabIndex = 0;
            PictureBox.TabStop = false;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            btnCreate.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnCreate.Location = new System.Drawing.Point(12, 594);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new System.Drawing.Size(130, 58);
            btnCreate.TabIndex = 1;
            btnCreate.Text = "Создать";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += BtnCreate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            btnDelete.BackgroundImage = (System.Drawing.Image)resources.GetObject("btnDelete.BackgroundImage");
            btnDelete.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnDelete.ForeColor = System.Drawing.Color.Black;
            btnDelete.Location = new System.Drawing.Point(895, 633);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(139, 57);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Удалить";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUp
            // 
            btnUp.BackColor = System.Drawing.SystemColors.ActiveBorder;
            btnUp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnUp.Location = new System.Drawing.Point(264, 558);
            btnUp.Name = "btnUp";
            btnUp.Size = new System.Drawing.Size(75, 42);
            btnUp.TabIndex = 9;
            btnUp.Text = "Вверх";
            btnUp.UseVisualStyleBackColor = false;
            btnUp.Click += btnUp_Click;
            // 
            // btnDown
            // 
            btnDown.BackColor = System.Drawing.SystemColors.ActiveBorder;
            btnDown.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnDown.Location = new System.Drawing.Point(264, 647);
            btnDown.Name = "btnDown";
            btnDown.Size = new System.Drawing.Size(75, 43);
            btnDown.TabIndex = 10;
            btnDown.Text = "Вниз";
            btnDown.UseVisualStyleBackColor = false;
            btnDown.Click += btnDown_Click;
            // 
            // btnRight
            // 
            btnRight.BackColor = System.Drawing.SystemColors.ActiveCaption;
            btnRight.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnRight.Location = new System.Drawing.Point(346, 602);
            btnRight.Name = "btnRight";
            btnRight.Size = new System.Drawing.Size(82, 39);
            btnRight.TabIndex = 11;
            btnRight.Text = "Вправо";
            btnRight.UseVisualStyleBackColor = false;
            btnRight.Click += btnRight_Click;
            // 
            // btnLeft
            // 
            btnLeft.BackColor = System.Drawing.SystemColors.ActiveCaption;
            btnLeft.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnLeft.Location = new System.Drawing.Point(181, 602);
            btnLeft.Name = "btnLeft";
            btnLeft.Size = new System.Drawing.Size(82, 39);
            btnLeft.TabIndex = 12;
            btnLeft.Text = "Влево";
            btnLeft.UseVisualStyleBackColor = false;
            btnLeft.Click += btnLeft_Click;
            // 
            // btnPlus
            // 
            btnPlus.BackColor = System.Drawing.SystemColors.ActiveBorder;
            btnPlus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnPlus.Location = new System.Drawing.Point(744, 567);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new System.Drawing.Size(94, 33);
            btnPlus.TabIndex = 13;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = false;
            btnPlus.Click += btnPlus_Click;
            // 
            // btnMinus
            // 
            btnMinus.BackColor = System.Drawing.SystemColors.ActiveCaption;
            btnMinus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnMinus.Location = new System.Drawing.Point(744, 642);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new System.Drawing.Size(94, 33);
            btnMinus.TabIndex = 14;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = false;
            btnMinus.Click += btnMinus_Click;
            // 
            // btnHide
            // 
            btnHide.BackColor = System.Drawing.SystemColors.ActiveBorder;
            btnHide.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnHide.Location = new System.Drawing.Point(919, 594);
            btnHide.Name = "btnHide";
            btnHide.Size = new System.Drawing.Size(94, 33);
            btnHide.TabIndex = 16;
            btnHide.Text = "Скрыть";
            btnHide.UseVisualStyleBackColor = false;
            btnHide.Click += btnHide_Click_1;
            // 
            // btnShow
            // 
            btnShow.BackColor = System.Drawing.SystemColors.ActiveCaption;
            btnShow.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnShow.Location = new System.Drawing.Point(919, 552);
            btnShow.Name = "btnShow";
            btnShow.Size = new System.Drawing.Size(94, 33);
            btnShow.TabIndex = 17;
            btnShow.Text = "Показать";
            btnShow.UseVisualStyleBackColor = false;
            btnShow.Click += btnShow_Click;
            // 
            // btnAllMassive
            // 
            btnAllMassive.BackColor = System.Drawing.SystemColors.ActiveBorder;
            btnAllMassive.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnAllMassive.Location = new System.Drawing.Point(526, 567);
            btnAllMassive.Name = "btnAllMassive";
            btnAllMassive.Size = new System.Drawing.Size(117, 38);
            btnAllMassive.TabIndex = 18;
            btnAllMassive.Text = "Массив";
            btnAllMassive.UseVisualStyleBackColor = false;
            btnAllMassive.Click += btnAllMassive_Click;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            button1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button1.Location = new System.Drawing.Point(526, 642);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(117, 38);
            button1.TabIndex = 19;
            button1.Text = "Лист";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FigureApp
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1046, 702);
            Controls.Add(button1);
            Controls.Add(btnAllMassive);
            Controls.Add(btnShow);
            Controls.Add(btnHide);
            Controls.Add(btnMinus);
            Controls.Add(btnPlus);
            Controls.Add(btnLeft);
            Controls.Add(btnRight);
            Controls.Add(btnDown);
            Controls.Add(btnUp);
            Controls.Add(btnDelete);
            Controls.Add(btnCreate);
            Controls.Add(PictureBox);
            Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Name = "FigureApp";
            Text = "FigureApp";
            ((System.ComponentModel.ISupportInitialize)PictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnAllMassive;
        private System.Windows.Forms.Button button1;
    }
}
