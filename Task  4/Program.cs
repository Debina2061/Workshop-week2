class Program
{
    static void Main()
    {

        int[] favNumbers = { 1, 2, 3, 4, 5,6 };

        Array.Sort(favNumbers);

        Array.Reverse(favNumbers);

        Console.WriteLine("Array elements (in descending order):");
        for (int i = 0; i < favNumbers.Length; i++)
        {
            Console.WriteLine(favNumbers[i]);
        }

        int numberToFind = 15;
        int index = Array.IndexOf(favNumbers, numberToFind);

        Console.WriteLine($"\nPosition of {numberToFind} in array: {index}");
    }
}