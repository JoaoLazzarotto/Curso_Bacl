using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Drawing;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;
using System;

namespace Capitulo20.ExercíciosDeRevisao
{
    public partial class Form1 : Form
    {
        /*
        1) Crie um programa que pedirá para o usuário inserir quatro notas válidas de 0 a 10, permitindo valores
            decimais, ao clicar em um botão é feito o cálculo das notas e exibido logo abaixo a maior nota, a menor nota e
            a média.
            Crie um botão que limpe o formulário(limpe todos os campos).

        2) Crie um programa que simule um caixa eletrônico.O usuário digitará o número da conta que deseja sacar
            ou depositar algum valor.Ao final informe o saldo.

        3) Altere o exercício anterior para que a conta possa permitir um saque se o saldo for negativo, desde que o
            usuário possua limite de cheque especial(possui limite será um checkbox).

        4) Crie um formulário que pergunte a data de nascimento de uma pessoa e o seu nome, ao clicar em um
            botão chamado "Verificar exigibilidade", o programa verificará se a pessoa pode abrir uma conta corrente.

        5) Altere o exercício anterior para que as condições de exigibilidade sejam as seguintes(use a criatividade,
            dica: checkbox para os tipos de conta)>
           a.Qualquer pessoa só pode abrir conta corrente, poupança ou universitária se tiver CPF.
           b.Se a pessoa for < 18 ela pode ter conta poupança.
           c.A pessoa < 18 só pode ter conta corrente se for emancipada.
           d.A pessoa que desejar abrir conta universária precisa ter um código de matrícula
           e. A pessoa que desejar abrir conta jurídica precisa ter um CNPJ.
           f.O gerente da loja pode liberar, em caráter de exceção pode ser aberta uma conta universitária sem código
            de matrícula.

        6) Construa um programa que possua o número da conta, saldo inicial e nome.
            Haverá um botão que armazenará essas contas em forma de lista na memória.
            Utilize orientação a objetos.
            Haverá outro botão que exibirá todas as contas e seus respectivos saldos.

        7) Imagine uma aplicação que tem dois campos textbox.Existe um botão calcular que divide o primeiro pelo
            segundo.Como eu poderia individualizar as mensagens de erro quando o usuário tentar dividir um valor por
            zero ou digitar um valor inválido (por exemplo letra em vez de numeros)?

        8) Suponha que em um determinado programa, o objetivo do campo textbox X seja não aceitar números.
            Como você resolveria esse problema sem alterá-lo por um numericUpDown?
        */
        public Form1()
        {
            InitializeComponent();
        }
        //textBoxNome.Clear();
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void textBoxNota1_TextChanged(object sender, EventArgs e)
        {
            
            
        }
       
    }
}