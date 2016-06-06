using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stockroom
{
    public class Prices
    {
        
        private Random random = new Random();
        public virtual double PriceFor(string item)
        {
            if (item.ToLower().StartsWith("a"))
            {
                return 5.5;
            } else
            {
                return Math.Round(random.NextDouble() * 100, 2);
            }
        }
    }
}
