using System;

namespace ExpStmt
{
    class Continue: IRunnable
    {
        public void Run()
        {
            int[] a = new int[3] {2,4,6};
            foreach (int i in a) {
                if (2 == i) continue;
                Console.WriteLine($"{i}");
            }
        }
    }
}
