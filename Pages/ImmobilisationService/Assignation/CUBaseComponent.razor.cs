using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;
using LimsFrontEnd.Models.Immobilisation;
using LimsUtils.Api;
using System.Text.Json;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LimsFrontEnd.Pages.Assignation
{
    public class CUBaseComponent : ComponentBase
    {
        [Inject]
        protected HttpClient? Http { get; set; }

        [Inject]
        protected NavigationManager? NavigationManager { get; set; }

        
        

        protected async Task<List<EmployeImmobilisationDto>> LoadEmployes()
        {
            try
            {
                var apiResponse = await Http.GetFromJsonAsync<ApiResponse>("http://localhost:5077/api/employes");
                if (apiResponse is { IsSuccess: true, Data: not null })
                {
                    var jsonData = apiResponse.Data.ToString();
                    return JsonSerializer.Deserialize<List<EmployeImmobilisationDto>>(jsonData,
                        new JsonSerializerOptions { PropertyNameCaseInsensitive = true })
                        ?? new List<EmployeImmobilisationDto>();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur lors du chargement des employés : {ex.Message}");
            }
            return new List<EmployeImmobilisationDto>();
        }

        protected async Task<List<ImmobilisationImmatriculationDto>> LoadAvailableImmatriculations()
        {
            try
            {
                var apiResponse = await Http.GetFromJsonAsync<ApiResponse>("http://localhost:5077/api/immobilisation-immatriculations/non-assignees");
                if (apiResponse is { IsSuccess: true, Data: not null })
                {
                    var jsonData = apiResponse.Data.ToString();
                    return JsonSerializer.Deserialize<List<ImmobilisationImmatriculationDto>>(jsonData,
                        new JsonSerializerOptions { PropertyNameCaseInsensitive = true })
                        ?? new List<ImmobilisationImmatriculationDto>();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur lors du chargement des immatriculations disponibles : {ex.Message}");
            }
            return new List<ImmobilisationImmatriculationDto>();
        }

        protected async Task<List<LocalisationDto>> LoadLocalisations()
        {
            try
            {
                var apiResponse = await Http.GetFromJsonAsync<ApiResponse>("http://localhost:5077/api/localisations");
                if (apiResponse is { IsSuccess: true, Data: not null })
                {
                    var jsonData = apiResponse.Data.ToString();
                    return JsonSerializer.Deserialize<List<LocalisationDto>>(jsonData,
                        new JsonSerializerOptions { PropertyNameCaseInsensitive = true })
                        ?? new List<LocalisationDto>();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur lors du chargement des localisations : {ex.Message}");
            }
            return new List<LocalisationDto>();
        }
    }
}