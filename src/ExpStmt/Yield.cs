using System;
using System.Collections.Generic;

namespace ExpStmt
{
    class Yield: IRunnable
    {
        public void Run()
        {
            foreach(int i in Get()) {
                Console.WriteLine($"{i}");
            }
        }
        public IEnumerable<int> Get()
        {
            yield return 1;
            yield return 2;
            yield break;
            yield return 3;
        }
    }
}
