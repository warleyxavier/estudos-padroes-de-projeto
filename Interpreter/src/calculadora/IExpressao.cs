using InterpreterEVisitor.src.calculadora;
using System;
using System.Collections.Generic;
using System.Security.Policy;
using System.Text;

namespace Interpreter.src.calculadora {
    interface IExpressao {

        public double executar();

        public string aceita(IVisitor visitor);

    }
}
