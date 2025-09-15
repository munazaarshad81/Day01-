Console.WriteLine("For how numbers you want Fibonacci sequence for: ");
int n = int.Parse(Console.ReadLine());

int first = 0, second = 1, next;
Console.Write("Fibonacci Sequence: ");

for (int i = 0; i < n; i++)
{
    if (n<=1)
        next = i;
    else
    {
        next= first +second;
        first = second;
        second = next;
    }
    Console.Write(next  + " ");
}

