namespace ConceptsPOO
{
    public class BaseCommissionEmployee : CommissionEmployee
    {
        public decimal Base { get; set; }

        public override decimal GetValuetoPay()
        {
            return base.GetValuetoPay() + Base;
        }
        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n\tBase-----------------: {$"{Base:c2}",18}";
        }
    }
}
