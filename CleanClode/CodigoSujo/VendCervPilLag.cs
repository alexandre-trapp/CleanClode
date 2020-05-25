using System;

namespace CleanClode.CodigoSujo
{
    public static class VendCervPilLag
    {
        public static decimal VdCerv(int tpCerv, decimal prcPilUn, decimal prcLagUn, int qt)
        {
            if (tpCerv == 1)
                return qt * prcPilUn;

            else if (tpCerv == 2)
                return qt * prcLagUn;
            else
                throw new Exception("Informe um tipo de cerveja");
        }
    }
}
