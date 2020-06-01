namespace CleanClode.DRY
{
    public class FuncoesRepetidas
    {
        public string VerificarSeNumeroEPar(double? number)
        {
            if (number != null)
            {
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
            if (number != null)
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
