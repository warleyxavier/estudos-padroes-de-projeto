using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod.src.imposto {
    class Orcamento {

        private double valor;

        public Orcamento(double valor) {
            this.Valor = valor;
        }

        public double Valor {
            get => valor;
            set => valor = value;
        }
    }
}
