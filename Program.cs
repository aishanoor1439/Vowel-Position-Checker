using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vowel_Position_Checker
{
    internal class Program
    {
        static char[] InputArray(int size)
        {
            char[] array = new char[size];
            Console.WriteLine("Enter characters into the array:");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Character {i + 1}: ");
                array[i] = Convert.ToChar(Console.ReadLine());
            }
            return array;
        }

        static void CheckVowelsAtOddPositions(char[] array)
        {
            Console.WriteLine("Checking vowels at odd positions:");
            for (int i = 0; i < array.Length; i++)
            {
                if ((i + 1) % 2 != 0)
                {
                    char ch = char.ToLower(array[i]);
                    if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
                    {
                        Console.WriteLine($"Character '{array[i]}' at position {i + 1} is a vowel.");
                    }
                }
            }
        }
            static void Main(string[] args)
        {
            Console.Write("Enter the size of the array: ");
            int size = Convert.ToInt32(Console.ReadLine());

            char[] userArray = InputArray(size);
            CheckVowelsAtOddPositions(userArray);
        }
    }
}
