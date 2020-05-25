using System;
using CleanClode.CodigoSujo;
using CleanClode.CodigoLimpo;
using System.Runtime.ConstrainedExecution;

namespace CleanClode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Código sujo");
            Console.WriteLine("---------------------------------");

            ExemploCodigoSujo();

            Console.WriteLine("---------------------------------");

            Console.WriteLine("Código limpo");
            Console.WriteLine("---------------------------------");

            ExemploCodigoLimpo();

            Console.WriteLine("---------------------------------");

            Console.ReadKey();
        }

        private static void ExemploCodigoSujo()
        {
            Console.WriteLine("Informe a quantidade de cerveja que deseja comprar:");
            string quantidadeCerveja = Console.ReadLine();

            Console.WriteLine($"Cerveja pilsen: quantidade: {quantidadeCerveja} - preço unitário: R$ 3,50.");
            Console.WriteLine("Total da venda: " + VendCervPilLag.VdCerv(1, 3.50m, 0, Convert.ToInt32(quantidadeCerveja)));

            Console.WriteLine("---------------------------------");

            Console.WriteLine($"Cerveja lagger: quantidade: {quantidadeCerveja} - preço unitário: R$ 5,00.");
            Console.WriteLine("Total da venda: " + VendCervPilLag.VdCerv(2, 0, 5.00m, Convert.ToInt32(quantidadeCerveja)));
        }

        private static void ExemploCodigoLimpo()
        {
            Console.WriteLine("Informe a quantidade de cerveja que deseja comprar:");
            string quantidadeCerveja = Console.ReadLine();

            VenderCervejaPilsen(Convert.ToInt32(quantidadeCerveja));

            Console.WriteLine("---------------------------------");

            VenderCervejaLagger(Convert.ToInt32(quantidadeCerveja));
        }

        private static void VenderCervejaPilsen(int quantidadeCerveja)
        {
            var cervejaPilsen = new CervejaPilsen();
            var vendaCervejaPilsen = new VendaCerveja(cervejaPilsen);

            decimal valorDaVenda = vendaCervejaPilsen.VenderCerveja(quantidadeCerveja);

            Console.WriteLine($"Cerveja {cervejaPilsen.TipoCerveja}: " +
                $"quantidade: {quantidadeCerveja} - " +
                $"preço unitário: R$ {cervejaPilsen.ValorUnitario}.");

            Console.WriteLine("Total da venda: " + valorDaVenda);
        }

        private static void VenderCervejaLagger(int quantidadeCerveja)
        {
            var cervejaLagger = new CervejaLagger();
            var vendaCervejaLagger = new VendaCerveja(cervejaLagger);

            decimal valorDaVenda = vendaCervejaLagger.VenderCerveja(quantidadeCerveja);

            Console.WriteLine($"Cerveja {cervejaLagger.TipoCerveja}: " +
                $"quantidade: {quantidadeCerveja} - " +
                $"preço unitário: R$ {cervejaLagger.ValorUnitario}.");

            Console.WriteLine("Total da venda: " + valorDaVenda);
        }
    }
}
