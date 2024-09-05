using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Define el espacio de nombres 'IntroduccionLinq'.
namespace IntroduccionLinq
{
    // Define una clase pública llamada 'Habitante'.
    public class Habitante
    {
        // Propiedad pública de tipo entero que almacena el identificador único del habitante.
        public int IdHabitante { get; set; }

        // Propiedad pública de tipo cadena que almacena el nombre del habitante.
        public string Nombre { get; set; }

        // Propiedad pública de tipo entero que almacena la edad del habitante.
        public int Edad { get; set; }

        // Propiedad pública de tipo entero que almacena el identificador de la casa asociada al habitante.
        public int IdCasa { get; set; }

        // Método público que devuelve una cadena con los detalles del habitante.
        public string datosHabitante()
        {
            // Devuelve una cadena formateada con el nombre, la edad y el identificador de la casa del habitante.
            return $"Soy {Nombre} con edad de {Edad} años vividos en {IdCasa}";
        }
    }
}
