using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkListTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("顺序表测试开始...");
            //SeqList<string> seq = new SeqList<string>(10);
            LinkList<string> seq = new LinkList<string>();

            seq.Append("x");
            seq.InsertBefore("w", 0);
            seq.InsertBefore("v", 0);
            seq.Append("y");
            seq.InsertBefore("z", seq.Count());
            Console.WriteLine(seq.ToString());
            for (int i = 0; i < seq.Count(); i++)
            {
                Console.WriteLine(seq[i]);
            }
            Console.WriteLine(seq.IndexOf("z"));
            Console.WriteLine(seq.RemoveAt(2));
            Console.WriteLine(seq.ToString());
            seq.InsertBefore("x", 2);
            Console.WriteLine(seq.ToString());
            Console.WriteLine(seq.GetItemAt(2));
            seq.Resverse();
            Console.WriteLine(seq.ToString());

            seq.InsertAfter("z_1", 0);
            seq.InsertAfter("y_1", 2);
            //seq.InsertAfter("v_1", seq.Count() - 1);
            Console.WriteLine(seq.ToString());
            Console.ReadKey();
        }
    }
}
