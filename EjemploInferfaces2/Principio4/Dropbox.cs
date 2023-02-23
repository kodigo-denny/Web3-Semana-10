using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principio4
{
    internal class Dropbox : ICloudStorageProvider
    {
        public void StoreFile(string name)
        {
            Console.WriteLine($"Archivo {name} guardado en Dropbox");
        }

        public void GetFile(string name)
        {
            Console.WriteLine($"Archivo {name} obtenido desde Dropbox");
        }
    }
}
