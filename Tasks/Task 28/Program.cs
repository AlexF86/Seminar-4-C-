Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine( ));
int factorial = 1;

for (int i = 2; i <= n; i++)
{
     factorial = factorial * i;
}
Console.WriteLine(factorial);

