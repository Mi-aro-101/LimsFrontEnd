using LimsFrontEnd.Models.Immobilisation;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;
using LimsFrontEnd.Models;
using LimsUtils.Api;
using System.Text.Json;

namespace LimsFrontEnd.Pages.Immobilisation
{
    public class CUBaseImmobilisationComponent : ComponentBase
    {
        [Inject]
        protected HttpClient? Http { get; set; }

        [Inject]
        protected NavigationManager? NavigationManager { get; set; }

        public async Task<ICollection<MarqueDto>> LoadMarques()
        {
            try
            {
                var apiResponse = await Http.GetFromJsonAsync<ApiResponse>("http://localhost:5077/api/marque");
                if (apiResponse != null && apiResponse.IsSuccess && apiResponse.Data != null)
                {
                    // On désérialise la propriété Data en collection de MarqueDto
                    var jsonData = apiResponse.Data.ToString();
                    var marques = JsonSerializer.Deserialize<ICollection<MarqueDto>>(jsonData, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                    return marques ?? new List<MarqueDto>();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur lors du chargement des marques : {ex.Message}");
            }
            return new List<MarqueDto>();
        }


    }

}
