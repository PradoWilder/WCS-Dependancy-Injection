using Example.Services;
using Microsoft.AspNetCore.Mvc;

namespace Example.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalaryController : ControllerBase
    {
        private readonly ISalaryCalculator _calculator;

        public SalaryController(ISalaryCalculator calculator)
        {
            _calculator = calculator;
        }

        [HttpGet("{yearlyAmount}")]
        public IActionResult Get(double yearlyAmount)
        {
            double calculatedSalary = _calculator.CalculateSalary(yearlyAmount);
            return Ok(calculatedSalary);
        }
    }
}
