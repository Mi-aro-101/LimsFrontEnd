using System.Net.Http.Json;
using LimsFrontEnd.Models;
using LimsUtils.Api;
using System.Text.Json;
using Microsoft.AspNetCore.Components;

namespace LimsFrontEnd.Components;

public class CUUtilisateurBaseComponent : ComponentBase
{
    [Inject] 
    protected HttpClient Http { get; set; } = new HttpClient();
    protected string url = "http://localhost:5077/api/";
    protected string exception = "";
    protected async Task<ICollection<RoleDto>> LoadRole()
    {
        ICollection<RoleDto> roles = new List<RoleDto>();
        try
        {
            ApiResponse? apiResponse;
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            apiResponse = await Http.GetFromJsonAsync<ApiResponse>(url+"role/all");
            if(apiResponse?.IsSuccess == false || apiResponse == null)
            {
                HttpResponseMessage response = await Http.GetAsync(url+"role/all");
                exception = await response.Content.ReadAsStringAsync();
            }
            else if (apiResponse?.Data != null)
            {
                apiResponse.HandleResponse<List<RoleDto>>();
                roles = (List<RoleDto>)apiResponse.Data;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error while calling LoadRole {ex.Message} on calling : {url+"role/all"}");
        }

        return roles;
    }


}