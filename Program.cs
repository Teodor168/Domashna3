
using System.Collections;
namespace Domashna3
{
    internal class Program
    {
        static ArrayList names = new ArrayList() { "Ivan", "Mariq", "Teodor" };
        static ArrayList ages = new ArrayList() { 15, 17, 16 };
        static ArrayList grades = new ArrayList() { 5.55 , 5.80, 6.00 };

        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Izberi deistvie: ");
                Console.WriteLine();
                Console.WriteLine("dobavqne na uchenik: 1 ");

                Console.WriteLine("iztrivane po ime: 2 ");

                Console.WriteLine("nai mladiq uchenik: 3 ");

                Console.WriteLine("izhod: 4" );
                Console.WriteLine();
                Console.Write("tvoq izbor: ");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    AddStudent();
                }
                else if (choice == "2")
                {
                    DeleteStudent();
                }
                else if (choice == "3")
                {
                    YoungestStudent();
                }
                else if (choice == "4")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("NEVALIDEN IZBOR");
                    Console.WriteLine();
                }
            }
        }

        static void AddStudent()
        {
            Console.Write("ime: ");
            names.Add(Console.ReadLine());

            Console.Write("godini: ");
            ages.Add(int.Parse(Console.ReadLine()));

            Console.Write("uspeh: ");
            grades.Add(double.Parse(Console.ReadLine()));
            Console.WriteLine();
        }

        static void DeleteStudent()
        {
            Console.Write("ime za iztrivane: ");
            string name = Console.ReadLine();

            if (names.Contains(name))
            {
                int index = names.IndexOf(name);
                names.RemoveAt(index);
                ages.RemoveAt(index);
                grades.RemoveAt(index);
            }
            else
            {
                Console.WriteLine($"nqma uchenik s ime {name}");
            }
            Console.WriteLine();
        }

        static void YoungestStudent()
        {
            int minIndex = 0;
            for (int i = 1; i < ages.Count; i++)
            {
                if ((int)ages[i] < (int)ages[minIndex])
                {
                 minIndex = i;
                }         
            }

            Console.WriteLine($"nai mlad e {names[minIndex]} i e na {ages[minIndex]} godini");
            Console.WriteLine();
        }
    }
}