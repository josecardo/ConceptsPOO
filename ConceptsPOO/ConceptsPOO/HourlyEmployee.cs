namespace ConceptsPOO
{
    public class HourlyEmployee : Employee
    {
        public float Hours { get; set; }
        public decimal HourValue { get; set; }
        public override decimal GetValuetoPay()
        {
            return (decimal)Hours * HourValue;
        }
        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n\tHours----------------: {$"{Hours:n2}",18}" +
                $"\n\tHourValue------------: {$"{HourValue:c2}",18}" +
                $"\n\tvalue to pay---------: {$"{GetValuetoPay():c2}",18}";
        }
    }
}
