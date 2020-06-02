using System;
using Microsoft.Extensions.Logging;

namespace CleanClode.TratamentoErros
{
    public class TratamentoCorreto
    {
        private readonly ILogger _logger;

        public TratamentoCorreto(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger("TratamentoCorreto");
        }

        public void MetodoPrimeiro(DateTime? dataQuePodeSerNula)
        {
            try
            {
                ExibirDataFormatada(dataQuePodeSerNula);
            }
            catch (Exception e)
            {
                _logger.LogError($"Erro no método primeiro: Detalhes completos {e}");
                Console.WriteLine($"ronaldo - Erro ao efetuar o método primeiro: {e.Message}");
            }
        }

        private void ExibirDataFormatada(DateTime? dataQuePodeSerNula)
        {
            Console.WriteLine(dataQuePodeSerNula.Value.ToString("dd/MM/yyyy"));
        }
    }
}
