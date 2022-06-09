using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathSolve.Exeption
{
    public class IsNotHypotenuseException : Exception
    {

        public IsNotHypotenuseException()
        {

        }

        public IsNotHypotenuseException(int? name) : base(String.Format("Le chiffre : {0} n'est pas l'hypoténuse ." , name))
        {
            
        }


    }
}
