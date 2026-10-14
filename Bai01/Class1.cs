using System;

namespace ServiceChargeCalculator
{
    public class Calculator
    {
        public decimal Calculate(
            decimal unitPrice,
            int quantity,
            decimal discount)
        {
            return (unitPrice * quantity)
                * (100 - discount) / 100;
        }
    }
}