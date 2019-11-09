using System;

namespace ExpStmt
{
    class Constant : IRunnable
    {
        public void Run()
        {
            const int i = 1;
            const int a; // エラー（代入により初期化せねばならない）
            i = 2; // エラー（定数には初回以外代入不可）
            Console.WriteLine($"i={i} a={a} b={b} c={c} d={d} e={e}");
        }
    }
}
