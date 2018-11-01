using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieStore.DB;


namespace MovieStore.Business
{
    public class TaxCalculate
    {
         public double GetTaxCalc(int price)
        {
            const double tax = 0.08;
            double TaxRate = price * tax;
            return TaxRate;
         }

        public double TotPrice(int price)
        {
            const double Tax = 0.08;
            double totalPrice = (Tax * price )+ price;
            return totalPrice;
        }
        


    }
}
