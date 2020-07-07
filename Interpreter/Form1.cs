using Interpreter.src.calculadora;
using InterpreterEVisitor.src.calculadora;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interpreter {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {

            IExpressao esquerda = new Subtracao(new Numero(10), new Numero(5));
            IExpressao direita = new Soma(new Numero(2), new Numero(10));

            IExpressao resultadoExpressao = new Soma(esquerda, direita);

            resultadoExpressao = new Multiplicacao(resultadoExpressao, new Numero(2));

            resultadoExpressao = new Divisao(resultadoExpressao, new Numero(3));


            double resultado = resultadoExpressao.executar();

            MessageBox.Show(resultado.ToString());

            IVisitor visitor = new ImpressoraVisitor();

            string expressao = resultadoExpressao.aceita(visitor);

            MessageBox.Show(expressao);
        }
    }
}
