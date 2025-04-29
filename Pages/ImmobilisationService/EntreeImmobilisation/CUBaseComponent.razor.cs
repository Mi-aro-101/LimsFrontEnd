using LimsFrontEnd.Models.Immobilisation;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;
using LimsUtils.Api;
using System.Text.Json;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LimsFrontEnd.Pages.EntreeImmobilisation
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
                var apiResponse = await Http.GetFromJsonAsync<ApiResponse>("http://localhost:5077/api/immobilisations");
                if (apiResponse is { IsSuccess: true, Data: not null })
                {
                    var jsonData = apiResponse.Data.ToString();
                    return JsonSerializer.Deserialize<ICollection<ImmobilisationDto>>(jsonData, new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    }) ?? new List<ImmobilisationDto>();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur lors du chargement des immobilisations : {ex.Message}");
            }
            return new List<ImmobilisationDto>();
        }

        protected async Task<ICollection<FournisseurDto>> LoadFournisseurs()
        {
            try
            {
                var apiResponse = await Http.GetFromJsonAsync<ApiResponse>("http://localhost:5077/api/fournisseurs");
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