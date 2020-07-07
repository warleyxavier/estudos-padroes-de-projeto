using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Strategy {
    class CalculadorDeImpostos {

        public double calcular(Orcamento orcamento, Imposto imposto) {
            return imposto.calcular(orcamento);
        }

    }
}
