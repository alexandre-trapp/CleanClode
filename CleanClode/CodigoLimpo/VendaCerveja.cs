namespace CleanClode.CodigoLimpo
{
    public class VendaCerveja : IVendaCerveja
    {
        private readonly Cerveja _cerveja;

        public VendaCerveja(Cerveja cerveja)
        {
            _cerveja = cerveja;
        }

        public decimal CalcularValorVendaCervejaPorQuantidade(int quantidade)
        {
            return _cerveja.ValorUnitario * quantidade;
        }
    }
}
