Console.WriteLine("*****Калькулятор*****");

while (true)
{
    Console.WriteLine("\nВведите первое число: \n");
    double.TryParse(Console.ReadLine(), out double firstNumber);

    Console.WriteLine("\nВведите операцию: \n+ (сложение) \n- (вычитание)\n* (умножение) \n/ (деление) \n% (процент от числа) \n√ (корень от числа)\n");
    string operation = Console.ReadLine();

    double secondNumber = 0;

    if (operation == "%")
    {
        Console.WriteLine("\nВведите значение процента: ");
        double.TryParse(Console.ReadLine(), out secondNumber);

    }
    else if ("+-/*".Contains(operation))
    {
        Console.WriteLine("\nВведите второе число: ");
        double.TryParse(Console.ReadLine(), out secondNumber);
    }

    try
    {
        double result = operation switch
        {
            "+" => firstNumber + secondNumber,
            "-" => firstNumber - secondNumber,
            "*" => firstNumber * secondNumber,
            "/" => secondNumber != 0 ? firstNumber / secondNumber : throw new DivideByZeroException("Деление на ноль недопустимо"),
            "%" => firstNumber * (secondNumber / 100),
            "√" => firstNumber >= 0 ? Math.Sqrt(firstNumber) : throw new ArgumentException("Квадратный корень не может быть взят из отрицательного числа"),
            _ => throw new InvalidOperationException("Недопустимая операция.")
        };

        Console.WriteLine($"\nРезультат: {result}");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"\nОшибка: {ex.Message}");
    }

    Console.ReadKey();


}

