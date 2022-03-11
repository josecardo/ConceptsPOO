namespace ConceptsPOO
{
    public class SalaryEmployee : Employee
    {
        public decimal salary { get; set; }

        public override decimal GetValuetoPay()
        {
            return salary;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n\tvalue to pay---------: {$"{GetValuetoPay():c2}", 18}";
        }
    }
}
