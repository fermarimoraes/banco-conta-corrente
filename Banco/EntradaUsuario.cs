using System;
using System.Collections.Generic;
using System.Text;

namespace Banco
{
    class EntradaUsuario
    {
        public string Agencia { get; set; }
        public string Conta { get; set; }
        public double ValorDeposito { get; set; }
        public double ValorSaque {get; set; }

        public void LerDadosUsuario()
        {

            Console.WriteLine("Informe sua Agência");

            Agencia = Console.ReadLine();

            Console.WriteLine("Informe sua conta");

            Conta = Console.ReadLine();

            Console.WriteLine("Qual valor deseja Depositar?");

            ValorDeposito = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual valor deseja sacar?");

            ValorSaque = double.Parse(Console.ReadLine());

            


        }
    }

}
