using ServiceContracts;
using System;
using System.Collections.Generic;
using Entities;
using ServiceContracts.DTO;
using Services;

namespace CRUDTests
{
    public class CountriesServiceTest
    {
        private readonly ICountriesService _countriesService;

        public CountriesServiceTest()
        {
            _countriesService = new CountriesService(false);
        }

        #region AddCountry
        //When CountryAddRequest is null, it should ArgumentNullException

        [Fact]
        public void AddCountry_NullCountry()
        {
            //Arrange
            CountryAddRequest? request = null;

            //assert
            Assert.Throws<ArgumentNullException>(() =>
            {
                //act
                _countriesService.AddCountry(request);
            });
        }

        //when the CountryName is null, ut should throw argument exception

        [Fact]
        public void AddCountry_CountryNameIsNull()
        {
            //arrrange
            CountryAddRequest? request = new CountryAddRequest()
            {
                CountryName = null,
            };

            //assert
            Assert.Throws<ArgumentNullException>(() =>
            {
                //act
                _countriesService.AddCountry(request);
            });
        }


        //when the countryName is duplicate, it should throw argumentexception


        [Fact]
        public void AddCountry_DuplicateCountryName()
        {
            //arrrange
            CountryAddRequest? request1 = new CountryAddRequest()
            {
                CountryName = "USA",
            };
            CountryAddRequest? request2= new CountryAddRequest()
            {
                CountryName = "USA",
            };

            //assert
            Assert.Throws<ArgumentException>(() =>
            {
                //act
                _countriesService.AddCountry(request1);
                _countriesService.AddCountry(request2);
            });
        }

        //when you supply proper country name, it should insert(add) the country to the existing list of countries

        [Fact]
        public void AddCountry_ProperCountryDetails()
        {
            //arrrange
            CountryAddRequest? request = new CountryAddRequest()
            {
                CountryName = "Japan",
            };

            //act
            CountryResponse response = _countriesService.AddCountry(request);
            List<CountryResponse> countries = _countriesService.GetAllCountries();

            //assert
            Assert.True(response.CountryID != Guid.Empty);
            //equals method needs to be overridden because it doesnt compare actual values but references only
            //compares response an object to a collection of those responses which is equal to false as they are not the same
            Assert.Contains(response, countries);
        }

        #endregion

        #region GetAllCountries

        [Fact]
        public void GetAllCountries_EmptyList()
        {
            //act
            List<CountryResponse> countries = _countriesService.GetAllCountries();


            //assert
            Assert.Empty(countries);
        }

        [Fact]


        public void GetAllCountries_AddFewCountries()
        {
            List<CountryAddRequest> countries = new List<CountryAddRequest>() { 
                new CountryAddRequest(){CountryName = "USA"},
                new CountryAddRequest(){CountryName = "Japan"},
                new CountryAddRequest(){CountryName = "UK"},
            };
            //act
            List<CountryResponse> response = new List<CountryResponse>();
            foreach(CountryAddRequest country in countries)
            {
                response.Add(_countriesService.AddCountry(country));

            }

            List<CountryResponse> actualCountries = _countriesService.GetAllCountries();

            //read each element from response countries

            foreach(CountryResponse expectedCountry in response)
            {
                //finds the expected country in actual countries received
                Assert.Contains(expectedCountry, actualCountries);
            }


        }
        #endregion

        #region GetCountryByCountryId

        [Fact]
        public void GetCountryByCountryId_NullCountryId()
        {
            //arrange
            Guid? countryId = null;

            //act
            CountryResponse? response = _countriesService.GetCountryByCountryId(countryId);

            //assert
            Assert.Null(response);
        }

        [Fact]
        public void GetCountryByCountryId_ValidCountryId()
        {
            //arrange
            CountryAddRequest countryAddRequest = new CountryAddRequest() { 
                CountryName = "USA"
            };

            CountryResponse countryResponse = _countriesService.AddCountry(countryAddRequest);

            //act

            CountryResponse? actualCountryResponse = _countriesService.GetCountryByCountryId(countryResponse.CountryID);

            //assert
            Assert.Equal(countryResponse,actualCountryResponse);
        }
        #endregion
    }
}
