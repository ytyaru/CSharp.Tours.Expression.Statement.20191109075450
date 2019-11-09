using System;

namespace ExpStmt
{
    class For: IRunnable
    {
        public void Run()
        {
            for (int i=0; i<3; i++) {
                Console.WriteLine($"{i}");
            }
        }
    }
}
