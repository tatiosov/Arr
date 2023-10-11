using System;

class Program
{
    static void Main(string[] args)
    {
        // Объявление и определение основной функции программы, Main.
        // Она будет запускаться при старте приложения.

        string[] inputArray = ReadArray();
        // Объявление переменной inputArray и её инициализация результатом вызова функции ReadArray.
        // ReadArray считывает строку с консоли, разбивает её на подстроки и возвращает массив строк.

        string[] filteredArray = FilterArray(inputArray);
        // Объявление переменной filteredArray и её инициализация результатом вызова функции FilterArray.
        // FilterArray фильтрует строки из inputArray, оставляя только те, которые имеют длину не более 3 символов.

        Console.WriteLine("\nРезультат:");
        // Вывод строки "Результат:" на консоль.

        PrintArray(inputArray, filteredArray);
        // Вызов функции PrintArray для вывода двух массивов строк на консоль.
    }

    static string[] ReadArray()
    {
        // Объявление и определение функции ReadArray.

        Console.WriteLine("Введите строки через пробел:");
        // Вывод на консоль приглашения для ввода строк.

        string input = Console.ReadLine() ?? "";
        // Считывание введенной строки с консоли и присвоение её переменной input.
        // Оператор ?? используется для обработки возможного null значения и присваивает пустую строку, если Console.ReadLine() вернул null.

        return input.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
        // Разбиение строки input на подстроки, используя пробелы и запятые в качестве разделителей.
        // StringSplitOptions.RemoveEmptyEntries удаляет пустые строки после разбиения и возвращает массив строк.
    }

    static void PrintArray(string[] arr, string[] arr2)
    {
        // Объявление и определение функции PrintArray, которая принимает два массива строк.

        Console.WriteLine($"[{string.Join(", ", arr)}] -> [{string.Join(", ", arr2)}]");
        // Вывод строкового представления двух массивов строк на консоль.
        // Они объединяются с помощью запятых и выводятся в формате "[arr1] -> [arr2]".
    }

    static string[] FilterArray(string[] arr)
    {
        // Объявление и определение функции FilterArray, которая фильтрует массив строк.

        int filteredLength = CountShortStrings(arr);
        // Вызов функции CountShortStrings для подсчета количества коротких строк (длиной не более 3 символов).

        string[] filteredArray = new string[filteredLength];
        // Создание нового массива строк, который будет содержать отфильтрованные короткие строки.

        int index = 0;
        foreach (string str in arr)
        {
            // Начало цикла, который перебирает строки во входном массиве arr.

            if (str.Length <= 3)
            {
                filteredArray[index] = str;
                // Если текущая строка имеет длину не более 3 символов, она добавляется в filteredArray.

                index++;
                // Увеличение индекса для добавления следующей строки в массив filteredArray.
            }
        }
        return filteredArray;
        // Возврат массива, содержащего только короткие строки.
    }

    static int CountShortStrings(string[] arr)
    {
        // Объявление и определение функции CountShortStrings, которая подсчитывает короткие строки.

        int count = 0;
        // Инициализация переменной count, которая будет содержать количество коротких строк.

        foreach (string str in arr)
        {
            // Начало цикла, который перебирает строки во входном массиве arr.

            if (str.Length <= 3)
            {
                count++;
                // Если текущая строка имеет длину не более 3 символов, увеличивается счетчик count.
            }
        }
        return count;
        // Возврат общего количества коротких строк.
    }
}
