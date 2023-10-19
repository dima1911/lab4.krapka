using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Виберіть операцію:");
            Console.WriteLine("1. Додавання");
            Console.WriteLine("2. Віднімання");
            Console.WriteLine("3. Множення");
            Console.WriteLine("4. Ділення");
            Console.WriteLine("5. Вихід");
            string choice = Console.ReadLine();

            if (choice == "5")
            {
                break;
            }

            if (choice != "1" && choice != "2" && choice != "3" && choice != "4")
            {
                Console.WriteLine("Неправильний вибір операції. Спробуйте ще раз.");
                continue;
            }

            Console.Write("Введіть перше число: ");
            double number1 = double.Parse(Console.ReadLine());

            Console.Write("Введіть друге число: ");
            double number2 = double.Parse(Console.ReadLine());

            double result = 0.0;

            switch (choice)
            {
                case "1":
                    result = number1 + number2;
                    break;
                case "2":
                    result = number1 - number2;
                    break;
                case "3":
                    result = number1 * number2;
                    break;
                case "4":
                    if (number2 == 0)
                    {
                        Console.WriteLine("Помилка: ділення на нуль.");
                        continue;
                    }
                    result = number1 / number2;
                    break;
            }

            Console.WriteLine("Результат: " + result);
        }
    }
}
