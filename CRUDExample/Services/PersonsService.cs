using System;
using Entities;
using ServiceContracts.DTO;
using ServiceContracts;
using System.ComponentModel.DataAnnotations;
using Services.Helpers;

namespace Services
{
    public class PersonsService : IPersonsService
    {
        private readonly List<Person> _persons;

        public PersonsService(bool initialize = true) {
            _persons = new List<Person>();
            if (initialize) 
            {
                _persons.AddRange(new List<Person>() 
                { 
                    new Person() { PersonId = Guid.Parse("9FC78A14-B106-4AA5-B92D-BD0294414576"),
                                                         PersonName = "Dotti",
                                                         PersonEmail = "dmorrieson0@etsy.com",
                                                         Gender = "Female",
                                                         Address = "PO Box 72805",
                                                         DateOfBirth = DateTime.Parse("2024-02-09"),
                                                         ReceivedNewsLetters = true},

                    new Person() { PersonId = Guid.Parse("BF12BD6E-3C25-4467-BBFC-3FE2CE0BE1AD"),
                                                         PersonName = "Laughton",
                                                         PersonEmail = "llawerence1@amazon.co.jp",
                                                         Gender = "Male",
                                                         Address = "13th Floor",
                                                         DateOfBirth = DateTime.Parse("2024-07-28"),
                                                         ReceivedNewsLetters = false},

                    new Person() { PersonId = Guid.Parse("F64EC655-465C-4959-A437-59939505EA26"),
                                                         PersonName = "Wallie",
                                                         PersonEmail = "wscougal2@usgs.gov",
                                                         Gender = "Female",
                                                         Address = "Apt 686",
                                                         DateOfBirth = DateTime.Parse("2023-11-28"),
                                                         ReceivedNewsLetters = true}
                } );
            }
        } 
        public PersonResponse AddPerson(PersonAddRequest? request)
        {
            if (request == null) throw new ArgumentNullException(nameof(PersonAddRequest));

            //if(string.IsNullOrEmpty(request.PersonName))
            //{
            //    throw new ArgumentNullException(nameof(request.PersonName));
            //}

            //model validation
            ValidationHelper.ModelValidation(request);

            Person person = request.ToPerson();

            person.PersonId = Guid.NewGuid();

            _persons.Add(person);

            return person.ToPersonResponse();
        }

        public List<PersonResponse> GetFilteredPersons(string searchBy, string? searchString)
        {
            List<PersonResponse> allPersons = GetPersonsList();
            List<PersonResponse> matchingPersons = allPersons;

            if(string.IsNullOrEmpty(searchBy)) return matchingPersons;

            switch (searchBy) 
            {
                case nameof(PersonResponse.PersonName):
                    matchingPersons = allPersons.Where(temp => 
                    (!string.IsNullOrEmpty(temp.PersonName) ? temp.PersonName
                    .Contains(searchString, StringComparison.OrdinalIgnoreCase) : true)).ToList();
                    break;

                case nameof(PersonResponse.PersonEmail):
                    matchingPersons = allPersons.Where(temp =>
                    (!string.IsNullOrEmpty(temp.PersonEmail) ? temp.PersonEmail
                    .Contains(searchString, StringComparison.OrdinalIgnoreCase) : true)).ToList();
                    break;

                case nameof(PersonResponse.Address):
                    matchingPersons = allPersons.Where(temp =>
                    (!string.IsNullOrEmpty(temp.Address) ? temp.Address
                    .Contains(searchString, StringComparison.OrdinalIgnoreCase) : true)).ToList();
                    break;

                default:
                    return matchingPersons = allPersons;
            }

            return matchingPersons;

        }

        public PersonResponse GetPersonByPersonId(Guid? personId)
        {
            if (personId == null) { return null; }

            Person? person = _persons.FirstOrDefault(temp => temp.PersonId == personId);

            if (person == null)
            {
                return null;
            }

            return person.ToPersonResponse();
        }

        public List<PersonResponse> GetPersonsList()
        {
            return _persons.Select(person => person.ToPersonResponse()).ToList();
        }
    }
}
