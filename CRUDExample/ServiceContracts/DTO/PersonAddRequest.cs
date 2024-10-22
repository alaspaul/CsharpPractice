using System;
using ServiceContracts.Enums;
using Entities;
using System.ComponentModel.DataAnnotations;


namespace ServiceContracts.DTO
{
    /// <summary>
    /// acts as DTO for inserting a new person
    /// </summary>
    public class PersonAddRequest
    {
        [Required(ErrorMessage = "person name is required")]
        public string? PersonName { get; set; }

        public string? PersonEmail { get; set; }

        public GenderOptions? Gender { get; set; }

        public string? Address { get; set; }

        public Guid? CountryId { get; set; }

        public DateTime DateOfBirth { get; set; }

        public bool ReceivedNewsLetters { get; set; }

        /// <summary>
        /// converts personaddRequest to person object
        /// </summary>
        /// <returns>returns the person object created</returns>
        public Person ToPerson()
        {
            return new Person()
            {
                PersonName = PersonName,
                PersonEmail = PersonEmail,
                Gender = Gender.ToString(),
                Address = Address,
                CountryId = CountryId,
                DateOfBirth = DateOfBirth,
                ReceivedNewsLetters = ReceivedNewsLetters
            };
        }
    }
}
