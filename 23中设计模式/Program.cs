using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23种设计模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton s = Singleton.GetInstance();
            s.test("111");
            Singleton s1 = Singleton.GetInstance();
            s1.test("222");
            Console.WriteLine(s.Equals(s1));
            Console.ReadKey();
        }
    }
}
