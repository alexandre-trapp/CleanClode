using System;
using System.Collections.Generic;

namespace LogisticaCerveja
{
    public class LogisticaCerveja
    {
        private static List<Cerveja> _cervejasVendidas;
        private static int _quantidadeTotalCervejasVendidas;

        public static void EfetuarProcessoDeLogisticaDaCervejaPilsenELagger()
        {
            var materiaPrima = ColetarMateriaPrima();

            var cervejaPilsen = FabricarCervejaPilsen(materiaPrima);
            var cervejaLagger = FabricarCervejaLagger(materiaPrima);

            var cervejasVendidasPilsen = VenderCervejasPilsen(cervejaPilsen);
            var cervejasVendidasLagger = VenderCervejasLagger(cervejaLagger);
            
            AdicionarCervejasVendidasNaLista(cervejasVendidasPilsen, 
                cervejasVendidasLagger);

            var transporte = TransportarCervejas();

            EntregarCervejas(transporte);
        }

        private static MateriaPrima ColetarMateriaPrima()
        {
            return new MateriaPrima
            {
                Agua = true,
                Fermento = true,
                Lupulo = true,
                MalteCevada = true
            };
        }

        private static CervejaPilsen FabricarCervejaPilsen(MateriaPrima materiaPrima)
        {
            return new CervejaPilsen(materiaPrima);
        }

        private static CervejaLagger FabricarCervejaLagger(MateriaPrima materiaPrima)
        {
            return new CervejaLagger(materiaPrima);
        }

        private static List<Cerveja> VenderCervejasPilsen(Cerveja cervejaPilsen)
        {
            Console.WriteLine("Informe a quantidade de cerveja pilsen: ");

            int quantidade = Convert.ToInt32(Console.ReadLine());
            _quantidadeTotalCervejasVendidas += quantidade;

            return VendaCerveja.Vender(cervejaPilsen, quantidade);
        }

        private static List<Cerveja> VenderCervejasLagger(Cerveja cervejaLagger)
        {
            Console.WriteLine("Informe a quantidade de cerveja pilsen: ");

            int quantidade = Convert.ToInt32(Console.ReadLine());
            _quantidadeTotalCervejasVendidas += quantidade;

            return VendaCerveja.Vender(cervejaLagger, quantidade);
        }

        private static void AdicionarCervejasVendidasNaLista(List<Cerveja> cervejasVendidasPilsen, 
            List<Cerveja> cervejasVendidasLagger)
        {
            _cervejasVendidas = new List<Cerveja>();

            _cervejasVendidas.AddRange(cervejasVendidasPilsen);
            _cervejasVendidas.AddRange(cervejasVendidasLagger);
        }

        private static TransporteCerveja TransportarCervejas()
        {
            var transporte = new TransporteCerveja(_cervejasVendidas);
            transporte.Transportar(_quantidadeTotalCervejasVendidas, "Buteco do Trapp");

            return transporte;
        }

        private static void EntregarCervejas(TransporteCerveja transporte)
        {
            var entrega = new EntregaCerveja(transporte);
            entrega.Entregar();
        }
    }
}
