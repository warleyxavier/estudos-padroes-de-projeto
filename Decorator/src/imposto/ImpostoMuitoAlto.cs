using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.src.imposto {
    class ImpostoMuitoAlto : Imposto {

        public ImpostoMuitoAlto() : base() {
        }

        public ImpostoMuitoAlto(Imposto outroImposto) : base(outroImposto) {
        }
        protected override double calcularImposto(Venda venda) {
            return venda.Valor * 0.2;
        }
    }
}
