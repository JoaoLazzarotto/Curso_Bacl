using static System.Windows.Forms.DataFormats;
using System.Net;
using System.Runtime.ConstrainedExecution;

namespace _ExercicioCapQuatro
{
    public partial class FormInicial : Form
    {
        /*
        1) Crie um novo projeto chamado �ExercicioCapQuatro�. Em seu projeto, crie um novo formul�rio chamado       
           FormInicial contendo dois bot�es, Alunos e Professores.

        2) Crie um novo formul�rio chamado FormPai contendo componentes para cadastrar informa��es que
           Professores e Alunos possam ter em comum(Informa��es Pessoais).

        3) Crie dois formul�rios chamados Professores e Alunos.Fa�a com que eles herdem as informa��es do FormPai
           e adicione outras informa��es a cada um deles, obviamente informa��es pertinentes somente a Professores
           e Alunos respectivamente.Ambos devem conter um bot�o chamado btnEnviar.

        4) Crie no FormInicial a l�gica necess�ria para ao clicar em Alunos v� para o formul�rio Aluno e ao clicar em
           Professores v� para o formul�rio Professor.

        5) No evento Click do bot�o btnEnviar dos formul�rios Professor e Pessoa exiba um MessageBox com todas as
           informa��es passadas pelo usu�rio.
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