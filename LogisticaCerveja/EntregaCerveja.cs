using System;

namespace LogisticaCerveja
{
    public class EntregaCerveja
    {
        public bool _entregue { get; private set; }
        public TransporteCerveja _transporteCerveja { get; private set; }

        public EntregaCerveja(TransporteCerveja transporteCerveja)
        {
            _transporteCerveja = transporteCerveja;
        }

        public void Entregar()
        {
            _entregue = true;
            
            InformarEntrega();
        }

        private void InformarEntrega()
        {
            Console.WriteLine($"--> Cervejas entregues ao PDV {_transporteCerveja._pdvDestino} com sucesso.");
        }
    }
}
