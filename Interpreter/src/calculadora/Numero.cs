using InterpreterEVisitor.src.calculadora;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter.src.calculadora {
    class Numero: IExpressao {

        private double numero;

        public Numero(double numero) {
            this.numero = numero;
        }

        public double GetNumero => this.numero;

        public string aceita(IVisitor visitor) {
            return visitor.visitaNumero(this);
        }

        public double executar() => this.numero;

    }
}
