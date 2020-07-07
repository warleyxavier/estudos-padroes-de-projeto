using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator.src.filtro {
    abstract class Filtro {

        private Filtro outroFiltro;

        public Filtro() {
            outroFiltro = null;
        }

        public Filtro(Filtro outroFiltro) {
            this.outroFiltro = outroFiltro;
        }

        public List<Conta> filtrar(List<Conta> contas) {
            List<Conta> contasDoOutroFiltro = filtrarPeloOutroFiltro(contas);

            List<Conta> contasDesteFiltro = filtrarEste(contas);

            return contasDoOutroFiltro.Concat(contasDesteFiltro).ToList();
        }

        private List<Conta> filtrarPeloOutroFiltro(List<Conta> contas) {
            if (outroFiltro == null)
                return new List<Conta>();

            return outroFiltro.filtrar(contas);
        }

        abstract protected List<Conta> filtrarEste(List<Conta> contas);
    }
}
