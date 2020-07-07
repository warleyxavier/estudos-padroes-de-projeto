using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.src.investimento {
    class Arrojado : Investimento {
        public double gerarValorInvestimento(Conta conta) {
            Random randon = new Random();

            double percentualPossibilidade = randon.Next(0, 101);

            double percentualMultiplicacao = 0.05;

            if (percentualPossibilidade >= 30)
                percentualMultiplicacao = 0.03;
            else if (percentualPossibilidade >= 50)
                percentualMultiplicacao = 0.006;

            return conta.Saldo * percentualMultiplicacao;
        }
    }
}
