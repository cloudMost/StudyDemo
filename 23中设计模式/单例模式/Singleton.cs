using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23种设计模式
{
    public class Singleton
    {
        private static Singleton uniqueInstance;
        private static readonly object locker = new object();

        private Singleton()
        { }
        public static Singleton GetInstance()
        {
            if (uniqueInstance==null)
            {
                lock (locker)
                {
                    uniqueInstance = new Singleton();
                }
            }
            return uniqueInstance;
        }
        public void test(string str)
        {
            Console.WriteLine(str);
        }
    }
}
