using System.Text.Json.Serialization;

namespace LimsFrontEnd.Models.Reactif
{
    public class SortieReactifDto
    {
        [JsonPropertyName("idSortie")]
        public int IdSortie { get; set; }

        [JsonPropertyName("quantite")]
        public double Quantite { get; set; }

        [JsonPropertyName("dateSortie")]
        public DateTime DateSortie { get; set; } = DateTime.Now;

        [JsonPropertyName("idDepartement")]
        public int? IdDepartement { get; set; }

        [JsonPropertyName("departement")]
        public DepartementDto? Departement { get; set; }

        [JsonPropertyName("idReactif")]
        public int IdReactif { get; set; }

        [JsonPropertyName("reactif")]
        public ReactifDto? Reactif { get; set; }

        [JsonPropertyName("idObjetSortieReactif")]
        public int IdObjetSortieReactif { get; set; }

        [JsonPropertyName("objetSortieReactif")]
        public ObjetSortieReactifDto? ObjetSortieReactif { get; set; }
    }
}
