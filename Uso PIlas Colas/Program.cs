using System;
using System.Collections.Generic;

class ColaDecimal //Clase ColaDecimal
{
    private List<decimal> datos;

    public ColaDecimal()
    {
        datos = new List<decimal>();
    }

    public int Cantidad//Devuelve la cantidad de datos
    {
        get { return datos.Count; }
        
    }

    public decimal Encolar(decimal n)//Método Encolar(Enqueue) ingresa datos al final de la lista  
    {
        datos.Add(n);
        return n;
    }

    public decimal Descencolar()//Método Descencolar(Dequeue) al dato lo saca de la lista  
    {
        decimal dato = datos [0];
        datos.RemoveAt(0);
        return dato;
    }
    
}

class Cola //Clase Cola
{
    static void Main(string[] args)
    {
        ColaDecimal cola = new ColaDecimal();
        
        string opcion;
        do
        {//Menú de opciones para el ingreso de los datos
            Console.WriteLine("1.- Añadir un dato");
            Console.WriteLine("2.- Imprimir los datos");
            Console.WriteLine("0.- Ingrese 0 para salir");
            opcion = Console.ReadLine();
            switch (opcion)
            {
                case "1":
                    Console.WriteLine("Ingrese un número: ");
                    cola.Encolar(Convert.ToDecimal(
                        Console.ReadLine()));
                    break;
                case "2":
                    while (cola.Cantidad > 0)
                    {
                        Console.WriteLine(cola.Descencolar);
                    }
                    break;
                default:
                    break;
            }
        }
        while (opcion != "0");

    }
}