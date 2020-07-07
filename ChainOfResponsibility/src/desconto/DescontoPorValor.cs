using ChainOfResponsibility.src.desconto;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility {
    class DescontoPorValor : Desconto {

        private Desconto proximo;
        double Desconto.geraValorDesconto(Venda venda) {

            if (venda.Valor > 500)
                return venda.Valor * 0.07;

            return proximo.geraValorDesconto(venda);

        }

        void Desconto.insereProximo(Desconto desconto) {
            this.proximo = desconto;
        }
    }
}
