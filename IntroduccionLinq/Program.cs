
using IntroduccionLinq;

#region Introduccion 
/*
// Declara un arreglo de cadenas llamado 'palabras'.
string[] palabras;

// Inicializa el arreglo 'palabras' con un conjunto de palabras.
palabras = new string[] { "gato", "perro", "lagarto", "tortuga", "cocodrilo", "serpiente", "123456789" };

// Imprime en la consola el mensaje "Más de 5 letras" para indicar qué se va a mostrar a continuación.
Console.WriteLine("Mas de 5 letras");

// Crea una lista de cadenas llamada 'resultado' para almacenar las palabras que cumplen el criterio.
List<string> resultado = new List<string>();

// Itera sobre cada elemento en el arreglo 'palabras'.
foreach (string str in palabras) {
    // Verifica si la longitud de la palabra actual es mayor que 5.
    if (str.Length > 5) {
        // Si la condición es verdadera, agrega la palabra a la lista 'resultado'.
        resultado.Add(str);
    }
}

// Itera sobre cada elemento en la lista 'resultado'.
foreach (var r in resultado) 
    // Imprime cada palabra en la consola.
    Console.WriteLine(r);

*/
#endregion
#region utilizando Linq
/*// Imprime una línea de guiones para separar visualmente el contenido en la consola.
Console.WriteLine("-----------------------------------------------------");

// Utiliza LINQ para filtrar las palabras del arreglo 'palabras' que tienen más de 8 caracteres.
// 'list' es una variable de tipo IEnumerable<string> que almacena los resultados de la consulta.
IEnumerable<string> list = from r in palabras where r.Length > 8 select r;

// Itera sobre cada elemento en 'list'.
foreach(var listado in list)
    // Imprime cada palabra filtrada en la consola.
    Console.WriteLine(listado);

// Imprime otra línea de guiones para indicar el fin de la sección en la consola.
Console.WriteLine("-----------------------------------------------------");

*/
#endregion
#region ListaModelos
// Crea una lista de objetos de tipo 'Casa'. Esta lista será utilizada para almacenar múltiples instancias de 'Casa'.
List<Casa> ListaCasas = new List<Casa>();

// Crea una lista de objetos de tipo 'Habitante'. Esta lista será utilizada para almacenar múltiples instancias de 'Habitante'.
List<Habitante> ListaHabitantes = new List<Habitante>();

#endregion
#region listaCasa
// Añade una nueva casa a la lista 'ListaCasas'.
ListaCasas.Add(new Casa
{
    Id = 1, // Identificador único de la casa.
    Direccion = "3 av Norte ArcanCity", // Dirección de la casa.
    Ciudad = "Gothan City", // Ciudad donde se encuentra la casa.
    numeroHabitaciones = 20, // Número de habitaciones que tiene la casa.
});

// Añade otra casa a la lista 'ListaCasas'.
ListaCasas.Add(new Casa
{
    Id = 2, // Identificador único de la casa.
    Direccion = "6 av Sur SmollVille", // Dirección de la casa.
    Ciudad = "Metropolis", // Ciudad donde se encuentra la casa.
    numeroHabitaciones = 5, // Número de habitaciones que tiene la casa.
});

// Añade otra casa a la lista 'ListaCasas'. 
// Nota: Este código es incompleto y puede causar un error si no se cierra adecuadamente.
ListaCasas.Add(new Casa
{
    Id = 3, // Identificador único de la casa.
    Direccion = "Forest Hills, Queens, NY 11375", // Dirección completa de la casa.
    Ciudad = "New York" // Ciudad donde se encuentra la casa.
    // Falta cerrar correctamente el objeto y potencialmente definir 'numeroHabitaciones'.
});

#endregion
#region ListaHabitante
// Añade un nuevo habitante a la lista 'ListaHabitantes'.
ListaHabitantes.Add(new Habitante
{
    IdHabitante = 1, // Identificador único del habitante, que se supone debe ser único para cada habitante.
    Nombre = "Bruno Diaz", // Nombre del habitante.
    Edad = 36, // Edad del habitante.
    IdCasa = 1 // Identificador de la casa asociada a este habitante.
});

// Añade otro habitante a la lista con diferente información.
ListaHabitantes.Add(new Habitante
{
    IdHabitante = 2,
    Nombre = "Clark Kent.",
    Edad = 40,
    IdCasa = 2
});

// Continúa añadiendo habitantes a la lista con sus respectivas propiedades.
ListaHabitantes.Add(new Habitante
{
    IdHabitante = 3,
    Nombre = "Peter Parker",
    Edad = 25,
    IdCasa = 3
});

// Añade otro habitante con el mismo IdHabitante que el anterior, lo cual podría ser un error si se espera que sean únicos.
ListaHabitantes.Add(new Habitante
{
    IdHabitante = 3,
    Nombre = "Tia Mey",
    Edad = 85,
    IdCasa = 3
});

// Añade otro habitante, notando que el IdHabitante se repite, lo que puede ser un problema.
ListaHabitantes.Add(new Habitante
{
    IdHabitante = 2,
    Nombre = "Luise Lain",
    Edad = 40,
    IdCasa = 2
});

// Más habitantes son añadidos con un IdHabitante ya usado, sugiriendo que la aplicación no requiere identificadores únicos o hay un error.
ListaHabitantes.Add(new Habitante
{
    IdHabitante = 1,
    Nombre = "Selina Kyle",
    Edad = 30,
    IdCasa = 1
});

// Continúa añadiendo habitantes con IdHabitante repetido.
ListaHabitantes.Add(new Habitante
{
    IdHabitante = 1,
    Nombre = "Alfred",
    Edad = 65,
    IdCasa = 1
});

// Añade un último habitante con IdHabitante repetido.
ListaHabitantes.Add(new Habitante
{
    IdHabitante = 1,
    Nombre = "Nathan Drake",
    Edad = 37,
    IdCasa = 1
});
#endregion
#region SentenciasLinQ
/*
// Crea una colección de tipo IEnumerable<Habitante> que incluye solo aquellos habitantes mayores de 40 años.
IEnumerable<Habitante> ListaEdad = from ObjetoProvicional
                                   in ListaHabitantes
                                   where ObjetoProvicional.Edad > 40
                                   select ObjetoProvicional;

// Itera sobre cada habitante en ListaEdad y escribe sus datos en la consola utilizando el método 'datosHabitante'.
foreach (Habitante objetoProvicional2 in ListaEdad)
{
    Console.WriteLine(objetoProvicional2.datosHabitante());
}


Join
// Realiza un join entre las listas ListaHabitantes y ListaCasas para encontrar aquellos habitantes que viven en casas en "Gothan City".
IEnumerable<Habitante> listaCasaGothan = from objetoTemporalHabitante in ListaHabitantes
                                         join objetoTemporalCasa in ListaCasas
                                         on objetoTemporalHabitante.IdHabitante equals objetoTemporalCasa.Id
                                         where objetoTemporalCasa.Ciudad == "Gothan City"
                                         select objetoTemporalHabitante;

// Imprime una línea divisoria en la consola.
Console.WriteLine("----------------------------------------------------------------------------------------------");

// Itera sobre cada habitante en listaCasaGothan y escribe sus datos en la consola utilizando el método 'datosHabitante'.
foreach (Habitante h in listaCasaGothan) {
    Console.WriteLine(h.datosHabitante());
}

*/
#endregion
#region FirsthAndFirsthOrDefault
/* 
// Imprime una línea de guiones para separar visualmente la salida en la consola.
Console.WriteLine("----------------------------------------------------------------------------------------------");

// Obtiene la primera 'Casa' de la lista 'ListaCasas' usando el método 'First()'.
var primeraCasa = ListaCasas.First();
// Imprime los datos de la primera casa utilizando el método 'dameDatosCasa()'.
Console.WriteLine(primeraCasa.dameDatosCasa());

// Utiliza LINQ para seleccionar el primer 'Habitante' mayor de 25 años de 'ListaHabitantes' sin usar expresión lambda.
Habitante personaEdad = (from variableTemporalHabitante in ListaHabitantes
                         where variableTemporalHabitante.Edad > 25
                         select variableTemporalHabitante).First();
// Imprime los datos de esta persona.
Console.WriteLine(personaEdad.datosHabitante());

// Imprime una línea divisoria para separar las diferentes partes del código.
Console.WriteLine("---------------------------Lo mismo pero con lambdas---------------------------------------------------------");

// Realiza la misma operación anterior pero utilizando una expresión lambda.
var Habitante1 = ListaHabitantes.First(objectTemp => objectTemp.Edad > 25);
// Imprime los datos de esta persona.
Console.WriteLine(Habitante1.datosHabitante());

// Intenta obtener una 'Casa' con un ID mayor que 10. Si no existe tal 'Casa', se lanzará una excepción.
Casa EdadError = (from vCasaTemp in ListaCasas where vCasaTemp.Id > 10 select vCasaTemp).First();
Console.WriteLine(EdadError.dameDatosCasa());

// Utiliza 'FirstOrDefault()' para buscar una 'Casa' con un ID mayor que 200 para evitar lanzar una excepción si no existe.
Casa CasaConFirstOrDefault = ListaCasas.FirstOrDefault(vCasa => vCasa.Id > 200);
if (CasaConFirstOrDefault == null) {
    // Si no se encuentra la casa, imprime un mensaje indicando que no existe y termina la ejecución.
    Console.WriteLine("No existe! No hay!");
    return;
}
// Si se encuentra la casa, imprime un mensaje indicando que sí existe.
Console.WriteLine("Existe! Sí existe!");

*/
#endregion
#region Last
/*// Intenta obtener la última 'Casa' en 'ListaCasas' cuyo ID sea mayor que 1 usando el método 'Last()'.
Casa ultimaCasa = ListaCasas.Last(temp => temp.Id > 1);
// Imprime los datos de esta casa utilizando el método 'dameDatosCasa()'.
Console.WriteLine(ultimaCasa.dameDatosCasa());

// Imprime una línea de separación para claridad visual en la consola.
Console.WriteLine("_____________________________________________________");

// Utiliza LINQ para seleccionar el último 'Habitante' mayor de 60 años de 'ListaHabitantes', utilizando 'LastOrDefault()'
// para evitar excepciones si no hay elementos que cumplan la condición.
var h1 = (from objHabitante in ListaHabitantes
          where objHabitante.Edad > 60
          select objHabitante).LastOrDefault();

// Verifica si 'h1' es null, lo que indicaría que no hay habitantes mayores de 60 años.
if (h1 == null) {
    // Si es null, imprime un mensaje de error y termina la ejecución.
    Console.WriteLine("Algo fallo");
    return;
}

// Si 'h1' no es null, imprime los datos del habitante.
Console.WriteLine(h1.datosHabitante());

*/
#endregion
#region ElementAt
/*
// Obtiene el tercer elemento de la lista 'ListaCasas' (indexación basada en cero, por lo que el índice 2 corresponde al tercer elemento).
var terceraCasa = ListaCasas.ElementAt(2);
// Imprime los datos de la tercera casa utilizando el método 'dameDatosCasa()'.
Console.WriteLine($"La tercera casa es {terceraCasa.dameDatosCasa()}");

// Intenta obtener el cuarto elemento de 'ListaCasas' usando 'ElementAtOrDefault' para evitar una excepción si el índice está fuera de rango.
var casaError = ListaCasas.ElementAtOrDefault(3);
// Verifica si el resultado no es null (lo que indicaría que el elemento existe).
if (casaError != null) {
    // Si el elemento existe, imprime sus datos.
    Console.WriteLine($"La tercera casa es {casaError.dameDatosCasa()}");
} // Si no hay cuarto elemento, no se imprime nada.

// Intenta obtener el tercer habitante de 'ListaHabitantes' usando 'ElementAtOrDefault' para prevenir excepciones por índice fuera de rango.
var segundoHabitante = (from objetoTem in ListaHabitantes select objetoTem).ElementAtOrDefault(2);
// Imprime los datos del segundo habitante si este no es null.
Console.WriteLine($"El segundo habitante es: {segundoHabitante.datosHabitante()}");
*/
#endregion
#region single

//try
//{
//    // Utilizando LINQ para encontrar el único habitante cuya edad está entre 40 y 70 años.
//    var habitante1 = ListaHabitantes.Single(variableTem => variableTem.Edad > 40 && variableTem.Edad < 70);

//    // Utilizando LINQ para encontrar el único habitante cuya edad es mayor que 70 años.
//    var habitante2 = (from obtem in ListaHabitantes where obtem.Edad > 70 select obtem).SingleOrDefault();

//    // Imprime los datos del habitante encontrado cuya edad está entre 40 y 70 años.
//    Console.WriteLine($"habitante con edad entre 40 y 70 años: {habitante1.datosHabitante()}");

//    // Verifica si se encontró un habitante cuya edad es mayor que 70 años.
//    if (habitante2 != null)
//    {
//        // Imprime los datos del habitante encontrado cuya edad es mayor que 70 años.
//        Console.WriteLine($"habitante con más de 70 años: {habitante2.datosHabitante()}");
//    }
//}
//catch (Exception)
//{
//    // Captura cualquier excepción que pueda ocurrir durante la ejecución de las consultas LINQ.
//    Console.WriteLine($"Ocurrió un error al ejecutar la consulta LINQ.");
//}

#endregion
#region typeOf
/* 
// Crea una lista de 'Empleado' que contiene un 'Medico' y un 'Enfermero'.
var listaEmpleados = new List<Empleado>() { 
    new Medico(){ nombre= "Jorge Casa" }, // Añade un nuevo 'Medico' con nombre "Jorge Casa".
    new Enfermero(){ nombre = "Raul Blanco"} // Añade un nuevo 'Enfermero' con nombre "Raul Blanco".
};

// Filtra la lista de empleados para obtener solo aquellos que son de tipo 'Medico'.
var medico = listaEmpleados.OfType<Medico>();

// Utiliza 'Single()' para obtener el único elemento de tipo 'Medico' en la lista y muestra su nombre.
// Si hay cero o más de un 'Medico', 'Single()' lanzará una excepción.
Console.WriteLine(medico.Single().nombre);

*/
#endregion
#region OrderBy
/*// Ordena 'ListaHabitantes' por la propiedad 'Edad' de cada 'Habitante' en orden ascendente usando el método de extensión 'OrderBy'.
var edadA = ListaHabitantes.OrderBy(x => x.Edad);

// Realiza la misma operación de ordenamiento usando sintaxis de consulta LINQ.
var edadAC = from vt in ListaHabitantes
             orderby vt.Edad
             select vt;

// Itera sobre la colección ordenada 'edadAC'.
foreach (var edad in edadAC) { 
    // Imprime los datos del habitante utilizando el método 'datosHabitante()'.
    Console.WriteLine(edad.datosHabitante());
}

*/
#endregion
#region OrderBYDescending()
/*// Ordena 'ListaHabitantes' por la propiedad 'Edad' de cada 'Habitante' en orden descendente usando el método 'OrderByDescending'.
var listaEdad = ListaHabitantes.OrderByDescending(x => x.Edad);

// Itera sobre la lista ordenada 'listaEdad'.
foreach (Habitante h in listaEdad) { 
    // Imprime los datos del habitante utilizando el método 'datosHabitante()', que probablemente incluye nombre, edad, y otros detalles.
    Console.WriteLine(h.datosHabitante());
}

// Imprime una línea de separación para diferenciar entre las dos listas impresas.
Console.WriteLine("-------------------------------------------");

// Realiza la misma operación de ordenamiento usando sintaxis de consulta LINQ, ordenando en orden descendente.
var ListaEdad2 = from h in ListaHabitantes
                 orderby h.Edad descending
                 select h;

// Itera sobre la colección ordenada 'ListaEdad2'.
foreach (Habitante h in ListaEdad2)
{
    // Imprime los datos de cada habitante, como antes.
    Console.WriteLine(h.datosHabitante());
}

*/
#endregion
#region ThenBy
var habitantes3 = ListaHabitantes.OrderBy(x => x.Edad).ThenBy(x => x.Nombre);



var edadATA = from h in ListaHabitantes orderby h.Edad, h.Nombre descending select h;

foreach (var h in edadATA)
{
    Console.WriteLine(h.datosHabitante());
}

Console.WriteLine("------------------");

var habitantes4 = ListaHabitantes.OrderBy(x => x.Edad).ThenByDescending(x => x.Nombre);

var lista4 = from h in ListaHabitantes orderby h.Edad, h.Nombre ascending select h;

foreach (var h in lista4)
{
    Console.WriteLine(h.datosHabitante());
}

#endregion
