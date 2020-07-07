using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Flyweight.src.musica {
    class GeradorNotas {

        private static Dictionary<string, INota> notas = new Dictionary<string, INota>();
        private static Dictionary<string, Type> classes = new Dictionary<string, Type>();

        static GeradorNotas() {
            classes.Add("do", typeof(Do));
            classes.Add("re", typeof(Re));
            classes.Add("mi", typeof(Mi));
            classes.Add("fa", typeof(Fa));
            classes.Add("sol", typeof(Sol));
            classes.Add("la", typeof(La));
            classes.Add("si", typeof(Si));
            classes.Add("doSustenido", typeof(DoSustenido));
            classes.Add("reSustenido", typeof(ReSustenido));
        }

        public INota localizar(string identificadorNota) {


            if (!notas.ContainsKey(identificadorNota)) {
                Type classe = classes.GetValueOrDefault(identificadorNota);
                notas.Add(identificadorNota, Activator.CreateInstance(classe) as INota);
            }


            INota nota;

            if (!notas.TryGetValue(identificadorNota, out nota))
                throw new Exception("Deu ruim");

            return nota;
        }

    }
}
