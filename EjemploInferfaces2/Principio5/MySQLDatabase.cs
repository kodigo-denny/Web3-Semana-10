using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principio5
{
    internal class MySQLDatabase
    {
        public void Insert() {
            Console.WriteLine("Datos insertados en MySQL");
        }

        public void Update() {
            Console.WriteLine("Actualizado en MySQL");
        }

        public void Delete()
        {
            Console.WriteLine("Eliminado en MySQL");
        }
    }
}
