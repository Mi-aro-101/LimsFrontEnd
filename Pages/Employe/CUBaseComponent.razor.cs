using System.Net.Http.Json;
using LimsFrontEnd.Models;
using LimsFrontEnd.Utils;
using System.Text.Json;
using Microsoft.AspNetCore.Components;

namespace LimsFrontEnd.Components;

public class CUBaseComponent : ComponentBase
{
    [Inject] 
    protected HttpClient? Http { get; set; }
    protected string url = "http://localhost:5077/api/";
    protected async Task<ICollection<DepartementDto>> LoadDepartement()
    {
        ICollection<DepartementDto> departements = new List<DepartementDto>();
        try
        {
            ApiResponse? apiResponse;
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            apiResponse = await Http.GetFromJsonAsync<ApiResponse>(url+"departement/all");
            apiResponse.HandleResponse<List<DepartementDto>>();
            departements = (List<DepartementDto>)apiResponse.Data;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error while calling LoadDepartement {ex.Message}");
        }

        return departements;
    }

    protected async Task<ICollection<PosteDto>> LoadPoste()
    {
        ICollection<PosteDto> postes = new List<PosteDto>();
        try
        {
            ApiResponse? apiResponse;
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            apiResponse = await Http.GetFromJsonAsync<ApiResponse>(url+"poste/all");
            apiResponse.HandleResponse<List<PosteDto>>();
            postes = (List<PosteDto>)apiResponse.Data;
            // Set initial values in case it is set to null if I do not touch it
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error while calling LoadPoste : {ex.Message}");
        }

        return postes;
    }
}