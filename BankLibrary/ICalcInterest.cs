using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLibrary
{
    public interface ICalcInterest
    {
         int Calculate(int principle, int RateOfInt, int years);
    }
}
