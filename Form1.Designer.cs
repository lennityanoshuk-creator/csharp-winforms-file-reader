namespace hw7
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
            txtFileContent = new Button();
            txtMyInput = new TextBox();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtFileContent
            // 
            txtFileContent.Location = new Point(61, 139);
            txtFileContent.Name = "txtFileContent";
            txtFileContent.Size = new Size(197, 49);
            txtFileContent.TabIndex = 2;
            txtFileContent.Text = "Прочитати файл";
            txtFileContent.UseVisualStyleBackColor = true;
            txtFileContent.Click += txtFileContent_Click;
            // 
            // txtMyInput
            // 
            txtMyInput.Location = new Point(61, 91);
            txtMyInput.Name = "txtMyInput";
            txtMyInput.Size = new Size(271, 27);
            txtMyInput.TabIndex = 3;
            txtMyInput.TextChanged += txtMyInput_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(61, 252);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(419, 34);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(61, 45);
            label1.Name = "label1";
            label1.Size = new Size(252, 31);
            label1.TabIndex = 5;
            label1.Text = "Шлях до файлу (.txt):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(61, 205);
            label2.Name = "label2";
            label2.Size = new Size(157, 31);
            label2.TabIndex = 6;
            label2.Text = "Вміст файлу:";
            label2.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(txtMyInput);
            Controls.Add(txtFileContent);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button txtFileContent;
        private TextBox txtMyInput;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
    }
}
