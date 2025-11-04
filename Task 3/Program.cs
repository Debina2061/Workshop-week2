using System.Diagnostics;

class Program
{
    static void Main()
    {
        byte b = 30;
        short s = 2000;
        int i = 42;
        long l = 123456789L;
        float f = 3.14f;
        double d = 6.66;
        decimal de = 111.234m;
        char c = 'A';
        bool booleanV = true;


        int val = 100;
        string intToString = val.ToString();

        string strValue = "3.14";
        double strToDouble = Convert.ToDouble(strValue);

        Console.WriteLine($"byte: {b}");
        Console.WriteLine($"short: {s}");
        Console.WriteLine($"int: {i}");
        Console.WriteLine($"long: {l}");
        Console.WriteLine($"float: {f}");
        Console.WriteLine($"double: {d}");
        Console.WriteLine($"decimal: {de}");
        Console.WriteLine($"char: {c}");
        Console.WriteLine($"bool: {booleanV}");
        Console.WriteLine($"int converted to string: {intToString}");
        Console.WriteLine($"string '3.14' converted to double: {strToDouble}");
    }

}