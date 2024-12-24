using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    public class CurrencyConverter
    {
        public double ConvertUsdToEur(double amount)
        {
            return amount * 0.85;
        }

        public double ConvertEurToUsd(double amount)
        {
            return amount * 1.18;
        }
    }
}
