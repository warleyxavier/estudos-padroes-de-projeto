using Decorator.src.filtro;
using Decorator.src.imposto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Decorator {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

            List<Conta> contas = new List<Conta>();

            contas.Add(new Conta(50, new DateTime(2020, 6, 4)));
            contas.Add(new Conta(200, new DateTime(2020, 6, 4)));
            contas.Add(new Conta(5000000, new DateTime(2020, 6, 4)));
            contas.Add(new Conta(300, DateTime.Now));

            Filtro filtroDataAbertura = new FiltroDataAbertura();
            Filtro filtroMaior500Mil = new FiltroMaior500Mil(filtroDataAbertura);
            Filtro filtroMenor100 = new FiltroMenorQue100(filtroMaior500Mil);

            List<Conta> contasFiltradas = filtroMenor100.filtrar(contas);

            contasFiltradas.ForEach(conta => {
                MessageBox.Show(conta.Saldo.ToString());
            });

        }
    }
}
