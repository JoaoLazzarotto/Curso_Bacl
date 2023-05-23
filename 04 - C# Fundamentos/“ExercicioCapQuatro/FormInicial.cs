using static System.Windows.Forms.DataFormats;
using System.Net;
using System.Runtime.ConstrainedExecution;

namespace _ExercicioCapQuatro
{
    public partial class FormInicial : Form
    {
        /*
        1) Crie um novo projeto chamado “ExercicioCapQuatro”. Em seu projeto, crie um novo formulário chamado       
           FormInicial contendo dois botões, Alunos e Professores.

        2) Crie um novo formulário chamado FormPai contendo componentes para cadastrar informações que
           Professores e Alunos possam ter em comum(Informações Pessoais).

        3) Crie dois formulários chamados Professores e Alunos.Faça com que eles herdem as informações do FormPai
           e adicione outras informações a cada um deles, obviamente informações pertinentes somente a Professores
           e Alunos respectivamente.Ambos devem conter um botão chamado btnEnviar.

        4) Crie no FormInicial a lógica necessária para ao clicar em Alunos vá para o formulário Aluno e ao clicar em
           Professores vá para o formulário Professor.

        5) No evento Click do botão btnEnviar dos formulários Professor e Pessoa exiba um MessageBox com todas as
           informações passadas pelo usuário.
        */

        public FormInicial()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}