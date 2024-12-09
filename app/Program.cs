// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!"); //Para mostrar en pantalla

string libro = "EL programador Cesar";

int numero = 200;

int[] list = { 23, 20, 25, 27, 45, 65 }; //arreglo

List<int> numeros = new List<int> { 23, 20, 25, 27, 45, 65 }; //Lista

Console.WriteLine(libro);
Console.WriteLine(numero);
Console.WriteLine(list[3]);
Console.WriteLine(string.Join(",", numeros));

//Diccionarios 
Console.WriteLine("\n");


Dictionary<int, string> Jugadores = new Dictionary<int, string>();

Jugadores.Add(13, "Cesar");
Jugadores.Add(23, "zule");

Console.WriteLine(Jugadores[23]);

//Constantes

const float pi = 3.1415926F;
Console.WriteLine("La variable de pi es: ", pi);

// Operadores
Console.WriteLine("\n");


Console.WriteLine(1 + 1);
Console.WriteLine(3 - 5);
Console.WriteLine(5 * 2);
Console.WriteLine(54 / 2);

//Operadores Booleanos
Console.WriteLine("\n");


Console.WriteLine(1 == 1);
Console.WriteLine(3 < 5);
Console.WriteLine(5 != 2);
Console.WriteLine(54 >= 2);

//Operadores logicos 
Console.WriteLine("\n");

//&& "Y"
Console.WriteLine(true && true);
Console.WriteLine(true && false);
Console.WriteLine(false && true);
Console.WriteLine(false && false);

Console.WriteLine("\n");


// || "O"
Console.WriteLine(true || true);
Console.WriteLine(true || false);
Console.WriteLine(false || true);
Console.WriteLine(false || false);

// Condicionales

Console.WriteLine("\n");

bool llave = false;

//Condicional if
if (llave)
{
    Console.WriteLine("La llave funciona.");
}
else
{

    Console.WriteLine("La llave no funciono.");

}

Console.WriteLine("\n");

string color = "rojo";

//Condicional Switch
switch (color)
{
    case "verde":
        Console.WriteLine("Puede avanzar.");
        break;
    case "amarillo":
        Console.WriteLine("Reduzca su velocidad.");
        break;
    case "rojo":
        Console.WriteLine("Detengase.");
        break;
    default:
        Console.WriteLine("Semaforo dañado. Detengase...");
        break;

}


//Funciones

Console.WriteLine("\n");

int sumar(int primero, int segundo) // Para sumar
{

    return primero + segundo;
}

int resultado = sumar(3, 4);

Console.WriteLine(resultado);

//Funcion para ordenar una lista

List<int> quicksort(List<int> lista)
{
    if (lista.Count <= 1)
    {
        return lista;
    }
    int pivote = lista[0];
    List<int> izquierda = new List<int>();
    List<int> derecha = new List<int>();
    for (int i = 1; i < lista.Count; i++)
    {
        if (lista[i] < pivote)
        {
            izquierda.Add(lista[i]);
        }
        else
        {
            derecha.Add(lista[i]);
        }
    }

    List<int> primero = quicksort(izquierda);
    List<int> medio = new List<int>(pivote);
    List<int> segundo = quicksort(derecha);
    primero.AddRange(medio);
    primero.AddRange(segundo);
    return primero;

}

List<int> listaOrdenada = quicksort(numeros);
Console.WriteLine("\n");
Console.WriteLine(string.Join(",", listaOrdenada));
// Falta terminar


//Ciclos, bucles o loops

string[] animales = { "perro", "gato", "gallo", "tigre" };
//Foreah
foreach (string animal in animales)
{
    Console.WriteLine("\n");
    Console.WriteLine(animal);
}

// otro
void multiplicar(int primero, int segundo)
{
    Console.WriteLine(primero * segundo);
}

int[] arreglosNum = { 12, 25, 45, 21, 31 };

foreach (int Aux in arreglosNum)
{
    multiplicar(Aux, 2);
}

//While

int llamada = 909;
int emergencia = 911;

while (llamada <= emergencia)
{
    Console.WriteLine("llamada");
    llamada++;
}

// PPO Clases

Console.WriteLine("\n");
Console.WriteLine("Objetos de lenguajes");
Console.WriteLine("\n");

Lenguaje html = new Lenguaje("html", 1993);
html.descripcion();
Lenguaje css = new Lenguaje("css", 1996);
css.descripcion();
Lenguaje python = new Lenguaje("python", 2003);
python.descripcion();