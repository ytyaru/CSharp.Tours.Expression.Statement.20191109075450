using System;
using System.Linq;
using System.Reflection;

namespace ExpStmt
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach(IRunnable runnables in AssemblyUtils.CreateInterfaceInstances<IRunnable>())
            {
                Console.WriteLine($"===== {runnables.GetType().Name} =====");
                runnables.Run();
            }
        }
    }
    class AssemblyUtils
    {
        /*
        // 指定した型を継承した子型を返す。直下の子のみ。子孫以下であっても対象外。
        public static Type[] GetChildren<T>()
        {
            return Assembly.GetExecutingAssembly().GetTypes().Where(c => c.BaseType == typeof(T)).ToArray();
        } // 末端の葉型だけを返すメソッドも欲しい。「どの型からも継承されていないか」をどうやって実装するか
        // 指定した型を継承した子孫型を返す。
        public static Type[] GetInheritanceTypes<T>()
        {
//            return Assembly.GetExecutingAssembly().GetTypes().Where(c => IsInheritance(typeof(T), c)).ToArray();
            return Assembly.GetExecutingAssembly().GetTypes().Where(c => c.IsSubclassOf(typeof(T))).ToArray();
        }
        */
        /*
        private static bool IsInheritance(Type target, Type instance)
        {
            if (target == instance) { return true; }
            else {
                if (null == instance.BaseType) { return false; }
                else { return IsInheritance(target, instance.BaseType); }
            }
        }
        */
        public static Type[] GetInterfaces<T>()
        {
            return Assembly.GetExecutingAssembly().GetTypes().Where(c => c.GetInterfaces().Any(t => t == typeof(T))).ToArray();
        }    
        public static T[] CreateInterfaceInstances<T>() where T : class
        {
            return GetInterfaces<T>().Select(c => Activator.CreateInstance(c) as T).ToArray();
        }
    }
}
