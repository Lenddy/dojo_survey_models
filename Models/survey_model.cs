using System.ComponentModel.DataAnnotations;
namespace survey_model.Models;
// * helps you not get a warning message in the terminal
#pragma warning disable CS8618
public class info{
    // * validates all you fields(properties)
    [Required]
    [MinLength(2,ErrorMessage ="you need at least 2 characters")]

    public string Name{get;set;}
    [Required]
    public string Location{get;set;}
        [Required]
    public string Language{get;set;}
    [MinLength(20)]
    public string? Comment {get;set;}
}