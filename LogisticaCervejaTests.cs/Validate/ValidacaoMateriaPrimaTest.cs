using LogisticaCerveja;
using LogisticaCerveja.Validate;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LogisticaCervejaTests.cs.Validate
{
    [TestClass]
    public class ValidacaoMateriaPrimaTest
    {
        [TestMethod]
        public void retornar_true_se_conter_todas_as_materias_primas()
        {
            // prepare
            var materiaPrima = new MateriaPrima
            {
                Agua = true,
                Fermento = true,
                Lupulo = true,
                MalteCevada = true
            };

            // action
            var contemTodasAsMateriasPrimas = ValidacaoMateriaPrima.MateriaPrimaCervejaContemElementosNecessarios(materiaPrima);

            // verify
            Assert.IsTrue(contemTodasAsMateriasPrimas);
        }

        [TestMethod]
        public void retornar_false_se_nao_conter_todas_as_materias_primas_necessarias()
        {
            // prepare
            var materiaPrima = new MateriaPrima
            {
                Agua = true,
                Fermento = true,
                Lupulo = true,
                MalteCevada = false
            };

            // action
            var contemTodasAsMateriasPrimas = ValidacaoMateriaPrima.MateriaPrimaCervejaContemElementosNecessarios(materiaPrima);

            // verify
            Assert.IsFalse(contemTodasAsMateriasPrimas);
        }
    }
}
