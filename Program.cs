
    {
        Console.Write("Введите первое число ");
        double a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите второе число ");
        double b = Convert.ToInt32(Console.ReadLine());
        if (a > b)
        {
            Console.WriteLine($"min = {b}, max = {a}");
        }
        else
        {
            Console.WriteLine($"min = {a}, max = {b}");
        }
    }