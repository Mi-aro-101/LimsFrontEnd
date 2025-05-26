using System.Text.Json.Serialization;

namespace LimsFrontEnd.Models
{
    public class DashboardDelaiMobileDto
    {
        [JsonPropertyName("semaines")]
        public List<SemaineDto>? Semaines { get; set; }     
        [JsonPropertyName("details")]   
        public List<DetailMobileDto>? Details { get; set; }
    }
}