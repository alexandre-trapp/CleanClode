using System;
using System.Collections.Generic;

namespace LogisticaCerveja 
{
    public class LogisticaCerveja 
    {
        private static List<Cerveja> _listagemCervejasVendidas;
        private static int _quantidadeTotalCervejasVendidas;

        public static void EfetuarProcessoDeLogisticaDaCervejaPilsenELagger() 
        {
            var materiaPrima = ColetarMateriaPrima();

            var cervejaPilsen = FabricarCervejaPilsen(materiaPrima);
            var cervejaLagger = FabricarCervejaLagger(materiaPrima);

            var cervejasVendidasPilsen = VenderCervejasPilsen(cervejaPilsen);
            var cervejasVendidasLagger = VenderCervejasLagger(cervejaLagger);

            _listagemCervejasVendidas = ObterListagemDeCervejasVendidas(
                                            cervejasVendidasPilsen,
                                            cervejasVendidasLagger);

            var transporte = TransportarCervejasParaOPdv();

            EntregarCervejasAoPdv(transporte);
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

        private static List<Cerveja> ObterListagemDeCervejasVendidas(
            List<Cerveja> cervejasVendidasPilsen,List<Cerveja> cervejasVendidasLagger) 
        {
            var cervejasVendidas = new List<Cerveja>();

            cervejasVendidas.AddRange(cervejasVendidasPilsen);
            cervejasVendidas.AddRange(cervejasVendidasLagger);

            return cervejasVendidas;
        }

        private static TransporteCerveja TransportarCervejasParaOPdv() 
        {
            var transporte = new TransporteCerveja(_listagemCervejasVendidas);
            transporte.Transportar(_quantidadeTotalCervejasVendidas, "Buteco do Trapp");

            return transporte;
        }

        private static void EntregarCervejasAoPdv(TransporteCerveja transporte) 
        {
            var entrega = new EntregaCerveja(transporte);
            entrega.Entregar();
        }
    }
}