using System;

using SingleLinkedList.models;

namespace SingleLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            // Klasse Person testen 
            
            Person p = new Person("Marcel", "Penz", new DateTime(2000, 4, 24));
            Person p2 = new Person("Christian", "Bling", new DateTime(2000, 4, 24));
            Person p3 = new Person("Fabo", "Eggitsch", new DateTime(2000, 4, 24));
            Person p4 = new Person("Thomas", "Schmairo", new DateTime(2000, 4, 24));

                                                      
            SingleLinkedList<Person> sll = new SingleLinkedList<Person>();

            sll.Add(p);
            sll.Add(p2);
            sll.Add(p3);
            sll.Add(p4);


            sll.Change(p, new Person("Alex", "Fax", new DateTime(2000, 4, 24)));
            Console.WriteLine(sll);



            /*

            if (sll.Remove(null))
            {
                Console.WriteLine("Person wurde entfernt");
            }
            else
            {
                Console.WriteLine("Person wurde nicht entfernt - Parameter = null");
            }

            if (sll.Remove(p))
            {
                Console.WriteLine("Person wurde entfernt");
            }
            else
            {
                Console.WriteLine("Person wurde nicht entfernt - Liste ist leer");
            }

            sll.Add(p);
            sll.Add(p2);
            sll.Add(p3);
            sll.Add(p4);
            // 1.Fall
            if (sll.Remove(p3))
            {
                Console.WriteLine("Person wurde entfernt - letzter Eintrag wurde entfernt");
            }
            else
            {
                Console.WriteLine("Person wurde nicht entfernt - letzter Eintrag ");
            }


            Console.WriteLine(sll);


            bool isStartItem;
            SingleLinkedListItem<Person> personBefore = sll.FindItemBeforeItemToFind(p, out isStartItem);
            if (isStartItem)
            {
                Console.WriteLine("Es existiert kein Eintrag vor dem gesuchten Eintrag");
                Console.WriteLine("Die gesuchte Person ist im Starteintrag enthalten");
            }
            else if(personBefore != null)
            {
                Console.WriteLine("Item vor gesuchter Person existiert");
                Console.WriteLine("Person vor gesuchter Person lautet: ");
                Console.WriteLine(personBefore);
            }
            else
            {
                Console.WriteLine("gesuchte Person ist in dieser Liste nicht enthalten");
            }



            SingleLinkedListItem<Person> foundPerson = new SingleLinkedListItem<Person>();

            foundPerson = sll.Find(p);
            if(foundPerson == null)
            {
                Console.WriteLine("Nicht gefunden");
            }
            else
            {
                Console.WriteLine(foundPerson);
            }


            //Console.WriteLine(p);
            /*  Person p2 = new Person("Marcel", "Penz", new DateTime(2000, 4, 24));
              Person p3 = new Person("Tobias", "Flöckinger", new DateTime(2000, 4, 24));

              if (p == p2)
              {
                  Console.WriteLine("p und p2 sind gleich: == ");
              }
              else
              {
                  Console.WriteLine("p und p2 sind nicht gleich: == ");
              }

               if(p.Equals(p2))
              {
                  Console.WriteLine("p und p2 sind gleich: Equals()");
              }
              else
              {
                  Console.WriteLine("p und p2 sind nicht gleich: Equals()");
              }

              if(p == p3)
              {
                  Console.WriteLine("p und p3 sind gleich: ==");
              }
              else
              {
                  Console.WriteLine("p und p3 sind nicht gleich: ==");
              }

              if (p.Equals(p3))
              {
                  Console.WriteLine("p und p3 sind gleich: Equals()");
              }
              else
              {
                  Console.WriteLine("p und p3 sind nicht gleich: Equals()");
              }

              Console.ReadKey();
              */

            /*

            // Klasse SingleLinkedListItem testen
            // generische Klasse verwenden
            SingleLinkedListItem<Person> item = new SingleLinkedListItem<Person>(p, null);
            // Console.WriteLine(item);


            // Klasse SLL testen
            // Methode Add() testen
            SingleLinkedList<Person> singleLL = new SingleLinkedList<Person>();
            if (singleLL.Add(p))
            {
                Console.WriteLine("Person wurde hinzugefügt");
            }
            else
            {
                Console.WriteLine("Person konnte nicht hinzugefügt werden");
            }

            

            if (singleLL.Add(new Person("Tobias", "Flöckinger", new DateTime(1121,8,12))))
            {
                Console.WriteLine("Person wurde hinzugefügt");
            }
            else
            {
                Console.WriteLine("Person konnte nicht hinzugefügt werden");
            }


           /* string nachname;

            Console.WriteLine("Geben Sie ihren Namen ein");
            nachname = Console.ReadLine();

            singleLL.AddAfter(new Person("Marcel", "Penz", new DateTime(2002,1,25)), ));




            Console.WriteLine("komplette SLL ausgeben");
            Console.WriteLine(singleLL);
            */
            Console.ReadKey();
        }
    }
}
