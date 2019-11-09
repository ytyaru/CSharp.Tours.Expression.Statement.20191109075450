using System;

namespace ExpStmt
{
    class Code
    {
        public Code() => Console.WriteLine($"===== {this.GetType().Name} =====");
        public virtual void Run() {}
    }
}
