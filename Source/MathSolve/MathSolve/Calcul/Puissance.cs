using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathSolve.Calcul
{
    public static class Puissance
    {

        public static int CalculationWithPersonalizedPowers(int chiffre , int puissance)
        {

            int result = 1;


            for(int i = 0; i < puissance; i++)
            {
                result =  result * chiffre;
            }

            return result;

        }

    }
}
