using System;

Console.WriteLine("Serie fibonacci de 50 numeros");

int valor = 0;
int aux = 1; 

for (int i = 1; i <= 50; i++)
{
    Console.WriteLine(i + " - " + valor);

    int fib = valor + aux;
    valor = aux; 
    aux = fib;

}

Console.ReadKey();