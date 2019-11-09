using System;
using System.IO;

namespace ExpStmt
{
    class Using: IRunnable
    {
        public void Run()
        {
            using (TextWriter w = File.CreateText("test.txt")) 
            {
                w.WriteLine("A");
            }
        }
    }
}
