System.Console.WriteLine();
int x = Convert.ToInt32(Console.ReadLine());
int number = x;
int sumDigit = 0;
System.Console.Write($"Сумма цифр числа {number} равна: ");

while (number > 0)
{
    int digit = number % 10;
    sumDigit = sumDigit + digit;
    number = number / 10;
}
System.Console.WriteLine(sumDigit);
System.Console.WriteLine();
