using System;

class Program
{
    static void Main(string[] args)
    {
        // Исходный массив строк (можно заменить на ввод с клавиатуры, если потребуется)
        string[] inputArray = { "Hello", "2", "world", ":-)" };

        // Подсчитываем количество строк с длиной <= 3
        int count = 0;
        foreach (string s in inputArray)
        {
            if (s.Length <= 3)
            {
                count++;
            }
        }

        // Создаём новый массив с подходящими строками
        string[] resultArray = new string[count];
        int index = 0;
        foreach (string s in inputArray)
        {
            if (s.Length <= 3)
            {
                resultArray[index++] = s;
            }
        }

        // Выводим результат
        Console.WriteLine("Результат:");
        foreach (string s in resultArray)
        {
            Console.Write(s + " ");
        }
        Console.WriteLine();
    }
}
