using System;

namespace ExpStmt
{
    class Return: IRunnable
    {
        public void Run()
        {
            return;
            Console.WriteLine("returned.");
        }
    }
}
