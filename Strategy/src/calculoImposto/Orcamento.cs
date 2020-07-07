using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy {
    class Orcamento {
        private double valor;

        public Orcamento(double valor) {
            this.valor = valor;
        }

        public double Valor {
            get => this.valor;
            set => this.valor = value;
        }

    }
}
