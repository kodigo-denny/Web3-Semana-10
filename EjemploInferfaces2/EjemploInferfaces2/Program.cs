namespace EjemploInferfaces2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var objeto = new Ground();
            Console.WriteLine(objeto.GetCost());
            objeto.AddClient();
            

            var objeto2 = new Air();
            Console.WriteLine(objeto2.GetCost());
        }
    }
}