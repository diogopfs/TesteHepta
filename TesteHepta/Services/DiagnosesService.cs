
using TesteHepta.Models;
using TesteHepta.Pattern;

namespace TesteHepta.Services
{
    public class DiagnosesService : IDiagnosesService
    {
        public BaseModel<int> RunDiagnoses(string[] arrayBinaries)
        {
            var gammaResult = new GammaRateCalculator().CalculateRate(arrayBinaries);

            var epsilonResul = new EpsilonRateCalculator().CalculateRate(arrayBinaries);

            var result = gammaResult * epsilonResul;

            return new BaseModel<int>(sucesso: true, "Relizado com sucesso", dados: result);
        }
    }
}
