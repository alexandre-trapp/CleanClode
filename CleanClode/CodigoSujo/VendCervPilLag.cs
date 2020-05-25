using System;

namespace CleanClode.CodigoSujo
{
    public static class VendCervPilLag
    {
        /// <summary>
        /// Função que vende as cervejas
        /// por tipo, preço unitario e quantidade
        /// com os tipos pilsen e lagger, retornando 
        /// o valor da venda atravé da multiplicação
        /// do preço unitário * quantidade
        /// </summary>
        /// <param name="tpCerv"></param>
        /// <param name="prcPilUn"></param>
        /// <param name="prcLagUn"></param>
        /// <param name="qt"></param>
        /// <returns></returns>
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
