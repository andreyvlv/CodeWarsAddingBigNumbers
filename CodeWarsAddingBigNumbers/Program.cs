using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsAddingBigNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Sum("10000000000000000000000000", "111"));
            Console.ReadLine();
        }

        static string Sum(string a, string b)
        {
            string result = "";

            int lengthA = a.Length;
            int lengthB = b.Length;

            int c = (lengthA >= lengthB) ? lengthA : lengthB;
            int s = 0, b1 = 0, bA = 0, bB = 0;

            lengthA--; lengthB--;

            for (int i = 0; i < c; i++)
            {
                if (lengthA >= 0)
                {
                    bA = Int16.Parse(Convert.ToString(a[lengthA]));
                    lengthA--;
                }
                if (lengthB >= 0)
                {
                    bB = Int16.Parse(Convert.ToString(b[lengthB]));
                    lengthB--;
                }
                s = (b1 + bA + bB) % 10;
                b1 = (b1 + bA + bB) / 10;
                result = result.Insert(0, Convert.ToString(s));
                bA = 0; bB = 0;
            }

            if (b1 == 1) result = result.Insert(0, "1");

            if (result[0] == '0')
                result = result.Remove(0, 1);

            return result;
        }

    }
}
