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
            pctBox.Location = new System.Drawing.Point(5, 5);
            pctBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pctBox.Name = "pctBox";
            pctBox.Size = new System.Drawing.Size(489, 551);
            pctBox.TabIndex = 0;
            pctBox.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(579, 11);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(124, 20);
            label1.TabIndex = 1;
            label1.Text = "Создание линии";
            // 
            // InputX
            // 
            InputX.Location = new System.Drawing.Point(522, 72);
            InputX.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            InputX.Name = "InputX";
            InputX.PlaceholderText = "500";
            InputX.Size = new System.Drawing.Size(209, 27);
            InputX.TabIndex = 2;
            // 
            // InputY
            // 
            InputY.Location = new System.Drawing.Point(522, 154);
            InputY.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            InputY.Name = "InputY";
            InputY.PlaceholderText = "500";
            InputY.Size = new System.Drawing.Size(209, 27);
            InputY.TabIndex = 3;
            InputY.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(519, 49);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(141, 20);
            label2.TabIndex = 4;
            label2.Text = "Введите X (0-1000):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(519, 130);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(140, 20);
            label3.TabIndex = 5;
            label3.Text = "Введите Y (0-1000):";
            // 
            // btnCreate
            // 
            btnCreate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnCreate.Location = new System.Drawing.Point(522, 211);
            btnCreate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new System.Drawing.Size(209, 35);
            btnCreate.TabIndex = 6;
            btnCreate.Text = "Создать";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // LineForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 515);
            Controls.Add(btnCreate);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(InputY);
            Controls.Add(InputX);
            Controls.Add(label1);
            Controls.Add(pctBox);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "LineForm";
            Text = "Line";
            FormClosing += LineForm_FormClosing;
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