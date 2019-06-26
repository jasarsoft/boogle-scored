using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
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
    }
}
