using Command.src.pedido;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Command {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {

            Pedido pedido1 = new Pedido("Goku", 50.50);
            Pedido pedido2 = new Pedido("Naruto", 70);

            FilaComandos comandos = new FilaComandos();
            comandos.adicionar(new PagarPedido(pedido1));
            comandos.adicionar(new PagarPedido(pedido2));
            comandos.adicionar(new FinalizarPedido(pedido1));
            comandos.adicionar(new FinalizarPedido(pedido2));

            comandos.processar();

            MessageBox.Show("Comandos processados com sucesso");
            MessageBox.Show(pedido1.Status.ToString());
            MessageBox.Show(pedido2.Status.ToString());

        }
    }
}
