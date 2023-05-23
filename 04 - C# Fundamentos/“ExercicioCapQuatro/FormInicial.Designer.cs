namespace _ExercicioCapQuatro
{
    partial class FormInicial
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
            buttonAluno = new Button();
            buttonProfessores = new Button();
            SuspendLayout();
            // 
            // buttonAluno
            // 
            buttonAluno.Location = new Point(59, 158);
            buttonAluno.Name = "buttonAluno";
            buttonAluno.Size = new Size(98, 37);
            buttonAluno.TabIndex = 0;
            buttonAluno.Text = "Aluno";
            buttonAluno.UseVisualStyleBackColor = true;
            // 
            // buttonProfessores
            // 
            buttonProfessores.Location = new Point(59, 236);
            buttonProfessores.Name = "buttonProfessores";
            buttonProfessores.Size = new Size(98, 37);
            buttonProfessores.TabIndex = 1;
            buttonProfessores.Text = "Professores";
            buttonProfessores.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonProfessores);
            Controls.Add(buttonAluno);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button buttonAluno;
        private Button buttonProfessores;
    }
}