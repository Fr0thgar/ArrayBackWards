using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayBackWards
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = new int[20];
            for (int i = number.Length; i > 0; i--)
            {
                Console.WriteLine(i);
            }

            string value =
                "Never gonna give you up, Never gonna let you down, Never gonna run around and desert you, Never gonna make you cry, Never gonna say goodbye, Never gonna tell a lie and hurt you";
            
            char[] array = value.ToCharArray();

            for (int i = array.Length-1; i >= 0; i--)
            {
                char letter = array[i];
                Console.Write("Letter: ");
                Console.WriteLine(letter);
            }
        }
    }
}
