using System.ComponentModel.DataAnnotations;
using Microsoft.Extensions.Options;

namespace FinalCodex.SharedLibrary.Settings;

public class SharedLibrarySettings
{
    [Required]
    [ValidateObjectMembers]
    public XivApi XivApi { get; set; }
}