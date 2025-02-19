using Microsoft.AspNetCore.Mvc;
using TesteHepta.Services;

namespace TesteHepta.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DignosesController : ControllerBase
    {
        private readonly IDiagnosesService _service;

        public DignosesController(IDiagnosesService service)
        {
            _service = service;
        }

        /// <summary>
        /// This endpoint receives an array of string
        /// </summary>
        /// <param name="values">An array of strings. example: ["01000", "00111", "11000"]</param>
        /// <returns>An int with the value of calculation</returns>
        [HttpPost("runDiagnoses")]
        public ActionResult RunDiagnoses([FromBody] string[] values)
        {
            var res = _service.RunDiagnoses(values);
            return Ok(res);
        }
    }
}
