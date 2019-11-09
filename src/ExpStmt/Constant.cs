using System;

namespace ExpStmt
{
    class Constant : IRunnable
    {
        public void Run()
        {
            const int i = 1;
//            const int a; // エラー（error CS0145: const フィールドに値を指定する必要があります。）
//            i = 2; // エラー（error CS0131: 代入式の左辺には変数、プロパティ、またはインデクサーを指定してください。）
        }
    }
}
