namespace ConceptsPOO
{
    public class CommissionEmployee : Employee
    {
        public float CommisionPercentaje { get; set; }
        public decimal Sales { get; set; }

        public override decimal GetValuetoPay()
        {
            return Sales * (decimal)CommisionPercentaje;
        }
        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n\tCommission Percentaje: {$"{CommisionPercentaje:p2}", 18}" +
                $"\n\tSales----------------: {$"{Sales:c2}", 18}" +
                $"\n\tvalue to pay---------: {$"{GetValuetoPay():c2}", 18}";
        }
    }
}
