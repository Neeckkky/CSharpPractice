// See https://aka.ms/new-console-template for more information
Numbers one = (Numbers)Enum.Parse(typeof(Numbers), "one");
Numbers two = (Numbers)Enum.Parse(typeof(Numbers), "two");
Numbers three = (Numbers)Enum.Parse(typeof(Numbers), "three");
Numbers four = (Numbers)Enum.Parse(typeof(Numbers), "four");


enum Numbers
{ one = 20, two = 10, three = 30, four = 5 }
Console.Write("{0}\n{1}\n{2}\n{3}\n", one, two, three, four);
Console.WriteLine("Выберите число:");
int mb = Convert.ToInt32(Console.Readline());