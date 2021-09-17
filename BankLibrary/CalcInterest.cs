using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLibrary
{
    public class CalcInterest : ICalcInterest
    {
        public int Calculate(int principle, int RateOfInt, int years)
        {
            int SimpInt = (principle * RateOfInt * years) / 100;
            return SimpInt;
        }
    }
}
