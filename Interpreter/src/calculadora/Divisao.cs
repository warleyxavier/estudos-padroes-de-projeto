﻿using InterpreterEVisitor.src.calculadora;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter.src.calculadora {
    class Divisao : IExpressao {
        private IExpressao expressaoEsquerda;
        private IExpressao expressaoDireita;

        public Divisao(IExpressao expressaoEsquerda, IExpressao expressaoDireita) {
            this.expressaoEsquerda = expressaoEsquerda;
            this.expressaoDireita = expressaoDireita;
        }

        public IExpressao Esquerda => this.expressaoEsquerda;
        public IExpressao Direita => this.expressaoDireita;

        public double executar() {
            double valorEsquerda = expressaoEsquerda.executar();
            double valorDireita = expressaoDireita.executar();

            return valorEsquerda / valorDireita;
        }

        public string aceita(IVisitor visitor) {
            return visitor.visitaDivisao(this);
        }
    }
}
