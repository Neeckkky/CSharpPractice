// See https://aka.ms/new-console-template for more information 

Console.WriteLine("Добро пожаловать в игру 'Rock Paper Scissors'! Вам следует выбрать один из 3 вариантов, где 0 - ROCK, 1 - PAPER, 2 - SCISSORS. Удачи!");

while (true)
{
    Random rnd = new Random();
    int RndRPS = rnd.Next(3);
    PlayerChoice ComputerChoice = (PlayerChoice)Enum.GetValues(typeof(PlayerChoice)).GetValue(RndRPS);

    




    Console.Write("Введите число: ");
    PlayerChoice userChoice = (PlayerChoice)int.Parse(Console.ReadLine());
    Console.WriteLine("Пользователь ввел: " + userChoice);
    Console.WriteLine("Компьютер ввел: " + ComputerChoice);


    if (userChoice == PlayerChoice.ROCK && ComputerChoice == PlayerChoice.PAPER)
    {
        Console.WriteLine("Победил компьютер!");
    }

    else if (userChoice == PlayerChoice.ROCK && ComputerChoice == PlayerChoice.SCISSORS)
    {
        Console.WriteLine("Победил игрок!");
    }


    else if (userChoice == PlayerChoice.PAPER && ComputerChoice == PlayerChoice.ROCK)
    {
        Console.WriteLine("Победил игрок!");
    }

    else if (userChoice == PlayerChoice.PAPER && ComputerChoice == PlayerChoice.SCISSORS)
    {
        Console.WriteLine("Победил компьютер!");
    }

    else if (userChoice == PlayerChoice.SCISSORS && ComputerChoice == PlayerChoice.ROCK)
    {
        Console.WriteLine("Победил компьютер!");
    }

    else if (userChoice == PlayerChoice.SCISSORS && ComputerChoice == PlayerChoice.PAPER)
    {
        Console.WriteLine("Победил игрок!");
    }

    else if (userChoice == PlayerChoice.ROCK && ComputerChoice == PlayerChoice.ROCK)
    {
        Console.WriteLine("Ничья!");
    }

    else if (userChoice == PlayerChoice.PAPER && ComputerChoice == PlayerChoice.PAPER)
    {
        Console.WriteLine("Ничья!");
    }

    else if (userChoice == PlayerChoice.SCISSORS && ComputerChoice == PlayerChoice.SCISSORS)
    {
        Console.WriteLine("Ничья!");
    }
}


enum PlayerChoice
{ ROCK, PAPER, SCISSORS }






