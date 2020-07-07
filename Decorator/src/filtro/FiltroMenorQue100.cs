using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator.src.filtro {
    class FiltroMenorQue100 : Filtro {
        public FiltroMenorQue100() {
        }

        public FiltroMenorQue100(Filtro outroFiltro) : base(outroFiltro) {
        }

        protected override List<Conta> filtrarEste(List<Conta> contas) {
            return contas.Where(conta => conta.Saldo < 100).ToList();
        }
    }
}
