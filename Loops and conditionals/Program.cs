double term;
double sum = 0;
for (int k = 0; k < 5; k++)
{
    term=1.0/(2*k+1);
    if (k % 2 == 0)
    {
        Console.Write($"{term} ");
        sum = sum + term;
    }
    else
    {
        term = term * -1;
        Console.Write($"{term} ");
        sum = sum + term;
    } 
}
Console.WriteLine();
Console.WriteLine($"Sum of series:{sum}");

