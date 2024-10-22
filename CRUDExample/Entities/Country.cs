using System.ComponentModel.DataAnnotations;

namespace Entities
{
    /// <summary>
    /// Domain Model for Storing Country Details
    /// </summary>
    public class Country
    {
        [Key]
        public Guid CountryId { get; set; }

        public string? CountryName { get; set; }
    }
}
