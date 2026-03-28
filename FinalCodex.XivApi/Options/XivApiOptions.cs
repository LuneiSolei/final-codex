using System.ComponentModel.DataAnnotations;
using Microsoft.Extensions.Options;

namespace FinalCodex.XivApi.Options;

public class XivApiOptions
{
    [Required, ValidateObjectMembers]
    public required string BaseUrl { get; set; }
    
    [Required, ValidateObjectMembers]
    public required Endpoints Endpoints { get; set; }
}