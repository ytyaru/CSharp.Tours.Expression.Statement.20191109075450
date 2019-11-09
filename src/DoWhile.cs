using System;

namespace ExpStmt
{
    class DoWhile: IRunnable
    {
        public void Run()
        {
            int i=1;
            do {
                Console.WriteLine($"{i}");
                i++;
            } while (i < 3);
        }
    }
}
