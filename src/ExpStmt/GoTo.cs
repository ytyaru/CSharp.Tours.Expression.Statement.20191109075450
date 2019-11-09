using System;

namespace ExpStmt
{
    class GoTo: IRunnable
    {
        public void Run()
        {
            goto label_1;
            Console.WriteLine("skipping.");
            label_1:
            Console.WriteLine("skiped.");
        }
    }
}
