using Interpreter.src.calculadora;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterpreterEVisitor.src.calculadora {
    class ImpressoraVisitor : IVisitor {
        public string visitaDivisao(Divisao divisao) {
            return " ( / " + divisao.Esquerda.aceita(this) + "  "  + divisao.Direita.aceita(this) + " ) ";
        }

        public string visitaMultiplicacao(Multiplicacao multiplicacao) {
            return " ( * " + multiplicacao.Esquerda.aceita(this) + " " + multiplicacao.Direita.aceita(this) + " ) ";
        }

        public string visitaNumero(Numero numero) {
            return numero.GetNumero.ToString();
        }

        public string visitaSoma(Soma soma) {
            return " ( + " + soma.Esquerda.aceita(this) + " " + soma.Direita.aceita(this) + " ) ";
        }

        public string visitaSubtracao(Subtracao subtracao) {
            return " ( - " + subtracao.Esquerda.aceita(this) + " " + subtracao.Direita.aceita(this) + " ) ";
        }
    }
}
