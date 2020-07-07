using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Text;

namespace Decorator.src.imposto {
    abstract class Imposto {

        protected Imposto outroImposto;

        public Imposto() {
            this.outroImposto = null;
        }

        public Imposto(Imposto outroImposto) {
            this.outroImposto = outroImposto;
        }

        public double calcular(Venda venda) {
            double valoDoOutroImposto = calculaValorDoOutroImposto(venda);

            double valorDesteImposto = calcularImposto(venda);

            return valoDoOutroImposto + valorDesteImposto;
        }

        private double calculaValorDoOutroImposto(Venda venda) {
            if (outroImposto == null)
                return 0;

            return outroImposto.calcular(venda);
        }

        abstract protected double calcularImposto(Venda venda);

    }
}
