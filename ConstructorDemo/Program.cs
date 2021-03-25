using System;

namespace ConstructorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Notacion como la de java
            //Numbers myNumbersObject = new Numbers();

            var myNumbersObject = new Numbers();

            Console.WriteLine("¿Cuantos numeros tengo? :" + myNumbersObject.Count);

            Console.WriteLine("¿Cual es el primer elemento? : " + myNumbersObject.MyNumbers[0]);

        }
    }
}
