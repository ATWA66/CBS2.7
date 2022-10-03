using System;
//Task 3 
namespace ConsoleApp58
{
    internal class Program
    {
        static void ClassTaker(MyClass myClass)
        {
            myClass.change = "changed";
        }
        static void StruktTaker(MyStruct myStruct)
        {
            myStruct.change = "changed";
            Console.WriteLine("myStruct.change = {0}", myStruct.change);
        }
        class MyClass
        {
            public string change;
            public MyClass(string change)
            {
                this.change = change;
            }
        }
        struct MyStruct 
        {
            public string change;
            public MyStruct(string change)
            {
                this.change = change;
            }
        }

        static void Main(string[] args)
        {
            MyClass myClass = new MyClass("unchenged");
            MyStruct myStruct = new MyStruct("unchenged");
            ClassTaker(myClass);
            StruktTaker(myStruct);
            Console.WriteLine("myClass.change = {0}, myStruct.change = {1}", myClass.change , myStruct.change);
            // при копировани структуры передается ее отдельная копия
        }
    }
}
