using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите сумму вклада:");
        decimal depositAmount = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Введите количество месяцев:");
        int months = Convert.ToInt32(Console.ReadLine());

        decimal interestRate = 0.07M; // 7% начисления

        for (int i = 0; i < months; i++)
        {
            depositAmount += depositAmount * interestRate;
        }

        Console.WriteLine($"Сумма вклада через {months} месяцев: {depositAmount}");
    }
}
