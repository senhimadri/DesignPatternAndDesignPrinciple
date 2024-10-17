namespace BuilderDesignPatternBySudoCODE.Product;

public class URL
{
    public string? Protocol { get; set; }
    public string? Host { get; set; }
    public int Port { get; set; }
    public string? Path { get; set; } 
    public Dictionary<string, string>? QueryParams { get; set; }

    public override string ToString()
    {
        string queryParams = QueryParams != null && QueryParams.Count > 0

                            ? "?" + string.Join("&", QueryParams.Select(kv => $"{kv.Key}={kv.Value}")) 
                            : string.Empty;

        return $"{Protocol}://{Host}:{Port}/{Path}{queryParams}";
    }
}
