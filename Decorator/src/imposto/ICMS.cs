﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.src.imposto {
    class ICMS : Imposto {

        public ICMS() : base() {
        }
        public ICMS(Imposto outroImposto) : base(outroImposto) {
        }
        protected override double calcularImposto(Venda venda) {
            return venda.Valor * 0.5;
        }
    }
}
