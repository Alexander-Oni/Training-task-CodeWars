using System;

public class Digitizer
{
    public static long[] Digitize(long number)
    {
        string numberString = number.ToString(); // Преобразование числа в строку
        int length = numberString.Length; // Длина строки

        // Создание массива для хранения перевернутых элементов
        long[] reversedArray = new long[length];

        // Заполнение массива перевернутыми элементами
        for (int i = 0; i < length; i++)
        {
            reversedArray[i] = long.Parse(numberString[length - i - 1].ToString());
        }

        return reversedArray;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a number:");
        long number = long.Parse(Console.ReadLine());

        long[] reversedArray = Digitizer.Digitize(number);

        Console.WriteLine("Reverse array:");
        foreach (long element in reversedArray)
        {
            Console.Write(element + " ");
        }
    }
}
/*
 Этот код создает программу, которая принимает число от пользователя, переворачивает его и выводит перевернутый массив.

1. Подключается пространство имен System, которое содержит базовые классы и типы данных.

2. Определяется публичный класс ReverseArray.

3. Внутри класса определяется статический метод ReverseArrayElements, который принимает число типа long и возвращает массив чисел типа long.

4. Создается строка numberString, содержащая представление числа в виде строки, с помощью метода ToString().

5. Создается переменная length, которая хранит длину строки numberString, с помощью свойства Length.

6. Создается массив reversedArray для хранения перевернутых элементов. Размер массива равен длине строки numberString.

7. Используется цикл for для заполнения массива reversedArray перевернутыми элементами. Индекс i итерируется от 0 до length - 1.

8. Внутри цикла, каждому элементу массива reversedArray присваивается значение числа, полученное из строки numberString. Число получается путем преобразования символа строки в число типа long с помощью метода Parse() и метода ToString().

9. Метод ReverseArrayElements возвращает массив reversedArray.

10. Определяется публичный класс Program.

11. Внутри класса определяется статический метод Main, который принимает массив строк args и не возвращает значения.

12. Выводится сообщение "Введите число:" с помощью метода WriteLine() из класса Console.

13. Вводится число с помощью метода ReadLine() из класса Console и преобразуется в число типа long с помощью метода Parse().

14. Создается массив reversedArray, который получается вызовом метода ReverseArrayElements из класса ReverseArray с передачей в него введенного числа.

15. Выводится сообщение "Перевернутый массив:" с помощью метода WriteLine() из класса Console.

16. Используется цикл foreach для вывода каждого элемента массива reversedArray с помощью метода Write() из класса Console. Элементы разделяются пробелом.

Таким образом, программа принимает число от пользователя, переворачивает его и выводит перевернутый массив чисел.*/


