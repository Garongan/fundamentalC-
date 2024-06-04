namespace FundamentalUpskilling;

public class MyMethod
{
    public void Main(string[] args)
    {
        SayHello();
        HelloUser("Alvindo");
        var sum = Sum(5, 6);
        Console.WriteLine(sum);

        // anonymous method, hanya dapat berjalan di local
        var print = delegate (string any)
        {
            Console.WriteLine($"ini dari method anonim dengan parameter {any}");
        };

        print("apa saja");

        var multiply = delegate (int a, int b)
        {
            return a * b;
        };

        Console.WriteLine(multiply(4, 5));

        var newPrint = () =>
        {
            // kalau di java () ->
            Console.WriteLine("ini dari lambda function");
        };

        newPrint();
    }

    /* 
    access modifier static/non-static return type (void/tipe data apapun) NamaMethod(parameter)
    {
       body method
    } 

    note: static method hanya bisa dipanggil dengan static method, jika tidak maka diakses dengan new instance
    */

    static void SayHello()
    {
        Console.WriteLine("Hello World");
    }

    static void HelloUser(string user)
    {
        Console.WriteLine($"Hello {user}");
    }

    static int Sum(int a, int b)
    {
        return a + b;
    }
}
