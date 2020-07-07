using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.src.desconto {
    class SemDesconto : Desconto {
        double Desconto.geraValorDesconto(Venda venda) {
            return 0;
        }

        void Desconto.insereProximo(Desconto desconto) {
        }
    }
}
