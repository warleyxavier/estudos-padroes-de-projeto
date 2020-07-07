using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.src.requisicoes {

    enum Formato { XML, CSV, Porcento, Nenhum };
    class Requisicao {

        private Formato formato;

        public Requisicao(Formato formato) {
            this.formato = formato;
        }

        public Formato Formato { get => formato; set => formato = value; }
    }
}
