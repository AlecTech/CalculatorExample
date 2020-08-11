using System;

namespace Assignement2
{
    class Program
    {
        static void Main(string[] args)
        {
            int result;
            int leftOperand, rightOperand;
            Console.WriteLine("Please enter the left operand");
            leftOperand = int.Parse(Console.ReadLine());

             Console.WriteLine("Please enter the right operand");
            rightOperand = int.Parse(Console.ReadLine());

            result = leftOperand * rightOperand;

            Console.WriteLine("total" + result);
            

           //int numYear = DateTime.Now.Year;
            //int year = Int32.Parse(numYear);

            //Console.WriteLine("Type your Age");
           // string age = Console.ReadLine();
           // int numAge = Int32.Parse(age);
           
          // int birthYear = numYear - numAge;

           // Console.WriteLine("Your BirthDay is " + birthYear);

           // Console.WriteLine("Type your name in lower case");
            //string name = Console.ReadLine();
            //string upperCase = name.ToUpper();
           // Console.WriteLine(name);
           // Console.WriteLine(upperCase);
        }
    }
}
