using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona P1 = new Persona("ivan",21);
            Persona P2 = new Persona("CR7",20);
            Persona P3 = new Persona("Ironman",19);
            Persona P4 = new Persona("Messi",18);
            Persona P5 = new Persona("Hulk",17);
            Persona P6 = new Persona("Blackpanter",16);
            Persona P7 = new Persona("Naruto",15);
            Persona P8 = new Persona("sasuke",14);
        
            Node<Persona> np1 = new Node<Persona>(P1);
            Node<Persona> np2 = new Node<Persona>(P2);
            Node<Persona> np3 = new Node<Persona>(P3);
            Node<Persona> np4 = new Node<Persona>(P4);
            Node<Persona> np5 = new Node<Persona>(P5);
            Node<Persona> np6 = new Node<Persona>(P6);
            Node<Persona> np7 = new Node<Persona>(P7);
            Node<Persona> np8 = new Node<Persona>(P8);

            np1.AddChildren(np2);
            np1.AddChildren(np3);
            np2.AddChildren(np4);
            np2.AddChildren(np5);
            np3.AddChildren(np6);
            np3.AddChildren(np7);
            np4.AddChildren(np8);
        //------------------Parte 3------------------------------------------------------------------------------
           SumaEdades sum = new SumaEdades();
           sum.Visit(np1);
           Console.WriteLine($"La suma de las edades es: {sum.sumaedad}");
        //------------------Parte 4A------------------------------------------------------------------------------
           EdadMayor sum1 = new EdadMayor();
           sum1.Visit(np1);
           Console.WriteLine($"El mas viejo es {sum1.mayor} con una edad de {sum1.Edad}");
        //------------------Parte 4B--------------------------------------------------------------------------------
            NombreLargo sum2 = new NombreLargo();
            sum2.Visit(np1);
            Console.WriteLine($"El nombre mas largo es {sum2.mayor1} Con un total de {sum2.mayor1.Length} caracteres");
        
        
        
        }
    }
}
