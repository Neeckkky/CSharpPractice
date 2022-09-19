// See https://aka.ms/new-console-template for more information 

Console.WriteLine("Добро пожаловать в игру 'Rock Paper Scissors'! Вам следует выбрать один из 3 вариантов, где 0 - ROCK, 1 - PAPER, 2 - SCISSORS. Удачи!");

while (true)
{
    Random rnd = new Random();
    int RndRPS = rnd.Next(3);

    PlayerChoice computerChoice = (PlayerChoice)Enum.GetValues(typeof(PlayerChoice)).GetValue(RndRPS);


    Console.Write("Введите число: ");
    PlayerChoice userChoice = (PlayerChoice)int.Parse(Console.ReadLine());
    Console.WriteLine("Пользователь ввел: " + userChoice);
    Console.WriteLine("Компьютер ввел: " + computerChoice);


    bool? CheckPlayerWin (PlayerChoice userChoice, PlayerChoice computerChoice)
    {
        bool? CheckPlayerWin = true & false;

        return CheckPlayerWin;

        if (userChoice == PlayerChoice.ROCK && computerChoice == PlayerChoice.PAPER)
            {
                return false;
            }
            else if (userChoice == PlayerChoice.ROCK && computerChoice == PlayerChoice.SCISSORS)
            {
                return true;
            }
            else if (userChoice == PlayerChoice.PAPER && computerChoice == PlayerChoice.ROCK)
            {
                return true;
            }

            else if (userChoice == PlayerChoice.PAPER && computerChoice == PlayerChoice.SCISSORS)
            {
                return false;
            }

            else if (userChoice == PlayerChoice.SCISSORS && computerChoice == PlayerChoice.ROCK)
            {
                return true;
            }

            else if (userChoice == PlayerChoice.SCISSORS && computerChoice == PlayerChoice.PAPER)
            {
                return true;
            }

            else if (userChoice == computerChoice)
            {
                return null;
            }

            if (CheckPlayerWin.HasValue)
                Console.WriteLine("Победил игрок!");

            else if (CheckPlayerWin.Value)
                Console.WriteLine("Победил компьютер");

            else 
                Console.WriteLine("Ничья!");
            CheckPlayerWin.GetValueOrDefault();
       

       
        
    }
    Console.WriteLine(CheckPlayerWin);

}
    
enum PlayerChoice
{ ROCK, PAPER, SCISSORS }






