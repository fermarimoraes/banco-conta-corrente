using System;
using System.Collections.Generic;
using System.Text;

namespace Banco
{
    class OperacaoBanco
    {
        public void Executar()
        {
            var entradaUsuario = new EntradaUsuario();
            entradaUsuario.LerDadosUsuario();

            var conta = new ContaCorrente(entradaUsuario.Agencia, entradaUsuario.Conta);

            conta.Creditar(entradaUsuario.ValorDeposito);
            conta.Debitar(entradaUsuario.ValorSaque);
            conta.CalcularImposto();



            Console.WriteLine("O saldo da conta corrente é "+ conta.Saldo);
            Console.WriteLine("A porcentagem do importo é: " + conta.Imposto+"%");
            Console.WriteLine("Valor do imposto é: "+conta.ValorImposto);
        }
       
    }
}
