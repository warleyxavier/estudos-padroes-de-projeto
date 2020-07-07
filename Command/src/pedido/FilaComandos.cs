using System;
using System.Collections.Generic;
using System.Text;

namespace Command.src.pedido {
    class FilaComandos {

        private IList<IComando> comandos = new List<IComando>();

        public void adicionar(IComando comando) {
            comandos.Add(comando);
        }

        public void processar() {

            foreach (IComando comando in comandos)
                comando.executar();

        }

    }
}
