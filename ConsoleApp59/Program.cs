using System;
//Task 5,4
namespace ConsoleApp59
{
    internal class Program
    {
        struct Notebook
        {
            private string model;
            private int price;
            private string creater;
            public Notebook(string creater, string model, int price)
            {
                this.creater = creater;
                this.model = model;
                this.price = price;
            }

            public void show()
            {
                Console.WriteLine("creator - {0}, model - {1}, price - {2}", creater, model, price);
            }
        }
        static void Main(string[] args)
        {
            Notebook notebook = new Notebook("HP", "456", 20000);
            notebook.show();    
        }
    }
}
//task 4
//MSDN: Структуры struct (Руководство по программированию на C#) - описывает использование структур, их типы...
//MSDN: Классы и структуры (Руководство по программированию на C#) - содержит информацию о том что может в себе вмещать классы и структуры, манипуляции и решение которые могут применятся к ним
//

