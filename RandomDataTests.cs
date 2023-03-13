using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteCorreios.Core;

namespace TesteCorreios
{
    internal class RandomDataTests : Begin
    {
        [Test]
        public void RandomData()
        {
            string nome = GeraNomeAleatorio();
            Console.WriteLine("Nome completo: " + nome);
            string email = GeraEmailAleatorio();
            Console.WriteLine("Email: " + email);
            string dataNasc = GeraDataNascimento();
            Console.WriteLine("Data de nascimento: " + dataNasc);
            string celNumber = GeraCelular();
            Console.WriteLine("Celular: " + celNumber);
        }
        [Test]
        public void PreencheCadastroAmazonPrime()
        {
            string nomeCompleto = GeraNomeAleatorio();
            EscreveTexto("//input[@id='ap_customer_name']", nomeCompleto);

            string celular = GeraCelular();
            EscreveTexto("//input[@id='ap_email']", celular);

            string senha = GeraCelular();
            EscreveTexto("//input[@id='ap_password']", senha);

            string senha2 = GeraCelular();
            EscreveTexto("//input[@id='ap_password_check']", senha2);

            ClicaElemento("//input[@id='continue']");
        }
    }
}
