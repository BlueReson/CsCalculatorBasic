namespace CsCalculatorBasic
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            bPlus = new Button();
            bMinus = new Button();
            bDiff = new Button();
            bMultiply = new Button();
            bPercent = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Coral;
            label1.Location = new Point(340, 83);
            label1.Name = "label1";
            label1.Size = new Size(120, 23);
            label1.TabIndex = 0;
            label1.Text = "Calculator";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(90, 153);
            label2.Name = "label2";
            label2.Size = new Size(58, 21);
            label2.TabIndex = 1;
            label2.Text = "value 1";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(90, 207);
            label3.Name = "label3";
            label3.Size = new Size(61, 21);
            label3.TabIndex = 2;
            label3.Text = "value 2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(86, 264);
            label4.Name = "label4";
            label4.Size = new Size(62, 21);
            label4.TabIndex = 3;
            label4.Text = "Output";
            label4.Click += label4_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(154, 150);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(188, 29);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(154, 204);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(188, 29);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(154, 261);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(188, 29);
            textBox3.TabIndex = 6;
            // 
            // bPlus
            // 
            bPlus.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            bPlus.Location = new Point(154, 310);
            bPlus.Name = "bPlus";
            bPlus.Size = new Size(49, 56);
            bPlus.TabIndex = 9;
            bPlus.Text = "+";
            bPlus.UseVisualStyleBackColor = true;
            bPlus.Click += bPlus_Click;
            // 
            // bMinus
            // 
            bMinus.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            bMinus.Location = new Point(209, 310);
            bMinus.Name = "bMinus";
            bMinus.Size = new Size(49, 56);
            bMinus.TabIndex = 10;
            bMinus.Text = "-";
            bMinus.UseVisualStyleBackColor = true;
            bMinus.Click += button1_Click_1;
            // 
            // bDiff
            // 
            bDiff.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            bDiff.Location = new Point(264, 310);
            bDiff.Name = "bDiff";
            bDiff.Size = new Size(49, 56);
            bDiff.TabIndex = 11;
            bDiff.Text = "/";
            bDiff.UseVisualStyleBackColor = true;
            // 
            // bMultiply
            // 
            bMultiply.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            bMultiply.Location = new Point(319, 310);
            bMultiply.Name = "bMultiply";
            bMultiply.Size = new Size(49, 56);
            bMultiply.TabIndex = 12;
            bMultiply.Text = "*";
            bMultiply.UseVisualStyleBackColor = true;
            bMultiply.Click += button4_Click;
            // 
            // bPercent
            // 
            bPercent.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            bPercent.Location = new Point(374, 310);
            bPercent.Name = "bPercent";
            bPercent.Size = new Size(49, 56);
            bPercent.TabIndex = 13;
            bPercent.Text = "%";
            bPercent.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bPercent);
            Controls.Add(bMultiply);
            Controls.Add(bDiff);
            Controls.Add(bMinus);
            Controls.Add(bPlus);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button bPlus;
        private Button bMinus;
        private Button bDiff;
        private Button bMultiply;
        private Button bPercent;
    }
}
