using System;

namespace ExpStmt
{
    class While: IRunnable
    {
        public void Run()
        {
            int i=1;
            while (i < 3) {
                Console.WriteLine($"{i}");
                i++;
            }
        }
    }
}
