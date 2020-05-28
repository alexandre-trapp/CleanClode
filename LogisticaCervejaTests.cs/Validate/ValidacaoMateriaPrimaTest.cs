using LogisticaCerveja;
using LogisticaCerveja.Validate;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LogisticaCervejaTests.cs.Validate
{
    [TestClass]
    public class ValidacaoMateriaPrimaTest
    {
        private MateriaPrima _materiaPrima;

        [TestInitialize]
        public void setup()
        {
            _materiaPrima = new MateriaPrima
            {
                Agua = true,
                Fermento = true,
                Lupulo = true,
                MalteCevada = true
            };
        }

        [TestMethod]
        public void retornar_true_se_conter_todas_as_materias_primas()
        {
            // action
            var contem = ValidacaoMateriaPrima
                .MateriaPrimaCervejaContemElementosNecessarios(_materiaPrima);

            // verify
            Assert.IsTrue(contem);
        }

        [TestMethod]
        public void retornar_false_se_nao_conter_todas_as_materias_primas_necessarias()
        {
            // prepare
            _materiaPrima.MalteCevada = false;

            // action
            var contem = ValidacaoMateriaPrima.MateriaPrimaCervejaContemElementosNecessarios(_materiaPrima);

            // verify
            Assert.IsFalse(contem);
        }
    }
}
