using System;

class Program
{
    static void Main(string[] args)
    {
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

        // Создаём новый массив нужного размера
        string[] resultArray = new string[count];
        int index = 0;
        foreach (string s in inputArray)
        {
            if (s.Length <= 3)
            {
                resultArray[index] = s;
                index++;
            }
        }
    }
}
