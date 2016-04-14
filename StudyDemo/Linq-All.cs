using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using System.Text;
using System.Threading.Tasks;

namespace StudyDemo
{
    /// <summary>
    /// 这个方法确定是否所有元素序列都满足某种条件，如果每一个元素都可以满足设定的特殊条件或者它是空，则方法返回true，否则返回false
    /// </summary>
    class Linq_All
    {
        //static void Main(string[] args)
        //{
        //    List<Student> students = new List<Student>()
        //    {
        //        new Student() { Id=1,Name="xxx"}
        //        //new Student() { Id=2,Name="zzz" },
        //        //new Student() { Id=2,Name="ccc" },
        //        //new Student() { Id=2,Name="vvv" },
        //        //new Student() { Id=2,Name="bbb" },
        //        //new Student() { Id=2,Name="nnn" }
        //    };
        //    /*
        //    [__DynamicallyInvokable]
        //    public static bool All<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
        //    {
        //        if (source == null)
        //        {
        //            throw Error.ArgumentNull("source");
        //        }
        //        if (predicate == null)
        //        {
        //            throw Error.ArgumentNull("predicate");
        //        }
        //        foreach (TSource local in source)
        //        {
        //            if (!predicate(local))
        //            {
        //                return false;
        //            }
        //        }
        //        return true;
        //    }           
        //    */
        //    var result = (from item in students
        //                  select item).All(s=>s.Name=="xxx");
        //    bool stuss = students.All(s => s.Name == "xxx");
        //    string json = JsonConvert.SerializeObject(stuss);
        //    Console.WriteLine(json);
        //    Console.ReadKey();

        //}
    }
}
