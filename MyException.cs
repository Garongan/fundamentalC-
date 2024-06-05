using System.Text.RegularExpressions;

namespace FundamentalUpskilling;

public class MyException
{
    public void Main(string[] args)
    {
        try
        {
            Console.WriteLine("masuk try");
            var numberString = "a";
            var valueParsing = int.Parse(numberString);
            Console.WriteLine(valueParsing);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            // throw new Exception($"Parse Failed {e.Message}");
        }
        finally
        {
            Console.WriteLine("ini masuk final");
        }

        // custom exception
        PesertaBootCamp cahyo;
        try
        {
            cahyo = new PesertaBootCamp();
            cahyo.NamaPeserta = "Cahyo888";
            ValidatePeserta(cahyo);
        }
        catch (InvalidNamaPesertaException e)
        {
            Console.WriteLine(e.Message);
        }
    }

    private static void ValidatePeserta(PesertaBootCamp pesertaBootCamp)
    {
        var regex = new Regex("^[a-zA-Z]+$");

        if (!regex.IsMatch(pesertaBootCamp.NamaPeserta))
        {
            throw new InvalidNamaPesertaException(pesertaBootCamp.NamaPeserta);
        }
    }
}

class PesertaBootCamp
{
    public int IdPeserta { get; set; }
    public string NamaPeserta { get; set; }
}

class InvalidNamaPesertaException : Exception
{
    public InvalidNamaPesertaException()
    {
    }

    public InvalidNamaPesertaException(string nama) : base(String.Format("Invalid Nama Peserta: {0}", nama))
    {
    }
}