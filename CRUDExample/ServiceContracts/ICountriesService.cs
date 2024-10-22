using ServiceContracts.DTO;

namespace ServiceContracts
{
    /// <summary>
    /// Represents business logic for manipulating Country Entity
    /// </summary>
    public interface ICountriesService
    {
        /// <summary>
        /// adds a country object to the list of countries
        /// </summary>
        /// <param name="countryAddRequest">Country object to add</param>
        /// <returns>Returns the country object after adding it (including newly generated countryid)</returns>
        CountryResponse AddCountry(CountryAddRequest? countryAddRequest);

        /// <summary>
        /// Returns all Countries from the list
        /// </summary>
        /// <returns>returns all countries as a list of countryresponse</returns>
        List<CountryResponse> GetAllCountries();

        /// <summary>
        /// Gets a countryresponse object using parameter CountryId
        /// </summary>
        /// <param name="countryId"></param>
        /// <returns>returns the matching countryResponse object</returns>
        CountryResponse? GetCountryByCountryId(Guid? countryId);
    }
}
