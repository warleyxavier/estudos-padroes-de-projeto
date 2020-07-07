using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.src.investimento {
    class Conservador : Investimento {
        double Investimento.gerarValorInvestimento(Conta conta) {
            return conta.Saldo * 0.008;
        }
    }
}
