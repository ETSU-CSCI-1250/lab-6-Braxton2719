using System.Security.Cryptography.X509Certificates;

ShowCharacter("New York", 1);
CalculateRetail();
for (int i = 80; i <= 100; i++)
{
    Celsius(i);
    Console.WriteLine($"{i}F = {Celsius(i)}C");
}
Console.Write("Enter a number:");
int n = int.Parse(Console.ReadLine());
bool primeCheck = IsPrime(n);
if (primeCheck == true)
{
    Console.WriteLine($"{n} is a prime number");
}
else
{
    Console.WriteLine($"{n} is not a prime number");
}

static void ShowCharacter(string word, int position)
    {
        char letter = word[position - 1];
        Console.WriteLine($"The word is {word}");
        Console.WriteLine($"The first letter is {letter}");
    }


static void CalculateRetail()
{
    Console.Write("Enter this item's wholesale cost:");
    double ws = Double.Parse(Console.ReadLine());
    Console.Write("Enter this item's markup percentage:");
    double mp = Double.Parse(Console.ReadLine())/100;
    Console.WriteLine($"The item's wholesale cost is {ws} and the markup percentage is {mp}, so the retail price is {(ws * mp) + ws}");
}

static double Celsius(double F)
{
    return (F - 32) * 5 / 9;
}

static bool IsPrime(int n)
{
    if (n == 1)
    {
        return false;
    }
    for (int i = 2; i < n; i++)
    {
        if (n % i == 0)
        {
            return false;
        }
    }
    return true;
}
