using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ColaNombres
    {
        private Queue<string> cola;

        public ColaNombres()
        {
            cola = new Queue<string>();
        }

        public void AgregarNombre(string nombre)
        {
            cola.Enqueue(nombre);
        }

        public string SacarNombre()
        {
            if (cola.Count > 0)
            {
                return cola.Dequeue();
            }
            else
            {
                return "La cola está vacía.";
            }
        }
    }
}
