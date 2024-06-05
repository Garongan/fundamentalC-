using System.Collections;

namespace FundamentalUpskilling;

public class List
{
    public void Main(string[] args)
    {
        Console.WriteLine("Hello from list");
        var split = new string('-', 50);
        Console.WriteLine(split);

        /*
         * list hanya bisa diisi satu tipe data
         * array list dapat diisi lebih dari satu tipe data
         */

        var cars = new List<string>() { "Mercy", "Tesla", "Toyota" };
        var bikes = new string[] { "Fixie", "Ontel", "Polygon" };
        
        // accesing last index cara pertama
        Console.WriteLine(bikes[bikes.Length - 1]);

        // add new element to list
        cars.Add("Wuling");
        
        // accessing last index cara kedua
        Console.WriteLine(cars[^1]);
        
        
        var motors = new ArrayList();
        motors.Add("Honda");
        motors.Add(1);
        Console.WriteLine(motors[^1]);
        
        /*
         *  Penggunaan memory lebih rendah daripada arraylist
         */
        
        // contoh dictionary
        Console.WriteLine(split);
        var carPrices = new Dictionary<string, int>();
        carPrices["Mercy"] = 100;
        carPrices["Tesla"] = 1000;
        Console.WriteLine(carPrices["Mercy"]);
        foreach (var carPrice in carPrices)
        {
            Console.WriteLine($"Key: {carPrice.Key}, Value: {carPrice.Value}");
        }
        
        // contoh hashtable
        Console.WriteLine(split);
        var motorPrices = new Hashtable();
        motorPrices["Honda"] = 10;
        motorPrices[1] = "Ini Integer";
        motorPrices["Yamaha"] = new ArrayList
        {
            1,
            2
        };
        Console.WriteLine(motorPrices[1]);
        motorPrices["Suzuki"] = null;
        Console.WriteLine(motorPrices["Suzuki"]);
        foreach (DictionaryEntry entry in motorPrices)
        {
            Console.WriteLine($"Key: {entry.Key}, Value {entry.Value}");
        }

        var yamahaPrices = motorPrices["Yamaha"];
        foreach (var price in ((IEnumerable)yamahaPrices!)!)
        {
            Console.WriteLine(price);
        }

        /*
         * Tuple -> dapat digunakan untuk pembuatan csv
         * contoh tuple
         */
        Console.WriteLine(split);
        var ranking1 = new Tuple<int, string, string>(1, "Alvindo", "Spk Turun");
        var ranking2 = (2, "Theo", "Spk Turun");
        Console.WriteLine(ranking2.GetType());

        // contoh enum
        const CarType carType = CarType.Diesel;
        Console.WriteLine(carType);
    }
}

enum CarType
{
    Electric,
    Diesel,
    Gas
}

class CollectionList
{
    
}