using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploInferfaces2
{
    internal class Air : IShipping
    {
        public void AddClient()
        {
            throw new NotImplementedException();
        }

        public double GetCost()
        {
            return 20;
        }

        public DateTime GetDate()
        {
            return DateTime.Now;
        }
    }
}
