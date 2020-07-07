using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator.src.filtro {
    class FiltroDataAbertura : Filtro {
        public FiltroDataAbertura() {
        }

        public FiltroDataAbertura(Filtro outroFiltro) : base(outroFiltro) {
        }

        protected override List<Conta> filtrarEste(List<Conta> contas) {
            return contas.Where(conta => conta.DataAbertura.Month == DateTime.Today.Month && conta.DataAbertura.Year == DateTime.Today.Year).ToList();
        }
    }
}
