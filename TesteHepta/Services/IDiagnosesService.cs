using TesteHepta.Models;

namespace TesteHepta.Services
{
    public interface IDiagnosesService
    {
        public BaseModel<int> RunDiagnoses(string[] arrayBinaries);
    }
}
