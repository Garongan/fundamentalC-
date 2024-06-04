namespace FundamentalUpskilling;

// inheritance c#
class Motor
{
    public void startEngine()
    {
        Console.WriteLine("Brumm");
    }
}

class MotorMurah : Motor
{
    public string harga = "100";
}

class MotorMahal : Motor
{
    public string harga = "1000";
}

abstract class Mobil
{
    public void startEngine()
    {
        Console.WriteLine("Brumm");
    }
}

class MobilMurah : Mobil
{
    public string harga = "1000";
}

interface IHeli
{
    public void StartEngine();
}

class Heli : IHeli
{
    public void StartEngine()
    {
        Console.WriteLine("Bukubuk");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        MotorMahal motor = new MotorMahal();
        motor.startEngine();
        Console.WriteLine(motor.harga);
        MobilMurah mobilMurah = new MobilMurah();
        mobilMurah.startEngine();
        Heli heli = new Heli();
        heli.StartEngine();
    }
}