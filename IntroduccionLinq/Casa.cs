using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduccionLinq
{
    // Define una clase pública llamada 'Casa'.
    public class Casa
    {
        // Propiedad pública de tipo entero que almacena el identificador único de la casa.
        public int Id { get; set; }

        // Propiedad pública de tipo cadena que almacena la dirección de la casa.
        public string Direccion { get; set; }

        // Propiedad pública de tipo cadena que almacena la ciudad donde se encuentra la casa.
        public string Ciudad { get; set; }

        // Propiedad pública de tipo entero que almacena el número de habitaciones de la casa.
        public int numeroHabitaciones { get; set; }

        // Método público que devuelve una cadena con los detalles de la casa.
        public string dameDatosCasa()
        {
            // Devuelve una cadena formateada con la dirección, la ciudad y el número de habitaciones de la casa.
            return $"Direcion es {Direccion} en la ciudad de {Ciudad} con numero de habitaciones {numeroHabitaciones}";
        }

    }
}
