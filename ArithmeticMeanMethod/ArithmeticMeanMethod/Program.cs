// See https://aka.ms/new-console-template for more information

static double ArithmeticMean(double a, double b, double c)
{
    double AMresult = (a + b + c) / 3;

    return AMresult;
}
double firstValue, secondValue, thirdValue, valueAM;

Console.Write("Введите первое число: ");

firstValue = double.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");

secondValue = double.Parse(Console.ReadLine());

Console.Write("Введите третье число: ");

thirdValue = double.Parse(Console.ReadLine());

valueAM = ArithmeticMean(firstValue, secondValue, thirdValue);

Console.WriteLine("Среднее арифметическое данных чисел: " + valueAM);
