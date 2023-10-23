namespace Laba_num_one
{
    partial class CaptionForm
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
            label1 = new System.Windows.Forms.Label();
            btnCircle = new System.Windows.Forms.Button();
            btnLine = new System.Windows.Forms.Button();
            btnRectangle = new System.Windows.Forms.Button();
            btnTriangle = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.SystemColors.Control;
            label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 22.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(189, 122);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(461, 43);
            label1.TabIndex = 0;
            label1.Text = "Выберите одну из фигур:";
            // 
            // btnCircle
            // 
            btnCircle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            btnCircle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnCircle.Location = new System.Drawing.Point(207, 280);
            btnCircle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnCircle.Name = "btnCircle";
            btnCircle.Size = new System.Drawing.Size(170, 60);
            btnCircle.TabIndex = 1;
            btnCircle.Text = "Окружность";
            btnCircle.UseVisualStyleBackColor = false;
            btnCircle.Click += btnCircle_Click;
            // 
            // btnLine
            // 
            btnLine.BackColor = System.Drawing.SystemColors.ActiveBorder;
            btnLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnLine.Location = new System.Drawing.Point(435, 280);
            btnLine.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnLine.Name = "btnLine";
            btnLine.Size = new System.Drawing.Size(178, 60);
            btnLine.TabIndex = 2;
            btnLine.Text = "Отрезок";
            btnLine.UseVisualStyleBackColor = false;
            btnLine.Click += btnLine_Click;
            // 
            // btnRectangle
            // 
            btnRectangle.BackColor = System.Drawing.SystemColors.ActiveBorder;
            btnRectangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnRectangle.Location = new System.Drawing.Point(207, 406);
            btnRectangle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnRectangle.Name = "btnRectangle";
            btnRectangle.Size = new System.Drawing.Size(170, 59);
            btnRectangle.TabIndex = 3;
            btnRectangle.Text = "Прямоугольник";
            btnRectangle.UseVisualStyleBackColor = false;
            btnRectangle.Click += btnRectangle_Click;
            // 
            // btnTriangle
            // 
            btnTriangle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            btnTriangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnTriangle.Location = new System.Drawing.Point(435, 406);
            btnTriangle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnTriangle.Name = "btnTriangle";
            btnTriangle.Size = new System.Drawing.Size(178, 59);
            btnTriangle.TabIndex = 4;
            btnTriangle.Text = "Треугольник";
            btnTriangle.UseVisualStyleBackColor = false;
            btnTriangle.Click += btnTriangle_Click;
            // 
            // CaptionForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 562);
            Controls.Add(btnTriangle);
            Controls.Add(btnRectangle);
            Controls.Add(btnLine);
            Controls.Add(btnCircle);
            Controls.Add(label1);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "CaptionForm";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCircle;
        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.Button btnRectangle;
        private System.Windows.Forms.Button btnTriangle;
    }
}