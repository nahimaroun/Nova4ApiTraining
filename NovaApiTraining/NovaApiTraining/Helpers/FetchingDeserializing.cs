using Newtonsoft.Json;

public class DataFetcher
{
    private readonly HttpClient _httpClient;
    private readonly ILogger<DataFetcher> _logger;

    public DataFetcher(HttpClient httpClient, ILogger<DataFetcher> logger)
    {
        _httpClient = httpClient;
        _logger = logger;
    }

    public async Task<T> FetchData<T>(string apiUrl)
    {
        try
        {
            HttpResponseMessage response = await _httpClient.GetAsync(apiUrl);
            if (response.IsSuccessStatusCode)
            {
                string jsonResponse = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<T>(jsonResponse);
            }
            else
            {
                _logger.LogWarning($"Failed to fetch data from {apiUrl}. Status code: {response.StatusCode}");
                return default(T);
            }
        }
        catch (Exception ex)
        {
            _logger.LogError($"An error occurred while fetching data from {apiUrl}: {ex.Message}");
            return default(T);
        }
    }
}