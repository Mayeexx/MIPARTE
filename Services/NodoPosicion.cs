using MIPARTE.Models;
using System.Collections.Generic;
  using System.Linq;
namespace MIPARTE.Services
{
  
        // Servicio para manipular la lista de nodos
        public class NodoPosicion
        {
            private List<Nodo> nodos = new List<Nodo>(); // Lista para almacenar los nodos

            // Método para obtener todos los nodos
            public List<Nodo> ObtenerNodos()
            {
                return nodos;
            }

            // Método para agregar un nodo en una posición específica
            public void AgregarNodoEnPosicion(int posicion, string valor)
            {
                nodos.Insert(posicion, new Nodo { Posicion = posicion, Valor = valor });
            }
        }
    

}

