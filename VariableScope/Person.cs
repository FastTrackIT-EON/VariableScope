using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableScope
{
    internal class Person
    {
        string name = "john doe";
        int age;

        void SayHello2()
        {
            string name = "other";
            Console.WriteLine("Hello, my name is " + name);
        }

        void SayHello()
        {
            Console.WriteLine("Hello, my name is " + name);
        }

        

        
    }
}
