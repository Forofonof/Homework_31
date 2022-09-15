using System;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        int[] arrayNumbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        Console.WriteLine("Исходный массив: ");

        foreach (int numbers in arrayNumbers)
        {
            Console.Write($"{numbers} ");
        }

        Shuffle(arrayNumbers);

        Console.WriteLine("\nМассив после перемешивания: ");

        foreach (int numbers in arrayNumbers)
        {
            Console.Write($"{numbers} ");
        }
    }
    static int[] Shuffle(int[] arrayNumbers)
    {
        int lastIndex = arrayNumbers.Count()-1;

        while (lastIndex > 0)
        {
            int tempValue = arrayNumbers[lastIndex];
            int randomIndex = new Random().Next(0, lastIndex);

            arrayNumbers[lastIndex] = arrayNumbers[randomIndex];
            arrayNumbers[randomIndex] = tempValue;
            lastIndex--;
        }
        return arrayNumbers;
    }
}