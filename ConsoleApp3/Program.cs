using System;
using System.Collections.Generic;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            IDictionary<string, string[]> pairs = new Dictionary<string, string[]>();
            pairs.Add("Lucas", new string[] { "am", "bibble", "loo", "malarkey"});
            pairs.Add("Clara", new string[] { "xertz", "gardyloo", "catty", "fuzzle" });
            pairs.Add("Klaus", new string[] { "bumfuzzle", "wabbit", "loo", "wampus" });

            var result = ScoredMulti(pairs);
            foreach (var item in result)
            {
                Console.WriteLine("{0}: {1}", item.Key, item.Value);
            }

            Console.ReadKey();
        }

        static int Scored(string word)
        {
            int point = 0;

            switch (word.Length)
            {
                case 0:
                case 1:
                case 2:
                    point = 0;
                    break;
                case 3:
                case 4:
                    point += 1;
                    break;
                case 5:
                    point += 2;
                    break;
                case 6:
                    point += 3;
                    break;
                case 7:
                    point += 5;
                    break;
                
                default:
                    point += 11;
                    break;
            }

            return point;
        }

        static IDictionary<string, int> ScoredMulti(IDictionary<string, string[]> pairs)
        {
            IDictionary<string, int> result = new Dictionary<string, int>();

            foreach (var item in pairs)
            {
                int point = 0;
                foreach (var s in item.Value)
                {
                    point += Scored(s);
                }

                result.Add(new KeyValuePair<string, int>(item.Key, point));
            }

            return result;
        }
    }
}
