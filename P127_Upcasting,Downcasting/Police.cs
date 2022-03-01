using System;
using System.Collections.Generic;
using System.Text;

namespace P127_Upcasting_Downcasting
{
    class Police:Human
    {
        public string Sheriff;
        public override sealed void Info()
        {
            Console.WriteLine(Sheriff);
        }
    }
}
