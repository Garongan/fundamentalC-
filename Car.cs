namespace FundamentalUpskilling;

/*
 *
 * OOP adalah paradigma yang digunakan untuk merancang aplikasi menjadi beberapa modul
 * class -> blueprint
 * objet -> reprensentasi dari class atau blueprint
 * dengan oop kita bisa membuat kode menjadi reusable
 *
 * ada 4 pilar oop
 * 1. Encapsulation
 * 2. Polymorphism
 * 3. Abstraction
 * 4. Inheritance
 *
 * access modifier
 * 1. public -> bisa diakses dimanapun
 * 2. private -> bisa diakses di class sendiri
 * 3. protected -> bisa di akses di child dan classnya sendiri
 * 4. internal -> hanya bisa diakses di project yang sama
 *
 */

// blueprint car
public class Car
{
    private string _name;
    public string Color { get; set; }
    public string Brand { get; set; }
    public int Fuel { get; set; }
    
    // private string _color;
    // private string _brand;
    // private int _fuel;

    // constructor -> method yang namanya sama dengan class, dan method constructor itu akan dipanggil atau dijalankan saat kita instance object
    // constructor merupakan overloading method
    // public Car(string color, string brand, int fuel)
    // {
    //     Color = color;
    //     Brand = brand;
    //     Fuel = fuel;
    // }
    //
    // public Car()
    // {
    // }

    // cara pertama
    // public string GetColor()
    // {
    //     return _color;
    // }
    //
    // public void SetColor(string color)
    // {
    //     _color = color;
    // }

    // cara kedua
    // public string Color
    // {
    //     get { return _color; }
    //     set {
    //         if (_color is not null)
    //         {
    //             _color = value;
    //         }
    //     }
    // }

    // cara ketiga
    public string Name
    {
        get => _name;
        set => _name = value;
    }
}

// public class Program
// {
//     public static void Main(string[] args)
//     {
//         // object - instance object - membuat object
//         Car ayla = new Car
//         {
//             Brand = "Toyota",
//             Color = "White",
//             Fuel = 30,
//             Name = "All New Ayla"
//         };
//         Console.WriteLine(ayla.Name);
//
//         var supra = new Car
//         {
//             Brand = "Toyota",
//             Color = "Blue",
//             Fuel = 20,
//             Name = "This is Supra"
//         };
//         // is called direct access -> kurang bagus
//         Console.WriteLine(supra.Color);
//         supra.Color = "Red";
//         Console.WriteLine(supra.Color);
//
//         var rush = new Car();
//         // Console.WriteLine(rush.Color);
//     }
// }