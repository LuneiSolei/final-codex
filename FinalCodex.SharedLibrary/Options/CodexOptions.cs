using System.ComponentModel.DataAnnotations;
using Microsoft.Extensions.Options;

namespace FinalCodex.SharedLibrary.Options;

public class CodexOptions
{
    [Required]
    [ValidateObjectMembers]
    public required XivApiOptions XivApiOptions { get; set; }
}