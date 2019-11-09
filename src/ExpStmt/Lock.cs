using System;

namespace ExpStmt
{
    class Lock: IRunnable
    {
        private int value;
        private readonly object sync = new object();
        /*
        public Lock() {
            value = 0;
            sync = new object();
        }
        */
        public void Run()
        {
            lock (sync) 
            {
                value++;
            }
        }
    }
}
