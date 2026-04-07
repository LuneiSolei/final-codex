using System.ComponentModel.DataAnnotations;
using Microsoft.Extensions.Options;

namespace FinalCodex.XivApi.Core.Options;

public class XivApiOptions
{
    [Required, ValidateObjectMembers]
    public required string BaseUrl { get; set; }
    
    [Required, ValidateObjectMembers]
    public required string Scheme { get; set; }
    
    [Required, ValidateObjectMembers]
    public required Endpoints Endpoints { get; set; }
}