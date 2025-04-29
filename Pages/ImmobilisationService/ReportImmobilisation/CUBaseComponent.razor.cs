using LimsFrontEnd.Models.Immobilisation;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;
using LimsUtils.Api;
using System.Text.Json;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LimsFrontEnd.Pages.ReportImmobilisation
{
    public class CUBaseComponent : ComponentBase
    {
        [Inject]
        protected HttpClient? Http { get; set; }

        [Inject]
        protected NavigationManager? NavigationManager { get; set; }

        protected async Task<ICollection<ImmobilisationDto>> LoadImmobilisations()
        {
            try
            {
                var apiResponse = await Http.GetFromJsonAsync<ApiResponse>("http://localhost:5077/api/immobilisation");
                if (apiResponse is { IsSuccess: true, Data: not null })
                {
                    return JsonSerializer.Deserialize<ICollection<ImmobilisationDto>>(
                        apiResponse.Data.ToString(),
                        new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
                    ) ?? new List<ImmobilisationDto>();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur lors du chargement des immobilisations : {ex.Message}");
            }
            return new List<ImmobilisationDto>();
        }
    }
}