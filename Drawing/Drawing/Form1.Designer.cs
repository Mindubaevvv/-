namespace Drawing
{
    partial class Form1
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
            btnDraw = new Button();
            SuspendLayout();
            // 
            // btnDraw
            // 
            btnDraw.Location = new Point(1304, 438);
            btnDraw.Name = "btnDraw";
            btnDraw.Size = new Size(188, 58);
            btnDraw.TabIndex = 1;
            btnDraw.Text = "Draw";
            btnDraw.UseVisualStyleBackColor = true;
            btnDraw.Click += btnDraw_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1700, 922);
            Controls.Add(btnDraw);
            Margin = new Padding(6);
            Name = "Form1";
            Text = "Form1";
            Paint += Form1_Paint;
            MouseClick += Form1_MouseClick;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button btnDraw;
    }
}