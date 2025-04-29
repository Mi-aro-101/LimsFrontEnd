using LimsFrontEnd.Models.Outillage;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;
using LimsUtils.Api;
using System.Text.Json;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LimsFrontEnd.Pages.EntreeOutillage
{
    public class CUBaseComponent : ComponentBase
    {
        [Inject]
        protected HttpClient? Http { get; set; }

        [Inject]
        protected NavigationManager? NavigationManager { get; set; }

        protected async Task<ICollection<OutillageDto>> LoadOutillages(string searchTerm = "")
        {
            try
            {
                var apiResponse = await Http.GetFromJsonAsync<ApiResponse>($"http://localhost:5077/api/outillages/search?searchTerm={searchTerm}");
                if (apiResponse is { IsSuccess: true, Data: not null })
                {
                    var jsonData = apiResponse.Data.ToString();
                    return JsonSerializer.Deserialize<ICollection<OutillageDto>>(jsonData, new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    }) ?? new List<OutillageDto>();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur lors du chargement des outillages : {ex.Message}");
            }
            return new List<OutillageDto>();
        }

        protected async Task<ICollection<FournisseurDto>> LoadFournisseurs()
        {
            try
            {
                var apiResponse = await Http.GetFromJsonAsync<ApiResponse>("http://localhost:5077/api/fournisseur");
                if (apiResponse is { IsSuccess: true, Data: not null })
                {
                    var jsonData = apiResponse.Data.ToString();
                    return JsonSerializer.Deserialize<ICollection<FournisseurDto>>(jsonData, new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    }) ?? new List<FournisseurDto>();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur lors du chargement des fournisseurs : {ex.Message}");
            }
            return new List<FournisseurDto>();
        }
    }
}