namespace Principio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Amazon amazon = new Amazon();
            amazon.StoreFile("archivo1.txt");
            amazon.GetFile("archivo1.txt");
            amazon.CreateServer("USA");
            amazon.ListServers("USA");
            amazon.GetCDNAddress();


            var dropbox = new Dropbox();
            dropbox.StoreFile("archivo2.txt");
            dropbox.GetFile("archivo2.txt");
            */

            
            List<ICloudStorageProvider> lista = new List<ICloudStorageProvider>();
            lista.Add(new Amazon());
            lista.Add(new Dropbox());
            lista.Add(new Amazon());
            
            foreach(var item in lista) {
                item.GetFile("archivo1.txt");
                item.StoreFile("archivo1.txt");
            }

        }
    }
}