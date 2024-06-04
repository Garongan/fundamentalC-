namespace FundamentalUpskilling;

/*
 * Polymorphism -> poly morphism: banyak bentuk, method overload itu juga termasuk banyak bentuk
 * Kita bisa membuat method dengan nama yang sama namun parameternya berbeda
 *
 * Syarat method overload:
 * 1. membuat nama method yang sama dengan parameter berbeda
 * 2. tidak untuk parameter sama namun return type berbeda
 * 
 */
public class Hero
{
    public string? Name { get; set; }
    public int Hp { get; set; }
    public int BaseDamage { get; set; }

    public void Attack(Hero hero)
    {
        Console.WriteLine($"{Name} attack {hero.Name}");
        hero.GetHit(BaseDamage);
    }

    public void Attack(Monster monster)
    {
        Console.WriteLine($"{Name} attack {monster.Name}");
        monster.GetHit(BaseDamage);
    }

    public void GetHit(int damage)
    {
        Console.WriteLine($"{Name} get hit: {damage}");
        Hp -= damage;
    }
}

// public class Program
// {
//     public void Main(string[] args)
//     {
//         var balmond = new Hero
//         {
//             Name = "Balmond",
//             Hp = 3000,
//             BaseDamage = 300
//         };
//
//         var nana = new Hero
//         {
//             Name = "Nana",
//             Hp = 2500,
//             BaseDamage = 200
//         };
//
//         balmond.Attack(nana);
//
//         var minion = new Monster
//         {
//             Name = "Minion",
//             Hp = 1000,
//             BaseDamage = 100
//         };
//         
//         nana.Attack(minion);
//     }
// }