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

        public static int ShearHypotenuse(this int hypo , int scote , int cote)
        {
            if (scote * scote + cote * cote == hypo * hypo)
            {
                return hypo*hypo;
            }
            else
            {
                return 0;
            }
        }

    }
}
