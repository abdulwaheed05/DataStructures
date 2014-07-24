using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemsAlgorithms
{
    public class Utilities
    {

        public static int[] RandomIntegerGenerator(int numberToGenerate)
        {
            Random rand = new Random();
            List<int> numbers = new List<int>();
            for (var i = 0; i < numberToGenerate; i++)
            {
                numbers.Add(rand.Next());
            }

            return numbers.ToArray();
        }

        public static bool IsArraySorted(int[] array)
        {
            for (int i = 0; i < array.Length - 2; i++)
            {
                if (array[i] > array[array[i + 1]])
                {
                    return false;
                }
            }

            return true;
        }

        public static uint[] RandomPhoneNumberGenerator(int howMany)
        {
            Random rand = new Random();
            List<uint> phoneNumbers = new List<uint>();
            for (int i = 0; i < howMany; i++)
            {
                StringBuilder builder = new StringBuilder(10);
                for (int j = 0; j < 10; j++)
                {
                    int digit;
                    if (j == 0)
                    {
                        digit = rand.Next(2, 4);
                    }
                    else
                    {
                        digit = rand.Next(0, 10);
                    }

                    builder.Append(digit);
                }

                phoneNumbers.Add(Convert.ToUInt32(builder.ToString()));
            }

            return phoneNumbers.ToArray();
        }
    }
}
