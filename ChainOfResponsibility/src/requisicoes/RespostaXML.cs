using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ChainOfResponsibility.src.requisicoes {
    class RespostaXML : IResposta {

        private IResposta proxima;

        public RespostaXML(IResposta proxima) {
            this.proxima = proxima;
        }

        public void responde(Requisicao requisicao, Conta conta) {
            if (requisicao.Formato == Formato.XML) {
                MessageBox.Show("XML");
                return;
            }

            proxima.responde(requisicao, conta);
        }

    }
}
