// namespace digunakan untuk pengelompokan atau package kalau di dalam java
namespace FundamentalUpskilling;

public class Looping
{
    public void Main(string[] args)
    {
        /* 
        C# memiliki 3 loop (for loop, while loop, do while loop)
        for -> counted loop
        while, do while -> loop conditional loop
         */

        for (var i = 0; i < 10; i++)
        {
            System.Console.WriteLine($"iteration ke {i}");
        }

        var j = 0;
        while (j < 10)
        {
            System.Console.WriteLine($"while loop ke-{j}");
            j++;
        }

        var k = 0;
        do
        {
            System.Console.WriteLine($"do while loop ke-{k}");
            k++;
        } while (k > 10);

        // melakukan input dari console
        // hanya menerima tipe data string dan mengembalikan tipe data string
        Console.Write("masukkan kata-kata: "); 
        var inputString = Console.ReadLine();
        var inputNumber = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine(inputString);
        System.Console.WriteLine(inputNumber.GetType());
    }
}
