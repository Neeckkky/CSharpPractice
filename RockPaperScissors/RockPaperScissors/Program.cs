// See https://aka.ms/new-console-template for more information 
while (true)
{
    Random rnd = new Random();
    int RndRPS = rnd.Next(0, 3);
    RPS ValueRPS = (RPS)(int)Enum.GetValues(typeof(RPS)).GetValue(RndRPS);

    Console.Write("Rock paper or scissorss?: ");
    int intRPS = int.Parse(Console.ReadLine());



    if (intRPS == 0 && (int)ValueRPS == 1)
    {
        Console.WriteLine("Победил игрок!");
    }

    else if (intRPS == 1 && (int)ValueRPS == 0)
    {
        Console.WriteLine("Победил игрок!");
    }

    else if (intRPS == 2 && (int)ValueRPS == 1)
    {
        Console.WriteLine("Победил игрок!");
    }


    else if (intRPS == 2 && ValueRPS == 0)
    {
        Console.WriteLine("Победил компьютер!");
    }


    else if (intRPS == 0 && (int)ValueRPS == 2)
    {
        Console.WriteLine("Победил компьютер!");
    }

    else if (intRPS == 1 && (int)ValueRPS == 2)
    {
        Console.WriteLine("Победил компьютер!");
    }



    else if (intRPS == (int)ValueRPS)
    {
        Console.WriteLine("Ничья");
    }
}



enum RPS : int
{ ROCK, PAPER, SCISSORS }






