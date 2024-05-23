namespace FundamentalUpskilling;

// dapat membuat 2 atau lebih class di dalam satu file
public class Person
{
}

public enum Direction
{
    North,
    East,
    South,
    West
}

public enum WeekDays
{
    Monday, // member monday valuenya adalah 0
    Tuesday, // 1
    Wednesday, // 2
    Thursday,
    Friday,
    Saturday,
    Sunday
}

public enum ErrorCode
{
    NotFound = 101
}

// bisa diganti value dari enum
public enum Role
{
    Manager = 6,
    Admin = 3,
    Customer = 1
}

public class Types
{
    // inner class enum
    // accessModifier enum Gender

    private enum Gender
    {
        // untuk penulisan data enum PascalCase
        Male,
        Female
    }

    public void Main(string[] args)
    {
        /*
         * Enum itu adalah kumpulan data constant
         * Gender: Male, Female
         * MataAngin: Utara, Timur, Selatan, Barat
         *
         * untuk pembuatan enum itu bisa dibuat didalam class ataupun diluar class
         *
         */

        Console.WriteLine(Gender.Male);
        // change enum to string
        Console.WriteLine(Gender.Female.ToString());
        Console.WriteLine(GetMale());

        // break
        Console.WriteLine(new string('-', 50));

        // calling enum outside of class
        Console.WriteLine(Direction.East);
        Console.WriteLine(WeekDays.Sunday.ToString());
        Console.WriteLine(Role.Manager);

        // casting -> merubah satu tipe data ke tipe data lain
        int maleValue = (int)Gender.Male;
        Console.WriteLine(maleValue);
    }

    private static Gender GetMale()
    {
        return Gender.Male;
    }
}