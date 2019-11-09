using System;

namespace ExpStmt
{
    class ForEach: IRunnable
    {
        public void Run()
        {
            int[] a = new int[3] {2,4,6};
            foreach (int i in a) {
                Console.WriteLine($"{i}");
            }
        }
    }
}
