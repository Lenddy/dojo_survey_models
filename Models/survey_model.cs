using System.ComponentModel.DataAnnotations;
namespace survey_model.Models;
#pragma warning disable CS8618
public class info{
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