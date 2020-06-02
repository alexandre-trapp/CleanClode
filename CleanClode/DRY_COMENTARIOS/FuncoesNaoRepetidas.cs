namespace CleanClode.DRY
{
    public class FuncoesNaoRepetidas
    {
        public string VerificarSeNumeroEPar(double? number)
        {
            if (!ValidacaoNumero.NumeroValido(number))
                return ValidacaoNumero.NUMEROINVALIDO;

            if (number % 2 == 0)
                return $"Número {number} é par";
            else
                return $"Númeto {number} é impar";
        }

        public string VerificarSeNumeroEMaiorQue10(double? number)
        {
            if (!ValidacaoNumero.NumeroValido(number))
                return ValidacaoNumero.NUMEROINVALIDO;

            if (number > 10)
                return $"Número {number} é maior que 10";
            else
                return $"Númeto {number} é menor ou igual a 10";
        }
    }
}
