using System.Text.Json.Serialization;

namespace LimsFrontEnd.Utils;

public class Formule
{
    public static Formule FromString(string formule)
    {
        Formule result = new Formule();
        string[] formuleString = formule.Split(Environment.NewLine.ToCharArray());
        string variables = formuleString[0].Split("=")[1];
        string[] variablesName = variables.Replace(" ", "").Split(",");
        foreach(string variable in variablesName)
        {
            result.Variable.Add(variable, 0);
        }
        result.LoadCondition(formuleString);

        return result;
    }

    public void LoadCondition(string[] formules)
    {
        for(int i = 1 ; i < formules.Length-1 ; i++)
        {
            string[] row = formules[i].Replace(" ", "").Split(";;"); 
            string condition = row[0];
            string formula = row[1];
            this.ConditionFormula.Add(condition, formula);
        }
    }

    [JsonPropertyName("variable")]
    public Dictionary<string, double> Variable { get; set; } = new Dictionary<string, double>();
    [JsonPropertyName("tarif")]
    public Double? Tarif { get; set; }
    [JsonPropertyName("formuleChosed")]
    public string FormuleChosed { get; set; }
    public Dictionary<string, string> ConditionFormula { get; set; } = new Dictionary<string, string>();
}