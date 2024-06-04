// semua object atau method di c# memakai PascalCase

public class Program
{
    public void Main(string[] args)
    {

        /* 
        Multi Line
         */

        Console.WriteLine("Hello World"); // with new line
        Console.Write("Hello Dunia");

        Console.WriteLine();

        // penulisan variabel
        int number = 10; // explisit
        var number1 = 10; // implisit

        Console.WriteLine(number);
        Console.WriteLine(number1);


        // camelCase -> variable
        // PascalCase -> class atau method
        // _underScore -> private field

        /* 

        Number data type
        tipe data number dibagi menjadi 2
        - Integer Types:
         - byte 8bit
         - short 16bit
         - int 32bit
         - long 64bit
        - Floating Point Types:
         - float 32bit
         - double 64bit
         - decimal 128bit
         */

        /* 
        unsigned data type -> data yang tidak boleh minus
        - Integer types
         - ushort
         - uint
         - ulong
         */

        ushort unsignedShortNumber = 1;
        uint unsignedIntegerNumber = 2354565;
        ulong unsignedLongNumber = 124546548624798L;
        // contoh penggunaan
        uint stock = 20;
        System.Console.WriteLine(unsignedShortNumber);
        System.Console.WriteLine(unsignedIntegerNumber);
        System.Console.WriteLine(unsignedLongNumber);
        System.Console.WriteLine(stock);

        //  Integer types
        byte byteNumber = 123;
        short shortNumber = 10000;
        int intNumber = 1000000000;
        long longNumber = 10000000000000L;

        System.Console.WriteLine(byteNumber);
        System.Console.WriteLine(shortNumber);
        System.Console.WriteLine(intNumber);
        System.Console.WriteLine(longNumber);

        // Floating Point Types:
        float floatNumber = 1234.5F;
        double doubleNumber = 123354675868.5d;
        decimal decimalNumber = 1235354365379135823750.5755817489m;
        System.Console.WriteLine(floatNumber);
        System.Console.WriteLine(doubleNumber);
        System.Console.WriteLine(decimalNumber);

        /* 
        String 
         */

        char myChar = 'a';
        string fullname = "Alvindo Tri Jatmiko";
        System.Console.WriteLine(myChar);
        System.Console.WriteLine(fullname);


        //  Escape Character atau menyelipkan text ke string

        string text = "This is \"String\"";
        Console.WriteLine(text);

        // dengan simbol @ akan membaca semua string walaupun itu escape character atau multi line
        // Verbatim String 
        string path = @"\\mypc\shared";
        System.Console.WriteLine(path);
        Console.WriteLine(
            @"1. Makan
            2. Turu
            3. Mandi"
        );

        // String concat
        string name = "Alvindo" + "Tri";
        System.Console.WriteLine(name);

        // String interpolation
        string firstName = "Alvindo";
        string lastName = "Jatmiko";
        string fullName = $"{firstName} {lastName}";
        Console.WriteLine(fullName);
    }
}