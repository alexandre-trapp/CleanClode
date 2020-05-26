using System;
using LogisticaCerveja.Validate;

namespace LogisticaCerveja
{
    public class CervejaLagger : Cerveja
    {
        public CervejaLagger(MateriaPrima materiaPrima)
        {
            if (!ValidacaoMateriaPrima
                .MateriaPrimaCervejaContemElementosNecessarios(materiaPrima))
            {
                throw new OperationCanceledException("Não é possível fabricar cerveja lagger sem os elementos necessários");
            }

            ValorUnitario = 5.00m;
            TipoCerveja = TipoCerveja.Lagger;
            HorasDeFermentacao = 48;
        }
    }
}
