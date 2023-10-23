namespace Laba_num_one
{
    partial class LineForm
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
            pctBox = new System.Windows.Forms.PictureBox();
            label1 = new System.Windows.Forms.Label();
            InputX = new System.Windows.Forms.TextBox();
            InputY = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            btnCreate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)pctBox).BeginInit();
            SuspendLayout();
            // 
            // pctBox
            // 
            pctBox.Location = new System.Drawing.Point(11, 10);
            pctBox.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            pctBox.Name = "pctBox";
            pctBox.Size = new System.Drawing.Size(1039, 1130);
            pctBox.TabIndex = 0;
            pctBox.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(1230, 23);
            label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(241, 41);
            label1.TabIndex = 1;
            label1.Text = "Создание линии";
            // 
            // InputX
            // 
            InputX.Location = new System.Drawing.Point(1109, 148);
            InputX.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            InputX.Name = "InputX";
            InputX.PlaceholderText = "500";
            InputX.Size = new System.Drawing.Size(440, 47);
            InputX.TabIndex = 2;
            // 
            // InputY
            // 
            InputY.Location = new System.Drawing.Point(1109, 316);
            InputY.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            InputY.Name = "InputY";
            InputY.PlaceholderText = "500";
            InputY.Size = new System.Drawing.Size(440, 47);
            InputY.TabIndex = 3;
            InputY.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(1103, 100);
            label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(279, 41);
            label2.TabIndex = 4;
            label2.Text = "Введите X (0-1000):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(1103, 266);
            label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(278, 41);
            label3.TabIndex = 5;
            label3.Text = "Введите Y (0-1000):";
            // 
            // btnCreate
            // 
            btnCreate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnCreate.Location = new System.Drawing.Point(1109, 433);
            btnCreate.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new System.Drawing.Size(444, 72);
            btnCreate.TabIndex = 6;
            btnCreate.Text = "Создать";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // LineForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1700, 1152);
            Controls.Add(btnCreate);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(InputY);
            Controls.Add(InputX);
            Controls.Add(label1);
            Controls.Add(pctBox);
            Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            Name = "LineForm";
            Text = "Line";
            Load += LineForm_Load;
            ((System.ComponentModel.ISupportInitialize)pctBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pctBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox InputX;
        private System.Windows.Forms.TextBox InputY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCreate;
    }
}