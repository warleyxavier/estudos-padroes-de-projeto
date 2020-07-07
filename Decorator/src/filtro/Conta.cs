using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.src.filtro {
    class Conta {

        private double saldo;
        private DateTime dataAbertura;

        public Conta(double saldo, DateTime dataAbertura) {
            this.saldo = saldo;
            this.dataAbertura = dataAbertura;
        }

        public double Saldo {
            get => this.saldo;
            set => this.saldo = value;
        }

        public DateTime DataAbertura {
            get => this.dataAbertura;
            set => this.dataAbertura = value;
        }

    }
}
