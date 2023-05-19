namespace Capitulo21.Exercicio1
{
    partial class Eventos
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
            textBoxNome = new TextBox();
            comboBoxSexo = new ComboBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(77, 57);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(121, 23);
            textBoxNome.TabIndex = 0;
            textBoxNome.TextChanged += textBoxNome_TextChanged;
            // 
            // comboBoxSexo
            // 
            comboBoxSexo.FormattingEnabled = true;
            comboBoxSexo.Items.AddRange(new object[] { "Masculino ", "Feminino" });
            comboBoxSexo.Location = new Point(77, 101);
            comboBoxSexo.Name = "comboBoxSexo";
            comboBoxSexo.Size = new Size(121, 23);
            comboBoxSexo.TabIndex = 1;
            comboBoxSexo.SelectedIndexChanged += comboBoxSexo_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(77, 130);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Salvar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(77, 39);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 3;
            label1.Text = "Nome";
        
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(77, 83);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 4;
            label2.Text = "Sexo";
            // 
            // Eventos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(comboBoxSexo);
            Controls.Add(textBoxNome);
            Name = "Eventos";
            Text = "Eventos";
            Load += Eventos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNome;
        private ComboBox comboBoxSexo;
        private Button button1;
        private Label label1;
        private Label label2;
    }
}