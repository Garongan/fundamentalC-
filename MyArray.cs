namespace FundamentalUpskilling;

public class MyArray
{
    public void Main(string[] args)
    {
        /* 
        
        Array adalah tipe data untuk menyimpan lebih dati satu value dalam satu variabel.
        array index dimulai dari 0. dan emelent array diakses dengan menggunakan index.

         */

        // explicit declaration array
        int[] numbers = new int[5];
        numbers[0] = 1;
        numbers[1] = 2;
        numbers[2] = 3;
        // numbers[3] = 4;
        // numbers[4] = 5;
        // numbers[5] = 6; error index out of bound

        Console.WriteLine(numbers[0]);
        Console.WriteLine(numbers[1]);
        Console.WriteLine(numbers[2]);
        Console.WriteLine(numbers[3]);
        Console.WriteLine(numbers[4]);

        // cara kedua deklarasi secara langsung
        string[] cities = { "Jakarta", "Bandung", "Surabaya" };
        // cities[3] = "medan";

        // for i
        for (int i = 0; i < cities.Length; i++)
        {
            Console.WriteLine($"Kota: {cities[i]}");
        }

        Console.WriteLine(new string('-', 50));
        // var is implisit declaration
        foreach (var city in cities)
        {
            Console.WriteLine($"Kota: {city}");
        }

        var anotherNumbers = new int[3];
        anotherNumbers[0] = 1;

        var anotherCities = new[] { "Denpasar", "Demak" };

        /* 
        
        Multidimensional array

        [
            [1, 2], [],
        ]
         */


        // two row and two columns
        int[,] matrix = new int[2, 2];
        matrix[0, 0] = 1;
        matrix[0, 1] = 2;
        matrix[1, 0] = 3;
        matrix[1, 1] = 4;

        // print matrix
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            Console.Write("[");
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($" {matrix[i, j]} ");
            }
            Console.WriteLine("]");
        }
    }
}
