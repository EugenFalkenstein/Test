using System;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Hello hello = new Hello();
            Console.WriteLine(hello.Echo("Hello Eugen!!!!!!"));
        }
    }

    public class Hello
    {
        public string Echo(string value)
        {
            return value;
        }
    }
}
