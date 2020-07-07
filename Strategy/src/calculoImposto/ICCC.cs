using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy {
    class ICCC : Imposto {
        public double calcular(Orcamento orcamento) {
            double percentualMultiplicacao = 0;
            double valorAcrescimo = 0;

            percentualMultiplicacao = 0.05;

            if (orcamento.Valor >= 1000 && orcamento.Valor <= 3000) {
                percentualMultiplicacao = 0.7;
            } else if (orcamento.Valor > 3000) {
                percentualMultiplicacao = 0.08;
                valorAcrescimo = 30.00;
            }

            return orcamento.Valor * percentualMultiplicacao + valorAcrescimo;
        }
    }
}
