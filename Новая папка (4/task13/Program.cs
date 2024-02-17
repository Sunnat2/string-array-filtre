using System;

class Program
{
    static void Main()
    {
        // Исходный массив строк
        string[] inputArray = { "Hello", "2", "world", ":-)" };

        // Создание нового массива с помощью метода FilterArray
        string[] resultArray = FilterArray(inputArray);

        // Вывод результата
        Console.WriteLine("Новый массив:");
        foreach (string str in resultArray)
        {
            Console.WriteLine(str);
        }
    }

    static string[] FilterArray(string[] array)
    {
        // Подсчет количества строк с длиной не более 3 символов
        int count = 0;
        foreach (string str in array)
        {
            if (str.Length <= 3)
            {
                count++;
            }
        }

        // Создание нового массива с соответствующим размером
        string[] newArray = new string[count];
        int index = 0;
        // Заполнение нового массива
        foreach (string str in array)
        {
            if (str.Length <= 3)
            {
                newArray[index++] = str;
            }
        }
        return newArray;
    }
}
