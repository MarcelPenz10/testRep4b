using System;

using DoubleLinkedList.models;

namespace DoubleLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {

            Car c = new Car("Audi", "blue", 30.6m);
            Car c2 = new Car("BMW", "green", 80.6m);
            Car c3 = new Car("Fiat", "red", 90.6m);
            Car c4 = new Car("Mercedes", "black", 10.6m);
            Car c5 = new Car("VW", "pink", 55.6m);

            DoubleLinkedList<Car> dll = new DoubleLinkedList<Car>();

            dll.Add(c);
            dll.Add(c2);
            dll.Add(c3);
            dll.Add(c4);
            
            Console.WriteLine(dll);

            dll.AddAfter(c5,c3);
            dll.Remove(c);
            dll.Change(c2, new Car("Golf", "blau", 15.6m));           

            Console.WriteLine(dll);

           /* DoubleLinkedListItem<Car> foundItem;
            foundItem = dll.Find(c4);

            Console.WriteLine(foundItem);
            */

            
            


            Console.ReadKey();
        }
    }
}
