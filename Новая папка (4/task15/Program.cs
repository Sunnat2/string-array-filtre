using System;

class Program
{
    static void Main()
    {
        // Ввод массива строк с клавиатуры
        Console.WriteLine("Введите строки массива (чтобы закончить, введите пустую строку):");
        string[] inputArray = ReadInputArray();

        // Создание нового массива с помощью метода FilterArray
        string[] resultArray = FilterArray(inputArray);

        // Вывод результата
        Console.WriteLine("Новый массив:");
        foreach (string str in resultArray)
        {
            Console.WriteLine(str);
        }
    }

    static string[] ReadInputArray()
    {
        // Чтение строк с клавиатуры и добавление их в массив
        string input;
        int count = 0;
        while (!string.IsNullOrWhiteSpace(input = Console.ReadLine()))
        {
            count++;
        }
        string?[] array = new string?[count]; // Изменение типа массива на string?, чтобы допустить null
        count = 0;
        Console.SetCursorPosition(0, Console.CursorTop - array.Length);
        while (!string.IsNullOrWhiteSpace(input = Console.ReadLine()))
        {
            array[count++] = input;
        }
        return Array.ConvertAll(array, x => x ?? ""); // Преобразование null в пустую строку
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