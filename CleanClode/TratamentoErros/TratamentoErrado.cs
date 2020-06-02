using System;

namespace CleanClode.TratamentoErros
{
    public class TratamentoErrado
    {
        public void MetodoPrimeiro(DateTime? dataQuePodeSerNula)
        {
            try
            {
                ExibirDataFormatada(dataQuePodeSerNula);
            }
            catch (Exception e)
            {
                throw new Exception($"erro: {e.Message}");
            }
        }

        private void ExibirDataFormatada(DateTime? dataQuePodeSerNula)
        {
            try
            {
                Console.WriteLine(dataQuePodeSerNula.Value.ToString("dd/MM/yyyy"));
            }
            catch(Exception e)
            {
                throw new Exception($"erro: {e.Message}");
            }
        }
    }
}
