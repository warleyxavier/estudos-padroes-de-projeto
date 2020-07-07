using ChainOfResponsibility.src.desconto;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility {
    class DescontoPorQuantidadeItens : Desconto {

        private Desconto proximo;
        double Desconto.geraValorDesconto(Venda venda) {

            if (venda.getQuantidadeItens() > 5)
                return venda.Valor * 0.03;

            return proximo.geraValorDesconto(venda);

        }

        void Desconto.insereProximo(Desconto desconto) {
            this.proximo = desconto;
        }
    }
}
