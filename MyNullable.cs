namespace FundamentalUpskilling;

public class MyNullable
{
    public static void Main(string[] args)
    {
        // membuat variable dengan nilai awal null dengan class Nullable<T> -> tipe data generic (dapat menerima tipe data apapun)
        // Nullable merupakaan sebuah struct
        Nullable<int> number = null;
        Console.WriteLine(number);
        
        // short hand menggunakan operator opsional (?)
        int? anotherNumber = null;
        Console.WriteLine(anotherNumber);
        
        // it will error
        // Console.WriteLine(anotherNumber.Value);
        
        // string null itu berbeda dengan string kosong ""
        string? name = null;
        
        // C# mendukung null safety

        if (anotherNumber.HasValue)
        {
            Console.WriteLine(anotherNumber.Value);
        }
        else
        {
            Console.WriteLine("Error: data kosong");
        }
    }
}