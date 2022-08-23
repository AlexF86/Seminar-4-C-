System.Console.WriteLine();
int x = Convert.ToInt32(Console.ReadLine());
int number = x;
int y = Convert.ToInt32(Console.ReadLine());
int exponent = y;
int count = 1;
int result = number;

while (count < exponent)
{
    result = result * number;
    count++;
}

System.Console.WriteLine($"{number} ^ {exponent} = {result}");
System.Console.WriteLine();
