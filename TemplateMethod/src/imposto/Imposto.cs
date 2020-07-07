using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TemplateMethod.src.imposto {
    abstract class Imposto : IImposto {

        protected double maiorTaxa;
        protected double menorTaxa;

        public double calcular(Orcamento orcamento) {
            double taxa = deveCalcularImposto(orcamento) ? maiorTaxa : menorTaxa;

            return orcamento.Valor * taxa;
        }

        abstract protected Boolean deveCalcularImposto(Orcamento orcamento);
    }
}
