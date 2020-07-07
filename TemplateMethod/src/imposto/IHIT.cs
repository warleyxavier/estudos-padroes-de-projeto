using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod.src.imposto {
    class IHIT : Imposto {
        public IHIT() {
            maiorTaxa = 0.13;
            menorTaxa = 0.01;
        }

        protected override bool deveCalcularImposto(Orcamento orcamento) {
            throw new NotImplementedException();
        }

        private bool existemDoisProdutosComOMesmoNome(Orcamento orcamento) {
            return true;
        }
    }
}
