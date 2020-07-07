using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.src.desconto {
    class DescontoPorVendaCasada : Desconto {

        private Desconto proximo;
        double Desconto.geraValorDesconto(Venda venda) {
            bool contemItem = venda.contemItem("lapis") && venda.contemItem("caneta");

            if (contemItem)
                return venda.Valor * 0.05;

            return proximo.geraValorDesconto(venda);
        }

        void Desconto.insereProximo(Desconto desconto) {
            proximo = desconto;
        }
    }
}
