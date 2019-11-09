using System;

namespace ExpStmt
{
    class Switch : IRunnable
    {
        public void Run()
        {
            int i=1;
            switch (i) {
                case 0: Console.WriteLine("case 0"); break;
                case 1: Console.WriteLine("case 1"); break;
                default: Console.WriteLine("default"); break;
            }
        }
    }
}
