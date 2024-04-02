using System;

namespace ClassVillageois
{
    public class Villageois
    {
        private string nom;
        private int poids;
        private bool malade;
        private Potion maPotion;
        public Villageois(string nom)
        {
            this.nom = nom;
            this.malade = false;
            this.maPotion = new Potion(0);
        }
        public Villageois(string nom, int poids, bool malade)
        {
            this.nom = nom;
            this.poids = poids;
            this.malade = malade;
            this.maPotion = new Potion(0);
        }

           public Villageois(string nom, int poids, bool malade,int potion)
        {
            this.nom = nom;
            this.poids = poids;
            this.malade = malade;
            this.maPotion = new Potion (potion);
        }   
        public string getNom()
        {
            return nom;
        }
        public int getPoids()
        {
            return poids;
        }
        public bool getMalade()
        {
            return malade;
        }
        public void setPoids(int poids)
        {
            this.poids = poids;
        }
        public bool soulevemepoids(Villageois c)
        {
            bool flag = false;
            if (this.poids == c.getPoids()) flag = true;
            return flag;

        }
        public void setDose(int dose) {
        maPotion.ajouterDose(dose);
        }
        public Potion getPotion()
        {
            return maPotion;
        }
        public int poidsSouleve()
        {
            return poids/5 ;
        }
        public string plusFort(Villageois b)
        {
            string rep = $"{b.getNom()} est le plus fort.";
            if (this.soulevemepoids(b))
            {
                rep = "ils sont de force équivalente.";
            }
            else 
            {
                if (this.poidsSouleve() > b.poidsSouleve())
                {
                    rep = $"{nom} est le plus fort.";
                }
            }
            return rep;
        }
    }

}





