using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ChainOfResponsibility.src.requisicoes {
    class SemResposta : IResposta {

        private IResposta proxima;
        public SemResposta(IResposta proxima) {
            this.proxima = proxima;
        }
        public void responde(Requisicao requisicao, Conta conta) {
            MessageBox.Show("SemResposta");
        }
    }
}
