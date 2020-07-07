using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Strategy.src.investimento {
    interface Investimento {

        public double gerarValorInvestimento(Conta conta); 

    }
}
