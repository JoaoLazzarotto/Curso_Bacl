namespace ExercicioCapSeis
{
    public partial class Form1 : Form
    {
        /*
        1) Crie um novo projeto chamado “ExercicioCapSeis”. Dentro dele crie um formulário contendo um TextBox,
           um ComboBox, um DateTimePicker, um NumericUpDown e um Botão chamado Enviar.Faça as validações
           necessárias sendo que:
                1. O TextBox não pode conter mais de 15 caracteres nem o caractere “%”.
                2. O ComboBox deve conter no mínimo 3 valores quando declarado.Só será válido se o index não for igual a -1.
                3. A Data não pode ser a atual e nem menor do que 2012.
                4. O valor numérico deve incrementar de 10 em 10 e seu valor só pode estar entre 30 e 100.
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