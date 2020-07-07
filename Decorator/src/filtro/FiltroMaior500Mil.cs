using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator.src.filtro {
    class FiltroMaior500Mil : Filtro {
        public FiltroMaior500Mil() {
        }

        public FiltroMaior500Mil(Filtro outroFiltro) : base(outroFiltro) {
        }

        protected override List<Conta> filtrarEste(List<Conta> contas) {
            return contas.Where(conta => conta.Saldo > 500000).ToList();
        }
    }
}
