using ServiceContracts;
using ServiceContracts.DTO;
using Entities;

namespace Services
{
    public class CountriesService : ICountriesService
    {
        //private field
        private readonly PersonsDbContext _db;

        //Constructor
        public CountriesService(PersonsDbContext personsDbContext)
        {
            _db = personsDbContext;

        }
        public CountryResponse AddCountry(CountryAddRequest? countryAddRequest)
        {
            if (countryAddRequest == null) { 
                throw new ArgumentNullException(nameof(countryAddRequest));
            }

            if (countryAddRequest.CountryName == null) {
                throw new ArgumentNullException(nameof(countryAddRequest.CountryName));
            }

            if (_db.Countries.Where(temp => temp.CountryName == countryAddRequest.CountryName).Count() > 0)
            {
                throw new ArgumentException("Country Name already exists");
            }
            Country country = countryAddRequest.ToCountry();

            country.CountryId = Guid.NewGuid();
            _db.Add(country);


            return country.ToCountryResponse();
        }

        public List<CountryResponse> GetAllCountries()
        {
            return _db.Select(country => country.ToCountryResponse()).ToList();
        }

        public CountryResponse? GetCountryByCountryId(Guid? countryId)
        {
            if (countryId == null) { return null; }

            Country? country = _db.Countries.FirstOrDefault(temp => temp.CountryId == countryId);

            if (country == null)
            {
                return null;    
            }

            return country.ToCountryResponse();
        }
    }
}
