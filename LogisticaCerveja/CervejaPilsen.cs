using System;
using LogisticaCerveja.Validate;

namespace LogisticaCerveja
{
    public class CervejaPilsen : Cerveja
    {
        public CervejaPilsen(MateriaPrima materiaPrima)
        {
            if (!ValidacaoMateriaPrima
                .MateriaPrimaCervejaContemElementosNecessarios(materiaPrima))
            {
                throw new OperationCanceledException("Não é possível fabricar cerveja sem os elementos necessários");
            }

            ValorUnitario = 3.50m;
            TipoCerveja = TipoCerveja.Pilsen;
            HorasDeFermentacao = 12;
        }        
    }
}
