using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy {
    class ISS : Imposto {
        double Imposto.calcular(Orcamento orcamento) {
            return orcamento.Valor * 0.06;
        }
    }
}
