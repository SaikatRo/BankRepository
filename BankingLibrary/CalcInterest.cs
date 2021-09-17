using System;

namespace BankingLibrary
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
