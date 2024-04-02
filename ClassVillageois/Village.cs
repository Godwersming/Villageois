using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassVillageois
{
    public class Village
    {
        private string description;
        private string name;
        private int superficie;
        private List<Villageois> mesHabitants;
        
        public Village(string description, string name, int superficie)
        {
            this.description = description;
            this.name = name;
            this.superficie = superficie;
            this.mesHabitants = new List<Villageois>();
         }

        public void AjouterVillageois (Villageois a)
        {
            mesHabitants.Add(a);
        }


        public void AjouterNewVillageois(string nom, int poids, bool malade, int potion)
        {
            Villageois a = new Villageois(nom, poids, malade,potion);
            mesHabitants.Add(a);
        }

        public Villageois GetVillageois(string nom)
        {
            Villageois villageoisTrouve = null;

            foreach (Villageois a in mesHabitants)
            {
                if (a.getNom() == nom)
                {
                    villageoisTrouve = a;
                    break; 
                }
            }


            return villageoisTrouve;
        }

        public List<Villageois> GetHabitants()
        {
            return mesHabitants;
        }


        public string GetNom()
        {
            return this.name;
        }

    }
}
