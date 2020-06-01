namespace CleanClode.DRY
{
    public static class ValidacaoNumero
    {
        public const string NUMEROINVALIDO = "um numero deve ser informado";

        public static bool NumeroValido(double? number)
        {
            return number != null;
        }
    }
}
