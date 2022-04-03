namespace ConceptsPOO
{
    public class Invoice : IPay
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int MyProperty { get; set; }
        public float Quantity { get; set; }
        public decimal Price { get; set; }

        public decimal GetValuetoPay()
        {
            return Price * (decimal)Quantity;
        }

        public override string ToString()
        {
            return $"{Id} - { Description}" +
                $"\n\tQuantity............{$"{Quantity:n2}",18}" +
                $"\n\tPrice...............{$"{Price:c2}",18}" +
                $"\n\tValue...............{$"{GetValuetoPay():c2}",18}";
        }
    }
}
