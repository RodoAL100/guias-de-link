using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Define el espacio de nombres 'IntroduccionLinq'.
namespace IntroduccionLinq
{
    // Define una clase pública llamada 'Medico', que hereda de la clase 'Empleado'.
    public class Medico : Empleado
    {
        // Propiedad pública de tipo cadena que almacena el nombre del médico.
        // Nota: Esta propiedad está duplicada aquí innecesariamente, ya que 'Empleado' ya define una propiedad 'nombre'.
        public string nombre { get; set; }
    }
}
