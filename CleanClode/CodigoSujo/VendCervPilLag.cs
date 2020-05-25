using System;

namespace CleanClode.CodigoSujo
{
    public static class VendCervPilLag
    {
        /// <summary>
        /// Função que vende as cervejas
        /// por tipo, preço unitario e quantidade
        /// com os tipos pilsen e lagger, retornando 
        /// o valor da venda através da multiplicação
        /// do preço unitário * quantidade
        /// </summary>
        /// <param name="tpCerv"></param>
        /// <param name="prcPilUn"></param>
        /// <param name="prcLagUn"></param>
        /// <param name="qt"></param>
        /// <returns></returns>
        public static decimal VdCerv(int tpCerv, decimal prcPilUn, decimal prcLagUn, int qt)
        {
            decimal result = 0;

            if (tpCerv == 1)
            {
                if (qt >= 10)
                    result = (qt * prcPilUn) - (((qt * prcPilUn)/100)*30);
                else
                    result = qt * prcPilUn;
            }
            else if (tpCerv == 2)
            {
                if (qt >= 10)
                    result = (qt * prcLagUn) - (((qt * prcLagUn) / 100) * 30);
                else
                    result = qt * prcLagUn;
            }
            else
                throw new Exception("Informe um tipo de cerveja");

            return result;
        }
    }
}
