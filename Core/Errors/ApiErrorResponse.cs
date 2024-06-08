using Newtonsoft.Json;

namespace LoanworksBackend.Core.Errors;

public class ApiErrorResponse
{
    public ErrorDescription Error { get; set; } = new();
}

public class ErrorDescription
{
    public string? Code { get; set; }
    public string? Message { get; set; }
    [JsonProperty(PropertyName = "type")]
    public string ErrorType { get; set; } = string.Empty;
    [JsonProperty(PropertyName = "details")]
    public List<ErrorDetail>? ErrorDetails { get; set; }
}

public class ErrorDetail
{
    [JsonProperty(PropertyName = "id", Order = 10)]
    public string? CodeId { get; set; }
    public string Code { get; set; } = string.Empty;
    public string Value { get; set; } = string.Empty;
    public string Message { get; set; } = string.Empty;
    public string? Type { get; set; }
    [JsonProperty(PropertyName = "data")]
    public Dictionary<string, string>? AdditionalData { get; set; }
}