using System;
using System.Collections.Generic;
using System.Text;

namespace Banco
{
    interface IContaCorrente
    {
        string Conta { get; }
        string Agencia { get; }
        double Saldo { get; }
        double Imposto { get; }
        double ValorImposto { get; }

        void  Creditar(double valor);
       void Debitar(double valor);
        void CalcularImposto();

    }
}
