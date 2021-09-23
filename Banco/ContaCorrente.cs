using System;
using System.Collections.Generic;
using System.Text;

namespace Banco
{
    class ContaCorrente : IContaCorrente
    {
        public string Agencia { get; private set; }
        public string Conta { get; private set; }
        public double Saldo { get; private set; } = 0;
        public double Imposto { get; private set; }
        public double ValorImposto { get; private set; }
        

        public ContaCorrente(string agencia, string conta)
        {
            Agencia = agencia;
            Conta = conta;

        }

        public void  Creditar(double valor)
        {
            Saldo = Saldo + valor;

        }

        public void  Debitar(double valor)
        {
            Saldo = Saldo - valor;

        }

        public void CalcularImposto()
        {

            if (Saldo <= 999)
            {
                Imposto = 2;
            }
            else if (Saldo >= 1000 && Saldo <= 2999)
            {
                Imposto = 2.5;
            }
            else if (Saldo >= 3000 && Saldo <= 6999)
            {
                Imposto = 2.8;
            }
            else if (Saldo >= 7000)
            {
                Imposto = 3;
            }

            ValorImposto = Saldo * Imposto /100;
        }



    };
}
