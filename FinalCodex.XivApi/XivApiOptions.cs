using System.ComponentModel.DataAnnotations;
using Microsoft.Extensions.Options;

namespace FinalCodex.XivApi;

public class XivApiOptions
{
    [Required]
    [ValidateObjectMembers]
    public required XivApiOptions XivApi { get; set; }
}