
using TesteHepta.Pattern;

namespace TestTesteHepta
{
    public class UnitTest1
    {
        [Fact]
        public void TesteGammaReturnsResult22()
        {
            string[] diagnosticReport = {
            "00100", "11110", "10110", "10111", "10101",
            "01111", "00111", "11100", "10000", "11001",
            "00010", "01010"
            };

            int gammaResult = new GammaRateCalculator().CalculateRate(diagnosticReport);

            Assert.Equal(22, gammaResult);
        }

        [Fact]
        public void TesteEpsilonReturnsResult9()
        {
            string[] diagnosticReport = {
            "00100", "11110", "10110", "10111", "10101",
            "01111", "00111", "11100", "10000", "11001",
            "00010", "01010"
            };

            int epsilonResult = new EpsilonRateCalculator().CalculateRate(diagnosticReport);

            Assert.Equal(9, epsilonResult);
        }
    }
}