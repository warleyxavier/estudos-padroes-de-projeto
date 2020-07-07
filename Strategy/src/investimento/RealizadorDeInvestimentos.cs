using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.src.investimento {
    class RealizadorDeInvestimentos {

        public void investir(Conta conta, Investimento investimento) {
            double valorInvestido = investimento.gerarValorInvestimento(conta);

            double valorParaAdicionarAoSaldo = valorInvestido * 0.75;

            conta.AdicionarValorAoSaldo(valorParaAdicionarAoSaldo);
        }

    }
}
