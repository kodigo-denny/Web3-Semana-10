using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploInferfaces2
{
    internal interface IShipping
    {
        public double GetCost();

        public DateTime GetDate();

        public void AddClient();
    }
}
