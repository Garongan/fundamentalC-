namespace FundamentalUpskilling;

public class Operators
{
    public void Main(string[] args)
    {
        /* 
        Arithmethic Operator
        (+) (-) (*) (/) (%)
         */
        int sum = 10 + 10;
        float sum1 = 10.1f + 10;
        double sum2 = 10.1 + 19;
        System.Console.WriteLine(sum);
        System.Console.WriteLine(sum1);
        System.Console.WriteLine(sum2);

        /* 
        Assignment operator
        (=) assignment
         */

        int a = 10;
        System.Console.WriteLine(a);

        /* 
        Operator comparison -> mengembalikan tipe data boolean
        <, >, !=, ==, <=, >=
         */

        bool b = 1 != 2;
        System.Console.WriteLine(b);

        // increment, decrement (x++, x--, ++x, --x)
        System.Console.WriteLine(a++);
        System.Console.WriteLine(a);
        System.Console.WriteLine(++a);

        /* 
        Logical operator
        (and) ->  &&, (or) -> ||
         */

         bool c = 10 > 0 && 10 < 11;
         System.Console.WriteLine(c);
    }
}
