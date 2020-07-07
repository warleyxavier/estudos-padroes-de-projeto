using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ChainOfResponsibility.src.requisicoes {
    class Conta {

        private string titular;
        private double saldo;

        public string Titular {
            get => titular;
            set => titular = value;
        }
        public double Saldo {
            get => saldo;
            set => saldo = value;
        }
    }
}
