char operat;
Console.WriteLine("Enter the operator:");
operat=char.Parse(Console.ReadLine());

double a, b;
Console.WriteLine("Enter the two operands:");
a=double.Parse(Console.ReadLine());
b=double.Parse(Console.ReadLine());

double val;

switch (operat)
{
    case '+': 
        val = a + b;
        Console.WriteLine($"{a}{operat}{b}={val}");
        break;
    case '-':
        val = a - b;
        Console.WriteLine($"{a}{operat}{b}={val}");
        break;
    case '*':
        val = a * b;
        Console.WriteLine($"{a}{operat}{b}={val}");
        break;
    case '/':
        if (b == 0)
        {
            Console.WriteLine("0 cannot be divider.");
        }
        else
        {
            val = a / b;
            Console.WriteLine($"{a}{operat}{b}={val}");
        }
        break;
    default:
        Console.WriteLine("Invalid Input.");
        break;
}