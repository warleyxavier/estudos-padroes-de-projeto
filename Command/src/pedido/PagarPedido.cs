using System;
using System.Collections.Generic;
using System.Text;

namespace Command.src.pedido {
    class PagarPedido : IComando {

        private Pedido pedido;

        public PagarPedido(Pedido pedido) {
            this.pedido = pedido;
        }

        public void executar() {
            pedido.pagar();
        }
    }
}
