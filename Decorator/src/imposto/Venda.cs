using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.src.imposto {
    class Venda {

        private double valor;

        public Venda(double valor) {
            this.valor = valor;
        }

        public double Valor {
            get => this.valor;
            set => this.valor = value;
        }

    }
}
