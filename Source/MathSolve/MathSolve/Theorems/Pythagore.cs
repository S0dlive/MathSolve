using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathSolve.Theorems
{
    public static class Pythagore
    {

        public static bool IsHypotenuse(this int hypo , 
            int scote ,
            int cote)
        {
            if (hypo * hypo == scote * scote + cote * cote)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static int ShearHypotenuse(int scote , int cote)
        {
            return scote * scote + cote * cote;
        }

        public static int ShearCote(int hypotenuse , int cote)
        {
            if (hypotenuse < cote)
            {
                throw new Exeption.IsNotHypotenuseException(hypotenuse);
            }
            else
            {
                return hypotenuse * hypotenuse - cote * cote;
            }
        }
    }
}
