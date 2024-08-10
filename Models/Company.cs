using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Nowadays.Models;

public class Company
{

    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? companyID { get; set; }

    public string name { get; set; } = null!;

    [BsonElement("employees")]
    [JsonPropertyName("employees")]
    public List<string> employeeIds { get; set; } = null!;

}
