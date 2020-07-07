using ChainOfResponsibility.src.desconto;
using ChainOfResponsibility.src.requisicoes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChainOfResponsibility {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

            Requisicao requisicao = new Requisicao(Formato.Nenhum);

            Conta conta = new Conta();

            GeradorResposta gerador = new GeradorResposta();
            gerador.gerar(requisicao, conta);

        }                                       
    }                                           
}
