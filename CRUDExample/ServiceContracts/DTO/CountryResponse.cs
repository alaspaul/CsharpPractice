using System;
using Entities;

namespace ServiceContracts.DTO
{
    /// <summary>
    /// DTO class used as return type for countries service methods
    /// </summary>
    public class CountryResponse
    {
        public Guid CountryID { get; set; }

        public string? CountryName { get; set; }

        public override bool Equals(object? obj)
        {
            if (obj == null) { return false; }

            if(obj.GetType() != typeof(CountryResponse))
            {
                return false;
            }

            CountryResponse countryResponse = (CountryResponse)obj;

            return CountryID == countryResponse.CountryID && CountryName == countryResponse.CountryName;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }

    public static class CountryExtensions
    {
        /// <summary>
        /// converts country object to countryresponse object
        /// </summary>
        /// <param name="country"></param>
        /// <returns>returns countryresponse object</returns>
        public static CountryResponse ToCountryResponse(this Country country)
        {
            return new CountryResponse()
            {
                CountryID = country.CountryId,
                CountryName = country.CountryName
            };
        }
    }

}
