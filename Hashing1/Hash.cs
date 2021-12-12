using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Hashing1
{
    public class Hash
    {
        static void Main(string[] args)
        {
            Hashtable HT = new Hashtable();
            HT.Add(1, "H");
            HT.Add(3, "A");
            HT.Add(4, "S");
            HT.Add(2, "H");
            HT.Add(5, "I");
            foreach (object i in HT.Keys)
                Console.WriteLine(i);
            foreach (object J in HT.Values)
                Console.WriteLine(J);
            foreach (DictionaryEntry di in HT)
                Console.WriteLine("keys={0} values={1}", di.Key, di.Value);
            Console.ReadKey();

        }
    }
}