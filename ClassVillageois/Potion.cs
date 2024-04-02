using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassVillageois
{
    public class Potion
    {
        private int _dose;
        public Potion(int n)
        {
            _dose = n;
        }


        public void ajouterDose(int n)
        {
            _dose = _dose + n;
        }

        public int getDose()
        {
            return _dose;
        }

    }
}