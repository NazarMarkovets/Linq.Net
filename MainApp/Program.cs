using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;
using MainApp.DataManager;
using MainApp.DTO;

namespace MainApp
{
    class Program
    {
        static void Main(string[] args) 
        {
            // LinqManager.LinqSelect();
            // LinqManager.LinqSelectByParameter();
            // LinqManager.LinqTakeWhile();
            // LinqManager.LinqSelectSortedByAgeDesc();
            // LinqManager.LinqSelectLastOrDefault();
            CreatingHashMap();
        }

        public static void CreatingHashMap()
        {
            Dictionary<string, int> dic = new Dictionary<string, int>();
            
            
            var hashtable = new Hashtable();
            hashtable.Add("string", 100);
            var res = hashtable.Keys.Cast<List<string>>();
            Console.WriteLine(res.Select(c=>c));
            Console.WriteLine(hashtable["string"]);

            HashSet<string> set = new();
            set.Add("st1");
            string actualValue = string.Empty;
            
            set.TryGetValue("st1", out actualValue);
            Console.WriteLine(actualValue);
        }

    }
}
