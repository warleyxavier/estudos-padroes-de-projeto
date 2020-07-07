using Interpreter.src.calculadora;
using System;
using System.Collections.Generic;
using System.Security.Policy;
using System.Text;

namespace InterpreterEVisitor.src.calculadora {
    interface IVisitor {

        public string visitaSoma(Soma soma);
        public string visitaSubtracao(Subtracao subtracao);
        public string visitaMultiplicacao(Multiplicacao multiplicacao);
        public string visitaDivisao(Divisao divisao);
        public string visitaNumero(Numero numero);

    }
}
