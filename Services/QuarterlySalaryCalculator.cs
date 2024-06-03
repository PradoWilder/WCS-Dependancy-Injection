namespace Example.Services
{
    public class QuarterlySalaryCalculator : ISalaryCalculator
    {
        public double CalculateSalary(double yearlyAmount)
        {
            return yearlyAmount / 4;
        }
    }
}
