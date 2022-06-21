using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathSolve.Exeption;

namespace MathSolve.Calcul
{
    public static class Chance
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="numbermax">le nombre qui atteint 100 %</param>
        /// <param name="pourcentage"> ne doit pas dépasser les 100 et ne doit pas être inférieur à 0</param>
        /// <returns></returns>
        public static int ShearNumberWithPourcentage(int numbermax , int pourcentage)
        {
            if (pourcentage > 100 || pourcentage < 0)
                throw new IsNotGoodPourcentageException(pourcentage);
            else
            {
                return numbermax * pourcentage / 100; 
            }

        }

    }
}
