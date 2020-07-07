using Memento.src.contrato;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memento {
    public partial class Form1 : Form {

        private Contrato contrato = new Contrato(DateTime.Now, "Warley", Tipo.Novo);
        private Historico historico = new Historico();

        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {

            historico.adicionar(contrato.geraEstado());

            contrato.avancarTipo();

            MessageBox.Show(contrato.Tipo.ToString());
            
        }

        private void button2_Click(object sender, EventArgs e) {

            int posicao = int.Parse(textBox1.Text);

            Contrato contratoAntigo = historico.localiza(posicao).Contrato;

            MessageBox.Show(contratoAntigo.Tipo.ToString());

        }
    }
}
