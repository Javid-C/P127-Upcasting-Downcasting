using System;
using System.Collections.Generic;
using System.Text;

namespace P127_Upcasting_Downcasting
{
    class Teacher:Human
    {
        public string Academy;


        public override void Info()
        {
            Console.WriteLine(Academy);
        }
    }
}
