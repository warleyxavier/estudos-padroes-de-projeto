using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.src.investimento {
    class Conta {

        private double saldo = 0;

        public Conta(double saldo) {
            this.saldo = saldo;
        }

        public double Saldo {
            get => this.saldo;
            set => this.saldo = value;
        }

        public void AdicionarValorAoSaldo(double valorAdicionado) {
            this.saldo =+ valorAdicionado; 
        }

    }
}
