namespace CleanClode.DRY
{
    public class FuncoesRepetidas
    {
        /// <summary>
        /// aqui que a mágica acontece
        /// </summary>
        /// <param name="number">número que será verificado se é par</param>
        /// <returns></returns>
        public string VerificarSeNumeroEPar(double? number)
        {
            // verifica se é diferente de nulo e maior ou igual a zero
            if (number != null && number >= 0)
            {
                // verifica se numero dividido por 2 o resto for zero, é par
                if (number % 2 == 0)
                    return $"Número {number} é par";
                else
                    return $"Númeto {number} é impar";
            }
            else
                return "um numero deve ser informado";
        }

        public string VerificarSeNumeroEMaiorQue10(double? number)
        {
            if (number != null && number >= 0)
            {
                if (number > 10)
                    return $"Número {number} é maior que 10";
                else
                    return $"Númeto {number} é menor ou igual a 10";
            }

            return string.Empty;
        }
    }
}
