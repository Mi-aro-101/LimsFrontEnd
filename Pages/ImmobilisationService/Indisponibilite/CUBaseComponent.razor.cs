using LimsFrontEnd.Models.Immobilisation;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;
using LimsUtils.Api;
using System.Text.Json;

namespace LimsFrontEnd.Pages.Indisponibilite
{
    public class CUBaseIndisponibiliteComponent : ComponentBase
    {
        [Inject]
        protected HttpClient? Http { get; set; }

        [Inject]
        protected NavigationManager? NavigationManager { get; set; }

        public async Task<ICollection<ImmobilisationImmatriculationDto>> LoadImmobilisationsImmatriculees()
        {
            try
            {
                var apiResponse = await Http.GetFromJsonAsync<ApiResponse>("http://localhost:5077/api/immobilisation-immatriculations");
                if (apiResponse != null && apiResponse.IsSuccess && apiResponse.Data != null)
                {
                    var jsonData = apiResponse.Data.ToString();
                    return JsonSerializer.Deserialize<ICollection<ImmobilisationImmatriculationDto>>(jsonData, new JsonSerializerOptions { PropertyNameCaseInsensitive = true }) ?? new List<ImmobilisationImmatriculationDto>();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur lors du chargement des immobilisations immatriculées : {ex.Message}");
            }
            return new List<ImmobilisationImmatriculationDto>();
        }

        public async Task<ICollection<ObjetIndisponibiliteDto>> LoadObjetsIndisponibilite()
        {
            try
            {
                var apiResponse = await Http.GetFromJsonAsync<ApiResponse>("http://localhost:5077/api/objets-indisponibilite");
                if (apiResponse != null && apiResponse.IsSuccess && apiResponse.Data != null)
                {
                    var jsonData = apiResponse.Data.ToString();
                    return JsonSerializer.Deserialize<ICollection<ObjetIndisponibiliteDto>>(jsonData, new JsonSerializerOptions { PropertyNameCaseInsensitive = true }) ?? new List<ObjetIndisponibiliteDto>();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur lors du chargement des objets d'indisponibilité : {ex.Message}");
            }
            return new List<ObjetIndisponibiliteDto>();
        }
    }
}