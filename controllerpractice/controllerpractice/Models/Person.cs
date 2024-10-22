using System.Runtime.InteropServices;

namespace controllerpractice.Models
{
    public class Person
    {
        public Guid Id { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public int Age { get; set; }
    }
}
