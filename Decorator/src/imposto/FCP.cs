using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.src.imposto {
    class FCP : Imposto {

        public FCP() : base() {
        }

        public FCP(Imposto outroImposto) : base(outroImposto){            
        }

        protected override double calcularImposto(Venda venda) {
            return venda.Valor * 0.2;
        }
    }
}
