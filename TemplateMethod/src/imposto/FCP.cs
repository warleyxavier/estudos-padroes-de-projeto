using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod.src.imposto {
    class FCP : Imposto {
        public FCP() {
            maiorTaxa = 0.05;
            menorTaxa = 0.03;
        }

        protected override bool deveCalcularImposto(Orcamento orcamento) {
            return orcamento.Valor > 700;
        }
    }
}
