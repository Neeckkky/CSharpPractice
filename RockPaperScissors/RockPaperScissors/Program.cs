// See https://aka.ms/new-console-template for more information 
Random rnd = new Random();
int RndRPS = rnd.Next(3);
Console.WriteLine("Добро пожаловать в игру 'Rock Paper Scissors'! Вам следует выбрать один из 3 вариантов, где 0 - ROCK, 1 - PAPER, 2 - SCISSORS. Удачи!");

while (true)
{
    PlayerChoice ComputerChoice = (PlayerChoice)Enum.GetValues(typeof(PlayerChoice)).GetValue(RndRPS);

   


    Console.Write("Введите число: ");
    int userChoice = (int.Parse(Console.ReadLine()));
    Console.WriteLine("Пользователь ввел: " + userChoice);
    Console.WriteLine("Компьютер ввел: " + (int)ComputerChoice);


    if ((int)userChoice == (int)PlayerChoice.ROCK && (int)ComputerChoice == (int)PlayerChoice.PAPER)
    {
        Console.WriteLine("Победил компьютер!");
    }

    else if (userChoice == (int)PlayerChoice.ROCK && (int)ComputerChoice == (int)PlayerChoice.SCISSORS)
    {
        Console.WriteLine("Победил игрок!");
    }


    else if (userChoice == (int)PlayerChoice.PAPER && (int)ComputerChoice == (int)PlayerChoice.ROCK)
    {
        Console.WriteLine("Победил игрок!");
    }

    else if (userChoice == (int)PlayerChoice.PAPER && (int)ComputerChoice == (int)PlayerChoice.SCISSORS)
    {
        Console.WriteLine("Победил компьютер!");
    }

    else if (userChoice == (int)PlayerChoice.SCISSORS && (int)ComputerChoice == (int)PlayerChoice.ROCK)
    {
        Console.WriteLine("Победил компьютер!");
    }

    else if (userChoice == (int)PlayerChoice.SCISSORS && (int)ComputerChoice == (int)PlayerChoice.PAPER)
    {
        Console.WriteLine("Победил игрок!");
    }

    else if (userChoice == (int)PlayerChoice.ROCK && (int)ComputerChoice == (int)PlayerChoice.ROCK)
    {
        Console.WriteLine("Ничья!");
    }

    else if (userChoice == (int)PlayerChoice.PAPER && (int)ComputerChoice == (int)PlayerChoice.PAPER)
    {
        Console.WriteLine("Ничья!");
    }

    else if (userChoice == (int)PlayerChoice.SCISSORS && (int)ComputerChoice == (int)PlayerChoice.SCISSORS)
    {
        Console.WriteLine("Ничья!");
    }
}


enum PlayerChoice
{ ROCK, PAPER, SCISSORS }






