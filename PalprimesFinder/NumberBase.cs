using System;
using System.Collections.Generic;
using System.Text;

namespace PalprimesFinder
{
    public class NumberBase
    {
        public string ConvertDecimalToOtherBase(long number, int numberBase)
        {
            return Convert.ToString(number, numberBase);
        }

        //public long ConvertOtherBaseToDecimal(string number, int numberBase)
        //{
        //    return Convert.ToInt64(number, numberBase);
        //}
    }
}
