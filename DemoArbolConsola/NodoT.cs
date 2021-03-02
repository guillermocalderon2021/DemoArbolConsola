using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoArbolConsola
{
    class NodoT
    {
        private int valor;

        public int Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        private NodoT nodoIzquierdo;

        public NodoT NodoIzquierdo
        {
            get { return nodoIzquierdo; }
            set { nodoIzquierdo = value; }
        }

        private NodoT nodoDerecho;

        public NodoT NodoDerecho
        {
            get { return nodoDerecho; }
            set { nodoDerecho = value; }
        }

        public NodoT(int n)
        {
            this.valor = n;
            this.nodoIzquierdo = null;
            this.NodoDerecho = null;
        }

    }
}
