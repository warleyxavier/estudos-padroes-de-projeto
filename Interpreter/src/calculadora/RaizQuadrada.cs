using InterpreterEVisitor.src.calculadora;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter.src.calculadora {
    class RaizQuadrada : IExpressao {


        private IExpressao expressao;

        public RaizQuadrada(IExpressao expressao) {
            this.expressao = expressao;
        }

        public string aceita(IVisitor visitor) {
            return "";
        }

        public double executar() => Math.Sqrt(this.expressao.executar());

    }
}
