// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// int raised( int a, int b)
// {
//     int result = 1;
//     for(int i = 1; i <= b; i++)
//     {
//         result *= a;
//     }
//     return result;
// }

// Console.WriteLine("Input number A: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number B: ");
// int b = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine();
// Console.WriteLine($"The number A raised to the power of B is: {raised(a, b)}");



// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

// int sumDigitNum(int num)
// {
//     int count = 0;
//     int sum = 0;
//     while(num > 0)
//     {
//         sum = sum + num % 10;
//         num /= 10;
//         count++;
//     }
//     return sum;
// }

// Console.WriteLine("Input number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"The sum of digit num is: {sumDigitNum(num)}");



// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// int Prompt(string message)
// {
//     Console.WriteLine(message);
//     string readInput = Console.ReadLine();
//     int result = int.Parse(readInput);
//     return result;
// }

// int[] createArray(int size, int minValue, int maxValue)
// {
//     int[] newArray = new int[size];
//     for(int i = 0; i < size; i++)
//     {
//         newArray[i] = new Random().Next(minValue, maxValue);
//     }
//     return newArray;
// }

// void printArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// int size = Prompt("Input size array: ");
// int minValue = Prompt("Input minimal value: ");
// int maxValue = Prompt("input maximal value: ");
// int[] myArray = createArray(size, minValue, maxValue);

// printArray(myArray);
// 

