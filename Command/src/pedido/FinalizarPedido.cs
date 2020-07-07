using System;
using System.Collections.Generic;
using System.Text;

namespace Command.src.pedido {
    class FinalizarPedido : IComando {

        private Pedido pedido;

        public FinalizarPedido(Pedido pedido) {
            this.pedido = pedido;
        }

        public void executar() {
            pedido.finalizar();
        }
    }
}
