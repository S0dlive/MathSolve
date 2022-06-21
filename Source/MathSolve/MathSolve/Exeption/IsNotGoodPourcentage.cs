using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathSolve.Exeption
{
    public class IsNotGoodPourcentageException : Exception
    {

        public IsNotGoodPourcentageException()
        {

        }

        public IsNotGoodPourcentageException(int? name) : base(String.Format("Le chiffre : {0} n'est pas compris entre 0 - 100 : /", name))
        {

        }

    }
}
