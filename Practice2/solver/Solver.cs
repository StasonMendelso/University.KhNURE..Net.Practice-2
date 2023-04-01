using System.Security.Cryptography;

namespace Practice2;

public class Solver
{
    public void Task1()
    {
        PrintHeaderTask(1);
        Console.WriteLine("Введіть перше ціле число:");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введіть друге ціле число:");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введіть третє ціле число:");
        int c = Convert.ToInt32(Console.ReadLine());
        int[] array = { a, b, c };
        int countPositive = 0, countNegative = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                countPositive++;
            }

            if (array[i] < 0)
            {
                countNegative++;
            }
        }

        Console.WriteLine("Кількість додатніх чисел {0}, кількість від'ємних чисел {1}", countPositive, countNegative);
    }

    public void Task2()
    {
        PrintHeaderTask(2);
        Console.WriteLine("Введіть дійсне число А:");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введіть дійсне число B:");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введіть дійсне число C:");
        double c = Convert.ToDouble(Console.ReadLine());
        if ((a < b && b < c) || (a > b && b > c))
        {
            a *= 2;
            b *= 2;
            c *= 2;
        }
        else
        {
            a *= -1;
            b *= -1;
            c *= -1;
        }

        Console.WriteLine("A = {0}\nB = {1}\nC = {2}", a, b, c);
    }

    public void Task3()
    {
        PrintHeaderTask(3);
        Console.WriteLine("Введіть ціле число N (N>0):");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] array = new int[n];
        int evenNumber = 1;
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = evenNumber;
            evenNumber += 2;
        }

        Console.Write("Массив з додатніми непарними числами: ");
        foreach (int number in array)
        {
            Console.Write("{0} ", number);
        }

        Console.WriteLine();
    }

    public void Task4()
    {
        PrintHeaderTask(4);
        Console.WriteLine("Вихідний масив:");
        int[,] array = new int[5, 5];
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                array[i, j] = RandomNumberGenerator.GetInt32(10);
                Console.Write("{0} ", array[i, j]);
            }

            Console.WriteLine();
        }

        for (int i = 0; i < 5; i += 2)
        {
            Console.WriteLine("Непарний стовпець №{0}", i + 1);
            for (int j = 0; j < 5; j++)
            {
                Console.Write("{0} ", array[j, i]);
            }

            Console.WriteLine();
        }
    }


    public void Task5()
    {
        PrintHeaderTask(5);
        Console.WriteLine("Введіть ціле додатнє число А:");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введіть ціле додатнє число B (B>A):");
        int b = Convert.ToInt32(Console.ReadLine());
        ulong sum = 0;
        for (int i = a; i <= b; i++)
        {
            sum += (ulong)(i * i);
        }

        Console.WriteLine("Сума квадратів всіх цілих чисел від A до B включно {0}", sum);
    }

    public void Task6()
    {
        PrintHeaderTask(6);
        Console.WriteLine("Введіть ціле додатнє число А:");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введіть ціле додатнє число B (B>A):");
        int b = Convert.ToInt32(Console.ReadLine());
        for (int i = a; i <= b; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("{0} ", i);
            }
        }

        Console.WriteLine();
    }

    public void Task7()
    {
        PrintHeaderTask(7);
        Console.WriteLine("Введіть ціле додатнє число N:");
        int n = Convert.ToInt32(Console.ReadLine());
        while (n > 1)
        {
            if (n % 3 != 0)
            {
                Console.WriteLine("FALSE");
                return;
            }

            n /= 3;
        }

        Console.WriteLine("TRUE");
    }

    public void Task8()
    {
        PrintHeaderTask(8);
        Console.WriteLine("Введіть число P:");
        double p = Convert.ToDouble(Console.ReadLine()) / 100.0;
        double distance = 10.0;
        double totalDistance = distance;
        int days = 1;
        while (totalDistance < 200.0)
        {
            distance += distance * p;
            totalDistance += distance;
            days++;
        }

        Console.WriteLine("K = {0}, S = {1}", days, totalDistance);
    }

    public void Task9()
    {
        PrintHeaderTask(9);
        PrintASumOfTwoNumbersEnteredByUser();
    }

    private void PrintASumOfTwoNumbersEnteredByUser()
    {
        Console.WriteLine("Введіть перше число:");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введіть друге число:");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Сума числа {0} та {1} дорівнює {2}", a, b, a + b);
    }

    public void Task10()
    {
        PrintHeaderTask(10);
        Console.WriteLine("Введіть число К для інвертування:");
        int k = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Інвертоване число {0} наступне {1}", k, InvertDigits(k));
    }

    private int InvertDigits(int k)
    {
        int inverted = 0;

        while (k > 0)
        {
            int digit = k % 10;
            inverted = inverted * 10 + digit;
            k /= 10;
        }

        return inverted;
    }

    public void Task11()
    {
        PrintHeaderTask(11);
        Console.WriteLine("Введіть значення сторони трикутника:");
        double a = Convert.ToDouble(Console.ReadLine());

        double p, s;
        TrianglePS(a, out p, out s);
        Console.WriteLine("P = {0}\nS = {1}", p, s);
    }

    private void TrianglePS(double a, out double p, out double s)
    {
        p = 3 * a;
        s = a * a * Math.Sqrt(3) / 4;
    }

    public void Task12()
    {
        PrintHeaderTask(12);
        Console.WriteLine("Введіть число x:");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введіть число y:");
        double y = Convert.ToDouble(Console.ReadLine());

        MinMax(ref x, ref y);
        Console.WriteLine("x = {0}\n y = {1}", x, y);
    }

    private void MinMax(ref double x, ref double y)
    {
        if (x > y)
        {
            (x, y) = (y, x);
        }
    }

    public void Task13()
    {
        PrintHeaderTask(13);
        Console.WriteLine("Сума для масиву від 1 до 4 включно: {0}", Sum(new int[] { 1, 2, 3, 4 }));

        Console.WriteLine("Сума для чисел 1 та 2: {0}", Sum(1, 2));

        Console.WriteLine("Результат методу без передачі параметрів {0}", Sum());
    }

    private int Sum(params int[] numbers)
    {
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        return sum;
    }

    public void Task14()
    {
        PrintHeaderTask(14);
        Console.WriteLine("Введіть число К для знаходження суми цифр:");
        int k = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Сума цифр числа К дорівнює {0}", DigitSum(k));
    }

    private int DigitSum(int k)
    {
        if (k < 10)
        {
            return k;
        }

        return k % 10 + DigitSum(k / 10);
    }

    public void Task15()
    {
        PrintHeaderTask(15);
        Console.WriteLine("Введіть число x:");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введіть число y:");
        double y = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введіть назву операції (Add, Sub, Mul, Div):");
        string name = Console.ReadLine();
        Operation operation = Enum.Parse<Operation>(name);

        Console.WriteLine("Результат операції дорівнює {0}", Calculate(x, y, operation));
    }

    double Calculate(double x, double y, Operation operation)
    {
        switch (operation)
        {
            case Operation.Add:
                return x + y;
            case Operation.Sub:
                return x - y;
            case Operation.Mul:
                return x * y;
            case Operation.Div:
                if (y == 0)
                {
                    throw new ArgumentException("Ділити на нуль не можна.");
                }

                return x / y;
            default:
                throw new ArgumentException("Операцію не знайдено.");
        }
    }

    public void Task16()
    {
        PrintHeaderTask(16);
        Item[] items = new Item[3];

        items[0] = new Item();
        items[0].name = "Item 1";
        items[0].nameOfProducer = "Producer 1";
        items[0].dateOfArrival = "01.04.2023";
        items[0].maxStoragePeriod = "30.04.2025";
        items[0].weight = 20;
        items[0].price = 250;

        items[1] = new Item("Item 2", "02.04.2023", 300, 10000, "Producer 2", "30.04.2026");
        items[2] = new Item("Item 3", "03.04.2023", 30, 400, "Producer 3", "23.07.2023");
        foreach (Item item in items)
        {
            item.DisplayInfo();
            Console.WriteLine();
        }
    }

    public void PrintHeaderTask(int number)
    {
        Console.WriteLine("Task {0}", number);
    }
}