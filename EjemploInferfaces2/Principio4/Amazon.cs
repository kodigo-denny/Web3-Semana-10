using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principio4
{
    internal class Amazon : ICloudHostingProvider, ICDNProvider, ICloudStorageProvider
    {
        public void CreateServer(string region)
        {
            Console.WriteLine($"Servidor creado en la region {region} de Amazon");
        }

        public void ListServers(string region)
        {
            Console.WriteLine($"Listado de servidores de la region {region} de Amazon");
        }

        public void GetCDNAddress()
        {
            Console.WriteLine("CDN obtenido desde Amazon");
        }

        public void StoreFile(string name)
        {
            Console.WriteLine($"Archivo guardado {name} en Amazon");
        }

        public void GetFile(string name)
        {
            Console.WriteLine($"Archivo abierto {name} desde Amazon");
        }

    }
}
