using System;
using ServiceContracts.DTO;

namespace ServiceContracts
{
    public interface IPersonsService
    {
        /// <summary>
        /// Adds a new person to the list of persons
        /// </summary>
        /// <param name="request"> person to add </param>
        /// <returns>returns a Person response with the given details</returns>
        PersonResponse AddPerson(PersonAddRequest? request);

        /// <summary>
        /// returns all person from the list
        /// </summary>
        /// <returns>returns a list of person response object</returns>
        List<PersonResponse> GetPersonsList();

        /// <summary>
        /// Gets the personResponse Object using Person ID
        /// </summary>
        /// <param name="personId">Person Id of Person you want to find</param>
        /// <returns>returns the matching Person object</returns>
        PersonResponse GetPersonByPersonId(Guid? personId);

        /// <summary>
        /// filters the personlist by the given parameters
        /// </summary>
        /// <param name="searchBy">searchby entity attribute name</param>
        /// <param name="searchString">searchstring string to search the given searchby parameter</param>
        /// <returns>returns list of filtered person response</returns>
        List<PersonResponse> GetFilteredPersons(string searchBy, string? searchString);

    }
}
