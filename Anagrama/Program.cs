using System; 

internal class Program
{
    private static void Main(string[] args)
    {
        string Palabra1;
        string Palabra2;

        char[] Lista1;
        char[] Lista2;

        bool son = false; 


        Console.WriteLine("Ingrese la primera palabra: "); 
        Palabra1 = Console.ReadLine();
        Console.WriteLine("Ingrese la segunda palabra; "); 
        Palabra2 = Console.ReadLine();

        if(Palabra1.Length == Palabra2.Length) // Comprobamos que tenga la misma longitud
        {
            Lista1 = Palabra1.ToCharArray(); // Para convertir en Array
            Lista2 = Palabra2.ToCharArray(); 

            Array.Sort(Lista1); //Ordenamos alfabeticamente
            Array.Sort(Lista2);

            Palabra1 = string.Join(",", Lista1);   
            Palabra2 = string.Join(",", Lista2);

            son = Palabra1 == Palabra2; 
        }
        if(son)
        { 
            Console.WriteLine("Las palabras son Anagramas"); 
        }
        else 
        {
            Console.WriteLine("No son anagramas"); 
        }
        Console.ReadKey();
    }
}