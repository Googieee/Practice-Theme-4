try
{
    Console.WriteLine("Введите делимое:");
    int dividend = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите делитель:");
    int divisor = Convert.ToInt32(Console.ReadLine());

    int result = dividend / divisor;
    Console.WriteLine($"Результат деления: {result}");
}
catch (DivideByZeroException)
{
    Console.WriteLine("Ошибка: Деление на ноль недопустимо.");
}
catch (FormatException)
{
    Console.WriteLine("Ошибка: Пожалуйста, введите корректное число.");
}
catch (Exception ex)
{
    Console.WriteLine($"Неизвестная ошибка: {ex.Message}");
}
finally
{
    Console.WriteLine("Программа завершила работу. Нажмите любую клавишу для выхода.");
    Console.ReadKey();
}
    