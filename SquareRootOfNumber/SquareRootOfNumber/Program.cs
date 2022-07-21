// See https://aka.ms/new-console-template for more information
Console.Write("Введите число для вычисления квадратного корня: ");
string changingNumber = Console.ReadLine();
double num;

bool correctValue = double.TryParse(changingNumber, out num);

if (correctValue)
{
    double rootResult = Math.Sqrt(num);
    if (num < 0)
    {
        Console.WriteLine("Ошибка: корень отрицального числа вычислить невозможно.");
    }
  else
    {
        Console.WriteLine("Квадратный корень числа " + num + " равен " + rootResult);
    }
}
else
{
    Console.WriteLine("Ошибка: " + changingNumber + " не является числом.");
}


