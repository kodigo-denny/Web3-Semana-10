using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploInferfaces2
{
    internal class Ground : IShipping
    {
        private int propiedad { get; set; }

        public void AddClient()
        {
            throw new NotImplementedException();
        }

        public double GetCost()
        {
            return 10;
        }

        public DateTime GetDate()
        {
            return DateTime.Now;
        }
    }
}
