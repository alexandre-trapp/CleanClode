using System;
using System.Collections.Generic;

namespace LogisticaCerveja
{
    public class TransporteCerveja
    {
        public bool _caminhaoCarregado { get; set;  }
        public List<Cerveja> _cervejasTransportadas { get; private set; }
        public string _pdvDestino { get; private set; }

        public TransporteCerveja(List<Cerveja> cervejasTransportadas)
        {
            _cervejasTransportadas = cervejasTransportadas;
        }

        public void Transportar(int quantidade, string pdvDestino)
        {
            if (!QuantidadeCondizComAsCervejasIncluidasParaTransporte(quantidade))
                throw new OperationCanceledException("Quantidade computada não condiz com a quantidade" +
                    "de cervejas incluídas para transporte");

            _pdvDestino = pdvDestino;
            _caminhaoCarregado = true;
            
            InformarTransporte(quantidade, pdvDestino);
        }

        private void InformarTransporte(int quantidade, string pdvDestino)
        {
            Console.WriteLine($"Caminhão carregado com {quantidade} cervejas, " +
                $"com destino ao PDV {pdvDestino}");
        }

        private bool QuantidadeCondizComAsCervejasIncluidasParaTransporte(int quantidade)
        {
            return quantidade == _cervejasTransportadas.Count;
        }
    }
}
