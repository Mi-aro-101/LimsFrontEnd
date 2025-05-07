namespace LimsFrontEnd.Services;
public interface ISessionService
{
    Task<string> GetItemAsync(string key);
    Task SetItemAsync(string key, string value);
    Task RemoveItemAsync(string key);
}