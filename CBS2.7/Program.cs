using System;
// Task 2
namespace CBS2._7
{
    internal class Program
    {
        interface IInfo { 
            void print();
        }

        struct Train : IInfo
        {
            public string destination { get; set; } 
            public sbyte Number { get; set; }
            public string time { get; set; }
             public void print()
            {
                Console.WriteLine("destination - " + destination + " time " + time);
            }

        }

        static void Main(string[] args)
        {
            Train[] train = new Train[8];
            for (sbyte i = 0; i < train.Length; i++)
            {
                train[i].Number = (sbyte)((sbyte)1+i);
                Console.WriteLine("enter the destination of train {0}", i + 1);
                train[i].destination = Console.ReadLine();
                Console.WriteLine("enter the departure time of train {0}", i + 1);
                train[i].time = Console.ReadLine();
            }
            Console.WriteLine("///////////////////////////////");
            Console.WriteLine("Enter the number of train:");
            try
            {
                train[Convert.ToInt32(Console.ReadLine())-1].print();
            }
            catch
            {
                Console.WriteLine("An error has occured");
            }
        }
    }
}
