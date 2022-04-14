using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodpractice
{
    class Cal
    {
        public void Add()
        {
            Console.WriteLine("Enter First Number");
            int a = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter second Number");
            int b = Convert.ToInt32(Console.ReadLine());

            int result = a + b;
            Console.WriteLine("Addition is " + result);


        }
        public void Sub()
        {
            Console.WriteLine("Enter First Number");
            int a = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter second Number");
            int b = Convert.ToInt32(Console.ReadLine());

            int result = a - b;
            Console.WriteLine("Addition is " + result);

        }
        public void Mul()
        {
            Console.WriteLine("Enter First Number");
            int a = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter second Number");
            int b = Convert.ToInt32(Console.ReadLine());

            int result = a * b;
            Console.WriteLine("Addition is " + result);


        }
        public void Div()
        {
            Console.WriteLine("Enter First Number");
            int a = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter second Number");
            int b = Convert.ToInt32(Console.ReadLine());

            int result = a / b;

            Console.WriteLine("Addition is " + result);

        }
    }
}
