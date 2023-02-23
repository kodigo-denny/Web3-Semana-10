using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principio5
{
    internal class Report
    {
        private SQLServer database { get; set; } = new SQLServer();

        public void Open(string data)
        {
            Console.WriteLine("Dato aperturado");
        }

        public void Save()
        {
            database.Insertar();
        }
    }
}
