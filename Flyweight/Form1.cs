using Flyweight.src.musica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flyweight {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {

            GeradorNotas geradorNotas = new GeradorNotas();

            List<INota> notas = new List<INota>();
            notas.Add(geradorNotas.localizar("do"));
            notas.Add(geradorNotas.localizar("re"));
            notas.Add(geradorNotas.localizar("mi"));
            notas.Add(geradorNotas.localizar("fa"));
            notas.Add(geradorNotas.localizar("fa"));
            notas.Add(geradorNotas.localizar("fa"));
            notas.Add(geradorNotas.localizar("doSustenido"));
            notas.Add(geradorNotas.localizar("reSustenido"));

            string simbolos = "";

            foreach (INota nota in notas)
                simbolos = simbolos + nota.Simbolo + " ";

            MessageBox.Show(simbolos);
        }
    }
}
