namespace FirstAPI.Models
{
    public class Employee : IComparable<Employee>
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Role { get; set; }

        public int CompareTo(Employee? other)
        {
            return this.Id.CompareTo(other.Id);
        }
    }
}
