using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.src.requisicoes {
    class GeradorResposta {

        public void gerar(Requisicao requisicao, Conta conta) {

            IResposta analiseResposta = new RespostaPorcentagem(new RespostaCSV(new RespostaXML(new SemResposta(null))));

            analiseResposta.responde(requisicao, conta);
        }

    }
}
