using System;
using System.Runtime.Intrinsics.X86;

namespace Konstruktorerövning3inl
{
    class Program
    {
        static void Main(string[] args)
        {
            Person jag = new Person("alex", "ved", 2001, 09, 11, 1.46F, 135);
            if (jag.isMyndig())
            {
                Console.WriteLine(jag.getFullnamn() + " är myndig");
            }
            else
            {
                Console.WriteLine(jag.getFullnamn() + " är inte myndig");
            }
            Console.WriteLine("Personens BMI är " + jag.getBMI());
        }
    }
}