void Task01()
{
    System.Console.WriteLine("Введите любое число: ");
    string input = Console.ReadLine();
    if (input != null)
    {
        char[] arr = input.ToCharArray();
        Array.Reverse(arr);
        string output = new string(arr);
        if (input == output)
        {
            System.Console.WriteLine("Это палиндром");
        }
        else
        {
            System.Console.WriteLine("Это не палиндром");
        }
    }
    else
    {
        System.Console.WriteLine("Вы ничего не ввели. Завершение");
    }
}

void Task02()
{
    System.Console.WriteLine("Введите координаты двух точек в трёхмерном пространстве");
    System.Console.WriteLine("Первая точка:");
    System.Console.Write("X: ");
    int x1 = Convert.ToInt32(Console.ReadLine());
    System.Console.Write("Y: ");
    int y1 = Convert.ToInt32(Console.ReadLine());
    System.Console.Write("Z: ");
    int z1 = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine("Вторая точка:");
    System.Console.Write("X: ");
    int x2 = Convert.ToInt32(Console.ReadLine());
    System.Console.Write("Y: ");
    int y2 = Convert.ToInt32(Console.ReadLine());
    System.Console.Write("Z: ");
    int z2 = Convert.ToInt32(Console.ReadLine());

    double result = Math.Round(Math.Sqrt(Math.Pow((x2-x1), 2)+Math.Pow((y2-y1), 2)+Math.Pow((z2-z1), 2)), 2);
    System.Console.WriteLine($"Расстояние между точками: {result}");
}

void Task03()
{
    System.Console.Write("Введите число: ");
    int num = Convert.ToInt32(Console.ReadLine());

    for (int i = 1; i <= num; i++)
    {
        System.Console.Write($"{Math.Pow(i, 3)} ");
    }
}

System.Console.WriteLine("Введите номер задачи, где: \n 1 - определение палиндрома \n 2 - найти расстояние в трёхмерном пространстве \n 3 - куб чисел от 1 до N");
int task = Convert.ToInt32(Console.ReadLine());
switch(task)
{
    case 1:
        Task01();
        break;
    case 2:
        Task02();
        break;
    case 3:
        Task03();
        break;
    default:
        System.Console.WriteLine("Такой задачи нет");
        break;
}