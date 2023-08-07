using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class PilaNombres
    {
        private Stack<string> pila;

        public PilaNombres()
        {
            pila = new Stack<string>();
        }

        public void AgregarNombre(string nombre)
        {
            pila.Push(nombre);
        }

        public string SacarNombre()
        {
            if (pila.Count > 0)
            {
                return pila.Pop();
            }
            else
            {
                return "La pila está vacía.";
            }
        }
    }
}
