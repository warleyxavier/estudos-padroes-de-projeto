using System;
using System.Collections.Generic;
using System.Text;

namespace Memento.src.contrato {
    class Historico {

        private IList<Estado> estados = new List<Estado>();

        public void adicionar(Estado estado) => this.estados.Add(estado);

        public Estado localiza(int posicao) => this.estados[posicao];

    }
}
