using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms.VisualStyles;

namespace ChainOfResponsibility.src.desconto {
    class Venda {


        private double valor = 0;
        private List<string> itens;

        public Venda(double valor) {
            this.valor = valor;

            itens = new List<string>();
        }

        public double Valor {
            get => this.valor;
            set => this.valor = value;
        }

        public int getQuantidadeItens() {
            return this.itens.Count;
        }

        public bool contemItem(string item) {
            return this.itens.Contains(item.ToUpper());
        }

        public void adicionarItem(string nomeItem) {
            itens.Add(nomeItem.ToUpper());
        }

    }
}
