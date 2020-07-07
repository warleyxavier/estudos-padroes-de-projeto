using System;
using System.Collections.Generic;
using System.Text;

namespace Command.src.pedido {

    enum Status { Novo, Processando, Pago, ItemSeparado, Entregue };

    class Pedido {

        private string cliente;
        private double valor;
        private Status status;
        private DateTime dataFinalizacao;

        public Pedido(string cliente, double valor) {
            this.cliente = cliente;
            this.valor = valor;

            this.status = Status.Novo;
        }

        public Status Status => this.status;


        public void pagar() {
            this.status = Status.Pago;
        }

        public void finalizar() {
            this.dataFinalizacao = DateTime.Now;
            this.status = Status.Entregue;
        }
    }
}
