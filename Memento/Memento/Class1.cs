using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_Memento
{


    public class Memento
    {
        public Memento(Color c, string t)
        {
            color = c;
            texto = t;
        }
        public Color color { get; set; }
        public string texto { get; set; }

    }

    public class Guardian
    {
        private Stack<Memento> mementos = new Stack<Memento>();
        public void push(Memento m)
        {
            mementos.Push(m);   
        }
        public Memento pop()
        {
            return mementos.Pop();
        }

    }
}
