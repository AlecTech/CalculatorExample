using System;

namespace Assignement2
{
    class Program
    {
        static void Main(string[] args)
        {
            
           int numYear = DateTime.Now.Year;
            //int year = Int32.Parse(numYear);

            Console.WriteLine("Type your Age");
            string age = Console.ReadLine();
            int numAge = Int32.Parse(age);
           
           int birthYear = numYear - numAge;

            Console.WriteLine("Your BirthDay is " + birthYear);

           // Console.WriteLine("Type your name in lower case");
            //string name = Console.ReadLine();
            //string upperCase = name.ToUpper();
           // Console.WriteLine(name);
           // Console.WriteLine(upperCase);
        }
    }
}
