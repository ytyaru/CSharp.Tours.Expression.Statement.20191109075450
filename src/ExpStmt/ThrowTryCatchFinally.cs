using System;
using System.Collections.Generic;

namespace ExpStmt
{
    class ThrowTryCatchFinally: IRunnable
    {
        public void Run()
        {
            try {
                Console.WriteLine("try");
                throw new Exception();
            } catch (Exception e) {
                Console.WriteLine("catch");
            } finally {
                Console.WriteLine("finally");
            }
        }
    }
}
