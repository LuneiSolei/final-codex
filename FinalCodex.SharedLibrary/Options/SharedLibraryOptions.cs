using System.ComponentModel.DataAnnotations;
using Microsoft.Extensions.Options;

namespace FinalCodex.SharedLibrary.Options;

public class SharedLibraryOptions
{
    [Required]
    [ValidateObjectMembers]
    public required XivApiOptions XivApiOptions { get; set; }
}