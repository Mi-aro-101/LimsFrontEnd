using LimsFrontEnd.Models.Outillage;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;
using LimsUtils.Api;
using System.Text.Json;

namespace LimsFrontEnd.Pages.Outillage
{
    public class CUBaseOutillageComponent : ComponentBase
    {
        [Inject]
        protected HttpClient? Http { get; set; }

        [Inject]
        protected NavigationManager? NavigationManager { get; set; }

        public async Task<ICollection<MarqueDto>> LoadMarques()
        {
            try
            {
                var apiResponse = await Http.GetFromJsonAsync<ApiResponse>("http://localhost:5077/api/marque-outillage");
                if (apiResponse != null && apiResponse.IsSuccess && apiResponse.Data != null)
                {
                    var jsonData = apiResponse.Data.ToString();
                    var marques = JsonSerializer.Deserialize<ICollection<MarqueDto>>(jsonData, new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
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