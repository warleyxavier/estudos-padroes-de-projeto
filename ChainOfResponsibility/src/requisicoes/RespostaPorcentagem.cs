using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ChainOfResponsibility.src.requisicoes {
    class RespostaPorcentagem : IResposta {

        private IResposta proxima;

        public RespostaPorcentagem(IResposta proxima) {
            this.proxima = proxima;
        }

        public void responde(Requisicao requisicao, Conta conta) {
            if (requisicao.Formato == Formato.Porcento) {
                MessageBox.Show("Porcento");
                return;
            }

            proxima.responde(requisicao, conta);
        }

    }
}
