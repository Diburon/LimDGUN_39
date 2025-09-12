class Program
{
    static void Main()
    {
          
        if (!int.TryParse(Console.ReadLine(), out int a))
        {
            Console.WriteLine("Error!");
            return;
        }

        if (!int.TryParse(Console.ReadLine(), out int b))
        {
            Console.WriteLine("Error!");
            return;
        }

        Console.WriteLine("Enter operator (&, |, ^): ");
        string x = Console.ReadLine();

        if (x.Length != 1 || (x[0] != '&' && x[0] != '|' && x[0] != '^'))
        {
            Console.WriteLine("Error!");
            return;
        }

        int result = 0;
        switch (x[0])
        {
            case '&':
                result = a & b;
                break;
            case '|':
                result = a | b;
                break;
            case '^':
                result = a ^ b;
                break;
            default:
                Console.WriteLine("Error!!!");
                break;
        }

        Console.WriteLine(result);
        Console.WriteLine(Convert.ToString(result,2));
        Console.WriteLine(Convert.ToString(result,16));
    }
}