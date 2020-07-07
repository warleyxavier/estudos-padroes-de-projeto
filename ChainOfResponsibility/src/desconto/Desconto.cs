using ChainOfResponsibility.src.desconto;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility {
    interface Desconto {

        public double geraValorDesconto(Venda venda);
        public void insereProximo(Desconto desconto);

    }
}
