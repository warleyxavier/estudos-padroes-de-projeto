using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.src.requisicoes {
    interface IResposta {

        public void responde(Requisicao requisicao, Conta conta);

    }
}
