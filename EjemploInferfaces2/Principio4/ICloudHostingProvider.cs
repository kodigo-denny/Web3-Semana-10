using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principio4
{
    internal interface ICloudHostingProvider
    {
        public void CreateServer(string region);

        public void ListServers(string region);
    }
}
