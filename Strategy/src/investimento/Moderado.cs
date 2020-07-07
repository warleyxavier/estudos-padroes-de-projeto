using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace Strategy.src.investimento {
    class Moderado : Investimento {
        double Investimento.gerarValorInvestimento(Conta conta) {
            Random randon = new Random();

            double percentualPossibilidade = randon.Next(0, 101);

            double percentualMultiplicacao = (percentualPossibilidade <= 50 ? 0.025 : 0.07);

            return conta.Saldo * percentualMultiplicacao;            
        }
    }
}
