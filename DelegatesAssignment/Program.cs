using System;
using static DelegatesAssignment.Computer;

namespace DelegatesAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello input number");
            int input = Convert.ToInt32(Console.ReadLine());

            
            if(input > 0)
            {
                var compute = new Computer(input);
                var square = new SquareNumbers();
                var factorial = new FatorialNumbers();
                var ca1 = new ComputeAnswer(square.ComputeValue);
                var ca2 = new ComputeAnswer(factorial.ComputeValue);
                compute.GetAnswer(ca1);
                compute.GetAnswer(ca2);
            }
        }
    }
}
