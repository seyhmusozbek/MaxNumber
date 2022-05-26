using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class NumberService : INumberService
    {
        public int GetMax(int[] numbers)
        {
            return numbers.Max(x => x);
        }
    }
}
