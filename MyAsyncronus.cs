namespace FundamentalUpskilling;

/// <summary>
/// learn about asynchronous function
/// </summary>
public class MyAsyncronus
{
    public static async Task Main(string[] args)
    {
        var prosesPanjang = ProsesPanjang();
        ProsesSingkat();
        var hasilProsesPanjang = await prosesPanjang;
        Console.WriteLine(hasilProsesPanjang);
    }

    private static async Task<string> ProsesPanjang()
    {
        Console.WriteLine("in process lama");
        await Task.Delay(5000);
        return "out process lama";
    }

    private static void ProsesSingkat()
    {
        Console.WriteLine("in process singkat");
        Console.WriteLine("out process singkat");
    }
}