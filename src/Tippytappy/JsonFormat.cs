using System.Text.Json.Serialization;

namespace Tippytappy;

public class TiptapJsonNode
{
    [JsonPropertyName("type")] public string Type { get; set; } = default!;

    [JsonPropertyName("content")] public IReadOnlyList<TiptapJsonNode>? Content { get; set; }
    
    [JsonPropertyName("text")] public string? Text { get; set; }

    [JsonPropertyName("attrs")] public IReadOnlyDictionary<string, object>? Attrs { get; set; }
    
    [JsonPropertyName("marks")] public IReadOnlyList<TiptapJsonNode>? Marks { get; set; }
}