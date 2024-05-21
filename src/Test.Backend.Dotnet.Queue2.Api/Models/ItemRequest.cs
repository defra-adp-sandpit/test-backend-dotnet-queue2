using System.ComponentModel.DataAnnotations;

namespace Test.Backend.Dotnet.Queue2.Api.Models;

public class ItemRequest
{
    public int? Id { get; set; }
    [Required]
    public required string Name { get; set; }
}

