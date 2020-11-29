using System.Text.Json.Serialization;

namespace Managing_Adults.Models {
public class User {
    [JsonPropertyName("userName")]public string UserName { get; set; }
   
    [JsonPropertyName("role")]public string Role { get; set; }
    [JsonPropertyName("password")]public string Password { get; set; }
}
}