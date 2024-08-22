using System.Diagnostics;

[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
internal class Program
{
    private static void Main(string[] args)
    {
        int count = 0;
        while (count < 100)
        {
            Console.WriteLine("hello world");
            count++;
        }
        for(count=0;count<100;count++)
            Console.WriteLine("hello world");

        Console.WriteLine("Hello, World!");
        Console.WriteLine("\n*\n**\n***");

        for(int count2 = 0; count2 < 100; count2++)
        {
            Console.WriteLine("Rodrigo Zaleski Pioner");
            Console.WriteLine(count2);
        }
        for(int count3 = 0; count3 < 100; count3++)
        {
            if(count3%2!=0)
                Console.WriteLine(  "*");
            else
                Console.WriteLine(  "**");
        }
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}