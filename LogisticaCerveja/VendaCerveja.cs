using System;
using System.Collections.Generic;
using Microsoft.OpenApi.Extensions;

namespace LogisticaCerveja
{
    public static class VendaCerveja
    {
        public static List<Cerveja> Vender(Cerveja cerveja, int quantidade)
        {
            var venda = new CalculoVendaCerveja(cerveja);
            decimal valorVenda = venda.CalcularVenda(quantidade);

            Console.WriteLine($"Vendido {quantidade} cervejas tipo {cerveja.TipoCerveja.GetDisplayName()} - " +
                $"Valor total: {valorVenda}");

            return CriarListaDeCervejasVendidas(cerveja, quantidade);
        }

        private static List<Cerveja> CriarListaDeCervejasVendidas(Cerveja cerveja, int quantidade)
        {
            var cervejasVendidas = new List<Cerveja>();

            for (int numeroCerveja = 0; numeroCerveja < quantidade; numeroCerveja++)
                cervejasVendidas.Add(cerveja);

            return cervejasVendidas;
        }
    }
}
