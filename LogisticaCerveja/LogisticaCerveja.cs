using System;

namespace LogisticaCerveja
{
    public class LogisticaCerveja
    {
        public static void EfetuarProcessoDeLogisticaDaCervejaPilsenELagger()
        {
            var materiaPrima = ColetarMateriaPrima();

            var cervejaPilsen = FabricarCervejaPilsen(materiaPrima);
            var cervejaLagger = FabricarCervejaLagger(materiaPrima);

            VenderCervejaPilsen(cervejaPilsen);
            VenderCervejaLagger(cervejaLagger);
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
            throw new NotImplementedException();
        }

        private static void VenderCervejaPilsen(Cerveja cervejaPilsen)
        {
            Console.WriteLine("Informe a quantidade de cerveja pilsen: ");
            int quantidade = Convert.ToInt32(Console.ReadLine());

            VenderCerveja(cervejaPilsen, quantidade);
        }

        private static void VenderCervejaLagger(Cerveja cervejaLagger)
        {
            Console.WriteLine("Informe a quantidade de cerveja pilsen: ");
            int quantidade = Convert.ToInt32(Console.ReadLine());

            VenderCerveja(cervejaLagger, quantidade);
        }

        private static void VenderCerveja(Cerveja cervejaLagger, int quantidade)
        {
            throw new NotImplementedException();
        }
    }
}
