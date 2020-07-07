using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Memento.src.contrato {
    class Estado {

        private Contrato contrato;
        private DateTime horarioGeracao;

        public Estado(DateTime horarioGeracao, Contrato contrato) {
            this.horarioGeracao = horarioGeracao;
            this.contrato = contrato;
        }

        public Contrato Contrato => this.contrato;
    }
}
