using ServiceContracts;
using System;
using Xunit;
using Entities;
using ServiceContracts.DTO;
using ServiceContracts;
using Services;
using ServiceContracts.Enums;
using Xunit.Abstractions;

namespace CRUDTests
{
    public class PersonsServiceTest
    {
        private readonly IPersonsService _personsService;
        private readonly ITestOutputHelper _testOutputHelper;

        public PersonsServiceTest(ITestOutputHelper testOutputHelper) 
        {
            _personsService = new PersonsService(false); 
            _testOutputHelper = testOutputHelper;
        }

        #region AddPerson

        //when we supply null value as personaddrequest throw argumentnullexception
        [Fact]
        public void AddPerson_NullPerson()
        {
            //arrange 
            PersonAddRequest request = null;


            //assert
            Assert.Throws<ArgumentNullException>(() => 
            {
                _personsService.AddPerson(request);
            });

        }

        // supply null name
        [Fact]
        public void AddPerson_PersonNameIsNull() 
        {
            PersonAddRequest request = new PersonAddRequest()
            {
                PersonName = null
            };

            Assert.Throws<ArgumentException>(() =>
            {
                _personsService.AddPerson(request);
            });
        }

        // supply proper person details
        [Fact]
        public void AddPerson_ValidPerson() 
        {
            //arrange
            PersonAddRequest request = new PersonAddRequest()
            {
                PersonName = "paul",
                PersonEmail = "paul@mail.com",
                Address = "asdasdasd",
                CountryId = Guid.NewGuid(),
                Gender = GenderOptions.Male,
                DateOfBirth = DateTime.Parse("2000-01-01"),
                ReceivedNewsLetters = true,
            };

            //act
            PersonResponse personResponse = _personsService.AddPerson(request);
            List<PersonResponse> allPerson = _personsService.GetPersonsList();

            //assert
            Assert.True(personResponse.PersonId != Guid.Empty);
            Assert.Contains(personResponse,allPerson);
        }

        #endregion


        #region GetPersonByPersonId

        [Fact]
        public void GetPersonByPersonId_NullPersonId()
        {
            Guid? personId = null;

            PersonResponse? personResponse = _personsService.GetPersonByPersonId(personId);

            Assert.Null(personResponse);
        }

        [Fact]
        public void GetPersonByPersonId_ValidPersonId()
        {
            PersonAddRequest personAddRequest = new PersonAddRequest()
            {
                PersonName = "name"
            };

            PersonResponse personResponse = _personsService.AddPerson(personAddRequest);

            PersonResponse actualPersonResponse = _personsService.GetPersonByPersonId(personResponse.PersonId);

            Assert.Equal(personResponse, actualPersonResponse);
        }

        #endregion


        #region GetPersonList

        [Fact]
        public void GetPersonsList_NullPersonsList()
        {
            List<PersonResponse> personList = _personsService.GetPersonsList();

            Assert.Empty(personList);
        }


        [Fact]
        public void GetPersonsList_AddFewPersonsList()
        {
            List<PersonResponse> ListofPersonResponse = new List<PersonResponse>();
            List<PersonAddRequest> personAddRequests = new List<PersonAddRequest>()
            {
                new PersonAddRequest{ PersonName = "name1" },
                new PersonAddRequest{ PersonName = "name2" }
            };

            foreach(PersonAddRequest person in personAddRequests)
            {
                ListofPersonResponse.Add(_personsService.AddPerson(person));
            }

            List<PersonResponse> actualListofPersonResponse = _personsService.GetPersonsList();

            //print expected
            _testOutputHelper.WriteLine("Expected:");
            foreach (PersonResponse personResponse in ListofPersonResponse)
            {
                _testOutputHelper.WriteLine(personResponse.ToString()); 
            }

            //print Actual
            _testOutputHelper.WriteLine("Actual:");
            foreach (PersonResponse personResponse in actualListofPersonResponse)
            {
                _testOutputHelper.WriteLine(personResponse.ToString());
            }


            foreach (PersonResponse personResponse in ListofPersonResponse) 
            {
                Assert.Contains(personResponse, actualListofPersonResponse);
            }
        }
        #endregion


        #region GetFilteredPersons

        [Fact]
        public void GetFilteredPersons_EmptyPersonNameString()
        {
            List<PersonResponse> ListofPersonResponse = new List<PersonResponse>();
            List<PersonAddRequest> personAddRequests = new List<PersonAddRequest>()
            {
                new PersonAddRequest{ PersonName = "name1" },
                new PersonAddRequest{ PersonName = "name2" }
            };

            foreach (PersonAddRequest person in personAddRequests)
            {
                ListofPersonResponse.Add(_personsService.AddPerson(person));
            }

            List<PersonResponse> actualFilteredListofPersonResponse = _personsService.GetFilteredPersons(nameof(Person.PersonName),"");

            //print expected
            _testOutputHelper.WriteLine("Expected:");
            foreach (PersonResponse personResponse in ListofPersonResponse)
            {
                _testOutputHelper.WriteLine(personResponse.ToString());
            }

            //print Actual
            _testOutputHelper.WriteLine("Actual:");
            foreach (PersonResponse personResponse in actualFilteredListofPersonResponse)
            {
                _testOutputHelper.WriteLine(personResponse.ToString());
            }


            foreach (PersonResponse personResponse in ListofPersonResponse)
            {
                Assert.Contains(personResponse, actualFilteredListofPersonResponse);
            }
        }


        [Fact]
        public void GetFilteredPersons_SearchByPersonName()
        {
            List<PersonResponse> ListofPersonResponse = new List<PersonResponse>();
            List<PersonAddRequest> personAddRequests = new List<PersonAddRequest>()
            {
                new PersonAddRequest{ PersonName = "Paul" },
                new PersonAddRequest{ PersonName = "Steven" },
                new PersonAddRequest{ PersonName = "abstergus" }
            };

            foreach (PersonAddRequest person in personAddRequests)
            {
                ListofPersonResponse.Add(_personsService.AddPerson(person));
            }

            List<PersonResponse> actualFilteredListofPersonResponse = _personsService.GetFilteredPersons(nameof(Person.PersonName), "ste");

            //print Actual
            _testOutputHelper.WriteLine("Actual:");
            foreach (PersonResponse personResponse in actualFilteredListofPersonResponse)
            {
                _testOutputHelper.WriteLine(personResponse.ToString());
            }


            foreach (PersonResponse personResponse in ListofPersonResponse)
            {
                if(personResponse.PersonName != null) 
                {
                    if (personResponse.PersonName.Contains("ste", StringComparison.OrdinalIgnoreCase))
                    {
                        Assert.Contains(personResponse, actualFilteredListofPersonResponse);
                    }
                }

            }
        }

        #endregion
    }
}
