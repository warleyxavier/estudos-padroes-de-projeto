using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ChainOfResponsibility.src.requisicoes {
    class RespostaCSV : IResposta {

        private IResposta proxima;

        public RespostaCSV(IResposta proxima) {
            this.proxima = proxima;
        }

        public void responde(Requisicao requisicao, Conta conta) {
            if (requisicao.Formato == Formato.CSV) {
                MessageBox.Show("CSV");
                return;
            }

            proxima.responde(requisicao, conta);
        }
    }
}
