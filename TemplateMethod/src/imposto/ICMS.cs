using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod.src.imposto {
    class ICMS : Imposto {
        public ICMS() {
            maiorTaxa = 0.08;
            menorTaxa = 0.06;
        }

        protected override bool deveCalcularImposto(Orcamento orcamento) {
            return orcamento.Valor > 500;
        }
    }
}
