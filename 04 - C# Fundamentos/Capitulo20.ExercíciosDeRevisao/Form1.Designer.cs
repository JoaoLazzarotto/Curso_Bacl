namespace Capitulo20.ExercíciosDeRevisao
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
            textBoxNota1 = new TextBox();
            textBoxNota2 = new TextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // textBoxNota1
            // 
            textBoxNota1.Location = new Point(60, 107);
            textBoxNota1.Name = "textBoxNota1";
            textBoxNota1.Size = new Size(100, 23);
            textBoxNota1.TabIndex = 0;
            textBoxNota1.TextChanged += textBoxNota1_TextChanged;
            // 
            // textBoxNota2
            // 
            textBoxNota2.Location = new Point(60, 156);
            textBoxNota2.Name = "textBoxNota2";
            textBoxNota2.Size = new Size(100, 23);
            textBoxNota2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(60, 205);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(60, 254);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(56, 84);
            label1.Name = "label1";
            label1.Size = new Size(183, 20);
            label1.TabIndex = 4;
            label1.Text = "Insira aqui a primeira nota";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(56, 133);
            label2.Name = "label2";
            label2.Size = new Size(183, 20);
            label2.TabIndex = 5;
            label2.Text = "Insira aqui a segunda nota";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(56, 182);
            label3.Name = "label3";
            label3.Size = new Size(177, 20);
            label3.TabIndex = 6;
            label3.Text = "Insira aqui a terceira nota";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(56, 231);
            label4.Name = "label4";
            label4.Size = new Size(170, 20);
            label4.TabIndex = 7;
            label4.Text = "Insira aqui a quarta nota";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(textBoxNota2);
            Controls.Add(textBoxNota1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNota1;
        private TextBox textBoxNota2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}