using ServiceContracts.Enums;
using System;
using Entities;

namespace ServiceContracts.DTO
{   /// <summary>
    /// represents DTO class that is used as return for person object
    /// </summary>
    public class PersonResponse
    {
        public Guid PersonId { get; set; }
        public string? PersonName { get; set; }

        public string? PersonEmail { get; set; }

        public GenderOptions? Gender { get; set; }

        public string? Address { get; set; }

        public Guid? CountryId { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public bool ReceivedNewsLetters { get; set; }

        public double? Age { get; set; }

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;

            if(obj.GetType() != typeof(PersonResponse)) return false;

            PersonResponse person = (PersonResponse)obj;

            return PersonId == person.PersonId
              &&   PersonName == person.PersonName
              &&   PersonEmail == person.PersonEmail
              &&   Address == person.Address
              &&   Gender == person.Gender
              &&   CountryId == person.CountryId
              &&   DateOfBirth == person.DateOfBirth
              &&   ReceivedNewsLetters == person.ReceivedNewsLetters
              &&   Age == person.Age;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return $"personID: {PersonId}, PersonName: {PersonName}";
        }



    }
    public static class PersonExtensions
    {
        /// <summary>
        /// extension to convert person object to person response obj
        /// </summary>
        /// <param name="person"></param>
        /// <returns>returns the new personresponse obj</returns>
        public static PersonResponse ToPersonResponse(this Person person)
        {
            return new PersonResponse()
            {
                PersonId = person.PersonId,
                PersonName = person.PersonName,
                Address = person.Address,
                //Gender = person.Gender,
                CountryId = person.CountryId,
                DateOfBirth = person.DateOfBirth,
                ReceivedNewsLetters = person.ReceivedNewsLetters,
                PersonEmail = person.PersonEmail,
                Age = (person.DateOfBirth != null) ? Math.Round((DateTime.Now - person.DateOfBirth).TotalDays / 365.25) : null,
            };

        }
    }
}
