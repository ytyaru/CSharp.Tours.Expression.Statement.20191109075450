using System;
using System.Collections.Generic;

namespace ExpStmt
{
    class Checked: IRunnable
    {
        public void Run()
        {
            int x = int.MaxValue;
            unchecked 
            {
                Console.WriteLine(x + 1);  // Overflow
            }
            checked 
            {
                try {
                    Console.WriteLine(x + 1);  // Exception 
                } catch (OverflowException e) {
                    Console.WriteLine(e.Message);
                }
            }     
        }
    }
}
