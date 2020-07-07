using System;
using System.Collections.Generic;
using System.Text;

namespace Memento.src.contrato {

    enum Tipo { Novo, EmAndamento, Acertado, Concluido };

    class Contrato {

        private DateTime data;
        private string cliente;
        private Tipo tipo;

        public Contrato(DateTime data, string cliente, Tipo tipo) {
            this.data = data;
            this.cliente = cliente;
            this.tipo = tipo;
        }

        public DateTime Data => this.data;

        public string Cliente => this.cliente;

        public Tipo Tipo => this.tipo;

        public Estado geraEstado() => new Estado(DateTime.Now, new Contrato(this.data, this.cliente, this.tipo));

        public void avancarTipo() {

            switch (tipo) {
                case Tipo.Novo:
                    tipo = Tipo.EmAndamento;
                    break;
                case Tipo.EmAndamento:
                    tipo = Tipo.Acertado;
                    break;
                case Tipo.Acertado:
                    tipo = Tipo.Concluido;
                    break;
            }
        }
    }
}
