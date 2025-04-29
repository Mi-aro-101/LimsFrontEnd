using LimsFrontEnd.Models.Reactif;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;
using LimsUtils.Api;
using System.Text.Json;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LimsFrontEnd.Pages.ReportReactif
{
    public class CUBaseComponent : ComponentBase
    {
        [Inject]
        protected HttpClient? Http { get; set; }

        [Inject]
        protected NavigationManager? NavigationManager { get; set; }

        protected async Task<ICollection<ReactifDto>> LoadReactifs()
        {
            try
            {
                var apiResponse = await Http.GetFromJsonAsync<ApiResponse>("http://localhost:5077/api/reactifs");
                if (apiResponse is { IsSuccess: true, Data: not null })
                {
                    var jsonData = apiResponse.Data.ToString();
                    return JsonSerializer.Deserialize<ICollection<ReactifDto>>(jsonData, new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    }) ?? new List<ReactifDto>();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur lors du chargement des réactifs : {ex.Message}");
            }
            return new List<ReactifDto>();
        }
    }
}