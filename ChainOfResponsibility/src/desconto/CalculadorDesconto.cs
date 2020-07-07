using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.src.desconto {
    class CalculadorDesconto {

        public double calcular(Venda venda) {

            Desconto semDesconto = new SemDesconto();

            Desconto descontoPorQuantidade = new DescontoPorQuantidadeItens();
            descontoPorQuantidade.insereProximo(semDesconto);

            Desconto descontoPorVendaCasada = new DescontoPorVendaCasada();
            descontoPorVendaCasada.insereProximo(descontoPorQuantidade);

            Desconto descontoPorValor = new DescontoPorValor();
            descontoPorValor.insereProximo(descontoPorVendaCasada);

            double valorDesconto = descontoPorValor.geraValorDesconto(venda);

            return valorDesconto;
        }

    }
}
