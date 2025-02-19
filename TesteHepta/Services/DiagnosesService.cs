
using TesteHepta.Pattern;

namespace TesteHepta.Services
{
    public class DiagnosesService : IDiagnosesService
    {
        public int RunDiagnoses(string[] arrayBinaries)
        {
            var gammaResult = new GammaRateCalculator().CalculateRate(arrayBinaries);

            var epsilonResul = new EpsilonRateCalculator().CalculateRate(arrayBinaries);

            return  gammaResult * epsilonResul;
        }
    }
}
