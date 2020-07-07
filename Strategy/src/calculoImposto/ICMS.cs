using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy {
    class ICMS : Imposto {
        double Imposto.calcular(Orcamento orcamento) {
            return orcamento.Valor * 0.05 + 50.00;
        }
    }
}
