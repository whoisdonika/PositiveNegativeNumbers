using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PositiveNegativeNumbers
{
    public class Numbers
    {
        public bool IsPositive(double number)
        {
            if (number > 0)
            {
                return true;
            }
            else if (number == 0)
            {
                throw new ArgumentException();
            }
            else
            {
                return false;
            }
        }
    }
}
