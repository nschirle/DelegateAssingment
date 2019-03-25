using System;
using System.Collections.Generic;
using System.Text;

namespace DelegatesAssignment
{
    class Computer
    {
        public delegate double ComputeAnswer(int num);
        private int MyProperty { get; set; }

        public Computer(int num)
        {
            MyProperty = num;
        }

        public void GetAnswer(ComputeAnswer comp)
        {
            Console.WriteLine(comp(MyProperty));
        }

    }
}
