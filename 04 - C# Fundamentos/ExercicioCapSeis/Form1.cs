namespace ExercicioCapSeis
{
    public partial class Form1 : Form
    {
        /*
        1) Crie um novo projeto chamado �ExercicioCapSeis�. Dentro dele crie um formul�rio contendo um TextBox,
           um ComboBox, um DateTimePicker, um NumericUpDown e um Bot�o chamado Enviar.Fa�a as valida��es
           necess�rias sendo que:
                1. O TextBox n�o pode conter mais de 15 caracteres nem o caractere �%�.
                2. O ComboBox deve conter no m�nimo 3 valores quando declarado.S� ser� v�lido se o index n�o for igual a -1.
                3. A Data n�o pode ser a atual e nem menor do que 2012.
                4. O valor num�rico deve incrementar de 10 em 10 e seu valor s� pode estar entre 30 e 100.
        */
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}