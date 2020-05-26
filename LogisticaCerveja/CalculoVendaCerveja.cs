namespace LogisticaCerveja
{
    public class CalculoVendaCerveja
    {
        private readonly Cerveja _cerveja;

        public CalculoVendaCerveja(Cerveja cerveja)
        {
            _cerveja = cerveja;
        }

        public decimal CalcularVenda(int quantidade)
        {
            return _cerveja.ValorUnitario * quantidade;
        }
    }
}
