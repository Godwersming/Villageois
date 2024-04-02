using ClassVillageois;

using System;

namespace ClassVillageois
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Villageois a = new Villageois("Panoramix", 16, true);
            Villageois b = new Villageois("Abraracourcix");
            Console.WriteLine(b.getPoids());
            b.setPoids(16);
            Console.WriteLine(a.ToString());
            Console.WriteLine(a.getNom());
            Console.WriteLine(a.getPoids());
            Console.WriteLine(a.soulevemepoids(b));

            a.setDose(3);
            Console.WriteLine($"{a.getNom()} prend {a.getPotion().getDose()} doses");
            Console.WriteLine("Apres les doses " + a.plusFort(b));
            Console.WriteLine($"{a.getNom()} soulève {a.poidsSouleve()} poids");
            Console.WriteLine($"{b.getNom()} soulève {b.poidsSouleve()} poids");

            Village villageGaulois = new Village("petit village", "Glenbret", 500);
            villageGaulois.AjouterVillageois(a);
            villageGaulois.AjouterVillageois(b);
            villageGaulois.AjouterNewVillageois("Homéopatix", 20, true, 3);
            Console.WriteLine(villageGaulois.GetVillageois("Panoramix").ToString());
            Console.WriteLine($"Il y a {villageGaulois.GetHabitants().Count} habitants dans le village {villageGaulois.GetNom()}");
        }
    }
}
