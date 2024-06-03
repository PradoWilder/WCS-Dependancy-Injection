namespace Example.Services
{
    public class MonthlySalaryCalculator : ISalaryCalculator
    {
        public double CalculateSalary(double yearlyAmount)
        {
            return yearlyAmount / 12;
        }
    }
}

