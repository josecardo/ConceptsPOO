namespace ConceptsPOO
{
    public abstract class Employee
    {
        public Date BirthDate { get; set; }
        public Date HiringDate { get; set; }
        public string FirstName { get; set; }
        public string LasttName { get; set; }
        public int Id { get; set; }
        public bool IsActive { get; set; }

        public abstract decimal GetValuetoPay();

        public override string ToString()
        {
            return $"{Id} - {FirstName} {LasttName}, " +
                $"Birth: {BirthDate}, " +
                $"Hiring: {HiringDate}, " +
                $"IsActive: {IsActive}";
        }
    }
}
