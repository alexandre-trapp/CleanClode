namespace LogisticaCerveja.Validate
{
    public static class ValidacaoMateriaPrima
    {
        public static bool MateriaPrimaCervejaContemElementosNecessarios(MateriaPrima materiaPrima)
        {
            return materiaPrima.MalteCevada && materiaPrima.Agua &&
                   materiaPrima.Fermento && materiaPrima.Lupulo;
        }
    }
}
