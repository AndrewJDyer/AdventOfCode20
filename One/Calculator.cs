using System;
using System.Collections.Generic;
using System.Linq;

namespace One
{
    public class Calculator
    {
        private readonly IEnumerable<int> allExpenses;

        public Calculator(IEnumerable<int> allExpenses)
        {
            this.allExpenses = allExpenses;
        }

        public int GetMultiplication()
        {
            var (x, y, z) = GetSummingExpenses();
            return x * y * z;
        }

        private (int X, int Y, int Z) GetSummingExpenses()
        {
            foreach (var x in allExpenses.ToList())
            {
                foreach (var y in allExpenses.ToList())
                {
                    foreach (var z in allExpenses)
                    {
                        if (x + y + z == 2020)
                            return (x, y, z);
                    }
                }
            }

            throw new InvalidOperationException("No pair of expenses summing to 2020");
        }
    }
}