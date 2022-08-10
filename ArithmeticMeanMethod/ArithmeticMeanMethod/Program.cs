// See https://aka.ms/new-console-template for more information

using AMLib;

double firstValue, secondValue, thirdValue;

Console.Write("Введите первое число: ");

firstValue = double.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");

secondValue = double.Parse(Console.ReadLine());

Console.Write("Введите третье число: ");

thirdValue = double.Parse(Console.ReadLine());

double amResult = AMLib.ArMean.ArithmeticMean(firstValue, secondValue, thirdValue);


Console.WriteLine("Среднее арифметическое данных чисел: " + amResult);

