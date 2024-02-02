//Basic syntax, con statements and loops - exercise, Task 007
//27.01.2024, 15:01

double money = 0.0;

while (true)
{
    string cmd = Console.ReadLine().ToLower();

    if(cmd == "start")
    {
        break;
    }

    double coin = double.Parse(cmd);

    if(coin == 0.1 || coin == 0.2 || coin == 0.5 || coin == 1 || coin == 2)
    {
        money += coin;        
    }
    else
    {
        Console.WriteLine($"Cannot accept {coin}");
    }
}

while(true)
{
    string cmd = Console.ReadLine().ToLower();

    if(cmd == "end")
    {
        Console.WriteLine($"Change: {money:F2}");
        break;
    }

    if(cmd == "nuts")
    {
        if(money >= 2.0)
        {
            Console.WriteLine($"Purchased {cmd}");
            money -= 2.0;
        }
        else
        {
            Console.WriteLine("Sorry. not enough money");
        }
    }
    else if(cmd == "water")
    {
        if (money >= 0.7)
        {
            Console.WriteLine($"Purchased {cmd}");
            money -= 0.7;
        }
        else
        {
            Console.WriteLine("Sorry. not enough money");
        }
    }
    else if(cmd == "crisps")
    {
        if (money >= 1.5)
        {
            Console.WriteLine($"Purchased {cmd}");
            money -= 1.5;
        }
        else
        {
            Console.WriteLine("Sorry. not enough money");
        }
    }
    else if(cmd == "soda")
    {
        if (money >= 0.8)
        {
            Console.WriteLine($"Purchased {cmd}");
            money -= 0.8;
        }
        else
        {
            Console.WriteLine("Sorry. not enough money");
        }
    }
    else if(cmd == "coke")
    {
        if (money >= 1.0)
        {
            Console.WriteLine($"Purchased {cmd}");
            money -= 1.0;
        }
        else
        {
            Console.WriteLine("Sorry. not enough money");
        }
    }
    else
    {
        Console.WriteLine("Invalid product");
    }
}