using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
     // Ejemplo de HashMap
        Dictionary<string, int> hashMap = new Dictionary<string, int>();

        // Insertar elementos en el HashMap
        hashMap["clave1"] = 1;
        hashMap["clave2"] = 2;
        hashMap["clave3"] = 3;

        // Obtener elementos del HashMap
        Console.WriteLine("Valor asociado a clave1: " + hashMap["clave1"]);
        Console.WriteLine("Valor asociado a clave2: " + hashMap["clave2"]);
        Console.WriteLine("Valor asociado a clave3: " + hashMap["clave3"]);
        Console.WriteLine();

        // Verificar si una clave existe en el HashMap
        if (hashMap.ContainsKey("clave4"))
        {
            Console.WriteLine("Valor asociado a clave4: " + hashMap["clave4"]);
        }
        else
        {
            Console.WriteLine("La clave4 no existe en el HashMap.");
        }
        Console.WriteLine();
    }
}