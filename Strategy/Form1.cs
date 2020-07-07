using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Strategy;

namespace Strategy
{
    public partial class Form1 : Form
    {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

            double valorDoImposto = 0;

            CalculadorDeImpostos calculador = new CalculadorDeImpostos();

            Orcamento venda = new Orcamento(10.00);

            Imposto ICMS = new ICMS();

            valorDoImposto = calculador.calcular(venda, ICMS);

            MessageBox.Show(valorDoImposto.ToString());

            Imposto ISS = new ISS();

            valorDoImposto = calculador.calcular(venda, ISS);

            MessageBox.Show(valorDoImposto.ToString());
        }
    }
}
